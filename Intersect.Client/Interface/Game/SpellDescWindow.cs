using System;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game
{

    public class SpellDescWindow
    {

        ImagePanel mDescWindow;
        public Button CloseButton;

        public SpellDescWindow(Guid spellId, int x, int y, bool centerHorizontally = false, string sourceSpellName = "", bool[] effectiveStatBuffs = null, bool isMapRegion = false)
        {
            var spell = SpellBase.Get(spellId);
            if (spell == null)
            {
                return;
            }

            mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "SpellDescWindowExpanded");

            var icon = new ImagePanel(mDescWindow, "SpellIcon");

            var spellName = new Label(mDescWindow, "SpellName");
            if (string.IsNullOrEmpty(sourceSpellName))
            {
                spellName.Text = spell.Name;
            }
            else
            {
                spellName.Text = sourceSpellName;
            }

            var spellType = new RichLabel(mDescWindow, "SpellType");
            var spellTypeText = new Label(mDescWindow, "SpellTypeText");
            spellTypeText.Font = spellTypeText.Parent.Skin.DefaultFont;
            var spellDesc = new RichLabel(mDescWindow, "SpellDesc");
            var spellStats = new RichLabel(mDescWindow, "SpellStats");
            var spellDescText = new Label(mDescWindow, "SpellDescText");
            spellDescText.Font = spellDescText.Parent.Skin.DefaultFont;
            var spellStatsText = new Label(mDescWindow, "SpellStatsText");
            spellStatsText.Font = spellStatsText.Parent.Skin.DefaultFont;
            spellDescText.IsHidden = true;
            spellStatsText.IsHidden = true;
            

            CloseButton = new Button(mDescWindow, "CloseButton");
            CloseButton.Clicked += CloseButton_Clicked;
            //Load this up now so we know what color to make the text when filling out the desc
            mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            if (spell.Description.Length > 0)
            {
                spellDesc.AddText(
                    Strings.SpellDesc.desc.ToString(spell.Description), spellDesc.RenderColor,
                    spellDescText.CurAlignments.Count > 0 ? spellDescText.CurAlignments[0] : Alignments.Left,
                    spellDescText.Font
                );

                spellDesc.AddLineBreak();
                spellDesc.AddLineBreak();
            }
            

            if (spell.SpellType == (int) SpellTypes.CombatSpell &&
                (spell.Combat.TargetType == SpellTargetTypes.Anchored ||
                 spell.Combat.TargetType == SpellTargetTypes.Targeted) &&
                spell.Combat.HitRadius > 0)
            {
                spellStats.AddText(
                    Strings.SpellDesc.radius.ToString(spell.Combat.HitRadius), spellStats.RenderColor,
                    spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                    spellStatsText.Font
                );

                spellStats.AddLineBreak();
                spellStats.AddLineBreak();
            }

            if (spell.CastDuration > 0)
            {
                var castDuration = (float) spell.CastDuration / 1000f;
                spellStats.AddText(
                    Strings.SpellDesc.casttime.ToString(castDuration), spellStats.RenderColor,
                    spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                    spellStatsText.Font
                );

                spellStats.AddLineBreak();
                if (spell.CooldownDuration <= 0)
                {
                    spellStats.AddLineBreak();
                }
            }

            if (spell.CooldownDuration > 0)
            {
                var cdr = 1 - Globals.Me.GetCooldownReduction() / 100;
                var cd = (float) (spell.CooldownDuration * cdr) / 1000f;
                spellStats.AddText(
                    Strings.SpellDesc.cooldowntime.ToString(cd), spellStats.RenderColor,
                    spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                    spellStatsText.Font
                );

                spellStats.AddLineBreak();
                spellStats.AddLineBreak();
            }

            var requirements = spell.VitalCost[(int) Vitals.Health] > 0 || spell.VitalCost[(int) Vitals.Mana] > 0;

            if (requirements == true)
            {
                spellStats.AddText(
                    Strings.SpellDesc.prereqs, spellStats.RenderColor,
                    spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                    spellStatsText.Font
                );

                spellStats.AddLineBreak();
                if (spell.VitalCost[(int) Vitals.Health] > 0)
                {
                    spellStats.AddText(
                        Strings.SpellDesc.vitalcosts[(int) Vitals.Health].ToString(
                            Strings.SpellDesc.damagestyles[spell.VitalCostStyle[(int)Vitals.Health]].ToString(
                                spell.VitalCost[(int)Vitals.Health], Strings.SpellDesc.hp)),
                        spellStats.RenderColor,
                        spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                        spellStatsText.Font
                    );

                    spellStats.AddLineBreak();
                }

                if (spell.VitalCost[(int) Vitals.Mana] > 0)
                {
                    spellStats.AddText(
                        Strings.SpellDesc.vitalcosts[(int)Vitals.Mana].ToString(
                            Strings.SpellDesc.damagestyles[spell.VitalCostStyle[(int)Vitals.Mana]].ToString(
                                spell.VitalCost[(int)Vitals.Mana], Strings.SpellDesc.mp)),
                        spellStats.RenderColor,
                        spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                        spellStatsText.Font
                    );

                    spellStats.AddLineBreak();
                }

                spellStats.AddLineBreak();
            }

            var stats = "";
            stats = Strings.SpellDesc.effects;
            spellStats.AddText(
                stats, spellStats.RenderColor,
                spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                spellStatsText.Font
            );
            spellStats.AddLineBreak();

            var currentSpell = spell;
            int e = spell.Combat?.NextEffectSpellId != Guid.Empty ? 1 : 0;
            byte countnext = 0;
            while (currentSpell != null && countnext < Options.Combat.MaxDisplayNextSpells)
            {
                countnext++;
                if (currentSpell.SpellType == (int)SpellTypes.CombatSpell)
                {
                    var typeText = "";
                    if (currentSpell.Combat.TargetType == SpellTargetTypes.Projectile)
                    {
                        var proj = ProjectileBase.Get(currentSpell.Combat.ProjectileId);

                        if (proj?.Range == 0)
                        {
                            typeText = Strings.SpellDesc.meleeprojectile.ToString(currentSpell.Combat.HitRadius);
                            if (proj?.Quantity > 1)
                            {
                                typeText += Strings.SpellDesc.meleeprojectilehits.ToString(proj?.Quantity ?? 1);
                            }
                        }
                        else
                        {
                            typeText = Strings.SpellDesc.targettypes[(int)currentSpell.Combat.TargetType]
                            .ToString(proj?.Range + 1 ?? 1, currentSpell.Combat.HitRadius);
                            if (proj?.Quantity > 1)
                            {
                                typeText += Strings.SpellDesc.projectileshots.ToString(proj?.Quantity ?? 1);
                            }
                        }
                    }
                    else if (currentSpell.Combat.TargetType == SpellTargetTypes.Anchored)
                    {
                        var txtZone = Strings.SpellDesc.zonenone;
                        var customArea = currentSpell.Combat.Projectile;
                        if (customArea?.Speed == 0)
                        {
                            txtZone = Strings.SpellDesc.zonecustom;
                            if (customArea.Quantity > 1)
                            {
                                txtZone += Strings.SpellDesc.anchoredhits
                                    .ToString(customArea.Quantity);
                            }
                        }
                        else if (currentSpell.Combat.HitRadius > 0)
                        {
                            if (currentSpell.Combat.SquareHitRadius)
                            {
                                txtZone = Strings.SpellDesc.zonesquare.ToString(currentSpell.Combat.HitRadius);
                            }
                            else
                            {
                                txtZone = Strings.SpellDesc.zonecircle.ToString(currentSpell.Combat.HitRadius);
                            }
                        }
                        
                        if (currentSpell.Combat.CastRange == 0)
                        {
                            typeText = Strings.SpellDesc.onsiteanchored.ToString(txtZone);
                        }
                        else if (currentSpell.Combat.CastRange == 1)
                        {
                            typeText = Strings.SpellDesc.meleeanchored.ToString(txtZone);
                        }
                        else
                        {
                            typeText = Strings.SpellDesc.targettypes[(int)SpellTargetTypes.Anchored]
                                .ToString(currentSpell.Combat.CastRange, txtZone);
                        }
                    }
                    else
                    {
                        var txtZone = Strings.SpellDesc.zonenone;
                        if (currentSpell.Combat?.HitRadius > 0)
                        {
                            if (currentSpell.Combat.SquareHitRadius)
                            {
                                txtZone = Strings.SpellDesc.zonesquare.ToString(currentSpell.Combat.HitRadius);
                            }
                            else
                            {
                                txtZone = Strings.SpellDesc.zonecircle.ToString(currentSpell.Combat.HitRadius);
                            }
                        }
                        typeText = Strings.SpellDesc.targettypes[(int)currentSpell.Combat.TargetType]
                            .ToString(currentSpell.Combat?.CastRange, txtZone);
                    }
                    if (e > 0)
                    {
                        spellType.AddText(Strings.SpellDesc.effectnumber.ToString(e) + typeText, spellType.RenderColor, Alignments.CenterH, spellTypeText.Font);
                    }
                    else
                    {
                        spellType.AddText(Strings.SpellDesc.effect + typeText, spellType.RenderColor, Alignments.CenterH, spellTypeText.Font);
                    }

                    if (currentSpell.Combat.Effect > 0)
                    {
                        var effect = Strings.SpellDesc.effectlist[(int)currentSpell.Combat.Effect];
                        if (currentSpell.Combat.EffectChance != 100)
                        {
                            effect += Strings.SpellDesc.effectchance.ToString(currentSpell.Combat.EffectChance);
                        }
                        spellStats.AddText(
                            effect, spellStats.RenderColor,
                            spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                            spellStatsText.Font
                        );

                        spellStats.AddLineBreak();
                    }
                    for (var i = 0; i < (int)Vitals.VitalCount; i++)
                    {
                        var vitalDiff = currentSpell.Combat.VitalDiff?[i] ?? 0;
                        if (vitalDiff == 0)
                        {
                            continue;
                        }

                        var vitalSymbol = vitalDiff < 0 ? Strings.SpellDesc.addsymbol : Strings.SpellDesc.removesymbol;
                        if (currentSpell.Combat.Effect == StatusTypes.Shield)
                        {
                            stats = Strings.SpellDesc.shield.ToString(Strings.SpellDesc.damagestyles[spell.Combat.VitalDiffStyle[i]].ToString(
                                        Math.Abs(vitalDiff), Strings.SpellDesc.vitalstyles[i]));
                        }
                        else
                        {
                            stats = Strings.SpellDesc.vitals[i].ToString(vitalSymbol,
                                    Strings.SpellDesc.damagestyles[spell.Combat.VitalDiffStyle[i]].ToString(
                                        Math.Abs(vitalDiff), Strings.SpellDesc.vitalstyles[i]));
                        }
                        if (currentSpell.Combat.VitalSteal?[i] > 0)
                        {
                            stats += Strings.SpellDesc.vitalsteal[i].ToString(currentSpell.Combat.VitalSteal[i]);
                        }
                        spellStats.AddText(
                            stats, spellStats.RenderColor,
                            spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                            spellStatsText.Font
                        );

                        spellStats.AddLineBreak();
                    }

                    if (currentSpell.Combat.Duration > 0 || isMapRegion)
                    {
                        if (effectiveStatBuffs != null)
                        {
                            // Show only current buffs
                            for (var i = 0; i < (int)Stats.StatCount; i++)
                            {
                                if (effectiveStatBuffs[i])
                                {
                                    var strStat = "";
                                    if (currentSpell.Combat.StatDiff[i] != 0)
                                    {
                                        strStat += currentSpell.Combat.StatDiff[i] > 0 ? Strings.SpellDesc.addsymbol : Strings.SpellDesc.removesymbol;
                                        strStat += Math.Abs(currentSpell.Combat.StatDiff[i]);
                                        if (currentSpell.Combat.PercentageStatDiff[i] != 0)
                                        {
                                            strStat += Strings.SpellDesc.statseparator;
                                        }
                                    }
                                    if (currentSpell.Combat.PercentageStatDiff[i] != 0)
                                    {
                                        strStat += currentSpell.Combat.PercentageStatDiff[i] > 0 ? Strings.SpellDesc.addsymbol : Strings.SpellDesc.removesymbol;
                                        strStat += Math.Abs(currentSpell.Combat.PercentageStatDiff[i]) + "%";
                                    }
                                    if (strStat.Length != 0)
                                    {
                                        spellStats.AddText(
                                            Strings.SpellDesc.stats[i].ToString(strStat, ""), spellStats.RenderColor,
                                            spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                                            spellStatsText.Font
                                        );
                                        spellStats.AddLineBreak();
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Show probability on the spell description
                            for (var i = 0; i < (int)Stats.StatCount; i++)
                            {
                                if (currentSpell.Combat.StatDiffChance[i] > 0)
                                {
                                    var strStat = "";
                                    if (currentSpell.Combat.StatDiff[i] != 0)
                                    {
                                        strStat += currentSpell.Combat.StatDiff[i] > 0 ? Strings.SpellDesc.addsymbol : Strings.SpellDesc.removesymbol;
                                        strStat += Math.Abs(currentSpell.Combat.StatDiff[i]);
                                        if (currentSpell.Combat.PercentageStatDiff[i] != 0)
                                        {
                                            strStat += Strings.SpellDesc.statseparator;
                                        }
                                    }
                                    if (currentSpell.Combat.PercentageStatDiff[i] != 0)
                                    {
                                        strStat += currentSpell.Combat.PercentageStatDiff[i] > 0 ? Strings.SpellDesc.addsymbol : Strings.SpellDesc.removesymbol;
                                        strStat += Math.Abs(currentSpell.Combat.PercentageStatDiff[i]) + "%";
                                    }
                                    if (strStat.Length != 0)
                                    {
                                        var strChance = currentSpell.Combat.StatDiffChance[i] == 100 ? "" :
                                            Strings.SpellDesc.statchance.ToString(currentSpell.Combat.StatDiffChance[i]);
                                        spellStats.AddText(
                                            Strings.SpellDesc.stats[i].ToString(strStat, strChance), spellStats.RenderColor,
                                            spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                                            spellStatsText.Font
                                        );
                                        spellStats.AddLineBreak();
                                    }
                                }
                            }
                        }

                        if (!isMapRegion)
                        {
                            var duration = (float)currentSpell.Combat.Duration / 1000f;
                            var strTarget = "";
                            if (effectiveStatBuffs == null)
                            {
                                // Need to display the target type when it's not an active buff
                                if (currentSpell.Combat.TargetType == SpellTargetTypes.Self)
                                {
                                    strTarget = " " + Strings.SpellDesc.onself;
                                }
                                else
                                {
                                    strTarget = " " + Strings.SpellDesc.ontarget;
                                }
                            }
                            spellStats.AddText(
                                Strings.SpellDesc.duration.ToString(duration) + strTarget, spellStats.RenderColor,
                                spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                                spellStatsText.Font
                            );
                            spellStats.AddLineBreak();
                        }
                    }
                }
                else
                {
                    spellStats.AddText(
                        Strings.SpellDesc.spelltypes[(int)currentSpell.SpellType],
                        spellStats.RenderColor,
                        spellStatsText.CurAlignments.Count > 0 ? spellStatsText.CurAlignments[0] : Alignments.Left,
                        spellStatsText.Font
                    );
                    spellStats.AddLineBreak();
                    if (e > 0)
                    {
                        spellType.AddText(Strings.SpellDesc.effectnumber.ToString(e) + Strings.SpellDesc.spelltypes[(int)currentSpell.SpellType], spellType.RenderColor, Alignments.CenterH, spellTypeText.Font);
                    }
                    else
                    {
                        spellType.AddText(Strings.SpellDesc.effect + Strings.SpellDesc.spelltypes[(int)currentSpell.SpellType], spellType.RenderColor, Alignments.CenterH, spellTypeText.Font);
                    }
                }
                spellType.AddLineBreak();
                if (effectiveStatBuffs == null && currentSpell.Combat?.NextEffectSpellId != Guid.Empty)
                {
                    // Display separator only if not an active buff and if there is a next spell
                    var nextSpell = currentSpell.Combat.NextEffectSpell;
                    spellStats.AddText(Strings.SpellDesc.effectseparator, spellStats.RenderColor, Alignments.CenterH, spellStatsText.Font);
                    var nextText = nextSpell.Name == spell.Name ? "" : nextSpell.Name;

                    if (currentSpell.Combat.NextEffectSpellChance != 100)
                    {
                        nextText += Strings.SpellDesc.effectchance.ToString(currentSpell.Combat.NextEffectSpellChance);
                    }
                    if (!string.IsNullOrEmpty(nextText))
                    {
                        spellStats.AddLineBreak();
                        spellStats.AddText(nextText, spellStats.RenderColor, Alignments.CenterH, spellStatsText.Font);
                    }
                    
                    spellStats.AddLineBreak();
                    currentSpell = nextSpell;
                }
                else
                {
                    currentSpell = null;
                }
                e++;
            } 

            spellStats.SizeToChildren(false, true);
            if (spellStats.Children.Count == 0)
            {
                mDescWindow.Name = "SpellDescWindow";
                spellStats.Name = "";
                spellStatsText.Name = "";
            }

            //Load Again for positioning purposes.
            mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            spellDescText.IsHidden = true;
            spellStatsText.IsHidden = true;
            icon.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Spell, spell.Icon);
            spellStats.SizeToChildren(false, true);
            spellType.SizeToChildren(false, true);
            spellDesc.SetPosition(spellDesc.X, spellType.Y + spellType.Height + 10);
            if (centerHorizontally)
            {
                mDescWindow.MoveTo(x - mDescWindow.Width / 2, y + mDescWindow.Padding.Top);
            }
            else
            {
                mDescWindow.MoveTo(x - mDescWindow.Width - mDescWindow.Padding.Right, y + mDescWindow.Padding.Top);
            }
        }

        private void CloseButton_Clicked(Base sender, Framework.Gwen.Control.EventArguments.ClickedEventArgs arguments)
        {
            Globals.Me.ClickedStatus = null;
            Dispose();
        }

        public void Dispose()
        {
            if (mDescWindow == null)
            {
                return;
            }

            Interface.GameUi.GameCanvas.RemoveChild(mDescWindow, false);
            mDescWindow.Dispose();
        }
    }

}
