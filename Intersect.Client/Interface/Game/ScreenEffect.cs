using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Graphics;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
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

        public ScreenEffectBase Base;

        public Guid MapRegionId = Guid.Empty;

        public bool WaitForRegion = false;

        public bool RegionLeave = false;

        public ScreenEffect(PlayScreenEffectPacket packet)
        {
            Base = new ScreenEffectBase();
            Base.EffectType = packet.EffectType;
            Base.Data = packet.Data;
            Base.Size = packet.Size;
            Base.OverGUI = packet.OverGUI;
            Base.Opacities = packet.Opacities ?? new byte[(int)ScreenEffectState.StateCount];
            Base.Durations = packet.Durations ?? new int[(int)ScreenEffectState.StateCount];
            Base.Frames = packet.Frames ?? new int[(int)ScreenEffectState.StateCount - 1];
            Start();
        }
        public ScreenEffect(ScreenEffectBase screenEffectBase, Guid mapRegionId)
        {
            Base = screenEffectBase;
            if (Base.Opacities == null)
            {
                Base.Opacities = new byte[(int)ScreenEffectState.StateCount];
            }
            if (Base.Durations == null)
            {
                Base.Durations = new int[(int)ScreenEffectState.StateCount];
            }
            if (Base.Frames == null)
            {
                Base.Frames = new int[(int)ScreenEffectState.StateCount - 1];
            }
            MapRegionId = mapRegionId;
            Start();
        }

        public ScreenEffect(ScreenEffectType effectType, string data, int[] durations)
        {
            Base = new ScreenEffectBase();
            Base.EffectType = effectType;
            Base.Data = data;
            Base.Durations = durations ?? new int[(int)ScreenEffectState.StateCount];
        }

        public float CurrentOpacity { get; set; } = 255;
        public float OpacityStep { get; set; }

        public long NextUpdateTime { get; set; }

        public int FrameTime { get; set; }

        public long NextStateTime { get; set; }

        public Color ImageColor { get; set; } = null;

        public List<Point> ShakePos = null;

        private int ShakeIterator = 0;

        public ScreenEffectState State { get; set; }
        public void Start()
        {
            switch (Base.EffectType)
            {
                case ScreenEffectType.ColorTransition:
                    mImage = new ImagePanel(GameCanvas);
                    ImageColor = Color.FromString(Base.Data);
                    mImage.Texture = Graphics.Renderer.GetWhiteTexture();
                    if (mImage.Texture != null)
                    {
                        ProcessColorSize(mImage);
                        InitImageTransition();
                    }         
                    break;
                case ScreenEffectType.PictureTransition:
                    mImage = new ImagePanel(GameCanvas);
                    mImage.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Image, Base.Data);
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
                    ShakePos.Add(new Point(Base.Size, 0));
                    ShakePos.Add(new Point(-Base.Size, -Base.Size));
                    ShakePos.Add(new Point(0, -Base.Size));
                    var startTime = Globals.System.GetTimeMs();
                    if (MapRegionId != Guid.Empty)
                    {
                        NextStateTime = 0;
                        WaitForRegion = true;
                    }
                    else
                    {
                        NextStateTime = startTime + Base.Durations[(int)ScreenEffectState.Pending];
                    }
                    NextUpdateTime = startTime + FrameTime;
                    State = ScreenEffectState.Pending;
                    break;
            }
        }

        public void Update()
        {
            if (State < ScreenEffectState.StateCount && Globals.System.GetTimeMs() > NextUpdateTime)
            {
                if (WaitForRegion && RegionLeave)
                {
                    WaitForRegion = false;
                }
                switch (Base.EffectType)
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
            if (!WaitForRegion && Globals.System.GetTimeMs() > NextStateTime)
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
                        if (MapRegionId != Guid.Empty)
                        {
                            if (RegionLeave)
                            {
                                WaitForRegion = false;
                                UpdateImage();
                            }
                            else
                            {
                                WaitForRegion = true;
                                mImage.RenderColor = Color.FromArgb(Base.Opacities[(int)ScreenEffectState.Pending],
                                    mImage.RenderColor.R, mImage.RenderColor.G, mImage.RenderColor.B);
                                NextStateTime = 0;
                                NextUpdateTime = 0;
                            }    
                        }
                        else if (Base.Durations[(int)ScreenEffectState.Pending] == 0)
                        {
                            UpdateImage(); //Duration is 0, go to next state
                        }
                        else
                        {
                            NextStateTime += Base.Durations[(int)ScreenEffectState.Pending];
                            NextUpdateTime = NextStateTime;
                            mImage.RenderColor = Color.FromArgb(Base.Opacities[(int)ScreenEffectState.Pending],
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
                    if (WaitForRegion)
                    {
                        // if we depend of a mapregion, block the state until we leave the region 
                        return;
                    }
                    State = ScreenEffectState.End;
                    if (Base.Durations[(int)ScreenEffectState.End] == 0)
                    {
                        UpdateImage(); //Duration is 0, go to next state
                    }
                    else
                    {
                        SetupImageTransition(Base.Opacities[(int)ScreenEffectState.Pending], Base.Opacities[(int)ScreenEffectState.End],
                            Base.Frames[1], Base.Durations[(int)ScreenEffectState.End]);
                        NextStateTime += Base.Durations[(int)ScreenEffectState.End];
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
            if (Base.Durations[(int)ScreenEffectState.Begin] != 0)
            {
                State = ScreenEffectState.Begin;
                CurrentOpacity = Base.Opacities[(int)ScreenEffectState.Begin];
                SetupImageTransition(Base.Opacities[(int)ScreenEffectState.Begin], Base.Opacities[(int)ScreenEffectState.Pending],
                    Base.Frames[0], Base.Durations[(int)ScreenEffectState.Begin]);
                var startTime = Globals.System.GetTimeMs();
                NextStateTime = startTime + Base.Durations[(int)ScreenEffectState.Begin];
                NextUpdateTime = startTime + FrameTime;
                if (Base.OverGUI)
                {
                    mImage.BringToFront();
                }
                else
                {
                    mImage.SendToBack();
                }
                mImage.Show();
            }
            else if (Base.Durations[(int)ScreenEffectState.Pending] != 0 || MapRegionId != Guid.Empty)
            {
                State = ScreenEffectState.Pending;
                CurrentOpacity = Base.Opacities[(int)ScreenEffectState.Pending];
                if (ImageColor != null)
                {
                    mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, ImageColor.R, ImageColor.G, ImageColor.B);
                }
                else
                {
                    mImage.RenderColor = Color.FromArgb((int)CurrentOpacity, 255, 255, 255);
                }
                if (MapRegionId != Guid.Empty)
                {
                    NextStateTime = 0;
                    WaitForRegion = true;
                    NextUpdateTime = 0;
                }
                else
                {
                    NextStateTime = Globals.System.GetTimeMs() + Base.Durations[(int)ScreenEffectState.Pending];
                    NextUpdateTime = NextStateTime;
                }
                
                if (Base.OverGUI)
                {
                    mImage.BringToFront();
                }
                else
                {
                    mImage.SendToBack();
                }
                mImage.Show();
            }
            else if(Base.Durations[(int)ScreenEffectState.End] != 0)
            {
                State = ScreenEffectState.End;
                CurrentOpacity = Base.Opacities[(int)ScreenEffectState.Pending];
                SetupImageTransition(Base.Opacities[(int)ScreenEffectState.Pending], Base.Opacities[(int)ScreenEffectState.End],
                            Base.Frames[1], Base.Durations[(int)ScreenEffectState.End]);
                var startTime = Globals.System.GetTimeMs();
                NextStateTime = startTime + Base.Durations[(int)ScreenEffectState.End];
                NextUpdateTime = startTime + FrameTime;
                if (Base.OverGUI)
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

            if (Base.Size != (int)PictureSize.Original) // Don't scale if you want to keep the original size.
            {
                if (Base.Size == (int)PictureSize.StretchToFit)
                {
                    picture.SetSize(GameCanvas.Width, GameCanvas.Height);
                    Align.Center(picture);
                }
                else
                {
                    var n = 1;

                    //If you want half fullscreen size set n to 2.
                    if (Base.Size == (int)PictureSize.HalfScreen)
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

            if (Base.Size != (int)PictureSize.Original) // Don't scale if you want to keep the original size.
            {
                if (Base.Size == (int)PictureSize.StretchToFit)
                {
                    image.SetSize(GameCanvas.Width, GameCanvas.Height);
                    Align.Center(image);
                }
                else
                {
                    var n = 1;

                    //If you want half fullscreen size set n to 2.
                    if (Base.Size == (int)PictureSize.HalfScreen)
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
