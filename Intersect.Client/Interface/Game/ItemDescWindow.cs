using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using System;
using System.Collections.Generic;

namespace Intersect.Client.Interface.Game
{

    public class ItemDescWindow
    {

        ImagePanel mDescWindow;

        public ItemDescWindow(
            ItemBase item,
            int amount,
            int x,
            int y,
            int[] statBuffs,
            string titleOverride = "",
            string valueLabel = "",
            bool centerHorizontally = false
        )
        {
            var title = titleOverride;
            if (string.IsNullOrWhiteSpace(title))
            {
                title = item.Name;
            }
            var windowSize = CalculateWindowSize(item); // Window size
            if (windowSize == 0) // Small
            {
                mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "ItemDescWindowSmall");
            }
            else if (windowSize == 1) // Medium
            {
                mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "ItemDescWindowMedium");
            }
            else // Large
            {
                mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "ItemDescWindowLarge");
            }
            
            
            if (item != null)
            {

                var iconContainer = new ImagePanel(mDescWindow, "ItemIconContainer");
                var icon = new ImagePanel(iconContainer, "ItemIcon");

                var itemTitleContainer = new ImagePanel(mDescWindow, "ItemTitleContainer");
                var itemName = new Label(itemTitleContainer, "ItemNameLabel");
                itemName.Text = title;

                var itemQuantity = new Label(mDescWindow, "ItemQuantityLabel");

                if (amount > 0)
                {
                    itemQuantity.Text += Strings.ItemDesc.quantity.ToString(amount.ToString("N0").Replace(",", Strings.Numbers.comma));
                }

                var infosContainer = new ImagePanel(mDescWindow, "ItemInfosContainer");
                var itemCategory = new Label(infosContainer, "ItemCategoryLabel");
                itemCategory.Text = Strings.ItemDesc.category.ToString(GetCategoryText(item));

                var itemRarity = new Label(infosContainer, "ItemRarityLabel");
                itemRarity.Text = Strings.ItemDesc.rarity[item.Rarity];
                itemRarity.TextColorOverride = CustomColors.Items.Rarities[item.Rarity];

                var price = new Label(infosContainer, "ItemPriceLabel");
                if (item.Price == 0)
                {
                    price.Text = Strings.ItemDesc.noprice;
                }
                else
                {
                    price.Text = Strings.ItemDesc.price.ToString(item.Price);
                }

                var cooldown = new Label(infosContainer, "ItemCooldownLabel");
                if (item.Cooldown != 0)
                {
                    cooldown.Text = Strings.ItemDesc.cooldown.ToString(item.Cooldown / 1000f);
                }

                var itemValue = new Label(mDescWindow, "ItemValueLabel");
                itemValue.SetText(valueLabel);

                var descContainer = new ImagePanel(mDescWindow, "ItemDescContainer");
                var itemDesc = new RichLabel(descContainer, "ItemDescription");
                var itemDescText = new Label(descContainer, "ItemDescText");
                itemDescText.Font = itemDescText.Parent.Skin.DefaultFont;
                itemDescText.IsHidden = true;
                var itemConditionsText = new Label(descContainer, "ItemConditionsText");
                itemConditionsText.Font = itemConditionsText.Parent.Skin.DefaultFont;
                itemConditionsText.IsHidden = true;

                if (windowSize == 0)
                {
                    //Load this up now so we know what color to make the text when filling out the richlabels
                    mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

                    if (!string.IsNullOrWhiteSpace(item.CannotUseMessage))
                    {
                        itemDesc.AddText(
                           Strings.ItemDesc.prereq.ToString(item.CannotUseMessage), itemConditionsText.RenderColor,
                           itemConditionsText.CurAlignments.Count > 0 ? itemConditionsText.CurAlignments[0] : Alignments.Left,
                           itemConditionsText.Font, itemConditionsText.TextBorderColor
                       );
                        itemDesc.AddLineBreak();
                    }
                    if (item.Description.Length > 0)
                    {
                        itemDesc.AddText(
                            Strings.ItemDesc.desc.ToString(item.Description), itemDesc.RenderColor,
                            itemDescText.CurAlignments.Count > 0 ? itemDescText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font, itemDescText.TextBorderColor
                        );
                    }

                }
                else
                {
                    var dataContainer = new ImagePanel(mDescWindow, "ItemDataContainer");
                    var dataTitle = new Label(dataContainer, "ItemDataTitle");
                    var itemDataText = new Label(dataContainer, "ItemStatsText");
                    itemDataText.Font = itemDataText.Parent.Skin.DefaultFont;
                    var itemData = new RichLabel(dataContainer, "ItemStats");
                    itemDataText.IsHidden = true;

                    if (windowSize == 1)
                    {
                        //Load this up now so we know what color to make the text when filling out the richlabels
                        mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                    }
                    else
                    {
                        var effectsContainer = new ImagePanel(mDescWindow, "ItemEffectsContainer");
                        var effectTitle = new Label(effectsContainer, "ItemEffectsTitle");
                        effectTitle.Text = Strings.ItemDesc.additionaleffects;
                        var itemEffectText = new Label(effectsContainer, "ItemEffectsText");
                        itemEffectText.Font = itemEffectText.Parent.Skin.DefaultFont;
                        var itemEffects = new RichLabel(effectsContainer, "ItemEffects");
                        itemEffectText.IsHidden = true;
                        var itemEffectsElementalType = new ImagePanel(effectsContainer, "ItemEffectsElementalType");
                        //Load this up now so we know what color to make the text when filling out the richlabels
                        mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

                        if (item.ItemType == ItemTypes.Equipment && item.EquipmentSlot == Options.WeaponIndex)
                        {
                            FillEffectsContainer(itemEffects, itemEffectText, item, itemEffectsElementalType);
                            effectsContainer.IsHidden = false;
                        }
                    }

                    switch (item.ItemType)
                    {
                        case ItemTypes.Consumable:
                            dataTitle.Text = Strings.ItemDesc.usage;
                            FillDataContainerWithConsumable(itemData, itemDataText, item);
                            break;
                        case ItemTypes.Spell:
                            dataTitle.Text = Strings.ItemDesc.usage;
                            break;
                        case ItemTypes.Event:
                            FillDataContainerWithEvent(itemData, itemDataText, item);
                            dataTitle.Text = Strings.ItemDesc.usage;
                            break;
                        case ItemTypes.Equipment:
                            dataTitle.Text = Strings.ItemDesc.bonuses;
                            FillDataContainerWithStats(itemData, itemDataText, item, statBuffs);
                            break;

                    }
                    if (!string.IsNullOrWhiteSpace(item.CannotUseMessage))
                    {
                        itemDesc.AddText(
                           Strings.ItemDesc.prereq.ToString(item.CannotUseMessage), itemConditionsText.RenderColor,
                           itemConditionsText.CurAlignments.Count > 0 ? itemConditionsText.CurAlignments[0] : Alignments.Left,
                           itemConditionsText.Font, itemConditionsText.TextBorderColor
                       );
                        itemDesc.AddLineBreak();
                    }
                    if (item.Description.Length > 0)
                    {
                        itemDesc.AddText(
                            Strings.ItemDesc.desc.ToString(item.Description), itemDesc.RenderColor,
                            itemDescText.CurAlignments.Count > 0 ? itemDescText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font, itemDescText.TextBorderColor
                        );
                    }
                }
                //Load Again for positioning purposes.
                //mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                var itemTex = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Item, item.Icon);
                if (itemTex != null)
                {
                    icon.Texture = itemTex;
                    icon.SetSize(itemTex.Width, itemTex.Height);
                    icon.RenderColor = item.Color;
                    icon.ProcessAlignments();
                }
                //itemDesc.SizeToChildren(false, true);
                
                if (centerHorizontally)
                {
                    mDescWindow.MoveTo(x - mDescWindow.Width / 2, y + mDescWindow.Padding.Top);
                }
                else
                {
                    mDescWindow.MoveTo(x - mDescWindow.Width - mDescWindow.Padding.Right, y + mDescWindow.Padding.Top);
                }
            }
        }

        private void FillDataContainerWithEvent(RichLabel itemData, Label itemDataText, ItemBase item)
        {
            if (string.IsNullOrWhiteSpace(item.Use))
            {
                itemData.AddText(
                   Strings.ItemDesc.nodata, itemDataText.RenderColor,
                   itemDataText.CurAlignments.Count > 0 ? itemDataText.CurAlignments[0] : Alignments.Left,
                   itemDataText.Font, itemDataText.TextBorderColor
               );
            }
            else
            {
                itemData.AddText(
                   Strings.ItemDesc.eventeffect.ToString(item.Use), itemDataText.RenderColor,
                   itemDataText.CurAlignments.Count > 0 ? itemDataText.CurAlignments[0] : Alignments.Left,
                   itemDataText.Font, itemDataText.TextBorderColor
               );            }
        }

        private void FillDataContainerWithConsumable(RichLabel itemData, Label itemDataText, ItemBase item)
        {
            var flatStat = item.Consumable.Value;
            var bonusFlat = "";
            if (flatStat > 0)
            {
                if (item.Consumable.Type == ConsumableType.Experience)
                {
                    bonusFlat = Strings.ItemDesc.gain.ToString(flatStat);
                }
                else
                {
                    bonusFlat = Strings.ItemDesc.restore.ToString(flatStat);
                } 
            }
            else if (flatStat < 0)
            {
                bonusFlat = Strings.ItemDesc.lose.ToString(-flatStat);
            }

            var bonusPerc = "";
            if (item.Consumable.Percentage > 0)
            {
                bonusPerc = " + " + item.Consumable.Percentage + "%";
            }
            var consumable = Strings.ItemDesc.consumabletypes[((int)item.Consumable.Type)].ToString(bonusFlat, bonusPerc);
            itemData.AddText(
                consumable, itemData.RenderColor,
                itemDataText.CurAlignments.Count > 0 ? itemDataText.CurAlignments[0] : Alignments.Left,
                itemDataText.Font, itemDataText.TextBorderColor
            );
        }

        private void FillDataContainerWithStats(RichLabel itemData, Label itemDataText, ItemBase item, int[] statBuffs)
        {
            for (var i = 0; i < (int)Vitals.VitalCount; i++)
            {
                var showStat = false;
                var flatStat = item.VitalsGiven[i];
                var bonusFlat = "";
                if (flatStat > 0)
                {
                    bonusFlat = "+" + flatStat + " ";
                    showStat = true;
                }
                else if (flatStat < 0)
                {
                    bonusFlat = flatStat + " ";
                    showStat = true;
                }

                var bonusPerc = "";
                if (item.PercentageVitalsGiven[i] > 0)
                {
                    showStat = true;
                    bonusPerc = " + " + item.PercentageVitalsGiven[i] + "%";
                }
                if (showStat)
                {
                    // Show stat only if not 0
                    var vitals = Strings.ItemDesc.vitals[i].ToString(bonusFlat, bonusPerc);
                    itemData.AddText(
                        vitals, item.VitalsGiven[i] > 0 ? CustomColors.Items.PositiveStat : CustomColors.Items.NegativeStat,
                        itemDataText.CurAlignments.Count > 0 ? itemDataText.CurAlignments[0] : Alignments.Left,
                        itemDataText.Font, itemDataText.TextBorderColor
                    );

                    itemData.AddLineBreak();
                }
            }
            var stats = "";
            if (statBuffs != null)
            {
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    var showStat = false;
                    var flatStat = item.StatsGiven[i] + statBuffs[i];
                    var bonusFlat = "";
                    if (flatStat > 0)
                    {
                        bonusFlat = "+" + flatStat + " ";
                        showStat = true;
                    }
                    else if (flatStat < 0)
                    {
                        bonusFlat = flatStat + " ";
                        showStat = true;
                    }

                    var bonusPerc = "";
                    if (item.PercentageStatsGiven[i] > 0)
                    {
                        showStat = true;
                        bonusPerc = " + " + item.PercentageStatsGiven[i] + "%";
                    }

                    if (showStat)
                    {
                        // Show stat only if not 0
                        stats = Strings.ItemDesc.stats[i].ToString(bonusFlat, bonusPerc);
                        itemData.AddText(
                            stats, item.StatsGiven[i] > 0 ? CustomColors.Items.PositiveStat : CustomColors.Items.NegativeStat,
                            itemDataText.CurAlignments.Count > 0
                                ? itemDataText.CurAlignments[0]
                                : Alignments.Left, itemDataText.Font, itemDataText.TextBorderColor
                        );

                        itemData.AddLineBreak();
                    }
                }
            }
            else
            {
                // Display the possible stat ranges
                for (var i = 0; i < (int)Stats.StatCount; i++)
                {
                    var showStat = false;
                    var flatBonus = "";
                    if (item.StatGrowth > 0)
                    {
                        //TODO Verifier les bonus negatifs etc ...
                        var minBonus = item.StatsGiven[i] - item.StatGrowth;
                        if (minBonus < 0)
                        {
                            minBonus = 0;
                        }
                        var maxBonus = item.StatsGiven[i] + item.StatGrowth;
                        if (maxBonus < 0)
                        {
                            maxBonus = 0;
                        }
                        flatBonus = Strings.ItemDesc.rangestat.ToString(minBonus, maxBonus);
                        showStat = true;
                    }

                    var bonusPerc = "";
                    if (item.PercentageStatsGiven[i] > 0)
                    {
                        showStat = true;
                        bonusPerc = " + " + item.PercentageStatsGiven[i] + "%";
                    }
                    if (showStat)
                    {
                        // Show stat only if not 0
                        stats = Strings.ItemDesc.stats[i].ToString(flatBonus, bonusPerc);
                        itemData.AddText(
                            stats, item.StatsGiven[i] > 0 ? CustomColors.Items.PositiveStat : CustomColors.Items.NegativeStat,
                            itemDataText.CurAlignments.Count > 0
                                ? itemDataText.CurAlignments[0]
                                : Alignments.Left, itemDataText.Font, itemDataText.TextBorderColor
                        );

                        itemData.AddLineBreak();
                    }
                }
            }
            for (var i = 0; i < (int)item.VitalsRegen.Length; i++)
            {
                if (item.VitalsRegen[i] > 0)
                {
                    itemData.AddText(Strings.ItemDesc.vitalsregen[i].ToString(item.VitalsRegen[i]),
                        itemData.RenderColor,
                        itemDataText.CurAlignments.Count > 0 ? itemDataText.CurAlignments[0] : Alignments.Left,
                        itemDataText.Font, itemDataText.TextBorderColor
                    );
                    itemData.AddLineBreak();
                }
            }

            if (item.ItemType == ItemTypes.Equipment && item.Effect.Type != EffectType.None && item.Effect.Percentage > 0)
            {
                itemData.AddText(Strings.ItemDesc.effects[(int)item.Effect.Type - 1].ToString(item.Effect.Percentage),
                    itemData.RenderColor,
                    itemDataText.CurAlignments.Count > 0 ? itemDataText.CurAlignments[0] : Alignments.Left,
                    itemDataText.Font, itemDataText.TextBorderColor
                );
            }
        }

        private void FillEffectsContainer(RichLabel itemEffects, Label itemEffectText, ItemBase item, ImagePanel itemEffectsElementalType)
        {
            //itemEffectsElementalType.Texture = Globals.GetElementalTypeTexture((ElementalType)item.ElementalType, true);
            itemEffects.AddText(Strings.ItemDesc.damage.ToString(item.Damage, Strings.ItemDesc.damagetypes[item.DamageType]),
                itemEffects.RenderColor,
                itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                itemEffectText.Font, itemEffectText.TextBorderColor
            );
            itemEffects.AddLineBreak();
            if (item.Scaling > 0)
            {
                itemEffects.AddText(Strings.ItemDesc.scaling.ToString(Strings.ItemDesc.stats[item.ScalingStat].ToString("", ""), item.Scaling),
                    itemEffects.RenderColor,
                    itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                    itemEffectText.Font, itemEffectText.TextBorderColor
                 );
            }
            else
            {
                itemEffects.AddText(Strings.ItemDesc.noscaling,
                    itemEffects.RenderColor,
                    itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                    itemEffectText.Font, itemEffectText.TextBorderColor
                 );
            }
            itemEffects.AddLineBreak();

            if (item.CritChance > 0)
            {
                itemEffects.AddText(Strings.ItemDesc.critical.ToString(item.CritChance, item.CritMultiplier),
                    itemEffects.RenderColor,
                    itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                    itemEffectText.Font, itemEffectText.TextBorderColor
                 );
            }
            else
            {
                itemEffects.AddText(Strings.ItemDesc.nocritical,
                    itemEffects.RenderColor,
                    itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                    itemEffectText.Font, itemEffectText.TextBorderColor
                 );
            }
            itemEffects.AddLineBreak();
            if (item.AttackSpeedModifier != 0) // Display only if we modify base attackspeed
            {
                if (item.AttackSpeedModifier == 1) //Static
                {
                    itemEffects.AddText(Strings.ItemDesc.atkspeedstatic.ToString(Math.Round(((float)item.AttackSpeedValue) / 1000f, 2)),
                        itemEffects.RenderColor,
                        itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                        itemEffectText.Font, itemEffectText.TextBorderColor
                     );
                    itemEffects.AddLineBreak();

                }
                else if (item.AttackSpeedModifier == 2) //Percentage
                {
                    itemEffects.AddText(Strings.ItemDesc.atkspeedperc.ToString(item.AttackSpeedValue),
                        itemEffects.RenderColor,
                        itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                        itemEffectText.Font, itemEffectText.TextBorderColor
                     );
                    itemEffects.AddLineBreak();
                }
            }
            if (item.ProjectileId != Guid.Empty)
            {
                if (item.Projectile.Range == 0)
                {
                    itemEffects.AddText(Strings.ItemDesc.rangemelee,
                        itemEffects.RenderColor,
                        itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                        itemEffectText.Font, itemEffectText.TextBorderColor
                     );
                }
                else
                {
                    itemEffects.AddText(Strings.ItemDesc.rangeproj.ToString(item.Projectile.Range + 1),
                        itemEffects.RenderColor,
                        itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                        itemEffectText.Font, itemEffectText.TextBorderColor
                     );
                }
                itemEffects.AddLineBreak();
            }
            else if (!item.AdaptRange) // No display if we need to adapt range to starter
            {
                if (item.AttackRange == 0)
                {
                    itemEffects.AddText(Strings.ItemDesc.rangemelee,
                        itemEffects.RenderColor,
                        itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                        itemEffectText.Font, itemEffectText.TextBorderColor
                     );
                }
                else
                {
                    itemEffects.AddText(Strings.ItemDesc.rangetargeted.ToString(item.AttackRange),
                        itemEffects.RenderColor,
                        itemEffectText.CurAlignments.Count > 0 ? itemEffectText.CurAlignments[0] : Alignments.Left,
                        itemEffectText.Font, itemEffectText.TextBorderColor
                     );
                }
                itemEffects.AddLineBreak();
            }
        }


        private int CalculateWindowSize(ItemBase item)
        {
            if (item != null)
            {
                // Look if expanded window is needed
                switch (item.ItemType)
                {
                    case ItemTypes.Consumable:
                    case ItemTypes.Event:
                        return 1; // Medium size
                    case ItemTypes.Equipment:
                        if (item.EquipmentSlot == Options.WeaponIndex)
                        {
                            return 2; // Large size
                        }
                        var statCount = 0;
                        for (var i = 0; i < (int)Vitals.VitalCount; i++)
                        {
                            if (item.VitalsGiven[i] != 0 || item.PercentageVitalsGiven[i] != 0 || item.VitalsRegen[i] != 0)
                            {
                                statCount++;
                            }
                        }
                        for (var i = 0; i < (int)Stats.StatCount; i++)
                        {
                            if (item.StatsGiven[i] != 0 || item.PercentageStatsGiven[i] != 0)
                            {
                                statCount++;
                            }
                        }
                        if (item.Effect.Type != EffectType.None && item.Effect.Percentage != 0)
                        {
                            statCount++;
                        }
                        if (statCount > 3) // This value can change if we decide to increase size of medium window
                        {
                            return 2; // Large size
                        }
                        else
                        {
                            return 1; // Medium size
                        }
                    case ItemTypes.Spell:
                        if (item.QuickCast) // We cast a spell, describe it
                        {
                            return 1; // Medium size
                        }
                        else // We learn a spell
                        {
                            return 0; // Small size
                        }
                    default:
                        return 0; // Small size because not so much info to show
                }
            }
            return 0;
        }

        public void Dispose()
        {
            Interface.GameUi?.GameCanvas?.RemoveChild(mDescWindow, false);
            mDescWindow.Dispose();
        }

        public string GetCategoryText(ItemBase item)
        {
            switch(item.ItemType)
            {
                case ItemTypes.Equipment:
                    return Options.EquipmentSlots[item.EquipmentSlot];
                case ItemTypes.Spell:
                    switch(item.InventoryTab)
                    {
                        case InventoryTab.Projectiles:
                            return Strings.ItemDesc.typeprojectile;
                        case InventoryTab.Consumables:
                            return Strings.ItemDesc.typeconsumable;
                        default:
                            return Strings.ItemDesc.itemtypes[((int)ItemTypes.Spell)];
                    }
                case ItemTypes.Event:
                    switch (item.InventoryTab)
                    {
                        case InventoryTab.Projectiles:
                            return Strings.ItemDesc.typeprojectile;
                        case InventoryTab.Consumables:
                            return Strings.ItemDesc.typeconsumable;
                        default:
                            return Strings.ItemDesc.itemtypes[((int)ItemTypes.Event)];
                    }
                default:
                    return Strings.ItemDesc.itemtypes[((int)item.ItemType)];
            }
            return "";
        }

    }

}
