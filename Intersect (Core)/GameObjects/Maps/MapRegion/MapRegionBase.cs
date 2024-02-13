using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Intersect.Collections;
using Intersect.Compression;
using Intersect.Enums;
using Intersect.GameObjects.Events;
using Intersect.Models;
using Intersect.Utilities;
using Newtonsoft.Json;

namespace Intersect.GameObjects.Maps.MapRegion
{

    public class MapRegionBase : DatabaseObject<MapRegionBase>, IFolderable
    {
        //[NotMapped] public ConditionLists Requirements = new ConditionLists();
        public string EditorName { get; set; } = "";

        public byte[] EditorColor { get; set; } = new byte[4] { 150, 0, 0, 0 };
        public string Folder { get; set; } = "";
        public string Description { get; set; } = "";
        public string Comment { get; set; } = "";

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

        // Rules
        [NotMapped] public List<MapRegionRule> Rules = new List<MapRegionRule>();

        [Column("MapRegionRules")]
        [JsonIgnore]
        public string RulesJson
        {
            get => JsonConvert.SerializeObject(Rules, Formatting.None, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            set => Rules = JsonConvert.DeserializeObject<List<MapRegionRule>>(value);
        }
    }

}
