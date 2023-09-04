using MessagePack;
using Intersect.Enums;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class NpcEntityPacket : EntityPacket
    {
        //Parameterless Constructor for MessagePack
        public NpcEntityPacket()
        {
        }


        [Key(24)]
        public int Aggression { get; set; }

        [Key(25)]
        public bool IsSpawn { get; set; }

        [Key(26)]
        public ElementalType[] ElementalTypes { get; set; }
    }

}
