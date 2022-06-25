using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class MatchmakingStadiumResponsePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public MatchmakingStadiumResponsePacket()
        {
        }

        public MatchmakingStadiumResponsePacket(bool accepting)
        {
            AcceptingMatch = accepting;
        }

        [Key(0)]
        public bool AcceptingMatch { get; set; }

    }

}
