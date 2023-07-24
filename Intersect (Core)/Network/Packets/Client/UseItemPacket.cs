using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class UseItemPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public UseItemPacket()
        {
        }

        public UseItemPacket(int slot, Guid targetId, bool fromHotbar=false)
        {
            Slot = slot;
            TargetId = targetId;
            FromHotbar = fromHotbar;
        }

        [Key(0)]
        public int Slot { get; set; }

        [Key(1)]
        public Guid TargetId { get; set; }

        [Key(2)]
        public bool FromHotbar { get; set; }

    }

}
