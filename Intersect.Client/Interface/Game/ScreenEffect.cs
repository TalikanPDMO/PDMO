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
            OpacityStart = packet.OpacityStart;
            OpacityEnd = packet.OpacityEnd;
            OpacityDuration = packet.OpacityDuration;
            OpacityFrame = packet.OpacityFrame;
            FinalDuration = packet.FinalDuration;
            Start();
        }

        public ScreenEffect(ScreenEffectType effectType, string data, int finalDuration)
        {
            EffectType = effectType;
            Data = data;
            FinalDuration = finalDuration;
        }

        public ScreenEffectType EffectType { get; set; } = ScreenEffectType.ColorTransition;
        public string Data { get; set; } = "";
        public int Size { get; set; } = 0; //Original = 0, Full Screen, Half Screen, Stretch To Fit or ShakeIntensity in pixels

        public int OpacityDuration { get; set; } = 0;

        public int FinalDuration { get; set; } = 0;

        public int OpacityFrame { get; set; } = 0; // 0 = Auto, > 0 = Manual
        public byte OpacityStart { get; set; } = 255;

        public byte OpacityEnd { get; set; } = 255;

        public float CurrentOpacity { get; set; } = 255;
        public float OpacityStep { get; set; }

        public long NextUpdateTime { get; set; }

        public int FrameTime { get; set; }

        public long StartTime { get; set; }

        public List<Point> ShakePos = null;
        private int ShakeIterator = 0;

        public int Step { get; set; } = 0; // 0 before start, 1 when opacity transition, 2 after transition, 3 effect done
        public void Start()
        {
            CurrentOpacity = OpacityStart;
            switch (EffectType)
            {
                case ScreenEffectType.ColorTransition:
                    mImage = new ImagePanel(GameCanvas);
                    mImage.Texture = Graphics.Renderer.GetWhiteTexture();
                    if (mImage.Texture != null)
                    {
                        ProcessColorSize(mImage);
                        ProcessImageTransition(mImage, Color.FromString(Data));
                    }         
                    break;
                case ScreenEffectType.PictureTransition:
                    mImage = new ImagePanel(GameCanvas);
                    mImage.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Image, Data);
                    if (mImage.Texture != null)
                    {
                        ProcessPictureSize(mImage);
                        ProcessImageTransition(mImage, null);
                    }
                    break;
                case ScreenEffectType.Shake:
                    ShakePos = new List<Point>();
                    FrameTime = 30;
                    ShakePos.Clear();
                    ShakePos.Add(new Point(Size, 0));
                    ShakePos.Add(new Point(-Size, -Size));
                    ShakePos.Add(new Point(0, -Size));
                    break;
            }
            StartTime = Globals.System.GetTimeMs();
            NextUpdateTime = StartTime + FrameTime;
            Step = 1;
        }

        public void Update()
        {
            if (Step < 3 && Globals.System.GetTimeMs() > NextUpdateTime)
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
            if (Globals.System.GetTimeMs() > StartTime + FinalDuration)
            {
                Step = 3;
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
            switch (Step)
            {
                case 1:
                    if (Globals.System.GetTimeMs() > StartTime + OpacityDuration)
                    {
                        Step = 2;
                        NextUpdateTime = StartTime + OpacityDuration + FinalDuration;
                        mImage.RenderColor = Color.FromArgb(OpacityEnd,
                            mImage.RenderColor.R, mImage.RenderColor.G, mImage.RenderColor.B);
                    }
                    else
                    {
                        CurrentOpacity += OpacityStep;
                        NextUpdateTime += FrameTime;
                        mImage.RenderColor = Color.FromArgb((int)CurrentOpacity,
                            mImage.RenderColor.R, mImage.RenderColor.G, mImage.RenderColor.B);
                    }
                    break;
                case 2: // NextUpdateTime is over, we need to finish the effect
                    Step = 3;
                    NextUpdateTime = 0;
                    mImage.Hide();
                    break;
                default:
                    NextUpdateTime = 0;
                    mImage.Hide();
                    break;
            }
        }
        private void ProcessImageTransition(ImagePanel image, Color color)
        {
            if (OpacityFrame == 0)
            {
                // Autoframe, +1 or -1 opacity for each update if possible, else we chose 17ms for each (60 FPS)
                FrameTime = Math.Max(17, OpacityDuration / Math.Abs(OpacityEnd - OpacityStart));
                OpacityStep = (OpacityEnd - OpacityStart) * FrameTime / (float)OpacityDuration;
            }
            else
            {
                FrameTime = OpacityDuration / OpacityFrame;
                OpacityStep = (OpacityEnd - OpacityStart) / (float)OpacityFrame;
            }
            if (color != null)
            {
                mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, color.R, color.G, color.B);
            }
            else
            {
                mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, 255, 255, 255);
            }
            
            mImage.BringToFront();
            mImage.Show();
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
