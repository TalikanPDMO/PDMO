using Intersect.Enums;
using Intersect.Server.General;
using Intersect.Server.Networking;

namespace Intersect.Server.Entities.Combat
{

    public partial class Dash
    {

        public byte Direction;

        public int DistanceTraveled;

        public byte Facing;

        public int Range;

        public long TransmittionTimer;

        public Dash(
            Entity en,
            int range,
            byte direction,
            bool blockPass = false,
            bool activeResourcePass = false,
            bool deadResourcePass = false,
            bool zdimensionPass = false
        )
        {
            DistanceTraveled = 0;
            Direction = direction;
            Facing = (byte) en.Dir;

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
            
            TransmittionTimer = Globals.Timing.Milliseconds + (long) ((float) Options.MaxDashSpeed / (float) Range);
            PacketSender.SendEntityDash(
                en, en.MapId, (byte) en.X, (byte) en.Y, (int) (Options.MaxDashSpeed * (Range / 10f)),
                Direction == Facing ? (sbyte) Direction : (sbyte) -1
            );

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
                if (n == -5) //Check for out of bounds
                {
                    return;
                } //Check for blocks

                if (n == -2 && blockPass == false)
                {
                    return;
                } //Check for ZDimensionTiles

                if (n == -3 && zdimensionPass == false)
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
/*                if (n == (int) EntityTypes.Resource && activeResourcePass == false)
                {
                    return;
                } //Check for dead resources

                if (n == (int) EntityTypes.Resource && deadResourcePass == false)
                {
                    return;
                }*/
                
                //Check for players and solid events
                if (n == (int) EntityTypes.Player || n == (int) EntityTypes.Event || n == (int)EntityTypes.Projectile)
                {
                    return;
                }

                en.Move(Direction, null, true, false, true);
                en.Dir = Facing;

                Range = i;
            }
        }

    }

}
