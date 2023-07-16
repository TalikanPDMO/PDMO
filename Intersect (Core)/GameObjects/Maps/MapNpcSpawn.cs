using System;
using System.Collections.Generic;
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

        public int MinTime = -1;

        public int MaxTime = -1;

        public List<int> InactiveSpawns = new List<int>();

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
            MinTime = copy.MinTime;
            MaxTime = copy.MaxTime;
            InactiveSpawns = new List<int>(copy.InactiveSpawns);
        }

    }

}
