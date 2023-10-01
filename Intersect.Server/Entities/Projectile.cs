﻿using System;
using System.Collections.Generic;
using System.Linq;

using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps;
using Intersect.Logging;
using Intersect.Network.Packets.Server;
using Intersect.Server.Entities.Combat;
using Intersect.Server.General;
using Intersect.Server.Localization;
using Intersect.Server.Maps;
using Intersect.Server.Networking;

namespace Intersect.Server.Entities
{

    public partial class Projectile : Entity
    {

        public ProjectileBase Base;

        public bool HasGrappled;

        public bool AlreadyCrit;

        public ItemBase Item;

        private int mQuantity;

        private int mSpawnCount;

        private int mSpawnedAmount;

        private long mSpawnTime;

        private int mTotalSpawns;

        public Entity Owner;

        // Individual Spawns
        public ProjectileSpawn[] Spawns;

        public ProjectileSpawn[,] LinkedSpawns;

        public SpellBase Spell;

        public Entity Target;

        public Projectile(
            Entity owner,
            SpellBase parentSpell,
            ItemBase parentItem,
            ProjectileBase projectile,
            Guid mapId,
            byte X,
            byte Y,
            byte z,
            byte direction,
            Entity target,
            bool alreadyCrit
        ) : base()
        {
            Base = projectile;
            Name = Base.Name;
            Owner = owner;
            Stat = owner.Stat;
            MapId = mapId;
            Target = target;
            AlreadyCrit = alreadyCrit;
            base.X = X;
            base.Y = Y;
            Z = z;
            SetMaxVital(Vitals.Health, 1);
            SetVital(Vitals.Health, 1);
            Dir = direction;
            Spell = parentSpell;
            Item = parentItem;

            //Static projectiles are passable only if not blocking
            Passable = !Base.BlockTarget;
            HideName = true;
            for (var x = 0; x < ProjectileBase.SPAWN_LOCATIONS_WIDTH; x++)
            {
                for (var y = 0; y < ProjectileBase.SPAWN_LOCATIONS_HEIGHT; y++)
                {
                    for (var d = 0; d < ProjectileBase.MAX_PROJECTILE_DIRECTIONS; d++)
                    {
                        if (Base.SpawnLocations[x, y].Directions[d] == true)
                        {
                            mTotalSpawns++;
                        }
                    }
                }
            }
            LinkedSpawns = new ProjectileSpawn[Base.Quantity, mTotalSpawns];
            mTotalSpawns *= Base.Quantity;
            Spawns = new ProjectileSpawn[mTotalSpawns];
        }

        private void AddProjectileSpawns(List<KeyValuePair<Guid, int>> spawnDeaths)
        {
            var i = 0;
            for (byte x = 0; x < ProjectileBase.SPAWN_LOCATIONS_WIDTH; x++)
            {
                for (byte y = 0; y < ProjectileBase.SPAWN_LOCATIONS_HEIGHT; y++)
                {
                    for (byte d = 0; d < ProjectileBase.MAX_PROJECTILE_DIRECTIONS; d++)
                    {
                        if (Base.SpawnLocations[x, y].Directions[d] == true && mSpawnedAmount < Spawns.Length)
                        {
                            var tile = new TileHelper(MapId, X, Y);
                            tile.Translate(FindProjectileRotationX(Dir, x - 2, y - 2), FindProjectileRotationY(Dir, x - 2, y - 2));
                            var s = new ProjectileSpawn(
                                FindProjectileRotationDir(Dir, d),
                                (byte) tile.GetX(),
                                (byte) tile.GetY(), (byte) Z, tile.GetMapId(), Base, this,
                                (byte)mSpawnedAmount, (byte)mQuantity, (byte)i
                            );

                            Spawns[mSpawnedAmount] = s;
                            LinkedSpawns[mQuantity, i] = s;
                            mSpawnedAmount++;
                            mSpawnCount++;
                            i++;
                            if (CheckForCollision(s))
                            {
                                s.Dead = true;
                            }

                            // Play the impact animation on the first tile for each spawn
                            if (Spell?.ImpactAnimation != null)
                            {
                                PacketSender.SendAnimationToProximity(Spell.ImpactAnimationId, -1, Guid.Empty, s.MapId, (byte)s.X, (byte)s.Y, (sbyte)Directions.Up);
                            }  
                        }
                    }
                }
            }
            mSpawnTime = Globals.Timing.Milliseconds + Base.Delay;
            mQuantity++;
        }

        public static int FindProjectileRotationX(int direction, int x, int y)
        {
            switch (direction)
            {
                case 0: //Up
                    return x;
                case 1: //Down
                    return -x;
                case 2: //Left
                    return y;
                case 3: //Right
                    return -y;
                case 4: //UpLeft
                    return y;
                case 5: //UpRight
                    return -y;
                case 6: //DownLeft
                    return y;
                case 7: //DownRight
                    return -y;
                default:
                    return x;
            }
        }

        public static int FindProjectileRotationY(int direction, int x, int y)
        {
            switch (direction)
            {
                case 0: //Up
                    return y;
                case 1: //Down
                    return -y;
                case 2: //Left
                    return -x;
                case 3: //Right
                    return x;
                case 4: //UpLeft
                    return -x;
                case 5: //UpRight
                    return x;
                case 6: //DownLeft
                    return -x;
                case 7: //DownRight
                    return x;
                default:
                    return y;
            }
        }

        public static byte FindProjectileRotationDir(int entityDir, byte projectionDir)
        {
            switch (entityDir)
            {
                case 0: //Up
                    return projectionDir;
                case 1: //Down
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 1;
                        case 1: //Down
                            return 0;
                        case 2: //Left
                            return 3;
                        case 3: //Right
                            return 2;
                        case 4: //UpLeft
                            return 7;
                        case 5: //UpRight
                            return 6;
                        case 6: //DownLeft
                            return 5;
                        case 7: //DownRight
                            return 4;
                        default:
                            return projectionDir;
                    }
                case 2: //Left
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 2;
                        case 1: //Down
                            return 3;
                        case 2: //Left
                            return 1;
                        case 3: //Right
                            return 0;
                        case 4: //UpLeft
                            return 6;
                        case 5: //UpRight
                            return 4;
                        case 6: //DownLeft
                            return 7;
                        case 7: //DownRight
                            return 5;
                        default:
                            return projectionDir;
                    }
                case 3: //Right
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 3;
                        case 1: //Down
                            return 2;
                        case 2: //Left
                            return 0;
                        case 3: //Right
                            return 1;
                        case 4: //UpLeft
                            return 5;
                        case 5: //UpRight
                            return 7;
                        case 6: //DownLeft
                            return 4;
                        case 7: //DownRight
                            return 6;
                        default:
                            return projectionDir;
                    }
                case 4: //UpLeft
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 2;
                        case 1: //Down
                            return 3;
                        case 2: //Left
                            return 1;
                        case 3: //Right
                            return 0;
                        case 4: //UpLeft
                            return 6;
                        case 5: //UpRight
                            return 4;
                        case 6: //DownLeft
                            return 7;
                        case 7: //DownRight
                            return 5;
                        default:
                            return projectionDir;
                    }
                case 5: //UpRight
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 3;
                        case 1: //Down
                            return 2;
                        case 2: //Left
                            return 0;
                        case 3: //Right
                            return 1;
                        case 4: //UpLeft
                            return 5;
                        case 5: //UpRight
                            return 7;
                        case 6: //DownLeft
                            return 4;
                        case 7: //DownRight
                            return 6;
                        default:
                            return projectionDir;
                    }
                case 6: //DownLeft
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 2;
                        case 1: //Down
                            return 3;
                        case 2: //Left
                            return 1;
                        case 3: //Right
                            return 0;
                        case 4: //UpLeft
                            return 6;
                        case 5: //UpRight
                            return 4;
                        case 6: //DownLeft
                            return 7;
                        case 7: //DownRight
                            return 5;
                        default:
                            return projectionDir;
                    }
                case 7: //DownRight
                    switch (projectionDir)
                    {
                        case 0: //Up
                            return 3;
                        case 1: //Down
                            return 2;
                        case 2: //Left
                            return 0;
                        case 3: //Right
                            return 1;
                        case 4: //UpLeft
                            return 5;
                        case 5: //UpRight
                            return 7;
                        case 6: //DownLeft
                            return 4;
                        case 7: //DownRight
                            return 6;
                        default:
                            return projectionDir;
                    }
                default:
                    return projectionDir;
            }
        }

        public void Update(List<Guid> projDeaths, List<KeyValuePair<Guid, int>> spawnDeaths)
        {
            if (mQuantity < Base.Quantity && Globals.Timing.Milliseconds > mSpawnTime)
            {
                AddProjectileSpawns(spawnDeaths);
            }

            ProcessFragments(projDeaths, spawnDeaths);
        }

        public static int GetRangeX(int direction, int range)
        {
            //Left, UpLeft, DownLeft
            if (direction == 2 || direction == 4 || direction == 6)
            {
                return -range;
            }

            //Right, UpRight, DownRight
            else if (direction == 3 || direction == 5 || direction == 7)
            {
                return range;
            }

            //Up and Down
            else
            {
                return 0;
            }
        }

        public static int GetRangeY(int direction, int range)
        {
            //Up, UpLeft, UpRight
            if (direction == 0 || direction == 4 || direction == 5)
            {
                return -range;
            }

            //Down, DownLeft, DownRight
            else if (direction == 1 || direction == 6 || direction == 7)
            {
                return range;
            }

            //Left and Right
            else
            {
                return 0;
            }
        }

        public void ProcessFragments(List<Guid> projDeaths, List<KeyValuePair<Guid, int>> spawnDeaths)
        {
            if (Base == null)
            {
                return;
            }
            List<byte> addedDeaths = new List<byte>();
            if (mSpawnCount != 0 || mQuantity < Base.Quantity)
            {
                for (var i = 0; i < mSpawnedAmount; i++)
                {
                    var spawn = Spawns[i];
                    if (spawn != null)
                    {
                        while ((Globals.Timing.Milliseconds > spawn.TransmittionTimer || spawn.Dead) && Spawns[i] != null)
                        {
                            var x = spawn.X;
                            var y = spawn.Y;
                            var map = spawn.MapId;
                            var killSpawn = false;
                            if (!spawn.Dead)
                            {
                                if (Base.Speed > 0)
                                {   
                                    killSpawn = MoveFragment(spawn);
                                    if (!killSpawn && (x != spawn.X || y != spawn.Y || map != spawn.MapId))
                                    {
                                        // Play the tile animation on the current projectilespawn tile
                                        if (Spell?.TilesAnimation != null)
                                        {
                                            PacketSender.SendAnimationToProximity(Spell.TilesAnimationId, -1, Guid.Empty, spawn.MapId, (byte)spawn.X, (byte)spawn.Y, (sbyte)Directions.Up);
                                        }
                                        killSpawn = CheckForCollision(spawn);
                                    }
                                }
                                else
                                {
                                    killSpawn = CheckForCollision(spawn);
                                    spawn.TransmittionTimer = Globals.Timing.Milliseconds + spawn.ProjectileBase.Delay;
                                }
                            }

                            if (killSpawn || spawn.Dead)
                            {
                                spawnDeaths.Add(new KeyValuePair<Guid, int>(Id, i));
                                addedDeaths.Add(Spawns[i].LinkedSpawnIndex);
                                LinkedSpawns[Spawns[i].LinkedSpawnIndex, Spawns[i].LinkedSpawnNumber] = null;
                                Spawns[i] = null;
                                
                                mSpawnCount--;
                            }
                        }
                    }
                }
                if (Base.LinkedSpawns)
                {
                    foreach (var deathIndex in addedDeaths)
                    {
                        for(var s=0; s<LinkedSpawns.GetLength(1);s++)
                        {
                            if (LinkedSpawns[deathIndex, s] != null)
                            {
                                spawnDeaths.Add(new KeyValuePair<Guid, int>(Id, LinkedSpawns[deathIndex, s].SpawnIndex));
                                Spawns[LinkedSpawns[deathIndex, s].SpawnIndex] = null;
                                LinkedSpawns[deathIndex, s] = null;
                                mSpawnCount--;
                            }
                        }
                        
                    }
                }
            }
            else
            {
                lock (EntityLock)
                {
                    projDeaths.Add(Id);
                    Die(false);
                }
            }
        }

        public bool CheckForCollision(ProjectileSpawn spawn)
        {
            var killSpawn = MoveFragment(spawn, false);

            //Check Map Entities For Hits
            var map = MapInstance.Get(spawn.MapId);
            if (!killSpawn && map != null)
            {
                var attribute = map.Attributes[(int)spawn.X, (int)spawn.Y];

                //Check for Z-Dimension
                if (!spawn.ProjectileBase.IgnoreZDimension)
                {
                    if (attribute != null && attribute.Type == MapAttributes.ZDimension)
                    {
                        if (((MapZDimensionAttribute) attribute).GatewayTo > 0)
                        {
                            spawn.Z = (byte) (((MapZDimensionAttribute) attribute).GatewayTo - 1);
                        }
                    }
                }

                //Check for grapplehooks.
                if (attribute != null &&
                    attribute.Type == MapAttributes.GrappleStone &&
                    Base.GrappleHook == true &&
                    !spawn.Parent.HasGrappled)
                {
                    if (spawn.Dir <= 3) //Don't handle directional projectile grapplehooks
                    {
                        spawn.Parent.HasGrappled = true;

                        //Only grapple if the player hasnt left the firing position.. if they have then we assume they dont wanna grapple
                        if (Owner.X == X && Owner.Y == Y && Owner.MapId == MapId)
                        {
                            Owner.Dir = spawn.Dir;
                            new Dash(
                                Owner, spawn.Distance, (byte) Owner.Dir, Base.IgnoreMapBlocks,
                                Base.IgnoreActiveResources, Base.IgnoreExhaustedResources, Base.IgnoreZDimension
                            );
                        }

                        killSpawn = true;
                    }
                }

                if (attribute != null &&
                    (attribute.Type == MapAttributes.Blocked || attribute.Type == MapAttributes.Animation && ((MapAnimationAttribute)attribute).IsBlock) &&
                    !spawn.ProjectileBase.IgnoreMapBlocks)
                {
                    killSpawn = true;
                }

                // Check for stop projectiles (mainly static projs like wall etc ...)
                foreach (var proj in map.MapProjectilesCached)
                {
                    if (proj != null && proj != this && proj.Base.StopProjectiles && proj.Spawns != null)
                    {
                        foreach (var stopSpawn in proj.Spawns)
                        {
                            if (stopSpawn != null && !stopSpawn.Dead && stopSpawn.IsAtLocation(spawn.MapId, (int)spawn.X, (int)spawn.Y, spawn.Z))
                            {
                                if (this.Base.StopProjectiles)
                                {
                                    // If both are stopping projectiles, we need to kill also the one we collide
                                    stopSpawn.Dead = true;
                                }
                                //No need to check others, we directly exit with true to gain time
                                return true;
                            }
                        }
                    }
                }
            }
            if (!killSpawn && map != null)
            {
                var entities = map.GetEntities();
                if (entities.Count > 0)
                {
                    for (var z = 0; z < entities.Count; z++)
                    {
                        if (entities[z] != null &&
                            (entities[z].X == Math.Round(spawn.X) || entities[z].X == Math.Ceiling(spawn.X) || entities[z].X == Math.Floor(spawn.X)) &&
                            (entities[z].Y == Math.Round(spawn.Y) || entities[z].Y == Math.Ceiling(spawn.Y) || entities[z].Y == Math.Floor(spawn.Y)) &&
                            entities[z].Z == spawn.Z)
                        {
                            killSpawn = spawn.HitEntity(entities[z]);
                            if (killSpawn && !spawn.ProjectileBase.PierceTarget)
                            {
                                return killSpawn;
                            }
                            else if (spawn.Parent.Base.BlockTarget)
                            {
                                var dashspeed = spawn.Parent.Base.Speed;
                                if (spawn.Parent.Base.Range > 0 && spawn.Parent.Base.Speed > 0)
                                {
                                    //dashRange = spawn.Parent.Base.Range - spawn.Distance + 1;
                                    dashspeed = (int)((float)spawn.Parent.Base.Speed / (float)(spawn.Parent.Base.Range + 1));
                                }
                                new Dash(entities[z], 1, spawn.Dir, false, false, false, false, null, dashspeed);
                            }
                        }
                    }
                }

                if ((Base.Speed == 0 && Globals.Timing.Milliseconds > spawn.TransmittionTimer) || (Base.Speed > 0 && spawn.Distance >= Base.Range))
                {
                    killSpawn = true;
                }
            }

            return killSpawn;
        }

        public bool MoveFragment(ProjectileSpawn spawn, bool move = true)
        {
            float newx = spawn.X;
            float newy = spawn.Y;
            var newMapId = spawn.MapId;

            if (move)
            {
                spawn.Distance++;
                if (Base.Range == 0)
                {
                    spawn.TransmittionTimer += Base.Speed;
                }
                else
                {
                    spawn.TransmittionTimer += (long)((float)Base.Speed / (float)Base.Range);
                }
                newx = spawn.X + GetRangeX(spawn.Dir, 1);
                newy = spawn.Y + GetRangeY(spawn.Dir, 1);
            }

            var killSpawn = false;
            var map = MapInstance.Get(spawn.MapId);

            if (Math.Round(newx) < 0)
            {
                if (MapInstance.Get(map.Left) != null)
                {
                    newMapId = MapInstance.Get(spawn.MapId).Left;
                    newx = Options.MapWidth - 1;
                }
                else
                {
                    killSpawn = true;
                }
            }

            if (Math.Round(newx) > Options.MapWidth - 1)
            {
                if (MapInstance.Get(map.Right) != null)
                {
                    newMapId = MapInstance.Get(spawn.MapId).Right;
                    newx = 0;
                }
                else
                {
                    killSpawn = true;
                }
            }

            if (Math.Round(newy) < 0)
            {
                if (MapInstance.Get(map.Up) != null)
                {
                    newMapId = MapInstance.Get(spawn.MapId).Up;
                    newy = Options.MapHeight - 1;
                }
                else
                {
                    killSpawn = true;
                }
            }

            if (Math.Round(newy) > Options.MapHeight - 1)
            {
                if (MapInstance.Get(map.Down) != null)
                {
                    newMapId = MapInstance.Get(spawn.MapId).Down;
                    newy = 0;
                }
                else
                {
                    killSpawn = true;
                }
            }

            spawn.X = newx;
            spawn.Y = newy;
            spawn.MapId = newMapId;

            return killSpawn;
        }

        public override void Die(bool dropItems = true, Entity killer = null, bool isDespawn = false)
        {
            for (var i = 0; i < Spawns.Length; i++)
            {
                Spawns[i] = null;
            }

            MapInstance.Get(MapId).RemoveProjectile(this);
        }

        public override EntityPacket EntityPacket(EntityPacket packet = null, Player forPlayer = null, bool isSpawn = false)
        {
            if (packet == null)
            {
                packet = new ProjectileEntityPacket();
            }

            packet = base.EntityPacket(packet, forPlayer);

            var pkt = (ProjectileEntityPacket) packet;
            pkt.ProjectileId = Base.Id;
            pkt.ProjectileDirection = (byte) Dir;
            pkt.TargetId = Target?.Id ?? Guid.Empty;
            pkt.OwnerId = Owner?.Id ?? Guid.Empty;

            return pkt;
        }

        public override EntityTypes GetEntityType()
        {
            return EntityTypes.Projectile;
        }

    }

}
