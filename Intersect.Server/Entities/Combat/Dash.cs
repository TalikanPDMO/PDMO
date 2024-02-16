using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.Server.General;
using Intersect.Server.Networking;
using System;

namespace Intersect.Server.Entities.Combat
{

    public partial class Dash
    {

        public byte Direction;

        public int DistanceTraveled;

        public byte Facing;

        public int Range;

        public long TransmittionTimer;

        public SpellBase Spell;

        public Dash(
            Entity en,
            int range,
            byte direction,
            bool blockPass = false,
            bool activeResourcePass = false,
            bool deadResourcePass = false,
            bool zdimensionPass = false,
            SpellBase spellBase = null,
            int dashTime = 0
        )
        {
            DistanceTraveled = 0;
            Direction = direction;
            Facing = (byte) en.Dir;
            Spell = spellBase;

            CalculateRange(en, range, blockPass, activeResourcePass, deadResourcePass, zdimensionPass);
            if (Range <= 0)
            {
                //Remove dash instance if no where to dash
                return;
            } 

            //Check for collide event at the end of the dash
            if (en is Player p)
            {
                foreach (var evt in p.EventLookup)
                {
                    if (evt.Value.MapId == p.MapId)
                    {
                        if (evt.Value.PageInstance != null && evt.Value.PageInstance.MapId == p.MapId && !evt.Value.PageInstance.CollideOnDash)
                        {
                            var x = evt.Value.PageInstance.GlobalClone?.X ?? evt.Value.PageInstance.X;
                            var y = evt.Value.PageInstance.GlobalClone?.Y ?? evt.Value.PageInstance.Y;
                            var z = evt.Value.PageInstance.GlobalClone?.Z ?? evt.Value.PageInstance.Z;
                            if (x == p.X && y == p.Y && z == p.Z)
                            {
                                p.HandleEventCollision(evt.Value, -1, false);
                            }
                        }
                    }
                }
            }
            if (dashTime == 0)
            {
                dashTime = (int)(Options.MaxDashSpeed * (Range / 10f));
            }
            TransmittionTimer = Globals.Timing.Milliseconds + (long) ((float) Options.MaxDashSpeed / (float) Range);
            PacketSender.SendEntityDash(
                en, en.MapId, (byte) en.X, (byte) en.Y, dashTime,
                Direction == Facing ? (sbyte) Direction : (sbyte) -1
            );

            // Play the animation on the dash end tile
            if (Spell?.ImpactAnimation != null)
            {
                PacketSender.SendAnimationToProximity(Spell.ImpactAnimationId, -1, Guid.Empty, en.MapId, (byte)en.X, (byte)en.Y, (sbyte)Directions.Up);
            }

            en.MoveTimer = Globals.Timing.Milliseconds + Options.MaxDashSpeed;
        }

        public void CalculateRange(
            Entity en,
            int range,
            bool blockPass = false,
            bool activeResourcePass = false,
            bool deadResourcePass = false,
            bool zdimensionPass = false
        )
        {
            var n = 0;
            en.MoveTimer = 0;
            Range = 0;
            for (var i = 1; i <= range; i++)
            {
                n = en.CanMove(Direction);
                if (n == -5 || n == -7) //Check for out of bounds or MapRegion
                {
                    return;
                }
                

                if (n == -2 && blockPass == false)//Check for blocks
                {
                    return;
                }


                if (n == -3 && zdimensionPass == false) //Check for ZDimensionTiles
                {
                    return;
                }

                //Check for resources, update of the Intersect Engine code
                if (n == (int)EntityTypes.Resource)
                {
                    if (en.CollidedResource.Base.Undashable)
                    {
                        return;
                    }

                    if (!deadResourcePass && en.CollidedResource.IsDead())
                    {
                        return;
                    }
                    if (!activeResourcePass && !en.CollidedResource.IsDead())
                    {
                        return;
                    }
                }
                
                //Check for players and solid events
                if (n == (int) EntityTypes.Player || n == (int) EntityTypes.Event || n == (int)EntityTypes.Projectile)
                {
                    return;
                }
                // Play the tile animation (if any) on the entity tile during the dash
                if (Spell?.TilesAnimation != null)
                {
                    PacketSender.SendAnimationToProximity(Spell.TilesAnimationId, -1, Guid.Empty, en.MapId, (byte)en.X, (byte)en.Y, (sbyte)Directions.Up);
                }
                en.Move(Direction, null, true, false, true);
                en.Dir = Facing;

                Range = i;
            }
        }

    }

}
