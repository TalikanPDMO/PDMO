using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Events.Commands;
using Intersect.GameObjects.Maps;
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
        private EventBase mEditingEvent;
        private MapBase mCurrentMap;
        private UseSpellCommand mMyCommand;
        public EventCommandUseSpell(UseSpellCommand refCommand, EventBase currentEvent, MapBase currentMap, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            mEditingEvent = currentEvent;
            mCurrentMap = currentMap;
            InitLocalization();
            cmbSpell.Items.Clear();
            cmbSpell.Items.AddRange(SpellBase.Names);
            cmbSpell.SelectedIndex = SpellBase.ListIndex(mMyCommand.SpellId);
            cmbSource.Items.Clear();
            cmbSource.Items.Add(Strings.EventUseSpell.player);
            cmbSource.SelectedIndex = 0;

            cmbTarget.Items.Clear();
            cmbTarget.Items.Add(Strings.EventUseSpell.player);
            cmbTarget.SelectedIndex = 0;

            if (mEditingEvent != null && !mEditingEvent.CommonEvent)
            {
                foreach (var evt in mCurrentMap.LocalEvents)
                {
                    cmbSource.Items.Add(
                        evt.Key == mEditingEvent.Id ? Strings.EventUseSpell.thisevent + " " : "" + evt.Value.Name
                    );
                    if (mMyCommand.SourceId == evt.Key) // When updating event
                    {
                        cmbSource.SelectedIndex = cmbSource.Items.Count - 1;
                    }

                    cmbTarget.Items.Add(
                       evt.Key == mEditingEvent.Id ? Strings.EventUseSpell.thisevent + " " : "" + evt.Value.Name
                    );
                    if (mMyCommand.TargetId == evt.Key) // When updating event
                    {
                        cmbTarget.SelectedIndex = cmbTarget.Items.Count - 1;
                    }
                }
            }
        }

        private void InitLocalization()
        {
            grpUseSpell.Text = Strings.EventUseSpell.title;
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
            if (cmbSource.SelectedIndex == 0 || cmbSource.SelectedIndex == -1)
            {
                mMyCommand.SourceId = Guid.Empty;
            }
            else
            {
                mMyCommand.SourceId = mCurrentMap.LocalEvents.Keys.ToList()[cmbSource.SelectedIndex - 1];
            }
            if (cmbTarget.SelectedIndex == 0 || cmbTarget.SelectedIndex == -1)
            {
                mMyCommand.TargetId = Guid.Empty;
            }
            else
            {
                mMyCommand.TargetId = mCurrentMap.LocalEvents.Keys.ToList()[cmbTarget.SelectedIndex - 1];
            }
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void cmbSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpellBase spell = SpellBase.FromList(cmbSpell.SelectedIndex);
            switch (spell.SpellType)
            {
                case SpellTypes.CombatSpell:
                    switch (spell.Combat.TargetType)
                    {
                        case SpellTargetTypes.AoE:
                        case SpellTargetTypes.Projectile:
                        case SpellTargetTypes.Self:
                            cmbTarget.SelectedIndex = 0;
                            cmbTarget.Items[0] = Strings.EventUseSpell.notargetrequired;
                            cmbTarget.Enabled = false;
                            break;
                        default:
                            cmbTarget.Items[0] = Strings.EventUseSpell.player;
                            cmbTarget.Enabled = true;
                            break;
                    }
                    break;
                default:
                    cmbTarget.Items[0] = Strings.EventUseSpell.player;
                    cmbTarget.Enabled = true;
                    break;
            }
        }
    }
}
