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

        public PlayScreenEffectPacket(ScreenEffectType effectType, string data, int size, bool overGUI,
            byte[] opacities , int[] durations, int[] frames)
        {
            EffectType = effectType;
            Data = data;
            Size = size;
            OverGUI = overGUI;
            Opacities = opacities;
            Durations = durations;
            Frames = frames;
        }

        [Key(0)]
        public ScreenEffectType EffectType { get; set; }

        [Key(1)]
        public string Data { get; set; }

        [Key(2)]
        public int Size { get; set; }

        [Key(3)]
        public bool OverGUI { get; set; }

        [Key(4)]
        public byte[] Opacities { get; set; }

        [Key(5)]
        public int[] Durations { get; set; }

        [Key(6)]
        public int[] Frames { get; set; }

    }

}
