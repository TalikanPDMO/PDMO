﻿using System;
using System.Collections.Generic;

using Intersect.Client.Entities;
using Intersect.Client.Entities.Events;
using Intersect.Client.Framework.Database;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Graphics;
using Intersect.Client.Framework.Input;
using Intersect.Client.Framework.Sys;
using Intersect.Client.Items;
using Intersect.Client.Plugins.Interfaces;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.Network.Packets.Server;

namespace Intersect.Client.General
{

    public static class Globals
    {

        //Only need 1 table, and that is the one we see at a given moment in time.
        public static CraftingTableBase ActiveCraftingTable;

        public static int AnimFrame = 0;

        //Bag
        public static Item[] Bag = null;

        //Bank
        public static Item[] Bank;
        public static bool GuildBank;
        public static int BankSlots;

        public static bool ConnectionLost;

        //Game Systems
        public static GameContentManager ContentManager;

        public static int CurrentMap = -1;

        public static GameDatabase Database;

        //Entities and stuff
        public static Dictionary<Guid, Entity> Entities = new Dictionary<Guid, Entity>();

        public static List<Guid> EntitiesToDispose = new List<Guid>();

        public static Dictionary<Guid, Entity> DespawnAnimations = new Dictionary<Guid, Entity>();

        public static float[] CalculatedSpeeds;

        //Control Objects
        public static List<Dialog> EventDialogs = new List<Dialog>();

        public static Dictionary<Guid, Guid> EventHolds = new Dictionary<Guid, Guid>();

        //Game Lock
        public static object GameLock = new object();

        //Game Shop
        //Only need 1 shop, and that is the one we see at a given moment in time.
        public static ShopBase GameShop;

        //Crucial game variables

        internal static List<IClientLifecycleHelper> ClientLifecycleHelpers { get; } =
            new List<IClientLifecycleHelper>();

        internal static void OnLifecycleChangeState()
        {
            ClientLifecycleHelpers.ForEach(
                clientLifecycleHelper => clientLifecycleHelper?.OnLifecycleChangeState(GameState)
            );
        }

        internal static void OnGameUpdate()
        {
            ClientLifecycleHelpers.ForEach(
                clientLifecycleHelper => clientLifecycleHelper?.OnGameUpdate(GameState)
            );
        }

        private static GameStates mGameState = GameStates.Intro;

        /// <see cref="GameStates" />
        public static GameStates GameState
        {
            get => mGameState;
            set
            {
                mGameState = value;
                OnLifecycleChangeState();
            }
        }

        public static List<Guid> GridMaps = new List<Guid>();

        public static bool HasGameData = false;

        public static bool InBag = false;

        public static bool InBank = false;

        //Crafting station
        public static bool InCraft = false;

        public static bool InShop => GameShop != null;

        public static bool InTrade = false;

        public static bool CanCloseInventory => !(InBag || InBank || InCraft || InShop || InTrade);

        public static GameInput InputManager;

        public static bool IntroComing = true;

        public static long IntroDelay = 2000;

        //Engine Progression
        public static int IntroIndex = 0;

        public static long IntroStartTime = -1;

        public static bool IsRunning = true;

        public static bool JoiningGame = false;

        public static bool LoggedIn = false;

        //Map/Chunk Array
        public static Guid[,] MapGrid;

        public static long MapGridHeight;

        public static long MapGridWidth;

        //Local player information
        public static Player Me;

        public static bool MoveRouteActive = false;

        public static bool NeedsMaps = true;

        //Event Guid and the Map its associated with
        public static Dictionary<Guid, Dictionary<Guid, EventEntityPacket>> PendingEvents =
            new Dictionary<Guid, Dictionary<Guid, EventEntityPacket>>();

        //Event Show Pictures
        public static ShowPicturePacket Picture;

        //Event Show Popups
        public static List<ShowPopupPacket> Popups = new List<ShowPopupPacket>();

        public static List<Guid> QuestOffers = new List<Guid>();

        public static Random Random = new Random();

        public static GameSystem System;

        //Trading (Only 2 people can trade at once)
        public static Item[,] Trade;

        //Scene management
        public static bool WaitingOnServer = false;

        public static Entity GetEntity(Guid id, EntityTypes type)
        {
            if (Entities.ContainsKey(id))
            {
                if (Entities[id].GetEntityType() == type)
                {
                    EntitiesToDispose.Remove(Entities[id].Id);

                    return Entities[id];
                }

                Entities[id].Dispose();
                Entities.Remove(id);
            }

            return null;
        }

        public static void InitCalculatedSpeeds(int size)
        {
            var coeffs = Options.Instance.PlayerOpts.SpeedFormulaCoeffs;
            CalculatedSpeeds = new float[size + 1];
            for (var i=0; i<=size; i++)
            {
                if (i >= coeffs[8])
                {
                    CalculatedSpeeds[i] = Math.Max(100, coeffs[6] - coeffs[7] * (i - coeffs[8]));
                }
                else if (i >= coeffs[5])
                {
                    CalculatedSpeeds[i] = Math.Max(100, coeffs[3] - coeffs[4] * (i - coeffs[5]));
                }
                else if (i>=coeffs[2])
                {
                    CalculatedSpeeds[i] = Math.Max(100, coeffs[0] - coeffs[1] * (i - coeffs[2]));
                }
                else
                {
                    CalculatedSpeeds[i] = 1000f;
                }
            }
        }

        public static GameTexture GetElementalTypeTexture(ElementalType elementalType, bool needFull)
        {
            if (elementalType == ElementalType.None)
            {
                return null;
            }
            if (needFull)
            {
                return ContentManager.GetTexture(GameContentManager.TextureType.Gui,
                    "type_" + elementalType.ToString() + "_full.png");
            }
            else
            {
                return ContentManager.GetTexture(GameContentManager.TextureType.Gui,
                    "type_" + elementalType.ToString() + ".png");
            }
           
        }

    }

}
