using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Intersect.Editor.Forms.Editors.Events;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.Logging;
using Intersect.Models;

namespace Intersect.Editor.Forms.Editors
{

    public partial class NpcPhaseEditor : UserControl
    {

        public bool Cancelled;
        private NpcBase mMyNpc;
        private NpcPhase mMyPhase;
        public string mEventBackup = null;
        public string mPhaseBackup = null;
        public NpcPhaseEditor(NpcBase refNpc, NpcPhase refPhase)
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
                txtName.Text = mMyPhase.Name;
                txtDesc.Text = mMyPhase.Description;
                chkReplaceSpells.Checked = mMyPhase.ReplaceSpells;

                //Stats diff
                if (mMyPhase.BaseStatsDiff != null)
                {
                    nudStrPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)Stats.Attack];
                    nudDefPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)Stats.Defense];
                    nudMagPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)Stats.AbilityPower];
                    nudMRPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)Stats.MagicResist];
                    nudSpdPercentage.Value = (decimal)mMyPhase.BaseStatsDiff[(int)Stats.Speed];
                }
                else
                {
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
                

            }
            
            if (mMyPhase.Spells == null)
            {
                mMyPhase.Spells = new DbList<SpellBase>();
            }
            UpdateFormElements();
        }

        private void InitLocalization()
        {
            grpEditor.Text = Strings.NpcPhaseEditor.editor;

            lblName.Text = Strings.NpcPhaseEditor.name;
            lblDesc.Text = Strings.NpcPhaseEditor.desc;

            grpPhaseConditions.Text = Strings.NpcPhaseEditor.phaseconditions;
            btnEditConditions.Text = Strings.NpcPhaseEditor.editconditions;
            btnEditBeginEvent.Text = Strings.NpcPhaseEditor.editbeginevent;

            grpSpells.Text = Strings.NpcPhaseEditor.spells;
            chkReplaceSpells.Text = Strings.NpcPhaseEditor.replacespells;
            lblSpell.Text = Strings.NpcPhaseEditor.spell;
            lstSpells.Items.Clear();
            cmbSpell.Items.Clear();
            cmbSpell.Items.AddRange(SpellBase.EditorFormatNames);
            btnAddSpell.Text = Strings.NpcPhaseEditor.addspell;
            btnRemoveSpell.Text = Strings.NpcPhaseEditor.removespell;


            grpStats.Text = Strings.NpcPhaseEditor.stats;
            lblX1.Text = Strings.NpcPhaseEditor.x;
            lblX2.Text = Strings.NpcPhaseEditor.x;
            lblX3.Text = Strings.NpcPhaseEditor.x;
            lblX4.Text = Strings.NpcPhaseEditor.x;
            lblX5.Text = Strings.NpcPhaseEditor.x;

            lblStr.Text = Strings.NpcPhaseEditor.str;
            lblMag.Text = Strings.NpcPhaseEditor.mag;
            lblDef.Text = Strings.NpcPhaseEditor.def;
            lblMR.Text = Strings.NpcPhaseEditor.MR;
            lblSpd.Text = Strings.NpcPhaseEditor.spd;

            grpRegen.Text = Strings.NpcPhaseEditor.regen;
            chkChangeRegen.Text = Strings.NpcPhaseEditor.changeregen;
            lblHpRegen.Text = Strings.NpcPhaseEditor.hpregen;
            lblManaRegen.Text = Strings.NpcPhaseEditor.manaregen;


            btnSave.Text = Strings.NpcPhaseEditor.ok;
            btnCancel.Text = Strings.NpcPhaseEditor.cancel;
        }

        private void UpdateFormElements()
        {
            // Add the spells to the list
            lstSpells.Items.Clear();
            for (var i = 0; i < mMyPhase.Spells.Count; i++)
            {
                if (mMyPhase.Spells[i] != Guid.Empty)
                {
                    lstSpells.Items.Add(SpellBase.GetName(mMyPhase.Spells[i]));
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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyPhase.Name = txtName.Text;
            mMyPhase.Description = txtDesc.Text;
            mMyPhase.ReplaceSpells = chkReplaceSpells.Checked;

            mMyPhase.BaseStatsDiff = new double[(int)Stats.StatCount];
            mMyPhase.BaseStatsDiff[(int)Stats.Attack] = (double)nudStrPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)Stats.Defense] = (double)nudDefPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)Stats.AbilityPower] = (double)nudMagPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)Stats.MagicResist] = (double)nudMRPercentage.Value;
            mMyPhase.BaseStatsDiff[(int)Stats.Speed] = (double)nudSpdPercentage.Value;
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
            if (mMyPhase.Spells.Count == 0)
            {
                mMyPhase.Spells = null;
            }
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

        private void btnAddSpell_Click(object sender, EventArgs e)
        {
            mMyPhase.Spells.Add(SpellBase.IdFromList(cmbSpell.SelectedIndex));
            var n = lstSpells.SelectedIndex;
            lstSpells.Items.Clear();
            for (var i = 0; i < mMyPhase.Spells.Count; i++)
            {
                lstSpells.Items.Add(SpellBase.GetName(mMyPhase.Spells[i]));
            }

            lstSpells.SelectedIndex = n;
        }

        private void btnRemoveSpell_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1)
            {
                var i = lstSpells.SelectedIndex;
                lstSpells.Items.RemoveAt(i);
                mMyPhase.Spells.RemoveAt(i);
            }
        }

        private void lstSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1)
            {
                cmbSpell.SelectedIndex = SpellBase.ListIndex(mMyPhase.Spells[lstSpells.SelectedIndex]);
            }
        }

        private void cmbSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1 && lstSpells.SelectedIndex < mMyPhase.Spells.Count)
            {
                mMyPhase.Spells[lstSpells.SelectedIndex] = SpellBase.IdFromList(cmbSpell.SelectedIndex);
            }

            var n = lstSpells.SelectedIndex;
            lstSpells.Items.Clear();
            for (var i = 0; i < mMyPhase.Spells.Count; i++)
            {
                lstSpells.Items.Add(SpellBase.GetName(mMyPhase.Spells[i]));
            }

            lstSpells.SelectedIndex = n;
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
    }

}
