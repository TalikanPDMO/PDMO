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
        public TradeUpdatePacket() : base(0, Guid.Empty, 0, null, new int[(int)Stats.StatCount], new int[(int)Vitals.VitalCount], new List<int[]>())
        {
        }

        public TradeUpdatePacket(Guid traderId, int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs, int[] vitalBuffs, List<int[]> effects) : base(
            slot, id, quantity, bagId, statBuffs, vitalBuffs, effects
        )
        {
            TraderId = traderId;
        }

        [Key(8)]
        public Guid TraderId { get; set; }

    }

}
