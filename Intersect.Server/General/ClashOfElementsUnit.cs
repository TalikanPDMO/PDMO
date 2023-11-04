using Microsoft.Owin.Security;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Intersect.Enums;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.Network.Packets.Server;

namespace Intersect.Server.General
{
    internal class ClashOfElementsUnit
    {
        // all player in queue
        public static ConcurrentDictionary<Guid, ClashOfElementsUnit> ClashOfElementsQueue = new ConcurrentDictionary<Guid, ClashOfElementsUnit>();
        // Selected player
        public static Dictionary<Guid, ClashOfElementsUnit> CurrentMatchPlayers = new Dictionary<Guid, ClashOfElementsUnit>();

        private static long sUpdateTime = 0;

        public ClashOfElementsState CEOState;

        public long RegistrationTime;

        public long TimeoutTimer;

        public Guid InitialMapId;

        public int InitialMapX;

        public int InitialMapY;

        public ClashOfElementsUnit()
        {
            CEOState = ClashOfElementsState.None;
            RegistrationTime = Globals.Timing.Milliseconds;
            InitialMapId = Guid.Empty;
            InitialMapX = 0;
            InitialMapY = 0;
            TimeoutTimer = 0;

        }

        public static void Update()
        {
            var updateTime = Globals.Timing.Milliseconds;
            if(updateTime > sUpdateTime)
            {
                if(CurrentMatchPlayers.Count == 0)
                {
                    MatchMaking();
                }
                else
                {
                    //check for afk
                    foreach (var p in CurrentMatchPlayers)
                    {
                        if(updateTime > p.Value.TimeoutTimer)
                        {
                            if(UnregisterPlayer(p.Key, true))
                            {
                                // break To avoid error with the foreach
                                break;
                            }
                        }
                    }
                }
                sUpdateTime = Globals.Timing.Milliseconds + Options.ClashOfElements.COEUpdateInterval;
            
            }
        }

        private static void MatchMaking()
        {
            if(ClashOfElementsQueue.Count >= 2)
            {
                Dictionary<Guid, ClashOfElementsUnit> localDict = new Dictionary<Guid, ClashOfElementsUnit>();

                foreach (var playerUnit in ClashOfElementsQueue)
                {
                    if(playerUnit.Value.RegistrationTime + Options.ClashOfElements.COEUpdateInterval < Globals.Timing.Milliseconds && playerUnit.Value.CEOState == ClashOfElementsState.None)
                    {
                        localDict.Add(playerUnit.Key, playerUnit.Value);
                        if (localDict.Count == 2)
                        {
                            foreach (var p in localDict)
                            {
                                p.Value.CEOState = ClashOfElementsState.WhaitForResponse;
                                p.Value.TimeoutTimer = Globals.Timing.Milliseconds + Options.ClashOfElements.COEUpdateInterval;

                                CurrentMatchPlayers.Add(p.Key, p.Value);
                            }
                            // TODO Send Popup Stadium
                            break;
                        }
                    } 
                }
            }
        }
        public static bool ToggleRegistrationForPlayer(Guid playerId)
        {
            // if can't unregister, try to register it
            if (!UnregisterPlayer(playerId))
            {
                ClashOfElementsUnit playerUnit = new ClashOfElementsUnit();
                return ClashOfElementsQueue.TryAdd(playerId, playerUnit);
            }
            else
            {
                return true;
            }
        }

        public static bool UnregisterPlayer(Guid playerId, bool isForced = false)
        {
            ClashOfElementsUnit playerUnit = null;
            if(ClashOfElementsQueue.TryGetValue(playerId, out playerUnit))
            {
                if(playerUnit.CEOState == ClashOfElementsState.None || playerUnit.CEOState == ClashOfElementsState.MatchDeclined)
                {
                    return ClashOfElementsQueue.TryRemove(playerId, out playerUnit);
                }
                else if (isForced) // timeout
                {
                    if(playerUnit.CEOState == ClashOfElementsState.WhaitForResponse)
                    {
                        DeclineMatch(playerId);
                    }
                    else if (playerUnit.CEOState == ClashOfElementsState.MatchAccepted
                        || playerUnit.CEOState == ClashOfElementsState.MatchOnPreparation
                        || playerUnit.CEOState == ClashOfElementsState.MatchOnGoing) 
                    {
                        // LooseMatch
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
                // Unable to register
                return false;
            }
        }

        public static void DeclineMatch(Guid declinerId)
        {
            ClashOfElementsUnit playerUnit = null;
            if(CurrentMatchPlayers.TryGetValue(declinerId, out playerUnit)){
                CurrentMatchPlayers.Remove(declinerId);
                foreach(var p in CurrentMatchPlayers)
                {
                    p.Value.CEOState = ClashOfElementsState.None;
                    p.Value.TimeoutTimer = 0;
                }
                CurrentMatchPlayers.Clear();
                playerUnit.CEOState = ClashOfElementsState.MatchDeclined;
                UnregisterPlayer(declinerId);

            }
        }

        public static void AcceptMatch(Guid accepterId)
        {
            ClashOfElementsUnit playerUnit = null;
            bool matchReady = true;
            if(CurrentMatchPlayers.TryGetValue(accepterId, out playerUnit)){
                playerUnit.CEOState = ClashOfElementsState.MatchAccepted;
                foreach (var p in CurrentMatchPlayers)
                {
                    if(p.Value.CEOState != ClashOfElementsState.MatchAccepted)
                    {
                        matchReady = false;
                    }
                }
                if (matchReady)
                {
                    // TODO LaunchMatch 
                }
            }
        }

    }

    
}
