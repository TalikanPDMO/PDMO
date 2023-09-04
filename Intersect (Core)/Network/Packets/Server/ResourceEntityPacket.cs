using Intersect.Enums;
using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class ResourceEntityPacket : EntityPacket
    {
        //Parameterless Constructor for MessagePack
        public ResourceEntityPacket()
        {
        }


        [Key(24)]
        public Guid ResourceId { get; set; }


        [Key(25)]
        public bool IsDead { get; set; }

        [Key(26)]
        public ElementalType[] ElementalTypes { get; set; }
    }

}
