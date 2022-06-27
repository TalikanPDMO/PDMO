using Intersect.Enums;
using Intersect.Server.Entities;
using Intersect.Server.Networking;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Intersect.Server.General
{

    public class PvpStadiumUnit
    {
        public static ConcurrentDictionary<Guid, PvpStadiumUnit> StadiumQueue = new ConcurrentDictionary<Guid, PvpStadiumUnit>();

        public static Dictionary<Guid, PvpStadiumUnit> CurrentMatchPlayers = new Dictionary<Guid, PvpStadiumUnit>();
        private static long sUpdateTime = 0;

        public PvpStadiumState StadiumState;

        private long RegistrationTime;

        private long TimeoutTimer;

        private Guid InitialMapId;

        private int InitialMapX;

        private int InitialMapY;

        private int[] InitialVitals;


        public PvpStadiumUnit()
        {
            StadiumState = PvpStadiumState.None;
            RegistrationTime = Globals.Timing.Milliseconds;
            InitialMapId = Guid.Empty;
            InitialMapX = 0;
            InitialMapY = 0;
            InitialVitals = new int[(int)Vitals.VitalCount];
            TimeoutTimer = 0;
        }

        public static void Update()
        {
            var updateTime = Globals.Timing.Milliseconds;
            if (updateTime > sUpdateTime && Options.PvpStadium.StadiumEnabled)
            {
                if (CurrentMatchPlayers.Count == 0)
                {
                    // Matchmaking
                    MatchMaking();
                }
                else
                {
                    // Check for afk
                    foreach (var p in CurrentMatchPlayers)
                    {
                        if (p.Value.TimeoutTimer > 0 && updateTime > p.Value.TimeoutTimer)
                        {
                            if (p.Value.StadiumState == PvpStadiumState.MatchOnPreparation)
                            {
                                StartMatch();
                                break; // break To avoid error with the foreach
                            }
                            else if (p.Value.StadiumState == PvpStadiumState.MatchOnGoing)
                            {
                                // Tie after a certain amount of time
                                EndMatch(Guid.Empty);
                                break; // break To avoid error with the foreach
                            }
                            else if (p.Value.StadiumState == PvpStadiumState.MatchEnded)
                            {
                                ReleaseStadium();
                                break;
                            }
                            else if (UnregisterPlayer(p.Key, true)) // Unregister the first afk in the match
                            {
                                break; // break To avoid error with the foreach
                            }
                        }
                    }
                    
                }
                sUpdateTime = Globals.Timing.Milliseconds + Options.PvpStadium.StadiumUpdateInterval;
            } 
        }

        private static void MatchMaking()
        {
            if (StadiumQueue.Count >= 2)
            {
                Dictionary<Guid, PvpStadiumUnit> localDict = new Dictionary<Guid, PvpStadiumUnit>();
                foreach(var playerUnit in StadiumQueue)
                {
                    if (playerUnit.Value.RegistrationTime + Options.PvpStadium.MinRegistrationTime < Globals.Timing.Milliseconds 
                        && playerUnit.Value.StadiumState == PvpStadiumState.None)
                    {
                        var player = Player.FindOnline(playerUnit.Key);
                        if (player?.CombatTimer < Globals.Timing.Milliseconds)
                        {
                            localDict.Add(playerUnit.Key, playerUnit.Value);
                            if (localDict.Count == 2)
                            {
                                foreach (var p in localDict)
                                {
                                    p.Value.StadiumState = PvpStadiumState.WaitForResponse;
                                    p.Value.TimeoutTimer = Globals.Timing.Milliseconds + Options.PvpStadium.AcceptMatchPopupTime;
                                    PacketSender.SendMatchmakingStadium(Player.FindOnline(p.Key));
                                    CurrentMatchPlayers.Add(p.Key, p.Value);
                                }
                                break;
                            }
                        }
                        else
                        {
                            if (UnregisterPlayer(playerUnit.Key))
                            {
                                PacketSender.SendMatchmakingStadium(player, true);
                            }
                            break;
                        }
                    }
                }

            }
        }
        
        public static bool ToggleRegistrationForPlayer(Guid playerId, int playerLvl)
        {
            if (Options.PvpStadium.StadiumEnabled)
            {
                // If can't unregister, try to register it 
                if (!UnregisterPlayer(playerId))
                {
                    if (playerLvl >= Options.PvpStadium.StadiumMinLevel)
                    {
                        PvpStadiumUnit playerUnit = new PvpStadiumUnit();
                        return StadiumQueue.TryAdd(playerId, playerUnit);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // Successfully unregistred
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool UnregisterPlayer(Guid playerId, bool isForced = false)
        {
            PvpStadiumUnit playerUnit = null;
            if (StadiumQueue.TryGetValue(playerId, out playerUnit))
            {
                if (playerUnit.StadiumState == PvpStadiumState.None || playerUnit.StadiumState == PvpStadiumState.MatchDeclined ||
                    playerUnit.StadiumState == PvpStadiumState.MatchEnded)
                {
                    return StadiumQueue.TryRemove(playerId, out playerUnit);
                }
                else if (isForced)
                {
                    if (playerUnit.StadiumState == PvpStadiumState.WaitForResponse || playerUnit.StadiumState == PvpStadiumState.MatchAccepted)
                    {
                        DeclineMatch(playerId);
                    }
                    else if (playerUnit.StadiumState == PvpStadiumState.MatchOnPreparation || playerUnit.StadiumState == PvpStadiumState.MatchOnGoing)
                    {
                        EndMatch(playerId, isForced);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Unable to unregister (player is probably not registred)
                return false;
            }
        }

        public static void DeclineMatch(Guid declinerId)
        {
            PvpStadiumUnit playerUnit = null;
            if (CurrentMatchPlayers.TryGetValue(declinerId, out playerUnit))
            {
                CurrentMatchPlayers.Remove(declinerId);
                foreach (var p in CurrentMatchPlayers)
                {
                    p.Value.StadiumState = PvpStadiumState.None;
                    p.Value.TimeoutTimer = 0;
                    PacketSender.SendMatchmakingStadium(Player.FindOnline(p.Key), true);
                }
                CurrentMatchPlayers.Clear();
                playerUnit.StadiumState = PvpStadiumState.MatchDeclined;
                UnregisterPlayer(declinerId);
            }  
        }

        public static void AcceptMatch(Guid accepterId)
        {
            PvpStadiumUnit playerUnit = null;
            bool matchReady = true;
            if (CurrentMatchPlayers.TryGetValue(accepterId, out playerUnit))
            {
                playerUnit.StadiumState = PvpStadiumState.MatchAccepted;
                playerUnit.TimeoutTimer = 0;
                foreach (var p in CurrentMatchPlayers)
                {
                    if (p.Value.StadiumState != PvpStadiumState.MatchAccepted)
                    {
                        matchReady = false;
                    }
                }
                if (matchReady)
                {
                    StartPreparation();
                }
            }
        }
        private static void StartPreparation()
        {
            List<Player> localList = new List<Player>();
            foreach (var matchplayer in CurrentMatchPlayers)
            {
                var player = Player.FindOnline(matchplayer.Key);
                if (player != null)
                {
                    // Save player position
                    matchplayer.Value.InitialMapId = player.MapId;
                    matchplayer.Value.InitialMapX = player.X;
                    matchplayer.Value.InitialMapY = player.Y;

                    // Save and restore vitals
                    for (var v = 0; v < (int)Vitals.VitalCount; v++)
                    {
                        matchplayer.Value.InitialVitals[v] = player.GetVital(v);
                        player.RestoreVital((Vitals)v);
                    }
                    // Clear all status and dot for a stadium match
                    foreach (var status in player.CachedStatuses)
                    {
                         status.RemoveStatus();
                    }
                    foreach (var dot in player.CachedDots)
                    {
                        dot.Expire();
                    }
                    matchplayer.Value.StadiumState = PvpStadiumState.MatchOnPreparation;
                    matchplayer.Value.TimeoutTimer = Globals.Timing.Milliseconds + Options.PvpStadium.BeforeMatchTime;
                    localList.Add(player);
                }
                else
                {
                    UnregisterPlayer(matchplayer.Key);
                    break;
                }
            }
            if (localList.Count == 2)
            {
                localList[0].Warp(Options.PvpStadium.StadiumPreparationMapId,
                        Options.PvpStadium.Location1_PreparationX, Options.PvpStadium.Location1_PreparationY);
                localList[1].Warp(Options.PvpStadium.StadiumPreparationMapId,
                        Options.PvpStadium.Location2_PreparationX, Options.PvpStadium.Location2_PreparationY);
            }                
        }

        private static void StartMatch()
        {
            List<Player> localList = new List<Player>();
            foreach (var matchplayer in CurrentMatchPlayers)
            {
                var player = Player.FindOnline(matchplayer.Key);
                if (player != null)
                {
                    matchplayer.Value.StadiumState = PvpStadiumState.MatchOnGoing;
                    matchplayer.Value.TimeoutTimer = Globals.Timing.Milliseconds + Options.PvpStadium.MaxMatchDuration;
                    localList.Add(player);
                }
                else
                {
                    UnregisterPlayer(matchplayer.Key);
                    break;
                }
            }
            if (localList.Count == 2)
            {
                localList[0].Warp(Options.PvpStadium.StadiumCombatMapId,
                        Options.PvpStadium.Location1_CombatX, Options.PvpStadium.Location1_CombatY);
                localList[1].Warp(Options.PvpStadium.StadiumCombatMapId,
                        Options.PvpStadium.Location2_CombatX, Options.PvpStadium.Location2_CombatY);
            }
        }

        public static void EndMatch(Guid loserId, bool isForced = false)
        {
            var i = 0;
            Player winner = null;
            Player loser = null;
            foreach (var matchplayer in CurrentMatchPlayers)
            {
                if(matchplayer.Value.StadiumState == PvpStadiumState.MatchOnGoing || matchplayer.Value.StadiumState == PvpStadiumState.MatchOnPreparation)
                {
                    var player = Player.FindOnline(matchplayer.Key);
                    if (loserId != Guid.Empty)
                    {
                        // Not a tie
                        if (matchplayer.Key == loserId)
                        {
                            // TODO Count loss ++
                            loser = player;
                        }
                        else
                        {
                            // TODO Count win ++
                            winner = player;
                        }
                    }
                    
                    if (player != null && matchplayer.Value.StadiumState == PvpStadiumState.MatchOnGoing)
                    {
                        if (i == 0)
                        {
                            player.Warp(Options.PvpStadium.StadiumPreparationMapId,
                                Options.PvpStadium.Location1_PreparationX, Options.PvpStadium.Location1_PreparationY);
                            
                        }
                        else
                        {
                            player.Warp(Options.PvpStadium.StadiumPreparationMapId,
                                Options.PvpStadium.Location2_PreparationX, Options.PvpStadium.Location2_PreparationY);
                        }
                    }
                    matchplayer.Value.StadiumState = PvpStadiumState.MatchEnded;
                    matchplayer.Value.TimeoutTimer = Globals.Timing.Milliseconds + Options.PvpStadium.AfterMatchTime;
                    i++;
                }
            }
            if (loserId != Guid.Empty)
            {
                // Not a tie, start event for winner and loser (show message via event probably ?)
                 winner?.StartCommonEventsWithTrigger(CommonEventTrigger.PVPKill, nameof(PvpStadiumState), loser?.Name);
                 loser?.StartCommonEventsWithTrigger(CommonEventTrigger.PVPDeath, nameof(PvpStadiumState), winner?.Name);
            }
            if (isForced)
            {
                // When it is a logout
                if (CurrentMatchPlayers.TryGetValue(loserId, out var loserUnit))
                {
                    if (loser != null)
                    {
                        if (loserUnit.InitialMapId != Guid.Empty)
                        {
                            loser.MapId = loserUnit.InitialMapId;
                            loser.X = loserUnit.InitialMapX;
                            loser.Y = loserUnit.InitialMapY;
                        }
                        for (var v = 0; v < (int)Vitals.VitalCount; v++)
                        {
                            loser.SetVital(v, loserUnit.InitialVitals[v]);
                        }
                    }
                    CurrentMatchPlayers.Remove(loserId);
                    UnregisterPlayer(loserId);
                }
            }
        }

        private static void ReleaseStadium()
        {
            foreach (var matchplayer in CurrentMatchPlayers)
            {
                matchplayer.Value.TimeoutTimer = 0;
                var player = Player.FindOnline(matchplayer.Key);
                if (player != null)
                {
                    for (var v = 0; v < (int)Vitals.VitalCount; v++)
                    {
                        player.SetVital(v, matchplayer.Value.InitialVitals[v]);
                    }
                    player.Warp(matchplayer.Value.InitialMapId, matchplayer.Value.InitialMapX, matchplayer.Value.InitialMapY); 
                }
                UnregisterPlayer(matchplayer.Key);
            }
            CurrentMatchPlayers.Clear();
        }
    }
}
