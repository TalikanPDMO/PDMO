using Discord;
using Intersect.GameObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Intersect.Client.General
{
    public static class DiscordHandler
    {
        // Discord RichPresence management
        public static Discord.Discord discord;
        public static Discord.Activity activity;
        public static DiscordPresenceState presenceActivityMenu = DiscordPresenceState.Initial;
        public static DiscordPresenceState presenceInGame = DiscordPresenceState.Initial;
        public static string SMALL_IMAGE_PREFIX = "sprite_";
        private static long APPLICATION_ID = 864507833672269854;
        private static System.Timers.Timer discordTimer;
        private static int DISCORD_TIMER_INTERVAL = 900000; // 15 minutes
        public enum DiscordPresenceState
        {

            Initial = 0,

            Ongoing,

            Done,
        }

        public static void InitDiscord()
        {
            discordTimer = new Timer(DISCORD_TIMER_INTERVAL);
            discordTimer.AutoReset = true;
            discordTimer.Enabled = false;
            discordTimer.Elapsed += OnElapsedTimeDiscord;
            //Trycatch to ensure discord is running
            try
            {
                discord = new Discord.Discord(APPLICATION_ID, (UInt64)Discord.CreateFlags.NoRequireDiscord);
            }
            catch (ResultException ex)
            {
                //Discord is not running
                discord = null;
            }
            InitActivity();
            discordTimer.Start();
        }


        private static void InitActivity()
        {
            activity = new Discord.Activity
            {
                Details = ConvertForDiscordUTF8("Pokemon Donjon Mystère Online"),
                State = "Lancement",
                Assets =
                {
                    LargeImage = "pdmo_main_icon",
                    LargeText = ConvertForDiscordUTF8("PDMO : La brèche des mondes"),
                    SmallImage = "pdmo_icone",
                    SmallText = ""
                }

            };
        }

        //If needed, update the discord RichPresence to "menu" state
        public static void SwitchToActivityMenu()
        {
            if (discord != null && presenceActivityMenu == DiscordPresenceState.Initial)
            {
                presenceActivityMenu = DiscordPresenceState.Ongoing;
                activity.State = "Menu principal";
                activity.Assets.SmallImage = "pdmo_icone";
                activity.Assets.SmallText = "";
                discord.GetActivityManager().UpdateActivity(activity, (res) =>
                {
                    if (res == Discord.Result.Ok)
                    {
                        presenceActivityMenu = DiscordPresenceState.Done;
                        presenceInGame = DiscordPresenceState.Initial;
                    }
                    else
                    {
                        presenceActivityMenu = DiscordPresenceState.Initial;
                    }
                });
            }
        }

        //If needed, update the discord RichPresence to the "in game" state
        public static void SwitchToActivityInGame()
        {
            if (discord != null && presenceInGame == DiscordPresenceState.Initial)
            {
                presenceInGame = DiscordPresenceState.Ongoing;
                activity.State = "En jeu";
                
                activity.Assets.SmallImage = SMALL_IMAGE_PREFIX + Path.GetFileNameWithoutExtension(ClassBase.Get(Globals.Me.Class).Sprites[0].Sprite);
                activity.Assets.SmallText = ConvertForDiscordUTF8(Globals.Me.Name + " (" + ClassBase.GetName(Globals.Me.Class) + ")");
                discord.GetActivityManager().UpdateActivity(activity, (res) =>
                {
                    if (res == Discord.Result.Ok)
                    {
                        presenceActivityMenu = DiscordPresenceState.Initial;
                        presenceInGame = DiscordPresenceState.Done;
                    }
                    else
                    {
                        presenceInGame = DiscordPresenceState.Initial;
                    }
                });
            }
        }

        //Hard to render some characters on Discord Rich Presence so we do a little trick
        private static string ConvertForDiscordUTF8(string baseString)
        {
            Byte[] encodedBytes = Encoding.UTF8.GetBytes(baseString);
            return new string(encodedBytes.Select((byte b, int ind) => (char)b).ToArray());
        }

        private static void OnElapsedTimeDiscord(Object source, ElapsedEventArgs e)
        {
            if (discord == null)
            {
                try
                {
                    //Reset discord link for RichPresence
                    discord = new Discord.Discord(APPLICATION_ID, (UInt64)Discord.CreateFlags.NoRequireDiscord);
                    //Reset presence state
                    presenceActivityMenu = DiscordPresenceState.Initial;
                    presenceInGame = DiscordPresenceState.Initial;
                }
                catch (ResultException ex)
                {
                    //Discord is not running
                    discord = null;
                }
            }
        }
    }
}
