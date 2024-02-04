using Intersect.Enums;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class InventoryUpdatePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public InventoryUpdatePacket()
        {
        }

        public InventoryUpdatePacket(int slot, Guid id, int quantity, Guid? bagId, string itemPropertiesJson)
        {
            Slot = slot;
            ItemId = id;
            BagId = bagId;
            Quantity = quantity;
            ItemPropertiesJson = itemPropertiesJson;
        }

        [Key(1)]
        public int Slot { get; set; }

        [Key(2)]
        public Guid ItemId { get; set; }

        [Key(3)]
        public Guid? BagId { get; set; }

        [Key(4)]
        public int Quantity { get; set; }

        [Key(5)]
        public string ItemPropertiesJson { get; set; }

    }

}
