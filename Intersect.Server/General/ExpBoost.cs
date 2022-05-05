using Intersect.Enums;
using Intersect.Server.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Intersect.Server.General
{

    public class ExpBoost
    {
        public static readonly ConcurrentDictionary<Guid, ExpBoost> PlayerExpBoosts = new ConcurrentDictionary<Guid, ExpBoost>();
        public static readonly ConcurrentDictionary<Guid, ExpBoost> PartyExpBoosts = new ConcurrentDictionary<Guid, ExpBoost>();
        public static readonly ConcurrentDictionary<Guid, ExpBoost> GuildExpBoosts = new ConcurrentDictionary<Guid, ExpBoost>();
        public static ExpBoost AllExpBoost = null;

        private static long sUpdateTime = 0;

        public string Title;

        public Player SourcePlayer;

        public EventTargetType TargetType;

        public int AmountKill;

        public long ExpireTimeKill;

        public int AmountQuest;

        public long ExpireTimeQuest;


        public ExpBoost(string title, Player sourcePlayer, EventTargetType targetType,
            int amountKill, long expireTimeKill, int amountQuest, long expireTimeQuest)
        {
            Title = title;
            SourcePlayer = sourcePlayer;
            TargetType = targetType;
            AmountKill = amountKill;
            ExpireTimeKill = expireTimeKill;
            AmountQuest = amountQuest;
            ExpireTimeQuest = expireTimeQuest;
        }

        public static void Update()
        {
            var updateTime = Globals.Timing.Milliseconds;
            if (updateTime > sUpdateTime)
            {
                
                UpdateBoost(updateTime, PlayerExpBoosts);
                UpdateBoost(updateTime, PartyExpBoosts);
                UpdateBoost(updateTime, GuildExpBoosts);
                if (AllExpBoost != null)
                {
                    if (updateTime > AllExpBoost.ExpireTimeKill)
                    {
                        AllExpBoost.AmountKill = 0;
                    }
                    if (updateTime > AllExpBoost.ExpireTimeQuest)
                    {
                        AllExpBoost.AmountQuest = 0;
                    }
                    if (AllExpBoost.AmountKill == 0 && AllExpBoost.AmountQuest == 0)
                    {
                        AllExpBoost = null;
                    }
                }
                sUpdateTime = Globals.Timing.Milliseconds + 1000;
            } 
        }

        private static void UpdateBoost(long updateTime, ConcurrentDictionary<Guid, ExpBoost> boosts)
        {
            List<Guid> removekeys = new List<Guid>();
            foreach (var boost in boosts)
            {
                if (updateTime > boost.Value.ExpireTimeKill)
                {
                    boost.Value.AmountKill = 0;
                }
                if (updateTime > boost.Value.ExpireTimeQuest)
                {
                    boost.Value.AmountQuest = 0;
                }
                if (boost.Value.AmountKill == 0 && boost.Value.AmountQuest == 0)
                {
                    removekeys.Add(boost.Key);
                }
            }
            ExpBoost removedBoost;
            foreach(var k in removekeys)
            {
                boosts.TryRemove(k, out removedBoost);
            }
        }
    }

}
