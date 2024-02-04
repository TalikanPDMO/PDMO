using Intersect.Enums;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class BagUpdatePacket : InventoryUpdatePacket
    {
        //Parameterless Constructor for MessagePack
        public BagUpdatePacket() : base(0, Guid.Empty, 0, null, null)
        {
        }

        public BagUpdatePacket(int slot, Guid id, int quantity, Guid? bagId, string itemPropertiesJson) : base(
            slot, id, quantity, bagId, itemPropertiesJson
        )
        {
        }

    }

}
