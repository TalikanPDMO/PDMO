using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class SpellUpdatePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public SpellUpdatePacket()
        {
        }

        public SpellUpdatePacket(int slot, Guid spellId, bool ultimate)
        {
            Slot = slot;
            SpellId = spellId;
            Ultimate = ultimate;
        }

        [Key(0)]
        public int Slot { get; set; }

        [Key(1)]
        public Guid SpellId { get; set; }

        [Key(2)]
        public bool Ultimate { get; set; }

    }

}
