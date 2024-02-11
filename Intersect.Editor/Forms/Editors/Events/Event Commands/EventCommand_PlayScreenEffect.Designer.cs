namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommand_PlayScreenEffect
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
            this.grpPlayScreenEffect = new DarkUI.Controls.DarkGroupBox();
            this.chkOverGUI = new DarkUI.Controls.DarkCheckBox();
            this.cmbEffectType = new DarkUI.Controls.DarkComboBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
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
            this.grpShake = new DarkUI.Controls.DarkGroupBox();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.nudIntensity = new DarkUI.Controls.DarkNumericUpDown();
            this.nudShakeDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblShakeDuration = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.grpPlayScreenEffect.SuspendLayout();
            this.grpTransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityBegin)).BeginInit();
            this.grpShake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShakeDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlayScreenEffect
            // 
            this.grpPlayScreenEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpPlayScreenEffect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPlayScreenEffect.Controls.Add(this.chkOverGUI);
            this.grpPlayScreenEffect.Controls.Add(this.cmbEffectType);
            this.grpPlayScreenEffect.Controls.Add(this.lblEffectType);
            this.grpPlayScreenEffect.Controls.Add(this.btnCancel);
            this.grpPlayScreenEffect.Controls.Add(this.btnSave);
            this.grpPlayScreenEffect.Controls.Add(this.grpTransition);
            this.grpPlayScreenEffect.Controls.Add(this.grpShake);
            this.grpPlayScreenEffect.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPlayScreenEffect.Location = new System.Drawing.Point(3, 3);
            this.grpPlayScreenEffect.Name = "grpPlayScreenEffect";
            this.grpPlayScreenEffect.Size = new System.Drawing.Size(390, 247);
            this.grpPlayScreenEffect.TabIndex = 18;
            this.grpPlayScreenEffect.TabStop = false;
            this.grpPlayScreenEffect.Text = "Play ScreenEffect:";
            // 
            // chkOverGUI
            // 
            this.chkOverGUI.AutoSize = true;
            this.chkOverGUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOverGUI.Location = new System.Drawing.Point(306, 24);
            this.chkOverGUI.Name = "chkOverGUI";
            this.chkOverGUI.Size = new System.Drawing.Size(80, 17);
            this.chkOverGUI.TabIndex = 44;
            this.chkOverGUI.Text = "Over GUI ?";
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
            this.cmbEffectType.Location = new System.Drawing.Point(106, 22);
            this.cmbEffectType.Name = "cmbEffectType";
            this.cmbEffectType.Size = new System.Drawing.Size(190, 21);
            this.cmbEffectType.TabIndex = 22;
            this.cmbEffectType.Text = null;
            this.cmbEffectType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEffectType.SelectedIndexChanged += new System.EventHandler(this.cmbEffectType_SelectedIndexChanged);
            // 
            // lblEffectType
            // 
            this.lblEffectType.AutoSize = true;
            this.lblEffectType.Location = new System.Drawing.Point(4, 26);
            this.lblEffectType.Name = "lblEffectType";
            this.lblEffectType.Size = new System.Drawing.Size(99, 13);
            this.lblEffectType.TabIndex = 21;
            this.lblEffectType.Text = "ScreenEffect Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpTransition
            // 
            this.grpTransition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
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
            this.grpTransition.Location = new System.Drawing.Point(6, 49);
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
            // 
            // grpShake
            // 
            this.grpShake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpShake.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpShake.Controls.Add(this.lblIntensity);
            this.grpShake.Controls.Add(this.nudIntensity);
            this.grpShake.Controls.Add(this.nudShakeDuration);
            this.grpShake.Controls.Add(this.lblShakeDuration);
            this.grpShake.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpShake.Location = new System.Drawing.Point(6, 49);
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
            // EventCommand_PlayScreenEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpPlayScreenEffect);
            this.Name = "EventCommand_PlayScreenEffect";
            this.Size = new System.Drawing.Size(396, 255);
            this.grpPlayScreenEffect.ResumeLayout(false);
            this.grpPlayScreenEffect.PerformLayout();
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
            this.grpShake.ResumeLayout(false);
            this.grpShake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShakeDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox grpPlayScreenEffect;
        private DarkUI.Controls.DarkComboBox cmbEffectType;
        private System.Windows.Forms.Label lblEffectType;
        private DarkUI.Controls.DarkButton btnCancel;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDurations;
        private DarkUI.Controls.DarkNumericUpDown nudDurationBegin;
        private DarkUI.Controls.DarkNumericUpDown nudOpacityPending;
        private DarkUI.Controls.DarkNumericUpDown nudOpacityBegin;
        private System.Windows.Forms.Label lblOpacities;
        private DarkUI.Controls.DarkComboBox cmbPicture;
        private System.Windows.Forms.Label lblPicture;
        private DarkUI.Controls.DarkNumericUpDown nudFramesBegin;
        private System.Windows.Forms.Label lblFrames;
        private DarkUI.Controls.DarkNumericUpDown nudDurationPending;
        private System.Windows.Forms.Label lblAutoframes;
        private System.Windows.Forms.Label lblColor;
        private DarkUI.Controls.DarkGroupBox grpTransition;
        public System.Windows.Forms.Panel pnlColor;
        private DarkUI.Controls.DarkButton btnSelectColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private DarkUI.Controls.DarkGroupBox grpShake;
        private DarkUI.Controls.DarkNumericUpDown nudShakeDuration;
        private System.Windows.Forms.Label lblShakeDuration;
        private System.Windows.Forms.Label lblIntensity;
        private DarkUI.Controls.DarkNumericUpDown nudIntensity;
        private DarkUI.Controls.DarkNumericUpDown nudFramesEnd;
        private DarkUI.Controls.DarkNumericUpDown nudDurationEnd;
        private DarkUI.Controls.DarkNumericUpDown nudOpacityEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblBegin;
        private DarkUI.Controls.DarkCheckBox chkOverGUI;
    }
}