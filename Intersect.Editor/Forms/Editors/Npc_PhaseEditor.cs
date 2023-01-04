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
            }
            
            UpdateFormElements();
        }

        private void InitLocalization()
        {
            grpEditor.Text = Strings.NpcPhaseEditor.editor;

            lblName.Text = Strings.NpcPhaseEditor.name;
            lblDesc.Text = Strings.NpcPhaseEditor.desc;

            grpSpells.Text = Strings.NpcPhaseEditor.spells;
            chkReplaceSpells.Text = Strings.NpcPhaseEditor.replacespells;
            lblSpell.Text = Strings.NpcPhaseEditor.spell;
            lstSpells.Items.Clear();
            cmbSpell.Items.Clear();
            cmbSpell.Items.AddRange(SpellBase.EditorFormatNames);
            btnAddSpell.Text = Strings.NpcPhaseEditor.addspell;
            btnRemoveSpell.Text = Strings.NpcPhaseEditor.removespell;

            grpPhaseConditions.Text = Strings.NpcPhaseEditor.phaseconditions;
            btnEditConditions.Text = Strings.NpcPhaseEditor.editconditions;

            btnEditBeginEvent.Text = Strings.NpcPhaseEditor.editbeginevent;
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
    }

}
