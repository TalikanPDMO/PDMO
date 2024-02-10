using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Graphics;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Networking;
using Intersect.Enums;
using Intersect.Network.Packets.Server;
using System;
using System.Collections.Generic;

namespace Intersect.Client.Interface.Game
{

    public class ScreenEffect
    {

        // Canvas initialized when loading the game UI (InitGameUi)
        public static Canvas GameCanvas = null;
        private ImagePanel mImage = null;

        public ScreenEffect(PlayScreenEffectPacket packet)
        {
            EffectType = packet.EffectType;
            Data = packet.Data;
            Size = packet.Size;
            OverGUI = packet.OverGUI;
            Opacities = packet.Opacities ?? new byte[(int)ScreenEffectState.StateCount];
            Durations = packet.Durations ?? new int[(int)ScreenEffectState.StateCount];
            Frames = packet.Frames ?? new int[(int)ScreenEffectState.StateCount - 1];
            Start();
        }

        public ScreenEffect(ScreenEffectType effectType, string data, int[] durations)
        {
            EffectType = effectType;
            Data = data;
            Durations = durations ?? new int[(int)ScreenEffectState.StateCount];
        }

        public ScreenEffectType EffectType { get; set; } = ScreenEffectType.ColorTransition;
        public string Data { get; set; } = "";
        public int Size { get; set; } = 0; //Original = 0, Full Screen, Half Screen, Stretch To Fit or ShakeIntensity in pixels

        public byte[] Opacities { get; set; }
        public int[] Durations { get; set; }
        public int[] Frames { get; set; }

        public float CurrentOpacity { get; set; } = 255;
        public float OpacityStep { get; set; }

        public long NextUpdateTime { get; set; }

        public int FrameTime { get; set; }

        public long NextStateTime { get; set; }

        public Color ImageColor { get; set; } = null;

        public List<Point> ShakePos = null;

        private int ShakeIterator = 0;

        public bool OverGUI = true;

        public ScreenEffectState State { get; set; }
        public void Start()
        {
            switch (EffectType)
            {
                case ScreenEffectType.ColorTransition:
                    mImage = new ImagePanel(GameCanvas);
                    ImageColor = Color.FromString(Data);
                    mImage.Texture = Graphics.Renderer.GetWhiteTexture();
                    if (mImage.Texture != null)
                    {
                        ProcessColorSize(mImage);
                        InitImageTransition();
                    }         
                    break;
                case ScreenEffectType.PictureTransition:
                    mImage = new ImagePanel(GameCanvas);
                    mImage.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Image, Data);
                    if (mImage.Texture != null)
                    {
                        ProcessPictureSize(mImage);
                        InitImageTransition();
                    }
                    break;
                case ScreenEffectType.Shake:
                    ShakePos = new List<Point>();
                    FrameTime = 30;
                    ShakePos.Clear();
                    ShakePos.Add(new Point(Size, 0));
                    ShakePos.Add(new Point(-Size, -Size));
                    ShakePos.Add(new Point(0, -Size));
                    var startTime = Globals.System.GetTimeMs();
                    NextStateTime = startTime + Durations[(int)ScreenEffectState.Pending];
                    NextUpdateTime = startTime + FrameTime;
                    State = ScreenEffectState.Pending;
                    break;
            }
        }

        public void Update()
        {
            if (State < ScreenEffectState.StateCount && Globals.System.GetTimeMs() > NextUpdateTime)
            {
                switch (EffectType)
                {
                    case ScreenEffectType.ColorTransition:
                        UpdateImage();
                        break;
                    case ScreenEffectType.PictureTransition:
                        UpdateImage();
                        break;
                    case ScreenEffectType.Shake:
                        UpdateShake();
                        break;
                }
            }
        }
        private void UpdateShake()
        {
            if (Globals.System.GetTimeMs() > NextStateTime)
            {
                State = ScreenEffectState.StateCount;
            }
            else
            {
                if (ShakeIterator >= ShakePos.Count)
                {
                    ShakeIterator = 0;
                }
                Graphics.CurrentView.X += ShakePos[ShakeIterator].X;
                Graphics.CurrentView.Y += ShakePos[ShakeIterator].Y;
                ShakeIterator++;
                NextUpdateTime += FrameTime;
            } 
        }
        private void UpdateImage()
        {
            switch (State)
            {
                case ScreenEffectState.Begin:
                    if (Globals.System.GetTimeMs() > NextStateTime)
                    {
                        State = ScreenEffectState.Pending;
                        if (Durations[(int)ScreenEffectState.Pending] == 0)
                        {
                            UpdateImage(); //Duration is 0, go to next state
                        }
                        else
                        {
                            NextStateTime += Durations[(int)ScreenEffectState.Pending];
                            NextUpdateTime = NextStateTime;
                            mImage.RenderColor = Color.FromArgb(Opacities[(int)ScreenEffectState.Pending],
                                mImage.RenderColor.R, mImage.RenderColor.G, mImage.RenderColor.B);
                        }                     
                    }
                    else
                    {
                        CurrentOpacity += OpacityStep;
                        NextUpdateTime += FrameTime;
                        mImage.RenderColor = Color.FromArgb((int)CurrentOpacity,
                            mImage.RenderColor.R, mImage.RenderColor.G, mImage.RenderColor.B);
                    }
                    break;
                case ScreenEffectState.Pending: // NextUpdateTime is over, we need to transit to the finish of the
                    State = ScreenEffectState.End;
                    if (Durations[(int)ScreenEffectState.End] == 0)
                    {
                        UpdateImage(); //Duration is 0, go to next state
                    }
                    else
                    {
                        SetupImageTransition(Opacities[(int)ScreenEffectState.Pending], Opacities[(int)ScreenEffectState.End],
                            Frames[1], Durations[(int)ScreenEffectState.End]);
                        NextStateTime += Durations[(int)ScreenEffectState.End];
                        NextUpdateTime += FrameTime; // Start the ending transition 
                    }
                    break;
                case ScreenEffectState.End:
                    if (Globals.System.GetTimeMs() > NextStateTime)
                    {
                        State = ScreenEffectState.StateCount;
                        NextUpdateTime = 0;
                        NextStateTime = 0;
                        mImage.Hide();
                    }
                    else
                    {
                        CurrentOpacity += OpacityStep;
                        NextUpdateTime += FrameTime;
                        mImage.RenderColor = Color.FromArgb((int)CurrentOpacity,
                            mImage.RenderColor.R, mImage.RenderColor.G, mImage.RenderColor.B);
                    }
                    
                    break;
                default:
                    NextUpdateTime = 0;
                    NextStateTime = 0;
                    mImage.Hide();
                    break;
            }
        }

        private void InitImageTransition()
        {
            if (Durations[(int)ScreenEffectState.Begin] != 0)
            {
                State = ScreenEffectState.Begin;
                CurrentOpacity = Opacities[(int)ScreenEffectState.Begin];
                SetupImageTransition(Opacities[(int)ScreenEffectState.Begin], Opacities[(int)ScreenEffectState.Pending],
                    Frames[0], Durations[(int)ScreenEffectState.Begin]);
                var startTime = Globals.System.GetTimeMs();
                NextStateTime = startTime + Durations[(int)ScreenEffectState.Begin];
                NextUpdateTime = startTime + FrameTime;
                if (OverGUI)
                {
                    mImage.BringToFront();
                }
                else
                {
                    mImage.SendToBack();
                }
                mImage.Show();
            }
            else if (Durations[(int)ScreenEffectState.Pending] != 0)
            {
                State = ScreenEffectState.Pending;
                CurrentOpacity = Opacities[(int)ScreenEffectState.Pending];
                if (ImageColor != null)
                {
                    mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, ImageColor.R, ImageColor.G, ImageColor.B);
                }
                else
                {
                    mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, 255, 255, 255);
                }
                var startTime = Globals.System.GetTimeMs();
                NextStateTime = startTime + Durations[(int)ScreenEffectState.Pending];
                NextUpdateTime = NextStateTime;
                if (OverGUI)
                {
                    mImage.BringToFront();
                }
                else
                {
                    mImage.SendToBack();
                }
                mImage.Show();
            }
            else if(Durations[(int)ScreenEffectState.End] != 0)
            {
                State = ScreenEffectState.End;
                CurrentOpacity = Opacities[(int)ScreenEffectState.Pending];
                SetupImageTransition(Opacities[(int)ScreenEffectState.Pending], Opacities[(int)ScreenEffectState.End],
                            Frames[1], Durations[(int)ScreenEffectState.End]);
                var startTime = Globals.System.GetTimeMs();
                NextStateTime = startTime + Durations[(int)ScreenEffectState.End];
                NextUpdateTime = startTime + FrameTime;
                if (OverGUI)
                {
                    mImage.BringToFront();
                }
                else
                {
                    mImage.SendToBack();
                }
                mImage.Show();
            }
            else
            {
                State = ScreenEffectState.StateCount;
                mImage.Hide();
            } 

        }
        private void SetupImageTransition(byte opacityStart, byte opacityEnd, int opacityFrame, int opacityDuration)
        {
            if (opacityFrame == 0)
            {
                // Autoframe, +1 or -1 opacity for each update if possible, else we chose 17ms for each (60 FPS)
                FrameTime = Math.Max(17, opacityDuration / Math.Max(Math.Abs(opacityEnd - opacityStart), 1));
                OpacityStep = opacityDuration == 0 ? 0 : (opacityEnd - opacityStart) * FrameTime / (float)opacityDuration;
            }
            else
            {
                FrameTime = opacityDuration / opacityFrame;
                OpacityStep = (opacityEnd - opacityStart) / (float)opacityFrame;
            }
            if (ImageColor != null)
            {
                mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, ImageColor.R, ImageColor.G, ImageColor.B);
            }
            else
            {
                mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, 255, 255, 255);
            }
        }

        private void ProcessPictureSize(ImagePanel picture)
        {
            picture.SetSize(picture.Texture.GetWidth(), picture.Texture.GetHeight());
            Align.Center(picture);

            if (Size != (int)PictureSize.Original) // Don't scale if you want to keep the original size.
            {
                if (Size == (int)PictureSize.StretchToFit)
                {
                    picture.SetSize(GameCanvas.Width, GameCanvas.Height);
                    Align.Center(picture);
                }
                else
                {
                    var n = 1;

                    //If you want half fullscreen size set n to 2.
                    if (Size == (int)PictureSize.HalfScreen)
                    {
                        n = 2;
                    }

                    var ar = (float)picture.Width / (float)picture.Height;
                    var heightLimit = true;
                    if (GameCanvas.Width < GameCanvas.Height * ar)
                    {
                        heightLimit = false;
                    }

                    if (heightLimit)
                    {
                        var height = GameCanvas.Height;
                        var width = GameCanvas.Height * ar;
                        picture.SetSize((int)(width / n), (int)(height / n));
                        Align.Center(picture);
                    }
                    else
                    {
                        var width = GameCanvas.Width;
                        var height = width / ar;
                        picture.SetSize((int)(width / n), (int)(height / n));
                        Align.Center(picture);
                    }
                }
            }
        }

        private void ProcessColorSize(ImagePanel image)
        {
            image.SetSize(Options.TileWidth, Options.TileHeight);
            Align.Center(image);

            if (Size != (int)PictureSize.Original) // Don't scale if you want to keep the original size.
            {
                if (Size == (int)PictureSize.StretchToFit)
                {
                    image.SetSize(GameCanvas.Width, GameCanvas.Height);
                    Align.Center(image);
                }
                else
                {
                    var n = 1;

                    //If you want half fullscreen size set n to 2.
                    if (Size == (int)PictureSize.HalfScreen)
                    {
                        n = 2;
                    }

                    var ar = (float)image.Width / (float)image.Height;
                    var heightLimit = true;
                    if (GameCanvas.Width < GameCanvas.Height * ar)
                    {
                        heightLimit = false;
                    }

                    if (heightLimit)
                    {
                        var height = GameCanvas.Height;
                        var width = GameCanvas.Height * ar;
                        image.SetSize((int)(width / n), (int)(height / n));
                        Align.Center(image);
                    }
                    else
                    {
                        var width = GameCanvas.Width;
                        var height = width / ar;
                        image.SetSize((int)(width / n), (int)(height / n));
                        Align.Center(image);
                    }
                }
            }
        }

        private enum PictureSize
        {

            Original = 0,

            FullScreen,

            HalfScreen,

            StretchToFit,

        }

    }

}
