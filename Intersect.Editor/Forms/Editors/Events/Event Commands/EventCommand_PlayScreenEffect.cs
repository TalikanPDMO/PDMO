using System;
using System.Windows.Forms;

using Intersect.Editor.Content;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommand_PlayScreenEffect : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private PlayScreenEffectCommand mMyCommand;

        public EventCommand_PlayScreenEffect(PlayScreenEffectCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;

            InitLocalization();
            cmbEffectType.SelectedIndex = (int)mMyCommand.ScreenEffect.EffectType;

            if (mMyCommand.ScreenEffect.Opacities == null)
            {
                mMyCommand.ScreenEffect.Opacities = new byte[(int)ScreenEffectState.StateCount];
            }
            if (mMyCommand.ScreenEffect.Durations == null)
            {
                mMyCommand.ScreenEffect.Durations = new int[(int)ScreenEffectState.StateCount];
            }
            if (mMyCommand.ScreenEffect.Frames == null)
            {
                mMyCommand.ScreenEffect.Frames = new int[(int)ScreenEffectState.StateCount - 1];
            }
            chkOverGUI.Checked = mMyCommand.ScreenEffect.OverGUI;
            switch ((ScreenEffectType)cmbEffectType.SelectedIndex)
            {
                case ScreenEffectType.ColorTransition:
                    var color = Color.FromString(mMyCommand.ScreenEffect.Data, Color.Black);
                    pnlColor.BackColor = System.Drawing.Color.FromArgb(
                        color.A, color.R, color.G, color.B
                    );
                    colorDialog.Color = pnlColor.BackColor;
                    if (mMyCommand.ScreenEffect.Size > -1 && mMyCommand.ScreenEffect.Size < cmbSize.Items.Count)
                    {
                        cmbSize.SelectedIndex = mMyCommand.ScreenEffect.Size;
                    }
                    else
                    {
                        cmbSize.SelectedIndex = 0;
                    }
                    cmbPicture.SelectedIndex = 0;
                    nudOpacityBegin.Value = mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Begin];
                    nudOpacityPending.Value = mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Pending];
                    nudOpacityEnd.Value = mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.End];
                    nudDurationBegin.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Begin];
                    nudDurationPending.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Pending];
                    nudDurationEnd.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.End];
                    nudFramesBegin.Value = mMyCommand.ScreenEffect.Frames[0];
                    nudFramesEnd.Value = mMyCommand.ScreenEffect.Frames[1];
                    break;

                case ScreenEffectType.PictureTransition:
                    if (mMyCommand.ScreenEffect.Data != null && cmbPicture.Items.IndexOf(mMyCommand.ScreenEffect.Data) > -1)
                    {
                        cmbPicture.SelectedIndex = cmbPicture.Items.IndexOf(mMyCommand.ScreenEffect.Data);
                    }
                    else
                    {
                        if (cmbPicture.Items.Count > 0)
                        {
                            cmbPicture.SelectedIndex = 0;
                        }
                    }
                    if (mMyCommand.ScreenEffect.Size > -1 && mMyCommand.ScreenEffect.Size < cmbSize.Items.Count)
                    {
                        cmbSize.SelectedIndex = mMyCommand.ScreenEffect.Size;
                    }
                    else
                    {
                        cmbSize.SelectedIndex = 0;
                    }
                    nudOpacityBegin.Value = mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Begin];
                    nudOpacityPending.Value = mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Pending];
                    nudOpacityEnd.Value = mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.End];
                    nudDurationBegin.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Begin];
                    nudDurationPending.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Pending];
                    nudDurationEnd.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.End];
                    nudFramesBegin.Value = mMyCommand.ScreenEffect.Frames[0];
                    nudFramesEnd.Value = mMyCommand.ScreenEffect.Frames[1];
                    break;

                case ScreenEffectType.Shake:
                    nudShakeDuration.Value = mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Pending];
                    nudIntensity.Value = mMyCommand.ScreenEffect.Size;
                    cmbSize.SelectedIndex = 0;
                    cmbPicture.SelectedIndex = 0;
                    break;
            }

            UpdateVisibleFields();
        }

        private void UpdateVisibleFields()
        {
            lblColor.Hide();
            pnlColor.Hide();
            btnSelectColor.Hide();
            lblPicture.Hide();
            cmbPicture.Hide();
            cmbSize.Hide();
            grpTransition.Hide();
            grpShake.Hide();

            switch ((ScreenEffectType)cmbEffectType.SelectedIndex)
            {
                case ScreenEffectType.ColorTransition:
                    lblColor.Show();
                    pnlColor.Show();
                    btnSelectColor.Show();
                    cmbSize.Show();
                    grpTransition.Show();
                    chkOverGUI.Enabled = true;
                    break;

                case ScreenEffectType.PictureTransition:
                    lblPicture.Show();
                    cmbPicture.Show();
                    cmbSize.Show();
                    grpTransition.Show();
                    chkOverGUI.Enabled = true;
                    break;

                case ScreenEffectType.Shake:
                    grpShake.Show();
                    chkOverGUI.Checked = true;
                    chkOverGUI.Enabled = false;
                    break;
            }
        }

        private void InitLocalization()
        {
            grpPlayScreenEffect.Text = Strings.EventPlayScreenEffect.title;
            btnSave.Text = Strings.EventPlayScreenEffect.okay;
            btnCancel.Text = Strings.EventPlayScreenEffect.cancel;
            lblEffectType.Text = Strings.EventPlayScreenEffect.effecttype;
            cmbEffectType.Items.Clear();
            for (var i = 0; i < Strings.EventPlayScreenEffect.screeneffecttypes.Count; i++)
            {
                cmbEffectType.Items.Add(Strings.EventPlayScreenEffect.screeneffecttypes[i]);
            }
            chkOverGUI.Text = Strings.EventPlayScreenEffect.overgui;
            grpShake.Text = Strings.EventPlayScreenEffect.shake;
            lblShakeDuration.Text = Strings.EventPlayScreenEffect.duration;
            lblIntensity.Text = Strings.EventPlayScreenEffect.intensity;
            grpTransition.Text = Strings.EventPlayScreenEffect.transition;
            lblColor.Text = Strings.EventPlayScreenEffect.color;
            btnSelectColor.Text = Strings.EventPlayScreenEffect.selectcolor;
            lblPicture.Text = Strings.EventPlayScreenEffect.picture;
            cmbPicture.Items.Clear();
            cmbPicture.Items.AddRange(
                GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Image)
            );
            lblSize.Text = Strings.EventPlayScreenEffect.size;
            cmbSize.Items.Clear();
            cmbSize.Items.Add(Strings.EventPlayScreenEffect.original);
            cmbSize.Items.Add(Strings.EventPlayScreenEffect.fullscreen);
            cmbSize.Items.Add(Strings.EventPlayScreenEffect.halfscreen);
            cmbSize.Items.Add(Strings.EventPlayScreenEffect.stretchtofit);

            lblOpacities.Text = Strings.EventPlayScreenEffect.opacities;
            lblDurations.Text = Strings.EventPlayScreenEffect.durations;
            lblFrames.Text = Strings.EventPlayScreenEffect.frames;
            lblBegin.Text = Strings.EventPlayScreenEffect.beginning;
            lblPending.Text = Strings.EventPlayScreenEffect.pending;
            lblEnd.Text = Strings.EventPlayScreenEffect.ending;
            lblAutoframes.Text = Strings.EventPlayScreenEffect.autoframes;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.ScreenEffect.EffectType = (ScreenEffectType)cmbEffectType.SelectedIndex;
            mMyCommand.ScreenEffect.OverGUI = chkOverGUI.Checked;
            switch (mMyCommand.ScreenEffect.EffectType)
            {
                case ScreenEffectType.ColorTransition:
                    var color = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                    mMyCommand.ScreenEffect.Data = Color.ToString(color);
                    mMyCommand.ScreenEffect.Size = cmbSize.SelectedIndex;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Begin] = (byte)nudOpacityBegin.Value;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Pending] = (byte)nudOpacityPending.Value;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.End] = (byte)nudOpacityEnd.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Begin] = (int)nudDurationBegin.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Pending] = (int)nudDurationPending.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.End] = (int)nudDurationEnd.Value;
                    mMyCommand.ScreenEffect.Frames[0] = (int)nudFramesBegin.Value;
                    mMyCommand.ScreenEffect.Frames[1] = (int)nudFramesEnd.Value;
                    break;

                case ScreenEffectType.PictureTransition:
                    mMyCommand.ScreenEffect.Data = cmbPicture.Text;
                    mMyCommand.ScreenEffect.Size = cmbSize.SelectedIndex;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Begin] = (byte)nudOpacityBegin.Value;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Pending] = (byte)nudOpacityPending.Value;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.End] = (byte)nudOpacityEnd.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Begin] = (int)nudDurationBegin.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Pending] = (int)nudDurationPending.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.End] = (int)nudDurationEnd.Value;
                    mMyCommand.ScreenEffect.Frames[0] = (int)nudFramesBegin.Value;
                    mMyCommand.ScreenEffect.Frames[1] = (int)nudFramesEnd.Value;
                    break;

                case ScreenEffectType.Shake:
                    mMyCommand.ScreenEffect.Data = "";
                    mMyCommand.ScreenEffect.Size = (int)nudIntensity.Value;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Begin] = 0;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.Pending] =0;
                    mMyCommand.ScreenEffect.Opacities[(int)ScreenEffectState.End] = 0;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Begin] = (int)nudShakeDuration.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.Pending] = (int)nudShakeDuration.Value;
                    mMyCommand.ScreenEffect.Durations[(int)ScreenEffectState.End] = (int)nudShakeDuration.Value;
                    mMyCommand.ScreenEffect.Frames[0] = 0;
                    mMyCommand.ScreenEffect.Frames[1] = 0;
                    break;
            }
            if (Array.TrueForAll(mMyCommand.ScreenEffect.Opacities, item => item == 0))
            {
                mMyCommand.ScreenEffect.Opacities = null;
            }
            if (Array.TrueForAll(mMyCommand.ScreenEffect.Durations, item => item == 0))
            {
                mMyCommand.ScreenEffect.Durations = null;
            }
            if (Array.TrueForAll(mMyCommand.ScreenEffect.Frames, item => item == 0))
            {
                mMyCommand.ScreenEffect.Frames = null;
            }
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void cmbEffectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibleFields();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = System.Drawing.Color.White;
            colorDialog.ShowDialog();
            pnlColor.BackColor = colorDialog.Color;
        }
    }
}
