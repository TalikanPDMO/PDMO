using System;

using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps.MapRegion;
using Intersect.Server.Entities;
using Intersect.Server.Entities.Combat;
using Intersect.Server.Localization;
using Intersect.Server.Networking;

namespace Intersect.Server.Maps
{

    public static class MapRegionCommandProcessing
    {
		
		public static void ResetMapRegionAllCommands(Entity entity)
        {
            if (entity is Player || entity is Npc)
			{
				foreach (var status in entity.CachedStatuses)
				{
					if (status.Duration == -1)
					{
						status.RemoveStatus();
					}
				}
				foreach (var dot in entity.CachedDots)
				{
					if (dot.IsInfinite)
					{
						dot.Expire();
					}
				}
				foreach (var stat in entity.Stat)
				{
					stat.ResetInfiniteBuffs();
				}
			}
        } 

        public static void ProcessCommand(MapRegionCommand command, Entity entity, MapRegionBase mapRegionBase)
        {
            ProcessCommand((dynamic) command, entity, mapRegionBase);
        }
		
		//Apply Status Command
        private static void ProcessCommand(
            ApplySpellEffectsCommand command,
            Entity entity,
			MapRegionBase mapRegionBase
		)
        {
            if (entity is Player || entity is Npc)
			{
				var spell = SpellBase.Get(command.SpellId ?? Guid.Empty);
				var effectiveStatBuffs = new bool[(int)Stats.StatCount];
				for (var i = 0; i < (int)Stats.StatCount; i++)
				{
					entity.Stat[i]
						.AddBuff(
							new Buff(spell, spell.Combat.StatDiff[i], spell.Combat.PercentageStatDiff[i], -1)
						);

					if (spell.Combat.StatDiff[i] != 0 || spell.Combat.PercentageStatDiff[i] != 0)
					{
						effectiveStatBuffs[i] = true;
					}
				}
				var status = new Status(entity, Entity.Neutral, spell, spell.Combat.Effect, -1, effectiveStatBuffs, spell.Combat.TransformSprite, "");
				if (spell.Combat.Effect != StatusTypes.None)
				{
					PacketSender.SendActionMsg(
						entity, Strings.Combat.status[(int)spell.Combat.Effect], CustomColors.Combat.Status
					);
				}
				if (spell.Combat.HoTDoT)
				{
					var doTFound = false;
					foreach (var dot in entity.CachedDots)
					{
						if (dot.SpellBase.Id == spell.Id && dot.Target == entity)
						{
							doTFound = true;
							break;
						}
					}

					if (!doTFound) //no duplicate DoT/HoT spells.
					{
						new DoT(Entity.Neutral, spell.Id, entity, true);
					}
				}
			}
        }
		
		//Play Animation Command
        private static void ProcessCommand(
            PlayAnimationCommand command,
            Entity entity,
			MapRegionBase mapRegionBase
        )
        {
			// TODO Client side : Play infinitely until we leave region ?
			if (entity != null)
			{
				PacketSender.SendAnimationToProximity(
                            command.AnimId ?? Guid.Empty, entity.GetEntityType() == EntityTypes.Event ? 2 : 1, entity.Id,
                            entity.MapId, 0, 0, 0, mapRegionBase.Id
                        );
			}
		}
    }
}
