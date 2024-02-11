using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmAnimation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimation));
            this.grpAnimations = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstGameObjects = new Intersect.Editor.Forms.Controls.GameObjectList();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.txtId = new DarkUI.Controls.DarkTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.chkCompleteSoundPlayback = new DarkUI.Controls.DarkCheckBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.btnSwap = new DarkUI.Controls.DarkButton();
            this.scrlDarkness = new DarkUI.Controls.DarkScrollBar();
            this.labelDarkness = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.cmbSound = new DarkUI.Controls.DarkComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.grpLower = new DarkUI.Controls.DarkGroupBox();
            this.chkRenderAbovePlayer = new DarkUI.Controls.DarkCheckBox();
            this.chkDisableLowerRotations = new DarkUI.Controls.DarkCheckBox();
            this.nudLowerLoopCount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudLowerFrameDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.nudLowerFrameCount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudLowerVerticalFrames = new DarkUI.Controls.DarkNumericUpDown();
            this.nudLowerHorizontalFrames = new DarkUI.Controls.DarkNumericUpDown();
            this.grpLowerFrameOpts = new DarkUI.Controls.DarkGroupBox();
            this.btnLowerClone = new DarkUI.Controls.DarkButton();
            this.lightEditorLower = new Intersect.Editor.Forms.Controls.LightEditorCtrl();
            this.grpLowerPlayback = new DarkUI.Controls.DarkGroupBox();
            this.btnPlayLower = new DarkUI.Controls.DarkButton();
            this.scrlLowerFrame = new DarkUI.Controls.DarkScrollBar();
            this.lblLowerFrame = new System.Windows.Forms.Label();
            this.lblLowerLoopCount = new System.Windows.Forms.Label();
            this.lblLowerFrameDuration = new System.Windows.Forms.Label();
            this.lblLowerFrameCount = new System.Windows.Forms.Label();
            this.lblLowerVerticalFrames = new System.Windows.Forms.Label();
            this.lblLowerHorizontalFrames = new System.Windows.Forms.Label();
            this.cmbLowerGraphic = new DarkUI.Controls.DarkComboBox();
            this.lblLowerGraphic = new System.Windows.Forms.Label();
            this.picLowerAnimation = new System.Windows.Forms.PictureBox();
            this.grpUpper = new DarkUI.Controls.DarkGroupBox();
            this.chkRenderBelowFringe = new DarkUI.Controls.DarkCheckBox();
            this.chkDisableUpperRotations = new DarkUI.Controls.DarkCheckBox();
            this.nudUpperLoopCount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudUpperFrameDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.nudUpperFrameCount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudUpperVerticalFrames = new DarkUI.Controls.DarkNumericUpDown();
            this.nudUpperHorizontalFrames = new DarkUI.Controls.DarkNumericUpDown();
            this.grpUpperPlayback = new DarkUI.Controls.DarkGroupBox();
            this.btnPlayUpper = new DarkUI.Controls.DarkButton();
            this.scrlUpperFrame = new DarkUI.Controls.DarkScrollBar();
            this.lblUpperFrame = new System.Windows.Forms.Label();
            this.grpUpperFrameOpts = new DarkUI.Controls.DarkGroupBox();
            this.btnUpperClone = new DarkUI.Controls.DarkButton();
            this.lightEditorUpper = new Intersect.Editor.Forms.Controls.LightEditorCtrl();
            this.lblUpperLoopCount = new System.Windows.Forms.Label();
            this.lblUpperFrameDuration = new System.Windows.Forms.Label();
            this.lblUpperFrameCount = new System.Windows.Forms.Label();
            this.lblUpperVerticalFrames = new System.Windows.Forms.Label();
            this.lblUpperHorizontalFrames = new System.Windows.Forms.Label();
            this.cmbUpperGraphic = new DarkUI.Controls.DarkComboBox();
            this.lblUpperGraphic = new System.Windows.Forms.Label();
            this.picUpperAnimation = new System.Windows.Forms.PictureBox();
            this.tmrUpperAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrLowerAnimation = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpScreenEffects = new DarkUI.Controls.DarkGroupBox();
            this.lblInfoScreenEffects = new System.Windows.Forms.Label();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.chkOverGUI = new DarkUI.Controls.DarkCheckBox();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.cmbEffectType = new DarkUI.Controls.DarkComboBox();
            this.lstScreenEffects = new System.Windows.Forms.ListBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            this.grpShake = new DarkUI.Controls.DarkGroupBox();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.nudIntensity = new DarkUI.Controls.DarkNumericUpDown();
            this.nudShakeDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblShakeDuration = new System.Windows.Forms.Label();
            this.grpTransition = new DarkUI.Controls.DarkGroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.nudFramesEnd = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDurationEnd = new DarkUI.Controls.DarkNumericUpDown();
            this.nudOpacityEnd = new DarkUI.Controls.DarkNumericUpDown();
            this.btnSelectColor = new DarkUI.Controls.DarkButton();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblAutoframes = new System.Windows.Forms.Label();
            this.cmbSize = new DarkUI.Controls.DarkComboBox();
            this.nudFramesBegin = new DarkUI.Controls.DarkNumericUpDown();
            this.lblDurations = new System.Windows.Forms.Label();
            this.lblFrames = new System.Windows.Forms.Label();
            this.nudDurationBegin = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDurationPending = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPicture = new System.Windows.Forms.Label();
            this.cmbPicture = new DarkUI.Controls.DarkComboBox();
            this.nudOpacityPending = new DarkUI.Controls.DarkNumericUpDown();
            this.lblOpacities = new System.Windows.Forms.Label();
            this.nudOpacityBegin = new DarkUI.Controls.DarkNumericUpDown();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlphabetical = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemRelations = new System.Windows.Forms.ToolStripButton();
            this.tmrRender = new System.Windows.Forms.Timer(this.components);
            this.grpCommentary = new DarkUI.Controls.DarkGroupBox();
            this.txtCommentary = new DarkUI.Controls.DarkTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.grpAnimations.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpLower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerLoopCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerFrameDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerFrameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerVerticalFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerHorizontalFrames)).BeginInit();
            this.grpLowerFrameOpts.SuspendLayout();
            this.grpLowerPlayback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerAnimation)).BeginInit();
            this.grpUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperLoopCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperFrameDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperFrameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperVerticalFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperHorizontalFrames)).BeginInit();
            this.grpUpperPlayback.SuspendLayout();
            this.grpUpperFrameOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperAnimation)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.grpScreenEffects.SuspendLayout();
            this.grpShake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShakeDuration)).BeginInit();
            this.grpTransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityBegin)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.grpCommentary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAnimations
            // 
            this.grpAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAnimations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAnimations.Controls.Add(this.btnClearSearch);
            this.grpAnimations.Controls.Add(this.txtSearch);
            this.grpAnimations.Controls.Add(this.lstGameObjects);
            this.grpAnimations.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAnimations.Location = new System.Drawing.Point(3, 28);
            this.grpAnimations.Name = "grpAnimations";
            this.grpAnimations.Size = new System.Drawing.Size(203, 479);
            this.grpAnimations.TabIndex = 17;
            this.grpAnimations.TabStop = false;
            this.grpAnimations.Text = "Animations";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(179, 19);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearSearch.Size = new System.Drawing.Size(18, 20);
            this.btnClearSearch.TabIndex = 19;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lstGameObjects
            // 
            this.lstGameObjects.AllowDrop = true;
            this.lstGameObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstGameObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstGameObjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstGameObjects.HideSelection = false;
            this.lstGameObjects.ImageIndex = 0;
            this.lstGameObjects.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstGameObjects.Location = new System.Drawing.Point(6, 46);
            this.lstGameObjects.Name = "lstGameObjects";
            this.lstGameObjects.SelectedImageIndex = 0;
            this.lstGameObjects.Size = new System.Drawing.Size(191, 427);
            this.lstGameObjects.TabIndex = 2;
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.txtId);
            this.grpGeneral.Controls.Add(this.lblId);
            this.grpGeneral.Controls.Add(this.chkCompleteSoundPlayback);
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.btnSwap);
            this.grpGeneral.Controls.Add(this.scrlDarkness);
            this.grpGeneral.Controls.Add(this.labelDarkness);
            this.grpGeneral.Controls.Add(this.lblSound);
            this.grpGeneral.Controls.Add(this.cmbSound);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(1, 1);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(980, 76);
            this.grpGeneral.TabIndex = 18;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtId.Location = new System.Drawing.Point(666, 49);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(249, 21);
            this.txtId.TabIndex = 70;
            this.txtId.TabStop = false;
            this.txtId.Text = "guid-guid-guid-guid";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(643, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 69;
            this.lblId.Text = "Id:";
            // 
            // chkCompleteSoundPlayback
            // 
            this.chkCompleteSoundPlayback.Location = new System.Drawing.Point(221, 47);
            this.chkCompleteSoundPlayback.Name = "chkCompleteSoundPlayback";
            this.chkCompleteSoundPlayback.Size = new System.Drawing.Size(246, 17);
            this.chkCompleteSoundPlayback.TabIndex = 29;
            this.chkCompleteSoundPlayback.Text = "Complete Sound Playback After Anim Dies";
            this.chkCompleteSoundPlayback.CheckedChanged += new System.EventHandler(this.chkCompleteSoundPlayback_CheckedChanged);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(185, 45);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 17;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(5, 48);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 8;
            this.lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            this.cmbFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFolder.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFolder.DrawDropdownHoverOutline = false;
            this.cmbFolder.DrawFocusRectangle = false;
            this.cmbFolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.Location = new System.Drawing.Point(60, 45);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(119, 21);
            this.cmbFolder.TabIndex = 7;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(473, 43);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Padding = new System.Windows.Forms.Padding(5);
            this.btnSwap.Size = new System.Drawing.Size(158, 23);
            this.btnSwap.TabIndex = 6;
            this.btnSwap.Text = "Swap Upper/Lower";
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // scrlDarkness
            // 
            this.scrlDarkness.Location = new System.Drawing.Point(584, 19);
            this.scrlDarkness.Name = "scrlDarkness";
            this.scrlDarkness.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlDarkness.Size = new System.Drawing.Size(218, 17);
            this.scrlDarkness.TabIndex = 5;
            this.scrlDarkness.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlDarkness_Scroll);
            // 
            // labelDarkness
            // 
            this.labelDarkness.AutoSize = true;
            this.labelDarkness.Location = new System.Drawing.Point(470, 20);
            this.labelDarkness.Name = "labelDarkness";
            this.labelDarkness.Size = new System.Drawing.Size(107, 13);
            this.labelDarkness.TabIndex = 4;
            this.labelDarkness.Text = "Simulate Darkness: 0";
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(218, 21);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(41, 13);
            this.lblSound.TabIndex = 3;
            this.lblSound.Text = "Sound:";
            // 
            // cmbSound
            // 
            this.cmbSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSound.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSound.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSound.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSound.DrawDropdownHoverOutline = false;
            this.cmbSound.DrawFocusRectangle = false;
            this.cmbSound.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSound.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSound.FormattingEnabled = true;
            this.cmbSound.Items.AddRange(new object[] {
            "None"});
            this.cmbSound.Location = new System.Drawing.Point(265, 17);
            this.cmbSound.Name = "cmbSound";
            this.cmbSound.Size = new System.Drawing.Size(187, 21);
            this.cmbSound.TabIndex = 2;
            this.cmbSound.Text = "None";
            this.cmbSound.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSound.SelectedIndexChanged += new System.EventHandler(this.cmbSound_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(60, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpLower
            // 
            this.grpLower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpLower.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLower.Controls.Add(this.chkRenderAbovePlayer);
            this.grpLower.Controls.Add(this.chkDisableLowerRotations);
            this.grpLower.Controls.Add(this.nudLowerLoopCount);
            this.grpLower.Controls.Add(this.nudLowerFrameDuration);
            this.grpLower.Controls.Add(this.nudLowerFrameCount);
            this.grpLower.Controls.Add(this.nudLowerVerticalFrames);
            this.grpLower.Controls.Add(this.nudLowerHorizontalFrames);
            this.grpLower.Controls.Add(this.grpLowerFrameOpts);
            this.grpLower.Controls.Add(this.grpLowerPlayback);
            this.grpLower.Controls.Add(this.lblLowerLoopCount);
            this.grpLower.Controls.Add(this.lblLowerFrameDuration);
            this.grpLower.Controls.Add(this.lblLowerFrameCount);
            this.grpLower.Controls.Add(this.lblLowerVerticalFrames);
            this.grpLower.Controls.Add(this.lblLowerHorizontalFrames);
            this.grpLower.Controls.Add(this.cmbLowerGraphic);
            this.grpLower.Controls.Add(this.lblLowerGraphic);
            this.grpLower.Controls.Add(this.picLowerAnimation);
            this.grpLower.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLower.Location = new System.Drawing.Point(1, 84);
            this.grpLower.Name = "grpLower";
            this.grpLower.Size = new System.Drawing.Size(484, 425);
            this.grpLower.TabIndex = 19;
            this.grpLower.TabStop = false;
            this.grpLower.Text = "Lower Layer (Below Target)";
            // 
            // chkRenderAbovePlayer
            // 
            this.chkRenderAbovePlayer.AutoSize = true;
            this.chkRenderAbovePlayer.Location = new System.Drawing.Point(342, 400);
            this.chkRenderAbovePlayer.Name = "chkRenderAbovePlayer";
            this.chkRenderAbovePlayer.Size = new System.Drawing.Size(127, 17);
            this.chkRenderAbovePlayer.TabIndex = 27;
            this.chkRenderAbovePlayer.Text = "Render Above Player";
            this.chkRenderAbovePlayer.CheckedChanged += new System.EventHandler(this.chkRenderAbovePlayer_CheckedChanged);
            // 
            // chkDisableLowerRotations
            // 
            this.chkDisableLowerRotations.AutoSize = true;
            this.chkDisableLowerRotations.Location = new System.Drawing.Point(217, 400);
            this.chkDisableLowerRotations.Name = "chkDisableLowerRotations";
            this.chkDisableLowerRotations.Size = new System.Drawing.Size(109, 17);
            this.chkDisableLowerRotations.TabIndex = 26;
            this.chkDisableLowerRotations.Text = "Disable Rotations";
            this.chkDisableLowerRotations.CheckedChanged += new System.EventHandler(this.chkDisableLowerRotations_CheckedChanged);
            // 
            // nudLowerLoopCount
            // 
            this.nudLowerLoopCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLowerLoopCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLowerLoopCount.Location = new System.Drawing.Point(9, 398);
            this.nudLowerLoopCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudLowerLoopCount.Name = "nudLowerLoopCount";
            this.nudLowerLoopCount.Size = new System.Drawing.Size(194, 20);
            this.nudLowerLoopCount.TabIndex = 25;
            this.nudLowerLoopCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLowerLoopCount.ValueChanged += new System.EventHandler(this.nudLowerLoopCount_ValueChanged);
            // 
            // nudLowerFrameDuration
            // 
            this.nudLowerFrameDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLowerFrameDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLowerFrameDuration.Location = new System.Drawing.Point(10, 363);
            this.nudLowerFrameDuration.Maximum = new decimal(new int[] {
            -10,
            4,
            0,
            0});
            this.nudLowerFrameDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerFrameDuration.Name = "nudLowerFrameDuration";
            this.nudLowerFrameDuration.Size = new System.Drawing.Size(194, 20);
            this.nudLowerFrameDuration.TabIndex = 24;
            this.nudLowerFrameDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLowerFrameDuration.ValueChanged += new System.EventHandler(this.nudLowerFrameDuration_ValueChanged);
            // 
            // nudLowerFrameCount
            // 
            this.nudLowerFrameCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLowerFrameCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLowerFrameCount.Location = new System.Drawing.Point(10, 330);
            this.nudLowerFrameCount.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudLowerFrameCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerFrameCount.Name = "nudLowerFrameCount";
            this.nudLowerFrameCount.Size = new System.Drawing.Size(194, 20);
            this.nudLowerFrameCount.TabIndex = 23;
            this.nudLowerFrameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerFrameCount.ValueChanged += new System.EventHandler(this.nudLowerFrameCount_ValueChanged);
            // 
            // nudLowerVerticalFrames
            // 
            this.nudLowerVerticalFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLowerVerticalFrames.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLowerVerticalFrames.Location = new System.Drawing.Point(10, 296);
            this.nudLowerVerticalFrames.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudLowerVerticalFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerVerticalFrames.Name = "nudLowerVerticalFrames";
            this.nudLowerVerticalFrames.Size = new System.Drawing.Size(194, 20);
            this.nudLowerVerticalFrames.TabIndex = 22;
            this.nudLowerVerticalFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerVerticalFrames.ValueChanged += new System.EventHandler(this.nudLowerVerticalFrames_ValueChanged);
            // 
            // nudLowerHorizontalFrames
            // 
            this.nudLowerHorizontalFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLowerHorizontalFrames.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLowerHorizontalFrames.Location = new System.Drawing.Point(10, 260);
            this.nudLowerHorizontalFrames.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudLowerHorizontalFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerHorizontalFrames.Name = "nudLowerHorizontalFrames";
            this.nudLowerHorizontalFrames.Size = new System.Drawing.Size(194, 20);
            this.nudLowerHorizontalFrames.TabIndex = 21;
            this.nudLowerHorizontalFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerHorizontalFrames.ValueChanged += new System.EventHandler(this.nudLowerHorizontalFrames_ValueChanged);
            // 
            // grpLowerFrameOpts
            // 
            this.grpLowerFrameOpts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpLowerFrameOpts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLowerFrameOpts.Controls.Add(this.btnLowerClone);
            this.grpLowerFrameOpts.Controls.Add(this.lightEditorLower);
            this.grpLowerFrameOpts.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLowerFrameOpts.Location = new System.Drawing.Point(213, 93);
            this.grpLowerFrameOpts.Name = "grpLowerFrameOpts";
            this.grpLowerFrameOpts.Size = new System.Drawing.Size(265, 302);
            this.grpLowerFrameOpts.TabIndex = 20;
            this.grpLowerFrameOpts.TabStop = false;
            this.grpLowerFrameOpts.Text = "Frame Options";
            // 
            // btnLowerClone
            // 
            this.btnLowerClone.Location = new System.Drawing.Point(91, 9);
            this.btnLowerClone.Name = "btnLowerClone";
            this.btnLowerClone.Padding = new System.Windows.Forms.Padding(5);
            this.btnLowerClone.Size = new System.Drawing.Size(163, 23);
            this.btnLowerClone.TabIndex = 16;
            this.btnLowerClone.Text = "Clone From Previous";
            this.btnLowerClone.Click += new System.EventHandler(this.btnLowerClone_Click);
            // 
            // lightEditorLower
            // 
            this.lightEditorLower.Location = new System.Drawing.Point(6, 27);
            this.lightEditorLower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lightEditorLower.Name = "lightEditorLower";
            this.lightEditorLower.Size = new System.Drawing.Size(253, 274);
            this.lightEditorLower.TabIndex = 15;
            // 
            // grpLowerPlayback
            // 
            this.grpLowerPlayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpLowerPlayback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLowerPlayback.Controls.Add(this.btnPlayLower);
            this.grpLowerPlayback.Controls.Add(this.scrlLowerFrame);
            this.grpLowerPlayback.Controls.Add(this.lblLowerFrame);
            this.grpLowerPlayback.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLowerPlayback.Location = new System.Drawing.Point(213, 19);
            this.grpLowerPlayback.Name = "grpLowerPlayback";
            this.grpLowerPlayback.Size = new System.Drawing.Size(265, 68);
            this.grpLowerPlayback.TabIndex = 16;
            this.grpLowerPlayback.TabStop = false;
            this.grpLowerPlayback.Text = "Playback";
            // 
            // btnPlayLower
            // 
            this.btnPlayLower.Location = new System.Drawing.Point(57, 39);
            this.btnPlayLower.Name = "btnPlayLower";
            this.btnPlayLower.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayLower.Size = new System.Drawing.Size(197, 23);
            this.btnPlayLower.TabIndex = 16;
            this.btnPlayLower.Text = "Play Lower Animation";
            this.btnPlayLower.Click += new System.EventHandler(this.btnPlayLower_Click);
            // 
            // scrlLowerFrame
            // 
            this.scrlLowerFrame.Location = new System.Drawing.Point(57, 16);
            this.scrlLowerFrame.Maximum = 1;
            this.scrlLowerFrame.Minimum = 1;
            this.scrlLowerFrame.Name = "scrlLowerFrame";
            this.scrlLowerFrame.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlLowerFrame.Size = new System.Drawing.Size(197, 17);
            this.scrlLowerFrame.TabIndex = 15;
            this.scrlLowerFrame.Value = 1;
            this.scrlLowerFrame.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlLowerFrame_Scroll);
            // 
            // lblLowerFrame
            // 
            this.lblLowerFrame.AutoSize = true;
            this.lblLowerFrame.Location = new System.Drawing.Point(6, 16);
            this.lblLowerFrame.Name = "lblLowerFrame";
            this.lblLowerFrame.Size = new System.Drawing.Size(48, 13);
            this.lblLowerFrame.TabIndex = 14;
            this.lblLowerFrame.Text = "Frame: 1";
            // 
            // lblLowerLoopCount
            // 
            this.lblLowerLoopCount.AutoSize = true;
            this.lblLowerLoopCount.Location = new System.Drawing.Point(7, 382);
            this.lblLowerLoopCount.Name = "lblLowerLoopCount";
            this.lblLowerLoopCount.Size = new System.Drawing.Size(65, 13);
            this.lblLowerLoopCount.TabIndex = 12;
            this.lblLowerLoopCount.Text = "Loop Count:";
            // 
            // lblLowerFrameDuration
            // 
            this.lblLowerFrameDuration.AutoSize = true;
            this.lblLowerFrameDuration.Location = new System.Drawing.Point(7, 350);
            this.lblLowerFrameDuration.Name = "lblLowerFrameDuration";
            this.lblLowerFrameDuration.Size = new System.Drawing.Size(104, 13);
            this.lblLowerFrameDuration.TabIndex = 10;
            this.lblLowerFrameDuration.Text = "Frame Duration (ms):";
            // 
            // lblLowerFrameCount
            // 
            this.lblLowerFrameCount.AutoSize = true;
            this.lblLowerFrameCount.Location = new System.Drawing.Point(7, 317);
            this.lblLowerFrameCount.Name = "lblLowerFrameCount";
            this.lblLowerFrameCount.Size = new System.Drawing.Size(110, 13);
            this.lblLowerFrameCount.TabIndex = 8;
            this.lblLowerFrameCount.Text = "Graphic Frame Count:";
            // 
            // lblLowerVerticalFrames
            // 
            this.lblLowerVerticalFrames.AutoSize = true;
            this.lblLowerVerticalFrames.Location = new System.Drawing.Point(7, 283);
            this.lblLowerVerticalFrames.Name = "lblLowerVerticalFrames";
            this.lblLowerVerticalFrames.Size = new System.Drawing.Size(122, 13);
            this.lblLowerVerticalFrames.TabIndex = 5;
            this.lblLowerVerticalFrames.Text = "Graphic Vertical Frames:";
            // 
            // lblLowerHorizontalFrames
            // 
            this.lblLowerHorizontalFrames.AutoSize = true;
            this.lblLowerHorizontalFrames.Location = new System.Drawing.Point(7, 247);
            this.lblLowerHorizontalFrames.Name = "lblLowerHorizontalFrames";
            this.lblLowerHorizontalFrames.Size = new System.Drawing.Size(137, 13);
            this.lblLowerHorizontalFrames.TabIndex = 4;
            this.lblLowerHorizontalFrames.Text = "Graphic Horizontal Frames: ";
            // 
            // cmbLowerGraphic
            // 
            this.cmbLowerGraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbLowerGraphic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbLowerGraphic.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbLowerGraphic.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbLowerGraphic.DrawDropdownHoverOutline = false;
            this.cmbLowerGraphic.DrawFocusRectangle = false;
            this.cmbLowerGraphic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLowerGraphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLowerGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLowerGraphic.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbLowerGraphic.FormattingEnabled = true;
            this.cmbLowerGraphic.Items.AddRange(new object[] {
            "//General/none"});
            this.cmbLowerGraphic.Location = new System.Drawing.Point(54, 223);
            this.cmbLowerGraphic.Name = "cmbLowerGraphic";
            this.cmbLowerGraphic.Size = new System.Drawing.Size(149, 21);
            this.cmbLowerGraphic.TabIndex = 3;
            this.cmbLowerGraphic.Text = "//General/none";
            this.cmbLowerGraphic.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbLowerGraphic.SelectedIndexChanged += new System.EventHandler(this.cmbLowerGraphic_SelectedIndexChanged);
            // 
            // lblLowerGraphic
            // 
            this.lblLowerGraphic.AutoSize = true;
            this.lblLowerGraphic.Location = new System.Drawing.Point(7, 226);
            this.lblLowerGraphic.Name = "lblLowerGraphic";
            this.lblLowerGraphic.Size = new System.Drawing.Size(50, 13);
            this.lblLowerGraphic.TabIndex = 1;
            this.lblLowerGraphic.Text = "Graphic: ";
            // 
            // picLowerAnimation
            // 
            this.picLowerAnimation.Location = new System.Drawing.Point(7, 19);
            this.picLowerAnimation.Name = "picLowerAnimation";
            this.picLowerAnimation.Size = new System.Drawing.Size(200, 200);
            this.picLowerAnimation.TabIndex = 0;
            this.picLowerAnimation.TabStop = false;
            // 
            // grpUpper
            // 
            this.grpUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpUpper.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpUpper.Controls.Add(this.chkRenderBelowFringe);
            this.grpUpper.Controls.Add(this.chkDisableUpperRotations);
            this.grpUpper.Controls.Add(this.nudUpperLoopCount);
            this.grpUpper.Controls.Add(this.nudUpperFrameDuration);
            this.grpUpper.Controls.Add(this.nudUpperFrameCount);
            this.grpUpper.Controls.Add(this.nudUpperVerticalFrames);
            this.grpUpper.Controls.Add(this.nudUpperHorizontalFrames);
            this.grpUpper.Controls.Add(this.grpUpperPlayback);
            this.grpUpper.Controls.Add(this.grpUpperFrameOpts);
            this.grpUpper.Controls.Add(this.lblUpperLoopCount);
            this.grpUpper.Controls.Add(this.lblUpperFrameDuration);
            this.grpUpper.Controls.Add(this.lblUpperFrameCount);
            this.grpUpper.Controls.Add(this.lblUpperVerticalFrames);
            this.grpUpper.Controls.Add(this.lblUpperHorizontalFrames);
            this.grpUpper.Controls.Add(this.cmbUpperGraphic);
            this.grpUpper.Controls.Add(this.lblUpperGraphic);
            this.grpUpper.Controls.Add(this.picUpperAnimation);
            this.grpUpper.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpUpper.Location = new System.Drawing.Point(496, 84);
            this.grpUpper.Name = "grpUpper";
            this.grpUpper.Size = new System.Drawing.Size(485, 425);
            this.grpUpper.TabIndex = 20;
            this.grpUpper.TabStop = false;
            this.grpUpper.Text = "Upper Layer (Above Target)";
            // 
            // chkRenderBelowFringe
            // 
            this.chkRenderBelowFringe.AutoSize = true;
            this.chkRenderBelowFringe.Location = new System.Drawing.Point(356, 400);
            this.chkRenderBelowFringe.Name = "chkRenderBelowFringe";
            this.chkRenderBelowFringe.Size = new System.Drawing.Size(125, 17);
            this.chkRenderBelowFringe.TabIndex = 31;
            this.chkRenderBelowFringe.Text = "Render Below Fringe";
            this.chkRenderBelowFringe.CheckedChanged += new System.EventHandler(this.chkRenderBelowFringe_CheckedChanged);
            // 
            // chkDisableUpperRotations
            // 
            this.chkDisableUpperRotations.AutoSize = true;
            this.chkDisableUpperRotations.Location = new System.Drawing.Point(223, 400);
            this.chkDisableUpperRotations.Name = "chkDisableUpperRotations";
            this.chkDisableUpperRotations.Size = new System.Drawing.Size(109, 17);
            this.chkDisableUpperRotations.TabIndex = 27;
            this.chkDisableUpperRotations.Text = "Disable Rotations";
            this.chkDisableUpperRotations.CheckedChanged += new System.EventHandler(this.chkDisableUpperRotations_CheckedChanged);
            // 
            // nudUpperLoopCount
            // 
            this.nudUpperLoopCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudUpperLoopCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudUpperLoopCount.Location = new System.Drawing.Point(6, 398);
            this.nudUpperLoopCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudUpperLoopCount.Name = "nudUpperLoopCount";
            this.nudUpperLoopCount.Size = new System.Drawing.Size(194, 20);
            this.nudUpperLoopCount.TabIndex = 30;
            this.nudUpperLoopCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUpperLoopCount.ValueChanged += new System.EventHandler(this.nudUpperLoopCount_ValueChanged);
            // 
            // nudUpperFrameDuration
            // 
            this.nudUpperFrameDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudUpperFrameDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudUpperFrameDuration.Location = new System.Drawing.Point(6, 363);
            this.nudUpperFrameDuration.Maximum = new decimal(new int[] {
            -10,
            4,
            0,
            0});
            this.nudUpperFrameDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperFrameDuration.Name = "nudUpperFrameDuration";
            this.nudUpperFrameDuration.Size = new System.Drawing.Size(194, 20);
            this.nudUpperFrameDuration.TabIndex = 29;
            this.nudUpperFrameDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudUpperFrameDuration.ValueChanged += new System.EventHandler(this.nudUpperFrameDuration_ValueChanged);
            // 
            // nudUpperFrameCount
            // 
            this.nudUpperFrameCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudUpperFrameCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudUpperFrameCount.Location = new System.Drawing.Point(6, 330);
            this.nudUpperFrameCount.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudUpperFrameCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperFrameCount.Name = "nudUpperFrameCount";
            this.nudUpperFrameCount.Size = new System.Drawing.Size(194, 20);
            this.nudUpperFrameCount.TabIndex = 28;
            this.nudUpperFrameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperFrameCount.ValueChanged += new System.EventHandler(this.nudUpperFrameCount_ValueChanged);
            // 
            // nudUpperVerticalFrames
            // 
            this.nudUpperVerticalFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudUpperVerticalFrames.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudUpperVerticalFrames.Location = new System.Drawing.Point(6, 296);
            this.nudUpperVerticalFrames.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudUpperVerticalFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperVerticalFrames.Name = "nudUpperVerticalFrames";
            this.nudUpperVerticalFrames.Size = new System.Drawing.Size(194, 20);
            this.nudUpperVerticalFrames.TabIndex = 27;
            this.nudUpperVerticalFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperVerticalFrames.ValueChanged += new System.EventHandler(this.nudUpperVerticalFrames_ValueChanged);
            // 
            // nudUpperHorizontalFrames
            // 
            this.nudUpperHorizontalFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudUpperHorizontalFrames.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudUpperHorizontalFrames.Location = new System.Drawing.Point(6, 263);
            this.nudUpperHorizontalFrames.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudUpperHorizontalFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperHorizontalFrames.Name = "nudUpperHorizontalFrames";
            this.nudUpperHorizontalFrames.Size = new System.Drawing.Size(194, 20);
            this.nudUpperHorizontalFrames.TabIndex = 26;
            this.nudUpperHorizontalFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperHorizontalFrames.ValueChanged += new System.EventHandler(this.nudUpperHorizontalFrames_ValueChanged);
            // 
            // grpUpperPlayback
            // 
            this.grpUpperPlayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpUpperPlayback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpUpperPlayback.Controls.Add(this.btnPlayUpper);
            this.grpUpperPlayback.Controls.Add(this.scrlUpperFrame);
            this.grpUpperPlayback.Controls.Add(this.lblUpperFrame);
            this.grpUpperPlayback.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpUpperPlayback.Location = new System.Drawing.Point(212, 19);
            this.grpUpperPlayback.Name = "grpUpperPlayback";
            this.grpUpperPlayback.Size = new System.Drawing.Size(265, 68);
            this.grpUpperPlayback.TabIndex = 18;
            this.grpUpperPlayback.TabStop = false;
            this.grpUpperPlayback.Text = "Playback";
            // 
            // btnPlayUpper
            // 
            this.btnPlayUpper.Location = new System.Drawing.Point(57, 39);
            this.btnPlayUpper.Name = "btnPlayUpper";
            this.btnPlayUpper.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayUpper.Size = new System.Drawing.Size(197, 23);
            this.btnPlayUpper.TabIndex = 16;
            this.btnPlayUpper.Text = "Play Upper Animation";
            this.btnPlayUpper.Click += new System.EventHandler(this.btnPlayUpper_Click);
            // 
            // scrlUpperFrame
            // 
            this.scrlUpperFrame.Location = new System.Drawing.Point(57, 16);
            this.scrlUpperFrame.Maximum = 1;
            this.scrlUpperFrame.Minimum = 1;
            this.scrlUpperFrame.Name = "scrlUpperFrame";
            this.scrlUpperFrame.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlUpperFrame.Size = new System.Drawing.Size(197, 17);
            this.scrlUpperFrame.TabIndex = 15;
            this.scrlUpperFrame.Value = 1;
            this.scrlUpperFrame.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlUpperFrame_Scroll);
            // 
            // lblUpperFrame
            // 
            this.lblUpperFrame.AutoSize = true;
            this.lblUpperFrame.Location = new System.Drawing.Point(6, 16);
            this.lblUpperFrame.Name = "lblUpperFrame";
            this.lblUpperFrame.Size = new System.Drawing.Size(48, 13);
            this.lblUpperFrame.TabIndex = 14;
            this.lblUpperFrame.Text = "Frame: 1";
            // 
            // grpUpperFrameOpts
            // 
            this.grpUpperFrameOpts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpUpperFrameOpts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpUpperFrameOpts.Controls.Add(this.btnUpperClone);
            this.grpUpperFrameOpts.Controls.Add(this.lightEditorUpper);
            this.grpUpperFrameOpts.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpUpperFrameOpts.Location = new System.Drawing.Point(212, 93);
            this.grpUpperFrameOpts.Name = "grpUpperFrameOpts";
            this.grpUpperFrameOpts.Size = new System.Drawing.Size(265, 302);
            this.grpUpperFrameOpts.TabIndex = 19;
            this.grpUpperFrameOpts.TabStop = false;
            this.grpUpperFrameOpts.Text = "Frame Options";
            // 
            // btnUpperClone
            // 
            this.btnUpperClone.Location = new System.Drawing.Point(96, 9);
            this.btnUpperClone.Name = "btnUpperClone";
            this.btnUpperClone.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpperClone.Size = new System.Drawing.Size(163, 23);
            this.btnUpperClone.TabIndex = 17;
            this.btnUpperClone.Text = "Clone From Previous";
            this.btnUpperClone.Click += new System.EventHandler(this.btnUpperClone_Click);
            // 
            // lightEditorUpper
            // 
            this.lightEditorUpper.Location = new System.Drawing.Point(6, 27);
            this.lightEditorUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lightEditorUpper.Name = "lightEditorUpper";
            this.lightEditorUpper.Size = new System.Drawing.Size(253, 274);
            this.lightEditorUpper.TabIndex = 15;
            // 
            // lblUpperLoopCount
            // 
            this.lblUpperLoopCount.AutoSize = true;
            this.lblUpperLoopCount.Location = new System.Drawing.Point(6, 382);
            this.lblUpperLoopCount.Name = "lblUpperLoopCount";
            this.lblUpperLoopCount.Size = new System.Drawing.Size(65, 13);
            this.lblUpperLoopCount.TabIndex = 24;
            this.lblUpperLoopCount.Text = "Loop Count:";
            // 
            // lblUpperFrameDuration
            // 
            this.lblUpperFrameDuration.AutoSize = true;
            this.lblUpperFrameDuration.Location = new System.Drawing.Point(6, 350);
            this.lblUpperFrameDuration.Name = "lblUpperFrameDuration";
            this.lblUpperFrameDuration.Size = new System.Drawing.Size(104, 13);
            this.lblUpperFrameDuration.TabIndex = 22;
            this.lblUpperFrameDuration.Text = "Frame Duration (ms):";
            // 
            // lblUpperFrameCount
            // 
            this.lblUpperFrameCount.AutoSize = true;
            this.lblUpperFrameCount.Location = new System.Drawing.Point(6, 317);
            this.lblUpperFrameCount.Name = "lblUpperFrameCount";
            this.lblUpperFrameCount.Size = new System.Drawing.Size(110, 13);
            this.lblUpperFrameCount.TabIndex = 20;
            this.lblUpperFrameCount.Text = "Graphic Frame Count:";
            // 
            // lblUpperVerticalFrames
            // 
            this.lblUpperVerticalFrames.AutoSize = true;
            this.lblUpperVerticalFrames.Location = new System.Drawing.Point(6, 283);
            this.lblUpperVerticalFrames.Name = "lblUpperVerticalFrames";
            this.lblUpperVerticalFrames.Size = new System.Drawing.Size(122, 13);
            this.lblUpperVerticalFrames.TabIndex = 17;
            this.lblUpperVerticalFrames.Text = "Graphic Vertical Frames:";
            // 
            // lblUpperHorizontalFrames
            // 
            this.lblUpperHorizontalFrames.AutoSize = true;
            this.lblUpperHorizontalFrames.Location = new System.Drawing.Point(6, 247);
            this.lblUpperHorizontalFrames.Name = "lblUpperHorizontalFrames";
            this.lblUpperHorizontalFrames.Size = new System.Drawing.Size(134, 13);
            this.lblUpperHorizontalFrames.TabIndex = 16;
            this.lblUpperHorizontalFrames.Text = "Graphic Horizontal Frames:";
            // 
            // cmbUpperGraphic
            // 
            this.cmbUpperGraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbUpperGraphic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbUpperGraphic.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbUpperGraphic.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbUpperGraphic.DrawDropdownHoverOutline = false;
            this.cmbUpperGraphic.DrawFocusRectangle = false;
            this.cmbUpperGraphic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUpperGraphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpperGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUpperGraphic.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbUpperGraphic.FormattingEnabled = true;
            this.cmbUpperGraphic.Items.AddRange(new object[] {
            "//General/none"});
            this.cmbUpperGraphic.Location = new System.Drawing.Point(57, 223);
            this.cmbUpperGraphic.Name = "cmbUpperGraphic";
            this.cmbUpperGraphic.Size = new System.Drawing.Size(143, 21);
            this.cmbUpperGraphic.TabIndex = 15;
            this.cmbUpperGraphic.Text = "//General/none";
            this.cmbUpperGraphic.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbUpperGraphic.SelectedIndexChanged += new System.EventHandler(this.cmbUpperGraphic_SelectedIndexChanged);
            // 
            // lblUpperGraphic
            // 
            this.lblUpperGraphic.AutoSize = true;
            this.lblUpperGraphic.Location = new System.Drawing.Point(6, 226);
            this.lblUpperGraphic.Name = "lblUpperGraphic";
            this.lblUpperGraphic.Size = new System.Drawing.Size(50, 13);
            this.lblUpperGraphic.TabIndex = 14;
            this.lblUpperGraphic.Text = "Graphic: ";
            // 
            // picUpperAnimation
            // 
            this.picUpperAnimation.Location = new System.Drawing.Point(6, 19);
            this.picUpperAnimation.Name = "picUpperAnimation";
            this.picUpperAnimation.Size = new System.Drawing.Size(200, 200);
            this.picUpperAnimation.TabIndex = 1;
            this.picUpperAnimation.TabStop = false;
            // 
            // tmrUpperAnimation
            // 
            this.tmrUpperAnimation.Enabled = true;
            this.tmrUpperAnimation.Tick += new System.EventHandler(this.tmrUpperAnimation_Tick);
            // 
            // tmrLowerAnimation
            // 
            this.tmrLowerAnimation.Enabled = true;
            this.tmrLowerAnimation.Tick += new System.EventHandler(this.tmrLowerAnimation_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1014, 588);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(818, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlContainer.Controls.Add(this.grpScreenEffects);
            this.pnlContainer.Controls.Add(this.grpUpper);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpLower);
            this.pnlContainer.Location = new System.Drawing.Point(214, 28);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1005, 551);
            this.pnlContainer.TabIndex = 21;
            this.pnlContainer.Visible = false;
            // 
            // grpScreenEffects
            // 
            this.grpScreenEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpScreenEffects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpScreenEffects.Controls.Add(this.lblInfoScreenEffects);
            this.grpScreenEffects.Controls.Add(this.btnRemove);
            this.grpScreenEffects.Controls.Add(this.chkOverGUI);
            this.grpScreenEffects.Controls.Add(this.btnAdd);
            this.grpScreenEffects.Controls.Add(this.cmbEffectType);
            this.grpScreenEffects.Controls.Add(this.lstScreenEffects);
            this.grpScreenEffects.Controls.Add(this.lblEffectType);
            this.grpScreenEffects.Controls.Add(this.grpShake);
            this.grpScreenEffects.Controls.Add(this.grpTransition);
            this.grpScreenEffects.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpScreenEffects.Location = new System.Drawing.Point(11, 511);
            this.grpScreenEffects.Name = "grpScreenEffects";
            this.grpScreenEffects.Size = new System.Drawing.Size(691, 205);
            this.grpScreenEffects.TabIndex = 71;
            this.grpScreenEffects.TabStop = false;
            this.grpScreenEffects.Text = "ScreenEffects";
            // 
            // lblInfoScreenEffects
            // 
            this.lblInfoScreenEffects.AutoSize = true;
            this.lblInfoScreenEffects.Location = new System.Drawing.Point(20, 20);
            this.lblInfoScreenEffects.Name = "lblInfoScreenEffects";
            this.lblInfoScreenEffects.Size = new System.Drawing.Size(243, 13);
            this.lblInfoScreenEffects.TabIndex = 75;
            this.lblInfoScreenEffects.Text = " Only take into account for animations on Players !";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(140, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(70, 23);
            this.btnRemove.TabIndex = 74;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chkOverGUI
            // 
            this.chkOverGUI.AutoSize = true;
            this.chkOverGUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOverGUI.Location = new System.Drawing.Point(602, 14);
            this.chkOverGUI.Name = "chkOverGUI";
            this.chkOverGUI.Size = new System.Drawing.Size(80, 17);
            this.chkOverGUI.TabIndex = 44;
            this.chkOverGUI.Text = "Over GUI ?";
            this.chkOverGUI.CheckedChanged += new System.EventHandler(this.chkOverGUI_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbEffectType
            // 
            this.cmbEffectType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEffectType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEffectType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEffectType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEffectType.DrawDropdownHoverOutline = false;
            this.cmbEffectType.DrawFocusRectangle = false;
            this.cmbEffectType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEffectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEffectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEffectType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEffectType.FormattingEnabled = true;
            this.cmbEffectType.Location = new System.Drawing.Point(399, 13);
            this.cmbEffectType.Name = "cmbEffectType";
            this.cmbEffectType.Size = new System.Drawing.Size(190, 21);
            this.cmbEffectType.TabIndex = 22;
            this.cmbEffectType.Text = null;
            this.cmbEffectType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEffectType.SelectedIndexChanged += new System.EventHandler(this.cmbEffectType_SelectedIndexChanged);
            // 
            // lstScreenEffects
            // 
            this.lstScreenEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstScreenEffects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstScreenEffects.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstScreenEffects.FormattingEnabled = true;
            this.lstScreenEffects.Location = new System.Drawing.Point(17, 41);
            this.lstScreenEffects.Name = "lstScreenEffects";
            this.lstScreenEffects.Size = new System.Drawing.Size(253, 106);
            this.lstScreenEffects.TabIndex = 72;
            this.lstScreenEffects.SelectedIndexChanged += new System.EventHandler(this.lstScreenEffects_SelectedIndexChanged);
            // 
            // lblEffectType
            // 
            this.lblEffectType.AutoSize = true;
            this.lblEffectType.Location = new System.Drawing.Point(300, 16);
            this.lblEffectType.Name = "lblEffectType";
            this.lblEffectType.Size = new System.Drawing.Size(99, 13);
            this.lblEffectType.TabIndex = 21;
            this.lblEffectType.Text = "ScreenEffect Type:";
            // 
            // grpShake
            // 
            this.grpShake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpShake.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpShake.Controls.Add(this.lblIntensity);
            this.grpShake.Controls.Add(this.nudIntensity);
            this.grpShake.Controls.Add(this.nudShakeDuration);
            this.grpShake.Controls.Add(this.lblShakeDuration);
            this.grpShake.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpShake.Location = new System.Drawing.Point(299, 36);
            this.grpShake.Name = "grpShake";
            this.grpShake.Size = new System.Drawing.Size(377, 68);
            this.grpShake.TabIndex = 43;
            this.grpShake.TabStop = false;
            this.grpShake.Text = "Shaking parameters:";
            // 
            // lblIntensity
            // 
            this.lblIntensity.AutoSize = true;
            this.lblIntensity.Location = new System.Drawing.Point(211, 26);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(69, 13);
            this.lblIntensity.TabIndex = 37;
            this.lblIntensity.Text = "Intensity (px):";
            // 
            // nudIntensity
            // 
            this.nudIntensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudIntensity.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudIntensity.Location = new System.Drawing.Point(285, 24);
            this.nudIntensity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(45, 20);
            this.nudIntensity.TabIndex = 38;
            this.nudIntensity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudIntensity.ValueChanged += new System.EventHandler(this.nudIntensity_ValueChanged);
            // 
            // nudShakeDuration
            // 
            this.nudShakeDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudShakeDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudShakeDuration.Location = new System.Drawing.Point(84, 24);
            this.nudShakeDuration.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudShakeDuration.Name = "nudShakeDuration";
            this.nudShakeDuration.Size = new System.Drawing.Size(98, 20);
            this.nudShakeDuration.TabIndex = 36;
            this.nudShakeDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudShakeDuration.ValueChanged += new System.EventHandler(this.nudShakeDuration_ValueChanged);
            // 
            // lblShakeDuration
            // 
            this.lblShakeDuration.AutoSize = true;
            this.lblShakeDuration.Location = new System.Drawing.Point(6, 26);
            this.lblShakeDuration.Name = "lblShakeDuration";
            this.lblShakeDuration.Size = new System.Drawing.Size(75, 13);
            this.lblShakeDuration.TabIndex = 35;
            this.lblShakeDuration.Text = " Duration (ms):";
            // 
            // grpTransition
            // 
            this.grpTransition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpTransition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTransition.Controls.Add(this.lblEnd);
            this.grpTransition.Controls.Add(this.lblPending);
            this.grpTransition.Controls.Add(this.lblBegin);
            this.grpTransition.Controls.Add(this.nudFramesEnd);
            this.grpTransition.Controls.Add(this.nudDurationEnd);
            this.grpTransition.Controls.Add(this.nudOpacityEnd);
            this.grpTransition.Controls.Add(this.btnSelectColor);
            this.grpTransition.Controls.Add(this.pnlColor);
            this.grpTransition.Controls.Add(this.lblColor);
            this.grpTransition.Controls.Add(this.lblSize);
            this.grpTransition.Controls.Add(this.lblAutoframes);
            this.grpTransition.Controls.Add(this.cmbSize);
            this.grpTransition.Controls.Add(this.nudFramesBegin);
            this.grpTransition.Controls.Add(this.lblDurations);
            this.grpTransition.Controls.Add(this.lblFrames);
            this.grpTransition.Controls.Add(this.nudDurationBegin);
            this.grpTransition.Controls.Add(this.nudDurationPending);
            this.grpTransition.Controls.Add(this.lblPicture);
            this.grpTransition.Controls.Add(this.cmbPicture);
            this.grpTransition.Controls.Add(this.nudOpacityPending);
            this.grpTransition.Controls.Add(this.lblOpacities);
            this.grpTransition.Controls.Add(this.nudOpacityBegin);
            this.grpTransition.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTransition.Location = new System.Drawing.Point(299, 36);
            this.grpTransition.Name = "grpTransition";
            this.grpTransition.Size = new System.Drawing.Size(377, 163);
            this.grpTransition.TabIndex = 41;
            this.grpTransition.TabStop = false;
            this.grpTransition.Text = "Transition parameters:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(281, 51);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(43, 13);
            this.lblEnd.TabIndex = 48;
            this.lblEnd.Text = "Ending:";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(189, 51);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(49, 13);
            this.lblPending.TabIndex = 47;
            this.lblPending.Text = "Pending:";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(94, 51);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(57, 13);
            this.lblBegin.TabIndex = 46;
            this.lblBegin.Text = "Beginning:";
            // 
            // nudFramesEnd
            // 
            this.nudFramesEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFramesEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFramesEnd.Location = new System.Drawing.Point(280, 134);
            this.nudFramesEnd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFramesEnd.Name = "nudFramesEnd";
            this.nudFramesEnd.Size = new System.Drawing.Size(45, 20);
            this.nudFramesEnd.TabIndex = 45;
            this.nudFramesEnd.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFramesEnd.ValueChanged += new System.EventHandler(this.nudFramesEnd_ValueChanged);
            // 
            // nudDurationEnd
            // 
            this.nudDurationEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDurationEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDurationEnd.Location = new System.Drawing.Point(270, 104);
            this.nudDurationEnd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDurationEnd.Name = "nudDurationEnd";
            this.nudDurationEnd.Size = new System.Drawing.Size(70, 20);
            this.nudDurationEnd.TabIndex = 43;
            this.nudDurationEnd.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDurationEnd.ValueChanged += new System.EventHandler(this.nudDurationEnd_ValueChanged);
            // 
            // nudOpacityEnd
            // 
            this.nudOpacityEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacityEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacityEnd.Location = new System.Drawing.Point(280, 74);
            this.nudOpacityEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOpacityEnd.Name = "nudOpacityEnd";
            this.nudOpacityEnd.Size = new System.Drawing.Size(45, 20);
            this.nudOpacityEnd.TabIndex = 44;
            this.nudOpacityEnd.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOpacityEnd.ValueChanged += new System.EventHandler(this.nudOpacityEnd_ValueChanged);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(100, 21);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectColor.Size = new System.Drawing.Size(90, 23);
            this.btnSelectColor.TabIndex = 42;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(49, 21);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(31, 22);
            this.pnlColor.TabIndex = 41;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 26);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 40;
            this.lblColor.Text = "Color:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(235, 26);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 23;
            this.lblSize.Text = "Size:";
            // 
            // lblAutoframes
            // 
            this.lblAutoframes.AutoSize = true;
            this.lblAutoframes.Location = new System.Drawing.Point(169, 136);
            this.lblAutoframes.Name = "lblAutoframes";
            this.lblAutoframes.Size = new System.Drawing.Size(89, 13);
            this.lblAutoframes.TabIndex = 39;
            this.lblAutoframes.Text = "(0 for autoframes)";
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSize.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSize.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSize.DrawDropdownHoverOutline = false;
            this.cmbSize.DrawFocusRectangle = false;
            this.cmbSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Original",
            "Full Screen",
            "Half Screen",
            "Stretch To Fit"});
            this.cmbSize.Location = new System.Drawing.Point(268, 22);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(100, 21);
            this.cmbSize.TabIndex = 24;
            this.cmbSize.Text = "Original";
            this.cmbSize.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // nudFramesBegin
            // 
            this.nudFramesBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFramesBegin.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFramesBegin.Location = new System.Drawing.Point(100, 134);
            this.nudFramesBegin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFramesBegin.Name = "nudFramesBegin";
            this.nudFramesBegin.Size = new System.Drawing.Size(45, 20);
            this.nudFramesBegin.TabIndex = 38;
            this.nudFramesBegin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFramesBegin.ValueChanged += new System.EventHandler(this.nudFramesBegin_ValueChanged);
            // 
            // lblDurations
            // 
            this.lblDurations.AutoSize = true;
            this.lblDurations.Location = new System.Drawing.Point(6, 106);
            this.lblDurations.Name = "lblDurations";
            this.lblDurations.Size = new System.Drawing.Size(77, 13);
            this.lblDurations.TabIndex = 26;
            this.lblDurations.Text = "Durations (ms):";
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(6, 136);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(44, 13);
            this.lblFrames.TabIndex = 37;
            this.lblFrames.Text = "Frames:";
            // 
            // nudDurationBegin
            // 
            this.nudDurationBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDurationBegin.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDurationBegin.Location = new System.Drawing.Point(90, 104);
            this.nudDurationBegin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDurationBegin.Name = "nudDurationBegin";
            this.nudDurationBegin.Size = new System.Drawing.Size(70, 20);
            this.nudDurationBegin.TabIndex = 27;
            this.nudDurationBegin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDurationBegin.ValueChanged += new System.EventHandler(this.nudDurationBegin_ValueChanged);
            // 
            // nudDurationPending
            // 
            this.nudDurationPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDurationPending.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDurationPending.Location = new System.Drawing.Point(180, 104);
            this.nudDurationPending.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDurationPending.Name = "nudDurationPending";
            this.nudDurationPending.Size = new System.Drawing.Size(70, 20);
            this.nudDurationPending.TabIndex = 36;
            this.nudDurationPending.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDurationPending.ValueChanged += new System.EventHandler(this.nudDurationPending_ValueChanged);
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(4, 26);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(43, 13);
            this.lblPicture.TabIndex = 29;
            this.lblPicture.Text = "Picture:";
            // 
            // cmbPicture
            // 
            this.cmbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbPicture.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbPicture.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbPicture.DrawDropdownHoverOutline = false;
            this.cmbPicture.DrawFocusRectangle = false;
            this.cmbPicture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPicture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPicture.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbPicture.FormattingEnabled = true;
            this.cmbPicture.Location = new System.Drawing.Point(49, 22);
            this.cmbPicture.Name = "cmbPicture";
            this.cmbPicture.Size = new System.Drawing.Size(180, 21);
            this.cmbPicture.TabIndex = 30;
            this.cmbPicture.Text = null;
            this.cmbPicture.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbPicture.SelectedIndexChanged += new System.EventHandler(this.cmbPicture_SelectedIndexChanged);
            // 
            // nudOpacityPending
            // 
            this.nudOpacityPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacityPending.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacityPending.Location = new System.Drawing.Point(191, 74);
            this.nudOpacityPending.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOpacityPending.Name = "nudOpacityPending";
            this.nudOpacityPending.Size = new System.Drawing.Size(45, 20);
            this.nudOpacityPending.TabIndex = 34;
            this.nudOpacityPending.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOpacityPending.ValueChanged += new System.EventHandler(this.nudOpacityPending_ValueChanged);
            // 
            // lblOpacities
            // 
            this.lblOpacities.AutoSize = true;
            this.lblOpacities.Location = new System.Drawing.Point(6, 76);
            this.lblOpacities.Name = "lblOpacities";
            this.lblOpacities.Size = new System.Drawing.Size(54, 13);
            this.lblOpacities.TabIndex = 31;
            this.lblOpacities.Text = "Opacities:";
            // 
            // nudOpacityBegin
            // 
            this.nudOpacityBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacityBegin.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacityBegin.Location = new System.Drawing.Point(100, 74);
            this.nudOpacityBegin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOpacityBegin.Name = "nudOpacityBegin";
            this.nudOpacityBegin.Size = new System.Drawing.Size(45, 20);
            this.nudOpacityBegin.TabIndex = 32;
            this.nudOpacityBegin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOpacityBegin.ValueChanged += new System.EventHandler(this.nudOpacityBegin_ValueChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.btnAlphabetical,
            this.toolStripSeparator4,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo,
            this.toolStripItemRelations});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(1225, 25);
            this.toolStrip.TabIndex = 41;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAlphabetical
            // 
            this.btnAlphabetical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlphabetical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnAlphabetical.Image = ((System.Drawing.Image)(resources.GetObject("btnAlphabetical.Image")));
            this.btnAlphabetical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlphabetical.Name = "btnAlphabetical";
            this.btnAlphabetical.Size = new System.Drawing.Size(23, 22);
            this.btnAlphabetical.Text = "Order Chronologically";
            this.btnAlphabetical.Click += new System.EventHandler(this.btnAlphabetical_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // toolStripItemRelations
            // 
            this.toolStripItemRelations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemRelations.Enabled = false;
            this.toolStripItemRelations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemRelations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemRelations.Image")));
            this.toolStripItemRelations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemRelations.Name = "toolStripItemRelations";
            this.toolStripItemRelations.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemRelations.Text = "Relations";
            this.toolStripItemRelations.Click += new System.EventHandler(this.toolStripItemRelations_Click);
            // 
            // tmrRender
            // 
            this.tmrRender.Enabled = true;
            this.tmrRender.Interval = 16;
            this.tmrRender.Tick += new System.EventHandler(this.tmrRender_Tick);
            // 
            // grpCommentary
            // 
            this.grpCommentary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCommentary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCommentary.Controls.Add(this.txtCommentary);
            this.grpCommentary.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCommentary.Location = new System.Drawing.Point(3, 508);
            this.grpCommentary.Name = "grpCommentary";
            this.grpCommentary.Size = new System.Drawing.Size(203, 95);
            this.grpCommentary.TabIndex = 70;
            this.grpCommentary.TabStop = false;
            this.grpCommentary.Text = "Commentary";
            this.grpCommentary.Visible = false;
            // 
            // txtCommentary
            // 
            this.txtCommentary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtCommentary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtCommentary.Location = new System.Drawing.Point(3, 15);
            this.txtCommentary.Multiline = true;
            this.txtCommentary.Name = "txtCommentary";
            this.txtCommentary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommentary.Size = new System.Drawing.Size(197, 75);
            this.txtCommentary.TabIndex = 61;
            this.txtCommentary.TextChanged += new System.EventHandler(this.txtCommentary_TextChanged);
            // 
            // FrmAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1225, 621);
            this.ControlBox = false;
            this.Controls.Add(this.grpCommentary);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAnimations);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnimation_FormClosed);
            this.Load += new System.EventHandler(this.frmAnimation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpAnimations.ResumeLayout(false);
            this.grpAnimations.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpLower.ResumeLayout(false);
            this.grpLower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerLoopCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerFrameDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerFrameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerVerticalFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerHorizontalFrames)).EndInit();
            this.grpLowerFrameOpts.ResumeLayout(false);
            this.grpLowerPlayback.ResumeLayout(false);
            this.grpLowerPlayback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerAnimation)).EndInit();
            this.grpUpper.ResumeLayout(false);
            this.grpUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperLoopCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperFrameDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperFrameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperVerticalFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperHorizontalFrames)).EndInit();
            this.grpUpperPlayback.ResumeLayout(false);
            this.grpUpperPlayback.PerformLayout();
            this.grpUpperFrameOpts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUpperAnimation)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.grpScreenEffects.ResumeLayout(false);
            this.grpScreenEffects.PerformLayout();
            this.grpShake.ResumeLayout(false);
            this.grpShake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShakeDuration)).EndInit();
            this.grpTransition.ResumeLayout(false);
            this.grpTransition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityBegin)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grpCommentary.ResumeLayout(false);
            this.grpCommentary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpAnimations;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblSound;
        private DarkComboBox cmbSound;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkGroupBox grpLower;
        private System.Windows.Forms.Label lblLowerLoopCount;
        private System.Windows.Forms.Label lblLowerFrameDuration;
        private System.Windows.Forms.Label lblLowerFrameCount;
        private System.Windows.Forms.Label lblLowerVerticalFrames;
        private System.Windows.Forms.Label lblLowerHorizontalFrames;
        private DarkComboBox cmbLowerGraphic;
        private System.Windows.Forms.Label lblLowerGraphic;
        private System.Windows.Forms.PictureBox picLowerAnimation;
        private DarkGroupBox grpUpper;
        private System.Windows.Forms.Label lblUpperLoopCount;
        private System.Windows.Forms.Label lblUpperFrameDuration;
        private System.Windows.Forms.Label lblUpperFrameCount;
        private System.Windows.Forms.Label lblUpperVerticalFrames;
        private System.Windows.Forms.Label lblUpperHorizontalFrames;
        private DarkComboBox cmbUpperGraphic;
        private System.Windows.Forms.Label lblUpperGraphic;
        private System.Windows.Forms.PictureBox picUpperAnimation;
        private System.Windows.Forms.Timer tmrUpperAnimation;
        private System.Windows.Forms.Timer tmrLowerAnimation;
        private DarkGroupBox grpLowerPlayback;
        private DarkButton btnPlayLower;
        private DarkScrollBar scrlLowerFrame;
        private System.Windows.Forms.Label lblLowerFrame;
        private DarkGroupBox grpUpperPlayback;
        private DarkButton btnPlayUpper;
        private DarkScrollBar scrlUpperFrame;
        private System.Windows.Forms.Label lblUpperFrame;
        private DarkGroupBox grpUpperFrameOpts;
        private Controls.LightEditorCtrl lightEditorUpper;
        private DarkGroupBox grpLowerFrameOpts;
        private DarkButton btnLowerClone;
        private DarkButton btnUpperClone;
        public Controls.LightEditorCtrl lightEditorLower;
        private DarkScrollBar scrlDarkness;
        private System.Windows.Forms.Label labelDarkness;
        private DarkButton btnSwap;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkNumericUpDown nudLowerHorizontalFrames;
        private DarkNumericUpDown nudLowerLoopCount;
        private DarkNumericUpDown nudLowerFrameDuration;
        private DarkNumericUpDown nudLowerFrameCount;
        private DarkNumericUpDown nudLowerVerticalFrames;
        private DarkNumericUpDown nudUpperLoopCount;
        private DarkNumericUpDown nudUpperFrameDuration;
        private DarkNumericUpDown nudUpperFrameCount;
        private DarkNumericUpDown nudUpperVerticalFrames;
        private DarkNumericUpDown nudUpperHorizontalFrames;
        private System.Windows.Forms.Timer tmrRender;
        private DarkCheckBox chkDisableLowerRotations;
        private DarkCheckBox chkDisableUpperRotations;
        private DarkCheckBox chkRenderAbovePlayer;
        private DarkCheckBox chkRenderBelowFringe;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private DarkCheckBox chkCompleteSoundPlayback;
        private Controls.GameObjectList lstGameObjects;
        public System.Windows.Forms.ToolStripButton toolStripItemRelations;
        private DarkTextBox txtId;
        private System.Windows.Forms.Label lblId;
        private DarkGroupBox grpCommentary;
        private DarkTextBox txtCommentary;
        private DarkGroupBox grpScreenEffects;
        private DarkCheckBox chkOverGUI;
        private DarkComboBox cmbEffectType;
        private System.Windows.Forms.Label lblEffectType;
        private DarkGroupBox grpTransition;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblBegin;
        private DarkNumericUpDown nudFramesEnd;
        private DarkNumericUpDown nudDurationEnd;
        private DarkNumericUpDown nudOpacityEnd;
        private DarkButton btnSelectColor;
        public System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblAutoframes;
        private DarkComboBox cmbSize;
        private DarkNumericUpDown nudFramesBegin;
        private System.Windows.Forms.Label lblDurations;
        private System.Windows.Forms.Label lblFrames;
        private DarkNumericUpDown nudDurationBegin;
        private DarkNumericUpDown nudDurationPending;
        private System.Windows.Forms.Label lblPicture;
        private DarkComboBox cmbPicture;
        private DarkNumericUpDown nudOpacityPending;
        private System.Windows.Forms.Label lblOpacities;
        private DarkNumericUpDown nudOpacityBegin;
        private DarkGroupBox grpShake;
        private System.Windows.Forms.Label lblIntensity;
        private DarkNumericUpDown nudIntensity;
        private DarkNumericUpDown nudShakeDuration;
        private System.Windows.Forms.Label lblShakeDuration;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.ListBox lstScreenEffects;
        private System.Windows.Forms.Label lblInfoScreenEffects;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}