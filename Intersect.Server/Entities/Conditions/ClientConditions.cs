using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Conditions;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Switches_and_Variables;
using Intersect.Server.Entities;
using Intersect.Server.General;
using Intersect.Server.Maps;

namespace Intersect.Server.Entities.Conditions
{
    public static partial class ClientConditions
    {
        public static bool MeetsConditionLists(
            ConditionLists lists,
            Entity entity,
            bool singleList = true,
            QuestBase questBase = null
        )
        {
            if (entity == null)
            {
                return false;
            }

            //If no condition lists then this passes
            if (lists.Lists.Count == 0)
            {
                return true;
            }

            for (var i = 0; i < lists.Lists.Count; i++)
            {
                if (MeetsConditionList(lists.Lists[i], entity, questBase))

                //Checks to see if all conditions in this list are met
                {
                    //If all conditions are met.. and we only need a single list to pass then return true
                    if (singleList)
                    {
                        return true;
                    }

                    continue;
                }

                //If not.. and we need all lists to pass then return false
                if (!singleList)
                {
                    return false;
                }
            }

            //There were condition lists. If single list was true then we failed every single list and should return false.
            //If single list was false (meaning we needed to pass all lists) then we've made it.. return true.
            return !singleList;
        }

        public static bool MeetsConditionList(
            ConditionList list,
            Entity entity,
            QuestBase questBase)
        {
            for (var i = 0; i < list.Conditions.Count; i++)
            {
                var meetsCondition = MeetsCondition(list.Conditions[i], entity, questBase);

                if (!meetsCondition)
                {
                    return false;
                }
            }

            return true;
        }

        

        public static bool MeetsCondition(
            Condition condition,
            Entity entity,
            QuestBase questBase)
        {
            if (!condition.IsClient)
            {
                return false;
            }
            var result = ClientConditionHandlerRegistry.CheckCondition(condition, entity, questBase);
            if (condition.Negated)
            {
                result = !result;
            }
            return result;
        }

        public static bool MeetsCondition(
            HasItemCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            var quantity = condition.Quantity;
            if (entity is Player player && player.CountItems(condition.ItemId) >= quantity)
            {
                return true;
            }
            return false;
        }

        public static bool MeetsCondition(
            ClassIsCondition condition,
            Entity entity,
            QuestBase questBase)
        {

            if (entity is Player player && player.ClassId == condition.ClassId)
            {
                return true;
            }

            return false;
        }

        public static bool MeetsCondition(
            KnowsSpellCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity.Spells != null)
            {
                for (var i = 0; i < entity.Spells.Count; i++)
                {
                    if (entity.Spells[i].SpellId == condition.SpellId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool MeetsCondition(
            LevelOrStatCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            var lvlStat = 0;
            if (condition.ComparingLevel)
            {
                lvlStat = entity.Level;
            }
            else
            {
                lvlStat = entity.Stat[(int)condition.Stat].Value();
            }

            switch (condition.Comparator) //Comparator
            {
                case VariableComparators.Equal:
                    if (lvlStat == condition.Value)
                    {
                        return true;
                    }

                    break;
                case VariableComparators.GreaterOrEqual:
                    if (lvlStat >= condition.Value)
                    {
                        return true;
                    }

                    break;
                case VariableComparators.LesserOrEqual:
                    if (lvlStat <= condition.Value)
                    {
                        return true;
                    }

                    break;
                case VariableComparators.Greater:
                    if (lvlStat > condition.Value)
                    {
                        return true;
                    }

                    break;
                case VariableComparators.Less:
                    if (lvlStat < condition.Value)
                    {
                        return true;
                    }

                    break;
                case VariableComparators.NotEqual:
                    if (lvlStat != condition.Value)
                    {
                        return true;
                    }

                    break;
            }

            return false;
        }

        public static bool MeetsCondition(
            TimeBetweenCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            var maxRange = 1440 / TimeBase.GetTimeBase().RangeInterval;
            if (condition.Ranges[0] > -1 &&
                condition.Ranges[1] > -1 &&
                condition.Ranges[0] < maxRange &&
                condition.Ranges[1] < maxRange)
            {
                return Time.IsTimeRangeBetween(condition.Ranges[0], condition.Ranges[1]);
            }

            return true;
        }

        public static bool MeetsCondition(
            QuestInProgressCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity is Player player)
            {
                return player.QuestInProgress(condition.QuestId, condition.Progress, condition.TaskId);
            }
            return false;
        }

        public static bool MeetsCondition(
            QuestCompletedCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity is Player player)
            {
                return player.QuestCompleted(condition.QuestId);
            }
            return false;
            
        }

        public static bool MeetsCondition(
            GenderIsCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity is Player player)
            {
                return player.Gender == condition.Gender;
            }
            return false;
        }

        public static bool MeetsCondition(
            MapIsCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            return entity.MapId == condition.MapId;
        }

        public static bool MeetsCondition(
            IsItemEquippedCondition condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity is Player player)
            {
                for (var i = 0; i < Options.EquipmentSlots.Count; i++)
                {
                    if (player.Equipment[i] >= 0)
                    {
                        if (player.Items[player.Equipment[i]].ItemId == condition.ItemId)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool MeetsCondition(
            InGuildWithRank condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity is Player player)
            {
                return player.Guild != null && player.GuildRank <= condition.Rank;
            }
            return false;
        }

        public static bool MeetsCondition(
            MapZoneTypeIs condition,
            Entity entity,
            QuestBase questBase)
        {
            return entity.Map?.ZoneType == condition.ZoneType;
        }

        public static bool MeetsCondition(
            InPartyWithRole condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity is Player player)
            {
                var partySize = 1;
                if (player?.Party?.Count > 1)
                {
                    partySize = player.Party.Count;

                    // Check party role only if there is a party
                    switch (condition.Role)
                    {
                        //0 is for Any role, nothing to check
                        case 1:
                            // Role is Member
                            if (player.Party[0].Id == player.Id)
                            {
                                return false;
                            }
                            break;
                        case 2:
                            // Role is Leader
                            if (player.Party[0].Id != player.Id)
                            {
                                return false;
                            }
                            break;
                    }
                }
                switch (condition.Comparator) //Comparator
                {
                    case VariableComparators.Equal:
                        if (partySize == condition.Size)
                        {
                            return true;
                        }

                        break;
                    case VariableComparators.GreaterOrEqual:
                        if (partySize >= condition.Size)
                        {
                            return true;
                        }

                        break;
                    case VariableComparators.LesserOrEqual:
                        if (partySize <= condition.Size)
                        {
                            return true;
                        }

                        break;
                    case VariableComparators.Greater:
                        if (partySize > condition.Size)
                        {
                            return true;
                        }

                        break;
                    case VariableComparators.Less:
                        if (partySize < condition.Size)
                        {
                            return true;
                        }

                        break;
                    case VariableComparators.NotEqual:
                        if (partySize != condition.Size)
                        {
                            return true;
                        }

                        break;
                }
            }            
            return false;
        }

        public static bool MeetsCondition(
            PlayerElementalTypeIs condition,
            Entity entity,
            QuestBase questBase)
        {
            if (entity.ElementalTypes == null)
            {
                return false;
            }
            var conditionType = (ElementalType)condition.ElementalType;
            return entity.ElementalTypes[0] == conditionType || entity.ElementalTypes[1] == conditionType;
        }

        public static bool MeetsCondition(
           EntityTypeIs condition,
           Entity entity,
           QuestBase questBase)
        {
            return condition.Entities[(int)entity.GetEntityType()];
        }
    }

}
