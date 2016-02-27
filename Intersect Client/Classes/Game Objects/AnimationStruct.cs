﻿/*
    The MIT License (MIT)

    Copyright (c) 2015 JC Snider, Joe Bridges
  
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using System;
using System.Runtime.InteropServices;
using IntersectClientExtras.GenericClasses;
using IntersectClientExtras.Graphics;
using Intersect_Client.Classes.Core;
using Intersect_Client.Classes.General;
using Intersect_Client.Classes.Maps;
using Intersect_Client.Classes.Misc;

namespace Intersect_Client.Classes.Game_Objects
{
    public class AnimationStruct
    {
        public const string Version = "0.0.0.1";
        public string Name = "";
        public string Sound = "";

        //Lower Animation
        public string LowerAnimSprite = "";
        public int LowerAnimXFrames = 1;
        public int LowerAnimYFrames = 1;
        public int LowerAnimFrameCount = 1;
        public int LowerAnimFrameSpeed = 100;
        public int LowerAnimLoopCount = 1;
        public Light[] LowerLights;

        //Upper Animation
        public string UpperAnimSprite = "";
        public int UpperAnimXFrames = 1;
        public int UpperAnimYFrames = 1;
        public int UpperAnimFrameCount = 1;
        public int UpperAnimFrameSpeed = 100;
        public int UpperAnimLoopCount = 1;
        public Light[] UpperLights;

        public void Load(byte[] packet, int index)
        {
            var myBuffer = new ByteBuffer();
            myBuffer.WriteBytes(packet);

            string loadedVersion = myBuffer.ReadString();
            if (loadedVersion != Version)
                throw new Exception("Failed to load Animation #" + index + ". Loaded Version: " + loadedVersion + " Expected Version: " + Version);

            Name = myBuffer.ReadString();
            Sound = myBuffer.ReadString();

            //Lower Animation
            LowerAnimSprite = myBuffer.ReadString();
            LowerAnimXFrames = myBuffer.ReadInteger();
            LowerAnimYFrames = myBuffer.ReadInteger();
            LowerAnimFrameCount = myBuffer.ReadInteger();
            LowerAnimFrameSpeed = myBuffer.ReadInteger();
            LowerAnimLoopCount = myBuffer.ReadInteger();
            LowerLights = new Light[LowerAnimFrameCount];
            for (int i = 0; i < LowerAnimFrameCount; i++)
            {
                LowerLights[i] = new Light(myBuffer);
            }

            //Upper Animation
            UpperAnimSprite = myBuffer.ReadString();
            UpperAnimXFrames = myBuffer.ReadInteger();
            UpperAnimYFrames = myBuffer.ReadInteger();
            UpperAnimFrameCount = myBuffer.ReadInteger();
            UpperAnimFrameSpeed = myBuffer.ReadInteger();
            UpperAnimLoopCount = myBuffer.ReadInteger();
            UpperLights = new Light[UpperAnimFrameCount];
            for (int i = 0; i < UpperAnimFrameCount; i++)
            {
                UpperLights[i] = new Light(myBuffer);
            }

            myBuffer.Dispose();
        }
    }

    public class AnimationInstance
    {
        private AnimationStruct myBase;
        private float _renderX = 0;
        private float _renderY = 0;
        private int _renderDir = 0;
        private int lowerFrame;
        private int upperFrame;
        private int lowerLoop;
        private int upperLoop;
        private long lowerTimer;
        private long upperTimer;
        private bool infiniteLoop = false;
        private bool showLower = true;
        private bool showUpper = true;
        public AnimationInstance(AnimationStruct animBase, bool loopForever)
        {
            myBase = animBase;
            lowerLoop = animBase.LowerAnimLoopCount;
            upperLoop = animBase.UpperAnimLoopCount;
            lowerTimer = Globals.System.GetTimeMS() + animBase.LowerAnimFrameSpeed;
            upperTimer = Globals.System.GetTimeMS() + animBase.UpperAnimFrameSpeed;
            infiniteLoop = loopForever;
            GameGraphics.LiveAnimations.Add(this);
        }

        public void Draw(bool upper = false)
        {
            float rotationDegrees = 0f;
            switch (_renderDir)
            {
                case 0: //Up
                    rotationDegrees = 0f;
                    break;
                case 1: //Down
                    rotationDegrees = 180f;
                    break;
                case 2: //Left
                    rotationDegrees = 270f;
                    break;
                case 3: //Right
                    rotationDegrees = 90f;
                    break;
                case 4: //NW
                    rotationDegrees = 315f;
                    break;
                case 5: //NE
                    rotationDegrees = 45f;
                    break;
                case 6: //SW
                    rotationDegrees = 225f;
                    break;
                case 7: //SE
                    rotationDegrees = 135f;
                    break;
            }

            if (!upper)
            {
                //Draw Lower
                if (showLower && GameGraphics.AnimationFileNames.IndexOf(myBase.LowerAnimSprite) > -1)
                {
                    if (myBase.LowerAnimXFrames > 0 && myBase.LowerAnimYFrames > 0)
                    {
                        GameTexture tex =
                            GameGraphics.AnimationTextures[
                                GameGraphics.AnimationFileNames.IndexOf(myBase.LowerAnimSprite)];
                        int frameWidth = tex.GetWidth() / myBase.LowerAnimXFrames;
                        int frameHeight = tex.GetHeight() / myBase.LowerAnimYFrames;
                        GameGraphics.DrawGameTexture(tex,
                            new FloatRect((lowerFrame % myBase.LowerAnimXFrames) * frameWidth,
                                (float)Math.Floor((double)lowerFrame / myBase.LowerAnimXFrames) * frameHeight, frameWidth,
                                frameHeight),
                            new FloatRect(_renderX - frameWidth / 2, _renderY - frameHeight / 2, frameWidth, frameHeight),
                            Color.White, null, GameBlendModes.Alpha, null, rotationDegrees);
                        GameGraphics.DrawLight((int)_renderX + myBase.LowerLights[lowerFrame].OffsetX,
                            (int)_renderY + myBase.LowerLights[lowerFrame].OffsetY, myBase.LowerLights[lowerFrame].Size,
                            myBase.LowerLights[lowerFrame].Intensity, myBase.LowerLights[lowerFrame].Expand,
                            myBase.LowerLights[lowerFrame].Color);
                    }
                }
            }
            else
            {
                //Draw Upper
                if (showUpper && GameGraphics.AnimationFileNames.IndexOf(myBase.UpperAnimSprite) > -1)
                {
                    if (myBase.UpperAnimXFrames > 0 && myBase.UpperAnimYFrames > 0)
                    {
                        GameTexture tex =
                            GameGraphics.AnimationTextures[
                                GameGraphics.AnimationFileNames.IndexOf(myBase.UpperAnimSprite)];
                        int frameWidth = tex.GetWidth() / myBase.UpperAnimXFrames;
                        int frameHeight = tex.GetHeight() / myBase.UpperAnimYFrames;
                        GameGraphics.DrawGameTexture(tex,
                            new FloatRect((upperFrame % myBase.UpperAnimXFrames) * frameWidth,
                                (float)Math.Floor((double)upperFrame / myBase.UpperAnimXFrames) * frameHeight, frameWidth,
                                frameHeight),
                            new FloatRect(_renderX - frameWidth / 2, _renderY - frameHeight / 2, frameWidth, frameHeight),
                            Color.White, null, GameBlendModes.Alpha, null, rotationDegrees);
                        GameGraphics.DrawLight((int)_renderX + myBase.UpperLights[lowerFrame].OffsetX,
                            (int)_renderY + myBase.UpperLights[lowerFrame].OffsetY, myBase.UpperLights[lowerFrame].Size,
                            myBase.UpperLights[lowerFrame].Intensity, myBase.UpperLights[lowerFrame].Expand,
                            myBase.UpperLights[lowerFrame].Color);
                    }
                }
            }
        }

        public void Dispose()
        {
            GameGraphics.LiveAnimations.Remove(this);
        }

        public void SetPosition(float x, float y, int dir)
        {
            _renderX = x;
            _renderY = y;
            _renderDir = dir;
        }

        public void Update()
        {
            if (lowerTimer < Globals.System.GetTimeMS() && showLower)
            {
                lowerFrame++;
                if (lowerFrame >= myBase.LowerAnimFrameCount)
                {
                    lowerLoop--;
                    lowerFrame = 0;
                    if (lowerLoop < 0)
                    {
                        if (infiniteLoop)
                        {
                            lowerLoop = myBase.LowerAnimLoopCount;
                        }
                        else
                        {
                            showLower = false;
                        }
                    }
                    lowerTimer = Globals.System.GetTimeMS() + myBase.LowerAnimFrameSpeed;
                }
            }
            if (upperTimer < Globals.System.GetTimeMS() && showUpper)
            {
                upperFrame++;
                if (upperFrame >= myBase.UpperAnimFrameCount)
                {
                    upperLoop--;
                    upperFrame = 0;
                    if (upperLoop < 0)
                    {
                        if (infiniteLoop)
                        {
                            upperLoop = myBase.UpperAnimLoopCount;

                        }
                        else
                        {
                            showUpper = false;
                        }
                    }
                    upperTimer = Globals.System.GetTimeMS() + myBase.UpperAnimFrameSpeed;
                }
            }
        }
    }
}
