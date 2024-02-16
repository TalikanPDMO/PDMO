using System;
using System.Linq;
using System.Windows.Forms;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;

namespace Intersect.Editor.Forms.Editors.MapRegions
{

    public partial class MapRegionCommandCondition : UserControl
    {
        public bool Cancelled;

        public Condition Condition;

        private bool mLoading = false;

        public MapRegionCommandCondition(
            Condition refCommand
        )
        {
            InitializeComponent();
            mLoading = true;
            if (refCommand == null)
            {
                refCommand = new VariableIsCondition();
            }

            Condition = refCommand;
            UpdateFormElements(refCommand.Type);
            InitLocalization();
            var typeIndex = 0;
            foreach (var itm in Strings.MapRegionConditional.conditions)
            {
                if (itm.Key == (int) Condition.Type)
                {
                    cmbConditionType.SelectedIndex = typeIndex;

                    break;
                }

                typeIndex++;
            }
            chkNegated.Checked = refCommand.Negated;
            chkHasElse.Checked = refCommand.ElseEnabled;
            SetupFormValues((dynamic) refCommand);
            mLoading = false;
        }

        private void InitLocalization()
        {
            grpConditional.Text = Strings.MapRegionConditional.title;
            lblType.Text = Strings.MapRegionConditional.type;

            cmbConditionType.Items.Clear();
            foreach (var itm in Strings.MapRegionConditional.conditions)
            {
                cmbConditionType.Items.Add(itm.Value);
            }

            chkNegated.Text = Strings.MapRegionConditional.negated;
            chkHasElse.Text = Strings.MapRegionConditional.HasElse;


            //Has Item + Has Free Inventory Slots
            grpInventoryConditions.Text = Strings.MapRegionConditional.hasitem;
            lblItemQuantity.Text = Strings.MapRegionConditional.hasatleast;
            lblItem.Text = Strings.MapRegionConditional.item;
            grpAmountType.Text = Strings.MapRegionConditional.AmountType;
            rdoManual.Text = Strings.MapRegionConditional.Manual;
            rdoVariable.Text = Strings.MapRegionConditional.VariableLabel;
            grpManualAmount.Text = Strings.MapRegionConditional.Manual;

            //Has Item Equipped
            grpEquippedItem.Text = Strings.MapRegionConditional.hasitemequipped;
            lblEquippedItem.Text = Strings.MapRegionConditional.item;

            //Class is
            grpClass.Text = Strings.MapRegionConditional.classis;
            lblClass.Text = Strings.MapRegionConditional.Class;

            //Knows Spell
            grpSpell.Text = Strings.MapRegionConditional.knowsspell;
            lblSpell.Text = Strings.MapRegionConditional.spell;

            //Level or Stat is
            grpLevelStat.Text = Strings.MapRegionConditional.levelorstat;
            lblLvlStatValue.Text = Strings.MapRegionConditional.levelstatvalue;
            lblLevelComparator.Text = Strings.MapRegionConditional.comparator;
            lblLevelOrStat.Text = Strings.MapRegionConditional.levelstatitem;
            cmbLevelStat.Items.Clear();
            cmbLevelStat.Items.Add(Strings.MapRegionConditional.level);
            for (var i = 0; i < (int) Stats.StatCount; i++)
            {
                cmbLevelStat.Items.Add(Strings.Combat.stats[i]);
            }

            cmbLevelComparator.Items.Clear();
            for (var i = 0; i < Strings.MapRegionConditional.comparators.Count; i++)
            {
                cmbLevelComparator.Items.Add(Strings.MapRegionConditional.comparators[i]);
            }


            //Quest In Progress
            grpQuestInProgress.Text = Strings.MapRegionConditional.questinprogress;
            lblQuestProgress.Text = Strings.MapRegionConditional.questprogress;
            lblQuestIs.Text = Strings.MapRegionConditional.questis;
            cmbTaskModifier.Items.Clear();
            for (var i = 0; i < Strings.MapRegionConditional.questcomparators.Count; i++)
            {
                cmbTaskModifier.Items.Add(Strings.MapRegionConditional.questcomparators[i]);
            }

            lblQuestTask.Text = Strings.MapRegionConditional.task;

            //Quest Completed
            grpQuestCompleted.Text = Strings.MapRegionConditional.questcompleted;
            lblQuestCompleted.Text = Strings.MapRegionConditional.questcompletedlabel;

            //Gender is
            grpGender.Text = Strings.MapRegionConditional.genderis;
            lblGender.Text = Strings.MapRegionConditional.gender;
            cmbGender.Items.Clear();
            cmbGender.Items.Add(Strings.MapRegionConditional.male);
            cmbGender.Items.Add(Strings.MapRegionConditional.female);

            //Map Is
            grpMapIs.Text = Strings.MapRegionConditional.mapis;
            btnSelectMap.Text = Strings.MapRegionConditional.selectmap;

            //In Guild With At Least Rank
            grpInGuild.Text = Strings.MapRegionConditional.inguild;
            lblRank.Text = Strings.MapRegionConditional.rank;
            cmbRank.Items.Clear();
            foreach (var rank in Options.Instance.Guild.Ranks)
            {
                cmbRank.Items.Add(rank.Title);
            }

            // Map Zone Type
            grpMapZoneType.Text = Strings.MapRegionConditional.MapZoneTypeIs;
            lblMapZoneType.Text = Strings.MapRegionConditional.MapZoneTypeLabel;
            cmbMapZoneType.Items.Clear();
            for (var i = 0; i < Strings.MapProperties.zones.Count; i++)
            {
                cmbMapZoneType.Items.Add(Strings.MapProperties.zones[i]);
            }

            // In Party with role
            grpInParty.Text = Strings.MapRegionConditional.inparty;
            lblPartyComparator.Text = Strings.MapRegionConditional.comparator;
            lblPartySize.Text = Strings.MapRegionConditional.partysize;

            cmbPartyComparator.Items.Clear();
            for (var i = 0; i < Strings.MapRegionConditional.comparators.Count; i++)
            {
                cmbPartyComparator.Items.Add(Strings.MapRegionConditional.comparators[i]);
            }

            lblPartyRole.Text = Strings.MapRegionConditional.partyrole;
            cmbPartyRole.Items.Clear();
            for (var i = 0; i < Strings.MapRegionConditional.partyroles.Count; i++)
            {
                cmbPartyRole.Items.Add(Strings.MapRegionConditional.partyroles[i]);
            }

            // Player ElementalType is
            grpElementalType.Text = Strings.MapRegionConditional.elementaltypeis;
            lblPlayerElementalType.Text = Strings.MapRegionConditional.elementaltype;
            cmbPlayerElementalType.Items.Clear();
            for (var i = 0; i < Strings.Combat.elementaltypes.Count; i++)
            {
                cmbPlayerElementalType.Items.Add(Strings.Combat.elementaltypes[i]);
            }
            // Save/Cancel buttons
            btnSave.Text = Strings.MapRegionConditional.okay;
            btnCancel.Text = Strings.MapRegionConditional.cancel;
        }

        private void ConditionTypeChanged(ConditionTypes type)
        {
            switch (type)
            {
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
                case ConditionTypes.EntityTypeIs:
                    Condition = new EntityTypeIs();
                   
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void UpdateFormElements(ConditionTypes type)
        {
            grpInventoryConditions.Hide();
            grpSpell.Hide();
            grpClass.Hide();
            grpLevelStat.Hide();
            grpQuestInProgress.Hide();
            grpQuestCompleted.Hide();
            grpGender.Hide();
            grpMapIs.Hide();
            grpEquippedItem.Hide();
            grpInGuild.Hide();
            grpMapZoneType.Hide();
            grpElementalType.Hide();
            grpInParty.Hide();
            grpEntitytypeIs.Hide();
            switch (type)
            {
                case ConditionTypes.HasItem:
                    grpInventoryConditions.Show();
                    grpInventoryConditions.Text = Strings.MapRegionConditional.hasitem;
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
                    grpInventoryConditions.Text = Strings.MapRegionConditional.FreeInventorySlots;
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
                case ConditionTypes.InPartyWithRole:
                    grpInParty.Show();
                    break;
                case ConditionTypes.PlayerElementalType:
                    grpElementalType.Show();
                    break;
                case ConditionTypes.EntityTypeIs:
                    grpEntitytypeIs.Show();
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

            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void cmbConditionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Strings.MapRegionConditional.conditions.FirstOrDefault(x => x.Value == cmbConditionType.Text).Key;
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


        private void SetupAmountInput()
        {
            grpManualAmount.Visible = rdoManual.Checked;
            int ConditionQuantity;

            switch (Condition.Type)
            {
                case ConditionTypes.HasFreeInventorySlots:
                    ConditionQuantity = ((HasFreeInventorySlots)Condition).Quantity;
                    break;
                case ConditionTypes.HasItem:
                    ConditionQuantity = ((HasItemCondition)Condition).Quantity;
                    break;
                default:
                    ConditionQuantity = 0;
                    return;
            }
            nudItemAmount.Value = Math.Max(1, ConditionQuantity);
        }

        #region "SetupFormValues"


        private void SetupFormValues(HasItemCondition condition)
        {
            cmbItem.SelectedIndex = ItemBase.ListIndex(condition.ItemId);
            nudItemAmount.Value = condition.Quantity;
            rdoVariable.Checked = condition.UseVariable;
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

        private void SetupFormValues(EntityTypeIs condition)
        {
            chkPlayerType.Checked = condition.Entities[(int)EntityTypes.Player];
            chkNpcType.Checked = condition.Entities[(int)EntityTypes.GlobalEntity];
            chkEventType.Checked = condition.Entities[(int)EntityTypes.Event];
            chkProjectileType.Checked = condition.Entities[(int)EntityTypes.Projectile];
            chkResourceType.Checked = condition.Entities[(int)EntityTypes.Resource];
        }
        #endregion

        #region "SaveFormValues"

        private void SaveFormValues(HasItemCondition condition)
        {
            condition.ItemId = ItemBase.IdFromList(cmbItem.SelectedIndex);
            condition.Quantity = (int) nudItemAmount.Value;
            condition.UseVariable = false;
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

            condition.IgnoreBuffs = false;
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
            
            condition.UseVariable = false;
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

        private void SaveFormValues(EntityTypeIs condition)
        {
            condition.Entities[(int)EntityTypes.Player] = chkPlayerType.Checked;
            condition.Entities[(int)EntityTypes.GlobalEntity] = chkNpcType.Checked;
            condition.Entities[(int)EntityTypes.Event] = chkEventType.Checked;
            condition.Entities[(int)EntityTypes.Projectile] = chkProjectileType.Checked;
            condition.Entities[(int)EntityTypes.Resource] = chkResourceType.Checked;
        }

        #endregion
    }

}
