using System;
using System.Collections.Generic;
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
        public static bool isPresenceActivityMenu = false;
        public static bool isPresenceInGame = false;

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
            if (!isPresenceActivityMenu)
            {
                activity.State = "Menu principal";
                activity.Assets.SmallImage = "pdmo_icone";
                activity.Assets.SmallText = "";
                discord.GetActivityManager().UpdateActivity(activity, (res) =>
                {
                    if (res == Discord.Result.Ok)
                    {
                        isPresenceActivityMenu = true;
                        isPresenceInGame = false;
                    }
                    else
                    {
                        Console.WriteLine("Fail to set menu presence because of " + res.ToString());
                    }
                });
            }
        }

        //If needed, update the discord RichPresence to the "in game" state
        public static void SwitchToActivityInGame()
        {
            if (!isPresenceInGame)
            {
                activity.State = "En jeu";
                discord.GetActivityManager().UpdateActivity(activity, (res) =>
                {
                    if (res == Discord.Result.Ok)
                    {
                        isPresenceActivityMenu = false;
                        isPresenceInGame = true;
                    }
                    else
                    {
                        Console.WriteLine("Fail to set In Game because of " + res.ToString());
                    }
                });
            }
        }
    }
}
