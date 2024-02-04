using Intersect.Enums;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class TradeUpdatePacket : InventoryUpdatePacket
    {
        //Parameterless Constructor for MessagePack
        public TradeUpdatePacket() : base(0, Guid.Empty, 0, null, null)
        {
        }

        public TradeUpdatePacket(Guid traderId, int slot, Guid id, int quantity, Guid? bagId, string itemPropertiesJson) : base(
            slot, id, quantity, bagId, itemPropertiesJson
        )
        {
            TraderId = traderId;
        }

        [Key(6)]
        public Guid TraderId { get; set; }

    }

}
