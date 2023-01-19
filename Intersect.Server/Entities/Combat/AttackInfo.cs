using Intersect.Enums;
using System;

namespace Intersect.Server.Entities.Combat
{

    public partial class AttackInfo
    {
        public DamageType DamageType;

        public AttackType AttackType;

        public Guid AttackId;

        public AttackInfo(DamageType damageType, AttackType attackType, Guid attackId)
        {
            DamageType = damageType;
            AttackType = attackType;
            AttackId = attackId;
        }
    }

}
