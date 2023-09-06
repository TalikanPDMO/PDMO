﻿using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class BagUpdatePacket : InventoryUpdatePacket
    {
        //Parameterless Constructor for MessagePack
        public BagUpdatePacket() : base(0, Guid.Empty, 0, null, new int[(int)Enums.Stats.StatCount], Enums.InventoryTab.All)
        {
        }

        public BagUpdatePacket(int slot, Guid id, int quantity, Guid? bagId, int[] statBuffs, Enums.InventoryTab invTab) : base(
            slot, id, quantity, bagId, statBuffs, invTab
        )
        {
        }

    }

}
