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

            txtTitle.Text = mMyCommand.Title;
            rdoTargetPlayer.Checked = mMyCommand.TargetType == EventTargetType.Player;
            rdoTargetParty.Checked = mMyCommand.TargetType == EventTargetType.Party;
            rdoTargetGuild.Checked = mMyCommand.TargetType == EventTargetType.Guild;
            rdoTargetAllPlayers.Checked = mMyCommand.TargetType == EventTargetType.AllPlayers;

            rdoVariableKillNpcsBonus.Checked = mMyCommand.UseVariableExpBoostNpc;
            rdoGlobalVariableKillNpcsBonus.Checked = mMyCommand.VariableTypeExpBoostNpc == VariableTypes.ServerVariable;
            SetupAmountInputKill();

            rdoVariableKillNpcsBonusDuration.Checked = mMyCommand.UseVariableExpBoostNpcDuration;
            rdoGlobalVariableKillNpcsBonusDuration.Checked = mMyCommand.VariableTypeExpBoostNpcDuration == VariableTypes.ServerVariable;
            SetupAmountInputKillDuration();

            rdoVariableQuestBonus.Checked = mMyCommand.UseVariableExpBoostQuestEvent;
            rdoGlobalVariableQuestBonus.Checked = mMyCommand.VariableTypeExpBoostQuestEvent == VariableTypes.ServerVariable;
            SetupAmountInputQuest();

            rdoVariableQuestBonusDuration.Checked = mMyCommand.UseVariableExpBoostQuestEventDuration;
            rdoGlobalVariableQuestBonusDuration.Checked = mMyCommand.VariableTypeExpBoostQuestEventDuration == VariableTypes.ServerVariable;
            SetupAmountInputQuestDuration();
        }

        private void InitLocalization()
        {
            grpSetExpBoost.Text = Strings.EventSetExpBoost.title;

            grpTarget.Text = Strings.EventSetExpBoost.infos;
            lblBoostTitle.Text = Strings.EventSetExpBoost.boosttitle;
            lblTarget.Text = Strings.EventSetExpBoost.target;
            rdoTargetPlayer.Text = Strings.EventSetExpBoost.player;
            rdoTargetParty.Text = Strings.EventSetExpBoost.party;
            rdoTargetGuild.Text = Strings.EventSetExpBoost.guild;
            rdoTargetAllPlayers.Text = Strings.EventSetExpBoost.allplayers;

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


            lblQuestBonus.Text = Strings.EventSetExpBoost.labelquestbonus;
            lblVariableQuestBonus.Text = Strings.EventSetExpBoost.Variable;

            grpQuestBonusAmountType.Text = Strings.EventSetExpBoost.AmountType;
            rdoManualQuestBonus.Text = Strings.EventSetExpBoost.Manual;
            rdoVariableQuestBonus.Text = Strings.EventSetExpBoost.Variable;

            grpManualQuestBonusAmount.Text = Strings.EventSetExpBoost.manualquest;
            grpVariableQuestBonusAmount.Text = Strings.EventSetExpBoost.variablequest;

            rdoPlayerVariableQuestBonus.Text = Strings.EventSetExpBoost.PlayerVariable;
            rdoGlobalVariableQuestBonus.Text = Strings.EventSetExpBoost.ServerVariable;


            lblQuestBonusDuration.Text = Strings.EventSetExpBoost.labelquestbonusduration;
            lblVariableQuestBonusDuration.Text = Strings.EventSetExpBoost.Variable;

            grpQuestBonusDurationAmountType.Text = Strings.EventSetExpBoost.AmountType;
            rdoManualQuestBonusDuration.Text = Strings.EventSetExpBoost.Manual;
            rdoVariableQuestBonusDuration.Text = Strings.EventSetExpBoost.Variable;

            grpManualQuestBonusDuration.Text = Strings.EventSetExpBoost.manualquestduration;
            grpVariableQuestBonusDuration.Text = Strings.EventSetExpBoost.variablequestduration;

            rdoPlayerVariableQuestBonusDuration.Text = Strings.EventSetExpBoost.PlayerVariable;
            rdoGlobalVariableQuestBonusDuration.Text = Strings.EventSetExpBoost.ServerVariable;


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

            mMyCommand.ExpBoostQuestEvent = (int)nudQuestBonus.Value;
            mMyCommand.VariableTypeExpBoostQuestEvent = rdoPlayerVariableQuestBonus.Checked ? VariableTypes.PlayerVariable : VariableTypes.ServerVariable;
            mMyCommand.UseVariableExpBoostQuestEvent = !rdoManualQuestBonus.Checked;
            mMyCommand.VariableIdExpBoostQuestEvent = rdoPlayerVariableQuestBonus.Checked ? PlayerVariableBase.IdFromList(cmbVariableQuestBonus.SelectedIndex, VariableDataTypes.Integer) : ServerVariableBase.IdFromList(cmbVariableQuestBonus.SelectedIndex, VariableDataTypes.Integer);

            mMyCommand.ExpBoostQuestEventDuration = (int)nudQuestBonusDuration.Value;
            mMyCommand.VariableTypeExpBoostQuestEventDuration = rdoPlayerVariableQuestBonusDuration.Checked ? VariableTypes.PlayerVariable : VariableTypes.ServerVariable;
            mMyCommand.UseVariableExpBoostQuestEventDuration = !rdoManualQuestBonusDuration.Checked;
            mMyCommand.VariableIdExpBoostQuestEventDuration = rdoPlayerVariableQuestBonusDuration.Checked ? PlayerVariableBase.IdFromList(cmbVariableQuestBonusDuration.SelectedIndex, VariableDataTypes.Integer) : ServerVariableBase.IdFromList(cmbVariableQuestBonusDuration.SelectedIndex, VariableDataTypes.Integer);

            mMyCommand.Title = txtTitle.Text;
            if (rdoTargetPlayer.Checked)
            {
                mMyCommand.TargetType = EventTargetType.Player;
            }
            else if (rdoTargetParty.Checked)
            {
                mMyCommand.TargetType = EventTargetType.Party;
            }
            else if (rdoTargetGuild.Checked)
            {
                mMyCommand.TargetType = EventTargetType.Guild;
            }
            else if (rdoTargetAllPlayers.Checked)
            {
                mMyCommand.TargetType = EventTargetType.AllPlayers;
            }
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void VariableBlankKill()
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
        }

        private void VariableBlankKillDuration()
        {
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

        private void VariableBlankQuest()
        {
            if (cmbVariableQuestBonus.Items.Count > 0)
            {
                cmbVariableQuestBonus.SelectedIndex = 0;
            }
            else
            {
                cmbVariableQuestBonus.SelectedIndex = -1;
                cmbVariableQuestBonus.Text = "";
            }
        }

        private void VariableBlankQuestDuration()
        {
            if (cmbVariableQuestBonusDuration.Items.Count > 0)
            {
                cmbVariableQuestBonusDuration.SelectedIndex = 0;
            }
            else
            {
                cmbVariableQuestBonusDuration.SelectedIndex = -1;
                cmbVariableQuestBonusDuration.Text = "";
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
                        VariableBlankKill();
                    }
                }
                else
                {
                    VariableBlankKill();
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
                        VariableBlankKill();
                    }
                }
                else
                {
                    VariableBlankKill();
                }
            }

            nudKillNpcsBonus.Value = mMyCommand.ExpBoostNpc;
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
                        VariableBlankKillDuration();
                    }
                }
                else
                {
                    VariableBlankKillDuration();
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
                        VariableBlankKillDuration();
                    }
                }
                else
                {
                    VariableBlankKillDuration();
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

        private void SetupAmountInputQuest()
        {
            grpManualQuestBonusAmount.Visible = rdoManualQuestBonus.Checked;
            grpVariableQuestBonusAmount.Visible = !rdoManualQuestBonus.Checked;

            cmbVariableQuestBonus.Items.Clear();
            if (rdoPlayerVariableQuestBonus.Checked)
            {
                cmbVariableQuestBonus.Items.AddRange(PlayerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostQuestEvent == VariableTypes.PlayerVariable)
                {
                    var index = PlayerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostQuestEvent, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableQuestBonus.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlankQuest();
                    }
                }
                else
                {
                    VariableBlankQuest();
                }
            }
            else
            {
                cmbVariableQuestBonus.Items.AddRange(ServerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostQuestEvent == VariableTypes.ServerVariable)
                {
                    var index = ServerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostQuestEvent, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableQuestBonus.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlankQuest();
                    }
                }
                else
                {
                    VariableBlankQuest();
                }
            }

            nudQuestBonus.Value = mMyCommand.ExpBoostQuestEvent;
        }
        private void rdoManualQuest_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuest();
        }

        private void rdoVariableQuest_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuest();
        }

        private void rdoPlayerVariableQuest_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuest();
        }

        private void rdoGlobalVariableQuest_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuest();
        }

        private void SetupAmountInputQuestDuration()
        {
            grpManualQuestBonusDuration.Visible = rdoManualQuestBonusDuration.Checked;
            grpVariableQuestBonusDuration.Visible = !rdoManualQuestBonusDuration.Checked;

            cmbVariableQuestBonusDuration.Items.Clear();
            if (rdoPlayerVariableQuestBonusDuration.Checked)
            {
                cmbVariableQuestBonusDuration.Items.AddRange(PlayerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostQuestEventDuration == VariableTypes.PlayerVariable)
                {
                    var index = PlayerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostQuestEventDuration, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableQuestBonusDuration.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlankQuestDuration();
                    }
                }
                else
                {
                    VariableBlankQuestDuration();
                }
            }
            else
            {
                cmbVariableQuestBonusDuration.Items.AddRange(ServerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableTypeExpBoostQuestEventDuration == VariableTypes.ServerVariable)
                {
                    var index = ServerVariableBase.ListIndex(mMyCommand.VariableIdExpBoostQuestEventDuration, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbVariableQuestBonusDuration.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlankQuestDuration();
                    }
                }
                else
                {
                    VariableBlankQuestDuration();
                }
            }

            nudQuestBonusDuration.Value = mMyCommand.ExpBoostQuestEventDuration;
        }

        private void rdoManualQuestDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuestDuration();
        }

        private void rdoVariableQuestDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuestDuration();
        }

        private void rdoPlayerVariableQuestDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuestDuration();
        }

        private void rdoGlobalVariableQuestDuration_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInputQuestDuration();
        }
    }
}
