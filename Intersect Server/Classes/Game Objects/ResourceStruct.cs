﻿/*
    Intersect Game Engine (Server)
    Copyright (C) 2015  JC Snider, Joe Bridges
    
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com 

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System;
using System.Collections.Generic;
using System.IO;
using Intersect_Server.Classes.General;

namespace Intersect_Server.Classes
{
    public class ResourceStruct
    {
        // General
        public const string Version = "0.0.0.1";
        public string Name = "";
        public int MinHP = 0;
        public int MaxHP = 0;
        public int Tool = 0;
        public int SpawnDuration = 0;
        public int Animation = 0;
        public bool WalkableBefore = false;
        public bool WalkableAfter = false;

        // Graphics
        public string InitialGraphic = "None";
        public string EndGraphic = "None";

        // Drops
        public List<ResourceDrop> Drops = new List<ResourceDrop>();

        public ResourceStruct()
        {
            for (int i = 0; i < Options.MaxNpcDrops; i++)
            {
                Drops.Add(new ResourceDrop());
            }

        }

        public void Load(byte[] packet, int index)
        {
            var myBuffer = new ByteBuffer();
            myBuffer.WriteBytes(packet);
            string loadedVersion = myBuffer.ReadString();
            if (loadedVersion != Version)
                throw new Exception("Failed to load Resource #" + index + ". Loaded Version: " + loadedVersion + " Expected Version: " + Version);
            Name = myBuffer.ReadString();
            InitialGraphic = myBuffer.ReadString();
            EndGraphic = myBuffer.ReadString();
            MinHP = myBuffer.ReadInteger();
            MaxHP = myBuffer.ReadInteger();
            Tool = myBuffer.ReadInteger();
            SpawnDuration = myBuffer.ReadInteger();
            Animation = myBuffer.ReadInteger();
            WalkableBefore = Convert.ToBoolean(myBuffer.ReadInteger());
            WalkableAfter = Convert.ToBoolean(myBuffer.ReadInteger());

            for (int i = 0; i < Options.MaxNpcDrops; i++)
            {
                Drops[i].ItemNum = myBuffer.ReadInteger();
                Drops[i].Amount = myBuffer.ReadInteger();
                Drops[i].Chance = myBuffer.ReadInteger();
            }

            myBuffer.Dispose();
        }

        public byte[] ResourceData()
        {
            var myBuffer = new ByteBuffer();
            myBuffer.WriteString(Version);
            myBuffer.WriteString(Name);
            myBuffer.WriteString(InitialGraphic);
            myBuffer.WriteString(EndGraphic);
            myBuffer.WriteInteger(MinHP);
            myBuffer.WriteInteger(MaxHP);
            myBuffer.WriteInteger(Tool);
            myBuffer.WriteInteger(SpawnDuration);
            myBuffer.WriteInteger(Animation);
            myBuffer.WriteInteger(Convert.ToInt32(WalkableBefore));
            myBuffer.WriteInteger(Convert.ToInt32(WalkableAfter));

            for (int i = 0; i < Options.MaxNpcDrops; i++)
            {
                myBuffer.WriteInteger(Drops[i].ItemNum);
                myBuffer.WriteInteger(Drops[i].Amount);
                myBuffer.WriteInteger(Drops[i].Chance);
            }

            return myBuffer.ToArray();
        }

        public void Save(int resourceNum)
        {
            byte[] data = ResourceData();
            Stream stream = new FileStream("resources/resources/" + resourceNum + ".res", FileMode.OpenOrCreate);
            stream.Write(data, 0, data.Length);
            stream.Close();
        }

        public class ResourceDrop
        {
            public int ItemNum;
            public int Amount;
            public int Chance;
        }
    }
}
