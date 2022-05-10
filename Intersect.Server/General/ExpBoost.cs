using Intersect.Enums;
using Intersect.Server.Entities;
using Intersect.Server.Networking;
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
        public static void SendPlayerBoost(Player player, EventTargetType targetType)
        {
            ExpBoost expboost;
            switch (targetType)
            {
                case EventTargetType.Player:
                    if (ExpBoost.PlayerExpBoosts.TryGetValue(player.Id, out expboost))
                    {
                        PacketSender.SendExpBoost(player, expboost);
                    }
                    break;
                case EventTargetType.Party:
                    if (player.Party?.Count > 0 && ExpBoost.PartyExpBoosts.TryGetValue(player.Party[0].Id, out expboost))
                    {
                        PacketSender.SendExpBoost(player, expboost);
                    }
                    else if (ExpBoost.PartyExpBoosts.TryGetValue(player.Id, out expboost))
                    {
                        PacketSender.SendExpBoost(player, expboost, true);
                    }
                    else
                    {
                        // Empty boost to clear player boost
                        PacketSender.SendExpBoost(player, new ExpBoost("", player, targetType,0,0,0,0), true);
                    }
                    break;
                case EventTargetType.Guild:
                    if (player.Guild != null && player.Guild.Id != Guid.Empty)
                    {
                        if (ExpBoost.GuildExpBoosts.TryGetValue(player.Guild.Id, out expboost))
                        {
                            PacketSender.SendExpBoost(player, expboost);
                        }
                    }
                    else
                    {
                        PacketSender.SendExpBoost(player, new ExpBoost("", player, targetType, 0, 0, 0, 0));
                    }
                    break;
                case EventTargetType.AllPlayers:
                    expboost = AllExpBoost;
                    if (expboost != null)
                    {
                        PacketSender.SendExpBoost(player, expboost);
                    }
                    break;
            }
        }

        public static void InitPlayerBoosts(Player player)
        {
            ExpBoost expboost;
            if (ExpBoost.PlayerExpBoosts.TryGetValue(player.Id, out expboost))
            {
                PacketSender.SendExpBoost(player, expboost);
            }
            if (ExpBoost.PartyExpBoosts.TryGetValue(player.Id, out expboost))
            {
                PacketSender.SendExpBoost(player, expboost, true);
            }
            if (player.Guild != null && player.Guild.Id != Guid.Empty && ExpBoost.GuildExpBoosts.TryGetValue(player.Guild.Id, out expboost))
            {
                PacketSender.SendExpBoost(player, expboost);
            }
            expboost = AllExpBoost;
            if (expboost != null)
            {
                PacketSender.SendExpBoost(player, expboost);
            }
        }
    }
}
