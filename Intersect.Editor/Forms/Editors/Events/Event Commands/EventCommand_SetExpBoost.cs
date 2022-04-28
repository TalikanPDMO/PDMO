using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandSetExpBoost : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private SetExpBoostCommand mMyCommand;

        public EventCommandSetExpBoost(SetExpBoostCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            InitLocalization();

            rdoVariableKillNpcsBonus.Checked = mMyCommand.UseVariableExpBoostNpc;
            rdoGlobalVariableKillNpcsBonus.Checked = mMyCommand.VariableTypeExpBoostNpc == VariableTypes.ServerVariable;
            SetupAmountInputKill();

            rdoGlobalVariableKillNpcsBonusDuration.Checked = mMyCommand.UseVariableExpBoostNpcDuration;
            rdoGlobalVariableKillNpcsBonusDuration.Checked = mMyCommand.VariableTypeExpBoostNpcDuration == VariableTypes.ServerVariable;
            SetupAmountInputKillDuration();
        }

        private void InitLocalization()
        {
            grpSetExpBoost.Text = Strings.EventSetExpBoost.title;

            lblKillNpcsBonus.Text = Strings.EventSetExpBoost.labelkillnpcsbonus;
            lblVariableKillNpcsBonus.Text = Strings.EventSetExpBoost.Variable;

            grpKillNpcsBonusAmountType.Text = Strings.EventSetExpBoost.AmountType;
            rdoManualKillNpcsBonus.Text = Strings.EventSetExpBoost.Manual;
            rdoVariableKillNpcsBonus.Text = Strings.EventSetExpBoost.Variable;

            grpManualKillNpcsBonusAmount.Text = Strings.EventSetExpBoost.manualkillnpcs;
            grpVariableKillNpcsBonusAmount.Text = Strings.EventSetExpBoost.variablekillnpcs;

            rdoPlayerVariableKillNpcsBonus.Text = Strings.EventSetExpBoost.PlayerVariable;
            rdoGlobalVariableKillNpcsBonus.Text = Strings.EventSetExpBoost.ServerVariable;


            lblKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.labelkillnpcsbonusduration;
            lblVariableKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.Variable;

            grpKillNpcsBonusDurationAmountType.Text = Strings.EventSetExpBoost.AmountType;
            rdoManualKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.Manual;
            rdoVariableKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.Variable;

            grpManualKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.manualkillnpcsduration;
            grpVariableKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.variablekillnpcsduration;

            rdoPlayerVariableKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.PlayerVariable;
            rdoGlobalVariableKillNpcsBonusDuration.Text = Strings.EventSetExpBoost.ServerVariable;

            btnSave.Text = Strings.EventSetExpBoost.okay;
            btnCancel.Text = Strings.EventSetExpBoost.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.ExpBoostNpc = (int) nudKillNpcsBonus.Value;
            mMyCommand.VariableTypeExpBoostNpc = rdoPlayerVariableKillNpcsBonus.Checked ? VariableTypes.PlayerVariable : VariableTypes.ServerVariable;
            mMyCommand.UseVariableExpBoostNpc = !rdoManualKillNpcsBonus.Checked;
            mMyCommand.VariableIdExpBoostNpc = rdoPlayerVariableKillNpcsBonus.Checked ? PlayerVariableBase.IdFromList(cmbVariableKillNpcsBonus.SelectedIndex, VariableDataTypes.Integer) : ServerVariableBase.IdFromList(cmbVariableKillNpcsBonus.SelectedIndex, VariableDataTypes.Integer);

            mMyCommand.ExpBoostNpcDuration = (int)nudKillNpcsBonusDuration.Value;
            mMyCommand.VariableTypeExpBoostNpcDuration = rdoPlayerVariableKillNpcsBonusDuration.Checked ? VariableTypes.PlayerVariable : VariableTypes.ServerVariable;
            mMyCommand.UseVariableExpBoostNpcDuration = !rdoManualKillNpcsBonusDuration.Checked;
            mMyCommand.VariableIdExpBoostNpcDuration = rdoPlayerVariableKillNpcsBonusDuration.Checked ? PlayerVariableBase.IdFromList(cmbVariableKillNpcsBonusDuration.SelectedIndex, VariableDataTypes.Integer) : ServerVariableBase.IdFromList(cmbVariableKillNpcsBonusDuration.SelectedIndex, VariableDataTypes.Integer);


            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKill();
        }

        private void rdoVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKill();
        }

        private void rdoPlayerVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKill();
        }

        private void rdoGlobalVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKill();
        }

        private void VariableBlank()
        {
            if (cmbVariableKillNpcsBonus.Items.Count > 0)
            {
                cmbVariableKillNpcsBonus.SelectedIndex = 0;
            }
            else
            {
                cmbVariableKillNpcsBonus.SelectedIndex = -1;
                cmbVariableKillNpcsBonus.Text = "";
            }

            if (cmbVariableKillNpcsBonusDuration.Items.Count > 0)
            {
                cmbVariableKillNpcsBonusDuration.SelectedIndex = 0;
            }
            else
            {
                cmbVariableKillNpcsBonusDuration.SelectedIndex = -1;
                cmbVariableKillNpcsBonusDuration.Text = "";
            }
        }

        private void SetupAmountInputKill()
        {
            grpManualKillNpcsBonusAmount.Visible = rdoManualKillNpcsBonus.Checked;
            grpVariableKillNpcsBonusAmount.Visible = !rdoManualKillNpcsBonus.Checked;

            cmbVariableKillNpcsBonus.Items.Clear();
            if (rdoPlayerVariableKillNpcsBonus.Checked)
            {
                cmbVariableKillNpcsBonus.Items.AddRange(PlayerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostNpc == VariableTypes.PlayerVariable)
                {
                    var index = PlayerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostNpc, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableKillNpcsBonus.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlank();
                    }
                }
                else
                {
                    VariableBlank();
                }
            }
            else
            {
                cmbVariableKillNpcsBonus.Items.AddRange(ServerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostNpc == VariableTypes.ServerVariable)
                {
                    var index = ServerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostNpc, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableKillNpcsBonus.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlank();
                    }
                }
                else
                {
                    VariableBlank();
                }
            }

            nudKillNpcsBonus.Value = mMyCommand.ExpBoostNpc;
        }

        private void SetupAmountInputKillDuration()
        {
            grpManualKillNpcsBonusDuration.Visible = rdoManualKillNpcsBonusDuration.Checked;
            grpVariableKillNpcsBonusDuration.Visible = !rdoManualKillNpcsBonusDuration.Checked;

            cmbVariableKillNpcsBonusDuration.Items.Clear();
            if (rdoPlayerVariableKillNpcsBonusDuration.Checked)
            {
                cmbVariableKillNpcsBonusDuration.Items.AddRange(PlayerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostNpcDuration == VariableTypes.PlayerVariable)
                {
                    var index = PlayerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostNpcDuration, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableKillNpcsBonusDuration.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlank();
                    }
                }
                else
                {
                    VariableBlank();
                }
            }
            else
            {
                cmbVariableKillNpcsBonusDuration.Items.AddRange(ServerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostNpcDuration == VariableTypes.ServerVariable)
                {
                    var index = ServerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostNpcDuration, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableKillNpcsBonusDuration.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlank();
                    }
                }
                else
                {
                    VariableBlank();
                }
            }

            nudKillNpcsBonusDuration.Value = mMyCommand.ExpBoostNpcDuration;
        }

        private void rdoManualKillDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKillDuration();
        }

        private void rdoVariableKillDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKillDuration();
        }

        private void rdoPlayerVariableKillDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKillDuration();
        }

        private void rdoGlobalVariableKillDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputKillDuration();
        }

    }
}
