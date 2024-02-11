﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Controls;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Events.Commands;
using Intersect.Utilities;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandConditionalBranch : UserControl
    {

        private readonly FrmEvent mEventEditor;

        public bool Cancelled;

        public Condition Condition;

        private EventPage mCurrentPage;

        private ConditionalBranchCommand mEventCommand;

        public bool FromNpc = false;

        private List<Guid> mAttackIdList = new List<Guid>();

        private bool mLoading = false;

        public EventCommandConditionalBranch(
            Condition refCommand,
            EventPage refPage,
            FrmEvent editor,
            ConditionalBranchCommand command
        )
        {
            InitializeComponent();
            mLoading = true;
            if (refCommand == null)
            {
                refCommand = new VariableIsCondition();
            }

            Condition = refCommand;
            mEventEditor = editor;
            mEventCommand = command;
            mCurrentPage = refPage;
            UpdateFormElements(refCommand.Type);
            InitLocalization();
            var typeIndex = 0;
            foreach (var itm in Strings.EventConditional.conditions)
            {
                if (itm.Key == (int) Condition.Type)
                {
                    cmbConditionType.SelectedIndex = typeIndex;

                    break;
                }

                typeIndex++;
            }

            nudVariableValue.Minimum = long.MinValue;
            nudVariableValue.Maximum = long.MaxValue;
            chkNegated.Checked = refCommand.Negated;
            chkHasElse.Checked = refCommand.ElseEnabled;
            SetupFormValues((dynamic) refCommand);
            mLoading = false;
        }

        private void InitLocalization()
        {
            grpConditional.Text = Strings.EventConditional.title;
            lblType.Text = Strings.EventConditional.type;

            cmbConditionType.Items.Clear();
            foreach (var itm in Strings.EventConditional.conditions)
            {
                cmbConditionType.Items.Add(itm.Value);
            }

            chkNegated.Text = Strings.EventConditional.negated;
            chkHasElse.Text = Strings.EventConditional.HasElse;

            //Variable Is
            grpVariable.Text = Strings.EventConditional.variable;
            grpSelectVariable.Text = Strings.EventConditional.selectvariable;
            rdoPlayerVariable.Text = Strings.EventConditional.playervariable;
            rdoGlobalVariable.Text = Strings.EventConditional.globalvariable;

            //Numeric Variable
            grpNumericVariable.Text = Strings.EventConditional.numericvariable;
            lblNumericComparator.Text = Strings.EventConditional.comparator;
            rdoVarCompareStaticValue.Text = Strings.EventConditional.value;
            rdoVarComparePlayerVar.Text = Strings.EventConditional.playervariablevalue;
            rdoVarCompareGlobalVar.Text = Strings.EventConditional.globalvariablevalue;
            cmbNumericComparitor.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.comparators.Count; i++)
            {
                cmbNumericComparitor.Items.Add(Strings.EventConditional.comparators[i]);
            }

            cmbNumericComparitor.SelectedIndex = 0;

            //Boolean Variable
            grpBooleanVariable.Text = Strings.EventConditional.booleanvariable;
            cmbBooleanComparator.Items.Clear();
            cmbBooleanComparator.Items.Add(Strings.EventConditional.booleanequal);
            cmbBooleanComparator.Items.Add(Strings.EventConditional.booleannotequal);
            cmbBooleanComparator.SelectedIndex = 0;
            optBooleanTrue.Text = Strings.EventConditional.True;
            optBooleanFalse.Text = Strings.EventConditional.False;
            optBooleanGlobalVariable.Text = Strings.EventConditional.globalvariablevalue;
            optBooleanPlayerVariable.Text = Strings.EventConditional.playervariablevalue;

            //String Variable
            grpStringVariable.Text = Strings.EventConditional.stringvariable;
            cmbStringComparitor.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.stringcomparators.Count; i++)
            {
                cmbStringComparitor.Items.Add(Strings.EventConditional.stringcomparators[i]);
            }

            cmbStringComparitor.SelectedIndex = 0;
            lblStringComparator.Text = Strings.EventConditional.comparator;
            lblStringComparatorValue.Text = Strings.EventConditional.value;
            lblStringTextVariables.Text = Strings.EventConditional.stringtip;

            //Has Item + Has Free Inventory Slots
            grpInventoryConditions.Text = Strings.EventConditional.hasitem;
            lblItemQuantity.Text = Strings.EventConditional.hasatleast;
            lblItem.Text = Strings.EventConditional.item;
            lblInvVariable.Text = Strings.EventConditional.VariableLabel;
            grpAmountType.Text = Strings.EventConditional.AmountType;
            rdoManual.Text = Strings.EventConditional.Manual;
            rdoVariable.Text = Strings.EventConditional.VariableLabel;
            grpManualAmount.Text = Strings.EventConditional.Manual;
            grpVariableAmount.Text = Strings.EventConditional.VariableLabel;
            rdoInvPlayerVariable.Text = Strings.EventConditional.playervariable;
            rdoInvGlobalVariable.Text = Strings.EventConditional.globalvariable;

            //Has Item Equipped
            grpEquippedItem.Text = Strings.EventConditional.hasitemequipped;
            lblEquippedItem.Text = Strings.EventConditional.item;

            //Class is
            grpClass.Text = Strings.EventConditional.classis;
            lblClass.Text = Strings.EventConditional.Class;

            //Knows Spell
            grpSpell.Text = Strings.EventConditional.knowsspell;
            lblSpell.Text = Strings.EventConditional.spell;

            //Level or Stat is
            grpLevelStat.Text = Strings.EventConditional.levelorstat;
            lblLvlStatValue.Text = Strings.EventConditional.levelstatvalue;
            lblLevelComparator.Text = Strings.EventConditional.comparator;
            lblLevelOrStat.Text = Strings.EventConditional.levelstatitem;
            cmbLevelStat.Items.Clear();
            cmbLevelStat.Items.Add(Strings.EventConditional.level);
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                cmbLevelStat.Items.Add(Strings.Combat.stats[i]);
            }

            cmbLevelComparator.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.comparators.Count; i++)
            {
                cmbLevelComparator.Items.Add(Strings.EventConditional.comparators[i]);
            }

            chkStatIgnoreBuffs.Text = Strings.EventConditional.ignorestatbuffs;

            //Self Switch Is
            grpSelfSwitch.Text = Strings.EventConditional.selfswitchis;
            lblSelfSwitch.Text = Strings.EventConditional.selfswitch;
            lblSelfSwitchIs.Text = Strings.EventConditional.switchis;
            cmbSelfSwitch.Items.Clear();
            for (var i = 0; i < 4; i++)
            {
                cmbSelfSwitch.Items.Add(Strings.EventConditional.selfswitches[i]);
            }

            cmbSelfSwitchVal.Items.Clear();
            cmbSelfSwitchVal.Items.Add(Strings.EventConditional.False);
            cmbSelfSwitchVal.Items.Add(Strings.EventConditional.True);

            //Power Is
            grpPowerIs.Text = Strings.EventConditional.poweris;
            lblPower.Text = Strings.EventConditional.power;
            cmbPower.Items.Clear();
            cmbPower.Items.Add(Strings.EventConditional.power0);
            cmbPower.Items.Add(Strings.EventConditional.power1);

            //Time Is
            grpTime.Text = Strings.EventConditional.time;
            lblStartRange.Text = Strings.EventConditional.startrange;
            lblEndRange.Text = Strings.EventConditional.endrange;
            lblAnd.Text = Strings.EventConditional.and;

            //Can Start Quest
            grpStartQuest.Text = Strings.EventConditional.canstartquest;
            lblStartQuest.Text = Strings.EventConditional.startquest;

            //Quest In Progress
            grpQuestInProgress.Text = Strings.EventConditional.questinprogress;
            lblQuestProgress.Text = Strings.EventConditional.questprogress;
            lblQuestIs.Text = Strings.EventConditional.questis;
            cmbTaskModifier.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.questcomparators.Count; i++)
            {
                cmbTaskModifier.Items.Add(Strings.EventConditional.questcomparators[i]);
            }

            lblQuestTask.Text = Strings.EventConditional.task;

            //Quest Completed
            grpQuestCompleted.Text = Strings.EventConditional.questcompleted;
            lblQuestCompleted.Text = Strings.EventConditional.questcompletedlabel;

            //Gender is
            grpGender.Text = Strings.EventConditional.genderis;
            lblGender.Text = Strings.EventConditional.gender;
            cmbGender.Items.Clear();
            cmbGender.Items.Add(Strings.EventConditional.male);
            cmbGender.Items.Add(Strings.EventConditional.female);

            //Map Is
            grpMapIs.Text = Strings.EventConditional.mapis;
            btnSelectMap.Text = Strings.EventConditional.selectmap;

            //In Guild With At Least Rank
            grpInGuild.Text = Strings.EventConditional.inguild;
            lblRank.Text = Strings.EventConditional.rank;
            cmbRank.Items.Clear();
            foreach (var rank in Options.Instance.Guild.Ranks)
            {
                cmbRank.Items.Add(rank.Title);
            }

            // Map Zone Type
            grpMapZoneType.Text = Strings.EventConditional.MapZoneTypeIs;
            lblMapZoneType.Text = Strings.EventConditional.MapZoneTypeLabel;
            cmbMapZoneType.Items.Clear();
            for (var i = 0; i < Strings.MapProperties.zones.Count; i++)
            {
                cmbMapZoneType.Items.Add(Strings.MapProperties.zones[i]);
            }

            // Fighting NPC Phase
            grpFightingNPC.Text = Strings.EventConditional.fightingnpc;
            lblFightNpc.Text = Strings.EventConditional.fightnpc;
            chkOnlyTriggerPhase.Text = Strings.EventConditional.onlytrigger;
           
            cmbFightNpc.Items.Clear();
            chkPhaseNone.Text = Strings.EventConditional.includenone;
            lblIsOnPhase.Text = Strings.EventConditional.isonphase;
            cmbIsOnPhase.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.phasecomparators.Count; i++)
            {
                cmbIsOnPhase.Items.Add(Strings.EventConditional.phasecomparators[i]);
            }
            lblNpcPhase.Text = Strings.EventConditional.npcphase;

            // Fighting NPC Stats
            grpFightingStats.Text = Strings.EventConditional.fightingstats;
            lblNpcStats.Text = Strings.EventConditional.statsnpc;
            chkOnlyTriggerStat.Text = Strings.EventConditional.onlytrigger;
            cmbStatsNpc.Items.Clear();

            lblNpcHp.Text = Strings.EventConditional.npchp;
            cmbNpcHpComp.Items.Clear();
            cmbNpcHpComp.Items.Add(Strings.EventConditional.any);
            lblHpPerc.Text = Strings.EventConditional.percent;

            lblNpcMana.Text = Strings.EventConditional.npcmana;
            cmbNpcManaComp.Items.Clear();
            cmbNpcManaComp.Items.Add(Strings.EventConditional.any);
            lblManaPerc.Text = Strings.EventConditional.percent;

            lblNpcAttack.Text = Strings.EventConditional.npcattack;
            cmbNpcAttackComp.Items.Clear();
            cmbNpcAttackComp.Items.Add(Strings.EventConditional.any);
            lblAttackPerc.Text = Strings.EventConditional.percent;

            lblNpcMagic.Text = Strings.EventConditional.npcmagic;
            cmbNpcMagicComp.Items.Clear();
            cmbNpcMagicComp.Items.Add(Strings.EventConditional.any);
            lblMagicPerc.Text = Strings.EventConditional.percent;

            lblNpcDefense.Text = Strings.EventConditional.npcdefense;
            cmbNpcDefenseComp.Items.Clear();
            cmbNpcDefenseComp.Items.Add(Strings.EventConditional.any);
            lblDefensePerc.Text = Strings.EventConditional.percent;

            lblNpcMR.Text = Strings.EventConditional.npcmr;
            cmbNpcMRComp.Items.Clear();
            cmbNpcMRComp.Items.Add(Strings.EventConditional.any);
            lblMRPerc.Text = Strings.EventConditional.percent;

            lblNpcSpeed.Text = Strings.EventConditional.npcspeed;
            cmbNpcSpeedComp.Items.Clear();
            cmbNpcSpeedComp.Items.Add(Strings.EventConditional.any);
            lblSpeedPerc.Text = Strings.EventConditional.percent;

            for (var i = 0; i < Strings.EventConditional.comparators.Count; i++)
            {
                cmbNpcHpComp.Items.Add(Strings.EventConditional.comparators[i]);
                cmbNpcManaComp.Items.Add(Strings.EventConditional.comparators[i]);
                cmbNpcAttackComp.Items.Add(Strings.EventConditional.comparators[i]);
                cmbNpcMagicComp.Items.Add(Strings.EventConditional.comparators[i]);
                cmbNpcDefenseComp.Items.Add(Strings.EventConditional.comparators[i]);
                cmbNpcMRComp.Items.Add(Strings.EventConditional.comparators[i]);
                cmbNpcSpeedComp.Items.Add(Strings.EventConditional.comparators[i]);
            }

            // Fighting NPC AttackType
            grpFightingAttackType.Text = Strings.EventConditional.fightingattacktype;
            lblFightNpcAttackType.Text = Strings.EventConditional.attacktypenpc;
            chkOnlyTriggerAttackType.Text = Strings.EventConditional.onlytrigger;

            cmbFightAttackTypeNpc.Items.Clear();
            lblNpcAttackType.Text = Strings.EventConditional.npcattacktype;
            cmbNpcAttackType.Items.Clear();
            cmbNpcAttackType.Items.Add(Strings.EventConditional.any);
            for (var i = 0; i < Strings.EventConditional.attacktypes.Count; i++)
            {
                cmbNpcAttackType.Items.Add(Strings.EventConditional.attacktypes[i]);
            }

            lblNpcAttackTypeIs.Text = Strings.EventConditional.isattacktype;
            cmbNpcAttackTypeIs.Items.Clear();
            cmbNpcAttackTypeIs.Items.Add(Strings.EventConditional.any);
            mAttackIdList.Clear();
            mAttackIdList.Add(Guid.Empty);

            lblNpcDmgType.Text = Strings.EventConditional.dmgtype;
            cmbNpcDmgType.Items.Clear();
            cmbNpcDmgType.Items.Add(Strings.EventConditional.any);
            for (var i = 0; i < Strings.Combat.damagetypes.Count; i++)
            {
                cmbNpcDmgType.Items.Add(Strings.Combat.damagetypes[i]);
            }

            lblNpcElementalType.Text = Strings.EventConditional.elementaltype;
            cmbNpcElementalType.Items.Clear();
            cmbNpcElementalType.Items.Add(Strings.EventConditional.any);
            for (var i = 0; i < Strings.Combat.elementaltypes.Count; i++)
            {
                cmbNpcElementalType.Items.Add(Strings.Combat.elementaltypes[i]);
            }

            // In Party with role
            grpInParty.Text = Strings.EventConditional.inparty;
            lblPartyComparator.Text = Strings.EventConditional.comparator;
            lblPartySize.Text = Strings.EventConditional.partysize;

            cmbPartyComparator.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.comparators.Count; i++)
            {
                cmbPartyComparator.Items.Add(Strings.EventConditional.comparators[i]);
            }

            lblPartyRole.Text = Strings.EventConditional.partyrole;
            cmbPartyRole.Items.Clear();
            for (var i = 0; i < Strings.EventConditional.partyroles.Count; i++)
            {
                cmbPartyRole.Items.Add(Strings.EventConditional.partyroles[i]);
            }

            // Player ElementalType is
            grpElementalType.Text = Strings.EventConditional.elementaltypeis;
            lblPlayerElementalType.Text = Strings.EventConditional.elementaltype;
            cmbPlayerElementalType.Items.Clear();
            for (var i = 0; i < Strings.Combat.elementaltypes.Count; i++)
            {
                cmbPlayerElementalType.Items.Add(Strings.Combat.elementaltypes[i]);
            }
            // Save/Cancel buttons
            btnSave.Text = Strings.EventConditional.okay;
            btnCancel.Text = Strings.EventConditional.cancel;
        }

        private void ConditionTypeChanged(ConditionTypes type)
        {
            switch (type)
            {
                case ConditionTypes.VariableIs:
                    Condition = new VariableIsCondition();
                    SetupFormValues((dynamic) Condition);

                    break;
                case ConditionTypes.HasItem:
                    Condition = new HasItemCondition();
                    if (cmbItem.Items.Count > 0)
                    {
                        cmbItem.SelectedIndex = 0;
                    }

                    nudItemAmount.Value = 1;

                    break;
                case ConditionTypes.ClassIs:
                    Condition = new ClassIsCondition();
                    if (cmbClass.Items.Count > 0)
                    {
                        cmbClass.SelectedIndex = 0;
                    }

                    break;
                case ConditionTypes.KnowsSpell:
                    Condition = new KnowsSpellCondition();
                    if (cmbSpell.Items.Count > 0)
                    {
                        cmbSpell.SelectedIndex = 0;
                    }

                    break;
                case ConditionTypes.LevelOrStat:
                    Condition = new LevelOrStatCondition();
                    cmbLevelComparator.SelectedIndex = 0;
                    cmbLevelStat.SelectedIndex = 0;
                    nudLevelStatValue.Value = 0;
                    chkStatIgnoreBuffs.Checked = false;

                    break;
                case ConditionTypes.SelfSwitch:
                    Condition = new SelfSwitchCondition();
                    cmbSelfSwitch.SelectedIndex = 0;
                    cmbSelfSwitchVal.SelectedIndex = 0;

                    break;
                case ConditionTypes.AccessIs:
                    Condition = new AccessIsCondition();
                    cmbPower.SelectedIndex = 0;

                    break;
                case ConditionTypes.TimeBetween:
                    Condition = new TimeBetweenCondition();
                    cmbTime1.SelectedIndex = 0;
                    cmbTime2.SelectedIndex = 0;

                    break;
                case ConditionTypes.CanStartQuest:
                    Condition = new CanStartQuestCondition();
                    if (cmbStartQuest.Items.Count > 0)
                    {
                        cmbStartQuest.SelectedIndex = 0;
                    }

                    break;
                case ConditionTypes.QuestInProgress:
                    Condition = new QuestInProgressCondition();
                    if (cmbQuestInProgress.Items.Count > 0)
                    {
                        cmbQuestInProgress.SelectedIndex = 0;
                    }

                    cmbTaskModifier.SelectedIndex = 0;

                    break;
                case ConditionTypes.QuestCompleted:
                    Condition = new QuestCompletedCondition();
                    if (cmbCompletedQuest.Items.Count > 0)
                    {
                        cmbCompletedQuest.SelectedIndex = 0;
                    }

                    break;
                case ConditionTypes.NoNpcsOnMap:
                    Condition = new NoNpcsOnMapCondition();

                    break;
                case ConditionTypes.GenderIs:
                    Condition = new GenderIsCondition();
                    cmbGender.SelectedIndex = 0;

                    break;
                case ConditionTypes.MapIs:
                    Condition = new MapIsCondition();
                    btnSelectMap.Tag = Guid.Empty;

                    break;
                case ConditionTypes.IsItemEquipped:
                    Condition = new IsItemEquippedCondition();
                    if (cmbEquippedItem.Items.Count > 0)
                    {
                        cmbEquippedItem.SelectedIndex = 0;
                    }

                    break;
                case ConditionTypes.HasFreeInventorySlots:
                    Condition = new HasFreeInventorySlots();
                    

                    break;
                case ConditionTypes.InGuildWithRank:
                    Condition = new InGuildWithRank();
                    cmbRank.SelectedIndex = 0;

                    break;
                case ConditionTypes.MapZoneTypeIs:
                    Condition = new MapZoneTypeIs();
                    if (cmbMapZoneType.Items.Count > 0)
                    {
                        cmbMapZoneType.SelectedIndex = 0;
                    }

                    break;
                case ConditionTypes.FightingNPCPhase:
                    Condition = new FightingNPCPhase();
                    if (cmbFightNpc.Items.Count > 0)
                    {
                        cmbFightNpc.SelectedIndex = 0;
                    }

                    if (FromNpc)
                    {
                        chkOnlyTriggerPhase.Checked = false;
                        chkOnlyTriggerPhase.Enabled = false;
                        chkOnlyTriggerPhase.Show();
                    }
                    chkPhaseNone.Checked = false;
                    cmbIsOnPhase.SelectedIndex = 0;
                    break;
                case ConditionTypes.FightingNPCStats:
                    Condition = new FightingNPCStats();
                    if (cmbStatsNpc.Items.Count > 0)
                    {
                        cmbStatsNpc.SelectedIndex = 0;
                    }
                    if (FromNpc)
                    {
                        chkOnlyTriggerStat.Checked = false;
                        chkOnlyTriggerStat.Enabled = false;
                        chkOnlyTriggerStat.Show();
                    }
                    nudNpcHp.Value = 100;
                    nudNpcMana.Value = 100;
                    nudNpcAttack.Value = 100;
                    nudNpcMagic.Value = 100;
                    nudNpcDefense.Value = 100;
                    nudNpcMR.Value = 100;
                    nudNpcSpeed.Value = 100;

                    cmbNpcHpComp.SelectedIndex = 0;
                    cmbNpcManaComp.SelectedIndex = 0;
                    cmbNpcAttackComp.SelectedIndex = 0;
                    cmbNpcMagicComp.SelectedIndex = 0;
                    cmbNpcDefenseComp.SelectedIndex = 0;
                    cmbNpcMRComp.SelectedIndex = 0;
                    cmbNpcSpeedComp.SelectedIndex = 0;

                    break;
                case ConditionTypes.FightingNPCAttackType:
                    Condition = new FightingNPCAttackType();
                    if (cmbFightAttackTypeNpc.Items.Count > 0)
                    {
                        cmbFightAttackTypeNpc.SelectedIndex = 0;
                    }
                    if (FromNpc)
                    {
                        chkOnlyTriggerAttackType.Checked = false;
                        chkOnlyTriggerAttackType.Enabled = false;
                        chkOnlyTriggerAttackType.Show();
                    }
                    cmbNpcAttackType.SelectedIndex = 0;
                    cmbNpcAttackTypeIs.SelectedIndex = 0;
                    cmbNpcDmgType.SelectedIndex = 0;
                    cmbNpcElementalType.SelectedIndex = 0;
                    break;
                case ConditionTypes.InPartyWithRole:
                    Condition = new InPartyWithRole();
                    cmbPartyComparator.SelectedIndex = 0;
                    nudPartySize.Value = 0;
                    cmbPartyRole.SelectedIndex = 0;

                    break;
                case ConditionTypes.PlayerElementalType:
                    Condition = new PlayerElementalTypeIs();
                    cmbPlayerElementalType.SelectedIndex = 0;

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void UpdateFormElements(ConditionTypes type)
        {
            grpVariable.Hide();
            grpInventoryConditions.Hide();
            grpSpell.Hide();
            grpClass.Hide();
            grpLevelStat.Hide();
            grpSelfSwitch.Hide();
            grpPowerIs.Hide();
            grpTime.Hide();
            grpStartQuest.Hide();
            grpQuestInProgress.Hide();
            grpQuestCompleted.Hide();
            grpGender.Hide();
            grpMapIs.Hide();
            grpEquippedItem.Hide();
            grpInGuild.Hide();
            grpMapZoneType.Hide();
            grpFightingNPC.Hide();
            grpFightingStats.Hide();
            grpFightingAttackType.Hide();
            grpInParty.Hide();
            grpElementalType.Hide();
            switch (type)
            {
                case ConditionTypes.VariableIs:
                    grpVariable.Show();

                    cmbCompareGlobalVar.Items.Clear();
                    cmbCompareGlobalVar.Items.AddRange(ServerVariableBase.Names);
                    cmbComparePlayerVar.Items.Clear();
                    cmbComparePlayerVar.Items.AddRange(PlayerVariableBase.Names);

                    cmbBooleanGlobalVariable.Items.Clear();
                    cmbBooleanGlobalVariable.Items.AddRange(ServerVariableBase.Names);
                    cmbBooleanPlayerVariable.Items.Clear();
                    cmbBooleanPlayerVariable.Items.AddRange(PlayerVariableBase.Names);

                    break;
                case ConditionTypes.HasItem:
                    grpInventoryConditions.Show();
                    grpInventoryConditions.Text = Strings.EventConditional.hasitem;
                    lblItem.Visible = true;
                    cmbItem.Visible = true;
                    cmbItem.Items.Clear();
                    cmbItem.Items.AddRange(ItemBase.EditorFormatNames);
                    SetupAmountInput();

                    break;
                case ConditionTypes.ClassIs:
                    grpClass.Show();
                    cmbClass.Items.Clear();
                    cmbClass.Items.AddRange(ClassBase.Names);

                    break;
                case ConditionTypes.KnowsSpell:
                    grpSpell.Show();
                    cmbSpell.Items.Clear();
                    cmbSpell.Items.AddRange(SpellBase.EditorFormatNames);

                    break;
                case ConditionTypes.LevelOrStat:
                    grpLevelStat.Show();

                    break;
                case ConditionTypes.SelfSwitch:
                    grpSelfSwitch.Show();

                    break;
                case ConditionTypes.AccessIs:
                    grpPowerIs.Show();

                    break;
                case ConditionTypes.TimeBetween:
                    grpTime.Show();
                    cmbTime1.Items.Clear();
                    cmbTime2.Items.Clear();
                    var time = new DateTime(2000, 1, 1, 0, 0, 0);
                    for (var i = 0; i < 1440; i += TimeBase.GetTimeBase().RangeInterval)
                    {
                        var addRange = time.ToString("h:mm:ss tt") + " " + Strings.EventConditional.to + " ";
                        time = time.AddMinutes(TimeBase.GetTimeBase().RangeInterval);
                        addRange += time.ToString("h:mm:ss tt");
                        cmbTime1.Items.Add(addRange);
                        cmbTime2.Items.Add(addRange);
                    }

                    break;
                case ConditionTypes.CanStartQuest:
                    grpStartQuest.Show();
                    cmbStartQuest.Items.Clear();
                    cmbStartQuest.Items.AddRange(QuestBase.Names);

                    break;
                case ConditionTypes.QuestInProgress:
                    grpQuestInProgress.Show();
                    cmbQuestInProgress.Items.Clear();
                    cmbQuestInProgress.Items.AddRange(QuestBase.Names);

                    break;
                case ConditionTypes.QuestCompleted:
                    grpQuestCompleted.Show();
                    cmbCompletedQuest.Items.Clear();
                    cmbCompletedQuest.Items.AddRange(QuestBase.Names);

                    break;
                case ConditionTypes.NoNpcsOnMap:
                    break;
                case ConditionTypes.GenderIs:
                    grpGender.Show();

                    break;
                case ConditionTypes.MapIs:
                    grpMapIs.Show();

                    break;
                case ConditionTypes.IsItemEquipped:
                    grpEquippedItem.Show();
                    cmbEquippedItem.Items.Clear();
                    cmbEquippedItem.Items.AddRange(ItemBase.EditorFormatNames);

                    break;

                case ConditionTypes.HasFreeInventorySlots:
                    grpInventoryConditions.Show();
                    grpInventoryConditions.Text = Strings.EventConditional.FreeInventorySlots;
                    lblItem.Visible = false;
                    cmbItem.Visible = false;
                    cmbItem.Items.Clear();
                    SetupAmountInput();

                    break;
                case ConditionTypes.InGuildWithRank:
                    grpInGuild.Show();

                    break;
                case ConditionTypes.MapZoneTypeIs:
                    grpMapZoneType.Show();

                    break;
                case ConditionTypes.FightingNPCPhase:
                    grpFightingNPC.Show();
                    chkOnlyTriggerPhase.Hide();
                    cmbFightNpc.Items.Clear();
                    cmbFightNpc.Items.Add(Strings.EventConditional.anynpc);
                    cmbFightNpc.Items.AddRange(NpcBase.EditorFormatNames);
                    break;
                case ConditionTypes.FightingNPCStats:
                    grpFightingStats.Show();
                    chkOnlyTriggerStat.Hide();
                    cmbStatsNpc.Items.Clear();
                    cmbStatsNpc.Items.Add(Strings.EventConditional.anynpc);
                    cmbStatsNpc.Items.AddRange(NpcBase.EditorFormatNames);

                    break;
                case ConditionTypes.FightingNPCAttackType:
                    grpFightingAttackType.Show();
                    chkOnlyTriggerAttackType.Hide();
                    cmbFightAttackTypeNpc.Items.Clear();
                    cmbFightAttackTypeNpc.Items.Add(Strings.EventConditional.anynpc);
                    cmbFightAttackTypeNpc.Items.AddRange(NpcBase.EditorFormatNames);
                    break;
                case ConditionTypes.InPartyWithRole:
                    grpInParty.Show();
                    break;
                case ConditionTypes.PlayerElementalType:
                    grpElementalType.Show();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFormValues((dynamic) Condition);
            Condition.Negated = chkNegated.Checked;
            Condition.ElseEnabled = chkHasElse.Checked;

            if (mEventCommand != null)
            {
                mEventCommand.Condition = Condition;
            }

            if (mEventEditor != null)
            {
                mEventEditor.FinishCommandEdit();
            }
            else
            {
                if (ParentForm != null)
                {
                    ParentForm.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (mCurrentPage != null)
            {
                mEventEditor.CancelCommandEdit();
            }

            Cancelled = true;
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void cmbConditionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Strings.EventConditional.conditions.FirstOrDefault(x => x.Value == cmbConditionType.Text).Key;
            if (type < 4)
            {
                type = 0;
            }

            UpdateFormElements((ConditionTypes) type);
            if ((ConditionTypes) type != Condition.Type)
            {
                ConditionTypeChanged((ConditionTypes) type);
            }
        }

        private void cmbTaskModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTaskModifier.SelectedIndex == 0)
            {
                cmbQuestTask.Enabled = false;
            }
            else
            {
                cmbQuestTask.Enabled = true;
            }
        }

        private void cmbQuestInProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQuestTask.Items.Clear();
            var quest = QuestBase.Get(QuestBase.IdFromList(cmbQuestInProgress.SelectedIndex));
            if (quest != null)
            {
                foreach (var task in quest.Tasks)
                {
                    cmbQuestTask.Items.Add(task.GetTaskString(Strings.TaskEditor.descriptions));
                }

                if (cmbQuestTask.Items.Count > 0)
                {
                    cmbQuestTask.SelectedIndex = 0;
                }
            }
        }

        private void cmbIsOnPhase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIsOnPhase.SelectedIndex > (int) NpcPhasesProgressState.OnAnyPhase)
            {
                cmbNpcPhase.Enabled = true;
                lblNpcPhase.ForeColor = System.Drawing.Color.Gainsboro;
                cmbNpcPhase.ForeColor = System.Drawing.Color.Gainsboro;
            }
            else
            {
                cmbNpcPhase.Enabled = false;
                lblNpcPhase.ForeColor = System.Drawing.Color.Gray;
                cmbNpcPhase.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void cmbFightingNpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNpcPhase.Items.Clear();
            cmbNpcPhase.ResetText();
            int previousIndex = cmbIsOnPhase.SelectedIndex;
            cmbIsOnPhase.Items.Clear();
            if (cmbFightNpc.SelectedIndex == 0)
            {
                chkOnlyTriggerPhase.Checked = false;
                chkOnlyTriggerPhase.Enabled = false;
                for (var i = 0; i < (int)NpcPhasesProgressState.BeforePhase; i++)
                {
                    cmbIsOnPhase.Items.Add(Strings.EventConditional.phasecomparators[i]);
                }
                if (previousIndex < (int)NpcPhasesProgressState.BeforePhase)
                {
                    cmbIsOnPhase.SelectedIndex = previousIndex;
                }
                else
                {
                    cmbIsOnPhase.SelectedIndex = 0;
                }
                cmbNpcPhase.SelectedIndex = -1;
            }
            else
            {
                chkOnlyTriggerPhase.Enabled = true;
                for (var i = 0; i < Strings.EventConditional.phasecomparators.Count; i++)
                {
                    cmbIsOnPhase.Items.Add(Strings.EventConditional.phasecomparators[i]);
                }
                cmbIsOnPhase.SelectedIndex = previousIndex;
                var npc = NpcBase.Get(NpcBase.IdFromList(cmbFightNpc.SelectedIndex - 1));
                if (npc != null)
                {
                    foreach (var phase in npc.NpcPhases)
                    {
                        cmbNpcPhase.Items.Add(Strings.EventConditional.displayphase.ToString(npc.GetPhaseIndex(phase.Id)+1, phase.Name));
                    }

                    if (cmbNpcPhase.Items.Count > 0)
                    {
                        cmbNpcPhase.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbNpcPhase.SelectedIndex = -1;
                    }
                }
            }
        }

        private void cmbStatsNpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatsNpc.SelectedIndex == 0)
            {
                chkOnlyTriggerStat.Checked = false;
                chkOnlyTriggerStat.Enabled = false;
            }
            else
            {
                chkOnlyTriggerStat.Enabled = true;
            }
        }

        private void cmbFightAttackTypeNpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFightAttackTypeNpc.SelectedIndex == 0)
            {
                chkOnlyTriggerAttackType.Checked = false;
                chkOnlyTriggerAttackType.Enabled = false;
            }
            else
            {
                chkOnlyTriggerAttackType.Enabled = true;
            }
        }

        private void cmbNpcAttackType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNpcAttackTypeIs.Items.Clear();
            cmbNpcAttackTypeIs.Items.Add(Strings.EventConditional.any);
            mAttackIdList.Clear();
            mAttackIdList.Add(Guid.Empty);
            if (cmbNpcAttackType.SelectedIndex > 0)
            {
                switch ((AttackType)(cmbNpcAttackType.SelectedIndex - 1))
                {
                    case AttackType.Basic:
                        var basiclist = ItemBase.Lookup.Where(pair => ((ItemBase)pair.Value)?.EquipmentSlot == Options.WeaponIndex)
                            .OrderBy(p => p.Value?.Name)
                            .Select(pair => pair.Value)
                            .ToList();
                        foreach (var basic in basiclist)
                        {
                            cmbNpcAttackTypeIs.Items.Add(TextUtils.FormatEditorName(basic?.Name, ((ItemBase)basic)?.EditorName) ?? ItemBase.Deleted);
                            mAttackIdList.Add(basic.Id);
                        }

                        break;
                    case AttackType.Projectile:
                        //Retrieve all spells that are projectiles
                        var projspelllist = SpellBase.Lookup.Where(pair => ((SpellBase)pair.Value)?.Combat?.TargetType == SpellTargetTypes.Projectile)
                            .OrderBy(p => p.Value?.Name)
                            .Select(pair => pair.Value)
                            .ToList();
                        foreach (var projspell in projspelllist)
                        {
                            cmbNpcAttackTypeIs.Items.Add(TextUtils.FormatEditorName(projspell?.Name, ((SpellBase)projspell)?.EditorName) ?? SpellBase.Deleted);
                            mAttackIdList.Add(projspell.Id);
                        }
                        //Retrieve all items that are projectiles
                        var projitemlist = ItemBase.Lookup.Where(pair => ((ItemBase)pair.Value)?.ProjectileId != Guid.Empty)
                            .OrderBy(p => p.Value?.Name)
                            .Select(pair => pair.Value)
                            .ToList();
                        foreach (var projitem in projitemlist)
                        {
                            cmbNpcAttackTypeIs.Items.Add(TextUtils.FormatEditorName(projitem?.Name, ((ItemBase)projitem)?.EditorName) ?? ItemBase.Deleted);
                            mAttackIdList.Add(projitem.Id);
                        }
                        break;
                    case AttackType.Spell:
                        var spelllist = SpellBase.Lookup.Where(pair => ((SpellBase)pair.Value)?.Combat?.TargetType != SpellTargetTypes.Projectile)
                            .OrderBy(p => p.Value?.Name)
                            .Select(pair => pair.Value)
                            .ToList();
                        foreach (var spell in spelllist)
                        {
                            cmbNpcAttackTypeIs.Items.Add(TextUtils.FormatEditorName(spell?.Name, ((SpellBase)spell)?.EditorName) ?? SpellBase.Deleted);
                            mAttackIdList.Add(spell.Id);
                        }
                        break;
                }
            } 
            cmbNpcAttackTypeIs.SelectedIndex = 0;
        }

        private void cmbNpcAttackTypeIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNpcAttackTypeIs.SelectedIndex > 0)
            {
                cmbNpcDmgType.SelectedIndex = 0;
                cmbNpcDmgType.Enabled = false;
                lblNpcDmgType.ForeColor = ForeColor = System.Drawing.Color.Gray;
                cmbNpcDmgType.ForeColor = System.Drawing.Color.Gray;

                cmbNpcElementalType.SelectedIndex = 0;
                cmbNpcElementalType.Enabled = false;
                lblNpcElementalType.ForeColor = ForeColor = System.Drawing.Color.Gray;
                cmbNpcElementalType.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                cmbNpcDmgType.Enabled = true;
                lblNpcDmgType.ForeColor = ForeColor = System.Drawing.Color.Gainsboro;
                cmbNpcDmgType.ForeColor = System.Drawing.Color.Gainsboro;

                cmbNpcElementalType.Enabled = true;
                lblNpcElementalType.ForeColor = ForeColor = System.Drawing.Color.Gainsboro;
                cmbNpcElementalType.ForeColor = System.Drawing.Color.Gainsboro;
            }
        }

        private void cmbAnyPhaseStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DarkComboBox comboBox = (DarkComboBox)sender;
            DarkNumericUpDown nud = null;
            Label lbl = null;
            if (comboBox == cmbNpcHpComp)
            {
                nud = nudNpcHp;
                lbl = lblHpPerc;
            }
            else if (comboBox == cmbNpcManaComp)
            {
                nud = nudNpcMana;
                lbl = lblManaPerc;
            }
            else if (comboBox == cmbNpcAttackComp)
            {
                nud = nudNpcAttack;
                lbl = lblAttackPerc;
            }
            else if (comboBox == cmbNpcMagicComp)
            {
                nud = nudNpcMagic;
                lbl = lblMagicPerc;
            }
            else if (comboBox == cmbNpcDefenseComp)
            {
                nud = nudNpcDefense;
                lbl = lblDefensePerc;
            }
            else if (comboBox == cmbNpcMRComp)
            {
                nud = nudNpcMR;
                lbl = lblMRPerc;
            }
            else if (comboBox == cmbNpcSpeedComp)
            {
                nud = nudNpcSpeed;
                lbl = lblSpeedPerc;
            }
            if (nud != null)
            {
                if (comboBox.SelectedIndex > 0)
                {
                    nud.Enabled = true;
                    lbl.ForeColor = System.Drawing.Color.Gainsboro;
                }
                else
                {
                    nud.Enabled = false;
                    lbl.ForeColor = System.Drawing.Color.Gray;
                }
            }
        }

        private void btnSelectMap_Click(object sender, EventArgs e)
        {
            var frmWarpSelection = new FrmWarpSelection();
            frmWarpSelection.InitForm(false, null);
            frmWarpSelection.SelectTile((Guid) btnSelectMap.Tag, 0, 0);
            frmWarpSelection.TopMost = true;
            frmWarpSelection.ShowDialog();
            if (frmWarpSelection.GetResult())
            {
                btnSelectMap.Tag = frmWarpSelection.GetMap();
            }
        }

        private void rdoVarCompareStaticValue_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumericVariableElements();
        }

        private void rdoVarComparePlayerVar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumericVariableElements();
        }

        private void rdoVarCompareGlobalVar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumericVariableElements();
        }

        private void UpdateNumericVariableElements()
        {
            nudVariableValue.Enabled = rdoVarCompareStaticValue.Checked;
            cmbComparePlayerVar.Enabled = rdoVarComparePlayerVar.Checked;
            cmbCompareGlobalVar.Enabled = rdoVarCompareGlobalVar.Checked;
        }

        private void UpdateVariableElements()
        {
            //Hide editor windows until we have a variable selected to work with
            grpNumericVariable.Hide();
            grpBooleanVariable.Hide();
            grpStringVariable.Hide();

            var varType = 0;
            if (cmbVariable.SelectedIndex > -1)
            {
                //Determine Variable Type
                if (rdoPlayerVariable.Checked)
                {
                    var playerVar = PlayerVariableBase.FromList(cmbVariable.SelectedIndex);
                    if (playerVar != null)
                    {
                        varType = (byte) playerVar.Type;
                    }
                }
                else if (rdoGlobalVariable.Checked)
                {
                    var serverVar = ServerVariableBase.FromList(cmbVariable.SelectedIndex);
                    if (serverVar != null)
                    {
                        varType = (byte) serverVar.Type;
                    }
                }
            }

            //Load the correct editor
            if (varType > 0)
            {
                switch ((VariableDataTypes) varType)
                {
                    case VariableDataTypes.Boolean:
                        grpBooleanVariable.Show();
                        TryLoadVariableBooleanComparison(((VariableIsCondition) Condition).Comparison);

                        break;

                    case VariableDataTypes.Integer:
                        grpNumericVariable.Show();
                        TryLoadVariableIntegerComparison(((VariableIsCondition) Condition).Comparison);
                        UpdateNumericVariableElements();

                        break;

                    case VariableDataTypes.Number:
                        break;

                    case VariableDataTypes.String:
                        grpStringVariable.Show();
                        TryLoadVariableStringComparison(((VariableIsCondition) Condition).Comparison);

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void TryLoadVariableBooleanComparison(VariableCompaison comp)
        {
            if (comp.GetType() == typeof(BooleanVariableComparison))
            {
                var com = (BooleanVariableComparison) comp;

                cmbBooleanComparator.SelectedIndex = Convert.ToInt32(!com.ComparingEqual);

                if (cmbBooleanComparator.SelectedIndex < 0)
                {
                    cmbBooleanComparator.SelectedIndex = 0;
                }

                optBooleanTrue.Checked = com.Value;
                optBooleanFalse.Checked = !com.Value;

                if (com.CompareVariableId != Guid.Empty)
                {
                    if (com.CompareVariableType == VariableTypes.PlayerVariable)
                    {
                        optBooleanPlayerVariable.Checked = true;
                        cmbBooleanPlayerVariable.SelectedIndex = PlayerVariableBase.ListIndex(com.CompareVariableId);
                    }
                    else
                    {
                        optBooleanGlobalVariable.Checked = true;
                        cmbBooleanGlobalVariable.SelectedIndex = ServerVariableBase.ListIndex(com.CompareVariableId);
                    }
                }
            }
        }

        private void TryLoadVariableIntegerComparison(VariableCompaison comp)
        {
            if (comp.GetType() == typeof(IntegerVariableComparison))
            {
                var com = (IntegerVariableComparison) comp;

                cmbNumericComparitor.SelectedIndex = (int) com.Comparator;

                if (cmbNumericComparitor.SelectedIndex < 0)
                {
                    cmbNumericComparitor.SelectedIndex = 0;
                }

                if (com.CompareVariableId != Guid.Empty)
                {
                    if (com.CompareVariableType == VariableTypes.PlayerVariable)
                    {
                        rdoVarComparePlayerVar.Checked = true;
                        cmbComparePlayerVar.SelectedIndex = PlayerVariableBase.ListIndex(com.CompareVariableId);
                    }
                    else
                    {
                        rdoVarCompareGlobalVar.Checked = true;
                        cmbCompareGlobalVar.SelectedIndex = ServerVariableBase.ListIndex(com.CompareVariableId);
                    }
                }
                else
                {
                    rdoVarCompareStaticValue.Checked = true;
                    nudVariableValue.Value = com.Value;
                }

                UpdateNumericVariableElements();
            }
        }

        private void TryLoadVariableStringComparison(VariableCompaison comp)
        {
            if (comp.GetType() == typeof(StringVariableComparison))
            {
                var com = (StringVariableComparison) comp;

                cmbStringComparitor.SelectedIndex = Convert.ToInt32(com.Comparator);

                if (cmbStringComparitor.SelectedIndex < 0)
                {
                    cmbStringComparitor.SelectedIndex = 0;
                }

                txtStringValue.Text = com.Value;
            }
        }

        private void InitVariableElements(Guid variableId)
        {
            mLoading = true;
            cmbVariable.Items.Clear();
            if (rdoPlayerVariable.Checked)
            {
                cmbVariable.Items.AddRange(PlayerVariableBase.Names);
                cmbVariable.SelectedIndex = PlayerVariableBase.ListIndex(variableId);
            }
            else
            {
                cmbVariable.Items.AddRange(ServerVariableBase.Names);
                cmbVariable.SelectedIndex = ServerVariableBase.ListIndex(variableId);
            }

            mLoading = false;
        }

        private BooleanVariableComparison GetBooleanVariableComparison()
        {
            var comp = new BooleanVariableComparison();

            if (cmbBooleanComparator.SelectedIndex < 0)
            {
                cmbBooleanComparator.SelectedIndex = 0;
            }

            comp.ComparingEqual = !Convert.ToBoolean(cmbBooleanComparator.SelectedIndex);

            comp.Value = optBooleanTrue.Checked;

            if (optBooleanGlobalVariable.Checked)
            {
                comp.CompareVariableType = VariableTypes.ServerVariable;
                comp.CompareVariableId = ServerVariableBase.IdFromList(cmbBooleanGlobalVariable.SelectedIndex);
            }
            else if (optBooleanPlayerVariable.Checked)
            {
                comp.CompareVariableType = VariableTypes.PlayerVariable;
                comp.CompareVariableId = PlayerVariableBase.IdFromList(cmbBooleanPlayerVariable.SelectedIndex);
            }

            return comp;
        }

        private IntegerVariableComparison GetNumericVariableComparison()
        {
            var comp = new IntegerVariableComparison();

            if (cmbNumericComparitor.SelectedIndex < 0)
            {
                cmbNumericComparitor.SelectedIndex = 0;
            }

            comp.Comparator = (VariableComparators) cmbNumericComparitor.SelectedIndex;

            comp.CompareVariableId = Guid.Empty;

            if (rdoVarCompareStaticValue.Checked)
            {
                comp.Value = (long) nudVariableValue.Value;
            }
            else if (rdoVarCompareGlobalVar.Checked)
            {
                comp.CompareVariableType = VariableTypes.ServerVariable;
                comp.CompareVariableId = ServerVariableBase.IdFromList(cmbCompareGlobalVar.SelectedIndex);
            }
            else if (rdoVarComparePlayerVar.Checked)
            {
                comp.CompareVariableType = VariableTypes.PlayerVariable;
                comp.CompareVariableId = PlayerVariableBase.IdFromList(cmbComparePlayerVar.SelectedIndex);
            }

            return comp;
        }

        private StringVariableComparison GetStringVariableComparison()
        {
            var comp = new StringVariableComparison();

            if (cmbStringComparitor.SelectedIndex < 0)
            {
                cmbStringComparitor.SelectedIndex = 0;
            }

            comp.Comparator = (StringVariableComparators) cmbStringComparitor.SelectedIndex;

            comp.Value = txtStringValue.Text;

            return comp;
        }

        private void rdoPlayerVariable_CheckedChanged(object sender, EventArgs e)
        {
            InitVariableElements(Guid.Empty);
            if (!mLoading && cmbVariable.Items.Count > 0)
            {
                cmbVariable.SelectedIndex = 0;
            }
        }

        private void rdoGlobalVariable_CheckedChanged(object sender, EventArgs e)
        {
            InitVariableElements(Guid.Empty);
            if (!mLoading && cmbVariable.Items.Count > 0)
            {
                cmbVariable.SelectedIndex = 0;
            }
        }

        private void cmbVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mLoading)
            {
                return;
            }

            if (rdoPlayerVariable.Checked)
            {
                InitVariableElements(PlayerVariableBase.IdFromList(cmbVariable.SelectedIndex));
            }
            else if (rdoGlobalVariable.Checked)
            {
                InitVariableElements(ServerVariableBase.IdFromList(cmbVariable.SelectedIndex));
            }

            UpdateVariableElements();
        }

        private void lblStringTextVariables_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://www.ascensiongamedev.com/community/topic/749-event-text-variables/"
            );
        }

        private void NudItemAmount_ValueChanged(object sender, System.EventArgs e)
        {
            nudItemAmount.Value = Math.Max(1, nudItemAmount.Value);
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void rdoVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void rdoInvPlayerVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void rdoInvGlobalVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void SetupAmountInput()
        {
            grpManualAmount.Visible = rdoManual.Checked;
            grpVariableAmount.Visible = !rdoManual.Checked;

            VariableTypes conditionVariableType;
            Guid conditionVariableId;
            int ConditionQuantity;

            switch (Condition.Type)
            {
                case ConditionTypes.HasFreeInventorySlots:
                    conditionVariableType = ((HasFreeInventorySlots)Condition).VariableType;
                    conditionVariableId = ((HasFreeInventorySlots)Condition).VariableId;
                    ConditionQuantity = ((HasFreeInventorySlots)Condition).Quantity;
                    break;
                case ConditionTypes.HasItem:
                    conditionVariableType = ((HasItemCondition)Condition).VariableType;
                    conditionVariableId = ((HasItemCondition)Condition).VariableId;
                    ConditionQuantity = ((HasItemCondition)Condition).Quantity;
                    break;
                default:
                    conditionVariableType = VariableTypes.PlayerVariable;
                    conditionVariableId = Guid.Empty;
                    ConditionQuantity = 0;
                    return;
            }

            cmbInvVariable.Items.Clear();
            if (rdoInvPlayerVariable.Checked)
            {
                cmbInvVariable.Items.AddRange(PlayerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (conditionVariableType == VariableTypes.PlayerVariable)
                {
                    var index = PlayerVariableBase.ListIndex(conditionVariableId, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbInvVariable.SelectedIndex = index;
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
                cmbInvVariable.Items.AddRange(ServerVariableBase.GetNamesByType(VariableDataTypes.Integer));
                // Do not update if the wrong type of variable is saved
                if (conditionVariableType == VariableTypes.ServerVariable)
                {
                    var index = ServerVariableBase.ListIndex(conditionVariableId, VariableDataTypes.Integer);
                    if (index > -1)
                    {
                        cmbInvVariable.SelectedIndex = index;
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

            nudItemAmount.Value = Math.Max(1, ConditionQuantity);
        }

        private void VariableBlank()
        {
            if (cmbInvVariable.Items.Count > 0)
            {
                cmbInvVariable.SelectedIndex = 0;
            }
            else
            {
                cmbInvVariable.SelectedIndex = -1;
                cmbInvVariable.Text = "";
            }
        }

        #region "SetupFormValues"

        private void SetupFormValues(VariableIsCondition condition)
        {
            if (condition.VariableType == VariableTypes.PlayerVariable)
            {
                rdoPlayerVariable.Checked = true;
            }
            else
            {
                rdoGlobalVariable.Checked = true;
            }

            InitVariableElements(condition.VariableId);

            UpdateVariableElements();
        }

        private void SetupFormValues(HasItemCondition condition)
        {
            cmbItem.SelectedIndex = ItemBase.ListIndex(condition.ItemId);
            nudItemAmount.Value = condition.Quantity;
            rdoVariable.Checked = condition.UseVariable;
            rdoInvGlobalVariable.Checked = condition.VariableType == VariableTypes.ServerVariable;
            SetupAmountInput();
        }

        private void SetupFormValues(ClassIsCondition condition)
        {
            cmbClass.SelectedIndex = ClassBase.ListIndex(condition.ClassId);
        }

        private void SetupFormValues(KnowsSpellCondition condition)
        {
            cmbSpell.SelectedIndex = SpellBase.ListIndex(condition.SpellId);
        }

        private void SetupFormValues(LevelOrStatCondition condition)
        {
            cmbLevelComparator.SelectedIndex = (int) condition.Comparator;
            nudLevelStatValue.Value = condition.Value;
            cmbLevelStat.SelectedIndex = condition.ComparingLevel ? 0 : (int) condition.Stat + 1;
            chkStatIgnoreBuffs.Checked = condition.IgnoreBuffs;
        }

        private void SetupFormValues(SelfSwitchCondition condition)
        {
            cmbSelfSwitch.SelectedIndex = condition.SwitchIndex;
            cmbSelfSwitchVal.SelectedIndex = Convert.ToInt32(condition.Value);
        }

        private void SetupFormValues(AccessIsCondition condition)
        {
            cmbPower.SelectedIndex = (int) condition.Access;
        }

        private void SetupFormValues(TimeBetweenCondition condition)
        {
            cmbTime1.SelectedIndex = Math.Min(condition.Ranges[0], cmbTime1.Items.Count - 1);
            cmbTime2.SelectedIndex = Math.Min(condition.Ranges[1], cmbTime2.Items.Count - 1);
        }

        private void SetupFormValues(CanStartQuestCondition condition)
        {
            cmbStartQuest.SelectedIndex = QuestBase.ListIndex(condition.QuestId);
        }

        private void SetupFormValues(QuestInProgressCondition condition)
        {
            cmbQuestInProgress.SelectedIndex = QuestBase.ListIndex(condition.QuestId);
            cmbTaskModifier.SelectedIndex = (int) condition.Progress;
            if (cmbTaskModifier.SelectedIndex == -1)
            {
                cmbTaskModifier.SelectedIndex = 0;
            }

            if (cmbTaskModifier.SelectedIndex != 0)
            {
                //Get Quest Task Here
                var quest = QuestBase.Get(QuestBase.IdFromList(cmbQuestInProgress.SelectedIndex));
                if (quest != null)
                {
                    for (var i = 0; i < quest.Tasks.Count; i++)
                    {
                        if (quest.Tasks[i].Id == condition.TaskId)
                        {
                            cmbQuestTask.SelectedIndex = i;
                        }
                    }
                }
            }
        }

        private void SetupFormValues(NoNpcsOnMapCondition condition)
        {
            //Nothing to do but we need this here so the dynamic will work :) 
        }

        private void SetupFormValues(QuestCompletedCondition condition)
        {
            cmbCompletedQuest.SelectedIndex = QuestBase.ListIndex(condition.QuestId);
        }

        private void SetupFormValues(GenderIsCondition condition)
        {
            cmbGender.SelectedIndex = (int) condition.Gender;
        }

        private void SetupFormValues(MapIsCondition condition)
        {
            btnSelectMap.Tag = condition.MapId;
        }

        private void SetupFormValues(IsItemEquippedCondition condition)
        {
            cmbEquippedItem.SelectedIndex = ItemBase.ListIndex(condition.ItemId);
        }

        private void SetupFormValues(HasFreeInventorySlots condition)
        {
            nudItemAmount.Value = condition.Quantity;
            rdoVariable.Checked = condition.UseVariable;
            rdoInvGlobalVariable.Checked = condition.VariableType == VariableTypes.ServerVariable;
            SetupAmountInput();
        }

        private void SetupFormValues(InGuildWithRank condition)
        {
            cmbRank.SelectedIndex = Math.Max(0, Math.Min(Options.Instance.Guild.Ranks.Length - 1, condition.Rank));
        }

        private void SetupFormValues(MapZoneTypeIs condition)
        {
            if (cmbMapZoneType.Items.Count > 0)
            {
                cmbMapZoneType.SelectedIndex = (int)condition.ZoneType;
            }
        }

        private void SetupFormValues(FightingNPCPhase condition)
        {
            if (cmbFightNpc.Items.Count > 0)
            {
                if (condition.NpcId == Guid.Empty)
                {
                    cmbFightNpc.SelectedIndex = 0;
                }
                else
                {
                    cmbFightNpc.SelectedIndex = NpcBase.ListIndex(condition.NpcId) + 1;
                }
            }
            if (cmbFightNpc.SelectedIndex > 0)
            {
                chkOnlyTriggerPhase.Checked = !condition.Any;
                chkOnlyTriggerPhase.Enabled = true;
            }
            else
            {
                chkOnlyTriggerPhase.Checked = false;
                chkOnlyTriggerPhase.Enabled = false;
            }

            cmbIsOnPhase.SelectedIndex = (int)condition.Progress;
            if (cmbIsOnPhase.SelectedIndex == -1)
            {
                cmbIsOnPhase.SelectedIndex = 0;
            }

            chkPhaseNone.Checked = condition.OrNone;

            if (cmbFightNpc.SelectedIndex > 0 && cmbIsOnPhase.SelectedIndex > (int) NpcPhasesProgressState.OnAnyPhase)
            {
                var npc = NpcBase.Get(NpcBase.IdFromList(cmbFightNpc.SelectedIndex - 1));
                if (npc != null)
                {
                    for (var i = 0; i < npc.NpcPhases.Count; i++)
                    {
                        if (npc.NpcPhases[i].Id == condition.PhaseId)
                        {
                            cmbNpcPhase.SelectedIndex = i;
                        }
                    }
                }
            }
        }

        private void SetupFormValues(FightingNPCStats condition)
        {
            if (cmbStatsNpc.Items.Count > 0)
            {
                if (condition.NpcId == Guid.Empty)
                {
                    cmbStatsNpc.SelectedIndex = 0;
                }
                else
                {
                    cmbStatsNpc.SelectedIndex = NpcBase.ListIndex(condition.NpcId) + 1;
                }
            }
            if (cmbStatsNpc.SelectedIndex > 0)
            {
                chkOnlyTriggerStat.Checked = !condition.Any;
                chkOnlyTriggerStat.Enabled = true;
            }
            else
            {
                chkOnlyTriggerStat.Checked = false;
                chkOnlyTriggerStat.Enabled = false;
            }
            cmbNpcHpComp.SelectedIndex = 0;
            cmbNpcManaComp.SelectedIndex = 0;
            cmbNpcAttackComp.SelectedIndex = 0;
            cmbNpcMagicComp.SelectedIndex = 0;
            cmbNpcDefenseComp.SelectedIndex = 0;
            cmbNpcMRComp.SelectedIndex = 0;
            cmbNpcSpeedComp.SelectedIndex = 0;
            foreach (var perc in condition.Percents)
            {
                switch((PhaseStats)perc.Key)
                {
                    case PhaseStats.Health:
                        nudNpcHp.Value = perc.Value[0];
                        cmbNpcHpComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                    case PhaseStats.Mana:
                        nudNpcMana.Value = perc.Value[0];
                        cmbNpcManaComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                    case PhaseStats.Attack:
                        nudNpcAttack.Value = perc.Value[0];
                        cmbNpcAttackComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                    case PhaseStats.AbilityPower:
                        nudNpcMagic.Value = perc.Value[0];
                        cmbNpcMagicComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                    case PhaseStats.Defense:
                        nudNpcDefense.Value = perc.Value[0];
                        cmbNpcDefenseComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                    case PhaseStats.MagicResist:
                        nudNpcMR.Value = perc.Value[0];
                        cmbNpcMRComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                    case PhaseStats.Speed:
                        nudNpcSpeed.Value = perc.Value[0];
                        cmbNpcSpeedComp.SelectedIndex = perc.Value[1] + 1;
                        break;
                }
            }
        }

        private void SetupFormValues(FightingNPCAttackType condition)
        {
            if (cmbFightAttackTypeNpc.Items.Count > 0)
            {
                if (condition.NpcId == Guid.Empty)
                {
                    cmbFightAttackTypeNpc.SelectedIndex = 0;
                }
                else
                {
                    cmbFightAttackTypeNpc.SelectedIndex = NpcBase.ListIndex(condition.NpcId) + 1;
                }
            }
            if (cmbFightAttackTypeNpc.SelectedIndex > 0)
            {
                chkOnlyTriggerAttackType.Checked = !condition.Any;
                chkOnlyTriggerAttackType.Enabled = true;
            }
            else
            {
                chkOnlyTriggerAttackType.Checked = false;
                chkOnlyTriggerAttackType.Enabled = false;
            }

            cmbNpcAttackType.SelectedIndex = condition.AttackType + 1;
            if (cmbNpcAttackType.SelectedIndex == -1)
            {
                cmbNpcAttackType.SelectedIndex = 0;
            }

            cmbNpcAttackType_SelectedIndexChanged(null, null);
            if (condition.AttackId == null || condition.AttackId == Guid.Empty)
            {
                cmbNpcAttackTypeIs.SelectedIndex = 0;
            }
            else
            {
                cmbNpcAttackTypeIs.SelectedIndex = mAttackIdList.IndexOf(condition.AttackId);
            }

            cmbNpcDmgType.SelectedIndex = condition.DamageType + 1;
            if (cmbNpcDmgType.SelectedIndex == -1)
            {
                cmbNpcDmgType.SelectedIndex = 0;
            }

            cmbNpcElementalType.SelectedIndex = condition.ElementalType + 1;
            if (cmbNpcElementalType.SelectedIndex == -1)
            {
                cmbNpcElementalType.SelectedIndex = 0;
            }

        }

        private void SetupFormValues(InPartyWithRole condition)
        {
            cmbPartyComparator.SelectedIndex = (int)condition.Comparator;
            nudPartySize.Value = condition.Size;
            cmbPartyRole.SelectedIndex = condition.Role;
        }

        private void SetupFormValues(PlayerElementalTypeIs condition)
        {
            cmbPlayerElementalType.SelectedIndex = condition.ElementalType;
        }
        #endregion

        #region "SaveFormValues"

        private void SaveFormValues(VariableIsCondition condition)
        {
            if (rdoGlobalVariable.Checked)
            {
                condition.VariableType = VariableTypes.ServerVariable;
                condition.VariableId = ServerVariableBase.IdFromList(cmbVariable.SelectedIndex);
            }
            else
            {
                condition.VariableType = VariableTypes.PlayerVariable;
                condition.VariableId = PlayerVariableBase.IdFromList(cmbVariable.SelectedIndex);
            }

            if (grpBooleanVariable.Visible)
            {
                condition.Comparison = GetBooleanVariableComparison();
            }
            else if (grpNumericVariable.Visible)
            {
                condition.Comparison = GetNumericVariableComparison();
            }
            else if (grpStringVariable.Visible)
            {
                condition.Comparison = GetStringVariableComparison();
            }
            else
            {
                condition.Comparison = new VariableCompaison();
            }
        }

        private void SaveFormValues(HasItemCondition condition)
        {
            condition.ItemId = ItemBase.IdFromList(cmbItem.SelectedIndex);
            condition.Quantity = (int) nudItemAmount.Value;
            condition.VariableType = rdoInvPlayerVariable.Checked ? VariableTypes.PlayerVariable : VariableTypes.ServerVariable;
            condition.UseVariable = !rdoManual.Checked;
            condition.VariableId = rdoInvPlayerVariable.Checked ? PlayerVariableBase.IdFromList(cmbInvVariable.SelectedIndex) : ServerVariableBase.IdFromList(cmbInvVariable.SelectedIndex);
        }

        private void SaveFormValues(ClassIsCondition condition)
        {
            condition.ClassId = ClassBase.IdFromList(cmbClass.SelectedIndex);
        }

        private void SaveFormValues(KnowsSpellCondition condition)
        {
            condition.SpellId = SpellBase.IdFromList(cmbSpell.SelectedIndex);
        }

        private void SaveFormValues(LevelOrStatCondition condition)
        {
            condition.Comparator = (VariableComparators) cmbLevelComparator.SelectedIndex;
            condition.Value = (int) nudLevelStatValue.Value;
            condition.ComparingLevel = cmbLevelStat.SelectedIndex == 0;
            if (!condition.ComparingLevel)
            {
                condition.Stat = (Stats) (cmbLevelStat.SelectedIndex - 1);
            }

            condition.IgnoreBuffs = chkStatIgnoreBuffs.Checked;
        }

        private void SaveFormValues(SelfSwitchCondition condition)
        {
            condition.SwitchIndex = cmbSelfSwitch.SelectedIndex;
            condition.Value = Convert.ToBoolean(cmbSelfSwitchVal.SelectedIndex);
        }

        private void SaveFormValues(AccessIsCondition condition)
        {
            condition.Access = (Access) cmbPower.SelectedIndex;
        }

        private void SaveFormValues(TimeBetweenCondition condition)
        {
            condition.Ranges[0] = cmbTime1.SelectedIndex;
            condition.Ranges[1] = cmbTime2.SelectedIndex;
        }

        private void SaveFormValues(CanStartQuestCondition condition)
        {
            condition.QuestId = QuestBase.IdFromList(cmbStartQuest.SelectedIndex);
        }

        private void SaveFormValues(QuestInProgressCondition condition)
        {
            condition.QuestId = QuestBase.IdFromList(cmbQuestInProgress.SelectedIndex);
            condition.Progress = (QuestProgressState) cmbTaskModifier.SelectedIndex;
            condition.TaskId = Guid.Empty;
            if (cmbTaskModifier.SelectedIndex != 0)
            {
                //Get Quest Task Here
                var quest = QuestBase.Get(QuestBase.IdFromList(cmbQuestInProgress.SelectedIndex));
                if (quest != null)
                {
                    if (cmbQuestTask.SelectedIndex > -1)
                    {
                        condition.TaskId = quest.Tasks[cmbQuestTask.SelectedIndex].Id;
                    }
                }
            }
        }

        private void SaveFormValues(QuestCompletedCondition condition)
        {
            condition.QuestId = QuestBase.IdFromList(cmbCompletedQuest.SelectedIndex);
        }

        private void SaveFormValues(NoNpcsOnMapCondition condition)
        {
            //Nothing to do but we need this here so the dynamic will work :) 
        }

        private void SaveFormValues(GenderIsCondition condition)
        {
            condition.Gender = (Gender) cmbGender.SelectedIndex;
        }

        private void SaveFormValues(MapIsCondition condition)
        {
            condition.MapId = (Guid) btnSelectMap.Tag;
        }

        private void SaveFormValues(IsItemEquippedCondition condition)
        {
            condition.ItemId = ItemBase.IdFromList(cmbEquippedItem.SelectedIndex);
        }

        private void SaveFormValues(HasFreeInventorySlots condition)
        {
            condition.Quantity = (int) nudItemAmount.Value;
            condition.VariableType = rdoInvPlayerVariable.Checked ? VariableTypes.PlayerVariable : VariableTypes.ServerVariable;
            condition.UseVariable = !rdoManual.Checked;
            condition.VariableId = rdoInvPlayerVariable.Checked ? PlayerVariableBase.IdFromList(cmbInvVariable.SelectedIndex) : ServerVariableBase.IdFromList(cmbInvVariable.SelectedIndex);
        }

        private void SaveFormValues(InGuildWithRank condition)
        {
            condition.Rank = Math.Max(cmbRank.SelectedIndex, 0);
        }

        private void SaveFormValues(MapZoneTypeIs condition)
        {
            if (cmbMapZoneType.Items.Count > 0)
            {
                condition.ZoneType = (MapZones)cmbMapZoneType.SelectedIndex;
            }
        }

        private void SaveFormValues(FightingNPCPhase condition)
        {
            condition.NpcId = Guid.Empty;
            condition.Progress = (NpcPhasesProgressState)cmbIsOnPhase.SelectedIndex;
            condition.PhaseId = Guid.Empty;
            condition.OrNone = chkPhaseNone.Checked;
            if (FromNpc)
            {
                condition.Any = !chkOnlyTriggerPhase.Checked;
            }
            else
            {
                condition.Any = false;
            }
            if (cmbFightNpc.SelectedIndex > 0)
            {
                condition.NpcId = NpcBase.IdFromList(cmbFightNpc.SelectedIndex - 1);
                if (cmbIsOnPhase.SelectedIndex > (int)NpcPhasesProgressState.OnAnyPhase)
                {
                    var npc = NpcBase.Get(NpcBase.IdFromList(cmbFightNpc.SelectedIndex - 1));
                    if (npc != null)
                    {
                        if (cmbNpcPhase.SelectedIndex > -1)
                        {
                            condition.PhaseId = npc.NpcPhases[cmbNpcPhase.SelectedIndex].Id;
                        }
                    }
                }
            }
        }

        private void SaveFormValues(FightingNPCStats condition)
        {
            condition.NpcId = Guid.Empty;
            condition.Percents.Clear();
            if (FromNpc)
            {
                condition.Any = !chkOnlyTriggerStat.Checked;
            }
            else
            {
                condition.Any = false;
            }
            if (cmbStatsNpc.SelectedIndex > 0)
            {
                condition.NpcId = NpcBase.IdFromList(cmbStatsNpc.SelectedIndex - 1);
            }
            if (cmbNpcHpComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.Health, new int[2] { (int)nudNpcHp.Value, cmbNpcHpComp.SelectedIndex - 1 });
            }
            if (cmbNpcManaComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.Mana, new int[2] { (int)nudNpcMana.Value, cmbNpcManaComp.SelectedIndex - 1 });
            }
            if (cmbNpcAttackComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.Attack, new int[2] { (int)nudNpcAttack.Value, cmbNpcAttackComp.SelectedIndex - 1 });
            }
            if (cmbNpcMagicComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.AbilityPower, new int[2] { (int)nudNpcMagic.Value, cmbNpcMagicComp.SelectedIndex - 1 });
            }
            if (cmbNpcDefenseComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.Defense, new int[2] { (int)nudNpcDefense.Value, cmbNpcDefenseComp.SelectedIndex - 1 });
            }
            if (cmbNpcMRComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.MagicResist, new int[2] { (int)nudNpcMR.Value, cmbNpcMRComp.SelectedIndex - 1 });
            }
            if (cmbNpcSpeedComp.SelectedIndex > 0)
            {
                condition.Percents.Add((int)PhaseStats.Speed, new int[2] { (int)nudNpcSpeed.Value, cmbNpcSpeedComp.SelectedIndex - 1 });
            }
        }

        private void SaveFormValues(FightingNPCAttackType condition)
        {
            condition.NpcId = Guid.Empty;
            condition.AttackType = cmbNpcAttackType.SelectedIndex - 1;
            condition.AttackId = mAttackIdList[cmbNpcAttackTypeIs.SelectedIndex];
            condition.DamageType = cmbNpcDmgType.SelectedIndex - 1;
            condition.ElementalType = cmbNpcElementalType.SelectedIndex - 1;
            if (FromNpc)
            {
                condition.Any = !chkOnlyTriggerAttackType.Checked;
            }
            else
            {
                condition.Any = false;
            }
            if (cmbFightAttackTypeNpc.SelectedIndex > 0)
            {
                condition.NpcId = NpcBase.IdFromList(cmbFightAttackTypeNpc.SelectedIndex - 1);
            }
        }

        private void SaveFormValues(InPartyWithRole condition)
        {
            condition.Comparator = (VariableComparators)cmbPartyComparator.SelectedIndex;
            condition.Size = (int)nudPartySize.Value;
            condition.Role = cmbPartyRole.SelectedIndex;
        }

        private void SaveFormValues(PlayerElementalTypeIs condition)
        {
            condition.ElementalType = cmbPlayerElementalType.SelectedIndex;
        }

        public void SetupFromNpc()
        {
            FromNpc = true;
            chkOnlyTriggerPhase.Show();
            chkOnlyTriggerStat.Show();
            chkOnlyTriggerAttackType.Show();
        }

        #endregion
    }

}
