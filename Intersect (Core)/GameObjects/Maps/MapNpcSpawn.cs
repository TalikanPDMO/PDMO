﻿using System;

using Intersect.Enums;

namespace Intersect.GameObjects.Maps
{

    public class NpcSpawn
    {

        public NpcSpawnDirection Direction;

        public Guid NpcId;

        public int X;

        public int Y;

        public int MinLevel;

        public int MaxLevel;

        public NpcSpawn()
        {
        }

        public NpcSpawn(NpcSpawn copy)
        {
            NpcId = copy.NpcId;
            X = copy.X;
            Y = copy.Y;
            Direction = copy.Direction;
            MinLevel = copy.MinLevel;
            MaxLevel = copy.MaxLevel;
        }

    }

}
