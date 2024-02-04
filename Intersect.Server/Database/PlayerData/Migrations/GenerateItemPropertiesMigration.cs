using System;
using System.Linq;

using Intersect.Logging;
using Newtonsoft.Json;
using Intersect.GameObjects;

namespace Intersect.Server.Database.PlayerData.Migrations
{
    public class GenerateItemPropertiesMigration
    {

        public static void Run(PlayerContext context)
        {

            Log.Info("Checking for needed ItemProperties in player database");

            foreach (var p_item in context.Player_Items)
            {
                var properties = new ItemProperties();
                p_item.ItemPropertiesJson = JsonConvert.SerializeObject(properties);
            }

            foreach (var p_bank in context.Player_Bank)
            {
                var properties = new ItemProperties();
                p_bank.ItemPropertiesJson = JsonConvert.SerializeObject(properties);
            }

            foreach (var g_bank in context.Guild_Bank)
            {
                var properties = new ItemProperties();
                g_bank.ItemPropertiesJson = JsonConvert.SerializeObject(properties);
            }

            foreach (var b_item in context.Bag_Items)
            {
                var properties = new ItemProperties();
                b_item.ItemPropertiesJson = JsonConvert.SerializeObject(properties);
            }

            context.ChangeTracker.DetectChanges();
            context.SaveChanges();
            Log.Info("End of ItemProperties Migration");
        }

    }
}