using System;
using System.Collections.Generic;
using System.Linq;

using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.Server.General;

namespace Intersect.Server.Entities.Combat
{

    public partial class DoT
    {
        public Guid Id = Guid.NewGuid();

        public Entity Attacker;

        public int Count;

        private long mInterval;

        public SpellBase SpellBase;

        public bool IsInfinite = false;

        public DoT(Entity attacker, Guid spellId, Entity target, bool isInfinite = false)
        {
            SpellBase = SpellBase.Get(spellId);
            IsInfinite = isInfinite;
            Attacker = attacker;
            Target = target;

            if (SpellBase == null || SpellBase.Combat.HotDotInterval < 1)
            {
                return;
            }

            // Does target have a cleanse buff? If so, do not allow this DoT when spell is unfriendly.
            if (!SpellBase.Combat.Friendly)
            {
                foreach (var status in Target.CachedStatuses)
                {
                    if (status.Type == StatusTypes.Cleanse && !IsInfinite)
                    {
                        return;
                    }
                }
            }
            

            //mInterval = Globals.Timing.Milliseconds + SpellBase.Combat.HotDotInterval;
            mInterval = 0;
            Count = SpellBase.Combat.Duration / SpellBase.Combat.HotDotInterval;
            target.DoT.TryAdd(Id, this);
            target.CachedDots = target.DoT.Values.ToArray();

        }

        public Entity Target { get; }

        public void Expire()
        {
            if (Target != null)
            {
                Target.DoT?.TryRemove(Id, out DoT val);
                Target.CachedDots = Target.DoT?.Values.ToArray() ?? new DoT[0];
            }
        }

        public bool CheckExpired()
        {
            if (Target != null && !Target.DoT.ContainsKey(Id))
            {
                return false;
            }

            if (IsInfinite || SpellBase == null || Count > 0)
            {
                return false;
            }

            Expire();

            return true;
        }

        public void Tick()
        {
            if (CheckExpired())
            {
                return;
            }

            if (mInterval > Globals.Timing.Milliseconds)
            {
                return;
            }

            var deadAnimations = new List<KeyValuePair<Guid, sbyte>>();
            var aliveAnimations = new List<KeyValuePair<Guid, sbyte>>();
            if (SpellBase.HitAnimationId != Guid.Empty)
            {
                deadAnimations.Add(new KeyValuePair<Guid, sbyte>(SpellBase.HitAnimationId, (sbyte) Directions.Up));
                aliveAnimations.Add(new KeyValuePair<Guid, sbyte>(SpellBase.HitAnimationId, (sbyte) Directions.Up));
            }

            var damageHealth = Attacker.CalculateVitalStyle(SpellBase.Combat.VitalDiff[(int)Vitals.Health],
                SpellBase.Combat.VitalDiffStyle[(int)Vitals.Health], Vitals.Health, Target);
            var damageMana = Attacker.CalculateVitalStyle(SpellBase.Combat.VitalDiff[(int)Vitals.Mana],
                SpellBase.Combat.VitalDiffStyle[(int)Vitals.Mana], Vitals.Mana, Target);

            Attacker?.Attack(
                Target, ref damageHealth, ref damageMana, SpellBase.Combat.VitalSteal[(int)Vitals.Health], SpellBase.Combat.VitalSteal[(int)Vitals.Mana],
                (ElementalType)SpellBase.ElementalType, (DamageType) SpellBase.Combat.DamageType, (Stats) SpellBase.Combat.ScalingStat,
                SpellBase.Combat.Scaling, SpellBase.Combat.CritChance, SpellBase.Combat.CritMultiplier, SpellBase.Name, deadAnimations,
                aliveAnimations, false
            ); //L'appel de la méthode a été modifié par Moussmous pour décrire les actions de combats dans le chat (ajout du nom de l'attaque utilisée)

            mInterval = Globals.Timing.Milliseconds + SpellBase.Combat.HotDotInterval;
            Count--;
        }

    }

}
