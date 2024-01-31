﻿using System;
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

            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                // TODO: What the fuck?
                StatBuffs[i] = Randomization.Next(-descriptor.StatGrowth, descriptor.StatGrowth + 1);
            }
            foreach (var effect in descriptor.Effects)
            {
                Effects.Add(new int[2] {(int)effect.Type, Randomization.Next(effect.Min, effect.Max + 1)});
            }
        }

        public Item(Item item) : this(item.ItemId, item.Quantity, item.BagId, item.Bag)
        {
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                StatBuffs[i] = item.StatBuffs[i];
            }
            Effects.Clear();
            foreach (var effect in item.Effects)
            {
                Effects.Add(new int[2] { effect[0], effect[1] });
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

        [Column("StatBuffs")]
        [JsonIgnore]
        public string StatBuffsJson
        {
            get => DatabaseUtils.SaveIntArray(StatBuffs, (int) Stats.StatCount);
            set => StatBuffs = DatabaseUtils.LoadIntArray(value, (int) Stats.StatCount);
        }

        [NotMapped]
        public int[] StatBuffs { get; set; } = new int[(int) Stats.StatCount];


        //Effects
        [NotMapped] public List<int[]> Effects = new List<int[]>();

        [Column("Effects")]
        [JsonIgnore]
        public string EffectsJson
        {
            get => JsonConvert.SerializeObject(Effects, Formatting.None, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            set => Effects = JsonConvert.DeserializeObject<List<int[]>>(value);
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
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                StatBuffs[i] = item.StatBuffs[i];
            }
            Effects.Clear();
            foreach (var effect in item.Effects)
            {
                Effects.Add(new int[2] { effect[0], effect[1] });
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
            foreach(var effect in Effects)
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
