using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.Enums;
using Intersect.GameObjects.Conditions;
using Newtonsoft.Json;

namespace Intersect.GameObjects.Maps.MapRegion
{

    public abstract class MapRegionCommand
    {

        public abstract MapRegionCommandTypes Type { get; }
        public ConditionLists ConditionLists { get; set; } = new ConditionLists();

    }

    public class ApplySpellEffectsCommand : MapRegionCommand
    {
        public override MapRegionCommandTypes Type { get; } = MapRegionCommandTypes.ApplySpellEffects;

        public Guid? SpellId { get; set; } = null;
    }

    public class PlayAnimationCommand : MapRegionCommand
    {
        public override MapRegionCommandTypes Type { get; } = MapRegionCommandTypes.PlayAnimation;

        public Guid? AnimId { get; set; } = null;
    }

}
