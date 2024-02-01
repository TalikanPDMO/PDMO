using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
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
            List<int[]> effects,
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
            bool expandedWindow = false;
            mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "ItemDescWindow");
            if (item != null && item.ItemType == ItemTypes.Equipment)
            {
                // Look if expanded window is needed
                if (item.EquipmentSlot == Options.WeaponIndex && (item.Damage != 0 || item.ManaDamage != 0))
                {
                    expandedWindow = true;
                }
                else if (effects != null || item.Effects.Count > 0)
                {
                    expandedWindow = true;
                }
                else
                {
                    for (var i = 0; i < (int)Vitals.VitalCount; i++)
                    {
                        if (item.VitalsGiven[i] != 0 || item.PercentageVitalsGiven[i] != 0)
                        {
                            expandedWindow = true;
                            break;
                        }
                    }
                    for (var i = 0; i < (int)Stats.StatCount; i++)
                    {
                        if ((item.StatsGiven[i, 0] != 0 && item.StatsGiven[i, 1] != 0) || item.PercentageStatsGiven[i] != 0)
                        {
                            expandedWindow = true;
                            break;
                        }
                    } 
                }

                if (expandedWindow)
                {
                    mDescWindow.Name = "ItemDescWindowExpanded";
                }
            }
            if (item != null)
            {
                var icon = new ImagePanel(mDescWindow, "ItemIcon");

                var itemName = new Label(mDescWindow, "ItemNameLabel");
                itemName.Text = title;

                var itemQuantity = new Label(mDescWindow, "ItemQuantityLabel");

                if (amount > 1)
                {
                    itemQuantity.Text += amount.ToString("N0").Replace(",", Strings.Numbers.comma);
                }

                itemName.AddAlignment(Alignments.CenterH);

                var itemType = new Label(mDescWindow, "ItemTypeLabel");
                var itemValue = new Label(mDescWindow, "ItemValueLabel");

                itemType.Text = Strings.ItemDesc.itemtypes[(int) item.ItemType];
                itemValue.SetText(valueLabel);

                if (item.ItemType == ItemTypes.Equipment &&
                    item.EquipmentSlot >= 0 &&
                    item.EquipmentSlot < Options.EquipmentSlots.Count)
                {
                    itemType.Text = Options.EquipmentSlots[item.EquipmentSlot];
                    if (item.EquipmentSlot == Options.WeaponIndex && item.TwoHanded)
                    {
                        itemType.Text += " - " + Strings.ItemDesc.twohand;
                    }
                }

                if (item.Rarity > 0)
                {
                    itemType.Text += " - " + Strings.ItemDesc.rarity[item.Rarity];
                    var rarity = CustomColors.Items.Rarities.ContainsKey(item.Rarity)
                        ? CustomColors.Items.Rarities[item.Rarity]
                        : Color.White;

                    itemType.TextColorOverride.R = rarity.R;
                    itemType.TextColorOverride.G = rarity.G;
                    itemType.TextColorOverride.B = rarity.B;
                    itemType.TextColorOverride.A = rarity.A;
                }

                var itemDesc = new RichLabel(mDescWindow, "ItemDescription");
                var itemDescText = new Label(mDescWindow, "ItemDescText");
                itemDescText.Font = itemDescText.Parent.Skin.DefaultFont;
                var itemStatsText = new Label(mDescWindow, expandedWindow ? "ItemStatsText" : "");
                itemStatsText.Font = itemStatsText.Parent.Skin.DefaultFont;
                var itemStats = new RichLabel(mDescWindow, expandedWindow ? "ItemStats" : "");
                itemDescText.IsHidden = true;
                itemStatsText.IsHidden = true;

                //Load this up now so we know what color to make the text when filling out the desc
                mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                if (item.Description.Length > 0)
                {
                    itemDesc.AddText(
                        Strings.ItemDesc.desc.ToString(item.Description), itemDesc.RenderColor,
                        itemDescText.CurAlignments.Count > 0 ? itemDescText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );

                    itemDesc.AddLineBreak();
                    itemDesc.AddLineBreak();
                }

                var stats = "";
                if (expandedWindow)
                {
                    stats = Strings.ItemDesc.bonuses;
                    itemStats.AddText(
                        stats, itemStats.RenderColor,
                        itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                        itemDescText.Font
                    );

                    itemStats.AddLineBreak();
                    itemStats.AddLineBreak();
                    if (item.ItemType == ItemTypes.Equipment && item.EquipmentSlot == Options.WeaponIndex)
                    {
                        stats = Strings.ItemDesc.damage.ToString(item.Damage);
                        itemStats.AddText(
                            stats, itemStats.RenderColor,
                            itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font
                        );

                        itemStats.AddLineBreak();

                        stats = Strings.ItemDesc.manadamage.ToString(item.ManaDamage);
                        itemStats.AddText(
                            stats, itemStats.RenderColor,
                            itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                            itemDescText.Font
                        );

                        itemStats.AddLineBreak();
                    }

                    for (var i = 0; i < (int) Vitals.VitalCount; i++)
                    {
                        var bonus = item.VitalsGiven[i].ToString();
                        if (item.PercentageVitalsGiven[i] > 0)
                        {
                            if (item.VitalsGiven[i] > 0)
                            {
                                bonus += " + ";
                            }
                            else
                            {
                                bonus = "";
                            }

                            bonus += item.PercentageVitalsGiven[i] + "%";
                        }
                        if (bonus != "0")
                        {
                            // Show stat only if not 0
                            var vitals = Strings.ItemDesc.vitals[i].ToString(bonus);
                            itemStats.AddText(
                                vitals, itemStats.RenderColor,
                                itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                                itemDescText.Font
                            );

                            itemStats.AddLineBreak();
                        }
                    }
                    if (statBuffs != null)
                    {
                        for (var i = 0; i < (int)Stats.StatCount; i++)
                        {
                            var flatStat = statBuffs[i];
                            var bonus = flatStat.ToString();

                            if (item.PercentageStatsGiven[i] > 0)
                            {
                                if (flatStat > 0)
                                {
                                    bonus += " + ";
                                }
                                else
                                {
                                    bonus = "";
                                }

                                bonus += item.PercentageStatsGiven[i] + "%";
                            }
                            if (bonus != "0")
                            {
                                // Show stat only if not 0
                                stats = Strings.ItemDesc.stats[i].ToString(bonus);
                                itemStats.AddText(
                                    stats, itemStats.RenderColor,
                                    itemStatsText.CurAlignments.Count > 0
                                        ? itemStatsText.CurAlignments[0]
                                        : Alignments.Left, itemDescText.Font
                                );

                                itemStats.AddLineBreak();
                            }
                        }
                    }
                    else
                    {
                        // Display the possible stat ranges
                        for (var i = 0; i < (int)Stats.StatCount; i++)
                        {
                            var bonus = item.StatsGiven[i, 0].ToString();
                            if (item.StatsGiven[i, 0] != item.StatsGiven[i,1])
                            {
                                bonus = Strings.ItemDesc.rangestat.ToString(item.StatsGiven[i, 0], item.StatsGiven[i, 1]);
                            }
                           
                            if (item.PercentageStatsGiven[i] > 0)
                            {
                                if (bonus != "0")
                                {
                                    bonus += " + ";
                                }
                                else
                                {
                                    bonus = "";
                                }

                                bonus += item.PercentageStatsGiven[i] + "%";
                            }
                            if (bonus != "0")
                            {
                                // Show stat only if not 0
                                stats = Strings.ItemDesc.stats[i].ToString(bonus);
                                itemStats.AddText(
                                    stats, itemStats.RenderColor,
                                    itemStatsText.CurAlignments.Count > 0
                                        ? itemStatsText.CurAlignments[0]
                                        : Alignments.Left, itemDescText.Font
                                );

                                itemStats.AddLineBreak();
                            }
                        }
                    }
                }

                if (item.ItemType == ItemTypes.Equipment)
                {
                    if (effects != null)
                    {
                        // Show actual effects of the player Item
                        if (effects.Count > 0)
                        {
                            itemStats.AddLineBreak();
                            itemStats.AddText(
                                Strings.ItemDesc.bonuseffects, itemStats.RenderColor,
                                itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                                itemDescText.Font
                            );
                        }
                        foreach (var effect in effects)
                        {
                            if (effect[0] != (int)EffectType.None)
                            {
                                itemStats.AddLineBreak();
                                itemStats.AddText(
                                    Strings.ItemDesc.effect.ToString(
                                        effect[1].ToString("+#;-#;0"), Strings.ItemDesc.effects[(int)effect[0] - 1]
                                    ), itemStats.RenderColor,
                                    itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                                    itemDescText.Font
                                );
                            }

                        }
                    }
                    else if (item.Effects.Count > 0)
                    {
                        // Show theoritical effects of ItemBase and display the possible ranges
                        itemStats.AddLineBreak();
                        itemStats.AddText(
                                Strings.ItemDesc.bonuseffects, itemStats.RenderColor,
                                itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                                itemDescText.Font
                            );
                        foreach (var effect in item.Effects)
                        {
                            if (effect.Type != EffectType.None)
                            {
                                itemStats.AddLineBreak();
                                itemStats.AddText(
                                    Strings.ItemDesc.effectrange.ToString(
                                        effect.Min.ToString("+#;-#;0"), effect.Max.ToString("+#;-#;0"), Strings.ItemDesc.effects[(int)effect.Type - 1]
                                    ), itemStats.RenderColor,
                                    itemStatsText.CurAlignments.Count > 0 ? itemStatsText.CurAlignments[0] : Alignments.Left,
                                    itemDescText.Font
                                );
                                
                            }

                        }
                    }
                    
                    
                }

                //Load Again for positioning purposes.
                mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                var itemTex = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Item, item.Icon);
                if (itemTex != null)
                {
                    icon.Texture = itemTex;
                    icon.RenderColor = item.Color;
                }

                itemDesc.SizeToChildren(false, true);
                itemStats.SizeToChildren(false, true);
                itemDescText.IsHidden = true;
                itemStatsText.IsHidden = true;
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

        public void Dispose()
        {
            Interface.GameUi?.GameCanvas?.RemoveChild(mDescWindow, false);
            mDescWindow.Dispose();
        }

    }

}
