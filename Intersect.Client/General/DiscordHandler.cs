using Intersect.GameObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Client.General
{
    public static class DiscordHandler
    {
        // Discord RichPresence management
        public static Discord.Discord discord;
        public static Discord.Activity activity;
        public static DiscordPresenceState presenceActivityMenu = DiscordPresenceState.Initial;
        public static DiscordPresenceState presenceInGame = DiscordPresenceState.Initial;
        public static String SMALL_IMAGE_PREFIX = "sprite_";
        public enum DiscordPresenceState
        {

            Initial = 0,

            Ongoing,

            Done,
        }


        public static void InitActivity()
        {
            activity = new Discord.Activity
            {
                Details = "Pokemon Donjon Mystere Online",
                State = "Demarrage",
                Assets =
                {
                    LargeImage = "pdmo_main_icon",
                    LargeText = "PDMO : La breche des mondes",
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
                        Console.WriteLine("Fail to set menu presence because of " + res.ToString());
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
                activity.Assets.SmallImage = SMALL_IMAGE_PREFIX + Path.GetFileNameWithoutExtension(Globals.Me.MySprite);
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
                        Console.WriteLine("Fail to set In Game because of " + res.ToString());
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
    }
}
