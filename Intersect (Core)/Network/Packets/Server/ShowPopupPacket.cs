using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class ShowPopupPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public ShowPopupPacket()
        {
        }

        public ShowPopupPacket(string picture, string title, string text, int hideTime, byte opacity)
        {
            Picture = picture;
            Title = title;
            Text = text;
            HideTime = hideTime;
            Opacity = opacity;
        }

        [Key(0)]
        public string Picture { get; set; }

        [Key(1)]
        public string Title { get; set; }

        [Key(2)]
        public string Text { get; set; }

        [Key(3)]
        public int HideTime { get; set; }

        [Key(4)]
        public byte Opacity { get; set; }

    }

}
