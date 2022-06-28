using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class MatchmakingStadiumTogglePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public MatchmakingStadiumTogglePacket()
        {
        }

        public MatchmakingStadiumTogglePacket(bool onlyInfos)
        {
            OnlyInfos = onlyInfos;
        }

        [Key(0)]
        public bool OnlyInfos { get; set; }

    }

}
