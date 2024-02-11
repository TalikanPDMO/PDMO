﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DarkUI.Controls;
using DarkUI.Forms;

using Intersect.Editor.Content;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps;
using Intersect.Utilities;

using Microsoft.Xna.Framework.Graphics;

namespace Intersect.Editor.Forms.Editors
{

    public partial class FrmAnimation : EditorForm
    {

        private List<AnimationBase> mChanged = new List<AnimationBase>();

        private string mCopiedItem;

        private AnimationBase mEditorItem;

        private List<string> mKnownFolders = new List<string>();

        private RenderTarget2D mLowerDarkness;

        private int mLowerFrame;

        //Mono Rendering Variables
        private SwapChainRenderTarget mLowerWindow;

        private bool mPlayLower;

        private bool mPlayUpper;

        private RenderTarget2D mUpperDarkness;

        private int mUpperFrame;

        private SwapChainRenderTarget mUpperWindow;

        public FrmAnimation()
        {
            ApplyHooks();
            InitializeComponent();

            lstGameObjects.Init(UpdateToolStripItems, AssignEditorItem, toolStripItemNew_Click, toolStripItemCopy_Click, toolStripItemUndo_Click, toolStripItemPaste_Click, toolStripItemDelete_Click, toolStripItemRelations_Click);
        }

        private void AssignEditorItem(Guid id)
        {
            mEditorItem = AnimationBase.Get(id);
            UpdateEditor();
        }

        protected override void GameObjectUpdatedDelegate(GameObjectType type)
        {
            if (type != GameObjectType.Animation)
            {
                return;
            }

            InitEditor();
            if (mEditorItem == null || AnimationBase.Lookup.Values.Contains(mEditorItem))
            {
                return;
            }

            mEditorItem = null;
            UpdateEditor();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var item in mChanged)
            {
                item.RestoreBackup();
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Send Changed items
            foreach (var item in mChanged)
            {
                foreach(var screeneffect in item.ScreenEffects)
                {
                    if (Array.TrueForAll(screeneffect.Opacities, v => v == 0))
                    {
                        screeneffect.Opacities = null;
                    }
                    if (Array.TrueForAll(screeneffect.Durations, v => v == 0))
                    {
                        screeneffect.Durations = null;
                    }
                    if (Array.TrueForAll(screeneffect.Frames, v => v == 0))
                    {
                        screeneffect.Frames = null;
                    }
                }
                PacketSender.SendSaveObject(item);
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void frmAnimation_Load(object sender, EventArgs e)
        {
            //Animation Sound
            cmbSound.Items.Clear();
            cmbSound.Items.Add(Strings.General.none);
            cmbSound.Items.AddRange(GameContentManager.SmartSortedSoundNames);

            //Lower Animation Graphic
            cmbLowerGraphic.Items.Clear();
            cmbLowerGraphic.Items.Add(Strings.General.none);
            cmbLowerGraphic.Items.AddRange(
                GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Animation)
            );

            //Upper Animation Graphic
            cmbUpperGraphic.Items.Clear();
            cmbUpperGraphic.Items.Add(Strings.General.none);
            cmbUpperGraphic.Items.AddRange(
                GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Animation)
            );

            mLowerWindow = new SwapChainRenderTarget(
                Core.Graphics.GetGraphicsDevice(), picLowerAnimation.Handle, picLowerAnimation.Width,
                picLowerAnimation.Height
            );

            mUpperWindow = new SwapChainRenderTarget(
                Core.Graphics.GetGraphicsDevice(), picUpperAnimation.Handle, picUpperAnimation.Width,
                picUpperAnimation.Height
            );

            mLowerDarkness = Core.Graphics.CreateRenderTexture(picLowerAnimation.Width, picLowerAnimation.Height);
            mUpperDarkness = Core.Graphics.CreateRenderTexture(picUpperAnimation.Width, picUpperAnimation.Height);

            InitLocalization();
            UpdateEditor();
        }

        private void InitLocalization()
        {
            Text = Strings.AnimationEditor.title;
            toolStripItemNew.Text = Strings.AnimationEditor.New;
            toolStripItemDelete.Text = Strings.AnimationEditor.delete;
            toolStripItemCopy.Text = Strings.AnimationEditor.copy;
            toolStripItemPaste.Text = Strings.AnimationEditor.paste;
            toolStripItemUndo.Text = Strings.AnimationEditor.undo;
            toolStripItemRelations.Text = Strings.AnimationEditor.relations;

            grpAnimations.Text = Strings.AnimationEditor.animations;
            grpCommentary.Text = Strings.AnimationEditor.commentary;

            grpGeneral.Text = Strings.AnimationEditor.general;
            lblName.Text = Strings.AnimationEditor.name;
            lblSound.Text = Strings.AnimationEditor.sound;
            chkCompleteSoundPlayback.Text = Strings.AnimationEditor.soundcomplete;
            labelDarkness.Text = Strings.AnimationEditor.simulatedarkness.ToString(scrlDarkness.Value);
            btnSwap.Text = Strings.AnimationEditor.swap;
            lblId.Text = Strings.AnimationEditor.animationid;

            grpLower.Text = Strings.AnimationEditor.lowergroup;
            lblLowerGraphic.Text = Strings.AnimationEditor.lowergraphic;
            lblLowerHorizontalFrames.Text = Strings.AnimationEditor.lowerhorizontalframes;
            lblLowerVerticalFrames.Text = Strings.AnimationEditor.lowerverticalframes;
            lblLowerFrameCount.Text = Strings.AnimationEditor.lowerframecount;
            lblLowerFrameDuration.Text = Strings.AnimationEditor.lowerframeduration;
            lblLowerLoopCount.Text = Strings.AnimationEditor.lowerloopcount;
            grpLowerPlayback.Text = Strings.AnimationEditor.lowerplayback;
            lblLowerFrame.Text = Strings.AnimationEditor.lowerframe.ToString(scrlLowerFrame.Value);
            btnPlayLower.Text = Strings.AnimationEditor.lowerplay;
            grpLowerFrameOpts.Text = Strings.AnimationEditor.lowerframeoptions;
            btnLowerClone.Text = Strings.AnimationEditor.lowerclone;
            chkDisableLowerRotations.Text = Strings.AnimationEditor.disablelowerrotations;
            chkRenderAbovePlayer.Text = Strings.AnimationEditor.renderaboveplayer;

            grpUpper.Text = Strings.AnimationEditor.uppergroup;
            lblUpperGraphic.Text = Strings.AnimationEditor.uppergraphic;
            lblUpperHorizontalFrames.Text = Strings.AnimationEditor.upperhorizontalframes;
            lblUpperVerticalFrames.Text = Strings.AnimationEditor.upperverticalframes;
            lblUpperFrameCount.Text = Strings.AnimationEditor.upperframecount;
            lblUpperFrameDuration.Text = Strings.AnimationEditor.upperframeduration;
            lblUpperLoopCount.Text = Strings.AnimationEditor.upperloopcount;
            grpUpperPlayback.Text = Strings.AnimationEditor.upperplayback;
            lblUpperFrame.Text = Strings.AnimationEditor.upperframe.ToString(scrlUpperFrame.Value);
            btnPlayUpper.Text = Strings.AnimationEditor.upperplay;
            grpUpperFrameOpts.Text = Strings.AnimationEditor.upperframeoptions;
            btnUpperClone.Text = Strings.AnimationEditor.upperclone;
            chkDisableUpperRotations.Text = Strings.AnimationEditor.disableupperrotations;
            chkRenderBelowFringe.Text = Strings.AnimationEditor.renderbelowfringe;

            //Searching/Sorting
            btnAlphabetical.ToolTipText = Strings.AnimationEditor.sortalphabetically;
            txtSearch.Text = Strings.AnimationEditor.searchplaceholder;
            lblFolder.Text = Strings.AnimationEditor.folderlabel;

            // Screen Effects
            grpScreenEffects.Text = Strings.AnimationEditor.screeneffects;
            lblEffectType.Text = Strings.AnimationEditor.effecttype;
            cmbEffectType.Items.Clear();
            for (var i = 0; i < Strings.AnimationEditor.screeneffecttypes.Count; i++)
            {
                cmbEffectType.Items.Add(Strings.AnimationEditor.screeneffecttypes[i]);
            }
            chkOverGUI.Text = Strings.AnimationEditor.overgui;
            grpShake.Text = Strings.AnimationEditor.shake;
            lblShakeDuration.Text = Strings.AnimationEditor.duration;
            lblIntensity.Text = Strings.AnimationEditor.intensity;
            grpTransition.Text = Strings.AnimationEditor.transition;
            lblColor.Text = Strings.AnimationEditor.color;
            btnSelectColor.Text = Strings.AnimationEditor.selectcolor;
            lblPicture.Text = Strings.AnimationEditor.picture;
            cmbPicture.Items.Clear();
            cmbPicture.Items.AddRange(
                GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Image)
            );
            lblSize.Text = Strings.AnimationEditor.size;
            cmbSize.Items.Clear();
            cmbSize.Items.Add(Strings.AnimationEditor.original);
            cmbSize.Items.Add(Strings.AnimationEditor.fullscreen);
            cmbSize.Items.Add(Strings.AnimationEditor.halfscreen);
            cmbSize.Items.Add(Strings.AnimationEditor.stretchtofit);

            lblOpacities.Text = Strings.AnimationEditor.opacities;
            lblDurations.Text = Strings.AnimationEditor.durations;
            lblFrames.Text = Strings.AnimationEditor.frames;
            lblBegin.Text = Strings.AnimationEditor.beginning;
            lblPending.Text = Strings.AnimationEditor.pending;
            lblEnd.Text = Strings.AnimationEditor.ending;
            lblAutoframes.Text = Strings.AnimationEditor.autoframes;

            btnAdd.Text = Strings.AnimationEditor.add;
            btnRemove.Text = Strings.AnimationEditor.remove;

            btnSave.Text = Strings.AnimationEditor.save;
            btnCancel.Text = Strings.AnimationEditor.cancel;
        }

        private void UpdateEditor()
        {
            if (mEditorItem != null)
            {
                pnlContainer.Show();
                grpCommentary.Show();

                txtCommentary.Text = mEditorItem.Comment;
                cmbFolder.Text = mEditorItem.Folder;
                txtName.Text = mEditorItem.Name;
                txtId.Text = mEditorItem.Id.ToString();
                cmbSound.SelectedIndex = cmbSound.FindString(TextUtils.NullToNone(mEditorItem.Sound));
                chkCompleteSoundPlayback.Checked = mEditorItem.CompleteSound;

                cmbLowerGraphic.SelectedIndex =
                    cmbLowerGraphic.FindString(TextUtils.NullToNone(mEditorItem.Lower.Sprite));

                nudLowerHorizontalFrames.Value = mEditorItem.Lower.XFrames;
                nudLowerVerticalFrames.Value = mEditorItem.Lower.YFrames;
                nudLowerFrameCount.Value = mEditorItem.Lower.FrameCount;
                UpdateLowerFrames();

                nudLowerFrameDuration.Value = mEditorItem.Lower.FrameSpeed;
                tmrLowerAnimation.Interval = (int) nudLowerFrameDuration.Value;
                nudLowerLoopCount.Value = mEditorItem.Lower.LoopCount;

                cmbUpperGraphic.SelectedIndex =
                    cmbUpperGraphic.FindString(TextUtils.NullToNone(mEditorItem.Upper.Sprite));

                nudUpperHorizontalFrames.Value = mEditorItem.Upper.XFrames;
                nudUpperVerticalFrames.Value = mEditorItem.Upper.YFrames;
                nudUpperFrameCount.Value = mEditorItem.Upper.FrameCount;
                UpdateUpperFrames();

                nudUpperFrameDuration.Value = mEditorItem.Upper.FrameSpeed;
                tmrUpperAnimation.Interval = (int) nudUpperFrameDuration.Value;
                nudUpperLoopCount.Value = mEditorItem.Upper.LoopCount;

                chkDisableLowerRotations.Checked = mEditorItem.Lower.DisableRotations;
                chkDisableUpperRotations.Checked = mEditorItem.Upper.DisableRotations;

                chkRenderAbovePlayer.Checked = mEditorItem.Lower.AlternateRenderLayer;
                chkRenderBelowFringe.Checked = mEditorItem.Upper.AlternateRenderLayer;

                LoadLowerLight();
                DrawLowerFrame();
                LoadUpperLight();
                DrawUpperFrame();

                lstScreenEffects.Items.Clear();
                for (var i = 0; i < mEditorItem.ScreenEffects.Count; i++)
                {
                    if (mEditorItem.ScreenEffects[i].Opacities == null)
                    {
                        mEditorItem.ScreenEffects[i].Opacities = new byte[(int)ScreenEffectState.StateCount];
                    }
                    if (mEditorItem.ScreenEffects[i].Durations == null)
                    {
                        mEditorItem.ScreenEffects[i].Durations = new int[(int)ScreenEffectState.StateCount];
                    }
                    if (mEditorItem.ScreenEffects[i].Frames == null)
                    {
                        mEditorItem.ScreenEffects[i].Frames = new int[(int)ScreenEffectState.StateCount - 1];
                    }
                    var data = mEditorItem.ScreenEffects[i].EffectType == ScreenEffectType.Shake ?
                        Strings.AnimationEditor.shakeformat.ToString(mEditorItem.ScreenEffects[i].Size):
                        mEditorItem.ScreenEffects[i].Data;
                    lstScreenEffects.Items.Add(Strings.AnimationEditor.screeneffectformat.ToString(
                        Strings.AnimationEditor.screeneffecttypes[(int)mEditorItem.ScreenEffects[i].EffectType], data
                    ));
                }
                if (lstScreenEffects.Items.Count > 0)
                {
                    lstScreenEffects.SelectedIndex = 0;
                }
                else
                {
                    cmbEffectType.SelectedIndex = 0;
                    cmbSize.SelectedIndex = 0;
                    chkOverGUI.Checked = true;
                }

                if (mChanged.IndexOf(mEditorItem) == -1)
                {
                    mChanged.Add(mEditorItem);
                    mEditorItem.MakeBackup();
                }
            }
            else
            {
                pnlContainer.Hide();
                grpCommentary.Hide();
            }

            UpdateToolStripItems();
        }

        private void lstScreenEffects_Refresh()
        {
            var n = lstScreenEffects.SelectedIndex;
            lstScreenEffects.Items.Clear();
            for (var i = 0; i < mEditorItem.ScreenEffects.Count; i++)
            {
                var data = mEditorItem.ScreenEffects[i].EffectType == ScreenEffectType.Shake ?
                                        Strings.AnimationEditor.shakeformat.ToString(mEditorItem.ScreenEffects[i].Size) :
                                        mEditorItem.ScreenEffects[i].Data;
                lstScreenEffects.Items.Add(Strings.AnimationEditor.screeneffectformat.ToString(
                    Strings.AnimationEditor.screeneffecttypes[(int)mEditorItem.ScreenEffects[i].EffectType], data
                ));
            }
            lstScreenEffects.SelectedIndex = n;
        }

        private void UpdateScreenEffect(ScreenEffectBase screeneffect)
        {
            switch (screeneffect.EffectType)
            {
                case ScreenEffectType.ColorTransition:
                    var color = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                    screeneffect.Data = Color.ToString(color);
                    screeneffect.Size = cmbSize.SelectedIndex;
                    screeneffect.Opacities[(int)ScreenEffectState.Begin] = (byte)nudOpacityBegin.Value;
                    screeneffect.Opacities[(int)ScreenEffectState.Pending] = (byte)nudOpacityPending.Value;
                    screeneffect.Opacities[(int)ScreenEffectState.End] = (byte)nudOpacityEnd.Value;
                    screeneffect.Durations[(int)ScreenEffectState.Begin] = (int)nudDurationBegin.Value;
                    screeneffect.Durations[(int)ScreenEffectState.Pending] = (int)nudDurationPending.Value;
                    screeneffect.Durations[(int)ScreenEffectState.End] = (int)nudDurationEnd.Value;
                    screeneffect.Frames[0] = (int)nudFramesBegin.Value;
                    screeneffect.Frames[1] = (int)nudFramesEnd.Value;
                    break;

                case ScreenEffectType.PictureTransition:
                    screeneffect.Data = cmbPicture.Text;
                    screeneffect.Size = cmbSize.SelectedIndex;
                    screeneffect.Opacities[(int)ScreenEffectState.Begin] = (byte)nudOpacityBegin.Value;
                    screeneffect.Opacities[(int)ScreenEffectState.Pending] = (byte)nudOpacityPending.Value;
                    screeneffect.Opacities[(int)ScreenEffectState.End] = (byte)nudOpacityEnd.Value;
                    screeneffect.Durations[(int)ScreenEffectState.Begin] = (int)nudDurationBegin.Value;
                    screeneffect.Durations[(int)ScreenEffectState.Pending] = (int)nudDurationPending.Value;
                    screeneffect.Durations[(int)ScreenEffectState.End] = (int)nudDurationEnd.Value;
                    screeneffect.Frames[0] = (int)nudFramesBegin.Value;
                    screeneffect.Frames[1] = (int)nudFramesEnd.Value;
                    break;

                case ScreenEffectType.Shake:
                    screeneffect.Data = "";
                    screeneffect.Size = (int)nudIntensity.Value;
                    screeneffect.Opacities[(int)ScreenEffectState.Begin] = 0;
                    screeneffect.Opacities[(int)ScreenEffectState.Pending] = 0;
                    screeneffect.Opacities[(int)ScreenEffectState.End] = 0;
                    screeneffect.Durations[(int)ScreenEffectState.Begin] = (int)nudShakeDuration.Value;
                    screeneffect.Durations[(int)ScreenEffectState.Pending] = (int)nudShakeDuration.Value;
                    screeneffect.Durations[(int)ScreenEffectState.End] = (int)nudShakeDuration.Value;
                    screeneffect.Frames[0] = 0;
                    screeneffect.Frames[1] = 0;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var screeneffect = new ScreenEffectBase();
            screeneffect.EffectType = (ScreenEffectType)cmbEffectType.SelectedIndex;
            screeneffect.OverGUI = chkOverGUI.Checked;
            UpdateScreenEffect(screeneffect);
            
            mEditorItem.ScreenEffects.Add(screeneffect);
            lstScreenEffects_Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1)
            {
                var i = lstScreenEffects.SelectedIndex;
                lstScreenEffects.Items.RemoveAt(i);
                mEditorItem.ScreenEffects.RemoveAt(i);
            }
        }

        private void lstScreenEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1)
            {
                UpdateScreenEffectsFields(mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex]);
            }
        }

        private void cmbEffectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScreenEffectsFields();
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].EffectType = (ScreenEffectType)cmbEffectType.SelectedIndex;
                UpdateScreenEffect(mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex]);
            }
            lstScreenEffects_Refresh();
        }

        private void UpdateScreenEffectsFields(ScreenEffectBase screeneffectValues = null)
        {
            lblColor.Hide();
            pnlColor.Hide();
            btnSelectColor.Hide();
            lblPicture.Hide();
            cmbPicture.Hide();
            cmbSize.Hide();
            grpTransition.Hide();
            grpShake.Hide();

            ScreenEffectType screenEffectType = screeneffectValues == null ? (ScreenEffectType)cmbEffectType.SelectedIndex : screeneffectValues.EffectType;

            switch (screenEffectType)
            {
                case ScreenEffectType.ColorTransition:
                    lblColor.Show();
                    pnlColor.Show();
                    btnSelectColor.Show();
                    cmbSize.Show();
                    grpTransition.Show();
                    chkOverGUI.Enabled = true;
                    if (screeneffectValues != null)
                    {
                        var color = Color.FromString(screeneffectValues.Data, Color.Black);
                        pnlColor.BackColor = System.Drawing.Color.FromArgb(
                            color.A, color.R, color.G, color.B
                        );
                        colorDialog.Color = pnlColor.BackColor;
                        if (screeneffectValues.Size > -1 && screeneffectValues.Size < cmbSize.Items.Count)
                        {
                            cmbSize.SelectedIndex = screeneffectValues.Size;
                        }
                        else
                        {
                            cmbSize.SelectedIndex = 0;
                        }
                        cmbPicture.SelectedIndex = 0;
                        nudOpacityBegin.Value = screeneffectValues.Opacities[(int)ScreenEffectState.Begin];
                        nudOpacityPending.Value = screeneffectValues.Opacities[(int)ScreenEffectState.Pending];
                        nudOpacityEnd.Value = screeneffectValues.Opacities[(int)ScreenEffectState.End];
                        nudDurationBegin.Value = screeneffectValues.Durations[(int)ScreenEffectState.Begin];
                        nudDurationPending.Value = screeneffectValues.Durations[(int)ScreenEffectState.Pending];
                        nudDurationEnd.Value = screeneffectValues.Durations[(int)ScreenEffectState.End];
                        nudFramesBegin.Value = screeneffectValues.Frames[0];
                        nudFramesEnd.Value = screeneffectValues.Frames[1];
                    }
                    break;

                case ScreenEffectType.PictureTransition:
                    lblPicture.Show();
                    cmbPicture.Show();
                    cmbSize.Show();
                    grpTransition.Show();
                    chkOverGUI.Enabled = true;
                    if (screeneffectValues != null)
                    {
                        if (screeneffectValues.Data != null && cmbPicture.Items.IndexOf(screeneffectValues.Data) > -1)
                        {
                            cmbPicture.SelectedIndex = cmbPicture.Items.IndexOf(screeneffectValues.Data);
                        }
                        else
                        {
                            if (cmbPicture.Items.Count > 0)
                            {
                                cmbPicture.SelectedIndex = 0;
                            }
                        }
                        if (screeneffectValues.Size > -1 && screeneffectValues.Size < cmbSize.Items.Count)
                        {
                            cmbSize.SelectedIndex = screeneffectValues.Size;
                        }
                        else
                        {
                            cmbSize.SelectedIndex = 0;
                        }
                        nudOpacityBegin.Value = screeneffectValues.Opacities[(int)ScreenEffectState.Begin];
                        nudOpacityPending.Value = screeneffectValues.Opacities[(int)ScreenEffectState.Pending];
                        nudOpacityEnd.Value = screeneffectValues.Opacities[(int)ScreenEffectState.End];
                        nudDurationBegin.Value = screeneffectValues.Durations[(int)ScreenEffectState.Begin];
                        nudDurationPending.Value = screeneffectValues.Durations[(int)ScreenEffectState.Pending];
                        nudDurationEnd.Value = screeneffectValues.Durations[(int)ScreenEffectState.End];
                        nudFramesBegin.Value = screeneffectValues.Frames[0];
                        nudFramesEnd.Value = screeneffectValues.Frames[1];
                    }  
                    break;

                case ScreenEffectType.Shake:
                    grpShake.Show();
                    chkOverGUI.Checked = true;
                    chkOverGUI.Enabled = false;
                    if (screeneffectValues != null)
                    {
                        nudShakeDuration.Value = screeneffectValues.Durations[(int)ScreenEffectState.Pending];
                        nudIntensity.Value = screeneffectValues.Size;
                        cmbSize.SelectedIndex = 0;
                        cmbPicture.SelectedIndex = 0;
                    }      
                    break;
            }
            if (screeneffectValues != null)
            {
                cmbEffectType.SelectedIndex = (int)screeneffectValues.EffectType;
                chkOverGUI.Checked = screeneffectValues.OverGUI;
            }
        }

        private void nudOpacityBegin_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Opacities[(int)ScreenEffectState.Begin] = (byte)nudOpacityBegin.Value;
            }
        }

        private void nudOpacityPending_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Opacities[(int)ScreenEffectState.Pending] = (byte)nudOpacityPending.Value;
            }
        }

        private void nudOpacityEnd_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Opacities[(int)ScreenEffectState.End] = (byte)nudOpacityEnd.Value;
            }
        }

        private void nudDurationBegin_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Durations[(int)ScreenEffectState.Begin] = (int)nudDurationBegin.Value;
            }
        }

        private void nudDurationPending_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Durations[(int)ScreenEffectState.Pending] = (int)nudDurationPending.Value;
            }
        }

        private void nudDurationEnd_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Durations[(int)ScreenEffectState.End] = (int)nudDurationEnd.Value;
            }
        }

        private void nudFramesBegin_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Frames[0] = (int)nudFramesBegin.Value;
            }
        }

        private void nudFramesEnd_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Frames[1] = (int)nudFramesEnd.Value;
            }
        }

        private void nudShakeDuration_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count
                && mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].EffectType == ScreenEffectType.Shake)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Durations[(int)ScreenEffectState.Begin] = (int)nudShakeDuration.Value;
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Durations[(int)ScreenEffectState.Pending] = (int)nudShakeDuration.Value;
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Durations[(int)ScreenEffectState.End] = (int)nudShakeDuration.Value;
            }
        }

        private void nudIntensity_ValueChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count
                && mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].EffectType == ScreenEffectType.Shake)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Size = (int)nudIntensity.Value;
            }
        }

        private void chkOverGUI_CheckedChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].OverGUI = chkOverGUI.Checked;
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count
                && mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].EffectType != ScreenEffectType.Shake)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Size = cmbSize.SelectedIndex;
            }
        }

        private void cmbPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count
                && mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].EffectType == ScreenEffectType.PictureTransition)
            {
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Data = cmbPicture.Text;
            }
            lstScreenEffects_Refresh();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = System.Drawing.Color.White;
            colorDialog.ShowDialog();
            pnlColor.BackColor = colorDialog.Color;
            if (lstScreenEffects.SelectedIndex > -1 && lstScreenEffects.SelectedIndex < mEditorItem.ScreenEffects.Count
                && mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].EffectType == ScreenEffectType.ColorTransition)
            {
                var color = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                mEditorItem.ScreenEffects[lstScreenEffects.SelectedIndex].Data = Color.ToString(color);
            }
            lstScreenEffects_Refresh();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Name = txtName.Text;
            lstGameObjects.UpdateText(txtName.Text);
        }

        private void txtCommentary_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Comment = txtCommentary.Text;
        }

        private void cmbSound_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Sound = TextUtils.SanitizeNone(cmbSound?.Text);
        }

        private void chkCompleteSoundPlayback_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.CompleteSound = chkCompleteSoundPlayback.Checked;
        }

        private void cmbLowerGraphic_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.Sprite = TextUtils.SanitizeNone(cmbLowerGraphic?.Text);
        }

        private void cmbUpperGraphic_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.Sprite = TextUtils.SanitizeNone(cmbUpperGraphic?.Text);
        }

        private void tmrLowerAnimation_Tick(object sender, EventArgs e)
        {
            if (mPlayLower)
            {
                mLowerFrame++;
                if (mLowerFrame >= (int) nudLowerFrameCount.Value)
                {
                    mLowerFrame = 0;
                }
            }
        }

        void UpdateLowerFrames()
        {
            LightBase[] newArray;
            scrlLowerFrame.Maximum = (int) nudLowerFrameCount.Value;
            if (mEditorItem.Lower.Lights == null || mEditorItem.Lower.FrameCount != mEditorItem.Lower.Lights.Length)
            {
                newArray = new LightBase[mEditorItem.Lower.FrameCount];
                for (var i = 0; i < newArray.Length; i++)
                {
                    if (mEditorItem.Lower.Lights != null && i < mEditorItem.Lower.Lights.Length)
                    {
                        newArray[i] = mEditorItem.Lower.Lights[i];
                    }
                    else
                    {
                        newArray[i] = new LightBase(-1, -1);
                    }
                }

                mEditorItem.Lower.Lights = newArray;
            }
        }

        void UpdateUpperFrames()
        {
            LightBase[] newArray;
            scrlUpperFrame.Maximum = (int) nudUpperFrameCount.Value;
            if (mEditorItem.Upper.Lights == null || mEditorItem.Upper.FrameCount != mEditorItem.Upper.Lights.Length)
            {
                newArray = new LightBase[mEditorItem.Upper.FrameCount];
                for (var i = 0; i < newArray.Length; i++)
                {
                    if (mEditorItem.Upper.Lights != null && i < mEditorItem.Upper.Lights.Length)
                    {
                        newArray[i] = mEditorItem.Upper.Lights[i];
                    }
                    else
                    {
                        newArray[i] = new LightBase(-1, -1);
                    }
                }

                mEditorItem.Upper.Lights = newArray;
            }
        }

        void DrawLowerFrame()
        {
            if (mLowerWindow == null || mEditorItem == null)
            {
                return;
            }

            if (!mPlayLower)
            {
                mLowerFrame = scrlLowerFrame.Value - 1;
            }

            var graphicsDevice = Core.Graphics.GetGraphicsDevice();
            Core.Graphics.EndSpriteBatch();
            graphicsDevice.SetRenderTarget(mLowerDarkness);
            graphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);
            if (mLowerFrame < mEditorItem.Lower.Lights.Length)
            {
                Core.Graphics.DrawLight(
                    picLowerAnimation.Width / 2 + mEditorItem.Lower.Lights[mLowerFrame].OffsetX,
                    picLowerAnimation.Height / 2 + mEditorItem.Lower.Lights[mLowerFrame].OffsetY,
                    mEditorItem.Lower.Lights[mLowerFrame], mLowerDarkness
                );
            }

            Core.Graphics.DrawTexture(
                Core.Graphics.GetWhiteTex(), new RectangleF(0, 0, 1, 1),
                new RectangleF(0, 0, mLowerDarkness.Width, mLowerDarkness.Height),
                System.Drawing.Color.FromArgb((byte) ((float) (100 - scrlDarkness.Value) / 100f * 255), 255, 255, 255),
                mLowerDarkness, BlendState.Additive
            );

            Core.Graphics.EndSpriteBatch();
            graphicsDevice.SetRenderTarget(mLowerWindow);
            graphicsDevice.Clear(Microsoft.Xna.Framework.Color.White);
            var animTexture = GameContentManager.GetTexture(
                GameContentManager.TextureType.Animation, cmbLowerGraphic.Text
            );

            if (animTexture != null)
            {
                long w = animTexture.Width / (int) nudLowerHorizontalFrames.Value;
                long h = animTexture.Height / (int) nudLowerVerticalFrames.Value;
                long x = 0;
                if (mLowerFrame > 0)
                {
                    x = mLowerFrame % (int) nudLowerHorizontalFrames.Value * w;
                }

                var y = (int) Math.Floor(mLowerFrame / nudLowerHorizontalFrames.Value) * h;
                Core.Graphics.DrawTexture(
                    animTexture, new RectangleF(x, y, w, h),
                    new RectangleF(
                        picLowerAnimation.Width / 2 - (int) w / 2, (int) picLowerAnimation.Height / 2 - (int) h / 2, w,
                        h
                    ), mLowerWindow
                );
            }

            Core.Graphics.DrawTexture(mLowerDarkness, 0, 0, mLowerWindow, Core.Graphics.MultiplyState);
            Core.Graphics.EndSpriteBatch();
            mLowerWindow.Present();
        }

        void DrawUpperFrame()
        {
            if (mUpperWindow == null || mEditorItem == null)
            {
                return;
            }

            if (!mPlayUpper)
            {
                mUpperFrame = scrlUpperFrame.Value - 1;
            }

            var graphicsDevice = Core.Graphics.GetGraphicsDevice();
            Core.Graphics.EndSpriteBatch();
            graphicsDevice.SetRenderTarget(mUpperDarkness);
            graphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);
            if (mUpperFrame < mEditorItem.Upper.Lights.Length)
            {
                Core.Graphics.DrawLight(
                    picUpperAnimation.Width / 2 + mEditorItem.Upper.Lights[mUpperFrame].OffsetX,
                    picUpperAnimation.Height / 2 + mEditorItem.Upper.Lights[mUpperFrame].OffsetY,
                    mEditorItem.Upper.Lights[mUpperFrame], mUpperDarkness
                );
            }

            Core.Graphics.DrawTexture(
                Core.Graphics.GetWhiteTex(), new RectangleF(0, 0, 1, 1),
                new RectangleF(0, 0, mUpperDarkness.Width, mUpperDarkness.Height),
                System.Drawing.Color.FromArgb((byte) ((float) (100 - scrlDarkness.Value) / 100f * 255), 255, 255, 255),
                mUpperDarkness, BlendState.Additive
            );

            Core.Graphics.EndSpriteBatch();
            graphicsDevice.SetRenderTarget(mUpperWindow);
            graphicsDevice.Clear(Microsoft.Xna.Framework.Color.White);
            var animTexture = GameContentManager.GetTexture(
                GameContentManager.TextureType.Animation, cmbUpperGraphic.Text
            );

            if (animTexture != null)
            {
                long w = animTexture.Width / (int) nudUpperHorizontalFrames.Value;
                long h = animTexture.Height / (int) nudUpperVerticalFrames.Value;
                long x = 0;
                if (mUpperFrame > 0)
                {
                    x = mUpperFrame % (int) nudUpperHorizontalFrames.Value * w;
                }

                var y = (int) Math.Floor(mUpperFrame / nudUpperHorizontalFrames.Value) * h;
                Core.Graphics.DrawTexture(
                    animTexture, new RectangleF(x, y, w, h),
                    new RectangleF(
                        picUpperAnimation.Width / 2 - (int) w / 2, (int) picUpperAnimation.Height / 2 - (int) h / 2, w,
                        h
                    ), mUpperWindow
                );
            }

            Core.Graphics.DrawTexture(mUpperDarkness, 0, 0, mUpperWindow, Core.Graphics.MultiplyState);
            Core.Graphics.EndSpriteBatch();
            mUpperWindow.Present();
        }

        private void tmrUpperAnimation_Tick(object sender, EventArgs e)
        {
            if (mPlayUpper)
            {
                mUpperFrame++;
                if (mUpperFrame >= (int) nudUpperFrameCount.Value)
                {
                    mUpperFrame = 0;
                }
            }
        }

        private void frmAnimation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CurrentEditor = -1;
        }

        private void scrlLowerFrame_Scroll(object sender, ScrollValueEventArgs e)
        {
            lblLowerFrame.Text = Strings.AnimationEditor.lowerframe.ToString(scrlLowerFrame.Value);
            LoadLowerLight();
            DrawLowerFrame();
        }

        private void LoadLowerLight()
        {
            lightEditorLower.CanClose = false;
            lightEditorLower.LoadEditor(mEditorItem.Lower.Lights[scrlLowerFrame.Value - 1]);
        }

        private void LoadUpperLight()
        {
            lightEditorUpper.CanClose = false;
            lightEditorUpper.LoadEditor(mEditorItem.Upper.Lights[scrlUpperFrame.Value - 1]);
        }

        private void scrlUpperFrame_Scroll(object sender, ScrollValueEventArgs e)
        {
            lblUpperFrame.Text = Strings.AnimationEditor.upperframe.ToString(scrlUpperFrame.Value);
            LoadUpperLight();
            DrawUpperFrame();
        }

        private void btnPlayLower_Click(object sender, EventArgs e)
        {
            mPlayLower = !mPlayLower;
            if (mPlayLower)
            {
                btnPlayLower.Text = Strings.AnimationEditor.lowerstop;
            }
            else
            {
                btnPlayLower.Text = Strings.AnimationEditor.lowerplay;
            }
        }

        private void btnLowerClone_Click(object sender, EventArgs e)
        {
            if (scrlLowerFrame.Value > 1)
            {
                mEditorItem.Lower.Lights[scrlLowerFrame.Value - 1] =
                    new LightBase(mEditorItem.Lower.Lights[scrlLowerFrame.Value - 2]);

                LoadLowerLight();
                DrawLowerFrame();
            }
        }

        private void btnPlayUpper_Click(object sender, EventArgs e)
        {
            mPlayUpper = !mPlayUpper;
            if (mPlayUpper)
            {
                btnPlayUpper.Text = Strings.AnimationEditor.upperstop;
            }
            else
            {
                btnPlayUpper.Text = Strings.AnimationEditor.upperplay;
            }
        }

        private void btnUpperClone_Click(object sender, EventArgs e)
        {
            if (scrlUpperFrame.Value > 1)
            {
                mEditorItem.Upper.Lights[scrlUpperFrame.Value - 1] =
                    new LightBase(mEditorItem.Upper.Lights[scrlUpperFrame.Value - 2]);

                LoadUpperLight();
                DrawUpperFrame();
            }
        }

        private void scrlDarkness_Scroll(object sender, ScrollValueEventArgs e)
        {
            labelDarkness.Text = Strings.AnimationEditor.simulatedarkness.ToString(scrlDarkness.Value);
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            var lowerAnimSprite = mEditorItem.Lower.Sprite;
            var lowerAnimXFrames = mEditorItem.Lower.XFrames;
            var lowerAnimYFrames = mEditorItem.Lower.YFrames;
            var lowerAnimFrameCount = mEditorItem.Lower.FrameCount;
            var lowerAnimFrameSpeed = mEditorItem.Lower.FrameSpeed;
            var lowerAnimLoopCount = mEditorItem.Lower.LoopCount;
            var disableLowerRotations = mEditorItem.Lower.DisableRotations;
            var lowerLights = mEditorItem.Lower.Lights;
            mEditorItem.Lower.Sprite = mEditorItem.Upper.Sprite;
            mEditorItem.Lower.XFrames = mEditorItem.Upper.XFrames;
            mEditorItem.Lower.YFrames = mEditorItem.Upper.YFrames;
            mEditorItem.Lower.FrameCount = mEditorItem.Upper.FrameCount;
            mEditorItem.Lower.FrameSpeed = mEditorItem.Upper.FrameSpeed;
            mEditorItem.Lower.LoopCount = mEditorItem.Upper.LoopCount;
            mEditorItem.Lower.Lights = mEditorItem.Upper.Lights;
            mEditorItem.Lower.DisableRotations = mEditorItem.Upper.DisableRotations;

            mEditorItem.Upper.Sprite = lowerAnimSprite;
            mEditorItem.Upper.XFrames = lowerAnimXFrames;
            mEditorItem.Upper.YFrames = lowerAnimYFrames;
            mEditorItem.Upper.FrameCount = lowerAnimFrameCount;
            mEditorItem.Upper.FrameSpeed = lowerAnimFrameSpeed;
            mEditorItem.Upper.LoopCount = lowerAnimLoopCount;
            mEditorItem.Upper.Lights = lowerLights;
            mEditorItem.Upper.DisableRotations = disableLowerRotations;

            mUpperFrame = 0;
            mLowerFrame = 0;

            UpdateEditor();
        }

        private void toolStripItemNew_Click(object sender, EventArgs e)
        {
            PacketSender.SendCreateObject(GameObjectType.Animation);
        }

        private void toolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstGameObjects.Focused)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.AnimationEditor.deleteprompt, Strings.AnimationEditor.deletetitle,
                        DarkDialogButton.YesNo, Properties.Resources.Icon
                    ) ==
                    DialogResult.Yes)
                {
                    PacketSender.SendDeleteObject(mEditorItem);
                }
            }
        }

        private void toolStripItemCopy_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstGameObjects.Focused)
            {
                mCopiedItem = mEditorItem.JsonData;
                toolStripItemPaste.Enabled = true;
            }
        }

        private void toolStripItemPaste_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && mCopiedItem != null && lstGameObjects.Focused)
            {
                mEditorItem.Load(mCopiedItem, true);
                UpdateEditor();
            }
        }

        private void toolStripItemUndo_Click(object sender, EventArgs e)
        {
            if (mChanged.Contains(mEditorItem) && mEditorItem != null)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.AnimationEditor.undoprompt, Strings.AnimationEditor.undotitle, DarkDialogButton.YesNo,
                        Properties.Resources.Icon
                    ) ==
                    DialogResult.Yes)
                {
                    mEditorItem.RestoreBackup();
                    UpdateEditor();
                }
            }
        }

        private void toolStripItemRelations_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null)
            {
                Dictionary<string, List<string>> dataDict = new Dictionary<string, List<string>>();

                //Retrieve all npcs using the animation (attack animation)
                var npcList = NpcBase.Lookup.Where(pair => ((NpcBase)pair.Value)?.AttackAnimationId == mEditorItem.Id)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => TextUtils.FormatEditorName(pair.Value?.Name, ((NpcBase)pair.Value)?.EditorName) ?? NpcBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.npcs, npcList);

                //Retrieve all classes using the animation (attack animation)
                var classList = ClassBase.Lookup.Where(pair => ((ClassBase)pair.Value)?.AttackAnimationId == mEditorItem.Id)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => pair.Value?.Name ?? ClassBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.classes, classList);

                //Retrieve all spells using the animation 
                var spellList = SpellBase.Lookup.Where(pair => ((SpellBase)pair.Value)?.CastAnimationId == mEditorItem.Id
                    || ((SpellBase)pair.Value)?.CastTargetAnimationId == mEditorItem.Id
                    || ((SpellBase)pair.Value)?.HitAnimationId == mEditorItem.Id
                    || ((SpellBase)pair.Value)?.ImpactAnimationId == mEditorItem.Id
                    || ((SpellBase)pair.Value)?.TilesAnimationId == mEditorItem.Id)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => TextUtils.FormatEditorName(pair.Value?.Name, ((SpellBase)pair.Value)?.EditorName) ?? SpellBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.spells, spellList);

                //Retrieve all projectiles using the animation
                var projList = ProjectileBase.Lookup.Where(pair => ((ProjectileBase)pair.Value)?.Animations?.Any(a => a?.AnimationId == mEditorItem.Id) ?? false)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => pair.Value?.Name ?? ProjectileBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.projectiles, projList);

                //Retrieve all items using the animation
                var itemList = ItemBase.Lookup.Where(pair => ((ItemBase)pair.Value)?.AnimationId == mEditorItem.Id
                    || ((ItemBase)pair.Value)?.AttackAnimationId == mEditorItem.Id
                    || ((ItemBase)pair.Value)?.EquipmentAnimationId == mEditorItem.Id)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => TextUtils.FormatEditorName(pair.Value?.Name, ((ItemBase)pair.Value)?.EditorName) ?? ItemBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.items, itemList);

                //Retrieve all maps using the animation (weather or in a tile)
                var mapList = MapBase.Lookup.Where(pair => ((MapBase)pair.Value)?.WeatherAnimationId == mEditorItem.Id
                || IsAnimationInMap(mEditorItem.Id, (MapBase)pair.Value))
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => pair.Value?.Name ?? MapBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.maps, mapList);

                //Retrieve all resources using the animation
                var resourceList = ResourceBase.Lookup.Where(pair => ((ResourceBase)pair.Value)?.AnimationId == mEditorItem.Id)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => pair.Value?.Name ?? ResourceBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.resources, resourceList);

                string titleTarget = "Animation : " + mEditorItem.Name;
                var relationsfrm = new FrmRelations(titleTarget, dataDict);
                relationsfrm.ShowDialog();
            }
        }

        private bool IsAnimationInMap(Guid animationId, MapBase mapBase)
        {
            foreach (var attribute in mapBase?.Attributes)
            {
                if (attribute?.Type == MapAttributes.Animation && (attribute as MapAnimationAttribute).AnimationId == animationId)
                {
                    return true;
                }
            }
            return false;
        }
        private void UpdateToolStripItems()
        {
            toolStripItemCopy.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemPaste.Enabled = mEditorItem != null && mCopiedItem != null && lstGameObjects.Focused;
            toolStripItemDelete.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemUndo.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemRelations.Enabled = mEditorItem != null;
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    toolStripItemNew_Click(null, null);
                }
            }
        }

        private void CheckFrameCounts()
        {
            nudLowerFrameCount.Value = Math.Min(mEditorItem.Lower.FrameCount, mEditorItem.Lower.XFrames * mEditorItem.Lower.YFrames);
            nudUpperFrameCount.Value = Math.Min(mEditorItem.Upper.FrameCount, mEditorItem.Upper.XFrames * mEditorItem.Upper.YFrames);
        }

        private void nudLowerHorizontalFrames_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.XFrames = (int) nudLowerHorizontalFrames.Value;
            CheckFrameCounts();
        }

        private void nudLowerVerticalFrames_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.YFrames = (int) nudLowerVerticalFrames.Value;
            CheckFrameCounts();
        }

        private void nudLowerFrameCount_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.FrameCount = (int) nudLowerFrameCount.Value;
            CheckFrameCounts();
            UpdateLowerFrames();
        }

        private void nudLowerFrameDuration_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.FrameSpeed = (int) nudLowerFrameDuration.Value;
            tmrLowerAnimation.Interval = (int) nudLowerFrameDuration.Value;
        }

        private void nudLowerLoopCount_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.LoopCount = (int) nudLowerLoopCount.Value;
        }

        private void nudUpperHorizontalFrames_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.XFrames = (int) nudUpperHorizontalFrames.Value;
            CheckFrameCounts();
        }

        private void nudUpperVerticalFrames_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.YFrames = (int) nudUpperVerticalFrames.Value;
            CheckFrameCounts();
        }

        private void nudUpperFrameCount_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.FrameCount = (int) nudUpperFrameCount.Value;
            CheckFrameCounts();
            UpdateUpperFrames();
        }

        private void nudUpperFrameDuration_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.FrameSpeed = (int) nudUpperFrameDuration.Value;
            tmrUpperAnimation.Interval = (int) nudUpperFrameDuration.Value;
        }

        private void nudUpperLoopCount_ValueChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.LoopCount = (int) nudUpperLoopCount.Value;
        }

        private void tmrRender_Tick(object sender, EventArgs e)
        {
            DrawLowerFrame();
            DrawUpperFrame();
        }

        private void chkDisableLowerRotations_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.DisableRotations = chkDisableLowerRotations.Checked;
        }

        private void chkDisableUpperRotations_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.DisableRotations = chkDisableUpperRotations.Checked;
        }

        private void chkRenderAbovePlayer_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.Lower.AlternateRenderLayer = chkRenderAbovePlayer.Checked;
        }

        private void chkRenderBelowFringe_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.Upper.AlternateRenderLayer = chkRenderBelowFringe.Checked;
        }

        #region "Item List - Folders, Searching, Sorting, Etc"

        public void InitEditor()
        {
            //Collect folders
            var mFolders = new List<string>();
            foreach (var anim in AnimationBase.Lookup)
            {
                if (!string.IsNullOrEmpty(((AnimationBase)anim.Value).Folder) &&
                    !mFolders.Contains(((AnimationBase)anim.Value).Folder))
                {
                    mFolders.Add(((AnimationBase)anim.Value).Folder);
                    if (!mKnownFolders.Contains(((AnimationBase)anim.Value).Folder))
                    {
                        mKnownFolders.Add(((AnimationBase)anim.Value).Folder);
                    }
                }
            }

            mFolders.Sort();
            mKnownFolders.Sort();
            cmbFolder.Items.Clear();
            cmbFolder.Items.Add("");
            cmbFolder.Items.AddRange(mKnownFolders.ToArray());

            var items = AnimationBase.Lookup.OrderBy(p => p.Value?.Name).Select(pair => new KeyValuePair<Guid, KeyValuePair<string, string>>(pair.Key, 
                new KeyValuePair<string, string>(((AnimationBase)pair.Value)?.Name ?? Models.DatabaseObject<AnimationBase>.Deleted, ((AnimationBase)pair.Value)?.Folder ?? ""))).ToArray();
            lstGameObjects.Repopulate(items, mFolders, btnAlphabetical.Checked, CustomSearch(), txtSearch.Text);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var folderName = "";
            var result = DarkInputBox.ShowInformation(
                Strings.AnimationEditor.folderprompt, Strings.AnimationEditor.foldertitle, ref folderName,
                DarkDialogButton.OkCancel
            );

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderName))
            {
                if (!cmbFolder.Items.Contains(folderName))
                {
                    mEditorItem.Folder = folderName;
                    lstGameObjects.ExpandFolder(folderName);
                    InitEditor();
                    cmbFolder.Text = folderName;
                }
            }
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Folder = cmbFolder.Text;
            InitEditor();
        }

        private void btnAlphabetical_Click(object sender, EventArgs e)
        {
            btnAlphabetical.Checked = !btnAlphabetical.Checked;
            InitEditor();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            InitEditor();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = Strings.AnimationEditor.searchplaceholder;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = Strings.AnimationEditor.searchplaceholder;
        }

        private bool CustomSearch()
        {
            return !string.IsNullOrWhiteSpace(txtSearch.Text) &&
                   txtSearch.Text != Strings.AnimationEditor.searchplaceholder;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == Strings.AnimationEditor.searchplaceholder)
            {
                txtSearch.SelectAll();
            }
        }

        #endregion

    }

}
