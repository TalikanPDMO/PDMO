using Intersect.Enums;

namespace Intersect.Server.Entities.Combat
{

    public partial class AttackInfo
    {
        public DamageType DamageType;

        public AttackType AttackType;

        public AttackInfo(DamageType damageType, AttackType attackType)
        {
            DamageType = damageType;
            AttackType = attackType;
        }
    }

}
