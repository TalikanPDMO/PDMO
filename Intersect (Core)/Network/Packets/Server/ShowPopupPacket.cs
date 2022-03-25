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

        public ShowPopupPacket(string picture, string title, string text, int hideTime, byte opacity, string face, sbyte[] popupLayout)
        {
            Picture = picture;
            Title = title;
            Text = text;
            HideTime = hideTime;
            Opacity = opacity;
            Face = face;
            PopupLayout = popupLayout;
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

        [Key(5)]
        public string Face { get; set; }

        [Key(6)]
        public sbyte[] PopupLayout { get; set; }

    }

}
