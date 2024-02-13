using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.Enums;
using Intersect.GameObjects.Conditions;
using Newtonsoft.Json;

namespace Intersect.GameObjects.Maps.MapRegion
{

    public abstract class MapRegionRule
    {

        public abstract MapRegionRuleTypes Type { get; }
        public ConditionLists ConditionLists { get; set; } = new ConditionLists();

        public MapRegionRule()
        {
        }

        public MapRegionRule(MapRegionRule copy)
        {
        }

    }

}
