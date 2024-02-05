using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.Server.Database.PlayerData.Players;
using Intersect.Utilities;

using Newtonsoft.Json;

namespace Intersect.Server.Database
{

    public class Item
    {

        [JsonIgnore] [NotMapped] public double DropChance = 100;
        [JsonIgnore] [NotMapped] public bool DropAmountRandom = false;
        [JsonIgnore] [NotMapped] public bool DropChanceIterative = false;

        public Item()
        {
        }

        public Item(Guid itemId, int quantity, bool incStatBuffs = true) : this(
            itemId, quantity, null, null, incStatBuffs
        )
        {
        }

        public Item(Guid itemId, int quantity, Guid? bagId, Bag bag, bool includeStatBuffs = true)
        {
            ItemId = itemId;
            Quantity = quantity;
            BagId = bagId;
            Bag = bag;

            var descriptor = ItemBase.Get(ItemId);
            if (descriptor == null || !includeStatBuffs)
            {
                return;
            }

            if (descriptor.ItemType != ItemTypes.Equipment)
            {
                return;
            }

            Properties = new ItemProperties();
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                if (descriptor.StatsGiven[i, 0] < descriptor.StatsGiven[i, 1])
                {
                    Properties.Stats[i] = Randomization.Next(descriptor.StatsGiven[i, 0], descriptor.StatsGiven[i, 1] + 1);
                }
                else
                {
                    Properties.Stats[i] = Randomization.Next(descriptor.StatsGiven[i, 1], descriptor.StatsGiven[i, 0] + 1);
                }
                
            }
            for (var i = 0; i < (int)Vitals.VitalCount; i++)
            {
                if(descriptor.VitalsGiven[i, 0] < descriptor.VitalsGiven[i, 1])
                {
                    Properties.Vitals[i] = Randomization.Next(descriptor.VitalsGiven[i, 0], descriptor.VitalsGiven[i, 1] + 1);
                }
                else
                {
                    Properties.Vitals[i] = Randomization.Next(descriptor.VitalsGiven[i, 1], descriptor.VitalsGiven[i, 0] + 1);
                }
                
            }
            foreach (var effect in descriptor.Effects)
            {
                if (effect.Min < effect.Max)
                {
                    Properties.Effects.Add(new int[2] { (int)effect.Type, Randomization.Next(effect.Min, effect.Max + 1) });
                }
                else
                {
                    Properties.Effects.Add(new int[2] { (int)effect.Type, Randomization.Next(effect.Max, effect.Min + 1) });
                }
            }
        }

        public Item(Item item) : this(item.ItemId, item.Quantity, item.BagId, item.Bag)
        {
            if (item.Properties == null)
            {
                Properties = null;
            }
            else
            {
                Properties = new ItemProperties();
                Properties.Id = item.Properties.Id;
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    Properties.Stats[i] = item.Properties.Stats[i];
                }
                for (var i = 0; i < (int)Vitals.VitalCount; i++)
                {
                    Properties.Vitals[i] = item.Properties.Vitals[i];
                }
                Properties.Effects.Clear();
                foreach (var effect in item.Properties.Effects)
                {
                    Properties.Effects.Add(new int[2] { effect[0], effect[1] });
                }
            }
            
            DropChance = item.DropChance;
            DropAmountRandom = item.DropAmountRandom;
            DropChanceIterative = item.DropChanceIterative;
        }
        
        // TODO: THIS SHOULD NOT BE A NULLABLE. This needs to be fixed.
        public Guid? BagId { get; set; }

        [JsonIgnore]
        public virtual Bag Bag { get; set; }

        public Guid ItemId { get; set; } = Guid.Empty;

        [NotMapped]
        public string ItemName => ItemBase.GetName(ItemId);

        public int Quantity { get; set; }

        [NotMapped] public ItemProperties Properties { get; set; } = null;

        [Column("ItemProperties")]
        [JsonIgnore]
        public string ItemPropertiesJson
        {
            get => Properties == null ? "" : JsonConvert.SerializeObject(Properties);
            set =>  Properties = JsonConvert.DeserializeObject<ItemProperties>(value);
        }

        [JsonIgnore]
        [NotMapped]
        public ItemBase Descriptor => ItemBase.Get(ItemId);

        public static Item None => new Item();

        public virtual void Set(Item item)
        {
            ItemId = item.ItemId;
            Quantity = item.Quantity;
            BagId = item.BagId;
            Bag = item.Bag;
            if (item.Properties != null)
            {
                Properties = new ItemProperties();
                Properties.Id = item.Properties.Id;
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    Properties.Stats[i] = item.Properties.Stats[i];
                }
                for (var i = 0; i < (int)Vitals.VitalCount; i++)
                {
                    Properties.Vitals[i] = item.Properties.Vitals[i];
                }
                Properties.Effects.Clear();
                foreach (var effect in item.Properties.Effects)
                {
                    Properties.Effects.Add(new int[2] { effect[0], effect[1] });
                }
            }
            else
            {
                Properties = null;
            }
            
        }

        public string Data()
        {
            return JsonConvert.SerializeObject(this);
        }

        public Item Clone()
        {
            return new Item(this);
        }

        /// <summary>
        /// Try to get the bag, with an additional attempt to load it if it is not already loaded (it should be if this is even a bag item).
        /// </summary>
        /// <param name="bag">the bag if there is one associated with this <see cref="Item"/></param>
        /// <returns>if <paramref name="bag"/> is not <see langword="null"/></returns>
        public bool TryGetBag(out Bag bag)
        {
            bag = Bag;

            // ReSharper disable once InvertIf Justification: Do not introduce two different return points that assert a value state
            if (bag == null)
            {
                var descriptor = Descriptor;
                // ReSharper disable once InvertIf Justification: Do not introduce two different return points that assert a value state
                if (descriptor?.ItemType == ItemTypes.Bag)
                {
                    bag = Bag.GetBag(BagId ?? Guid.Empty);
                    bag?.ValidateSlots();
                    Bag = bag;
                }
            }

            return default != bag;
        }

        public int GetEffectAmount(EffectType effectType)
        {
            var amount = 0;
            int effectTypeIndex = (int)effectType;
            if (Properties != null)
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

    }

    public class ItemProperties
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int[] Stats { get; set; } = new int[(int)Enums.Stats.StatCount];
        public int[] Vitals { get; set; } = new int[(int)Enums.Vitals.VitalCount];

        public List<int[]> Effects = new List<int[]>();

    }

}
