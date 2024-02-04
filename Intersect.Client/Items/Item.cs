using System;
using System.Collections.Generic;
using Intersect.Enums;
using Intersect.GameObjects;
using Newtonsoft.Json;

namespace Intersect.Client.Items
{

    public class Item
    {

        public Guid? BagId;

        public Guid ItemId;

        public int Quantity;

        public ItemProperties Properties = new ItemProperties();

        public ItemBase Base => ItemBase.Get(ItemId);

        public void Load(Guid id, int quantity, Guid? bagId, string itemPropertiesJson)
        {
            ItemId = id;
            Quantity = quantity;
            BagId = bagId;
            Properties = JsonConvert.DeserializeObject<ItemProperties>(itemPropertiesJson);
        }

        public Item Clone()
        {
            var newItem = new Item()
            {
                ItemId = ItemId,
                Quantity = Quantity,
                BagId = BagId
            };
            if (Properties == null)
            {
                newItem.Properties = null;
            }
            else
            {
                newItem.Properties.Id = Properties.Id;
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    newItem.Properties.Stats[i] = Properties.Stats[i];
                }

                for (var i = 0; i < (int)Vitals.VitalCount; i++)
                {
                    newItem.Properties.Vitals[i] = Properties.Vitals[i];
                }

                for (var i = 0; i < Properties.Effects.Count; i++)
                {
                    newItem.Properties.Effects.Add(new int[2] { Properties.Effects[i][0], Properties.Effects[i][1] });
                }
            }
            return newItem;
        }

        public int GetEffectAmount(EffectType effectType)
        {
            var amount = 0;
            int effectTypeIndex = (int)effectType;
            if (Properties != null && Properties.Effects != null)
            {
                foreach (var effect in Properties.Effects)
                {
                    if (effect[0] == effectTypeIndex)
                    {
                        amount += effect[1];
                    }
                }
            }
            return amount;
        }

        public class ItemProperties
        {
            public Guid Id { get; set; }
            public int[] Stats { get; set; } = new int[(int)Enums.Stats.StatCount];
            public int[] Vitals { get; set; } = new int[(int)Enums.Vitals.VitalCount];

            public List<int[]> Effects = new List<int[]>();

        }

    }

}
