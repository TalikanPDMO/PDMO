using System;

using Intersect.Enums;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class EntityDiePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public EntityDiePacket()
        {
        }

        public EntityDiePacket(Guid id, EntityTypes type, Guid mapId, bool isDespawn = false)
        {
            Id = id;
            Type = type;
            MapId = mapId;
            IsDespawn = isDespawn;
        }

        [Key(0)]
        public Guid Id { get; set; }

        [Key(1)]
        public EntityTypes Type { get; set; }

        [Key(2)]
        public Guid MapId { get; set; }

        [Key(3)]
        public bool IsDespawn { get; set; }
    }

}
