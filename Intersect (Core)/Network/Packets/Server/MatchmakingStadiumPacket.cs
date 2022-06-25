using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class MatchmakingStadiumPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public MatchmakingStadiumPacket()
        {
        }

        public MatchmakingStadiumPacket(bool declining)
        {
            IsDeclinedNotif = declining;
        }

        [Key(0)]
        public bool IsDeclinedNotif { get; set; }
    }

}
