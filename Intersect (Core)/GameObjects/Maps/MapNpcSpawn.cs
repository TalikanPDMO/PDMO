using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.Enums;
using Newtonsoft.Json;

namespace Intersect.GameObjects.Maps
{

    public class NpcSpawn
    {

        public NpcSpawnDirection Direction;

        public Guid NpcId;

        public int X;

        public int Y;

        public int[] Levels { get; set; } = { 0, 0 };

        public int[] Timeslots { get; set; } = { -1, -1 };

        public List<int> InactiveSpawns = new List<int>();

        [NotMapped]
        [JsonIgnore]
        public long RandomSpawnTimer = 0;

        public NpcSpawn()
        {
        }

        public NpcSpawn(NpcSpawn copy)
        {
            NpcId = copy.NpcId;
            X = copy.X;
            Y = copy.Y;
            Direction = copy.Direction;
            Levels = new int[2];
            copy.Levels.CopyTo(Levels, 0);
            Timeslots = new int[2];
            copy.Timeslots.CopyTo(Timeslots, 0);
            InactiveSpawns = new List<int>(copy.InactiveSpawns);
        }

    }

}
