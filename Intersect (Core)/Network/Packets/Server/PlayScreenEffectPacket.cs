using Intersect.Enums;
using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class PlayScreenEffectPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public PlayScreenEffectPacket()
        {
        }

        public PlayScreenEffectPacket(ScreenEffectType effectType, string data, int size, byte opacityStart, byte opacityEnd,
            int opacityFrame, int opacityDuration, int finalDuration)
        {
            EffectType = effectType;
            Data = data;
            Size = size;
            OpacityStart = opacityStart;
            OpacityEnd = opacityEnd;
            OpacityFrame = opacityFrame;
            OpacityDuration = opacityDuration;
            FinalDuration = finalDuration;
        }

        [Key(0)]
        public ScreenEffectType EffectType { get; set; }

        [Key(1)]
        public string Data { get; set; }

        [Key(2)]
        public int Size { get; set; }

        [Key(3)]
        public byte OpacityStart { get; set; }

        [Key(4)]
        public byte OpacityEnd { get; set; }

        [Key(5)]
        public int OpacityFrame { get; set; }

        [Key(6)]
        public int OpacityDuration { get; set; }

        [Key(7)]
        public int FinalDuration { get; set; }


    }

}
