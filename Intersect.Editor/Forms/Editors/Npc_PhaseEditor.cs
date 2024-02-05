using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DarkUI.Controls;
using Intersect.Editor.Content;
using Intersect.Editor.Forms.Editors.Events;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.Logging;
using Intersect.Models;
using Intersect.Utilities;

namespace Intersect.Editor.Forms.Editors
{

    public partial class NpcPhaseEditor : UserControl
    {

        public bool Cancelled;
        private NpcBase mMyNpc;
        private NpcPhase mMyPhase;
        public string mEventBackup = null;
        public string mPhaseBackup = null;
        public NpcPhaseEditor(NpcBase refNpc, NpcPhase refPhase, bool isAddPhase = false)
        {
            if (refNpc == null)
            {
                Log.Warn($@"{nameof(refNpc)} is null.");
            }
            if (refPhase == null)
            {
                Log.Warn($@"{nameof(refPhase)} is null.");
            }
            InitializeComponent();
            mMyPhase = refPhase;
            mMyNpc = refNpc;
            mEventBackup = refPhase?.EditingEvent?.JsonData;
            mPhaseBackup = refPhase?.JsonData;
            InitLocalization();
            if (mMyPhase != null)
            {
                if (isAddPhase)
                {
                    lblIndex.Text = Strings.NpcPhaseEditor.phaseindex.ToString(mMyNpc.NpcPhases.Count + 1);
                }
                else
                {
                    lblIndex.Text = Strings.NpcPhaseEditor.phaseindex.ToString(mMyNpc?.GetPhaseIndex(mMyPhase.Id) + 1);
                }
                txtName.Text = mMyPhase.Name;
                cmbSprite.Items.Clear();
                cmbSprite.Items.Add(Strings.General.none);
                cmbSprite.Items.AddRange(
                    GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Entity)
                );
                
                if (mMyPhase.Sprite != null)
                {
                    chkChangeSprite.Checked = true;
                    cmbSprite.SelectedIndex = cmbSprite.FindString(TextUtils.NullToNone(mMyPhase.Sprite));
                    txtNpcName.Text = mMyPhase.NpcName ?? "";
                    nudRgbaR.Value = mMyPhase.Color?.R ?? 255;
                    nudRgbaG.Value = mMyPhase.Color?.G ?? 255;
                    nudRgbaB.Value = mMyPhase.Color?.B ?? 255;
                    nudRgbaA.Value = mMyPhase.Color?.A ?? 255;
                    cmbSprite.Enabled = true;
                    nudRgbaR.Enabled = true;
                    nudRgbaG.Enabled = true;
                    nudRgbaB.Enabled = true;
                    nudRgbaA.Enabled = true;
                    txtNpcName.Enabled = true;
                }
                else
                {
                    chkChangeSprite.Checked = false;
                    cmbSprite.SelectedIndex = cmbSprite.FindString(TextUtils.NullToNone(mMyNpc.Sprite));
                    txtNpcName.Text = mMyNpc.Name;
                    nudRgbaR.Value = mMyNpc.Color.R;
                    nudRgbaG.Value = mMyNpc.Color.G;
                    nudRgbaB.Value = mMyNpc.Color.B;
                    nudRgbaA.Value = mMyNpc.Color.A;
                    cmbSprite.Enabled = false;
                    nudRgbaR.Enabled = false;
                    nudRgbaG.Enabled = false;
                    nudRgbaB.Enabled = false;
                    nudRgbaA.Enabled = false;
                    txtNpcName.Enabled = false;
                }

                chkReplaceSpells.Checked = mMyPhase.ReplaceSpells;
                cmbBeginAnimation.Items.Clear();
                cmbBeginAnimation.Items.Add(Strings.General.none);
                cmbBeginAnimation.Items.AddRange(AnimationBase.Names);
                cmbBeginAnimation.SelectedIndex = AnimationBase.ListIndex(mMyPhase.BeginAnimationId ?? Guid.Empty) + 1;

                cmbBeginSpell.Items.Clear();
                cmbBeginSpell.Items.Add(Strings.General.none);
                cmbBeginSpell.Items.AddRange(SpellBase.EditorFormatNames);
                cmbBeginSpell.SelectedIndex = SpellBase.ListIndex(mMyPhase.BeginSpellId ?? Guid.Empty) + 1;


                //Stats diff
                if (mMyPhase.BaseStatsDiff != null)
                {
                    nudHealthPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.Health];
                    nudManaPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.Mana];
                    nudStrPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.Attack];
                    nudDefPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.Defense];
                    nudMagPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.AbilityPower];
                    nudMRPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.MagicResist];
                    nudSpdPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)PhaseStats.Speed];
                }
                else
                {
                    nudHealthPercentage.Value = 1;
                    nudManaPercentage.Value = 1;
                    nudStrPercentage.Value = 1;
                    nudDefPercentage.Value = 1;
                    nudMagPercentage.Value = 1;
                    nudMRPercentage.Value = 1;
                    nudSpdPercentage.Value = 1;
                }

                //Regen
                if (mMyPhase.VitalRegen == null)
                {
                    chkChangeRegen.Checked = false;
                    nudHpRegen.Enabled = false;
                    nudMpRegen.Enabled = false;
                    if (mMyNpc != null)
                    {
                        nudHpRegen.Value = mMyNpc.VitalRegen[(int)Vitals.Health];
                        nudMpRegen.Value = mMyNpc.VitalRegen[(int)Vitals.Mana];
                    } 
                }
                else
                {
                    chkChangeRegen.Checked = true;
                    nudHpRegen.Value = mMyPhase.VitalRegen[(int)Vitals.Health];
                    nudMpRegen.Value = mMyPhase.VitalRegen[(int)Vitals.Mana];
                    nudHpRegen.Enabled = true;
                    nudMpRegen.Enabled = true;
                }

                if (mMyPhase.Spells == null)
                {
                    mMyPhase.Spells = new DbList<SpellBase>();
                }
                if (mMyPhase.SpellRules == null)
                {
                    mMyPhase.SpellRules = new List<NpcSpellRule>();
                }

                //Elemental Types
                if (mMyPhase.ElementalTypes == null)
                {
                    chkChangeElementalTypes.Checked = false;
                    cmbType1.Enabled = false;
                    cmbType2.Enabled = false;
                    if (mMyNpc != null)
                    {
                        cmbType1.SelectedIndex = mMyNpc.ElementalTypes[0];
                        cmbType2.SelectedIndex = mMyNpc.ElementalTypes[1];
                    }
                }
                else
                {
                    chkChangeElementalTypes.Checked = true;
                    cmbType1.SelectedIndex = mMyPhase.ElementalTypes[0];
                    cmbType2.SelectedIndex = mMyPhase.ElementalTypes[1];
                    cmbType1.Enabled = true;
                    cmbType2.Enabled = true;
                }

                //Combat
                nudDamage.Value = mMyPhase.Damage?? mMyNpc.Damage;
                nudCritChance.Value = mMyPhase.CritChance ?? mMyNpc.CritChance;
                nudCritMultiplier.Value = (decimal)(mMyPhase.CritMultiplier ?? mMyNpc.CritMultiplier);
                nudScaling.Value = mMyPhase.Scaling ?? mMyNpc.Scaling;
                nudAttackRange.Value = mMyPhase.AttackRange ?? mMyNpc.AttackRange;
                cmbDamageType.SelectedIndex = mMyPhase.DamageType ?? mMyNpc.DamageType;
                cmbScalingStat.Items.Clear();
                for (var x = 0; x < (int)Stats.StatCount; x++)
                {
                    cmbScalingStat.Items.Add(Globals.GetStatName(x));
                }
                cmbScalingStat.SelectedIndex = mMyPhase.ScalingStat ?? mMyNpc.ScalingStat;
                cmbAttackAnimation.Items.Clear();
                cmbAttackAnimation.Items.Add(Strings.General.none);
                cmbAttackAnimation.Items.AddRange(AnimationBase.Names);
                cmbAttackAnimation.SelectedIndex = AnimationBase.ListIndex(mMyPhase.AttackAnimationId?? mMyNpc.AttackAnimationId) + 1;
                if (mMyPhase.Damage != null || mMyPhase.CritChance != null || mMyPhase.CritMultiplier != null
                    || mMyPhase.Scaling != null || mMyPhase.DamageType != null || mMyPhase.ScalingStat != null
                    || mMyPhase.AttackAnimation != null || mMyPhase.AttackRange != null)
                {
                    chkChangeCombat.Checked = true;
                    nudDamage.Enabled = true;
                    nudCritChance.Enabled = true;
                    nudCritMultiplier.Enabled = true;
                    nudScaling.Enabled = true;
                    cmbDamageType.Enabled = true;
                    cmbScalingStat.Enabled = true;
                    cmbAttackAnimation.Enabled = true;
                    nudAttackRange.Enabled = true;
                }
                else
                {
                    chkChangeCombat.Checked = false;
                    nudDamage.Enabled = false;
                    nudCritChance.Enabled = false;
                    nudCritMultiplier.Enabled = false;
                    nudScaling.Enabled = false;
                    cmbDamageType.Enabled = false;
                    cmbScalingStat.Enabled = false;
                    cmbAttackAnimation.Enabled = false;
                    nudAttackRange.Enabled = false;
                }

                //Attack speed
                cmbAttackSpeedModifier.SelectedIndex = mMyPhase.AttackSpeedModifier ?? mMyNpc.AttackSpeedModifier;
                nudAttackSpeedValue.Value = mMyPhase.AttackSpeedValue ?? mMyNpc.AttackSpeedValue;
                if (mMyPhase.AttackSpeedModifier != null || mMyPhase.AttackSpeedValue != null)
                {
                    chkChangeAttackSpeed.Checked = true;
                    cmbAttackSpeedModifier.Enabled = true;
                    nudAttackSpeedValue.Enabled = cmbAttackSpeedModifier.SelectedIndex > 0;
                }
                else
                {
                    chkChangeAttackSpeed.Checked = false;
                    cmbAttackSpeedModifier.Enabled = false;
                    nudAttackSpeedValue.Enabled = false;
                }

                //Duration
                if (mMyPhase.Duration != null)
                {
                    nudDuration.Value = (decimal)mMyPhase.Duration;
                    chkDurationEnable.Checked = true;
                }
                else
                {
                    chkDurationEnable.Checked = false;
                    nudDuration.Enabled = false;
                }
            }
            DrawNpcSprite(null, null);
            UpdateFormElements();
        }

        private void InitLocalization()
        {
            grpEditor.Text = Strings.NpcPhaseEditor.editor;

            lblName.Text = Strings.NpcPhaseEditor.name;

            grpSprite.Text = Strings.NpcPhaseEditor.sprite;
            lblNpcName.Text = Strings.NpcPhaseEditor.npcname;
            lblRed.Text = Strings.NpcPhaseEditor.red;
            lblGreen.Text = Strings.NpcPhaseEditor.green;
            lblBlue.Text = Strings.NpcPhaseEditor.blue;
            lblAlpha.Text = Strings.NpcPhaseEditor.alpha;
            chkChangeSprite.Text = Strings.NpcPhaseEditor.changesprite;

            grpPhaseBegin.Text = Strings.NpcPhaseEditor.phaseconditions;
            btnEditConditions.Text = Strings.NpcPhaseEditor.editconditions;
            btnEditBeginEvent.Text = Strings.NpcPhaseEditor.editbeginevent;
            lblBeginAnimation.Text = Strings.NpcPhaseEditor.beginanimation;
            lblBeginSpell.Text = Strings.NpcPhaseEditor.beginspell;

            grpSpells.Text = Strings.NpcPhaseEditor.spells;
            chkReplaceSpells.Text = Strings.NpcPhaseEditor.replacespells;
            lblFreq.Text = Strings.NpcPhaseEditor.spellfrequency;
            lblSpell.Text = Strings.NpcPhaseEditor.spell;
            lstSpells.Items.Clear();
            cmbSpell.Items.Clear();
            cmbSpell.Items.AddRange(SpellBase.EditorFormatNames);
            lblBeforeSpell.Text = Strings.NpcPhaseEditor.beforespell;
            lblPrioritySpell.Text = Strings.NpcPhaseEditor.priority;
            lblAfterSpell.Text = Strings.NpcPhaseEditor.afterspell;
            btnAddSpell.Text = Strings.NpcPhaseEditor.addspell;
            btnRemoveSpell.Text = Strings.NpcPhaseEditor.removespell;


            grpStats.Text = Strings.NpcPhaseEditor.stats;
            lblX1.Text = Strings.NpcPhaseEditor.x;
            lblX2.Text = Strings.NpcPhaseEditor.x;
            lblX3.Text = Strings.NpcPhaseEditor.x;
            lblX4.Text = Strings.NpcPhaseEditor.x;
            lblX5.Text = Strings.NpcPhaseEditor.x;
            lblX6.Text = Strings.NpcPhaseEditor.x;
            lblX7.Text = Strings.NpcPhaseEditor.x;

            lblHealth.Text = Strings.NpcPhaseEditor.health;
            lblMana.Text = Strings.NpcPhaseEditor.mana;
            lblStr.Text = Strings.NpcPhaseEditor.str;
            lblMag.Text = Strings.NpcPhaseEditor.mag;
            lblDef.Text = Strings.NpcPhaseEditor.def;
            lblMR.Text = Strings.NpcPhaseEditor.MR;
            lblSpd.Text = Strings.NpcPhaseEditor.spd;

            grpRegen.Text = Strings.NpcPhaseEditor.regen;
            chkChangeRegen.Text = Strings.NpcPhaseEditor.changeregen;
            lblHpRegen.Text = Strings.NpcPhaseEditor.hpregen;
            lblManaRegen.Text = Strings.NpcPhaseEditor.manaregen;

            grpTypes.Text = Strings.NpcPhaseEditor.types;
            chkChangeElementalTypes.Text = Strings.NpcPhaseEditor.changetypes;
            lblType1.Text = Strings.NpcPhaseEditor.type1;
            lblType2.Text = Strings.NpcPhaseEditor.type2;
            cmbType1.Items.Clear();
            cmbType2.Items.Clear();
            for (var i = 0; i < Strings.Combat.elementaltypes.Count; i++)
            {
                cmbType1.Items.Add(Strings.Combat.elementaltypes[i]);
                cmbType2.Items.Add(Strings.Combat.elementaltypes[i]);
            }

            //Combat
            grpCombat.Text = Strings.NpcPhaseEditor.combat;
            chkChangeCombat.Text = Strings.NpcPhaseEditor.changecombat;
            lblDamage.Text = Strings.NpcPhaseEditor.basedamage;
            lblCritChance.Text = Strings.NpcPhaseEditor.critchance;
            lblCritMultiplier.Text = Strings.NpcPhaseEditor.critmultiplier;
            lblDamageType.Text = Strings.NpcPhaseEditor.damagetype;
            cmbDamageType.Items.Clear();
            for (var i = 0; i < Strings.Combat.damagetypes.Count; i++)
            {
                cmbDamageType.Items.Add(Strings.Combat.damagetypes[i]);
            }

            lblScalingStat.Text = Strings.NpcPhaseEditor.scalingstat;
            lblScaling.Text = Strings.NpcPhaseEditor.scalingamount;
            lblAttackAnimation.Text = Strings.NpcPhaseEditor.attackanimation;
            lblAttackRange.Text = Strings.NpcPhaseEditor.attackrange;

            //AttackSpeed
            grpAttackSpeed.Text = Strings.NpcPhaseEditor.attackspeed;
            chkChangeAttackSpeed.Text = Strings.NpcPhaseEditor.changeattackspeed;
            lblAttackSpeedModifier.Text = Strings.NpcPhaseEditor.modifier;
            cmbAttackSpeedModifier.Items.Clear();
            foreach (var val in Strings.NpcPhaseEditor.attackspeedmodifiers.Values)
            {
                cmbAttackSpeedModifier.Items.Add(val.ToString());
            }
            lblAttackSpeedValue.Text = Strings.NpcPhaseEditor.value;

            //Duration
            grpDuration.Text = Strings.NpcPhaseEditor.duration;
            chkDurationEnable.Text = Strings.NpcPhaseEditor.durationenable;
            lblDurationMs.Text = Strings.NpcPhaseEditor.durationms;

            btnSave.Text = Strings.NpcPhaseEditor.ok;
            btnCancel.Text = Strings.NpcPhaseEditor.cancel;
        }

        private void UpdateFormElements()
        {
            nudSpellFrequency.Value = mMyPhase.SpellFrequency ?? mMyNpc.SpellFrequency;

            //For compatibility when the feature NpcRule is added
            var needInitRules = mMyPhase.Spells.Count > 0 && mMyPhase.SpellRules.Count == 0;

            // Add the spells to the list
            lstSpells.Items.Clear();
            for (var i = 0; i < mMyPhase.Spells.Count; i++)
            {
                if (needInitRules)
                {
                    mMyPhase.SpellRules.Add(new NpcSpellRule());
                }
                if (mMyPhase.Spells[i] != Guid.Empty)
                {
                    lstSpells.Items.Add(Strings.NpcEditor.spellandrule.ToString(
                            mMyPhase.SpellRules[i].MinBeforeTimer, SpellBase.GetName(mMyPhase.Spells[i]),
                            mMyPhase.SpellRules[i].MinAfterTimer, mMyPhase.SpellRules[i].Priority));
                }
                else
                {
                    lstSpells.Items.Add(Strings.General.none);
                }
            }

            if (lstSpells.Items.Count > 0)
            {
                lstSpells.SelectedIndex = 0;
                cmbSpell.SelectedIndex = SpellBase.ListIndex(mMyPhase.Spells[lstSpells.SelectedIndex]);
                var spellRule = mMyPhase.SpellRules[lstSpells.SelectedIndex];
                nudBeforeSpell.Value = spellRule.MinBeforeTimer;
                nudSpellPriority.Value = spellRule.Priority;
                nudAfterSpell.Value = spellRule.MinAfterTimer;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyPhase.Name = txtName.Text;
            if (chkChangeSprite.Checked)
            {
                mMyPhase.Color = new Color();
                mMyPhase.Sprite =  (cmbSprite.SelectedIndex == 0 ? "" : cmbSprite.Text);
                mMyPhase.NpcName = txtNpcName.Text;
                mMyPhase.Color.R = (byte)nudRgbaR.Value;
                mMyPhase.Color.G = (byte)nudRgbaG.Value;
                mMyPhase.Color.B = (byte)nudRgbaB.Value;
                mMyPhase.Color.A = (byte)nudRgbaA.Value;
            }
            else
            {
                mMyPhase.Sprite = null;
                mMyPhase.Color = null;
                mMyPhase.NpcName = null;
            }
            
            mMyPhase.BeginAnimation = (cmbBeginAnimation.SelectedIndex == 0 ? null :
                AnimationBase.Get(AnimationBase.IdFromList(cmbBeginAnimation.SelectedIndex - 1)));
            mMyPhase.BeginSpell = (cmbBeginSpell.SelectedIndex == 0 ? null :
               SpellBase.Get(SpellBase.IdFromList(cmbBeginSpell.SelectedIndex - 1)));

            mMyPhase.BaseStatsDiff = new double[(int)PhaseStats.PhaseStatCount];
            mMyPhase.BaseStatsDiff[(int)PhaseStats.Health] = (double)nudHealthPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)PhaseStats.Mana] = (double)nudManaPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)PhaseStats.Attack] = (double)nudStrPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)PhaseStats.Defense] = (double)nudDefPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)PhaseStats.AbilityPower] = (double)nudMagPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)PhaseStats.MagicResist] = (double)nudMRPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)PhaseStats.Speed] = (double)nudSpdPercentage.Value;
            bool allOne = true;
            for (var i =0; i< mMyPhase.BaseStatsDiff.Length; i++)
            {
                if (mMyPhase.BaseStatsDiff[i] != 1.00)
                {
                    allOne = false;
                }
            }
            if (allOne)
            {
                // We dont't store the multipliers if all are equals to one
                mMyPhase.BaseStatsDiff = null;
            }
            if (chkChangeRegen.Checked)
            {
                mMyPhase.VitalRegen = new int[(int)Vitals.VitalCount];
                mMyPhase.VitalRegen[(int)Vitals.Health] = (int)nudHpRegen.Value;
                mMyPhase.VitalRegen[(int)Vitals.Mana] = (int)nudMpRegen.Value;
            }
            else
            {
                mMyPhase.VitalRegen = null;
            }

            if (chkChangeElementalTypes.Checked)
            {
                mMyPhase.ElementalTypes = new int[NpcBase.MAX_ELEMENTAL_TYPES];
                mMyPhase.ElementalTypes[0] = cmbType1.SelectedIndex;
                mMyPhase.ElementalTypes[1] = cmbType2.SelectedIndex;
            }
            else
            {
                mMyPhase.ElementalTypes = null;
            }

            mMyPhase.SpellFrequency = (mMyNpc.SpellFrequency == nudSpellFrequency.Value ? null : (int?)nudSpellFrequency.Value);
            mMyPhase.ReplaceSpells = chkReplaceSpells.Checked;
            if (mMyPhase.Spells.Count == 0)
            {
                mMyPhase.Spells = null;
                mMyPhase.SpellRules = null;
            }
            mMyPhase.Damage = (mMyNpc.Damage == nudDamage.Value ? null : (int?)nudDamage.Value);
            mMyPhase.CritChance = (mMyNpc.CritChance == nudCritChance.Value ? null : (int?)nudCritChance.Value);
            mMyPhase.CritMultiplier = (mMyNpc.CritMultiplier == (double)nudCritMultiplier.Value ? null : (double?)nudCritMultiplier.Value);
            mMyPhase.Scaling = (mMyNpc.Scaling == nudScaling.Value ? null : (int?)nudScaling.Value);
            mMyPhase.DamageType = (mMyNpc.DamageType == cmbDamageType.SelectedIndex ? null : (int?)cmbDamageType.SelectedIndex);
            mMyPhase.ScalingStat = (mMyNpc.ScalingStat == cmbScalingStat.SelectedIndex ? null : (int?)cmbScalingStat.SelectedIndex);
            mMyPhase.AttackAnimation = (mMyNpc.AttackAnimationId == AnimationBase.IdFromList(cmbAttackAnimation.SelectedIndex - 1) ?
                                        null : AnimationBase.Get(AnimationBase.IdFromList(cmbAttackAnimation.SelectedIndex - 1)));
            mMyPhase.AttackRange = (mMyNpc.AttackRange == nudAttackRange.Value ? null : (byte?)nudAttackRange.Value);
            mMyPhase.AttackSpeedModifier = (mMyNpc.AttackSpeedModifier == cmbAttackSpeedModifier.SelectedIndex ? null : (int?)cmbAttackSpeedModifier.SelectedIndex);
            mMyPhase.AttackSpeedValue = (mMyNpc.AttackSpeedValue == nudAttackSpeedValue.Value ? null : (int?)nudAttackSpeedValue.Value);

            mMyPhase.Duration = (chkDurationEnable.Checked ? (int?)nudDuration.Value : null);
            mMyPhase.EditingEvent.Name = Strings.NpcPhaseEditor.beginevent.ToString(mMyNpc.Name, mMyPhase.Name);
            ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            mMyPhase.Load(mPhaseBackup);
            mMyPhase.EditingEvent.Load(mEventBackup);
            ParentForm.Close();
        }

        private void btnEditBeginEvent_Click(object sender, EventArgs e)
        {
            mMyPhase.EditingEvent.Name = Strings.NpcPhaseEditor.beginevent.ToString(mMyNpc.Name, txtName.Text);
            var editor = new FrmEvent(null)
            {
                MyEvent = mMyPhase.EditingEvent
            };

            editor.InitEditor(true, true, true);
            editor.ShowDialog();
            Globals.MainForm.BringToFront();
            BringToFront();
        }

        private void btnEditConditions_Click(object sender, EventArgs e)
        {
            var editForm = new FrmDynamicRequirements(mMyPhase.ConditionLists, RequirementType.NpcPhase);
            editForm.ShowDialog();
        }
        private void lstSpells_Refresh()
        {
            var n = lstSpells.SelectedIndex;
            lstSpells.Items.Clear();
            for (var i = 0; i < mMyPhase.Spells.Count; i++)
            {
                lstSpells.Items.Add(Strings.NpcEditor.spellandrule.ToString(mMyPhase.SpellRules[i].MinBeforeTimer,
                    SpellBase.GetName(mMyPhase.Spells[i]), mMyPhase.SpellRules[i].MinAfterTimer, mMyPhase.SpellRules[i].Priority));
            }
            lstSpells.SelectedIndex = n;
        }

        private void btnAddSpell_Click(object sender, EventArgs e)
        {
            mMyPhase.Spells.Add(SpellBase.IdFromList(cmbSpell.SelectedIndex));
            var spellRule = new NpcSpellRule();
            spellRule.MinBeforeTimer = (int)nudBeforeSpell.Value;
            spellRule.Priority = (int)nudSpellPriority.Value;
            spellRule.MinAfterTimer = (int)nudAfterSpell.Value;
            mMyPhase.SpellRules.Add(spellRule);
            lstSpells_Refresh();
        }

        private void btnRemoveSpell_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1)
            {
                var i = lstSpells.SelectedIndex;
                lstSpells.Items.RemoveAt(i);
                mMyPhase.Spells.RemoveAt(i);
                mMyPhase.SpellRules.RemoveAt(i);
            }
        }

        private void lstSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1)
            {
                cmbSpell.SelectedIndex = SpellBase.ListIndex(mMyPhase.Spells[lstSpells.SelectedIndex]);
                nudBeforeSpell.Value = mMyPhase.SpellRules[lstSpells.SelectedIndex].MinBeforeTimer;
                nudSpellPriority.Value = mMyPhase.SpellRules[lstSpells.SelectedIndex].Priority;
                nudAfterSpell.Value = mMyPhase.SpellRules[lstSpells.SelectedIndex].MinAfterTimer;
            }
        }

        private void cmbSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1 && lstSpells.SelectedIndex < mMyPhase.Spells.Count)
            {
                mMyPhase.Spells[lstSpells.SelectedIndex] = SpellBase.IdFromList(cmbSpell.SelectedIndex);
            }
            lstSpells_Refresh();
        }

        private void nudBeforeSpell_ValueChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1 && lstSpells.SelectedIndex < mMyPhase.Spells.Count)
            {
                mMyPhase.SpellRules[lstSpells.SelectedIndex].MinBeforeTimer = (int)nudBeforeSpell.Value;
            }
            lstSpells_Refresh();
        }

        private void nudSpellPriority_ValueChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1 && lstSpells.SelectedIndex < mMyPhase.Spells.Count)
            {
                mMyPhase.SpellRules[lstSpells.SelectedIndex].Priority = (int)nudSpellPriority.Value;
            }
            lstSpells_Refresh();
        }

        private void nudAfterSpell_ValueChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1 && lstSpells.SelectedIndex < mMyPhase.Spells.Count)
            {
                mMyPhase.SpellRules[lstSpells.SelectedIndex].MinAfterTimer = (int)nudAfterSpell.Value;
            }
            lstSpells_Refresh();
        }

        private void chkChangeRegen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeRegen.Checked)
            {
                nudHpRegen.Enabled = true;
                nudMpRegen.Enabled = true;
            }
            else
            {
                nudHpRegen.Enabled = false;
                nudMpRegen.Enabled = false;
                if (mMyNpc != null)
                {
                    nudHpRegen.Value = mMyNpc.VitalRegen[(int)Vitals.Health];
                    nudMpRegen.Value = mMyNpc.VitalRegen[(int)Vitals.Mana];
                }
            }
        }

        private void chkChangeElementalTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeElementalTypes.Checked)
            {
                cmbType1.Enabled = true;
                cmbType2.Enabled = true;
            }
            else
            {
                cmbType1.Enabled = false;
                cmbType2.Enabled = false;
                if (mMyNpc != null)
                {
                    cmbType1.SelectedIndex = mMyNpc.ElementalTypes[0];
                    cmbType2.SelectedIndex = mMyNpc.ElementalTypes[1];
                }
            }
        }

        private void chkChangeAttackSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeAttackSpeed.Checked)
            {
                nudAttackSpeedValue.Enabled = cmbAttackSpeedModifier.SelectedIndex > 0;
                cmbAttackSpeedModifier.Enabled = true;
            }
            else
            {
                nudAttackSpeedValue.Enabled = false;
                cmbAttackSpeedModifier.Enabled = false;
                if (mMyNpc != null)
                {
                    nudAttackSpeedValue.Value = mMyNpc.AttackSpeedValue;
                    cmbAttackSpeedModifier.SelectedIndex = mMyNpc.AttackSpeedModifier;
                }
            }
        }

        private void chkChangeCombat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeCombat.Checked)
            {
                nudDamage.Enabled = true;
                nudCritChance.Enabled = true;
                nudCritMultiplier.Enabled = true;
                nudScaling.Enabled = true;
                cmbDamageType.Enabled = true;
                cmbScalingStat.Enabled = true;
                cmbAttackAnimation.Enabled = true;
                nudAttackRange.Enabled = true;
            }
            else
            {
                nudDamage.Enabled = false;
                nudCritChance.Enabled = false;
                nudCritMultiplier.Enabled = false;
                nudScaling.Enabled = false;
                cmbDamageType.Enabled = false;
                cmbScalingStat.Enabled = false;
                cmbAttackAnimation.Enabled = false;
                nudAttackRange.Enabled = false;
                if (mMyNpc != null)
                {
                    nudDamage.Value = mMyNpc.Damage;
                    nudCritChance.Value = mMyNpc.CritChance;
                    nudCritMultiplier.Value = (decimal)mMyNpc.CritMultiplier;
                    nudScaling.Value = mMyNpc.Scaling;
                    cmbDamageType.SelectedIndex = mMyNpc.DamageType;
                    cmbScalingStat.SelectedIndex = mMyNpc.ScalingStat;
                    cmbAttackAnimation.SelectedIndex = AnimationBase.ListIndex(mMyNpc.AttackAnimationId) + 1;
                    nudAttackRange.Value = mMyNpc.AttackRange;
                }
            }
        }

        private void comboBoxes_EnableChanged(object sender, EventArgs e)
        {
            DarkComboBox comboBox = (DarkComboBox)sender;
            if (comboBox.Enabled)
            {
                comboBox.ForeColor = System.Drawing.Color.Gainsboro;
            }
            else
            {
                comboBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void chkChangeSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeSprite.Checked)
            {
                nudRgbaR.Enabled = true;
                nudRgbaG.Enabled = true;
                nudRgbaB.Enabled = true;
                nudRgbaA.Enabled = true;
                cmbSprite.Enabled = true;
                txtNpcName.Enabled = true;
            }
            else
            {
                nudRgbaR.Enabled = false;
                nudRgbaG.Enabled = false;
                nudRgbaB.Enabled = false;
                nudRgbaA.Enabled = false;
                cmbSprite.Enabled = false;
                txtNpcName.Enabled = false;
                if (mMyNpc != null)
                {
                    cmbSprite.SelectedIndex = cmbSprite.FindString(TextUtils.NullToNone(mMyNpc.Sprite));
                    nudRgbaR.Value = mMyNpc.Color.R;
                    nudRgbaG.Value = mMyNpc.Color.G;
                    nudRgbaB.Value = mMyNpc.Color.B;
                    nudRgbaA.Value = mMyNpc.Color.A;
                    txtNpcName.Text = mMyNpc.Name;
                }
            }
        }

        private void cmbAttackSpeedModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudAttackSpeedValue.Enabled = cmbAttackSpeedModifier.SelectedIndex > 0;
        }

        private void chkDurationEnable_CheckedChanged(object sender, EventArgs e)
        {
            nudDuration.Enabled = chkDurationEnable.Checked;
        }

        private void DrawNpcSprite(object sender, EventArgs e)
        {
            var picSpriteBmp = new Bitmap(picNpc.Width, picNpc.Height);
            var gfx = Graphics.FromImage(picSpriteBmp);
            gfx.FillRectangle(Brushes.Black, new Rectangle(0, 0, picNpc.Width, picNpc.Height));
            if (cmbSprite.SelectedIndex > 0)
            {
                var img = Image.FromFile(GameContentManager.GraphResFolder + "/entities/" + cmbSprite.Text);
                var imgAttributes = new ImageAttributes();

                // Microsoft, what the heck is this crap?
                imgAttributes.SetColorMatrix(
                    new ColorMatrix(
                        new float[][]
                        {
                            new float[] { (float)nudRgbaR.Value / 255,  0,  0,  0, 0},  // Modify the red space
                            new float[] {0, (float)nudRgbaG.Value / 255,  0,  0, 0},    // Modify the green space
                            new float[] {0,  0, (float)nudRgbaB.Value / 255,  0, 0},    // Modify the blue space
                            new float[] {0,  0,  0, (float)nudRgbaA.Value / 255, 0},    // Modify the alpha space
                            new float[] {0, 0, 0, 0, 1}                                 // We're not adding any non-linear changes. Value of 1 at the end is a dummy value!
                        }
                    )
                );

                gfx.DrawImage(
                    img, new Rectangle(0, 0, img.Width / Options.Instance.Sprites.NormalFrames, img.Height / Options.Instance.Sprites.Directions),
                    0, 0, img.Width / Options.Instance.Sprites.NormalFrames, img.Height / Options.Instance.Sprites.Directions, GraphicsUnit.Pixel, imgAttributes
                );

                img.Dispose();
                imgAttributes.Dispose();
            }

            gfx.Dispose();

            picNpc.BackgroundImage = picSpriteBmp;
        }
    }

}
