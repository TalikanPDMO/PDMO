using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class TradeUpdatePacket : InventoryUpdatePacket
    {
        //Parameterless Constructor for MessagePack
        public TradeUpdatePacket() : base(0, Guid.Empty, 0, null, new int[(int)Enums.Stats.StatCount], Enums.InventoryTab.All)
        {
        }

        public TradeUpdatePacket(Guid traderId, int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs, Enums.InventoryTab invTab) : base(
            slot, id, quantity, bagId, statBuffs, invTab
        )
        {
            TraderId = traderId;
        }

        [Key(7)]
        public Guid TraderId { get; set; }

    }

}
