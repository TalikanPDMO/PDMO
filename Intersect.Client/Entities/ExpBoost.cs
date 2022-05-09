using System;

using Intersect.Client.General;
using Intersect.Enums;

namespace Intersect.Client.Entities
{

    public class ExpBoost
    {
        public static ExpBoost PlayerExpBoost { get; private set; } = null;
        public static ExpBoost PartyExpBoost { get; private set; } = null;
        public static ExpBoost GuildExpBoost { get; private set; } = null;
        public static ExpBoost AllExpBoost { get; private set; } = null;
        public static int BoostCount { get; private set; } = 0;

        private static long sUpdateTime = 0;

        public string Title;

        public string SourcePlayerName;

        public EventTargetType TargetType;

        public int AmountKill;

        public long ExpireTimeKill;

        public int AmountQuest;

        public long ExpireTimeQuest;


        public ExpBoost(string title, string sourcePlayerName, EventTargetType targetType,
            int amountKill, long expireTimeKill, int amountQuest, long expireTimeQuest)
        {
            Title = title;
            SourcePlayerName = sourcePlayerName;
            TargetType = targetType;
            AmountKill = amountKill;
            ExpireTimeKill = expireTimeKill > 0 ? expireTimeKill + Globals.System.GetTimeMs() : 0;
            AmountQuest = amountQuest;
            ExpireTimeQuest = expireTimeQuest > 0 ? expireTimeQuest + Globals.System.GetTimeMs() : 0;
        }

       public static void Update()
        {
            var updateTime = Globals.System.GetTimeMs();
            if (updateTime > sUpdateTime && BoostCount > 0)
            {
                if (PlayerExpBoost != null)
                {
                    if (updateTime > PlayerExpBoost.ExpireTimeKill)
                    {
                        PlayerExpBoost.AmountKill = 0;
                    }
                    if (updateTime > PlayerExpBoost.ExpireTimeQuest)
                    {
                        PlayerExpBoost.AmountQuest = 0;
                    }
                    if (PlayerExpBoost.AmountKill == 0 && PlayerExpBoost.AmountQuest == 0)
                    {
                        BoostCount--;
                        PlayerExpBoost = null;
                    }
                }
                if (PartyExpBoost != null)
                {
                    if (updateTime > PartyExpBoost.ExpireTimeKill)
                    {
                        PartyExpBoost.AmountKill = 0;
                    }
                    if (updateTime > PartyExpBoost.ExpireTimeQuest)
                    {
                        PartyExpBoost.AmountQuest = 0;
                    }
                    if (PartyExpBoost.AmountKill == 0 && PartyExpBoost.AmountQuest == 0)
                    {
                        BoostCount--;
                        PartyExpBoost = null;
                    }
                }
                if (GuildExpBoost != null)
                {
                    if (updateTime > GuildExpBoost.ExpireTimeKill)
                    {
                        GuildExpBoost.AmountKill = 0;
                    }
                    if (updateTime > GuildExpBoost.ExpireTimeQuest)
                    {
                        GuildExpBoost.AmountQuest = 0;
                    }
                    if (GuildExpBoost.AmountKill == 0 && GuildExpBoost.AmountQuest == 0)
                    {
                        BoostCount--;
                        GuildExpBoost = null;
                    }
                }
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
                        BoostCount--;
                        AllExpBoost = null;
                    }
                }
                sUpdateTime = Globals.System.GetTimeMs() + 1000;
            }
        }

        public static void AddOrUpdateBoost(ExpBoost newExpBoost)
        {
            if(newExpBoost == null)
            {
                return;
            }
            switch (newExpBoost.TargetType)
            {
                case EventTargetType.Player:
                    if (ExpBoost.PlayerExpBoost == null)
                    {
                        ExpBoost.BoostCount++;
                    }
                    ExpBoost.PlayerExpBoost = newExpBoost;
                    break;
                case EventTargetType.Party:
                    if (ExpBoost.PartyExpBoost == null)
                    {
                        ExpBoost.BoostCount++;
                    }
                    ExpBoost.PartyExpBoost = newExpBoost;
                    break;
                case EventTargetType.Guild:
                    if (ExpBoost.GuildExpBoost == null)
                    {
                        ExpBoost.BoostCount++;
                    }
                    ExpBoost.GuildExpBoost = newExpBoost;
                    break;
                case EventTargetType.AllPlayers:
                    if (ExpBoost.AllExpBoost == null)
                    {
                        ExpBoost.BoostCount++;
                    }
                    ExpBoost.AllExpBoost = newExpBoost;
                    break;
            }
        }

        public static void RemoveBoost(EventTargetType targetType)
        {
            switch (targetType)
            {
                case EventTargetType.Player:
                    if (ExpBoost.PlayerExpBoost != null)
                    {
                        ExpBoost.BoostCount--;
                    }
                    ExpBoost.PlayerExpBoost = null;
                    break;
                case EventTargetType.Party:
                    if (ExpBoost.PartyExpBoost != null)
                    {
                        ExpBoost.BoostCount--;
                    }
                    ExpBoost.PartyExpBoost = null;
                    break;
                case EventTargetType.Guild:
                    if (ExpBoost.GuildExpBoost != null)
                    {
                        ExpBoost.BoostCount--;
                    }
                    ExpBoost.GuildExpBoost = null;
                    break;
                case EventTargetType.AllPlayers:
                    if (ExpBoost.AllExpBoost != null)
                    {
                        ExpBoost.BoostCount--;
                    }
                    ExpBoost.AllExpBoost = null;
                    break;
            }
        }
        /*private static void UpdateBoost(long updateTime, ConcurrentDictionary<Guid, ExpBoost> boosts)
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
            foreach (var k in removekeys)
            {
                boosts.TryRemove(k, out removedBoost);
            }
        }*/

    }

}
