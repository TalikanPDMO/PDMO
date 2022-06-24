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

        public long RegistrationTime;

        public long TimeoutTimer;

        public Guid InitialMapId;

        public int InitialMapX;

        public int InitialMapY;


        public PvpStadiumUnit()
        {
            StadiumState = PvpStadiumState.None;
            RegistrationTime = Globals.Timing.Milliseconds;
            InitialMapId = Guid.Empty;
            InitialMapX = 0;
            InitialMapY = 0;
            TimeoutTimer = 0;
        }

        public static void Update()
        {
            var updateTime = Globals.Timing.Milliseconds;
            if (updateTime > sUpdateTime)
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
                        if (updateTime > p.Value.TimeoutTimer)
                        {
                            // Unregister the first afk in the match
                            if (UnregisterPlayer(p.Key, true))
                            {
                                // break To avoid error with the foreach
                                break;
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
                        localDict.Add(playerUnit.Key, playerUnit.Value);
                        if (localDict.Count == 2)
                        {
                            foreach (var p in localDict)
                            {
                                p.Value.StadiumState = PvpStadiumState.WaitForResponse;
                                p.Value.TimeoutTimer = Globals.Timing.Milliseconds + Options.PvpStadium.AcceptMatchPopupTime;
                                CurrentMatchPlayers.Add(p.Key, p.Value);
                            }
                            // TODO Send Popup stadium
                            break;
                        }
                    }
                }

            }
        }
        
        public static bool ToggleRegistrationForPlayer(Guid playerId)
        {
           // If can't unregister, try to register it 
            if (!UnregisterPlayer(playerId))
            {
                PvpStadiumUnit playerUnit = new PvpStadiumUnit();
                return StadiumQueue.TryAdd(playerId, playerUnit);
            }
            else
            {
                // Successfully unregistred
                return true;
            }
            
        }

        public static bool UnregisterPlayer(Guid playerId, bool isForced = false)
        {
            PvpStadiumUnit playerUnit = null;
            if (StadiumQueue.TryGetValue(playerId, out playerUnit))
            {
                if (playerUnit.StadiumState == PvpStadiumState.None || playerUnit.StadiumState == PvpStadiumState.MatchDeclined)
                {
                    return StadiumQueue.TryRemove(playerId, out playerUnit);
                }
                else if (isForced)
                {
                    if (playerUnit.StadiumState == PvpStadiumState.WaitForResponse)
                    {
                        DeclineMatch(playerId);
                    }
                    else if (playerUnit.StadiumState == PvpStadiumState.MatchAccepted ||
                        playerUnit.StadiumState == PvpStadiumState.MatchOnPreparation ||
                        playerUnit.StadiumState == PvpStadiumState.MatchOnGoing)
                    {
                        //LooseMatch
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
                }
                CurrentMatchPlayers.Clear();
                playerUnit.StadiumState = PvpStadiumState.MatchDeclined;
                UnregisterPlayer(declinerId);
            }  
        }

        /*public static void DeclineMatch(Guid declinerId)
        {
            PvpStadiumUnit playerUnit = null;
            if (CurrentMatchPlayers.TryGetValue(declinerId, out playerUnit))
            {
                CurrentMatchPlayers.Remove(declinerId);
                foreach (var p in CurrentMatchPlayers)
                {
                    // Reset state for the other player
                    if (StadiumQueue.TryGetValue(p.Key, out playerUnit))
                    {
                        playerUnit.StadiumState = PvpStadiumState.None;
                        playerUnit.TimeoutTimer = 0;
                    }
                }
                CurrentMatchPlayers.Clear();
            }
            if (StadiumQueue.TryGetValue(declinerId, out playerUnit))
            {
                playerUnit.StadiumState = PvpStadiumState.MatchDeclined;
                UnregisterPlayer(declinerId);
            }
        }*/

        public static void AcceptMatch(Guid accepterId)
        {
            PvpStadiumUnit playerUnit = null;
            bool matchReady = true;
            if (CurrentMatchPlayers.TryGetValue(accepterId, out playerUnit))
            {
                playerUnit.StadiumState = PvpStadiumState.MatchAccepted;
                foreach (var p in CurrentMatchPlayers)
                {
                    if (p.Value.StadiumState != PvpStadiumState.MatchAccepted)
                    {
                        matchReady = false;
                    }
                }
                if (matchReady)
                {
                    //LaunchMatch
                }
            }
        }
    }
}
