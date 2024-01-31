using System;
using System.Collections.Generic;
using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Items
{

    public class Item
    {

        public Guid? BagId;

        public Guid ItemId;

        public int Quantity;

        public int[] StatBuffs = new int[(int) Stats.StatCount];

        public List<int[]> Effects = new List<int[]>();

        public ItemBase Base => ItemBase.Get(ItemId);

        public void Load(Guid id, int quantity, Guid? bagId, int[] statBuffs, List<int[]> effects)
        {
            ItemId = id;
            Quantity = quantity;
            BagId = bagId;
            StatBuffs = statBuffs;
            Effects = effects;
        }

        public Item Clone()
        {
            var newItem = new Item()
            {
                ItemId = ItemId,
                Quantity = Quantity,
                BagId = BagId
            };

            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                newItem.StatBuffs[i] = StatBuffs[i];
            }

            for (var i = 0; i < Effects.Count; i++)
            {
                newItem.Effects.Add(new int[2] { Effects[i][0], Effects[i][1] });
            }

            return newItem;
        }

        public int GetEffectAmount(EffectType effectType)
        {
            var amount = 0;
            int effectTypeIndex = (int)effectType;
            foreach (var effect in Effects)
            {
                if (effect[0] == effectTypeIndex)
                {
                    amount += effect[1];
                }
            }
            return amount;
        }

    }

}
