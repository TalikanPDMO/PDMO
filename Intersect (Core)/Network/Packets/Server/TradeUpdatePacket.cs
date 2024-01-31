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
        public TradeUpdatePacket() : base(0, Guid.Empty, 0, null, new int[(int)Enums.Stats.StatCount], new List<int[]>())
        {
        }

        public TradeUpdatePacket(Guid traderId, int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs, List<int[]> effects) : base(
            slot, id, quantity, bagId, statBuffs, effects
        )
        {
            TraderId = traderId;
        }

        [Key(7)]
        public Guid TraderId { get; set; }

    }

}
