using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class BankUpdatePacket : InventoryUpdatePacket
    {
        //Parameterless Constructor for MessagePack
        public BankUpdatePacket() : base(0, Guid.Empty, 0, null, new int[(int)Enums.Stats.StatCount], Enums.InventoryTab.All)
        {
        }

        public BankUpdatePacket(int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs, Enums.InventoryTab invTab) : base(
            slot, id, quantity, bagId, statBuffs, invTab
        )
        {
        }

    }

}
