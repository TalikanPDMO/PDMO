using Intersect.Enums;
using System;

namespace Intersect.Server.Entities.Combat
{

    public partial class AttackInfo
    {
        public DamageType DamageType;

        public AttackType AttackType;

        public ElementalType ElementalType;

        public Guid AttackId;

        public AttackInfo(DamageType damageType, AttackType attackType, ElementalType elementalType, Guid attackId)
        {
            DamageType = damageType;
            AttackType = attackType;
            ElementalType = elementalType;
            AttackId = attackId;
        }
    }

}
