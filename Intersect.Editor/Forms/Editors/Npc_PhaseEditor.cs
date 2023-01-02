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
        private DbList<SpellBase> mCopySpells = new DbList<SpellBase>();

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

            InitLocalization();
            txtName.Text = mMyPhase?.Name;
            txtDesc.Text = mMyPhase?.Description;
            foreach(var spell in refPhase.Spells)
            {
                mCopySpells.Add(spell);
            }
            
            
            UpdateFormElements();
        }

        private void InitLocalization()
        {
            grpEditor.Text = Strings.NpcPhaseEditor.editor;

            lblName.Text = Strings.NpcPhaseEditor.name;
            lblDesc.Text = Strings.NpcPhaseEditor.desc;

            grpSpells.Text = Strings.NpcPhaseEditor.spells;
            lblSpell.Text = Strings.NpcPhaseEditor.spell;
            lstSpells.Items.Clear();
            cmbSpell.Items.Clear();
            cmbSpell.Items.AddRange(SpellBase.EditorFormatNames);
            btnAddSpell.Text = Strings.NpcPhaseEditor.addspell;
            btnRemoveSpell.Text = Strings.NpcPhaseEditor.removespell;

            btnEditTaskLinkEvent.Text = Strings.TaskLinksEditor.editcompletionevent;
            btnSave.Text = Strings.NpcPhaseEditor.ok;
            btnCancel.Text = Strings.NpcPhaseEditor.cancel;
        }

        private void UpdateFormElements()
        {
            // Add the spells to the list
            lstSpells.Items.Clear();
            for (var i = 0; i < mCopySpells.Count; i++)
            {
                if (mCopySpells[i] != Guid.Empty)
                {
                    lstSpells.Items.Add(SpellBase.GetName(mCopySpells[i]));
                }
                else
                {
                    lstSpells.Items.Add(Strings.General.none);
                }
            }

            if (lstSpells.Items.Count > 0)
            {
                lstSpells.SelectedIndex = 0;
                cmbSpell.SelectedIndex = SpellBase.ListIndex(mCopySpells[lstSpells.SelectedIndex]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyPhase.Name = txtName.Text;
            mMyPhase.Description = txtDesc.Text;
            mMyPhase.Spells.Clear();
            foreach(var spell in mCopySpells)
            {
                mMyPhase.Spells.Add(spell);
            }
            ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            ParentForm.Close();
        }

        private void btnEditTaskLinkEvent_Click(object sender, EventArgs e)
        {
            /*if (mMyLink != null)
            {
                mMyLink.EditingEvent.Name = Strings.TaskLinksEditor.completionevent.ToString(mMyQuest.Name, mMyLink.Name);
                var editor = new FrmEvent(null)
                {
                    MyEvent = mMyLink.EditingEvent
                };

                editor.InitEditor(true, true, true);
                editor.ShowDialog();
                Globals.MainForm.BringToFront();
                BringToFront();
            }*/
        }

        private void btnAddSpell_Click(object sender, EventArgs e)
        {
            mCopySpells.Add(SpellBase.IdFromList(cmbSpell.SelectedIndex));
            var n = lstSpells.SelectedIndex;
            lstSpells.Items.Clear();
            for (var i = 0; i < mCopySpells.Count; i++)
            {
                lstSpells.Items.Add(SpellBase.GetName(mCopySpells[i]));
            }

            lstSpells.SelectedIndex = n;
        }

        private void btnRemoveSpell_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1)
            {
                var i = lstSpells.SelectedIndex;
                lstSpells.Items.RemoveAt(i);
                mCopySpells.RemoveAt(i);
            }
        }

        private void lstSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1)
            {
                cmbSpell.SelectedIndex = SpellBase.ListIndex(mCopySpells[lstSpells.SelectedIndex]);
            }
        }

        private void cmbSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedIndex > -1 && lstSpells.SelectedIndex < mCopySpells.Count)
            {
                mCopySpells[lstSpells.SelectedIndex] = SpellBase.IdFromList(cmbSpell.SelectedIndex);
            }

            var n = lstSpells.SelectedIndex;
            lstSpells.Items.Clear();
            for (var i = 0; i < mCopySpells.Count; i++)
            {
                lstSpells.Items.Add(SpellBase.GetName(mCopySpells[i]));
            }

            lstSpells.SelectedIndex = n;
        }
    }

}
