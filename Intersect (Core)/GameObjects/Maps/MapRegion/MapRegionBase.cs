using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Intersect.Collections;
using Intersect.Compression;
using Intersect.Enums;
using Intersect.GameObjects.Conditions;
using Intersect.GameObjects.Events;
using Intersect.Models;
using Intersect.Utilities;
using Newtonsoft.Json;

namespace Intersect.GameObjects.Maps.MapRegion
{

    public class MapRegionBase : DatabaseObject<MapRegionBase>, IFolderable
    {
        public string EditorName { get; set; } = "";

        public byte[] EditorColor { get; set; } = new byte[4] { 150, 0, 0, 0 };
        public string Folder { get; set; } = "";
        public string Description { get; set; } = "";
        public string Comment { get; set; } = "";

        //Cached Commands Data
        private string mCachedCommandsData = null;
        private List<MapRegionCommand> mCommands = new List<MapRegionCommand>();

        public static string[] EditorFormatNames => Lookup.OrderBy(p => p.Value?.Name)
           .Select(pair => TextUtils.FormatEditorName(pair.Value?.Name, ((MapRegionBase)pair.Value)?.EditorName) ?? Deleted)
           .ToArray();

        [JsonConstructor]
        public MapRegionBase(Guid id) : base(id)
        {
            Name = "New MapRegion";
        }

        //EF wants NO PARAMETERS!!!!!
        public MapRegionBase()
        {
            Name = "New MapRegion";
        }

        [Column("EnterEvent")]
        [JsonProperty]
        public Guid EnterEventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public EventBase EnterEvent
        {
            get => EventBase.Get(EnterEventId);
            set => EnterEventId = value?.Id ?? Guid.Empty;
        }

        [Column("MoveEvent")]
        [JsonProperty]
        public Guid MoveEventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public EventBase MoveEvent
        {
            get => EventBase.Get(MoveEventId);
            set => MoveEventId = value?.Id ?? Guid.Empty;
        }

        [Column("ExitEvent")]
        [JsonProperty]
        public Guid ExitEventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public EventBase ExitEvent
        {
            get => EventBase.Get(ExitEventId);
            set => ExitEventId = value?.Id ?? Guid.Empty;
        }

        // Commands
        [NotMapped]
        public List<MapRegionCommand> Commands
        {
            get => mCommands;
            set
            {
                mCommands = value;
                mCachedCommandsData = JsonConvert.SerializeObject(
                    Commands,
                    new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                        NullValueHandling = NullValueHandling.Ignore,
                        DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    }
                );
            }
        }

        [Column("MapRegionCommands")]
        [JsonIgnore]
        public string CommandsJson
        {
            get => mCachedCommandsData;
            protected set => Commands = JsonConvert.DeserializeObject<List<MapRegionCommand>>(
                value,
                new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                }
            );
        }

        // Enter Requirements
        [NotMapped] public ConditionLists EnterRequirements = new ConditionLists();

        [Column("EnterRequirements")]
        [JsonIgnore]
        public string EnterRequirementsJson
        {
            get => EnterRequirements.Data();
            set => EnterRequirements.Load(value);
        }

        public string CannotEnterMessage { get; set; } = "";

        // Exit Requirements
        [NotMapped] public ConditionLists ExitRequirements = new ConditionLists();

        [Column("ExitRequirements")]
        [JsonIgnore]
        public string ExitRequirementsJson
        {
            get => ExitRequirements.Data();
            set => ExitRequirements.Load(value);
        }

        [JsonIgnore]
        [NotMapped]
        public override string JsonData => JsonConvert.SerializeObject(
            this, Formatting.Indented,
            new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                ObjectCreationHandling = ObjectCreationHandling.Replace
            }
        );

        public string CannotExitMessage { get; set; } = "";

        public override void Load(string json, bool keepCreationTime = false)
        {
            var oldTime = TimeCreated;
            JsonConvert.PopulateObject(
                json, this,
                new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                }
            );

            if (keepCreationTime)
            {
                TimeCreated = oldTime;
            }
        }
    }

}
