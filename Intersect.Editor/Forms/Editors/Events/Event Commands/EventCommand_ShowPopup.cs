using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Intersect.Editor.Content;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects.Events.Commands;
using Intersect.Utilities;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandShowPopup : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private ShowPopupCommand mMyCommand;

        public EventCommandShowPopup(ShowPopupCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            cmbBgPicture.Items.Clear();
            cmbBgPicture.Items.Add(Strings.General.none);
            cmbBgPicture.Items.AddRange(
                GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Image)
            );

            if (cmbBgPicture.Items.IndexOf(TextUtils.NullToNone(mMyCommand.BackgroundFile)) > -1)
            {
                cmbBgPicture.SelectedIndex = cmbBgPicture.Items.IndexOf(TextUtils.NullToNone(mMyCommand.BackgroundFile));
            }
            else
            {
                cmbBgPicture.SelectedIndex = 0;
            }

            cmbFace.Items.Clear();
            cmbFace.Items.Add(Strings.General.none);
            cmbFace.Items.AddRange(GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Face));
            if (cmbFace.Items.IndexOf(TextUtils.NullToNone(mMyCommand.FaceFile)) > -1)
            {
                cmbFace.SelectedIndex = cmbFace.Items.IndexOf(TextUtils.NullToNone(mMyCommand.FaceFile));
            }
            else
            {
                cmbFace.SelectedIndex = 0;
            }

            UpdateFacePreview();

            chkSyncAll.Checked = mMyCommand.IncludeAll;
            chkSyncGuild.Checked = mMyCommand.IncludeGuild;
            chkSyncParty.Checked = mMyCommand.IncludeParty;
            nudHideTime.Value = mMyCommand.HideTime;
            nudOpacity.Value = mMyCommand.Opacity;
            txtText.Text = mMyCommand.Text;
            txtTitle.Text = mMyCommand.Title;
            nudX.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.PopupShiftX)];
            nudY.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.PopupShiftY)];
            nudTitleX.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.TitleShiftX)];
            nudTitleY.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.TitleShiftY)];
            nudFaceX.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.FaceShiftX)];
            nudFaceY.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.FaceShiftY)];
            nudTextX.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaShiftX)];
            nudTextY.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaShiftY)];
            nudTextWidth.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaWidth)];
            nudTextHeight.Value = mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaHeight)];


            InitLocalization();
        }

        private void InitLocalization()
        {
            grpShowPopup.Text = Strings.EventShowPopup.title;
            lblBgPicture.Text = Strings.EventShowPopup.background;
            btnSave.Text = Strings.EventShowPopup.okay;
            btnCancel.Text = Strings.EventShowPopup.cancel;
            chkSyncAll.Text = Strings.EventShowPopup.all;
            chkSyncGuild.Text = Strings.EventShowPopup.guild;
            chkSyncParty.Text = Strings.EventShowPopup.party;
            lblHide.Text = Strings.EventShowPopup.hide;
            lblFace.Text = Strings.EventShowPopup.face;
            lblOpacity.Text = Strings.EventShowPopup.opacity;
            lblSync.Text = Strings.EventShowPopup.include;
            lblText.Text = Strings.EventShowPopup.text;
            lblCommands.Text = Strings.EventShowPopup.commands;
            lblPopupTitle.Text = Strings.EventShowPopup.popuptitle;
            lblX.Text = Strings.EventShowPopup.X;
            lblY.Text = Strings.EventShowPopup.Y;
            lblTitleX.Text = Strings.EventShowPopup.X;
            lblTitleY.Text = Strings.EventShowPopup.Y;
            lblFaceX.Text = Strings.EventShowPopup.X;
            lblFaceY.Text = Strings.EventShowPopup.Y;
            lblTextX.Text = Strings.EventShowPopup.X;
            lblTextY.Text = Strings.EventShowPopup.Y;
            lblTextWidth.Text = Strings.EventShowPopup.width;
            lblTextHeight.Text = Strings.EventShowPopup.height;
            lblExplanations.Text = Strings.EventShowPopup.explanations;
            lblShiftCenter.Text = Strings.EventShowPopup.shiftcenter;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.IncludeAll = chkSyncAll.Checked;
            mMyCommand.IncludeGuild = chkSyncGuild.Checked;
            mMyCommand.IncludeParty = chkSyncParty.Checked;
            mMyCommand.HideTime = (int)nudHideTime.Value;
            mMyCommand.Opacity = (byte)nudOpacity.Value;
            mMyCommand.Text = txtText.Text;
            mMyCommand.Title = txtTitle.Text;
            mMyCommand.BackgroundFile = TextUtils.SanitizeNone(cmbBgPicture?.Text);
            mMyCommand.FaceFile = TextUtils.SanitizeNone(cmbFace?.Text);
            mMyCommand.PopupLayout[((int)PopupLayoutParams.PopupShiftX)] = (sbyte)nudX.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.PopupShiftY)] = (sbyte)nudY.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.TitleShiftX)] = (sbyte)nudTitleX.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.TitleShiftY)] = (sbyte)nudTitleY.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.FaceShiftX)] = (sbyte)nudFaceX.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.FaceShiftY)] = (sbyte)nudFaceY.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaShiftX)] = (sbyte)nudTextX.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaShiftY)] = (sbyte)nudTextY.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaWidth)] = (sbyte)nudTextWidth.Value;
            mMyCommand.PopupLayout[((int)PopupLayoutParams.TextAreaHeight)] = (sbyte)nudTextHeight.Value;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void UpdateFacePreview()
        {
            if (File.Exists(GameContentManager.GraphResFolder + "/faces/" + cmbFace.Text))
            {
                pnlFace.BackgroundImage = new Bitmap(GameContentManager.GraphResFolder + "/faces/" + cmbFace.Text);
            }
            else
            {
                pnlFace.BackgroundImage = null;
            }
        }

        private void cmbFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFacePreview();
        }

        private void lblCommands_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://www.ascensiongamedev.com/community/topic/749-event-text-variables/"
            );
        }
    }

}
