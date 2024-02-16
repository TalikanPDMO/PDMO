using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.Logging;
using Intersect.Network.Packets.Server;
using Intersect.Server.Database;
using Intersect.Server.Database.PlayerData.Players;
using Intersect.Server.Entities.Combat;
using Intersect.Server.Entities.Conditions;
using Intersect.Server.Entities.Pathfinding;
using Intersect.Server.General;
using Intersect.Server.Maps;
using Intersect.Server.Networking;
using Intersect.Utilities;

namespace Intersect.Server.Entities
{

    public partial class Npc : Entity
    {

        //Spell casting
        public long CastFreq;
        public long LastCastTimer = 0;
        public List<NpcSpellRule> SpellRules = new List<NpcSpellRule>();

        /// <summary>
        /// Damage Map - Keep track of who is doing the most damage to this npc and focus accordingly
        /// </summary>
        public ConcurrentDictionary<Entity, long> DamageMap = new ConcurrentDictionary<Entity, long>();

        public ConcurrentDictionary<Guid, bool> LootMap = new ConcurrentDictionary<Guid, bool>();

        public Guid[] LootMapCache = Array.Empty<Guid>();

        public NpcPhase CurrentPhase = null;
        public long CurrentPhaseTimer;

        /// <summary>
        /// Returns the entity that ranks the highest on this NPC's damage map.
        /// </summary>
        public Entity DamageMapHighest { 
            get {
                long damage = 0;
                Entity top = null;
                foreach (var pair in DamageMap)
                {
                    if (pair.Value > damage)
                    {
                        top = pair.Key;
                        damage = pair.Value;
                    }
                }
                return top;
            } 
        }

        public bool Despawnable;

        //Moving
        public long LastRandomMove;
        public int RandomMoveValue = -1;
        public int CurrentRandomMove = 0;
        private int OpposingDir = -1;

        //Pathfinding
        private Pathfinder mPathFinder;

        private Task mPathfindingTask;

        public byte Range;

        //Respawn/Despawn
        public long RespawnTime;

        public long FindTargetWaitTime;
        public int FindTargetDelay = 500;

        private int mTargetFailCounter = 0;
        private int mTargetFailMax = 10;

        private int mResetDistance = 0;
        private int mResetCounter = 0;
        private int mResetMax = 100;
        private bool mResetting = false;
        private byte mResetPhase = 0; //0 for no reset, 1 when reset destination is reached, 2 when we are waiting our regen to end before reset phase

        /// <summary>
        /// The map on which this NPC was "aggro'd" and started chasing a target.
        /// </summary>
        public MapInstance AggroCenterMap;

        /// <summary>
        /// The X value on which this NPC was "aggro'd" and started chasing a target.
        /// </summary>
        public int AggroCenterX;

        /// <summary>
        /// The Y value on which this NPC was "aggro'd" and started chasing a target.
        /// </summary>
        public int AggroCenterY;

        /// <summary>
        /// The Z value on which this NPC was "aggro'd" and started chasing a target.
        /// </summary>
        public int AggroCenterZ;

        /// <summary>
        /// The map on which this NPC was spawned.
        /// </summary>
        public MapInstance SpawnMap;

        /// <summary>
        /// The X value on which this NPC was spawned.
        /// </summary>
        public int SpawnX;

        /// <summary>
        /// The Y value on which this NPC was spawned.
        /// </summary>
        public int SpawnY;

        public Npc(NpcBase myBase, bool despawnable = false, int level = 0) : base()
        {
            Name = myBase.Name;
            Sprite = myBase.Sprite;
            Color = myBase.Color;
            Level = level != 0 ? level : myBase.Level;
            Base = myBase;
            Despawnable = despawnable;

            var lvlGap = Level - myBase.Level;
            int vitalcount = (int)Vitals.VitalCount;
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                //i+2 for LevelScaling because 0 and 1 are Health/Mana
                var baseStat = (int)(myBase.Stats[i] * (1 + lvlGap * myBase.LevelScalings[i + vitalcount]));
                if (baseStat < 1)
                {
                    baseStat = 1;
                }
                BaseStats[i] = baseStat;
                Stat[i] = new Stat((Stats) i, this);
            }
            for (var i = 0; i < NpcBase.MAX_ELEMENTAL_TYPES; i++)
            {
                ElementalTypes[i] = (ElementalType)Base.ElementalTypes[i];
            }

            var spellSlot = 0;
            bool needRules = Base.SpellRules.Count == 0;
            for (var I = 0; I < Base.Spells.Count; I++)
            {
                var slot = new SpellSlot(spellSlot);
                slot.Set(new Spell(Base.Spells[I]));
                Spells.Add(slot);
                spellSlot++;
                if (needRules)
                {
                    SpellRules.Add(new NpcSpellRule());
                }
                else
                {
                    SpellRules.Add(Base.SpellRules[I]);
                }  
            }

            //Give NPC Drops
            var itemSlot = 0;
            foreach (var drop in myBase.Drops)
            {
                var slot = new InventorySlot(itemSlot);
                slot.Set(new Item(drop.ItemId, drop.Quantity));
                slot.DropChance = drop.Chance;
                slot.DropAmountRandom = drop.Random;
                slot.DropChanceIterative = drop.Iterative;
                Items.Add(slot);
                itemSlot++;
            }

            for (var i = 0; i < vitalcount; i++)
            {
                var maxvital = (int)(myBase.MaxVital[i] * (1 + lvlGap * myBase.LevelScalings[i]));
                SetMaxVital(i, maxvital);
                SetVital(i, maxvital);
            }

            Range = (byte) myBase.SightRange;
            mPathFinder = new Pathfinder(this);
        }

        public NpcBase Base { get; private set; }

        private bool IsStunnedOrSleeping => CachedStatuses.Any(PredicateStunnedOrSleeping);

        private bool IsUnableToCastSpells => CachedStatuses.Any(PredicateUnableToCastSpells);

        public override EntityTypes GetEntityType()
        {
            return EntityTypes.GlobalEntity;
        }

        public override void Die(bool generateLoot = true, Entity killer = null, bool isDespawn = false)
        {
            lock (EntityLock) {

                // Do it before base.Die because we need the damagemap to be not cleared
                foreach (var en in DamageMap.Keys)
                {
                    if (en is Player p && p.FightingListNpcs.TryGetValue(Base.Id, out var npcs))
                    {
                        if (npcs.TryRemove(this, out _) && npcs.Count == 0)
                        {
                            p.FightingListNpcs.TryRemove(Base.Id, out var removed);
                            p.FightingNpcBaseIds.TryRemove(Base.Id, out _);
                        }
                    }
                }

                base.Die(generateLoot, killer);

                AggroCenterMap = null;
                AggroCenterX = 0;
                AggroCenterY = 0;
                AggroCenterZ = 0;


                MapInstance.Get(MapId).RemoveEntity(this);
                PacketSender.SendEntityDie(this, isDespawn);
                PacketSender.SendEntityLeave(this);
            }
        }

        public bool TargetHasStealth(Entity target)
        {
            return target == null || target.CachedStatuses.Any(s => s.Type == StatusTypes.Stealth);
        }

        //Targeting
        public void AssignTarget(Entity en)
        {
            var oldTarget = Target;

            // Are we resetting? If so, do not allow for a new target.
            var pathTarget = mPathFinder?.GetTarget();
            if (AggroCenterMap != null && pathTarget != null &&
                pathTarget.TargetMapId == AggroCenterMap.Id && pathTarget.TargetX == AggroCenterX && pathTarget.TargetY == AggroCenterY)
            {
                if (en == null)
                {
                                    return;

                }
                else
                {
                    return;

                }
            }

            //Why are we doing all of this logic if we are assigning a target that we already have?
            if (en != null && en != Target)
            {
                // Can't assign a new target if taunted, unless we're resetting their target somehow.
                // Also make sure the taunter is in range.. If they're dead or gone, we go for someone else!
                if ((pathTarget != null && AggroCenterMap != null && (pathTarget.TargetMapId != AggroCenterMap.Id || pathTarget.TargetX != AggroCenterX || pathTarget.TargetY != AggroCenterY)))
                {
                    foreach (var status in CachedStatuses)
                    {
                        if (status.Type == StatusTypes.Taunt && en != status.Attacker && GetDistanceTo(status.Attacker) != 9999)
                        {
                            return;
                        }
                    }
                }

                if (en.GetType() == typeof(Projectile))
                {
                    if (((Projectile)en).Owner != this && !TargetHasStealth((Projectile)en))
                    {
                        Target = ((Projectile)en).Owner;
                    }
                }
                else
                {
                    if (en.GetType() == typeof(Npc))
                    {
                        if (((Npc)en).Base == Base)
                        {
                            if (Base.AttackAllies == false)
                            {
                                return;
                            }
                        }
                    }

                    if (en.GetType() == typeof(Player))
                    {
                        //TODO Make sure that the npc can target the player
                        if (this != en && !TargetHasStealth(en))
                        {
                            Target = en;
                        }
                    }
                    else
                    {
                        if (this != en && !TargetHasStealth(en))
                        {
                            Target = en;
                        }
                    }
                }

                // Are we configured to handle resetting NPCs after they chase a target for a specified amount of tiles?
                if (Options.Npc.AllowResetRadius)
                {
                    // Are we configured to allow new reset locations before they move to their original location, or do we simply not have an original location yet?
                    if (Options.Npc.AllowNewResetLocationBeforeFinish || AggroCenterMap == null)
                    {
                        AggroCenterMap = Map;
                        AggroCenterX = X;
                        AggroCenterY = Y;
                        AggroCenterZ = Z;
                    }
                }
            }
            else
            {
                Target = en;
            }
            
            if (Target != oldTarget)
            {
                CombatTimer = Timing.Global.Milliseconds + Options.CombatTime;
                mResetPhase = 0;
                PacketSender.SendNpcAggressionToProximity(this);
            }
            mTargetFailCounter = 0;
        }

        public void RemoveFromDamageMap(Entity en)
        {
            DamageMap.TryRemove(en, out _);
        }

        public void RemoveTarget()
        {
            AssignTarget(null);
        }

        public override int CalculateAttackTime()
        {
            if (CurrentPhase != null)
            {
                if ((CurrentPhase.AttackSpeedModifier ?? Base.AttackSpeedModifier) == 1) //Static
                {
                    return CurrentPhase.AttackSpeedValue ?? Base.AttackSpeedValue;
                }
            }
            else
            {
                if (Base.AttackSpeedModifier == 1) //Static
                {
                    return Base.AttackSpeedValue;
                }
            }
            

            return base.CalculateAttackTime();
        }

        public override bool CanAttack(Entity entity, SpellBase spell)
        {
            if (!base.CanAttack(entity, spell))
            {
                return false;
            }

            if (entity.GetType() == typeof(EventPageInstance))
            {
                return false;
            }

            //Check if the attacker is stunned or blinded.
            foreach (var status in CachedStatuses)
            {
                if (status.Type == StatusTypes.Stun || status.Type == StatusTypes.Sleep)
                {
                    return false;
                }
            }

            if (TargetHasStealth(entity))
            {
                return false;
            }

            if (entity.GetType() == typeof(Resource))
            {
                if (!entity.Passable)
                {
                    return false;
                }
            }
            else if (entity.GetType() == typeof(Npc))
            {
                return CanNpcCombat(entity, spell != null && spell.Combat.Friendly) || entity == this;
            }
            else if (entity.GetType() == typeof(Player))
            {
                var player = (Player) entity;
                var friendly = spell != null && spell.Combat.Friendly;
                if (friendly && IsAllyOf(player))
                {
                    return true;
                }

                if (!friendly && !IsAllyOf(player))
                {
                    return true;
                }

                return false;
            }

            return true;
        }

        public override void TryAttack(Entity target)
        {
            if (target.IsDisposed)
            {
                return;
            }

            if (!CanAttack(target, null))
            {
                return;
            }
            var attackrange = CurrentPhase?.AttackRange ?? Base.AttackRange;
            var needDir = -1;
            if (attackrange > 0)
            {
                if (GetDistanceTo(target) > attackrange)
                {
                    return;
                }
                var dirToEnemy = DirToEnemy(target, true);
                if (dirToEnemy != Dir)
                {
                    needDir = dirToEnemy;
                }
            }
            else
            {
                if (!IsOneBlockAway(target))
                {
                    return;
                }

                if (!IsFacingTarget(target))
                {
                    needDir = DirToEnemy(target, true);
                }
            }
            
            var deadAnimations = new List<KeyValuePair<Guid, sbyte>>();
            var aliveAnimations = new List<KeyValuePair<Guid, sbyte>>();

            //We were forcing at LEAST 1hp base damage.. but then you can't have guards that won't hurt the player.
            //https://www.ascensiongamedev.com/community/bug_tracker/intersect/npc-set-at-0-attack-damage-still-damages-player-by-1-initially-r915/
            if (AttackTimer < Globals.Timing.Milliseconds && 
                (SpellRules.Count == 0 || Globals.Timing.Milliseconds > LastCastTimer + SpellRules[SpellCastSlot].MinAfterTimer))
            {
                //Change dir toward enemy only when the attack is possible, not before. If no direction needed, needDir is -1
                ChangeDir(needDir);

                if (target is Player penemy)
                {
                    penemy.FightingNpcBaseIds.AddOrUpdate(Base.Id, CombatTimer, (guid, t) => CombatTimer);
                    var npclist = penemy.FightingListNpcs.GetOrAdd(Base.Id, new ConcurrentDictionary<Npc, AttackInfo>());
                    npclist.AddOrUpdate(this, npc => null, (npc, info) => info);
                }
                if (CurrentPhase != null)
                {
                    // if any members of CurrentPhase is null using ??, we use the base member instead
                    if ((CurrentPhase.AttackAnimation ?? Base.AttackAnimation) != null)
                    {
                        if (attackrange > 0)
                        {
                            PacketSender.SendAnimationToProximity(
                                   CurrentPhase.AttackAnimationId ?? Base.AttackAnimationId, 1, target.Id, target.MapId, 0, 0, (sbyte)Dir
                                );
                        }
                        else
                        {
                            PacketSender.SendAnimationToProximity(
                                CurrentPhase.AttackAnimationId ?? Base.AttackAnimationId, -1, Guid.Empty, target.MapId, (byte)target.X, (byte)target.Y,
                                (sbyte)Dir
                            );
                        } 
                    }
                    base.TryAttack(
                        target, CurrentPhase.Damage ?? Base.Damage, 0, (DamageType)(CurrentPhase.DamageType ?? Base.DamageType),
                        (Stats)(CurrentPhase.ScalingStat ?? Base.ScalingStat), CurrentPhase.Scaling ?? Base.Scaling,
                        CurrentPhase.CritChance ?? Base.CritChance, CurrentPhase.CritMultiplier ?? Base.CritMultiplier,
                        deadAnimations, aliveAnimations);
                }
                else
                {
                    if (Base.AttackAnimation != null)
                    {
                        if (attackrange > 0)
                        {
                            PacketSender.SendAnimationToProximity(
                                    Base.AttackAnimationId, 1, target.Id, target.MapId, 0, 0, (sbyte)Dir
                                );
                        }
                        else
                        {
                            PacketSender.SendAnimationToProximity(
                                Base.AttackAnimationId, -1, Guid.Empty, target.MapId, (byte)target.X, (byte)target.Y,
                                (sbyte)Dir
                            );
                        } 
                    }
                    base.TryAttack(
                        target, Base.Damage, 0, (DamageType)Base.DamageType, (Stats)Base.ScalingStat, Base.Scaling,
                        Base.CritChance, Base.CritMultiplier, deadAnimations, aliveAnimations);
                }
                var attackTime = CalculateAttackTime();
                MoveTimer = Globals.Timing.Milliseconds + (long)(attackTime * Options.Combat.AttackAnimationTimeRatio);
                CastFreq = Globals.Timing.Milliseconds + attackTime;
                PacketSender.SendEntityAttack(this, attackTime);
            }
        }

        public bool CanNpcCombat(Entity enemy, bool friendly = false)
        {
            //Check for NpcVsNpc Combat, both must be enabled and the attacker must have it as an enemy or attack all types of npc.
            if (!friendly)
            {
                if (enemy != null && enemy.GetType() == typeof(Npc) && Base != null)
                {
                    if (((Npc) enemy).Base.NpcVsNpcEnabled == false)
                    {
                        return false;
                    }

                    if (Base.AttackAllies && ((Npc) enemy).Base == Base)
                    {
                        return true;
                    }

                    for (var i = 0; i < Base.AggroList.Count; i++)
                    {
                        if (NpcBase.Get(Base.AggroList[i]) == ((Npc) enemy).Base)
                        {
                            return true;
                        }
                    }

                    return false;
                }

                if (enemy != null && enemy.GetType() == typeof(Player))
                {
                    return true;
                }
            }
            else
            {
                if (enemy != null &&
                    enemy.GetType() == typeof(Npc) &&
                    Base != null &&
                    ((Npc) enemy).Base == Base &&
                    Base.AttackAllies == false)
                {
                    return true;
                }
                else if (enemy != null && enemy.GetType() == typeof(Player))
                {
                    return false;
                }
            }

            return false;
        }

        private static bool PredicateStunnedOrSleeping(Status status)
        {
            switch (status?.Type)
            {
                case StatusTypes.Sleep:
                case StatusTypes.Stun:
                    return true;

                case StatusTypes.Silence:
                case StatusTypes.None:
                case StatusTypes.Snare:
                case StatusTypes.Blind:
                case StatusTypes.Stealth:
                case StatusTypes.Transform:
                case StatusTypes.Cleanse:
                case StatusTypes.Invulnerable:
                case StatusTypes.Shield:
                case StatusTypes.OnHit:
                case StatusTypes.Taunt:
                case null:
                    return false;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static bool PredicateUnableToCastSpells(Status status)
        {
            switch (status?.Type)
            {
                case StatusTypes.Silence:
                case StatusTypes.Sleep:
                case StatusTypes.Stun:
                    return true;

                case StatusTypes.None:
                case StatusTypes.Snare:
                case StatusTypes.Blind:
                case StatusTypes.Stealth:
                case StatusTypes.Transform:
                case StatusTypes.Cleanse:
                case StatusTypes.Invulnerable:
                case StatusTypes.Shield:
                case StatusTypes.OnHit:
                case StatusTypes.Taunt:
                case null:
                    return false;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override int CanMove(int moveDir)
        {
            var canMove = base.CanMove(moveDir);
            if ((canMove == -1 || canMove == -4) && IsFleeing() && Options.Instance.NpcOpts.AllowResetRadius)
            {
                var tile = new TileHelper(MapId, X, Y);

                if (tile.TranslateDir(moveDir))
                {
                    //If this would move us past our reset radius then we cannot move.
                    var dist = GetDistanceBetween(AggroCenterMap, tile.GetMap(), AggroCenterX, tile.GetX(), AggroCenterY, tile.GetY());
                    if (dist > Math.Max(Options.Npc.ResetRadius, Base.ResetRadius))
                    {
                        return -2;
                    }
                }
            }
            return canMove;
        }


        private bool TryCastSpells()
        {
            var target = Target;

            if (target == null || mPathFinder.GetTarget() == null
                || AttackTimer > Globals.Timing.Milliseconds || CastTime > Globals.Timing.Milliseconds
                || CastFreq > Globals.Timing.Milliseconds)
            {
                return false;
            }

            if (Base.Spells == null || Base.Spells.Count <= 0 || Spells.Count <= 0)
            {
                return false;
            }

            // Check if NPC is stunned/sleeping or unable to cast spells
            if (IsStunnedOrSleeping || IsUnableToCastSpells)
            {
                return false;
            }

            var frequency = (CurrentPhase == null ? Base.SpellFrequency : (CurrentPhase.SpellFrequency ?? Base.SpellFrequency));
            if (frequency == 0)
            {
                return false;
            }
            //Update the frequency check only after basic verifications unrelated to cooldowns or rules
            CastFreq = Globals.Timing.Milliseconds + Options.Npc.SpellCastFrequencyCheck;

            if (Globals.Timing.Milliseconds < LastCastTimer + SpellRules[SpellCastSlot].MinAfterTimer)
            {
                // Last spell don't allow to cast yet, come back here in the next frequency check
                return false;
            }
            if (Randomization.Next(1, 101) > frequency)
            {
                // Our % chance don't allow to cast a spell this time, so we use a basic attack if possible. If not, we come back here in the next check
                return false;
            }

            var maxPriority = 0;
            var availableSpells = new List<SpellSlot>();
            var neededDirs = new List<int>();
            for (var i = 0; i < Spells.Count; i++)
            {
                int neededDir = -1;
                if (Globals.Timing.Milliseconds > LastCastTimer + SpellRules[i].MinBeforeTimer && SpellRules[i].Priority >= maxPriority)
                {
                    if (SpellCooldowns.ContainsKey(Spells[i].SpellId) && SpellCooldowns[Spells[i].SpellId] >= Globals.Timing.MillisecondsUTC)
                    {
                        continue;
                    }
                    var spellBase = SpellBase.Get(Spells[i].SpellId);
                    if (spellBase == null || spellBase.VitalCost == null)
                    {
                        continue;
                    }
                    var manacost = CalculateVitalStyle(spellBase.VitalCost[(int)Vitals.Mana], spellBase.VitalCostStyle[(int)Vitals.Mana], Vitals.Mana, target);
                    var healthcost = CalculateVitalStyle(spellBase.VitalCost[(int)Vitals.Health], spellBase.VitalCostStyle[(int)Vitals.Health], Vitals.Health, target);

                    //Max mana to 0 means that the npc has unlimited mana
                    if ((GetMaxVital(Vitals.Mana) != 0 && manacost > GetVital(Vitals.Mana))
                        || healthcost > GetVital(Vitals.Health))
                    {
                        continue;
                    }

                    var range = spellBase.Combat?.CastRange ?? 0;
                    var targetType = spellBase.Combat?.TargetType ?? SpellTargetTypes.Targeted;
                    var projectileBase = spellBase.Combat?.Projectile;

                    if (targetType == SpellTargetTypes.Anchored && spellBase.SpellType == SpellTypes.CombatSpell)
                    {
                        var dirsToHitTarget = AreaInRange(target, spellBase);
                        if (dirsToHitTarget.Count == 0)
                        {
                            // Target is unreachable with the projectile in any possible directions
                            continue;
                        }
                        else if (!dirsToHitTarget.Contains(Dir))
                        {
                            // Need to change dir for the projectile
                            neededDir = dirsToHitTarget[0];
                        }
                    }
                    else if (targetType == SpellTargetTypes.Targeted && !InRangeOf(target, range, spellBase.Combat.SquareRange))
                    {
                        // ReSharper disable once SwitchStatementMissingSomeCases
                        continue;
                    }
                    else if (targetType == SpellTargetTypes.Projectile && spellBase.SpellType == SpellTypes.CombatSpell && projectileBase != null)
                    {
                        var dirsToHitTarget = ProjectileInRange(target, projectileBase);
                        if (dirsToHitTarget.Count == 0)
                        {
                            // Target is unreachable with the projectile in any possible directions
                            continue;
                        }
                        else if (!dirsToHitTarget.Contains(Dir))
                        {
                            // Need to change dir for the projectile
                            neededDir = dirsToHitTarget[0];
                        }
                    }

                    if (SpellRules[i].Priority == maxPriority)
                    {
                        availableSpells.Add(Spells[i]);
                        neededDirs.Add(neededDir);
                    }
                    else if (SpellRules[i].Priority > maxPriority)
                    {
                        maxPriority = SpellRules[i].Priority;
                        availableSpells.Clear();
                        availableSpells.Add(Spells[i]);
                        neededDirs.Clear();
                        neededDirs.Add(neededDir);
                    }
                }
            }

            if (availableSpells.Count == 0)
            {
                return false;
            }


            // Pick a random spell
            var randomIndex = Randomization.Next(0, availableSpells.Count);
            var randomSpellId = availableSpells[randomIndex].SpellId;
            var randomSpellBase = SpellBase.Get(randomSpellId);

            CastTime = Globals.Timing.Milliseconds + randomSpellBase.CastDuration;
            LastCastTimer = CastTime;

            /*if (spellBase.VitalCost[(int) Vitals.Mana] > 0)
            {
                SubVital(Vitals.Mana, spellBase.VitalCost[(int) Vitals.Mana]);
            }
            else
            {
                AddVital(Vitals.Mana, -spellBase.VitalCost[(int) Vitals.Mana]);
            }

            if (spellBase.VitalCost[(int) Vitals.Health] > 0)
            {
                SubVital(Vitals.Health, spellBase.VitalCost[(int) Vitals.Health]);
            }
            else
            {
                AddVital(Vitals.Health, -spellBase.VitalCost[(int) Vitals.Health]);
            }*/

            if ((randomSpellBase.Combat?.Friendly ?? false) && randomSpellBase.SpellType != SpellTypes.WarpTo)
            {
                CastTarget = this;
            }
            else
            {
                CastTarget = target;
            }

            SpellCastSlot = availableSpells[randomIndex].Slot;

            ChangeDir(neededDirs[randomIndex]);
            //LastRandomMove = Globals.Timing.Milliseconds + Randomization.Next(1000, 3000);
            //RandomMoveValue = -1;

            if (randomSpellBase.CastAnimationId != Guid.Empty)
            {
                //Target Type 1 will be global entity
                PacketSender.SendAnimationToProximity(randomSpellBase.CastAnimationId, 1, Id, MapId, 0, 0, (sbyte) Dir);
            }

            if (randomSpellBase.CastTargetAnimationId != Guid.Empty)
            {
                if (randomSpellBase.SpellType == SpellTypes.CombatSpell)
                {
                    // Play casttarget animation only for Targeted and Anchored CombatSpells
                    if (randomSpellBase.Combat.TargetType == SpellTargetTypes.Anchored)
                    {
                        TileHelper tile = new TileHelper(MapId, X, Y);
                        if (tile.Translate(Projectile.GetRangeX(Dir, randomSpellBase.Combat.CastRange), Projectile.GetRangeY(Dir, randomSpellBase.Combat.CastRange)))
                        {
                            //Target Type -1 will be a tile
                            PacketSender.SendAnimationToProximity(randomSpellBase.CastTargetAnimationId, -1, Guid.Empty, tile.GetMapId(), (byte)tile.GetX(), (byte)tile.GetY(), (sbyte)Directions.Up);
                        }
                    }
                    else if (randomSpellBase.Combat.TargetType == SpellTargetTypes.Targeted)
                    {
                        //Target Type 1 will be global entity
                        PacketSender.SendAnimationToProximity(randomSpellBase.CastTargetAnimationId, 1, CastTarget.Id, CastTarget.MapId, 0, 0, (sbyte)Directions.Up);
                    }
                }
                else if (randomSpellBase.SpellType == SpellTypes.WarpTo)
                {
                    //Target Type 1 will be global entity
                    PacketSender.SendAnimationToProximity(randomSpellBase.CastTargetAnimationId, 1, CastTarget.Id, CastTarget.MapId, 0, 0, (sbyte)Directions.Up);
                }
            }

            PacketSender.SendEntityCastTime(this, randomSpellId);
            return true;
        }

        // Return the direction needed to hit the target, -1 if the target is unreachable
        public List<int> ProjectileInRange(Entity target, ProjectileBase projectileBase)
        {
            //Calculate World Tile of Me
            var xMe = X + Map.MapGridX * Options.MapWidth;
            var yMe = Y + Map.MapGridY * Options.MapHeight;

            //Calculate world tile of target
            var xTarget = target.X + target.Map.MapGridX * Options.MapWidth;
            var yTarget = target.Y + target.Map.MapGridY * Options.MapHeight;

            List<int> directions = new List<int>();

            for (byte x = 0; x < ProjectileBase.SPAWN_LOCATIONS_WIDTH; x++)
            {
                for (byte y = 0; y < ProjectileBase.SPAWN_LOCATIONS_HEIGHT; y++)
                {
                    for (byte d = 0; d < ProjectileBase.MAX_PROJECTILE_DIRECTIONS; d++)
                    {
                        if (projectileBase.SpawnLocations[x, y].Directions[d])
                        {
                            // Check for each possible directions : 0 1 2 3
                            for (byte npc_d = 0; npc_d < 4; npc_d++)
                            {
                                var projPosX = xMe + Projectile.FindProjectileRotationX(npc_d, x - 2, y - 2);
                                var projPosY = yMe + Projectile.FindProjectileRotationY(npc_d, x - 2, y - 2);

                                for (int r = 0; r <= projectileBase.Range; r++)
                                {
                                    var destX = projPosX + (int)Projectile.GetRangeX(Projectile.FindProjectileRotationDir(npc_d, d), r);
                                    var destY = projPosY + (int)Projectile.GetRangeY(Projectile.FindProjectileRotationDir(npc_d, d), r);
                                    if (destX == xTarget && destY == yTarget)
                                    {
                                        directions.Add(npc_d);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return directions;
        }

        // Return the direction needed to hit the target, -1 if the target is unreachable
        public List<int> AreaInRange(Entity target, SpellBase spellBase)
        {
            //Calculate World Tile of Me
            var xMe = X + Map.MapGridX * Options.MapWidth;
            var yMe = Y + Map.MapGridY * Options.MapHeight;

            //Calculate world tile of target
            var xTarget = target.X + target.Map.MapGridX * Options.MapWidth;
            var yTarget = target.Y + target.Map.MapGridY * Options.MapHeight;

            var radius = spellBase.Combat.HitRadius;

            List<int> directions = new List<int>();
            if (spellBase.Combat.Projectile?.Speed == 0)
            {
                var projectileBase = spellBase.Combat.Projectile;
                for (byte x = 0; x < ProjectileBase.SPAWN_LOCATIONS_WIDTH; x++)
                {
                    for (byte y = 0; y < ProjectileBase.SPAWN_LOCATIONS_HEIGHT; y++)
                    {
                        for (byte d = 0; d < ProjectileBase.MAX_PROJECTILE_DIRECTIONS; d++)
                        {
                            if (projectileBase.SpawnLocations[x, y].Directions[d])
                            {
                                // Check for each possible directions : 0 1 2 3
                                for (byte npc_d = 0; npc_d < 4; npc_d++)
                                {
                                    var areaPosX = xMe + Projectile.FindProjectileRotationX(npc_d, x - 2, y - 2)
                                        + (int)Projectile.GetRangeX(Projectile.FindProjectileRotationDir(npc_d, d), spellBase.Combat.CastRange);

                                    var areaPosY = yMe + Projectile.FindProjectileRotationY(npc_d, x - 2, y - 2)
                                        + (int)Projectile.GetRangeY(Projectile.FindProjectileRotationDir(npc_d, d), spellBase.Combat.CastRange);
                                    if (areaPosX == xTarget && areaPosY == yTarget)
                                    {
                                        directions.Add(npc_d);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (spellBase.Combat.CastRange == 0)
            {
                // Baisc AoE on self, no need to turn so we keep our Dir and only verify target is in range
                if (InRangeOf(target, spellBase.Combat.HitRadius, spellBase.Combat.SquareHitRadius))
                {
                    directions.Add(Dir);
                }
            }
            else
            {
                for (byte npc_d = 0; npc_d < 4; npc_d++)
                {
                    var areaPosX = xMe + Projectile.GetRangeX(npc_d, spellBase.Combat.CastRange);
                    var areaPosY = yMe + Projectile.GetRangeY(npc_d, spellBase.Combat.CastRange);
                    if (spellBase.Combat.SquareHitRadius)
                    {
                        for (int w = -radius; w <= radius; w++)
                        {
                            for (int h = -radius; h <= radius; h++)
                            {
                                if (areaPosX + w == xTarget && areaPosY + h == yTarget)
                                {
                                    directions.Add(npc_d);
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int w = -radius; w <= radius; w++)
                        {
                            for (int h = -radius; h <= radius; h++)
                            {
                                if (Math.Abs(w) + Math.Abs(h) <= radius && areaPosX + w == xTarget && areaPosY + h == yTarget)
                                {
                                    directions.Add(npc_d);
                                }
                            }
                        }
                    }
                    /*var npcTile = new TileHelper(MapId, X, Y);
                    if (npcTile.Translate(Projectile.GetRangeX(npc_d, spellBase.Combat.CastRange), Projectile.GetRangeY(npc_d, spellBase.Combat.CastRange)))
                    {
                        if (spellBase.Combat.SquareHitRadius)
                        {
                            for (int w = -radius; w <= radius; w++)
                            {
                                for (int h = -radius; h <= radius; h++)
                                {
                                    var areaTile = new TileHelper(npcTile.GetMapId(), npcTile.GetX(), npcTile.GetY());
                                    if (areaTile.Translate(w, h) && npcTile.GetX() == xTarget && npcTile.GetY() == yTarget)
                                    {
                                        PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, tile.GetMapId(), tile.GetX(), tile.GetY(), (sbyte)Directions.Up);
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int w = -radius; w <= radius; w++)
                            {
                                for (int h = -radius; h <= radius; h++)
                                {
                                    tile = new TileHelper(startMapId, startX, startY);
                                    if (Math.Abs(w) + Math.Abs(h) <= radius && tile.Translate(w, h))
                                    {
                                        PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, tile.GetMapId(), tile.GetX(), tile.GetY(), (sbyte)Directions.Up);
                                    }
                                }
                            }
                        }
                    }*/
                }    
            }
            return directions;
        }

        public bool IsFleeing()
        {
            if (Base.FleeHealthPercentage > 0)
            {
                var fleeHpCutoff = GetMaxVital(Vitals.Health) * ((float)Base.FleeHealthPercentage / 100f);
                if (GetVital(Vitals.Health) < fleeHpCutoff)
                {
                    return true;
                }
            }
            return false;
        }

        // TODO: Improve NPC movement to be more fluid like a player
        //General Updating
        public override void Update(long timeMs)
        {
            var lockObtained = false;
            try
            {
                Monitor.TryEnter(EntityLock, ref lockObtained);
                if (lockObtained)
                {
                    var curMapLink = MapId;
                    base.Update(timeMs);
                    var tempTarget = Target;

                    foreach (var status in CachedStatuses)
                    {
                        if (status.Type == StatusTypes.Stun || status.Type == StatusTypes.Sleep)
                        {
                            RandomMoveValue = -1;
                            return;
                        }
                    }

                    if (CurrentPhase?.Duration != null && Globals.Timing.Milliseconds > CurrentPhaseTimer)
                    {
                        EndCurrentPhase();
                        PacketSender.SendEntityStats(this);
                        PacketSender.SendEntityDataToProximity(this);
                    }

                    var fleeing = IsFleeing();

                    if (MoveTimer < Globals.Timing.Milliseconds)
                    {
                        var targetMap = Guid.Empty;
                        var targetX = 0;
                        var targetY = 0;
                        var targetZ = 0;

                        // Reset the current phase when we reached our reset destination and we are full vitals or if our regen is 0
                        if (mResetPhase == 1)
                        {
                            if ((IsFullVital(Vitals.Health) && IsFullVital(Vitals.Mana))
                            || (CurrentPhase?.VitalRegen != null && CurrentPhase.VitalRegen.Contains(0))
                            || (CurrentPhase == null && Base.VitalRegen.Contains(0)))
                            {
                                EndCurrentPhase();
                                PacketSender.SendEntityStats(this);
                                PacketSender.SendEntityDataToProximity(this);
                                mResetPhase = 0;
                                CanDespawn = true;
                            }
                            else
                            {
                                mResetPhase = 2;
                            }
                        }

                        //TODO Clear Damage Map if out of combat (target is null and combat timer is to the point that regen has started)
                        if (tempTarget != null && Timing.Global.Milliseconds > CombatTimer)
                        {
                            if (CheckForResetLocation(true))
                            {
                                if (Target != tempTarget)
                                {
                                    PacketSender.SendNpcAggressionToProximity(this);
                                }
                                RandomMoveValue = -1;
                                return;
                            }
                        }

                        // Are we resetting? If so, regenerate completely!
                        if (mResetting)
                        {
                            var distance = GetDistanceTo(AggroCenterMap, AggroCenterX, AggroCenterY);
                            // Have we reached our destination? If so, clear it.
                            if (distance < 1)
                            {
                                targetMap = Guid.Empty;

                                // Reset our aggro center so we can get "pulled" again.
                                AggroCenterMap = null;
                                AggroCenterX = 0;
                                AggroCenterY = 0;
                                AggroCenterZ = 0;
                                mPathFinder?.SetTarget(null);
                                mResetting = false;
                                mResetPhase = 1;      
                            }

                            ResetNpc(Options.Instance.NpcOpts.ContinuouslyResetVitalsAndStatuses);
                            tempTarget = Target;

                            if (distance != mResetDistance)
                            {
                                mResetDistance = distance;
                            }
                            else 
                            {
                                // Something is fishy here.. We appear to be stuck in a reset loop?
                                // Give it a few more attempts and kill the Npc is it keeps going!
                                mResetCounter++;
                                if (mResetCounter > mResetMax)
                                {
                                    // Kill the Npc, and simply do not drop any loot or give any credit.
                                    Die(false, null);
                                    mResetCounter = 0;
                                    mResetDistance = 0;
                                }
                            }
                            
                        }

                        if (tempTarget != null && (tempTarget.IsDead() || !InRangeOf(tempTarget, Options.MapWidth * 2)))
                        {
                            TryFindNewTarget(Timing.Global.Milliseconds, tempTarget.Id);
                            tempTarget = Target;
                        }

                        //Check if there is a target, if so, run their ass down.
                        if (tempTarget != null)
                        {
                            if (!tempTarget.IsDead() && CanAttack(tempTarget, null))
                            {
                                targetMap = tempTarget.MapId;
                                targetX = tempTarget.X;
                                targetY = tempTarget.Y;
                                targetZ = tempTarget.Z;
                                foreach (var targetStatus in tempTarget.CachedStatuses)
                                {
                                    if (targetStatus.Type == StatusTypes.Stealth)
                                    {
                                        targetMap = Guid.Empty;
                                        targetX = 0;
                                        targetY = 0;
                                        targetZ = 0;
                                    }
                                }
                            }
                        }
                        else //Find a target if able
                        {
                            // Check if attack on sight or have other npc's to target
                            TryFindNewTarget(timeMs);
                            tempTarget = Target;
                        }

                        if (targetMap != Guid.Empty)
                        {
                            //Check if target map is on one of the surrounding maps, if not then we are not even going to look.
                            if (targetMap != MapId)
                            {
                                var found = false;
                                foreach (var map in MapInstance.Get(MapId).SurroundingMaps)
                                {
                                    if (map.Id == targetMap)
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                                if (!found)
                                {
                                    targetMap = Guid.Empty;
                                }
                            }
                        }

                        if (targetMap != Guid.Empty)
                        {
                            if (mPathFinder.GetTarget() != null)
                            {
                                if (targetMap != mPathFinder.GetTarget().TargetMapId ||
                                    targetX != mPathFinder.GetTarget().TargetX ||
                                    targetY != mPathFinder.GetTarget().TargetY)
                                {
                                    mPathFinder.SetTarget(null);
                                }
                            }

                            if (mPathFinder.GetTarget() == null)
                            {
                                mPathFinder.SetTarget(new PathfinderTarget(targetMap, targetX, targetY, targetZ));

                                if (tempTarget != Target)
                                {
                                    tempTarget = Target;
                                }
                            }

                        }
                        bool hasFoundSpell = false;
                        if (mPathFinder.GetTarget() != null && Base.Movement != (int)NpcMovement.Static)
                        {
                            if (!fleeing || Base.AttackOnFlee)
                            {
                                hasFoundSpell = TryCastSpells();
                            }
                            // TODO: Make resetting mobs actually return to their starting location.
                            var attackrange = CurrentPhase?.AttackRange ?? Base.AttackRange;
                            var isInAttackRange = false;
                            var distanceTarget = -1;
                            if (attackrange > 0)
                            {
                                distanceTarget = GetDistanceTo(tempTarget);
                                isInAttackRange = distanceTarget <= attackrange;
                            }
                            else
                            {
                                isInAttackRange = IsOneBlockAway(
                                    mPathFinder.GetTarget().TargetMapId, mPathFinder.GetTarget().TargetX,
                                    mPathFinder.GetTarget().TargetY, mPathFinder.GetTarget().TargetZ
                                );
                            }
                            if ((!mResetting && !isInAttackRange) ||
                            (mResetting && GetDistanceTo(AggroCenterMap, AggroCenterX, AggroCenterY) != 0)
                            )
                            {
                                switch (mPathFinder.Update(timeMs))
                                {
                                    case PathfinderResult.Success:

                                        var dir = mPathFinder.GetMove();
                                        if (dir > -1)
                                        {
                                            if (fleeing)
                                            {
                                                switch (dir)
                                                {
                                                    case 0:
                                                        dir = 1;

                                                        break;
                                                    case 1:
                                                        dir = 0;

                                                        break;
                                                    case 2:
                                                        dir = 3;

                                                        break;
                                                    case 3:
                                                        dir = 2;

                                                        break;
                                                    case 4:
                                                        dir = 5;

                                                        break;
                                                    case 5:
                                                        dir = 4;

                                                        break;
                                                    case 6:
                                                        dir = 7;

                                                        break;
                                                    case 7:
                                                        dir = 6;
                                                        break;
                                                }
                                            }

                                            if (CanMove(dir) == -1 || CanMove(dir) == -4)
                                            {
                                                //check if NPC is snared or stunned
                                                foreach (var status in CachedStatuses)
                                                {
                                                    if (status.Type == StatusTypes.Stun ||
                                                        status.Type == StatusTypes.Snare ||
                                                        status.Type == StatusTypes.Sleep)
                                                    {
                                                        return;
                                                    }
                                                }

                                                Move((byte)dir, null);
                                            }
                                            else
                                            {
                                                mPathFinder.PathFailed(timeMs);
                                            }

                                            // Are we resetting?
                                            if (mResetting)
                                            {
                                                // Have we reached our destination? If so, clear it.
                                                if (GetDistanceTo(AggroCenterMap, AggroCenterX, AggroCenterY) == 0)
                                                {
                                                    targetMap = Guid.Empty;

                                                    // Reset our aggro center so we can get "pulled" again.
                                                    AggroCenterMap = null;
                                                    AggroCenterX = 0;
                                                    AggroCenterY = 0;
                                                    AggroCenterZ = 0;
                                                    mPathFinder?.SetTarget(null);
                                                    mResetting = false;
                                                    mResetPhase = 1;
                                                }
                                            }  
                                        }

                                        break;
                                    case PathfinderResult.OutOfRange:
                                        TryFindNewTarget(timeMs, tempTarget?.Id ?? Guid.Empty, true);
                                        tempTarget = Target;
                                        targetMap = Guid.Empty;

                                        break;
                                    case PathfinderResult.NoPathToTarget:
                                        TryFindNewTarget(timeMs, tempTarget?.Id ?? Guid.Empty, true);
                                        tempTarget = Target;
                                        targetMap = Guid.Empty;

                                        break;
                                    case PathfinderResult.Failure:
                                        targetMap = Guid.Empty;
                                        TryFindNewTarget(timeMs, tempTarget?.Id ?? Guid.Empty, true);
                                        tempTarget = Target;

                                        break;
                                    case PathfinderResult.Wait:
                                        targetMap = Guid.Empty;

                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                            }
                            else
                            {
                                var fleed = false;
                                var needStepback = false;
                                if (attackrange > 0)
                                {
                                    needStepback = distanceTarget < attackrange;
                                }
                                if (tempTarget != null && (fleeing || needStepback))
                                {
                                    var dir = DirToEnemy(tempTarget);
                                    if (needStepback)
                                    {
                                        dir = RandomStepBackDir(dir);
                                    }
                                    else
                                    {
                                        switch (dir)
                                        {
                                            case 0:
                                                dir = 1;

                                                break;
                                            case 1:
                                                dir = 0;

                                                break;
                                            case 2:
                                                dir = 3;

                                                break;
                                            case 3:
                                                dir = 2;

                                                break;
                                            case 4:
                                                dir = 5;

                                                break;
                                            case 5:
                                                dir = 4;

                                                break;
                                            case 6:
                                                dir = 7;

                                                break;
                                            case 7:
                                                dir = 6;

                                                break;
                                        }
                                    }
                                    

                                    if (CanMove(dir) == -1 || CanMove(dir) == -4)
                                    {
                                        //check if NPC is snared or stunned
                                        foreach (var status in CachedStatuses)
                                        {
                                            if (status.Type == StatusTypes.Stun ||
                                                status.Type == StatusTypes.Snare ||
                                                status.Type == StatusTypes.Sleep)
                                            {
                                                RandomMoveValue = -1;
                                                return;
                                            }
                                        }
                                        Move(dir, null);
                                        fleed = fleeing;
                                    }
                                }

                                if (!fleed)
                                {
                                    if (tempTarget != null)
                                    {
                                        if (tempTarget.IsDisposed)
                                        {
                                            TryFindNewTarget(timeMs);
                                            tempTarget = Target;
                                        }
                                        else
                                        {
                                            if (!hasFoundSpell)
                                            {
                                                TryAttack(tempTarget);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        CheckForResetLocation();

                        //Move randomly
                        if (targetMap != Guid.Empty)
                        {
                            return;
                        }

                        if (LastRandomMove >= Globals.Timing.Milliseconds || CastTime > 0)
                        {
                            return;
                        }

                        if (Base.Movement == (int)NpcMovement.StandStill)
                        {
                            LastRandomMove = Globals.Timing.Milliseconds + Randomization.Next(1000, 3000);

                            return;
                        }
                        else if (Base.Movement == (int)NpcMovement.TurnRandomly)
                        {
                            ChangeDir((byte)Randomization.Next(0, 4));
                            LastRandomMove = Globals.Timing.Milliseconds + Randomization.Next(1000, 3000);

                            return;
                        }

                        if (RandomMoveValue == -1)
                        {
                            RandomMoveValue = Randomization.Next(0, Base.MaxRandomMove);
                            CurrentRandomMove = 0;
                            OpposingDir = -1;
                        }
                        var validDirs = GetRandomMoveValidDirs();
                        int dirMove = validDirs[Randomization.Next(0, validDirs.Length)];
                        switch (dirMove)
                        {
                            case 0: //Up
                                OpposingDir = 1;
                                break;
                            case 1: //Down
                                OpposingDir = 0;
                                break;
                            case 2: //Left
                                OpposingDir = 3;
                                break;
                            case 3: //Right
                                OpposingDir = 2;
                                break;
                            case 4: //UpLeft
                                OpposingDir = 7;
                                break;
                            case 5: //UpRight
                                OpposingDir = 6;
                                break;
                            case 6: //DownLeft
                                OpposingDir = 5;
                                break;
                            case 7: //DownRight
                                OpposingDir = 4;
                                break;

                        }
                        if (CanMove(dirMove) == -1)
                        {
                            //check if NPC is snared or stunned
                            foreach (var status in CachedStatuses)
                            {
                                if (status.Type == StatusTypes.Stun ||
                                    status.Type == StatusTypes.Snare ||
                                    status.Type == StatusTypes.Sleep)
                                {
                                    RandomMoveValue = -1;
                                    return;
                                }
                            }

                            Move((byte)dirMove, null);
                        }
                        else
                        {
                            // Can't move in the direction, so no previous direction to store
                            OpposingDir = -1;
                        }
                        CurrentRandomMove++;
                        if (CurrentRandomMove > RandomMoveValue)
                        {
                            RandomMoveValue = -1;
                            if (fleeing)
                            {
                                LastRandomMove = Globals.Timing.Milliseconds + (long)GetMovementTime();
                            }
                            else
                            {
                                // Default was 1000-3000, changed to 2000-5000
                                LastRandomMove = Globals.Timing.Milliseconds + Randomization.Next(2000, 5000);
                            }
                        }
                        else
                        {
                            LastRandomMove = Globals.Timing.Milliseconds + (long)GetMovementTime();
                        }

                    }

                    //If we switched maps, lets update the maps
                    if (curMapLink != MapId)
                    {
                        if (curMapLink == Guid.Empty)
                        {
                            MapInstance.Get(curMapLink).RemoveEntity(this);
                        }

                        if (MapId != Guid.Empty)
                        {
                            MapInstance.Get(MapId).AddEntity(this);
                        }
                    }
                }
            }
            finally
            {
                if (lockObtained)
                {
                    Monitor.Exit(EntityLock);
                }
            }
        }

        public int[] GetRandomMoveValidDirs()
        {
            var validDirs = new List<int>();
            for (var dir= 0; dir< 8;dir++)
            {
                var tile = new TileHelper(MapId, X, Y);
                if (tile.TranslateDir(dir))
                {
                    //If this would move us past our max distance from the spawn, it's not a valid dir
                    var dist = GetDistanceBetween(SpawnMap, tile.GetMap(), SpawnX, tile.GetX(), SpawnY, tile.GetY(), true);
                    if (dist <= Options.Npc.MaxDistanceSpawnOnRandomMove)
                    {
                        validDirs.Add(dir);
                    }
                }
            }
            if (validDirs.Count > 1)
            {
                // We try to remove the opposingdir if we can move at least at 1 other position
                validDirs.Remove(OpposingDir);
            }
            else if (validDirs.Count == 0)
            {
                // If no possible dir, add opposing dir by default
                validDirs.Add(OpposingDir);
            }
            return validDirs.ToArray();
        }
        public byte RandomStepBackDir(byte dirToEnemy)
        {
            byte[] dirList = null;
            switch (dirToEnemy)
            {
                case 0:
                   dirList = new byte[] { 1, 2, 3, 6, 7 };

                    break;
                case 1:
                    dirList = new byte[] { 0, 2, 3, 4, 5 };

                    break;
                case 2:
                    dirList = new byte[] { 0, 1, 3, 5, 7 };

                    break;
                case 3:
                    dirList = new byte[] { 0, 1, 2, 4, 6 };

                    break;
                case 4:
                    dirList = new byte[] { 1, 3, 7 };

                    break;
                case 5:
                    dirList = new byte[] { 1, 2, 6 };

                    break;
                case 6:
                    dirList = new byte[] { 0, 3, 5 };

                    break;
                case 7:
                    dirList = new byte[] { 0, 2, 4 };

                    break;
            }

            return dirList[Randomization.Next(0, dirList.Length)];
        }
        private bool CheckForResetLocation(bool forceDistance = false)
        {
            // Check if we've moved out of our range we're allowed to move from after being "aggro'd" by something.
            // If so, remove target and move back to the origin point.
            if (Options.Npc.AllowResetRadius && AggroCenterMap != null && (GetDistanceTo(AggroCenterMap, AggroCenterX, AggroCenterY) > Math.Max(Options.Npc.ResetRadius, Base.ResetRadius) || forceDistance))
            {
                ResetNpc(Options.Npc.ResetVitalsAndStatusses);

                mResetCounter = 0;
                mResetDistance = 0;

                // Try and move back to where we came from before we started chasing something.
                mResetting = true;
                if (Base.RegenReset)
                {
                    CombatTimer = 0; // Added to allow regen when starting resetting for npc
                }
                mPathFinder.SetTarget(new PathfinderTarget(AggroCenterMap.Id, AggroCenterX, AggroCenterY, AggroCenterZ));
                return true;
            }
            return false;
        }

        private void ResetNpc(bool resetVitals = true, bool clearLocation = false)
        {
            // Remove our target.
            RemoveTarget();

            DamageMap.Clear();
            LootMap.Clear();
            LootMapCache = Array.Empty<Guid>();
            if (clearLocation)
            {
                mPathFinder.SetTarget(null);
                AggroCenterMap = null;
                AggroCenterX = 0;
                AggroCenterY = 0;
                AggroCenterZ = 0;
            }
            
            // Reset our vitals and statusses when configured.
            if (resetVitals)
            {
                Statuses.Clear();
                CachedStatuses = Statuses.Values.ToArray();
                DoT.Clear();
                CachedDots = DoT.Values.ToArray();
                for (var v = 0; v < (int)Vitals.VitalCount; v++)
                {
                    RestoreVital((Vitals)v);
                }
            }
        }

        public override void NotifySwarm(Entity attacker)
        {
            if (!Base.Swarm)
            {
                return;
            }
            var mapEntities = MapInstance.Get(MapId).GetEntities(true);
            foreach (var en in mapEntities)
            {
                if (en.GetType() == typeof(Npc))
                {
                    var npc = (Npc) en;
                    if (npc.Target == null && (Base.SwarmAll || Base.SwarmList.Contains(npc.Base.Id)))
                    {
                        if (npc.InRangeOf(this, Base.SwarmRange))
                        {
                            npc.AssignTarget(attacker);
                        }
                        if (Base.SwarmOnPlayer && npc.InRangeOf(attacker, Base.SwarmRange)) // check here with Tali
                        {
                            npc.AssignTarget(attacker);
                        }
                    }
                }
            }
        }

        public bool CanPlayerAttack(Player en)
        {
            //Check to see if the npc is a friend/protector...
            if (IsAllyOf(en))
            {
                return false;
            }

            //If not then check and see if player meets the conditions to attack the npc...
            if (Base.PlayerCanAttackConditions.Lists.Count == 0 ||
                ServerConditions.MeetsConditionLists(Base.PlayerCanAttackConditions, en, null, true, null, this))
            {
                return true;
            }

            return false;
        }

        public bool CanPlayerSpell(Player en)
        {
            //Check to see if the npc is a friend/protector...
            if (IsAllyOf(en))
            {
                return false;
            }

            //If not then check and see if player meets the conditions to attack the npc with a spell...
            if (Base.PlayerCanSpellConditions.Lists.Count == 0 ||
                ServerConditions.MeetsConditionLists(Base.PlayerCanSpellConditions, en, null, true, null, this))
            {
                return true;
            }

            return false;
        }

        public bool CanPlayerProjectile(Player en)
        {
            //Check to see if the npc is a friend/protector...
            if (IsAllyOf(en))
            {
                return false;
            }

            //If not then check and see if player meets the conditions to attack the npc with a projectile...
            if (Base.PlayerCanProjectileConditions.Lists.Count == 0 ||
                ServerConditions.MeetsConditionLists(Base.PlayerCanProjectileConditions, en, null, true, null, this))
            {
                return true;
            }

            return false;
        }

        public override bool IsAllyOf(Entity otherEntity)
        {
            switch (otherEntity)
            {
                case Npc otherNpc:
                    return Base == otherNpc.Base;
                case Player otherPlayer:
                    var conditionLists = Base.PlayerFriendConditions;
                    if ((conditionLists?.Count ?? 0) == 0)
                    {
                        return false;
                    }

                    return ServerConditions.MeetsConditionLists(conditionLists, otherPlayer, null, true, null, this);
                default:
                    return base.IsAllyOf(otherEntity);
            }
        }

        public bool ShouldAttackPlayerOnSight(Player en)
        {
            if (IsAllyOf(en))
            {
                return false;
            }

            if (Base.Aggressive)
            {
                if (Base.AttackOnSightConditions.Lists.Count > 0 &&
                    ServerConditions.MeetsConditionLists(Base.AttackOnSightConditions, en, null, true, null, this))
                {
                    return false;
                }

                return true;
            }
            else
            {
                if (Base.AttackOnSightConditions.Lists.Count > 0 &&
                    ServerConditions.MeetsConditionLists(Base.AttackOnSightConditions, en, null, true, null, this))
                {
                    return true;
                }
            }

            return false;
        }

        public void TryFindNewTarget(long timeMs, Guid avoidId = new Guid(), bool ignoreTimer = false, Entity attackedBy = null)
        {
            if (!ignoreTimer && FindTargetWaitTime > timeMs)
            {
                return;
            }

            // Are we resetting? If so, do not allow for a new target.
            var pathTarget = mPathFinder?.GetTarget();
            if (AggroCenterMap != null && pathTarget != null &&
                pathTarget.TargetMapId == AggroCenterMap.Id && pathTarget.TargetX == AggroCenterX && pathTarget.TargetY == AggroCenterY)
            {
                if (!Options.Instance.NpcOpts.AllowEngagingWhileResetting || attackedBy == null || attackedBy.GetDistanceTo(AggroCenterMap, AggroCenterX, AggroCenterY) > Math.Max(Options.Instance.NpcOpts.ResetRadius, Base.ResetRadius))
                {
                    return;
                }
                else
                {
                    //We're resetting and just got attacked, and we allow reengagement.. let's stop resetting and fight!
                    mPathFinder?.SetTarget(null);
                    mResetting = false;
                    AssignTarget(attackedBy);
                    return;
                }
            }

            var maps = MapInstance.Get(MapId).GetSurroundingMaps(true);
            var possibleTargets = new List<Entity>();
            var closestRange = Range + 1; //If the range is out of range we didn't find anything.
            var closestIndex = -1;
            var highestDmgIndex = -1;

           
            if (DamageMap.Count > 0)
            {
                // Go through all of our potential targets in order of damage done as instructed and select the first matching one.
                long highestDamage = 0;
                foreach (var en in DamageMap.ToArray())
                {
                    // Are we supposed to avoid this one?
                    if (en.Key.Id == avoidId)
                    {
                        continue;
                    }
                    
                    // Is this entry dead?, if so skip it.
                    if (en.Key.IsDead())
                    {
                        continue;   
                    }

                    // Are we at a valid distance? (9999 means not on this map or somehow null!)
                    if (GetDistanceTo(en.Key) != 9999)
                    {
                        possibleTargets.Add(en.Key);

                        // Do we have the highest damage?
                        if (en.Value > highestDamage)
                        {
                            highestDmgIndex = possibleTargets.Count - 1;
                            highestDamage = en.Value;
                        }    
                        
                    }
                }
            }


            // Scan for nearby targets
            foreach (var map in maps)
            {
                foreach (var entity in map.GetCachedEntities())
                {
                    if (entity != null && !entity.IsDead() && entity != this && entity.Id != avoidId)
                    {
                        //TODO Check if NPC is allowed to attack player with new conditions
                        if (entity.GetType() == typeof(Player))
                        {
                            // Are we aggressive towards this player or have they hit us?
                            if (ShouldAttackPlayerOnSight((Player)entity) || DamageMap.ContainsKey(entity))
                            {
                                var dist = GetDistanceTo(entity);
                                if (dist <= Range && dist < closestRange)
                                {
                                    possibleTargets.Add(entity);
                                    closestIndex = possibleTargets.Count - 1;
                                    closestRange = dist;
                                }
                            }
                        }
                        else if (entity.GetType() == typeof(Npc))
                        {
                            if (Base.Aggressive && Base.AggroList.Contains(((Npc)entity).Base.Id))
                            {
                                var dist = GetDistanceTo(entity);
                                if (dist <= Range && dist < closestRange)
                                {
                                    possibleTargets.Add(entity);
                                    closestIndex = possibleTargets.Count - 1;
                                    closestRange = dist;
                                }
                            }
                        }
                    }
                }
            }

            // Assign our target if we've found one!
            if (Base.FocusHighestDamageDealer && highestDmgIndex != -1)
            {
                // We're focussed on whoever has the most threat! o7
                AssignTarget(possibleTargets[highestDmgIndex]);
            }
            else if (Target != null && possibleTargets.Count > 0)
            {
                // Time to randomize who we target.. Since we don't actively care who we attack!
                // 10% chance to just go for someone else.
                if (Randomization.Next(1, 101) > 90)
                {
                    if (possibleTargets.Count > 1)
                    {
                        var target = Randomization.Next(0, possibleTargets.Count - 1);
                        AssignTarget(possibleTargets[target]);
                    }
                    else
                    {
                        AssignTarget(possibleTargets[0]);
                    }
                }
            }
            else if (Target == null && Base.Aggressive && closestIndex != -1)
            {
                // Aggressively attack closest person!
                AssignTarget(possibleTargets[closestIndex]);
            }
            else if (possibleTargets.Count > 0)
            {
                // Not aggressive but no target, so just try and attack SOMEONE on the damage table!
                if (possibleTargets.Count > 1)
                {
                    var target = Randomization.Next(0, possibleTargets.Count - 1);
                    AssignTarget(possibleTargets[target]);
                }
                else
                {
                    AssignTarget(possibleTargets[0]);
                }
            }
            else
            {
                // ??? What the frick is going on here?
                // We can't find a valid target somehow, keep it up a few times and reset if this keeps failing!
                mTargetFailCounter += 1;
                if (mTargetFailCounter > mTargetFailMax)
                {
                    CheckForResetLocation(true);
                }
            }

            FindTargetWaitTime = timeMs + FindTargetDelay;
        }

        public override void ProcessRegen()
        {
            if (Base == null)
            {
                return;
            }
            foreach (Vitals vital in Enum.GetValues(typeof(Vitals)))
            {
                if (vital >= Vitals.VitalCount)
                {
                    continue;
                }

                var vitalId = (int) vital;
                var vitalValue = GetVital(vital);
                var maxVitalValue = GetMaxVital(vital);
                if (vitalValue >= maxVitalValue)
                {
                    continue;
                }
                var vitalRegenRate = Base.VitalRegen[vitalId] / 100f;
                if (CurrentPhase?.VitalRegen != null)
                {
                    vitalRegenRate = CurrentPhase.VitalRegen[vitalId] / 100f;
                }
                
                var regenValue = (int) Math.Max(1, maxVitalValue * vitalRegenRate) *
                                 Math.Abs(Math.Sign(vitalRegenRate));

                AddVital(vital, regenValue);
            }
            // Reset the current phase when reaching our reset destination and we are full vitals
            if (mResetPhase == 2 && IsFullVital(Vitals.Health) && IsFullVital(Vitals.Mana))
            {
                EndCurrentPhase();
                PacketSender.SendEntityStats(this);
                PacketSender.SendEntityDataToProximity(this);
                mResetPhase = 0;
                CanDespawn = true;
            }
        }

        public override void Warp(
            Guid newMapId,
            float newX,
            float newY,
            byte newDir,
            bool adminWarp = false,
            byte zOverride = 0,
            bool mapSave = false
        )
        {
            var map = MapInstance.Get(newMapId);
            if (map == null)
            {
                return;
            }

            X = (int)newX;
            Y = (int)newY;
            Z = zOverride;
            Dir = newDir;
            MapRegionId = map.MapRegionIds[X, Y];
            if (newMapId != MapId)
            {
                var oldMap = MapInstance.Get(MapId);
                if (oldMap != null)
                {
                    oldMap.RemoveEntity(this);
                }

                PacketSender.SendEntityLeave(this);
                MapId = newMapId;
                PacketSender.SendEntityDataToProximity(this);
                PacketSender.SendEntityPositionToAll(this);
            }
            else
            {
                PacketSender.SendEntityPositionToAll(this);
                PacketSender.SendEntityStats(this);
            }
        }

        public int GetAggression(Player player)
        {
            //Determines the aggression level of this npc to send to the player
            if (this.Target != null)
            {
                return -1;
            }
            else
            {
                //Guard = 3
                //Will attack on sight = 1
                //Will attack if attacked = 0
                //Can't attack nor can attack = 2
                var ally = IsAllyOf(player);
                var attackOnSight = ShouldAttackPlayerOnSight(player);
                var canPlayerAttack = CanPlayerAttack(player);
                if (ally && !canPlayerAttack)
                {
                    return 3;
                }

                if (attackOnSight)
                {
                    return 1;
                }

                if (!ally && !attackOnSight && canPlayerAttack)
                {
                    return 0;
                }

                if (!ally && !attackOnSight && !canPlayerAttack)
                {
                    return 2;
                }
            }

            return 2;
        }

        public override EntityPacket EntityPacket(EntityPacket packet = null, Player forPlayer = null, bool isSpawn = false)
        {
            if (packet == null)
            {
                packet = new NpcEntityPacket();
            }

            packet = base.EntityPacket(packet, forPlayer);

            var pkt = (NpcEntityPacket) packet;
            pkt.Aggression = GetAggression(forPlayer);
            pkt.IsSpawn = isSpawn;
            pkt.ElementalTypes = GetElementalTypes();
            return pkt;
        }

        public void HandlePhases(Player player)
        {
            foreach(var phase in Base.NpcPhases)
            {
                if (phase.Id != CurrentPhase?.Id && ServerConditions.MeetsConditionLists(phase.ConditionLists, player, null, true, null, this))
                {
                    EndCurrentPhase();
                    SetCurrentPhase(phase);
                    PacketSender.SendEntityStats(this);
                    PacketSender.SendEntityDataToProximity(this);
                    if (phase.BeginAnimationId != null && phase.BeginAnimationId != Guid.Empty)
                    {
                        PacketSender.SendAnimationToProximity((Guid)phase.BeginAnimationId, 1, Id, MapId, 0, 0, (sbyte)Dir);
                        //Target Type 1 will be global entity
                    }
                    if (phase.BeginSpellId != null && phase.BeginSpellId != Guid.Empty)
                    {
                        CastSpell((Guid)phase.BeginSpellId);
                    }
                    player.StartCommonEvent(phase.BeginEvent);
                    break; // Exit the loop, only one phase can be triggered
                }
            }
        }

        private void EndCurrentPhase()
        {
            if (CurrentPhase != null)
            {
                // Put back the base spells
                if (CurrentPhase.ReplaceSpells)
                {
                    Spells.Clear();
                    SpellRules.Clear();
                    var spellSlot = 0;
                    bool needRules = Base.SpellRules.Count == 0;
                    for (var I = 0; I < Base.Spells.Count; I++)
                    {
                        var slot = new SpellSlot(spellSlot);
                        slot.Set(new Spell(Base.Spells[I]));
                        Spells.Add(slot);
                        spellSlot++;
                        if (needRules)
                        {
                            SpellRules.Add(new NpcSpellRule());
                        }
                        else
                        {
                            SpellRules.Add(Base.SpellRules[I]);
                        }
                    }
                }
                else if (CurrentPhase.Spells != null)
                {
                    // Forget all spell related to the phase
                    Spells.RemoveRange(Base.Spells.Count, CurrentPhase.Spells.Count);
                    SpellRules.RemoveRange(Base.Spells.Count, CurrentPhase.Spells.Count);
                }
                //Reset current cast if any
                SpellCastSlot = 0;
                CastTime = 0;
                LastCastTimer = 0;

                if (CurrentPhase.BaseStatsDiff != null)
                {
                    int vitalcount = (int)Vitals.VitalCount;
                    var lvlGap = Level - Base.Level;
                    for (var i = 0; i < vitalcount; i++)
                    {
                        if (CurrentPhase.BaseStatsDiff[i] != 1.0)
                        {
                            SetMaxVital(i, (int)(Base.MaxVital[i] * (1 + lvlGap * Base.LevelScalings[i])));
                            RestoreVital((Vitals)i);
                        }
                    }
                    
                    for (var i = 0; i < (int)Stats.StatCount; i++)
                    {
                        //i+2 for LevelScaling because 0 and 1 are Health/Mana
                        var baseStat = (int)(Base.Stats[i] * (1 + lvlGap * Base.LevelScalings[i + vitalcount]));
                        if (baseStat < 1)
                        {
                            baseStat = 1;
                        }
                        BaseStats[i] = baseStat;
                    }
                }

                if (CurrentPhase.ElementalTypes != null)
                {
                    for (var i = 0; i < NpcBase.MAX_ELEMENTAL_TYPES; i++)
                    {
                        ElementalTypes[i] = (ElementalType)Base.ElementalTypes[i];
                    }
                }
                Sprite = Base.Sprite;
                Name = Base.Name;
                Color = Base.Color;
            }
            CurrentPhase = null;
            CurrentPhaseTimer = 0;
        }

        private void SetCurrentPhase(NpcPhase phase)
        {
            var spellSlot = 0;
            if (phase.ReplaceSpells)
            {
                // Forget all the base spells and replace it after by the phase spells
                Spells.Clear();
                SpellRules.Clear();
            }
            else
            {
                // Add phase spells to the known base spells
                spellSlot = Base.Spells.Count;
            }
            SpellSlot slot;
            if (phase.Spells != null)
            {
                for (var i = 0; i<phase.Spells.Count; i++)
                {
                    slot = new SpellSlot(spellSlot);
                    slot.Set(new Spell(phase.Spells[i]));
                    Spells.Add(slot);
                    SpellRules.Add(phase.SpellRules[i]);
                    spellSlot++;
                }
            }
            if (phase.BaseStatsDiff != null)
            {
                int vitalcount = (int)Vitals.VitalCount;
                var lvlGap = Level - Base.Level;
                for (var i = 0; i < vitalcount; i++)
                {
                    if (phase.BaseStatsDiff[i] != 1.0)
                    {
                        SetMaxVital(i, (int)(Base.MaxVital[i] * (1 + lvlGap * Base.LevelScalings[i]) * phase.BaseStatsDiff[i]));
                        RestoreVital((Vitals)i);
                    }
                }
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    BaseStats[i] = (int)(BaseStats[i] * phase.BaseStatsDiff[i + vitalcount]);
                }
            }
            if (phase.Sprite != null)
            {
                Sprite = phase.Sprite;
                Color = phase.Color;
                Name = phase.NpcName;
            }
            if (phase.ElementalTypes != null)
            {
                for (var i = 0; i < NpcBase.MAX_ELEMENTAL_TYPES; i++)
                {
                    ElementalTypes[i] = (ElementalType)phase.ElementalTypes[i];
                }
            }
            CurrentPhase = phase;
            CurrentPhaseTimer = (phase.Duration?? 0) + Globals.Timing.Milliseconds;
        }

    }

}
