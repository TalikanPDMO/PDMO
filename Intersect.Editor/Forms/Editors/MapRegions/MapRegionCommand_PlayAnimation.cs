using System;
using System.Drawing;
using Intersect.Editor.Content;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps.MapRegion;
using Intersect.Utilities;

namespace Intersect.Editor.Forms.Editors.MapRegions
{

    public partial class MapRegionCommandPlayAnimation : MapRegionCommandControl
    {

        private PlayAnimationCommand mMyCommand;

        public MapRegionCommandPlayAnimation(PlayAnimationCommand refCommand) : base(refCommand?.ConditionLists?.Data())
        {
            InitializeComponent();
            mMyCommand = refCommand;
            InitLocalization();

            if (mMyCommand.ConditionLists == null || mMyCommand.ConditionLists.Count == 0)
            {
                btnEditCmdConditions.Text = Strings.MapRegionPlayAnimation.editconditions.ToString(Strings.MapRegionPlayAnimation.none);
            }
            else
            {
                btnEditCmdConditions.Text = Strings.MapRegionPlayAnimation.editconditions.ToString(mMyCommand.ConditionLists.Count);
            }

            cmbAnimation.Items.Clear();
            cmbAnimation.Items.Add(Strings.General.none);
            cmbAnimation.Items.AddRange(AnimationBase.Names);
            cmbAnimation.SelectedIndex = AnimationBase.ListIndex(mMyCommand.AnimId ?? Guid.Empty) + 1;
        }

        private void InitLocalization()
        {
            grpPlayAnimation.Text = Strings.MapRegionPlayAnimation.title;
            lblInstructions.Text = Strings.MapRegionPlayAnimation.instructions;
            lblAnimation.Text = Strings.MapRegionPlayAnimation.animation;
            btnSave.Text = Strings.MapRegionPlayAnimation.okay;
            btnCancel.Text = Strings.MapRegionPlayAnimation.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAnimation.SelectedIndex == 0)
            {
                mMyCommand.AnimId = null;
            }
            else
            {
                mMyCommand.AnimId = AnimationBase.IdFromList(cmbAnimation.SelectedIndex - 1);
            }
            ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            mMyCommand.ConditionLists.Load(mBackupConditionData); // Cancel possible conditionlist editing
            ParentForm.Close();
        }
        private void btnEditCmdConditions_Click(object sender, EventArgs e)
        {
            var editForm = new FrmDynamicRequirements(mMyCommand.ConditionLists, RequirementType.MapRegion);
            editForm.ShowDialog();
            if (mMyCommand.ConditionLists == null || mMyCommand.ConditionLists.Count == 0)
            {
                btnEditCmdConditions.Text = Strings.MapRegionPlayAnimation.editconditions.ToString(Strings.MapRegionPlayAnimation.none);
            }
            else
            {
                btnEditCmdConditions.Text = Strings.MapRegionPlayAnimation.editconditions.ToString(mMyCommand.ConditionLists.Count);
            }
        }

    }

}
