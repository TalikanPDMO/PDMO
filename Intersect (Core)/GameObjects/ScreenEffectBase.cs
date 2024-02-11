using Intersect.Enums;

namespace Intersect.GameObjects
{

    public class ScreenEffectBase
    {

        public ScreenEffectBase()
        {

        }

        public ScreenEffectType EffectType { get; set; } = ScreenEffectType.ColorTransition;
        public string Data { get; set; } = "";
        public int Size { get; set; } = 0; //Original = 0, Full Screen, Half Screen, Stretch To Fit
        public byte[] Opacities { get; set; } = new byte[(int)ScreenEffectState.StateCount];
        public int[] Durations { get; set; } = new int[(int)ScreenEffectState.StateCount];
        public int[] Frames { get; set; } = new int[(int)ScreenEffectState.StateCount - 1];
        public bool OverGUI { get; set; } = true;

    }
}
