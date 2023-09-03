using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading;
using System.Web.UI;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Maps;
using Intersect.Logging;
using Intersect.Network.Packets.Server;
using Intersect.Server.Database;
using Intersect.Server.Database.PlayerData.Players;
using Intersect.Server.Entities.Combat;
using Intersect.Server.Entities.Events;
using Intersect.Server.General;
using Intersect.Server.Localization;
using Intersect.Server.Maps;
using Intersect.Server.Networking;
using Intersect.Utilities;

using Newtonsoft.Json;


//Ajoute par Moussmous
using Intersect.Network;
using Intersect.Models;

namespace Intersect.Server.Entities
{

    public partial class Entity : IDisposable
    {

        //Instance Values
        private Guid _id;

        [JsonProperty("MaxVitals"), NotMapped] private int[] _maxVital = new int[(int) Vitals.VitalCount];

        [NotMapped, JsonIgnore] public Stat[] Stat = new Stat[(int) Stats.StatCount];

        [NotMapped, JsonIgnore] public ElementalType[] ElementalTypes = new ElementalType[NpcBase.MAX_ELEMENTAL_TYPES];

        [NotMapped, JsonIgnore] public Entity Target { get; set; } = null;

        [NotMapped, JsonIgnore] public bool Running = false;

        [NotMapped, JsonIgnore] public bool CanDespawn = true;

        [NotMapped, JsonIgnore] public Resource CollidedResource { get; set; } = null;

        public Entity() : this(Guid.NewGuid())
        {
        }

        //Initialization
        public Entity(Guid instanceId)
        {
            if (!(this is EventPageInstance) && !(this is Projectile))
            {
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    Stat[i] = new Stat((Stats)i, this);
                }
            }

            Id = instanceId;
        }

        [Column(Order = 1), JsonProperty(Order = -2)]
        public string Name { get; set; }

        public Guid MapId { get; set; }

        [NotMapped]
        public string MapName => MapInstance.GetName(MapId);

        [JsonIgnore]
        [NotMapped]
        public MapInstance Map => MapInstance.Get(MapId);

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public int Dir { get; set; }

        public string Sprite { get; set; }

        /// <summary>
        /// The database compatible version of <see cref="Color"/>
        /// </summary>
        [JsonIgnore, Column(nameof(Color))]
        public string JsonColor
        {
            get => JsonConvert.SerializeObject(Color);
            set => Color = !string.IsNullOrWhiteSpace(value) ? JsonConvert.DeserializeObject<Color>(value) : Color.White;
        }

        /// <summary>
        /// Defines the ARGB color settings for this Entity.
        /// </summary>
        [NotMapped]
        public Color Color { get; set; } = new Color(255, 255, 255, 255);

        public string Face { get; set; }

        public int Level { get; set; }

        [JsonIgnore, Column("Vitals")]
        public string VitalsJson
        {
            get => DatabaseUtils.SaveIntArray(mVitals, (int) Enums.Vitals.VitalCount);
            set => mVitals = DatabaseUtils.LoadIntArray(value, (int) Enums.Vitals.VitalCount);
        }

        [JsonProperty("Vitals"), NotMapped]
        private int[] mVitals { get; set; } = new int[(int) Enums.Vitals.VitalCount];

        [JsonIgnore, NotMapped]
        private int[] mOldVitals { get; set; } = new int[(int)Enums.Vitals.VitalCount];

        [JsonIgnore, NotMapped]
        private int[] mOldMaxVitals { get; set; } = new int[(int)Enums.Vitals.VitalCount];

        //Stats based on npc settings, class settings, etc for quick calculations
        [JsonIgnore, Column(nameof(BaseStats))]
        public string StatsJson
        {
            get => DatabaseUtils.SaveIntArray(BaseStats, (int) Enums.Stats.StatCount);
            set => BaseStats = DatabaseUtils.LoadIntArray(value, (int) Enums.Stats.StatCount);
        }

        [NotMapped]
        public int[] BaseStats { get; set; } =
            new int[(int) Enums.Stats
                .StatCount]; // TODO: Why can this be BaseStats while Vitals is _vital and MaxVitals is _maxVital?

        [JsonIgnore, Column(nameof(StatPointAllocations))]
        public string StatPointsJson
        {
            get => DatabaseUtils.SaveIntArray(StatPointAllocations, (int) Enums.Stats.StatCount);
            set => StatPointAllocations = DatabaseUtils.LoadIntArray(value, (int) Enums.Stats.StatCount);
        }

        [NotMapped]
        public int[] StatPointAllocations { get; set; } = new int[(int) Enums.Stats.StatCount];

        //Inventory
        [JsonIgnore]
        public virtual List<InventorySlot> Items { get; set; } = new List<InventorySlot>();

        //Spells
        [JsonIgnore]
        public virtual List<SpellSlot> Spells { get; set; } = new List<SpellSlot>();

        [JsonIgnore, Column(nameof(NameColor))]
        public string NameColorJson
        {
            get => DatabaseUtils.SaveColor(NameColor);
            set => NameColor = DatabaseUtils.LoadColor(value);
        }

        [NotMapped]
        public Color NameColor { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public Guid Id { get => _id; set => _id = value; }

        [NotMapped]
        public Label HeaderLabel { get; set; }

        [JsonIgnore, Column(nameof(HeaderLabel))]
        public string HeaderLabelJson
        {
            get => JsonConvert.SerializeObject(HeaderLabel);
            set => HeaderLabel = value != null ? JsonConvert.DeserializeObject<Label>(value) : new Label();
        }

        [NotMapped]
        public Label FooterLabel { get; set; }

        [JsonIgnore, Column(nameof(FooterLabel))]
        public string FooterLabelJson
        {
            get => JsonConvert.SerializeObject(FooterLabel);
            set => FooterLabel = value != null ? JsonConvert.DeserializeObject<Label>(value) : new Label();
        }

        [NotMapped]
        public bool Dead { get; set; }

        //Combat
        [NotMapped, JsonIgnore]
        public long CastTime { get; set; }

        [NotMapped, JsonIgnore]
        public long AttackTimer { get; set; }

        [NotMapped, JsonIgnore]
        public bool Blocking { get; set; }

        [NotMapped, JsonIgnore]
        public Entity CastTarget { get; set; }

        [NotMapped, JsonIgnore]
        public Guid CollisionIndex { get; set; }

        [NotMapped, JsonIgnore]
        public long CombatTimer { get; set; }

        //Visuals
        [NotMapped, JsonIgnore]
        public bool HideName { get; set; }

        [NotMapped, JsonIgnore]
        public bool HideEntity { get; set; } = false;

        [NotMapped, JsonIgnore]
        public List<Guid> Animations { get; set; } = new List<Guid>();

        //DoT/HoT Spells
        [NotMapped, JsonIgnore]
        public ConcurrentDictionary<Guid, DoT> DoT { get; set; } = new ConcurrentDictionary<Guid, DoT>();

        [NotMapped, JsonIgnore]
        public DoT[] CachedDots { get; set; } = new DoT[0];

        [NotMapped, JsonIgnore]
        public EventMoveRoute MoveRoute { get; set; } = null;

        [NotMapped, JsonIgnore]
        public EventPageInstance MoveRouteSetter { get; set; } = null;

        [NotMapped, JsonIgnore]
        public long MoveTimer { get; set; }

        [NotMapped, JsonIgnore]
        public bool Passable { get; set; } = false;

        [NotMapped, JsonIgnore]
        public long RegenTimer { get; set; } = Globals.Timing.Milliseconds;

        [NotMapped, JsonIgnore]
        public int SpellCastSlot { get; set; } = 0;

        //Status effects
        [NotMapped, JsonIgnore]
        public ConcurrentDictionary<SpellBase, Status> Statuses { get; } = new ConcurrentDictionary<SpellBase, Status>();

        [JsonIgnore, NotMapped]
        public Status[] CachedStatuses = new Status[0];

        [JsonIgnore, NotMapped]
        private Status[] mOldStatuses = new Status[0];

        [NotMapped, JsonIgnore]
        public bool IsDisposed { get; protected set; }

        [NotMapped, JsonIgnore]
        public object EntityLock = new object();

        [NotMapped, JsonIgnore]
        public bool VitalsUpdated
        {
            get => !GetVitals().SequenceEqual(mOldVitals) || !GetMaxVitals().SequenceEqual(mOldMaxVitals);

            set
            {
                if (value == false)
                {
                    mOldVitals = GetVitals();
                    mOldMaxVitals = GetMaxVitals();
                }
            }
        }

        [NotMapped, JsonIgnore]
        public bool StatusesUpdated
        {
            get => CachedStatuses != mOldStatuses; //The whole CachedStatuses assignment gets changed when a status is added, removed, or updated (time remaining changes, so we only check for reference equivity here)

            set
            {
                if (value == false)
                {
                    mOldStatuses = CachedStatuses;
                }
            }
        }

        public virtual void Dispose()
        {
            if (!IsDisposed)
            {
                IsDisposed = true;
            }
        }

        public virtual void Update(long timeMs)
        {
            var lockObtained = false;
            try
            {
                Monitor.TryEnter(EntityLock, ref lockObtained);
                if (lockObtained)
                {
                    //Cast timers
                    if (CastTime != 0 && CastTime < timeMs)
                    {
                        CastTime = 0;
                        CastSpell(Spells[SpellCastSlot].SpellId, SpellCastSlot);
                        CastTarget = null;
                    }

                    //DoT/HoT timers
                    foreach (var dot in CachedDots)
                    {
                        dot.Tick();
                    }

                    var statsUpdated = false;
                    var statTime = Globals.Timing.Milliseconds;
                    for (var i = 0; i < (int)Stats.StatCount; i++)
                    {
                        statsUpdated |= (Stat[i] != null && Stat[i].Update(statTime));
                    }

                    if (statsUpdated)
                    {
                        PacketSender.SendEntityStats(this);
                    }

                    //Regen Timers
                    if (timeMs > CombatTimer && timeMs > RegenTimer)
                    {
                        ProcessRegen();
                        RegenTimer = timeMs + Options.RegenTime;
                    }

                    //Status timers
                    var statusArray = CachedStatuses;
                    foreach (var status in statusArray)
                    {
                        status.TryRemoveStatus();
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

        //Movement
        /// <summary>
        ///     Determines if this entity can move in the direction given.
        ///     Returns -5 if the tile is completely out of bounds.
        ///     Returns -3 if a tile is blocked because of a Z dimension tile
        ///     Returns -2 if a tile is blocked by a map attribute.
        ///     Returns -1 for clear.
        ///     Returns the type of entity that is blocking the way (if one exists)
        /// </summary>
        /// <param name="moveDir"></param>
        /// <returns></returns>
        public virtual int CanMove(int moveDir)
        {
            var xOffset = 0;
            var yOffset = 0;

            // If this is an Npc that has the Static behaviour, it can NEVER move.
            if (this is Npc npc)
            {
                if (npc.Base.Movement == (byte) NpcMovement.Static)
                {
                    return -2;
                }
            }

            var tile = new TileHelper(MapId, X, Y);
            switch (moveDir)
            {
                case 0: //Up
                    yOffset--;

                    break;
                case 1: //Down
                    yOffset++;

                    break;
                case 2: //Left
                    xOffset--;

                    break;
                case 3: //Right
                    xOffset++;

                    break;
                case 4: //NW
                    yOffset--;
                    xOffset--;

                    break;
                case 5: //NE
                    yOffset--;
                    xOffset++;

                    break;
                case 6: //SW
                    yOffset++;
                    xOffset--;

                    break;
                case 7: //SE
                    yOffset++;
                    xOffset++;

                    break;
            }

            MapInstance mapInstance = null;
            int tileX = 0;
            int tileY = 0;

            if (tile.Translate(xOffset, yOffset))
            {
                mapInstance = MapInstance.Get(tile.GetMapId());
                tileX = tile.GetX();
                tileY = tile.GetY();
                var tileAttribute = mapInstance.Attributes[tileX, tileY];
                if (tileAttribute != null)
                {
                    if (tileAttribute.Type == MapAttributes.Blocked || (tileAttribute.Type == MapAttributes.Animation && ((MapAnimationAttribute)tileAttribute).IsBlock))
                    {
                        return -2;
                    }

                    if (tileAttribute.Type == MapAttributes.NpcAvoid && (this is Npc || this is EventPageInstance))
                    {
                        return -2;
                    }

                    if (tileAttribute.Type == MapAttributes.ZDimension &&
                        ((MapZDimensionAttribute) tileAttribute).BlockedLevel > 0 &&
                        ((MapZDimensionAttribute) tileAttribute).BlockedLevel - 1 == Z)
                    {
                        return -3;
                    }

                    if (tileAttribute.Type == MapAttributes.Slide)
                    {
                        if (this is EventPage)
                        {
                            return -4;
                        }

                        switch (((MapSlideAttribute) tileAttribute).Direction)
                        {
                            case 1:
                                if (moveDir == 1)
                                {
                                    return -4;
                                }

                                break;
                            case 2:
                                if (moveDir == 0)
                                {
                                    return -4;
                                }

                                break;
                            case 3:
                                if (moveDir == 3)
                                {
                                    return -4;
                                }

                                break;
                            case 4:
                                if (moveDir == 2)
                                {
                                    return -4;
                                }

                                break;
                        }
                    }
                }
            }
            else
            {
                return -5; //Out of Bounds
            }
            if (!Passable)
            {
                var targetMap = mapInstance;
                var mapEntities = mapInstance.GetCachedEntities();
                foreach (var en in mapEntities)
                {
                    if (en != null && en.X == tileX && en.Y == tileY && en.Z == Z && !en.Passable)
                    {
                        //Set a target if a projectile
                        CollisionIndex = en.Id;
                        if (en is Player)
                        {
                            if (this is Player)
                            {
                                //Check if this target player is passable....
                                if (!Options.Instance.Passability.Passable[(int)targetMap.ZoneType])
                                {
                                    return (int)EntityTypes.Player;
                                }
                            }
                            else
                            {
                                return (int)EntityTypes.Player;
                            }
                        }
                        else if (en is Npc)
                        {
                            return (int)EntityTypes.Player;
                        }
                        else if (en is Resource resource)
                        {
                            //If determine if we should walk
                            if (!resource.IsPassable())
                            {
                                CollidedResource = (Resource)en;
                                return (int)EntityTypes.Resource;
                            }
                        }
                    }
                }

                foreach(var proj in mapInstance.MapProjectilesCached)
                {
                    if (proj != null && !proj.Passable && proj.Spawns != null)
                    {
                        foreach (var blockSpawn in proj.Spawns)
                        {
                            if (blockSpawn != null && !blockSpawn.Dead && blockSpawn.IsAtLocation(tile.GetMapId(), tileX, tileY, Z))
                            {
                                // Try to move in an area not passable, so we block
                                return (int)EntityTypes.Projectile;
                            }
                        }
                    }
                }

                //If this is an npc or other event.. if any global page exists that isn't passable then don't walk here!
                if (!(this is Player))
                {
                    foreach (var evt in mapInstance.GlobalEventInstances)
                    {
                        foreach (var en in evt.Value.GlobalPageInstance)
                        {
                            if (en != null && en.X == tileX && en.Y == tileY && en.Z == Z && !en.Passable)
                            {
                                return (int)EntityTypes.Event;
                            }
                        }
                    }
                }
            }

            return IsTileWalkable(tile.GetMap(), tile.GetX(), tile.GetY(), Z);
        }

        protected virtual int IsTileWalkable(MapInstance map, int x, int y, int z)
        {
            //Out of bounds if no map
            if (map == null)
            {
                return -5;
            }

            //Otherwise fine
            return -1;
        }

        protected virtual bool ProcessMoveRoute(Player forPlayer, long timeMs)
        {
            var moved = false;
            byte lookDir = 0, moveDir = 0;
            if (MoveRoute.ActionIndex < MoveRoute.Actions.Count)
            {
                switch (MoveRoute.Actions[MoveRoute.ActionIndex].Type)
                {
                    case MoveRouteEnum.MoveUp:
                        if (CanMove((int) Directions.Up) == -1)
                        {
                            Move((int) Directions.Up, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveDown:
                        if (CanMove((int) Directions.Down) == -1)
                        {
                            Move((int) Directions.Down, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveLeft:
                        if (CanMove((int) Directions.Left) == -1)
                        {
                            Move((int) Directions.Left, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveRight:
                        if (CanMove((int) Directions.Right) == -1)
                        {
                            Move((int) Directions.Right, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveUpLeft:
                        if (CanMove((int)Directions.UpLeft) == -1)
                        {
                            Move((int)Directions.UpLeft, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveUpRight:
                        if (CanMove((int)Directions.UpRight) == -1)
                        {
                            Move((int)Directions.UpRight, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveDownLeft:
                        if (CanMove((int)Directions.DownLeft) == -1)
                        {
                            Move((int)Directions.DownLeft, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveDownRight:
                        if (CanMove((int)Directions.DownRight) == -1)
                        {
                            Move((int)Directions.DownRight, forPlayer, false, true);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.MoveRandomly:
                        var dir = (byte)Randomization.Next(0, 8);
                        if (CanMove(dir) == -1)
                        {
                            Move(dir, forPlayer);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.StepForward:
                        if (CanMove(Dir) > -1)
                        {
                            Move((byte) Dir, forPlayer);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.StepBack:
                        switch (Dir)
                        {
                            case (int) Directions.Up:
                                moveDir = (int) Directions.Down;

                                break;
                            case (int) Directions.Down:
                                moveDir = (int) Directions.Up;

                                break;
                            case (int) Directions.Left:
                                moveDir = (int) Directions.Right;

                                break;
                            case (int) Directions.Right:
                                moveDir = (int) Directions.Left;

                                break;
                            case (int)Directions.UpLeft:
                                moveDir = (int)Directions.DownRight;

                                break;
                            case (int)Directions.UpRight:
                                moveDir = (int)Directions.DownLeft;

                                break;
                            case (int)Directions.DownLeft:
                                moveDir = (int)Directions.UpRight;

                                break;
                            case (int)Directions.DownRight:
                                moveDir = (int)Directions.UpLeft;

                                break;
                        }

                        if (CanMove(moveDir) > -1)
                        {
                            Move(moveDir, forPlayer);
                            moved = true;
                        }

                        break;
                    case MoveRouteEnum.FaceUp:
                        ChangeDir((int) Directions.Up);
                        moved = true;

                        break;
                    case MoveRouteEnum.FaceDown:
                        ChangeDir((int) Directions.Down);
                        moved = true;

                        break;
                    case MoveRouteEnum.FaceLeft:
                        ChangeDir((int) Directions.Left);
                        moved = true;

                        break;
                    case MoveRouteEnum.FaceRight:
                        ChangeDir((int) Directions.Right);
                        moved = true;

                        break;
                    case MoveRouteEnum.Turn90Clockwise:
                        switch (Dir)
                        {
                            case (int) Directions.Up:
                                lookDir = (int) Directions.Right;

                                break;
                            case (int) Directions.Down:
                                lookDir = (int) Directions.Left;

                                break;
                            case (int) Directions.Left:
                                lookDir = (int) Directions.Up;

                                break;
                            case (int) Directions.Right:
                                lookDir = (int) Directions.Down;

                                break;
                            case (int)Directions.UpLeft:
                                lookDir = (int)Directions.UpRight;

                                break;
                            case (int)Directions.UpRight:
                                lookDir = (int)Directions.DownRight;

                                break;
                            case (int)Directions.DownLeft:
                                lookDir = (int)Directions.UpLeft;

                                break;
                            case (int)Directions.DownRight:
                                lookDir = (int)Directions.DownLeft;

                                break;
                        }

                        ChangeDir(lookDir);
                        moved = true;

                        break;
                    case MoveRouteEnum.Turn90CounterClockwise:
                        switch (Dir)
                        {
                            case (int)Directions.Up:
                                lookDir = (int)Directions.Left;

                                break;
                            case (int)Directions.Down:
                                lookDir = (int)Directions.Right;

                                break;
                            case (int)Directions.Left:
                                lookDir = (int)Directions.Down;

                                break;
                            case (int)Directions.Right:
                                lookDir = (int)Directions.Up;

                                break;
                            case (int)Directions.UpLeft:
                                lookDir = (int)Directions.DownLeft;

                                break;
                            case (int)Directions.UpRight:
                                lookDir = (int)Directions.UpLeft;

                                break;
                            case (int)Directions.DownLeft:
                                lookDir = (int)Directions.DownRight;

                                break;
                            case (int)Directions.DownRight:
                                lookDir = (int)Directions.UpRight;

                                break;
                        }

                        ChangeDir(lookDir);
                        moved = true;

                        break;
                    case MoveRouteEnum.Turn180:
                        switch (Dir)
                        {
                            case (int) Directions.Up:
                                lookDir = (int) Directions.Down;

                                break;
                            case (int) Directions.Down:
                                lookDir = (int) Directions.Up;

                                break;
                            case (int) Directions.Left:
                                lookDir = (int) Directions.Right;

                                break;
                            case (int) Directions.Right:
                                lookDir = (int) Directions.Left;

                                break;
                            case (int)Directions.UpLeft:
                                lookDir = (int)Directions.DownRight;

                                break;
                            case (int)Directions.UpRight:
                                lookDir = (int)Directions.DownLeft;

                                break;
                            case (int)Directions.DownLeft:
                                lookDir = (int)Directions.UpRight;

                                break;
                            case (int)Directions.DownRight:
                                lookDir = (int)Directions.UpLeft;

                                break;
                        }

                        ChangeDir(lookDir);
                        moved = true;

                        break;
                    case MoveRouteEnum.TurnRandomly:
                        ChangeDir((byte)Randomization.Next(0, 8));
                        moved = true;

                        break;
                    case MoveRouteEnum.Wait100:
                        MoveTimer = Globals.Timing.Milliseconds + 100;
                        moved = true;

                        break;
                    case MoveRouteEnum.Wait500:
                        MoveTimer = Globals.Timing.Milliseconds + 500;
                        moved = true;

                        break;
                    case MoveRouteEnum.Wait1000:
                        MoveTimer = Globals.Timing.Milliseconds + 1000;
                        moved = true;

                        break;
                    default:
                        //Gonna end up returning false because command not found
                        return false;
                }

                if (moved || MoveRoute.IgnoreIfBlocked)
                {
                    MoveRoute.ActionIndex++;
                    if (MoveRoute.ActionIndex >= MoveRoute.Actions.Count)
                    {
                        if (MoveRoute.RepeatRoute)
                        {
                            MoveRoute.ActionIndex = 0;
                        }

                        MoveRoute.Complete = true;
                    }
                }

                if (moved && MoveTimer < Globals.Timing.Milliseconds)
                {
                    MoveTimer = Globals.Timing.Milliseconds + (long) GetMovementTime();
                }
            }

            return true;
        }

        public virtual bool IsPassable()
        {
            return Passable;
        }

        //Returns the amount of time required to traverse 1 tile
        public virtual float GetMovementTime()
        {
            //float time = 2.0f * Options.Instance.PlayerOpts.WalkingSpeed / (float)(1 + Math.Log(Stat[(int)Stats.Speed].Value()));
            float time = Stat[(int)Stats.Speed].Value() > Options.Instance.PlayerOpts.MaxSpeedStat ?
                 Globals.CalculatedSpeeds[Options.Instance.PlayerOpts.MaxSpeedStat] :
                 Globals.CalculatedSpeeds[Stat[(int)Stats.Speed].Value()];
            if (Blocking)
            {
                time += time * (float)Options.BlockingSlow / 100f;
            }

            return Math.Min(1000f, time);
        }

        public virtual EntityTypes GetEntityType()
        {
            return EntityTypes.GlobalEntity;
        }

        public virtual void Move(int moveDir, Player forPlayer, bool doNotUpdate = false, bool correction = false, bool isDash = false)
        {
            if (Globals.Timing.Milliseconds < MoveTimer || (!Options.Combat.MovementCancelsCast && CastTime > 0))
            {
                return;
            }

            lock (EntityLock)
            {
                if (this is Player && CastTime > 0 && Options.Combat.MovementCancelsCast)
                {
                    CastTime = 0;
                    CastTarget = null;
                }

                var xOffset = 0;
                var yOffset = 0;
                switch (moveDir)
                {
                    case 0: //Up
                        --yOffset;

                        break;
                    case 1: //Down
                        ++yOffset;

                        break;
                    case 2: //Left
                        --xOffset;

                        break;
                    case 3: //Right
                        ++xOffset;

                        break;
                    case 4: //UpLeft
                        --yOffset;
                        --xOffset;
                        break;
                    case 5: //UpRight
                        --yOffset;
                        ++xOffset;
                        break;
                    case 6: //DownLeft
                        ++yOffset;
                        --xOffset;
                        break;
                    case 7: //DownRight
                        ++yOffset;
                        ++xOffset;
                        break;
                    default:
                        Log.Warn(
                            new ArgumentOutOfRangeException(nameof(moveDir), $@"Bogus move attempt in direction {moveDir}.")
                        );

                        return;
                }
                //Dir = moveDir;
                // NO DIAGONAL DIRECTION, only movement
                switch (moveDir)
                {
                    case 4:
                    case 6:
                        Dir = 2;
                        break;
                    case 5:
                    case 7:
                        Dir = 3;
                        break;
                    default:
                        Dir = moveDir;
                        break;
                }
               


                var tile = new TileHelper(MapId, X, Y);
                var oldtile = new TileHelper(MapId, X, Y);
                // ReSharper disable once InvertIf
                if (tile.Translate(xOffset, yOffset))
                {
                    X = tile.GetX();
                    Y = tile.GetY();

                    var currentMap = MapInstance.Get(tile.GetMapId());
                    if (MapId != tile.GetMapId())
                    {
                        var oldMap = MapInstance.Get(MapId);
                        oldMap?.RemoveEntity(this);
                        currentMap?.AddEntity(this);

                        //Send Left Map Packet To the Maps that we are no longer with
                        var oldMaps = oldMap?.GetSurroundingMaps(true);
                        var newMaps = currentMap?.GetSurroundingMaps(true);

                        MapId = tile.GetMapId();

                        if (oldMaps != null)
                        {
                            foreach (var map in oldMaps)
                            {
                                if (newMaps == null || !newMaps.Contains(map))
                                {
                                    PacketSender.SendEntityLeaveMap(this, map.Id);
                                }
                            }
                        }


                        if (newMaps != null)
                        {
                            foreach (var map in newMaps)
                            {
                                if (oldMaps == null || !oldMaps.Contains(map))
                                {
                                    PacketSender.SendEntityDataToMap(this, map, this as Player);
                                }
                            }
                        }

                    }



                    if (doNotUpdate == false)
                    {
                        if (this is EventPageInstance)
                        {
                            if (forPlayer != null)
                            {
                                PacketSender.SendEntityMoveTo(forPlayer, this, moveDir, correction);
                            }
                            else
                            {
                                PacketSender.SendEntityMove(this, moveDir, correction); ;
                            }
                        }
                        else
                        {
                            PacketSender.SendEntityMove(this, moveDir, correction);
                        }

                        //Check if moving into a projectile.. if so this npc needs to be hit
                        if (currentMap != null)
                        {
                            var localMaps = currentMap.GetSurroundingMaps(true);
                            foreach (var map in localMaps)
                            {
                                var projectiles = map.MapProjectilesCached;
                                foreach (var projectile in projectiles)
                                {
                                    var spawns = projectile?.Spawns?.ToArray() ?? Array.Empty<ProjectileSpawn>();
                                    foreach (var spawn in spawns)
                                    {
                                        // TODO: Filter in Spawns variable, there should be no nulls. See #78 for evidence it is null.
                                        if (spawn == null)
                                        {
                                            continue;
                                        }

                                        if (spawn.IsAtLocation(MapId, X, Y, Z))
                                        {
                                            if (spawn.HitEntity(this))
                                            {
                                                spawn.Dead = true;
                                            }
                                            else if (projectile.Base.BlockTarget)
                                            {
                                                var dashspeed = projectile.Base.Speed;
                                                if (projectile.Base.Range > 0 && projectile.Base.Speed > 0)
                                                {
                                                    //dashRange = spawn.Parent.Base.Range - spawn.Distance + 1;
                                                    dashspeed = (int)((float)projectile.Base.Speed / (float)(spawn.Parent.Base.Range + 1));
                                                }
                                                new Dash(this, 1, spawn.Dir, false, false, false, false, null, dashspeed);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        MoveTimer = Globals.Timing.Milliseconds + (long)GetMovementTime();
                    }

                    if (TryToChangeDimension() && doNotUpdate == true)
                    {
                        PacketSender.UpdateEntityZDimension(this, (byte)Z);
                    }

                    //Check for traps
                    if (currentMap != null)
                    {
                        foreach (var trap in currentMap.MapTrapsCached)
                        {
                            trap.CheckEntityHasDetonatedTrap(this);
                        }
                    }

                    //Check for on hit tiles animations
                    foreach (var status in CachedStatuses)
                    {
                        if (status.Type == StatusTypes.OnHit && status.Spell?.TilesAnimation != null)
                        {
                            PacketSender.SendAnimationToProximity(status.Spell.TilesAnimationId, -1, Guid.Empty, oldtile.GetMapId(), (byte)oldtile.GetX(), (byte)oldtile.GetY(), (sbyte)Directions.Up);
                        }
                    }

                    // TODO: Why was this scoped to only Event entities?
                    //                if (currentMap != null && this is EventPageInstance)
                    var attribute = currentMap?.Attributes[X, Y];

                    // ReSharper disable once InvertIf
                    //Check for slide tiles
                    if (attribute?.Type == MapAttributes.Slide)
                    {
                        // If sets direction, set it.
                        if (((MapSlideAttribute)attribute).Direction > 0)
                        {
                            //Check for slide tiles
                            if (attribute != null && attribute.Type == MapAttributes.Slide)
                            {
                                if (((MapSlideAttribute)attribute).Direction > 0)
                                {
                                    Dir = (byte)(((MapSlideAttribute)attribute).Direction - 1);
                                }
                            }
                        }

                        var dash = new Dash(this, 1, (byte)Dir);
                    }
                }
            }
        }

        public void ChangeDir(int dir)
        {
            if (dir == -1)
            {
                return;
            }

            if (Dir != dir)
            {
                Dir = dir;

                if (this is EventPageInstance eventPageInstance && eventPageInstance.Player != null)
                {
                    if (((EventPageInstance)this).Player != null)
                    {
                        PacketSender.SendEntityDirTo(((EventPageInstance)this).Player, this);
                    }
                    else
                    {
                        PacketSender.SendEntityDir(this);
                    }
                }
                else
                {
                    PacketSender.SendEntityDir(this);
                }
            }
        }

        // Change the dimension if the player is on a gateway
        public bool TryToChangeDimension()
        {
            if (X < Options.MapWidth && X >= 0)
            {
                if (Y < Options.MapHeight && Y >= 0)
                {
                    var attribute = MapInstance.Get(MapId).Attributes[X, Y];
                    if (attribute != null && attribute.Type == MapAttributes.ZDimension)
                    {
                        if (((MapZDimensionAttribute) attribute).GatewayTo > 0)
                        {
                            Z = (byte) (((MapZDimensionAttribute) attribute).GatewayTo - 1);

                            return true;
                        }
                    }
                }
            }

            return false;
        }

        //Misc
        public int GetDirectionTo(Entity target)
        {
            int xDiff = 0, yDiff = 0;

            var map = MapInstance.Get(MapId);
            var gridId = map.MapGrid;
            var grid = DbInterface.GetGrid(gridId);

            //Loop through surrouding maps to generate a array of open and blocked points.
            for (var x = map.MapGridX - 1; x <= map.MapGridX + 1; x++)
            {
                if (x == -1 || x >= grid.Width)
                {
                    continue;
                }

                for (var y = map.MapGridY - 1; y <= map.MapGridY + 1; y++)
                {
                    if (y == -1 || y >= grid.Height)
                    {
                        continue;
                    }

                    if (grid.MyGrid[x, y] != Guid.Empty &&
                        grid.MyGrid[x, y] == target.MapId)
                    {
                        xDiff = (x - map.MapGridX) * Options.MapWidth + target.X - X;
                        yDiff = (y - map.MapGridY) * Options.MapHeight + target.Y - Y;
                        if (Math.Abs(xDiff) > Math.Abs(yDiff))
                        {
                            if (xDiff < 0)
                            {
                                return (int) Directions.Left;
                            }

                            if (xDiff > 0)
                            {
                                return (int) Directions.Right;
                            }
                        }
                        else
                        {
                            if (yDiff < 0)
                            {
                                return (int) Directions.Up;
                            }

                            if (yDiff > 0)
                            {
                                return (int) Directions.Down;
                            }
                        }
                    }
                }
            }

            return -1;
        }

        //Combat
        public virtual int CalculateAttackTime()
        {
            return (int) (Options.MaxAttackRate +
                          (float) ((Options.MinAttackRate - Options.MaxAttackRate) * 5f *
                                   (((float) Options.MaxStatValue - Stat[(int) Stats.Speed].Value()) /
                                    (float) Options.MaxStatValue)));
        }

        public void TryBlock(bool blocking)
        {
            if (AttackTimer < Globals.Timing.Milliseconds)
            {
                if (blocking && !Blocking && AttackTimer < Globals.Timing.Milliseconds)
                {
                    Blocking = true;
                    PacketSender.SendEntityAttack(this, -1);
                }
                else if (!blocking && Blocking)
                {
                    Blocking = false;
                    AttackTimer = Globals.Timing.Milliseconds + CalculateAttackTime();
                    PacketSender.SendEntityAttack(this, 0);
                }
            }
        }

        public virtual int GetWeaponDamage()
        {
            return 0;
        }

        public virtual bool CanAttack(Entity entity, SpellBase spell)
        {
            return CastTime <= 0;
        }

        public virtual void ProcessRegen()
        {
        }

        public int GetVital(int vital)
        {
            return mVitals[vital];
        }

        public int[] GetVitals()
        {
            var vitals = new int[(int) Vitals.VitalCount];
            Array.Copy(mVitals, 0, vitals, 0, (int) Vitals.VitalCount);

            return vitals;
        }

        public int GetVital(Vitals vital)
        {
            return GetVital((int) vital);
        }

        public void SetVital(int vital, int value)
        {
            if (value < 0)
            {
                value = 0;
            }

            if (GetMaxVital(vital) < value)
            {
                value = GetMaxVital(vital);
            }

            mVitals[vital] = value;
        }

        public void SetVital(Vitals vital, int value)
        {
            SetVital((int) vital, value);
        }

        public virtual int GetMaxVital(int vital)
        {
            return _maxVital[vital];
        }

        public virtual int GetMaxVital(Vitals vital)
        {
            return GetMaxVital((int) vital);
        }

        public int[] GetMaxVitals()
        {
            var vitals = new int[(int) Vitals.VitalCount];
            for (var vitalIndex = 0; vitalIndex < vitals.Length; ++vitalIndex)
            {
                vitals[vitalIndex] = GetMaxVital(vitalIndex);
            }

            return vitals;
        }

        public void SetMaxVital(int vital, int value)
        {
            if (value <= 0 && vital == (int) Vitals.Health)
            {
                value = 1; //Must have at least 1 hp
            }

            if (value < 0 && vital == (int) Vitals.Mana)
            {
                value = 1; //Can't have less than 1 mana and 0 is for illimited
            }

            _maxVital[vital] = value;
            if (value < GetVital(vital))
            {
                SetVital(vital, value);
            }
        }

        public void SetMaxVital(Vitals vital, int value)
        {
            SetMaxVital((int) vital, value);
        }

        public bool HasVital(Vitals vital)
        {
            return GetVital(vital) > 0;
        }

        public bool IsFullVital(Vitals vital)
        {
            return GetVital(vital) == GetMaxVital(vital);
        }

        //Vitals
        public void RestoreVital(Vitals vital)
        {
            SetVital(vital, GetMaxVital(vital));
        }

        public void AddVital(Vitals vital, int amount)
        {
            if (vital >= Vitals.VitalCount)
            {
                return;
            }

            var vitalId = (int) vital;
            var maxVitalValue = GetMaxVital(vitalId);
            var safeAmount = Math.Min(amount, int.MaxValue - maxVitalValue);
            SetVital(vital, GetVital(vital) + safeAmount);
        }

        public void SubVital(Vitals vital, int amount)
        {
            if (vital >= Vitals.VitalCount)
            {
                return;
            }

            //Check for any shields.
            foreach (var status in CachedStatuses)
            {
                if (status.Type == StatusTypes.Shield)
                {
                    status.DamageShield(vital, ref amount);
                }
            }

            var vitalId = (int) vital;
            var maxVitalValue = GetMaxVital(vitalId);
            var safeAmount = Math.Min(amount, GetVital(vital));
            SetVital(vital, GetVital(vital) - safeAmount);
        }

        public virtual int[] GetStatValues()
        {
            var stats = new int[(int) Stats.StatCount];
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                if (Stat[i] != null) // Prevent error in some cases
                {
                    stats[i] = Stat[i].Value();
                }
            }

            return stats;
        }

        public ElementalType[] GetElementalTypes()
        {
            var elemTypes = new ElementalType[NpcBase.MAX_ELEMENTAL_TYPES];
            Array.Copy(ElementalTypes, 0, elemTypes, 0, NpcBase.MAX_ELEMENTAL_TYPES);

            return elemTypes;
        }

        public virtual bool IsAllyOf(Entity otherEntity)
        {
            return this == otherEntity;
        }

        //Attacking with projectile
        public virtual void TryAttack(
            Entity target,
            ProjectileBase projectile,
            SpellBase parentSpell,
            ItemBase parentItem,
            byte projectileDir,
            bool alreadyCrit = false
        )
        {
            if (target is Resource && parentSpell != null)
            {
                return;
            }

            //Check for taunt status and trying to attack a target that has not taunted you.
            foreach (var status in CachedStatuses)
            {
                if (status.Type == StatusTypes.Taunt)
                {
                    if (Target != target)
                    {
                        PacketSender.SendActionMsg(this, Strings.Combat.miss, CustomColors.Combat.Missed);

                        return;
                    }
                }
            }

            // AttackInfos for static projectile are handled after in TryAttack(spell)
            if (projectile?.Speed > 0)
            {
                if (this is Player p && target is Npc npcenemy)
                {
                    p.FightingNpcBaseIds.AddOrUpdate(npcenemy.Base.Id, CombatTimer, (guid, t) => CombatTimer);
                    var npclist = p.FightingListNpcs.GetOrAdd(npcenemy.Base.Id, new ConcurrentDictionary<Npc, AttackInfo>());
                    AttackInfo attackinfo;
                    if (parentSpell != null)
                    {
                        attackinfo = new AttackInfo((DamageType)parentSpell.Combat.DamageType, AttackType.Projectile,
                            (ElementalType)parentSpell.ElementalType, parentSpell.Id);
                    }
                    else
                    {
                        attackinfo = new AttackInfo((DamageType)parentItem.DamageType, AttackType.Projectile,
                            (ElementalType)parentItem.ElementalType, parentItem.Id);
                    }
                    npclist.AddOrUpdate(npcenemy, attackinfo, (npc, info) => attackinfo);
                    if (!npcenemy.CanPlayerProjectile(p))
                    {
                        // Try to trigger possible phase related to projectile
                        npcenemy.HandlePhases(p);
                        return;
                    }
                }
                else if (this is Npc n && target is Player penemy)
                {
                    penemy.FightingNpcBaseIds.AddOrUpdate(n.Base.Id, CombatTimer, (guid, t) => CombatTimer);
                    var npclist = penemy.FightingListNpcs.GetOrAdd(n.Base.Id, new ConcurrentDictionary<Npc, AttackInfo>());
                    npclist.AddOrUpdate(n, npc => null, (npc, info) => info);
                }
            }

            if (parentSpell != null)
            {
                TryAttack(target, parentSpell, false, false, alreadyCrit, "", projectile?.Speed > 0, projectile?.Speed == 0);
            }

            var targetPlayer = target as Player;

            if (this is Player player && targetPlayer != null)
            {
                //Player interaction common events
                if (projectile == null && parentSpell == null)
                {
                    targetPlayer.StartCommonEventsWithTrigger(CommonEventTrigger.PlayerInteract, "", this.Name);
                }

                if (MapInstance.Get(MapId).ZoneType == MapZones.Safe)
                {
                    return;
                }

                if (MapInstance.Get(target.MapId).ZoneType == MapZones.Safe)
                {
                    return;
                }
                if (!PvpStadiumUnit.StadiumQueue.TryGetValue(targetPlayer.Id, out var playerUnit) ||
                    playerUnit.StadiumState != PvpStadiumState.MatchOnGoing)
                {
                    if (player.InParty(targetPlayer))
                    {
                        return;
                    }
                }
            }
            bool isCrit = false;
            
            if (parentSpell == null)
            {
                var damageHealth = parentItem.Damage;
                var damageMana = 0;
                if (target !=null && target.IsImmuneToElementalType(parentItem.ElementalType))
                {
                    PacketSender.SendActionMsg(target, Strings.Combat.immune, CustomColors.Combat.Immune);
                    return;
                }
                isCrit = Attack(
                    target, ref damageHealth, ref damageMana, 0, 0, (ElementalType)parentItem.ElementalType, (DamageType) parentItem.DamageType, (Stats) parentItem.ScalingStat,
                    parentItem.Scaling, parentItem.CritChance, parentItem.CritMultiplier, parentItem.Name, null, null, true, parentItem.CritEffectSpellReplace, alreadyCrit
                ); //L'appel de la méthode a été modifié par Moussmous pour décrire les actions de combats dans le chat (ajout du nom de l'attaque utilisée)
            }

            if (isCrit && parentItem.CritEffectSpellId != Guid.Empty)
            {
                // Directly try to attack with the the crit spell
                //TryAttack(target, parentItem.CritEffectSpell, false, false, true, parentItem.Name);
                CastSpell(parentItem.CritEffectSpellId, -1, true, parentItem.Name, target);
            }

            //If projectile, check if a splash spell is applied
            if (projectile == null)
            {
                return;
            }

            if (projectile.SpellId != Guid.Empty)
            {
                var s = projectile.Spell;
                if (s != null)
                {
                    //s.Name ou parentItem.Name ?
                    //HandleAoESpell(projectile.SpellId, s.Combat.HitRadius, target.MapId, target.X, target.Y, null, alreadyCrit);
                    CastSpell(projectile.SpellId, -1, alreadyCrit, projectile.Spell.Name, target);
                }

                //Check that the npc has not been destroyed by the splash spell
                //TODO: Actually implement this, since null check is wrong.
                if (target == null)
                {
                    return;
                }
            }

            if (targetPlayer == null && !(target is Npc) || target.IsDead())
            {
                return;
            }

            //If there is a knockback, knock them backwards and make sure its linear (diagonal player movement not coded).
            if (projectile.Knockback > 0 && projectileDir < 4)
            {
                var dash = new Dash(target, projectile.Knockback, projectileDir, false, false, false, false);
            }
        }

        //Attacking with spell
        public virtual void TryAttack(
            Entity target,
            SpellBase spellBase,
            bool onHitTrigger = false,
            bool trapTrigger = false,
            bool alreadyCrit = false,
            string sourceSpellName = "",
            bool fromProjectile = false,
            bool isNextSpell = false,
            bool reUseValues = false,
            int baseDamage = 0,
            int secondaryDamage = 0,
            bool isAnchored = false
        )
        {
            if (target is Resource)
            {
                return;
            }

            if (spellBase == null)
            {
                return;
            }
            if (!fromProjectile)
            {
                // Projectile are already managed at this point
                if (this is Player p && target is Npc npcenemy)
                {
                    p.FightingNpcBaseIds.AddOrUpdate(npcenemy.Base.Id, CombatTimer, (guid, t) => CombatTimer);
                    var npclist = p.FightingListNpcs.GetOrAdd(npcenemy.Base.Id, new ConcurrentDictionary<Npc, AttackInfo>());
                    var attackinfo = new AttackInfo((DamageType)spellBase.Combat.DamageType, AttackType.Spell,
                        (ElementalType) spellBase.ElementalType, spellBase.Id);
                    npclist.AddOrUpdate(npcenemy, attackinfo, (npc, info) => attackinfo);
                    if (!npcenemy.CanPlayerSpell(p))
                    {
                        // Try to trigger possible phase related to spell
                        npcenemy.HandlePhases(p);
                        return;
                    }
                }
                else if (this is Npc n && target is Player penemy)
                {
                    penemy.FightingNpcBaseIds.AddOrUpdate(n.Base.Id, CombatTimer, (guid, t) => CombatTimer);
                    var npclist = penemy.FightingListNpcs.GetOrAdd(n.Base.Id, new ConcurrentDictionary<Npc, AttackInfo>());
                    npclist.AddOrUpdate(n, npc => null, (npc, info) => info);
                }
            }
           

            //Check for taunt status and trying to attack a target that has not taunted you.
            if (!trapTrigger) //Traps ignore taunts.
            {
                foreach (var status in CachedStatuses)
                {
                    if (status.Type == StatusTypes.Taunt)
                    {
                        if (Target != target)
                        {
                            PacketSender.SendActionMsg(this, Strings.Combat.miss, CustomColors.Combat.Missed);

                            return;
                        }
                    }
                }
            }

            if (target != null && target.IsImmuneToElementalType(spellBase.ElementalType))
            {
                PacketSender.SendActionMsg(target, Strings.Combat.immune, CustomColors.Combat.Immune);
                return;
            }

            var deadAnimations = new List<KeyValuePair<Guid, sbyte>>();
            var aliveAnimations = new List<KeyValuePair<Guid, sbyte>>();

            //Only count safe zones and friendly fire if its a dangerous spell! (If one has been used)
            if (!spellBase.Combat.Friendly &&
                (spellBase.Combat.TargetType != (int) SpellTargetTypes.Self || onHitTrigger))
            {
                //If about to hit self with an unfriendly spell (maybe aoe?) return
                if (target == this && spellBase.Combat.Effect != StatusTypes.OnHit)
                {
                    return;
                }

                //Check for parties and safe zones, friendly fire off (unless its healing)
                if (target is Npc && this is Npc npc)
                {
                    if (!npc.CanNpcCombat(target, spellBase.Combat.Friendly))
                    {
                        return;
                    }
                }

                if (target is Player targetPlayer && this is Player player)
                {
                    if (player.IsAllyOf(targetPlayer))
                    {
                        return;
                    }

                    // Check if either the attacker or the defender is in a "safe zone" (Only apply if combat is PVP)
                    if (MapInstance.Get(MapId).ZoneType == MapZones.Safe)
                    {
                        return;
                    }

                    if (MapInstance.Get(target.MapId).ZoneType == MapZones.Safe)
                    {
                        return;
                    }
                }

                if (!CanAttack(target, spellBase))
                {
                    return;
                }
            }
            else
            {
                // For an event source, we use the initial target of the spell for friendly spells
                if (this is EventPageInstance)
                {
                    if (CastTarget is Player && !(target is Player))
                    {
                        // Event is on the side of the players, do not aoe heal other entities
                        return;
                    }
                    else if (!(CastTarget is Player) && target is Player)
                    {
                        // Event is not on the side of the players, do not aoe heal players
                        return;
                    }
                }
                else // Friendly Spell! Do not attack other players/npcs around us.
                {
                    switch (target)
                    {
                        case Player targetPlayer
                        when this is Player player && !IsAllyOf(targetPlayer) && this != target:
                        case Npc _ when this is Npc npc && !npc.CanNpcCombat(target, spellBase.Combat.Friendly):
                            return;
                    }

                    if (target?.GetType() != GetType())
                    {
                        return; // Don't let players aoe heal npcs. Don't let npcs aoe heal players.
                    }
                }
                
            }

            if (spellBase.HitAnimationId != Guid.Empty &&
                (spellBase.Combat.Effect != StatusTypes.OnHit || onHitTrigger))
            {
                deadAnimations.Add(new KeyValuePair<Guid, sbyte>(spellBase.HitAnimationId, (sbyte) Directions.Up));
                aliveAnimations.Add(new KeyValuePair<Guid, sbyte>(spellBase.HitAnimationId, (sbyte) Directions.Up));
            }

            var damageHealth = spellBase.Combat.VitalDiff[(int)Vitals.Health];
            var damageMana = spellBase.Combat.VitalDiff[(int)Vitals.Mana];
            if (reUseValues)
            {
                damageHealth = baseDamage;
                damageMana = secondaryDamage;
            }

            bool isCrit = false;
            if ((spellBase.Combat.Effect != StatusTypes.OnHit || onHitTrigger) &&
                spellBase.Combat.Effect != StatusTypes.Shield)
            {
                isCrit = Attack(
                    target, ref damageHealth, ref damageMana, spellBase.Combat.VitalSteal[(int)Vitals.Health], spellBase.Combat.VitalSteal[(int)Vitals.Mana],
                    (ElementalType)spellBase.ElementalType, (DamageType) spellBase.Combat.DamageType, (Stats) spellBase.Combat.ScalingStat, spellBase.Combat.Scaling, spellBase.Combat.CritChance,
                    spellBase.Combat.CritMultiplier, spellBase.Name, deadAnimations, aliveAnimations, false, spellBase.Combat.CritEffectSpellReplace, alreadyCrit, reUseValues, spellBase.Combat.HoTDoT
                ); //L'appel de la méthode a été modifié par Moussmous pour décrire les actions de combats dans le chat (ajout du nom de l'attaque utilisée)
            }
            if (alreadyCrit && isNextSpell)
            {
                // Handle crit when chaining spells using NextSpell
                isCrit = true;
            }
            if (isCrit && spellBase.Combat.CritEffectSpellId != Guid.Empty && spellBase.Combat.CritEffectSpellReplace)
            {
                // Directly cast the other spell ignoring the effect of the current spell
                CastSpell(spellBase.Combat.CritEffectSpellId, -1, true, spellBase.Name, target, isNextSpell, reUseValues, damageHealth, damageMana);
            }
            else
            {
                // If not a crit or if we need to handle a non-replacing crit

                // First, handle buffs
                var statBuffTime = -1;
                var expireTime = Globals.Timing.Milliseconds + spellBase.Combat.Duration;
                var randomBuff = Randomization.Next(1, 101);
                var effectiveStatBuffs = new bool[(int)Stats.StatCount];
                if (!(target is EventPageInstance)) // No buff on events
                {
                    for (var i = 0; i < (int)Stats.StatCount; i++)
                    {
                        if (randomBuff <= spellBase.Combat.StatDiffChance[i])
                        {
                            target.Stat[i]
                                .AddBuff(
                                    new Buff(spellBase, spellBase.Combat.StatDiff[i], spellBase.Combat.PercentageStatDiff[i], expireTime)
                                );

                            if (spellBase.Combat.StatDiff[i] != 0 || spellBase.Combat.PercentageStatDiff[i] != 0)
                            {
                                statBuffTime = spellBase.Combat.Duration;
                                effectiveStatBuffs[i] = true;
                            }
                        }
                        else
                        {
                            // Reset buffs to 0 when random is not ok
                            target.Stat[i]
                                .AddBuff(
                                    new Buff(spellBase, 0, 0, expireTime)
                                );
                        }
                    }

                    if (statBuffTime == -1)
                    {
                        if (spellBase.Combat.HoTDoT && spellBase.Combat.HotDotInterval > 0)
                        {
                            statBuffTime = spellBase.Combat.Duration;
                        }
                    }
                }

                if (spellBase.Combat.Effect > 0) //Handle status effects
                {
                    //Check for onhit effect to avoid the onhit effect recycling.
                    if (!(onHitTrigger && spellBase.Combat.Effect == StatusTypes.OnHit))
                    {
                        // Check for %chance of applying an extraeffect
                        if (Randomization.Next(1, 101) <= spellBase.Combat.EffectChance)
                        {
                            var sourceStatusName = sourceSpellName;
                            if (alreadyCrit)
                            {
                                sourceStatusName += Strings.Combat.critsuffix;
                            }
                            new Status(
                                target, this, spellBase, spellBase.Combat.Effect, spellBase.Combat.Duration, effectiveStatBuffs,
                                spellBase.Combat.TransformSprite, sourceStatusName
                            );

                            PacketSender.SendActionMsg(
                                target, Strings.Combat.status[(int)spellBase.Combat.Effect], CustomColors.Combat.Status
                            );

                            //If an onhit or shield status bail out as we don't want to do any damage.
                            if (spellBase.Combat.Effect == StatusTypes.OnHit || spellBase.Combat.Effect == StatusTypes.Shield)
                            {
                                Animate(target, aliveAnimations);

                                return;
                            }
                        }
                    }
                }
                else
                {
                    if (statBuffTime > -1)
                    {
                        var sourceStatusName = sourceSpellName;
                        if (alreadyCrit)
                        {
                            sourceStatusName += " (Crit.) ";
                        }
                        new Status(target, this, spellBase, spellBase.Combat.Effect, statBuffTime, effectiveStatBuffs, "", sourceStatusName);
                    }
                }

                //Handle DoT/HoT spells
                if (spellBase.Combat.HoTDoT)
                {
                    var doTFound = false;
                    foreach (var dot in target.CachedDots)
                    {
                        if (dot.SpellBase.Id == spellBase.Id && dot.Target == this)
                        {
                            doTFound = true;
                        }
                    }

                    if (doTFound == false) //no duplicate DoT/HoT spells.
                    {
                        new DoT(this, spellBase.Id, target);
                    }
                }

                //Handle crit spell if needed
                if (isCrit && spellBase.Combat.CritEffectSpellId != Guid.Empty)
                {
                    // Do not reuse values on crit because it's a new additional effect
                    CastSpell(spellBase.Combat.CritEffectSpellId, -1, true, spellBase.Name, target, isNextSpell);
                }
                // Next effect for projectile and area is excluded because handled when they are created
                if (spellBase.Combat.NextEffectSpellId != Guid.Empty && !fromProjectile && !isAnchored && Randomization.Next(1, 101) <= spellBase.Combat.NextEffectSpellChance)
                {
                    var nextIsCrit = isCrit || alreadyCrit;
                    // TODO Check if we reuse crit everytime or not
                    CastSpell(spellBase.Combat.NextEffectSpellId, -1, nextIsCrit, spellBase.Name, target, true, spellBase.Combat.NextEffectSpellReUseValues, damageHealth, damageMana);
                }
            }
            //TODO Put nextspell here if we want to handle even with critreplace enabled
            
        }

        private void Animate(Entity target, List<KeyValuePair<Guid, sbyte>> animations)
        {
            foreach (var anim in animations)
            {
                PacketSender.SendAnimationToProximity(anim.Key, 1, target.Id, target.MapId, 0, 0, anim.Value);
            }
        }

        //Attacking with weapon or unarmed.
        public virtual void TryAttack(Entity target)
        {
            //See player and npc override of this virtual void
        }

        public bool IsImmuneToElementalType(int elementalType)
        {
            return (Options.Combat.TableElementalTypes[(int)ElementalTypes[0]][elementalType] == 0
                        || Options.Combat.TableElementalTypes[(int)ElementalTypes[1]][elementalType] == 0);
        }
        //Attack using a weapon or unarmed
        public virtual void TryAttack(
            Entity target,
            int baseDamage,
            DamageType damageType,
            Stats scalingStat,
            int scaling,
            int critChance,
            double critMultiplier,
            List<KeyValuePair<Guid, sbyte>> deadAnimations = null,
            List<KeyValuePair<Guid, sbyte>> aliveAnimations = null,
            ItemBase weapon = null,
            bool alreadyCrit = false
        )
        {
            if (AttackTimer > Globals.Timing.Milliseconds)
            {
                return;
            }

            //Check for parties and safe zones, friendly fire off (unless its healing)
            if (target is Player targetPlayer && this is Player player)
            {
                if (!PvpStadiumUnit.StadiumQueue.TryGetValue(targetPlayer.Id, out var playerUnit) ||
                    playerUnit.StadiumState != PvpStadiumState.MatchOnGoing)
                {
                    if (player.InParty(targetPlayer))
                    {
                        return;
                    }
                }

                //Check if either the attacker or the defender is in a "safe zone" (Only apply if combat is PVP)
                //Player interaction common events
                targetPlayer.StartCommonEventsWithTrigger(CommonEventTrigger.PlayerInteract, "", this.Name);

                if (MapInstance.Get(MapId)?.ZoneType == MapZones.Safe)
                {
                    return;
                }

                if (MapInstance.Get(target.MapId)?.ZoneType == MapZones.Safe)
                {
                    return;
                }
            }

            //Check for taunt status and trying to attack a target that has not taunted you.
            foreach (var status in CachedStatuses)
            {
                if (status.Type == StatusTypes.Taunt)
                {
                    if (Target != target)
                    {
                        PacketSender.SendActionMsg(this, Strings.Combat.miss, CustomColors.Combat.Missed);

                        return;
                    }
                }
            }

            AttackTimer = Globals.Timing.Milliseconds + CalculateAttackTime();

            //Check if the attacker is blinded.
            foreach (var status in CachedStatuses)
            {
                if (status.Type == StatusTypes.Stun ||
                    status.Type == StatusTypes.Blind ||
                    status.Type == StatusTypes.Sleep)
                {
                    PacketSender.SendActionMsg(this, Strings.Combat.miss, CustomColors.Combat.Missed);
                    PacketSender.SendEntityAttack(this, CalculateAttackTime());

                    return;
                }
            }
            bool isCrit = false;
            var damageHealth = baseDamage;
            var damageMana = 0;
            if (weapon == null)
            {
                if (target != null && target.IsImmuneToElementalType((int)ElementalType.None))
                {
                    PacketSender.SendActionMsg(target, Strings.Combat.immune, CustomColors.Combat.Immune);
                    return;
                }
                isCrit = Attack(
                    target, ref damageHealth, ref damageMana, 0, 0, ElementalType.None,
                    damageType, scalingStat, scaling, critChance, critMultiplier, null, deadAnimations,
                    aliveAnimations, true
                ); //L'appel de la méthode a été modifié par Moussmous pour décrire les actions de combats dans le chat (ajout du nom de l'attaque utilisée)
            }
            else
            {
                if (target != null && target.IsImmuneToElementalType(weapon.ElementalType))
                {
                    PacketSender.SendActionMsg(target, Strings.Combat.immune, CustomColors.Combat.Immune);
                    return;
                }
                isCrit = Attack(
                    target, ref damageHealth, ref damageMana, 0, 0, (ElementalType)weapon.ElementalType,
                    damageType, scalingStat, scaling, critChance, critMultiplier, weapon.Name, deadAnimations,
                    aliveAnimations, true, weapon.CritEffectSpellReplace, alreadyCrit
                ); //L'appel de la méthode a été modifié par Moussmous pour décrire les actions de combats dans le chat (ajout du nom de l'attaque utilisée)
                if (isCrit && weapon.CritEffectSpellId != Guid.Empty)
                {
                    //TryAttack(target, weapon.CritEffectSpell, false, false, true, weapon.Name);
                    CastSpell(weapon.CritEffectSpellId, -1, true, weapon.Name, target);
                }
            }
            
        }

        //Return true if the attack is a critical hit
        public bool Attack(
            Entity enemy,
            ref int baseDamage,
            ref int secondaryDamage,
            int stealBase,
            int stealSecondary,
            ElementalType elementalType,
            DamageType damageType,
            Stats scalingStat,
            int scaling,
            int critChance,
            double critMultiplier,
            string name,   //A été rajouté par Moussmous pour décrire le nom de l'attaque utilisée pour l'utiliser dans les logs de chats de combat
            List<KeyValuePair<Guid, sbyte>> deadAnimations = null,
            List<KeyValuePair<Guid, sbyte>> aliveAnimations = null,
            bool isAutoAttack = false,
            bool critReplace = false,
            bool alreadyCrit = false,
            bool reUseValues = false,
            bool hasDot = false
        )
        {
            var originalDamage = baseDamage;
            var damagingAttack = baseDamage > 0;
            if (enemy == null)
            {
                return false;
            }

            var invulnerable = enemy.CachedStatuses.Any(status => status.Type == StatusTypes.Invulnerable);
            string chatLogMessage = "";
            bool isCrit = false;
            //Is this a critical hit?
            if (!alreadyCrit)
            {
                if (Randomization.Next(1, 101) > critChance)
                {
                    critMultiplier = 1;
                }
                else
                {
                    if (!reUseValues)
                    {
                        isCrit = true;
                    }
                }
            }
            if (this is Player || enemy is Player)
            {
                if (name != null)
                {
                    if (!alreadyCrit)
                    {
                        chatLogMessage += this.Name + Strings.Combat.useAttack + name;
                        chatLogMessage += ".";
                    }
                }
                else
                {
                    if (!(this is Player))
                    {
                        chatLogMessage += this.Name + Strings.Combat.npcunarmed;
                    }
                    else
                    {
                        chatLogMessage += this.Name + Strings.Combat.playerunarmed;
                    }
                    chatLogMessage += ".";
                }
                if (isCrit)
                {
                    chatLogMessage += " [" + Strings.Combat.critical + "]";
                }

            }
            if (isCrit)
            {
                if(!(enemy is Resource))
                {
                    // Display the critical message on the concerned entity
                    PacketSender.SendActionMsg(enemy, Strings.Combat.critical, CustomColors.Combat.Critical);
                }
                if (critReplace)
                {
                    // Display the critical message log and exit the function to execute after the crit spell
                    if (Options.Combat.EnableCombatChatMessages && !string.IsNullOrEmpty(chatLogMessage) && !(enemy is Resource))
                    {
                        if (this is Player myPlayer)
                        {
                            PacketSender.SendChatMsg(myPlayer, chatLogMessage, ChatMessageType.Combat);
                        }
                        else if (enemy is Player myPlayerEnemy)
                        {
                            PacketSender.SendChatMsg(myPlayerEnemy, chatLogMessage, ChatMessageType.Combat);
                        }
                    }
                    return true;
                }
            }
            if (hasDot)
            {
                return isCrit;
            }
            bool isFixedDamage = false;
            //If spell from event or for ressources, fixed damage
            if (this is EventPageInstance)
            {
                if (this.Stat == null || this.Stat.Contains(null))
                {
                    isFixedDamage = true;
                } 
            }
            else if (enemy is Resource)
            {
                isFixedDamage = true;
            }
            //Calculate Damages
            if (baseDamage != 0)
            {
                if (isFixedDamage || reUseValues)
                {
                    baseDamage = originalDamage;
                }
                else
                {
                    baseDamage = Formulas.CalculateDamage(
                    baseDamage, elementalType, damageType, scalingStat, scaling, critMultiplier, this, enemy
                );
                }
                
                if (baseDamage < 0 && damagingAttack)
                {
                    baseDamage = 0;
                }
                if (baseDamage > 0 && enemy.HasVital(Vitals.Health) && !invulnerable)
                {
                    //Substract hp and steal if needed
                    var amounthp = enemy.GetVital(Vitals.Health);
                    enemy.SubVital(Vitals.Health, (int)baseDamage);
                    amounthp = (int)((amounthp - enemy.GetVital(Vitals.Health)) * stealBase / 100.0);
                    //A été rajouté par Moussmous pour décrire les actions de combats dans le chat
                    //Ici ça affiche les attaques de base (reçu et donné)
                    if (Options.Combat.EnableCombatChatMessages && !(enemy is Resource))
                    {
                        if (name == null) // Cas où les dégats sont provoqués par une attaque directe mais pas une abilité quoi
                        {
                            if (this is Player myPlayer)
                            {
                                PacketSender.SendChatMsg(myPlayer, chatLogMessage + " " + enemy.Name + Strings.Combat.lost + (int)baseDamage + " " + Strings.Combat.vitals[0], ChatMessageType.Combat);
                            }
                            else if (enemy is Player myPlayerEnemy)
                            {
                                PacketSender.SendChatMsg(myPlayerEnemy, chatLogMessage + " " + myPlayerEnemy.Name + Strings.Combat.lost + (int)baseDamage + " " + Strings.Combat.vitals[0], ChatMessageType.Combat);
                            }
                        }
                        else //Cas où les dégats sont provoqués par une abilité
                        {
                            if (alreadyCrit)
                            {
                                chatLogMessage += Strings.Combat.criticaleffect;
                            }
                            if (this is Player myPlayer)
                            {
                                PacketSender.SendChatMsg(myPlayer, chatLogMessage + " " + enemy.Name + Strings.Combat.lost + (int)baseDamage + " " + Strings.Combat.vitals[0], ChatMessageType.Combat);
                            }
                            else if (enemy is Player myPlayerEnemy)
                            {
                                PacketSender.SendChatMsg(myPlayerEnemy, chatLogMessage + " " + myPlayerEnemy.Name + Strings.Combat.lost + (int)baseDamage + " " + Strings.Combat.vitals[0], ChatMessageType.Combat);
                            }
                        }
                    }
                    //------------------------------------------------------------------------------------------
                    switch (damageType)
                    {
                        case DamageType.Physical:
                            PacketSender.SendActionMsg(
                                enemy, Strings.Combat.removesymbol + (int) baseDamage,
                                CustomColors.Combat.PhysicalDamage
                            );
                           
                            break;

                        case DamageType.Magic:
                            PacketSender.SendActionMsg(
                                enemy, Strings.Combat.removesymbol + (int) baseDamage, CustomColors.Combat.MagicDamage
                            );

                            break;

                        case DamageType.True:
                            PacketSender.SendActionMsg(
                                enemy, Strings.Combat.removesymbol + (int) baseDamage, CustomColors.Combat.TrueDamage
                            );

                            break;
                    }
                    if (stealBase > 0 && amounthp > 0)
                    {
                        AddVital(Vitals.Health, amounthp);
                        PacketSender.SendActionMsg(
                               this, Strings.Combat.addsymbol + amounthp, CustomColors.Combat.Heal
                           );
                    }
                    var toRemove = new List<Status>();
                    foreach (var status in enemy.CachedStatuses.ToArray())  // ToArray the Array since removing a status will.. you know, change the collection.
                    {
                        //Wake up any sleeping targets targets and take stealthed entities out of stealth
                        if (status.Type == StatusTypes.Sleep || status.Type == StatusTypes.Stealth)
                        {
                            status.RemoveStatus();
                        }
                    }

                    // Add the attacker to the Npcs threat and loot table.
                    if (enemy is Npc enemyNpc)
                    {
                        var dmgMap = enemyNpc.DamageMap;
                        dmgMap.TryGetValue(this, out var damage);
                        dmgMap[this] = damage + baseDamage;

                        //No despawn during a fight
                        enemyNpc.CanDespawn = false;

                        enemyNpc.LootMap.TryAdd(Id, true);
                        enemyNpc.LootMapCache = enemyNpc.LootMap.Keys.ToArray();
                        enemyNpc.TryFindNewTarget(Timing.Global.Milliseconds, default, false, this);
                    }

                    enemy.NotifySwarm(this);
                }
                else if (baseDamage < 0 && !enemy.IsFullVital(Vitals.Health))
                {
                    enemy.AddVital(Vitals.Health, (int) -baseDamage);
                    PacketSender.SendActionMsg(
                        enemy, Strings.Combat.addsymbol + (int) Math.Abs(baseDamage), CustomColors.Combat.Heal
                    );
                }
            }
            else
            {
                if (Options.Combat.EnableCombatChatMessages && !string.IsNullOrEmpty(chatLogMessage) && !(enemy is Resource))
                {
                    if (this is Player myPlayer)
                    {
                        PacketSender.SendChatMsg(myPlayer, chatLogMessage, ChatMessageType.Combat);
                    }
                    else if (enemy is Player myPlayerEnemy)
                    {
                        PacketSender.SendChatMsg(myPlayerEnemy, chatLogMessage, ChatMessageType.Combat);
                    }
                }
            }

            // Check for mana damage
            originalDamage = secondaryDamage;
            damagingAttack = secondaryDamage > 0;
            if (secondaryDamage != 0)
            {
                if (isFixedDamage || reUseValues)
                {
                    secondaryDamage = originalDamage;
                }
                else // Scale if not fixed damage
                {
                    secondaryDamage = Formulas.CalculateDamage(
                        secondaryDamage, elementalType, damageType, scalingStat, scaling, critMultiplier, this, enemy);
                }
                if (secondaryDamage < 0 && damagingAttack)
                {
                    secondaryDamage = 0;
                }

                if (secondaryDamage > 0 && enemy.HasVital(Vitals.Mana) && !invulnerable)
                {
                    // Substract mana and steal if needed
                    var amountmana = enemy.GetVital(Vitals.Mana);
                    //If we took damage lets reset our combat timer
                    enemy.SubVital(Vitals.Mana, (int) secondaryDamage);
                    amountmana = (int)((amountmana - enemy.GetVital(Vitals.Mana)) * stealSecondary / 100.0);
                    PacketSender.SendActionMsg(
                        enemy, Strings.Combat.removesymbol + (int) secondaryDamage, CustomColors.Combat.RemoveMana
                    );
                    if (stealSecondary > 0 && amountmana > 0)
                    {
                        AddVital(Vitals.Mana, amountmana);
                        PacketSender.SendActionMsg(
                            this, Strings.Combat.addsymbol + amountmana, CustomColors.Combat.AddMana
                        );
                    }
                    //No Matter what, if we attack the entitiy, make them chase us
                    if (enemy is Npc enemyNpc)
                    {
                        enemyNpc.TryFindNewTarget(Timing.Global.Milliseconds, default, false, this);
                    }

                    enemy.NotifySwarm(this);
                }
                else if (secondaryDamage < 0 && !enemy.IsFullVital(Vitals.Mana))
                {
                    enemy.AddVital(Vitals.Mana, (int) -secondaryDamage);
                    PacketSender.SendActionMsg(
                        enemy, Strings.Combat.addsymbol + (int) Math.Abs(secondaryDamage), CustomColors.Combat.AddMana
                    );
                }
            }

            // Set combat timers!
            enemy.CombatTimer = Globals.Timing.Milliseconds + Options.CombatTime;
            CombatTimer = Globals.Timing.Milliseconds + Options.CombatTime;

            //Check for lifesteal
            if (GetType() == typeof(Player) && enemy.GetType() != typeof(Resource))
            {
                var lifesteal = ((Player) this).GetLifeSteal() / 100;
                var healthRecovered = lifesteal * baseDamage;
                if (healthRecovered > 0) //Don't send any +0 msg's.
                {
                    AddVital(Vitals.Health, (int) healthRecovered);
                    PacketSender.SendActionMsg(
                        this, Strings.Combat.addsymbol + (int) healthRecovered, CustomColors.Combat.Heal
                    );
                }
            }

            //Dead entity check
            if (enemy.GetVital(Vitals.Health) <= 0)
            {
                if (enemy.GetType() == typeof(Npc) || enemy.GetType() == typeof(Resource))
                {
                    lock (enemy.EntityLock)
                    {
                        enemy.Die(true, this);
                    }
                }
                else
                {
                    bool stadiumKill = false;
                    bool pvpKill = false;
                    //PVP Kill common events
                    if (!enemy.Dead && enemy is Player && this is Player)
                    {
                        // No trigger if it is a stadium kill (we handle it in Stadium EndMatch method)
                        pvpKill = true;
                        if (PvpStadiumUnit.StadiumQueue.TryGetValue(this.Id, out var playerUnit) && playerUnit.StadiumState == PvpStadiumState.MatchOnGoing)
                        {
                            if (PvpStadiumUnit.StadiumQueue.TryGetValue(enemy.Id, out playerUnit) && playerUnit.StadiumState == PvpStadiumState.MatchOnGoing)
                            {
                                stadiumKill = true;
                            }
                        }
                        if (!stadiumKill)
                        {
                            ((Player)this).StartCommonEventsWithTrigger(CommonEventTrigger.PVPKill, "", enemy.Name);
                            ((Player)enemy).StartCommonEventsWithTrigger(CommonEventTrigger.PVPDeath, "", this.Name);
                        }
                    }

                    lock (enemy.EntityLock)
                    {
                        // No drops items when pvpkill
                        enemy.Die(!pvpKill, this);
                    }
                }

                if (deadAnimations != null)
                {
                    foreach (var anim in deadAnimations)
                    {
                        PacketSender.SendAnimationToProximity(
                            anim.Key, -1, Id, enemy.MapId, (byte) enemy.X, (byte) enemy.Y, anim.Value
                        );
                    }
                }
            }
            else
            {
                //Hit him, make him mad and send the vital update.
                if (aliveAnimations?.Count > 0)
                {
                    Animate(enemy, aliveAnimations);
                }

                //Check for any onhit damage bonus effects!
                CheckForOnhitAttack(enemy, isAutoAttack);
            }

            // Add a timer before able to make the next move. NO NEED with our system (autoattack and spells timing conditions)
            /*if (GetType() == typeof(Npc))
            {
                ((Npc) this).MoveTimer = Globals.Timing.Milliseconds + (long) GetMovementTime();
            }*/

            if (this is Player && enemy is Npc)
            {
                ((Npc)enemy).HandlePhases((Player)this);
            }
            else if (this is Npc && enemy is Player)
            {
                ((Npc)this).HandlePhases((Player)enemy);
            }
            return isCrit;
        }

        void CheckForOnhitAttack(Entity enemy, bool isAutoAttack)
        {
            if (isAutoAttack) //Ignore spell damage.
            {
                foreach (var status in CachedStatuses)
                {
                    if (status.Type == StatusTypes.OnHit)
                    {
                        if (status.Spell?.ImpactAnimation != null)
                        {
                            PacketSender.SendAnimationToProximity(status.Spell.ImpactAnimationId, -1, Guid.Empty, enemy.MapId, (byte)enemy.X, (byte)enemy.Y, (sbyte)Directions.Up);
                        }
                        TryAttack(enemy, status.Spell, true);
                        status.RemoveStatus();
                    }
                }
            }
        }

        public virtual void KilledEntity(Entity entity)
        {
        }

        public bool CanCastSpell(Guid spellId, Entity target)
        {
            return CanCastSpell(SpellBase.Get(spellId), target);
        }

        public virtual bool CanCastSpell(SpellBase spellDescriptor, Entity target)
        {
            if (spellDescriptor == null)
            {
                return false;
            }

            var spellCombat = spellDescriptor.Combat;
            if (spellDescriptor.SpellType != SpellTypes.CombatSpell && spellDescriptor.SpellType != SpellTypes.Event ||
                spellCombat == null)
            {
                return true;
            }

            if (spellCombat.TargetType == SpellTargetTypes.Targeted)
            {
                return target == null || InRangeOf(target, spellCombat.CastRange, spellCombat.SquareRange);
            }

            return true;
        }

        public virtual void CastSpell(Guid spellId, int spellSlot = -1, bool alreadyCrit = false, string sourceSpellName = null, Entity specificTarget = null,
            bool isNextSpell = false, bool reUseValues = false, int baseDamage = 0, int secondaryDamage = 0)
        {
            var spellBase = SpellBase.Get(spellId);
            if (spellBase == null)
            {
                return;
            }
            Entity baseTarget = specificTarget;
            if (baseTarget == null)
            {
                // Handle some cases with a specific target like projectiles on crit and others
                baseTarget = CastTarget;
            }
            if (!alreadyCrit && !isNextSpell && !CanCastSpell(spellBase, baseTarget))
            {
                // Check CanCast only if not already checked before a crit or a nextspell
                return;
            }

            //TODO Check alreadycrit or nextspell if we want to cancel vital/mana costs
            if (spellBase.VitalCost[(int)Vitals.Mana] > 0)
            {
                SubVital(Vitals.Mana, spellBase.VitalCost[(int)Vitals.Mana]);
            }
            else
            {
                AddVital(Vitals.Mana, -spellBase.VitalCost[(int)Vitals.Mana]);
            }

            if (spellBase.VitalCost[(int)Vitals.Health] > 0)
            {
                SubVital(Vitals.Health, spellBase.VitalCost[(int)Vitals.Health]);
            }
            else
            {
                AddVital(Vitals.Health, -spellBase.VitalCost[(int)Vitals.Health]);
            }

            switch (spellBase.SpellType)
            {
                case SpellTypes.CombatSpell:
                case SpellTypes.Event:

                    switch (spellBase.Combat.TargetType)
                    {
                        case SpellTargetTypes.Self:
                            // Play the impact and tiles animation on the caster current tile
                            if (spellBase.ImpactAnimation != null)
                            {
                                PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                            }
                            if (spellBase.TilesAnimation != null)
                            {
                                PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                            }
                            TryAttack(this, spellBase, false, false, alreadyCrit, sourceSpellName, false, isNextSpell, reUseValues, baseDamage, secondaryDamage);

                            break;
                        case SpellTargetTypes.Targeted:
                            if (baseTarget == null)
                            {
                                return;
                            }

                            //If target has stealthed we cannot hit the spell.
                            foreach (var status in baseTarget.CachedStatuses)
                            {
                                if (status.Type == StatusTypes.Stealth)
                                {
                                    return;
                                }
                            }

                            // Play the impact animation on the target tile
                            if (spellBase.ImpactAnimation != null)
                            {
                                PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, baseTarget.MapId, (byte)baseTarget.X, (byte)baseTarget.Y, (sbyte)Directions.Up);
                            }

                            if (spellBase.Combat.HitRadius > 0) //Single target spells with AoE hit radius'
                            {
                                HandleAoESpell(
                                    spellId, spellBase.Combat.HitRadius, baseTarget.MapId, baseTarget.X, baseTarget.Y,
                                    alreadyCrit, sourceSpellName, isNextSpell, reUseValues, baseDamage, secondaryDamage
                                );
                            }
                            else
                            {
                                // Play the tile animation on the target tile
                                if (spellBase.TilesAnimation != null)
                                {
                                    PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, baseTarget.MapId, (byte)baseTarget.X, (byte)baseTarget.Y, (sbyte)Directions.Up);
                                }
                                TryAttack(baseTarget, spellBase, false, false, alreadyCrit, sourceSpellName, false, isNextSpell, reUseValues, baseDamage, secondaryDamage);
                            }

                            break;
                        case SpellTargetTypes.Anchored:
                            if (spellBase.Combat.CastRange > 0)
                            {
                                TileHelper tile;
                                byte z = (byte)Z;
                                if (specificTarget == null)
                                {
                                    tile = new TileHelper(MapId, X, Y);
                                }
                                else
                                {
                                    tile = new TileHelper(specificTarget.MapId, specificTarget.X, specificTarget.Y);
                                    z = (byte)specificTarget.Z;
                                }
                                if (tile.Translate(Projectile.GetRangeX(Dir, spellBase.Combat.CastRange), Projectile.GetRangeY(Dir, spellBase.Combat.CastRange)))
                                {
                                    // Play the impact animation on the center tile
                                    if (spellBase.ImpactAnimation != null)
                                    {
                                        PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, tile.GetMapId(), tile.GetX(), tile.GetY(), (sbyte)Directions.Up);
                                    }

                                    if (spellBase.Combat.Projectile?.Speed == 0)
                                    {
                                        // Projectile with speed equal to 0 is a custom Area
                                        MapInstance.Get(tile.GetMapId())
                                            .SpawnMapProjectile(
                                                this, spellBase.Combat.Projectile, spellBase, null, tile.GetMapId(), tile.GetX(), tile.GetY(), z,
                                                (byte)Dir, null, alreadyCrit
                                            );
                                    }
                                    else
                                    {
                                        HandleAoESpell(spellId, spellBase.Combat.HitRadius, tile.GetMapId(), tile.GetX(), tile.GetY(), alreadyCrit, sourceSpellName, isNextSpell, reUseValues, baseDamage, secondaryDamage);
                                    }
                                }
                            }
                            else
                            {
                                var areaLocation = specificTarget;
                                if (areaLocation == null)
                                {
                                    areaLocation = this;
                                }

                                // Play the impact animation on the center tile
                                if (spellBase.ImpactAnimation != null)
                                {
                                    PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, areaLocation.MapId, (byte)areaLocation.X, (byte)areaLocation.Y, (sbyte)Directions.Up);
                                }

                                if (spellBase.Combat.Projectile?.Speed == 0)
                                {
                                    // Projectile with speed equal to 0 is a custom Area
                                    MapInstance.Get(MapId)
                                        .SpawnMapProjectile(
                                            this, spellBase.Combat.Projectile, spellBase, null, areaLocation.MapId, (byte)areaLocation.X, (byte)areaLocation.Y, (byte)areaLocation.Z,
                                            (byte)Dir, null, alreadyCrit
                                        );
                                }
                                else
                                {
                                    HandleAoESpell(spellId, spellBase.Combat.HitRadius, areaLocation.MapId, areaLocation.X, areaLocation.Y, alreadyCrit, sourceSpellName, isNextSpell, reUseValues, baseDamage, secondaryDamage, true);
                                }

                                if (spellBase.Combat.NextEffectSpellId != Guid.Empty && Randomization.Next(1, 101) <= spellBase.Combat.NextEffectSpellChance)
                                {
                                    var damageHealth = baseDamage;
                                    var damageMana = secondaryDamage;
                                    // Can not reuse value for projectile because it is calculated on impact
                                    if (isNextSpell)
                                    {
                                        // Transmit the originals base and secondary damage
                                        CastSpell(spellBase.Combat.NextEffectSpellId, -1, alreadyCrit, sourceSpellName, specificTarget, true, reUseValues, damageHealth, damageMana);
                                    }
                                    else
                                    {
                                        // Re-calculte base and secondary damage for the next spell
                                        CastSpell(spellBase.Combat.NextEffectSpellId, -1, alreadyCrit, sourceSpellName, specificTarget, true, false, damageHealth, damageMana);
                                    }
                                }
                            }
                            break;
                        case SpellTargetTypes.Projectile:
                            var projectileBase = spellBase.Combat.Projectile;
                            if (projectileBase != null)
                            {
                                var projStart = specificTarget;
                                if (projStart == null)
                                {
                                    projStart = this;
                                }
                                MapInstance.Get(MapId)
                                    .SpawnMapProjectile(
                                        this, projectileBase, spellBase, null, projStart.MapId, (byte)projStart.X, (byte)projStart.Y, (byte)projStart.Z,
                                        (byte)Dir, null, alreadyCrit
                                    );
                                if (spellBase.Combat.NextEffectSpellId != Guid.Empty && Randomization.Next(1, 101) <= spellBase.Combat.NextEffectSpellChance)
                                {
                                    var damageHealth = baseDamage;
                                    var damageMana = secondaryDamage;
                                    // Can not reuse value for projectile because it is calculated on impact
                                    if (isNextSpell)
                                    {
                                        // Transmit the originals base and secondary damage
                                        CastSpell(spellBase.Combat.NextEffectSpellId, -1, alreadyCrit, sourceSpellName, specificTarget, true, reUseValues, damageHealth, damageMana);
                                    }
                                    else
                                    {
                                        // Re-calculte base and secondary damage for the next spell
                                        CastSpell(spellBase.Combat.NextEffectSpellId, -1, alreadyCrit, sourceSpellName, specificTarget, true, false, damageHealth, damageMana);
                                    }
                                }
                            }

                            break;
                        case SpellTargetTypes.OnHit:
                            if (spellBase.Combat.Effect == StatusTypes.OnHit)
                            {
                                var sourceStatusName = sourceSpellName;
                                if (alreadyCrit)
                                {
                                    sourceStatusName += " (Crit.) ";
                                }
                                new Status(
                                    this, this, spellBase, StatusTypes.OnHit, spellBase.Combat.OnHitDuration, null,
                                    spellBase.Combat.TransformSprite, sourceStatusName
                                );

                                // Play the impact animation on our current tile
                                if (spellBase.ImpactAnimation != null)
                                {
                                    PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                                }

                                PacketSender.SendActionMsg(
                                    this, Strings.Combat.status[(int) spellBase.Combat.Effect],
                                    CustomColors.Combat.Status
                                );
                            }
                            break;
                        case SpellTargetTypes.Trap:
                            // Play the impact animation on our current tile
                            if (spellBase.ImpactAnimation != null)
                            {
                                PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                            }
                            MapInstance.Get(MapId).SpawnTrap(this, spellBase, (byte) X, (byte) Y, (byte) Z);

                            break;
                        default:
                            break;
                    }

                    break;
                case SpellTypes.Warp:
                    if (this is Player)
                    {
                        // Play the tile animation on our tile before tp
                        if (spellBase.TilesAnimation != null)
                        {
                            PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                        }

                        Warp(
                            spellBase.Warp.MapId, spellBase.Warp.X, spellBase.Warp.Y,
                            spellBase.Warp.Dir - 1 == -1 ? (byte) this.Dir : (byte) (spellBase.Warp.Dir - 1)
                        );

                        // Play the impact animation on our new tile after tp
                        if (spellBase.ImpactAnimation != null)
                        {
                            PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, spellBase.Warp.MapId, (byte)spellBase.Warp.X, (byte)spellBase.Warp.Y, (sbyte)Directions.Up);
                        }
                    }

                    break;
                case SpellTypes.WarpTo:
                    if (baseTarget != null)
                    {
                        if (spellBase.TilesAnimation != null)
                        {
                            // Play the tile animation on our tile before tp
                            PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                        }

                        int[] position = GetPositionNearTarget(baseTarget.MapId, baseTarget.X, baseTarget.Y);
                        if (position!= null)
                        {
                            Warp(baseTarget.MapId, (byte)position[0], (byte)position[1], (byte)Dir);
                        }
                        ChangeDir(DirToEnemy(baseTarget, true));

                        if (spellBase.ImpactAnimation != null)
                        {
                            // Play the impact animation on our new tile after tp
                            PacketSender.SendAnimationToProximity(spellBase.ImpactAnimationId, -1, Guid.Empty, MapId, (byte)X, (byte)Y, (sbyte)Directions.Up);
                        }
                        //HandleAoESpell(spellId, spellBase.Combat.CastRange, MapId, X, Y, baseTarget, alreadyCrit, sourceSpellName, isNextSpell, reUseValues, baseDamage, secondaryDamage);
                        TryAttack(baseTarget, spellBase, false, false, alreadyCrit, sourceSpellName, false, isNextSpell, reUseValues, baseDamage, secondaryDamage);
                    }
                    break;
                case SpellTypes.Dash:
                    PacketSender.SendActionMsg(this, Strings.Combat.dash, CustomColors.Combat.Dash);
                    var dash = new Dash(
                        this, spellBase.Combat.CastRange, (byte) Dir, Convert.ToBoolean(spellBase.Dash.IgnoreMapBlocks),
                        Convert.ToBoolean(spellBase.Dash.IgnoreActiveResources),
                        Convert.ToBoolean(spellBase.Dash.IgnoreInactiveResources),
                        Convert.ToBoolean(spellBase.Dash.IgnoreZDimensionAttributes),
                        spellBase
                    );

                    break;
                default:
                    break;
            }

            if (spellSlot >= 0 && spellSlot < Options.MaxPlayerSkills)
            {
                // Player cooldown handling is done elsewhere!
                if (this is Player player)
                {
                    player.UpdateCooldown(spellBase);

                    // Trigger the global cooldown, if we're allowed to.
                    if (!spellBase.IgnoreGlobalCooldown)
                    {
                        player.UpdateGlobalCooldown();
                    }
                }
                else
                {
                    SpellCooldowns[Spells[spellSlot].SpellId] =
                    Globals.Timing.MillisecondsUTC + (int)(spellBase.CooldownDuration);
                }
            }
        }

        private void HandleAoESpell(
            Guid spellId,
            int range,
            Guid startMapId,
            int startX,
            int startY,
            bool alreadyCrit = false,
            string sourceSpellName = "",
            bool isNextSpell = false, bool reUseValues = false, int baseDamage = 0, int secondaryDamage = 0, bool isAnchored = false
        )
        {
            var spellBase = SpellBase.Get(spellId);
            if (spellBase != null)
            {
                var isSquare = spellBase.Combat.SquareHitRadius;
                if (spellBase.SpellType == SpellTypes.WarpTo)
                {
                    isSquare = spellBase.Combat.SquareRange;
                }

                var startMap = MapInstance.Get(startMapId);
                if (startMap != null)
                {
                    // Play the tiles animation on each tile covered by the area
                    if (spellBase.TilesAnimation != null)
                    {
                        TileHelper tile;
                        if (spellBase.Combat.SquareHitRadius)
                        {
                            for (int w = -range; w <= range; w++)
                            {
                                for (int h = -range; h <= range; h++)
                                {
                                    tile = new TileHelper(startMapId, startX, startY);
                                    if (tile.Translate(w, h))
                                    {
                                         PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, tile.GetMapId(), tile.GetX(), tile.GetY(), (sbyte)Directions.Up);
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int w = -range; w <= range; w++)
                            {
                                for (int h = -range; h <= range; h++)
                                {
                                    tile = new TileHelper(startMapId, startX, startY);
                                    if (Math.Abs(w) + Math.Abs(h) <= range && tile.Translate(w, h))
                                    {
                                        PacketSender.SendAnimationToProximity(spellBase.TilesAnimationId, -1, Guid.Empty, tile.GetMapId(), tile.GetX(), tile.GetY(), (sbyte)Directions.Up);
                                    }
                                }
                            }
                        }
                    }

                    var surroundingMaps = startMap.GetSurroundingMaps(true);
                    foreach (var map in surroundingMaps)
                    {
                        foreach (var entity in map.GetCachedEntities())
                        {
                            if (entity != null && (entity is Player || entity is Npc))
                            {
                                if (entity.GetDistanceTo(startMap, startX, startY, isSquare) <= range)
                                {
                                    TryAttack(entity, spellBase, false, false, alreadyCrit, sourceSpellName, false, isNextSpell, reUseValues, baseDamage, secondaryDamage, isAnchored); //Handle damage
                                }
                            }
                        }
                    }
                }
            }
        }

        private int[] GetPositionNearTarget(Guid mapId, int x, int y)
        {
            var map = MapInstance.Get(mapId);
            if (map == null)
            {
                //return new int[] { x, y };
                return null;
            }

            List<int[]> validPosition = new List<int[]>();

            // Start by north, west, est and south
            for (int col = -1; col < 2; col++)
            {
                for (int row = -1; row < 2; row++)
                {
                    if (Math.Abs(col % 2) != Math.Abs(row % 2))
                    {
                        int newX = x + row;
                        int newY = y + col;

                        if (newX >= 0 && newX <= Options.MapWidth &&
                            newY >= 0 && newY <= Options.MapHeight &&
                            !map.TileBlocked(newX, newY))
                        {
                            validPosition.Add(new int[] { newX, newY });
                        }
                    }
                }
            }

            if (validPosition.Count > 0)
            {
                return validPosition[Randomization.Next(0, validPosition.Count)];
            }

            // If nothing found, diagonal direction
            for (int col = -1; col < 2; col++)
            {
                for (int row = -1; row < 2; row++)
                {
                    if (Math.Abs(col % 2) == Math.Abs(row % 2))
                    {
                        int newX = x + row;
                        int newY = y + col;

                        // Tile must not be the target position
                        if (newX >= 0 && newX <= Options.MapWidth &&
                            newY >= 0 && newY <= Options.MapHeight &&
                            !(x + row == x && y + col == y) &&
                            !map.TileBlocked(newX, newY))
                        {
                            validPosition.Add(new int[] { newX, newY });
                        }
                    }
                }
            }

            if (validPosition.Count > 0)
            {
                return validPosition[Randomization.Next(0, validPosition.Count)];
            }

            // If nothing found, return null to indicate it
            return null;
            //return new int[] { x, y };
        }

        //Check if the target is either up, down, left or right of the target on the correct Z dimension.
        protected bool IsOneBlockAway(Entity target)
        {
            var myTile = new TileHelper(MapId, X, Y);
            var enemyTile = new TileHelper(target.MapId, target.X, target.Y);
            if (Z == target.Z)
            {
                myTile.Translate(0, -1); // Target Up
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }

                myTile.Translate(0, 2); // Target Down
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }

                myTile.Translate(-1, -1); // Target Left
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }

                myTile.Translate(2, 0); // Target Right 
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }
                // NO ATTACKS IN DIAGONAL
                /*myTile.Translate(-2, -1); // Target UpLeft
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }

                myTile.Translate(2, 0); // Target UpRight
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }

                myTile.Translate(-2, 2); // Target DownLeft
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }
                myTile.Translate(2, 0); // Target DownRight
                if (myTile.Matches(enemyTile))
                {
                    return true;
                }*/
            }

            return false;
        }

        //These functions only work when one block away.
        protected bool IsFacingTarget(Entity target)
        {
            if (IsOneBlockAway(target))
            {
                var myTile = new TileHelper(MapId, X, Y);
                var enemyTile = new TileHelper(target.MapId, target.X, target.Y);
                myTile.Translate(0, -1);
                if (myTile.Matches(enemyTile) && Dir == (int) Directions.Up)
                {
                    return true;
                }

                myTile.Translate(0, 2);
                if (myTile.Matches(enemyTile) && Dir == (int) Directions.Down)
                {
                    return true;
                }

                myTile.Translate(-1, -1);
                if (myTile.Matches(enemyTile) && Dir == (int) Directions.Left)
                {
                    return true;
                }

                myTile.Translate(2, 0);
                if (myTile.Matches(enemyTile) && Dir == (int) Directions.Right)
                {
                    return true;
                }
                // NO AUTOATTACKS IN DIAGONAL
                /*myTile.Translate(-2, -1);
                if (myTile.Matches(enemyTile) && Dir == (int)Directions.UpLeft)
                {
                    return true;
                }

                myTile.Translate(2, 0);
                if (myTile.Matches(enemyTile) && Dir == (int)Directions.UpRight)
                {
                    return true;
                }

                myTile.Translate(-2, 2);
                if (myTile.Matches(enemyTile) && Dir == (int)Directions.DownLeft)
                {
                    return true;
                }

                myTile.Translate(2, 0);
                if (myTile.Matches(enemyTile) && Dir == (int)Directions.DownRight)
                {
                    return true;
                }*/
            }

            return false;
        }

        public int GetDistanceTo(Entity target, bool squareBased=false)
        {
            if (target != null)
            {
                return GetDistanceTo(target.Map, target.X, target.Y, squareBased);
            }
            //Something is null.. return a value that is out of range :) 
            return 9999;
        }

        public int GetDistanceTo(MapInstance targetMap, int targetX, int targetY, bool squareBased=false)
        {
            return GetDistanceBetween(Map, targetMap, X, targetX, Y, targetY, squareBased);
        }

        public int GetDistanceBetween(MapInstance mapA, MapInstance mapB, int xTileA, int xTileB, int yTileA, int yTileB, bool squareBased=false)
        {
            if (mapA != null && mapB != null && mapA.MapGrid == mapB.MapGrid
            ) //Make sure both maps exist and that they are in the same dimension
            {
                //Calculate World Tile of Me
                var x1 = xTileA + mapA.MapGridX * Options.MapWidth;
                var y1 = yTileA + mapA.MapGridY * Options.MapHeight;

                //Calculate world tile of target
                var x2 = xTileB + mapB.MapGridX * Options.MapWidth;
                var y2 = yTileB + mapB.MapGridY * Options.MapHeight;

                // Changing default distance which was mathematical based
                // return (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                if (squareBased)
                {
                    // For square area/distance
                    return Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                }
                else 
                {
                    // Default distance : tiles that a player travel ro reach the distance
                    return Math.Abs(x1-x2) + Math.Abs(y1 - y2);
                }

            }

            //Something is null.. return a value that is out of range :) 
            return 9999;
        }

        public bool InRangeOf(Entity target, int range, bool squareBased=false)
        {
            var dist = GetDistanceTo(target, squareBased);
            if (dist == 9999)
            {
                return false;
            }

            if (dist <= range)
            {
                return true;
            }

            return false;
        }

        public virtual void NotifySwarm(Entity attacker)
        {
        }

        protected byte DirToEnemy(Entity target, bool only4dirs = false)
        {
            //Calculate World Tile of Me
            var x1 = X + MapInstance.Get(MapId).MapGridX * Options.MapWidth;
            var y1 = Y + MapInstance.Get(MapId).MapGridY * Options.MapHeight;

            //Calculate world tile of target
            var x2 = target.X + MapInstance.Get(target.MapId).MapGridX * Options.MapWidth;
            var y2 = target.Y + MapInstance.Get(target.MapId).MapGridY * Options.MapHeight;
            
            if (only4dirs)
            {
                var angle = 0.0;
                if (x1 - x2 < 0)
                {
                    if (y1 - y2 < 0)
                    {
                        //Down Right
                        angle = Math.Atan2(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                        return angle < Math.PI / 4 ? (byte)Directions.Down : (byte)Directions.Right; 
                    }
                    else if (y1 - y2 > 0)
                    {
                        //Up Right
                        angle = Math.Atan2(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                        return angle < Math.PI / 4 ? (byte)Directions.Up : (byte)Directions.Right;
                    }
                    else if (y1 - y2 == 0)
                    {
                        return (byte)Directions.Right;
                    }
                }
                else if (x1 - x2 > 0)
                {
                    if (y1 - y2 < 0)
                    {
                        //Down Left
                        angle = Math.Atan2(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                        return angle < Math.PI / 4 ? (byte)Directions.Down : (byte)Directions.Left;
                    }
                    else if (y1 - y2 > 0)
                    {
                        //Up Left
                        angle = Math.Atan2(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                        return angle < Math.PI / 4 ? (byte)Directions.Up : (byte)Directions.Left;
                    }
                    else if (y1 - y2 == 0)
                    {
                        return (byte)Directions.Left;
                    }
                }
                else
                {
                    if (y1 - y2 < 0)
                    {
                        return (byte)Directions.Down;
                    }
                    else if (y1 - y2 > 0)
                    {
                        return (byte)Directions.Up;
                    }
                }
            }
            else
            {
                if (x1 - x2 < 0)
                {
                    if (y1 - y2 < 0)
                    {
                        return (byte)Directions.DownRight;
                    }
                    else if (y1 - y2 > 0)
                    {
                        return (byte)Directions.UpRight;
                    }
                    else if (y1 - y2 == 0)
                    {
                        return (byte)Directions.Right;
                    }
                }
                else if (x1 - x2 > 0)
                {
                    if (y1 - y2 < 0)
                    {
                        return (byte)Directions.DownLeft;
                    }
                    else if (y1 - y2 > 0)
                    {
                        return (byte)Directions.UpLeft;
                    }
                    else if (y1 - y2 == 0)
                    {
                        return (byte)Directions.Left;
                    }
                }
                else
                {
                    if (y1 - y2 < 0)
                    {
                        return (byte)Directions.Down;
                    }
                    else if (y1 - y2 > 0)
                    {
                        return (byte)Directions.Up;
                    }
                }
            }
            return 0;
        }

        // Outdated : Check if the target is either up, down, left or right of the target on the correct Z dimension.
        // Check for 8 directions
        protected bool IsOneBlockAway(Guid mapId, int x, int y, int z = 0)
        {
            //Calculate World Tile of Me
            var x1 = X + MapInstance.Get(MapId).MapGridX * Options.MapWidth;
            var y1 = Y + MapInstance.Get(MapId).MapGridY * Options.MapHeight;

            //Calculate world tile of target
            var x2 = x + MapInstance.Get(mapId).MapGridX * Options.MapWidth;
            var y2 = y + MapInstance.Get(mapId).MapGridY * Options.MapHeight;
            if (z == Z)
            {
                // Disable diagonal for npc autoattack
                //if (y1 == y2 || y1 - 1 == y2 || y1 + 1 == y2)
                if (y1 == y2)
                {
                    if (x1 == x2 - 1)
                    {
                        return true;
                    }
                    else if (x1 == x2 + 1)
                    {
                        return true;
                    }
                }
                // Disable diagonal for npc autoattack
                //if (x1 == x2 || x1 - 1 == x2 || x1 + 1 == x2)
                if (x1 == x2)
                {
                    if (y1 == y2 - 1)
                    {
                        return true;
                    }
                    else if (y1 == y2 + 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //Spawning/Dying
        public virtual void Die(bool dropItems = true, Entity killer = null, bool isDespawn = false)
        {
            if (IsDead() || Items == null)
            {
                return;
            }

            var killerEntity = killer;
            if (this is Npc && Options.Npc.HighestDamageDealerIsKiller)
            {
                var highest = ((Npc)this).DamageMapHighest;
                if (highest != null && !highest.IsDead())
                {
                    killerEntity = highest;
                }
            }
            // Run events and other things.
            killerEntity?.KilledEntity(this);

            if (dropItems)
            {
                var lootGenerated = new List<Player>();
                // If this is an NPC, drop loot for every single player that participated in the fight.
                if (this is Npc npc)
                {
                    float bonusLoot = Options.Party.BonusLootChancePercentPerMember / 100;
                    if (npc.Base.IndividualizedLoot)
                    {
                        // Generate loot for every player that has helped damage this monster, as well as their party members.
                        // Keep track of who already got loot generated for them though, or this gets messy!
                        foreach (var entityEntry in npc.LootMapCache)
                        {
                            var player = Player.FindOnline(entityEntry);
                            if (player != null && !lootGenerated.Contains(player))
                            {
                                // is this player in a party?
                                if (player.Party.Count > 0)
                                {
                                    Player[] partyMembersInLootRange;
                                    if (Options.Instance.LootOpts.IndividualizedLootAutoIncludePartyMembers)
                                    {
                                        //Generate loot for all party members in range, even without hit the npc
                                        partyMembersInLootRange = player.Party.Where(partyMember => partyMember.InRangeOf(npc, Options.Party.SharedLootRange)).ToArray();
                                    }
                                    else
                                    {
                                        //Generate loot for all party members in range, only if the member hit the npc
                                        partyMembersInLootRange = player.Party.Where(partyMember => partyMember.InRangeOf(npc, Options.Party.SharedLootRange)
                                            && npc.LootMapCache.Contains(partyMember.Id)).ToArray();
                                    }
                                    var multiplier = 1.0f + (partyMembersInLootRange.Length * bonusLoot);
                                    foreach (var partyMember in partyMembersInLootRange)
                                    {
                                        // They are, so check for all party members and drop if still eligible!
                                        if (!lootGenerated.Contains(partyMember))
                                        {
                                            DropItems(partyMember, true, multiplier);
                                            lootGenerated.Add(partyMember);
                                        }
                                    }
                                    
                                }
                                else
                                {
                                    // They're not in a party, so drop the item if still eligible!
                                    DropItems(player);
                                    lootGenerated.Add(player);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (killerEntity is Player p && p.Party.Count > 0 && Options.Loot.GenerateLootForAllPartyMembers)
                        {
                            // Take into account only party members in range, but not mandatory to hit the npc
                            var partyMembersInLootRange = p.Party.Where(partyMember => partyMember.InRangeOf(npc, Options.Party.SharedLootRange)).ToArray();
                            var multiplier = 1.0f + (partyMembersInLootRange.Length * bonusLoot);
                            foreach (var partyMember in partyMembersInLootRange)
                            {
                                DropItems(partyMember, true, multiplier);
                            }
                        }
                        else
                        {
                            // Not in party or no need to generate loot for every party member
                            DropItems(killerEntity);
                        }
                    }
                    
                    // Clear their loot table and threat table.
                    npc.DamageMap.Clear();
                    npc.LootMap.Clear();
                    npc.LootMapCache = Array.Empty<Guid>();
                }
                else
                {
                    DropItems(killer);
                }
            }
            
            var currentMap = MapInstance.Get(MapId);
            if (currentMap != null)
            {
                foreach (var map in currentMap.GetSurroundingMaps(true))
                {
                    map.ClearEntityTargetsOf(this);
                }
            }

            DoT?.Clear();
            CachedDots = new DoT[0];
            Statuses?.Clear();
            CachedStatuses = new Status[0];
            Stat?.ToList().ForEach(stat => stat?.Reset());

            Dead = true;
        }

        private void DropItems(Entity killer, bool sendUpdate = true, float multiplier = 1)
        {
            // Drop items
            for (var n = 0; n < Items.Count; n++)
            {
                if (Items[n] == null)
                {
                    continue;
                }

                // Don't mess with the actual object.
                var item = Items[n].Clone();
                
                var itemBase = ItemBase.Get(item.ItemId);
                if (itemBase == null)
                {
                    continue;
                }

                //Don't lose bound items on death for players.
                if (this.GetType() == typeof(Player))
                {
                    if (itemBase.DropChanceOnDeath == 0)
                    {
                        continue;
                    }
                }

                //Calculate the killers luck (If they are a player)
                var playerKiller = killer as Player;
                var luck = 1.0 + (playerKiller != null ? playerKiller.GetLuck() : 0) / 100;

                var quantity = item.Quantity;
                Guid lootOwner = Guid.Empty;
                if (this is Player)
                {
                    //Player drop rates
                    // no luck or multiplier for item drop on death
                    if (Randomization.Next(1, 101) >= itemBase.DropChanceOnDeath)
                    {
                        continue;
                    }

                    // It's a player, try and set ownership to the player that killed them.. If it was a player.
                    // Otherwise set to self, so they can come and reclaim their items.
                    lootOwner = playerKiller?.Id ?? Id;

                    // Calculate the loss amount if it's a pleayer
                    int loss;
                    if (itemBase.MinLossOnDeath == itemBase.MaxLossOnDeath)
                    {
                        loss = itemBase.MinLossOnDeath;
                    }
                    else
                    {
                        loss = Randomization.Next(itemBase.MinLossOnDeath, itemBase.MaxLossOnDeath + 1);
                    }
                    if (itemBase.IsLossPercentage)
                    {
                        loss = (int)Math.Round(item.Quantity * loss / 100.0, MidpointRounding.AwayFromZero);
                    }
                    if (loss < item.Quantity)
                    {
                        if (loss == 0)
                        {
                            // Go to next item if we will lose an amount of 0
                            continue;
                        }
                        quantity = loss;
                    }
                }
                else
                {
                    //Npc drop rates

                    // Check if quantity should be randomized or fixed
                    if (item.DropAmountRandom)
                    {
                        quantity = Randomization.Next(0, quantity + 1);
                    }

                    // Iterative mode, loop using the maximum quantity
                    if (item.DropChanceIterative)
                    {
                        // No need to iterate if the drop chance is 100%
                        if (item.DropChance != 100.00)
                        { 
                            int final_quantity = 0;
                            for (int i = 0; i < quantity; i++)
                            {
                                // One chance to loot the item for each iteration
                                if (Randomization.Next(1, 100001) <= (item.DropChance * 1000) * luck * multiplier)
                                {
                                    final_quantity++;
                                }
                            }
                            // Change the quantity variable for spawning the good final iterative amount
                            quantity = final_quantity;
                        }
                    }
                    else
                    {
                        // Only one chance to spawn all the quantity
                        if (Randomization.Next(1, 100001) > (item.DropChance * 1000) * luck * multiplier)
                        {
                            continue;
                        }
                    }

                    // Go to next item if the final quantity is 0
                    if (quantity == 0)
                    {
                        continue;
                    }
                    

                    // Set owner to player that killed this, if there is any.
                    if (playerKiller != null && this is Npc thisNpc)
                    {
                        // Yes, so set the owner to the player that killed it.
                        lootOwner = playerKiller.Id;
                    }

                    // Set the attributes for this item.
                    item.Set(new Item(item.ItemId, quantity, true));
                }

                // Spawn the actual item!
                var map = MapInstance.Get(MapId);
                map?.SpawnItem(X, Y, item, quantity, lootOwner, sendUpdate);

                // Remove the item from inventory if a player.
                var player = this as Player;
                player?.TryTakeItem(Items[n], quantity);
            }


        }

        public virtual bool IsDead()
        {
            return Dead;
        }

        public void Reset()
        {
            for (var i = 0; i < (int) Vitals.VitalCount; i++)
            {
                RestoreVital((Vitals) i);
            }

            Dead = false;
        }

        //Empty virtual functions for players
        public virtual void Warp(Guid newMapId, float newX, float newY, bool adminWarp = false)
        {
            Warp(newMapId, newX, newY, (byte) Dir, adminWarp);
        }

        public virtual void Warp(
            Guid newMapId,
            float newX,
            float newY,
            byte newDir,
            bool adminWarp = false,
            byte zOverride = 0,
            bool mapSave = false
        )
        {
        }

        public virtual EntityPacket EntityPacket(EntityPacket packet = null, Player forPlayer = null, bool isSpawn = false)
        {
            if (packet == null)
            {
                throw new Exception("No packet to populate!");
            }

            packet.EntityId = Id;
            packet.MapId = MapId;
            packet.Name = Name;
            packet.Sprite = Sprite;
            packet.Color = Color;
            packet.Face = Face;
            packet.Level = Level;
            packet.X = (byte) X;
            packet.Y = (byte) Y;
            packet.Z = (byte) Z;
            packet.Dir = (byte) Dir;
            packet.Passable = Passable;
            packet.HideName = HideName;
            packet.HideEntity = HideEntity;
            packet.Animations = Animations.ToArray();
            packet.Vital = GetVitals();
            packet.MaxVital = GetMaxVitals();
            packet.Stats = GetStatValues();
            packet.StatusEffects = StatusPackets();
            packet.NameColor = NameColor;
            packet.HeaderLabel = new LabelPacket(HeaderLabel.Text, HeaderLabel.Color);
            packet.FooterLabel = new LabelPacket(FooterLabel.Text, FooterLabel.Color);

            return packet;
        }

        public StatusPacket[] StatusPackets()
        {
            var statuses = CachedStatuses;
            var statusPackets = new StatusPacket[statuses.Length];
            for (var i = 0; i < statuses.Length; i++)
            {
                var status = statuses[i];
                int[] vitalShields = null;
                if (status.Type == StatusTypes.Shield)
                {
                    vitalShields = new int[(int) Vitals.VitalCount];
                    for (var x = 0; x < (int) Vitals.VitalCount; x++)
                    {
                        vitalShields[x] = status.shield[x];
                    }
                }
                var effectiveStatBuffs = new bool[(int)Stats.StatCount];
                for (var b = 0; b < (int)Stats.StatCount; b++)
                {
                    effectiveStatBuffs[b] = status.EffectiveStatBuffs[b];
                }
                statusPackets[i] = new StatusPacket(
                    status.Spell.Id, status.Type, status.Data, (int) (status.Duration - Globals.Timing.Milliseconds),
                    (int) (status.Duration - status.StartTime), vitalShields, status.SourceSpellName, effectiveStatBuffs
                );
            }

            return statusPackets;
        }

        #region Spell Cooldowns

        [JsonIgnore, Column("SpellCooldowns")]
        public string SpellCooldownsJson
        {
            get => JsonConvert.SerializeObject(SpellCooldowns);
            set => SpellCooldowns = JsonConvert.DeserializeObject<ConcurrentDictionary<Guid, long>>(value ?? "{}");
        }

        [NotMapped] public ConcurrentDictionary<Guid, long> SpellCooldowns = new ConcurrentDictionary<Guid, long>();

        #endregion

    }

}
