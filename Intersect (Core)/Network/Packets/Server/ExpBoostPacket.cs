using System;

using Intersect.Enums;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class ExpBoostPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public ExpBoostPacket()
        {
        }

        public ExpBoostPacket(string title, string sourcePlayerName, EventTargetType targetType,
            int amountKill, long expireTimeKill, int amountQuest, long expireTimeQuest)
        {
            Title = title;
            SourcePlayerName = sourcePlayerName;
            TargetType = targetType;
            AmountKill = amountKill;
            ExpireTimeKill = expireTimeKill;
            AmountQuest = amountQuest;
            ExpireTimeQuest = expireTimeQuest;
        }

        [Key(0)]
        public string Title { get; set; }

        [Key(1)]
        public string SourcePlayerName { get; set; }

        [Key(2)]
        public EventTargetType TargetType { get; set; }

        [Key(3)]
        public int AmountKill { get; set; }

        [Key(4)]
        public long ExpireTimeKill { get; set; }

        [Key(5)]
        public int AmountQuest { get; set; }

        [Key(6)]
        public long ExpireTimeQuest { get; set; }
    }

}
