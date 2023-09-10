using System;

namespace Intersect.Client.Spells
{

    public class Spell
    {

        public Guid SpellId;
        public bool Ultimate;

        public Spell Clone()
        {
            var newSpell = new Spell()
            {
                SpellId = SpellId,
                Ultimate = Ultimate
            };

            return newSpell;
        }

        public void Load(Guid spellId, bool ultimate)
        {
            SpellId = spellId;
            Ultimate = ultimate;
        }

    }

}
