using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Intersect.Enums;
using Intersect.GameObjects.Conditions;
using Intersect.GameObjects.Events;
using Intersect.Models;
using Intersect.Utilities;

using Newtonsoft.Json;

namespace Intersect.GameObjects
{

    public class NpcBase : DatabaseObject<NpcBase>, IFolderable
    {
        [NotMapped] public ConditionLists AttackOnSightConditions = new ConditionLists();

        [NotMapped] public List<NpcDrop> Drops = new List<NpcDrop>();

        [NotMapped] public int[] MaxVital = new int[(int)Vitals.VitalCount];

        [NotMapped] public ConditionLists PlayerCanAttackConditions = new ConditionLists();

        [NotMapped] public ConditionLists PlayerCanSpellConditions = new ConditionLists();

        [NotMapped] public ConditionLists PlayerCanProjectileConditions = new ConditionLists();

        [NotMapped] public ConditionLists PlayerFriendConditions = new ConditionLists();

        [NotMapped] public int[] Stats = new int[(int)Enums.Stats.StatCount];

        [NotMapped] public int[] VitalRegen = new int[(int)Vitals.VitalCount];

        [NotMapped] public int[] ElementalTypes = new int[MAX_ELEMENTAL_TYPES];

        [NotMapped] public List<Guid> AddEvents = new List<Guid>(); //Events that need to be added for the quest, int is task id

        [NotMapped] public List<Guid> RemoveEvents = new List<Guid>(); //Events that need to be removed for the quest

        //Editor Only
        [NotMapped]
        [JsonIgnore]
        public Dictionary<Guid, Guid> OriginalPhaseEventIds { get; set; } = new Dictionary<Guid, Guid>();

        public string EditorName { get; set; } = "";
        public static string[] EditorFormatNames => Lookup.OrderBy(p => p.Value?.Name)
            .Select(pair => TextUtils.FormatEditorName(pair.Value?.Name, ((NpcBase)pair.Value)?.EditorName) ?? Deleted)
            .ToArray();

        [JsonConstructor]
        public NpcBase(Guid id) : base(id)
        {
            Name = "New Npc";
        }

        //Parameterless constructor for EF
        public NpcBase()
        {
            Name = "New Npc";
        }

        [Column("AggroList")]
        [JsonIgnore]
        public string JsonAggroList
        {
            get => JsonConvert.SerializeObject(AggroList);
            set => AggroList = JsonConvert.DeserializeObject<List<Guid>>(value);
        }

        [NotMapped]
        public List<Guid> AggroList { get; set; } = new List<Guid>();

        [Column("SwarmList")]
        [JsonIgnore]
        public string JsonSwarmList
        {
            get => JsonConvert.SerializeObject(SwarmList);
            set => SwarmList = JsonConvert.DeserializeObject<List<Guid>>(value);
        }

        [NotMapped]
        public List<Guid> SwarmList { get; set; } = new List<Guid>();

        public bool AttackAllies { get; set; }

        [Column("AttackAnimation")]
        public Guid AttackAnimationId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public AnimationBase AttackAnimation
        {
            get => AnimationBase.Get(AttackAnimationId);
            set => AttackAnimationId = value?.Id ?? Guid.Empty;
        }

        //Behavior
        public bool Aggressive { get; set; }

        public byte Movement { get; set; }

        public bool Swarm { get; set; }

        public int SwarmRange { get; set; }

        public bool SwarmOnPlayer { get; set; } = false;

        public bool SwarmAll { get; set; } = false;

        public byte FleeHealthPercentage { get; set; }

        public bool AttackOnFlee { get; set; } = true;

        public bool FocusHighestDamageDealer { get; set; } = true;

        public int ResetRadius { get; set; }

        public int MaxRandomMove { get; set; } = 3;


        //Conditions
        [Column("PlayerFriendConditions")]
        [JsonIgnore]
        public string PlayerFriendConditionsJson
        {
            get => PlayerFriendConditions.Data();
            set => PlayerFriendConditions.Load(value);
        }

        [Column("AttackOnSightConditions")]
        [JsonIgnore]
        public string AttackOnSightConditionsJson
        {
            get => AttackOnSightConditions.Data();
            set => AttackOnSightConditions.Load(value);
        }

        [Column("PlayerCanAttackConditions")]
        [JsonIgnore]
        public string PlayerCanAttackConditionsJson
        {
            get => PlayerCanAttackConditions.Data();
            set => PlayerCanAttackConditions.Load(value);
        }

        [Column("PlayerCanSpellConditions")]
        [JsonIgnore]
        public string PlayerCanSpellConditionsJson
        {
            get => PlayerCanSpellConditions.Data();
            set => PlayerCanSpellConditions.Load(value);
        }

        [Column("PlayerCanProjectileConditions")]
        [JsonIgnore]
        public string PlayerCanProjectileConditionsJson
        {
            get => PlayerCanProjectileConditions.Data();
            set => PlayerCanProjectileConditions.Load(value);
        }

        //Combat
        public int Damage { get; set; } = 1;

        public int DamageType { get; set; }

        public int CritChance { get; set; }

        public double CritMultiplier { get; set; } = 1.5;

        public int AttackSpeedModifier { get; set; }

        public int AttackSpeedValue { get; set; }

        public bool RegenReset { get; set; } = true;

        //Common Events
        [Column("OnDeathEvent")]
        public Guid OnDeathEventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public EventBase OnDeathEvent
        {
            get => EventBase.Get(OnDeathEventId);
            set => OnDeathEventId = value?.Id ?? Guid.Empty;
        }

        [Column("OnDeathPartyEvent")]
        public Guid OnDeathPartyEventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public EventBase OnDeathPartyEvent
        {
            get => EventBase.Get(OnDeathPartyEventId);
            set => OnDeathPartyEventId = value?.Id ?? Guid.Empty;
        }

        //Drops
        [Column("Drops")]
        [JsonIgnore]
        public string JsonDrops
        {
            get => JsonConvert.SerializeObject(Drops);
            set => Drops = JsonConvert.DeserializeObject<List<NpcDrop>>(value);
        }

        /// <summary>
        /// If true this npc will drop individual loot for all of those who helped slay it.
        /// </summary>
        public bool IndividualizedLoot { get; set; }

        public long Experience { get; set; }

        public int Level { get; set; } = 1;

        //Vitals & Stats
        [Column("MaxVital")]
        [JsonIgnore]
        public string JsonMaxVital
        {
            get => DatabaseUtils.SaveIntArray(MaxVital, (int)Vitals.VitalCount);
            set => DatabaseUtils.LoadIntArray(ref MaxVital, value, (int)Vitals.VitalCount);
        }

        //NPC vs NPC Combat
        public bool NpcVsNpcEnabled { get; set; }

        public int Scaling { get; set; } = 100;

        public int ScalingStat { get; set; }

        public int SightRange { get; set; }

        //Basic Info
        public int SpawnDuration { get; set; }

        public int SpellFrequency { get; set; } = 2;

        //Spells
        [JsonIgnore]
        [Column("Spells")]
        public string CraftsJson
        {
            get => JsonConvert.SerializeObject(Spells, Formatting.None);
            protected set => Spells = JsonConvert.DeserializeObject<DbList<SpellBase>>(value);
        }

        [NotMapped]
        public DbList<SpellBase> Spells { get; set; } = new DbList<SpellBase>();

        public string Sprite { get; set; } = "";

        /// <summary>
        /// The database compatible version of <see cref="Color"/>
        /// </summary>
        [Column("Color")]
        [JsonIgnore]
        public string JsonColor
        {
            get => JsonConvert.SerializeObject(Color);
            set => Color = !string.IsNullOrWhiteSpace(value) ? JsonConvert.DeserializeObject<Color>(value) : Color.White;
        }

        /// <summary>
        /// Defines the ARGB color settings for this Npc.
        /// </summary>
        [NotMapped]
        public Color Color { get; set; } = new Color(255, 255, 255, 255);

        [Column("Stats")]
        [JsonIgnore]
        public string JsonStat
        {
            get => DatabaseUtils.SaveIntArray(Stats, (int)Enums.Stats.StatCount);
            set => DatabaseUtils.LoadIntArray(ref Stats, value, (int)Enums.Stats.StatCount);
        }

        [Column("ElementalTypes")]
        [JsonIgnore]
        public string JsonElementalTypes
        {
            get => DatabaseUtils.SaveIntArray(ElementalTypes, MAX_ELEMENTAL_TYPES);
            set => ElementalTypes = DatabaseUtils.LoadIntArray(value, MAX_ELEMENTAL_TYPES);
        }

        //Vital Regen %
        [JsonIgnore]
        [Column("VitalRegen")]
        public string RegenJson
        {
            get => DatabaseUtils.SaveIntArray(VitalRegen, (int)Vitals.VitalCount);
            set => VitalRegen = DatabaseUtils.LoadIntArray(value, (int)Vitals.VitalCount);
        }

        /// <inheritdoc />
        public string Folder { get; set; } = "";

        //Phases
        [NotMapped] public List<NpcPhase> NpcPhases = new List<NpcPhase>();

        [Column("NpcPhases")]
        [JsonIgnore]
        public string NpcPhasesJson
        {
            get => JsonConvert.SerializeObject(NpcPhases, Formatting.None, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            set => NpcPhases = JsonConvert.DeserializeObject<List<NpcPhase>>(value);
        }

        public SpellBase GetRandomSpell(Random random)
        {
            if (Spells == null || Spells.Count == 0)
            {
                return null;
            }

            var spellIndex = random.Next(0, Spells.Count);
            var spellId = Spells[spellIndex];

            return SpellBase.Get(spellId);
        }

        public int GetPhaseIndex(Guid phaseId)
        {
            for (var i = 0; i < NpcPhases.Count; i++)
            {
                if (NpcPhases[i].Id == phaseId)
                {
                    return i;
                }
            }

            return -1;
        }

    }

    public class NpcDrop
    {

        public double Chance;

        public Guid ItemId;

        public int Quantity;

        public bool Random = false;

        public bool Iterative = false;

    }

    public enum NpcPhasesProgressState
    {
        OnNonePhase = 0,

        OnAnyPhase = 1,

        BeforePhase = 2,

        AfterPhase = 3,

        OnPhase = 4,
    }

    public class NpcPhase
    {
        [NotMapped] [JsonIgnore] public EventBase EditingEvent;

        public NpcPhase(Guid id)
        {
            Id = id;
            Name = "New Name";
            ReplaceSpells = false;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sprite { get; set; } = null;

        [Column("Color")]
        [JsonIgnore]
        public string JsonColor
        {
            get => JsonConvert.SerializeObject(Color);
            set => Color = JsonConvert.DeserializeObject<Color>(value);
        }
        [NotMapped]
        public Color Color { get; set; } = null;

        //Spells
        [NotMapped]
        public DbList<SpellBase> Spells { get; set; } = null;

        [Column("Spells")]
        [JsonIgnore]
        public string JsonSpells
        {
            get => JsonConvert.SerializeObject(Spells, Formatting.None);
            protected set => Spells = JsonConvert.DeserializeObject<DbList<SpellBase>>(value);
        }

        public bool ReplaceSpells { get; set; }

        [Column("BaseStatsDiff")]
        [JsonIgnore]
        public string JsonBaseStatsDiff
        {
            get => JsonConvert.SerializeObject(BaseStatsDiff);
            set => BaseStatsDiff = JsonConvert.DeserializeObject<double[]>(value);
        }

        [NotMapped]
        public double[] BaseStatsDiff { get; set; } = null;

        [NotMapped] public int[] VitalRegen = null;
        //Vital Regen %
        [JsonIgnore]
        [Column("VitalRegen")]
        public string JsonVitalRegen
        {
            get => JsonConvert.SerializeObject(VitalRegen);
            set => VitalRegen = JsonConvert.DeserializeObject<int[]>(value);
        }

        [NotMapped] public int[] ElementalTypes = null;
        //Elemental types
        [JsonIgnore]
        [Column("ElementalTypes")]
        public string JsonElementalTypes
        {
            get => JsonConvert.SerializeObject(ElementalTypes);
            set => ElementalTypes = JsonConvert.DeserializeObject<int[]>(value);
        }

        public int? Damage { get; set; } = null;

        public int? DamageType { get; set; } = null;
        public int? Scaling { get; set; } = null;

        public int? ScalingStat { get; set; } = null;

        public int? CritChance { get; set; } = null;

        public double? CritMultiplier { get; set; } = null;

        public int? AttackSpeedModifier { get; set; } = null;

        public int? AttackSpeedValue { get; set; } = null;

        [Column("AttackAnimation")]
        public Guid? AttackAnimationId { get; set; } = null;

        [NotMapped]
        [JsonIgnore]
        public AnimationBase AttackAnimation
        {
            get => AnimationBase.Get(AttackAnimationId ?? Guid.Empty);
            set => AttackAnimationId = value?.Id;
        }

        public ConditionLists ConditionLists { get; set; } = new ConditionLists();

        public Guid BeginEventId { get; set; }

        [JsonIgnore]
        public EventBase BeginEvent
        {
            get => EventBase.Get(BeginEventId);
            set => BeginEventId = value.Id;
        }

        [Column("BeginSpell")]
        public Guid? BeginSpellId { get; set; } = null;

        [NotMapped]
        [JsonIgnore]
        public SpellBase BeginSpell
        {
            get => SpellBase.Get(BeginSpellId ?? Guid.Empty);
            set => BeginSpellId = value?.Id;
        }

        [Column("BeginAnimation")]
        public Guid? BeginAnimationId { get; set; } = null;

        [NotMapped]
        [JsonIgnore]
        public AnimationBase BeginAnimation
        {
            get => AnimationBase.Get(BeginAnimationId ?? Guid.Empty);
            set => BeginAnimationId = value?.Id;
        }

        public int? Duration { get; set; } = null;

        [JsonIgnore]
        [NotMapped]
        public string JsonData => JsonConvert.SerializeObject(
            this, Formatting.Indented,
            new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                ObjectCreationHandling = ObjectCreationHandling.Replace
            }
        );

        public void Load(string json)
        {
            JsonConvert.PopulateObject(
                json, this,
                new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                }
            );
        }

    }

}
