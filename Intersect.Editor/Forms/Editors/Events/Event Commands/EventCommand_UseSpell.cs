using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Events.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    public partial class EventCommandUseSpell : UserControl
    {
        private readonly FrmEvent mEventEditor;
        private EventPage mCurrentPage;
        private UseSpellCommand mMyCommand;
        public EventCommandUseSpell(UseSpellCommand refCommand, EventPage refPage, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            mCurrentPage = refPage;
            InitLocalization();
            cmbSpell.Items.Clear();
            cmbSpell.Items.AddRange(SpellBase.Names);
            cmbSpell.SelectedIndex = SpellBase.ListIndex(mMyCommand.SpellId);
            cmbSource.SelectedIndex = 0;
            cmbTarget.SelectedIndex = 0;
        }

        private void InitLocalization()
        {
            grpUseSpell.Text = Strings.EventUseSpell.title;
            cmbSource.Items.Clear();
            for (var i = 0; i < Strings.EventUseSpell.sources.Count; i++)
            {
                cmbSource.Items.Add(Strings.EventUseSpell.sources[i]);
            }

            lblSource.Text = Strings.EventUseSpell.source;
            lblSpell.Text = Strings.EventUseSpell.spell;
            lblTarget.Text = Strings.EventUseSpell.target;
            btnSave.Text = Strings.EventUseSpell.okay;
            btnCancel.Text = Strings.EventUseSpell.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //mMyCommand.Add = !Convert.ToBoolean(cmbAction.SelectedIndex);
            mMyCommand.SpellId = SpellBase.IdFromList(cmbSpell.SelectedIndex);
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }
    }
}
