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
            cmbEffectType.SelectedIndex = (int)mMyCommand.EffectType;
            
            switch ((ScreenEffectType)cmbEffectType.SelectedIndex)
            {
                case ScreenEffectType.ColorTransition:
                    nudOpacityStart.Value = mMyCommand.OpacityStart;
                    nudOpacityEnd.Value = mMyCommand.OpacityEnd;
                    nudOpacityDuration.Value = mMyCommand.OpacityDuration;
                    nudFrames.Value = mMyCommand.OpacityFrame;
                    nudAfterDuration.Value = mMyCommand.FinalDuration;
                    var color = Color.FromString(mMyCommand.Data, Color.Black);
                    pnlColor.BackColor = System.Drawing.Color.FromArgb(
                        color.A, color.R, color.G, color.B
                    );
                    colorDialog.Color = pnlColor.BackColor;
                    if (mMyCommand.Size > -1 && mMyCommand.Size < cmbSize.Items.Count)
                    {
                        cmbSize.SelectedIndex = mMyCommand.Size;
                    }
                    else
                    {
                        cmbSize.SelectedIndex = 0;
                    }
                    cmbPicture.SelectedIndex = 0;
                    break;

                case ScreenEffectType.PictureTransition:
                    nudOpacityStart.Value = mMyCommand.OpacityStart;
                    nudOpacityEnd.Value = mMyCommand.OpacityEnd;
                    nudOpacityDuration.Value = mMyCommand.OpacityDuration;
                    nudFrames.Value = mMyCommand.OpacityFrame;
                    nudAfterDuration.Value = mMyCommand.FinalDuration;
                    if (mMyCommand.Data != null && cmbPicture.Items.IndexOf(mMyCommand.Data) > -1)
                    {
                        cmbPicture.SelectedIndex = cmbPicture.Items.IndexOf(mMyCommand.Data);
                    }
                    else
                    {
                        if (cmbPicture.Items.Count > 0)
                        {
                            cmbPicture.SelectedIndex = 0;
                        }
                    }
                    if (mMyCommand.Size > -1 && mMyCommand.Size < cmbSize.Items.Count)
                    {
                        cmbSize.SelectedIndex = mMyCommand.Size;
                    }
                    else
                    {
                        cmbSize.SelectedIndex = 0;
                    }
                    break;

                case ScreenEffectType.Shake:
                    nudShakeDuration.Value = mMyCommand.FinalDuration;
                    nudIntensity.Value = mMyCommand.Size;
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
                    break;

                case ScreenEffectType.PictureTransition:
                    lblPicture.Show();
                    cmbPicture.Show();
                    cmbSize.Show();
                    grpTransition.Show();
                    break;

                case ScreenEffectType.Shake:
                    grpShake.Show();
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

            lblOpacity.Text = Strings.EventPlayScreenEffect.opacitytransition;
            lblOpacityDuration.Text = Strings.EventPlayScreenEffect.transitionduration;
            lblFrames.Text = Strings.EventPlayScreenEffect.transitionframes;
            lblAfterDuration.Text = Strings.EventPlayScreenEffect.aftertransitionduration;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.EffectType = (ScreenEffectType)cmbEffectType.SelectedIndex;
            switch (mMyCommand.EffectType)
            {
                case ScreenEffectType.ColorTransition:
                    var color = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                    mMyCommand.Data = Color.ToString(color);
                    mMyCommand.Size = cmbSize.SelectedIndex;
                    mMyCommand.OpacityStart = (byte)nudOpacityStart.Value;
                    mMyCommand.OpacityEnd = (byte)nudOpacityEnd.Value;
                    mMyCommand.OpacityDuration = (int)nudOpacityDuration.Value;
                    mMyCommand.OpacityFrame = (int)nudFrames.Value;
                    mMyCommand.FinalDuration = (int)nudAfterDuration.Value;
                    break;

                case ScreenEffectType.PictureTransition:
                    mMyCommand.Data = cmbPicture.Text;
                    mMyCommand.Size = cmbSize.SelectedIndex;
                    mMyCommand.OpacityStart = (byte)nudOpacityStart.Value;
                    mMyCommand.OpacityEnd = (byte)nudOpacityEnd.Value;
                    mMyCommand.OpacityDuration = (int)nudOpacityDuration.Value;
                    mMyCommand.OpacityFrame = (int)nudFrames.Value;
                    mMyCommand.FinalDuration = (int)nudAfterDuration.Value;
                    break;

                case ScreenEffectType.Shake:
                    mMyCommand.Data = "";
                    mMyCommand.Size = (int)nudIntensity.Value;
                    mMyCommand.OpacityStart = 0;
                    mMyCommand.OpacityEnd = 0;
                    mMyCommand.OpacityDuration = 0;
                    mMyCommand.OpacityFrame = 0;
                    mMyCommand.FinalDuration = (int)nudShakeDuration.Value;
                    break;
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
