using Intersect.Enums;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class MatchmakingStadiumPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public MatchmakingStadiumPacket()
        {
        }

        public MatchmakingStadiumPacket(bool declining, PvpStadiumState stadiumState, int wins, int losses)
        {
            IsDeclinedNotif = declining;
            StadiumState = stadiumState;
            StadiumWins = wins;
            StadiumLosses = losses;
        }

        [Key(0)]
        public bool IsDeclinedNotif { get; set; }

        [Key(1)]
        public PvpStadiumState StadiumState { get; set; }

        [Key(2)]
        public int StadiumWins { get; set; }

        [Key(3)]
        public int StadiumLosses { get; set; }
    }

}
