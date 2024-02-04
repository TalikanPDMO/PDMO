using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Intersect.Client.Items
{

    public class MapItemInstance : Item
    {
        /// <summary>
        /// The Unique Id of this particular MapItemInstance so we can refer to it elsewhere.
        /// </summary>
        public Guid UniqueId;

        public int X { get; set; }

        public int Y { get; set; }

        [JsonIgnore] public int TileIndex => Y * Options.MapWidth + X;

        public MapItemInstance() : base()
        {
        }

        public MapItemInstance(int tileIndex, Guid uniqueId, Guid itemId, Guid? bagId, int quantity, string itemPropertiesJson) : base()
        {
            UniqueId = uniqueId;
            X = tileIndex % Options.MapWidth;
            Y = (int)Math.Floor(tileIndex / (float)Options.MapWidth);
            ItemId = itemId;
            BagId = bagId;
            Quantity = quantity;
            Properties = JsonConvert.DeserializeObject<ItemProperties>(itemPropertiesJson);
        }

    }

}
