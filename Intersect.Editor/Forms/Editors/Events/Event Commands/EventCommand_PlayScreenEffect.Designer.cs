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
            this.grpTransition = new DarkUI.Controls.DarkGroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblAutocalculate = new System.Windows.Forms.Label();
            this.cmbSize = new DarkUI.Controls.DarkComboBox();
            this.nudFrames = new DarkUI.Controls.DarkNumericUpDown();
            this.lblOpacityDuration = new System.Windows.Forms.Label();
            this.lblFrames = new System.Windows.Forms.Label();
            this.nudOpacityDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.nudAfterDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblAfterDuration = new System.Windows.Forms.Label();
            this.cmbPicture = new DarkUI.Controls.DarkComboBox();
            this.nudOpacityEnd = new DarkUI.Controls.DarkNumericUpDown();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.nudOpacityStart = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbEffectType = new DarkUI.Controls.DarkComboBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpPlayScreenEffect.SuspendLayout();
            this.grpTransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfterDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityStart)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlayScreenEffect
            // 
            this.grpPlayScreenEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpPlayScreenEffect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPlayScreenEffect.Controls.Add(this.grpTransition);
            this.grpPlayScreenEffect.Controls.Add(this.cmbEffectType);
            this.grpPlayScreenEffect.Controls.Add(this.lblEffectType);
            this.grpPlayScreenEffect.Controls.Add(this.btnCancel);
            this.grpPlayScreenEffect.Controls.Add(this.btnSave);
            this.grpPlayScreenEffect.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPlayScreenEffect.Location = new System.Drawing.Point(3, 3);
            this.grpPlayScreenEffect.Name = "grpPlayScreenEffect";
            this.grpPlayScreenEffect.Size = new System.Drawing.Size(426, 215);
            this.grpPlayScreenEffect.TabIndex = 18;
            this.grpPlayScreenEffect.TabStop = false;
            this.grpPlayScreenEffect.Text = "Play ScreenEffect:";
            // 
            // grpTransition
            // 
            this.grpTransition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpTransition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTransition.Controls.Add(this.lblColor);
            this.grpTransition.Controls.Add(this.lblSize);
            this.grpTransition.Controls.Add(this.lblAutocalculate);
            this.grpTransition.Controls.Add(this.cmbSize);
            this.grpTransition.Controls.Add(this.nudFrames);
            this.grpTransition.Controls.Add(this.lblOpacityDuration);
            this.grpTransition.Controls.Add(this.lblFrames);
            this.grpTransition.Controls.Add(this.nudOpacityDuration);
            this.grpTransition.Controls.Add(this.nudAfterDuration);
            this.grpTransition.Controls.Add(this.lblPicture);
            this.grpTransition.Controls.Add(this.lblAfterDuration);
            this.grpTransition.Controls.Add(this.cmbPicture);
            this.grpTransition.Controls.Add(this.nudOpacityEnd);
            this.grpTransition.Controls.Add(this.lblOpacity);
            this.grpTransition.Controls.Add(this.lblTo);
            this.grpTransition.Controls.Add(this.nudOpacityStart);
            this.grpTransition.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTransition.Location = new System.Drawing.Point(6, 49);
            this.grpTransition.Name = "grpTransition";
            this.grpTransition.Size = new System.Drawing.Size(413, 126);
            this.grpTransition.TabIndex = 41;
            this.grpTransition.TabStop = false;
            this.grpTransition.Text = "Transition:";
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
            this.lblSize.Location = new System.Drawing.Point(263, 26);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 23;
            this.lblSize.Text = "Size:";
            // 
            // lblAutocalculate
            // 
            this.lblAutocalculate.AutoSize = true;
            this.lblAutocalculate.Location = new System.Drawing.Point(6, 105);
            this.lblAutocalculate.Name = "lblAutocalculate";
            this.lblAutocalculate.Size = new System.Drawing.Size(101, 13);
            this.lblAutocalculate.TabIndex = 39;
            this.lblAutocalculate.Text = "(0 for autocalculate)";
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
            this.cmbSize.Location = new System.Drawing.Point(296, 22);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(111, 21);
            this.cmbSize.TabIndex = 24;
            this.cmbSize.Text = "Original";
            this.cmbSize.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // nudFrames
            // 
            this.nudFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFrames.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFrames.Location = new System.Drawing.Point(101, 85);
            this.nudFrames.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFrames.Name = "nudFrames";
            this.nudFrames.Size = new System.Drawing.Size(59, 20);
            this.nudFrames.TabIndex = 38;
            this.nudFrames.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblOpacityDuration
            // 
            this.lblOpacityDuration.AutoSize = true;
            this.lblOpacityDuration.Location = new System.Drawing.Point(214, 55);
            this.lblOpacityDuration.Name = "lblOpacityDuration";
            this.lblOpacityDuration.Size = new System.Drawing.Size(121, 13);
            this.lblOpacityDuration.TabIndex = 26;
            this.lblOpacityDuration.Text = "Transition Duration (ms):";
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(5, 88);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(93, 13);
            this.lblFrames.TabIndex = 37;
            this.lblFrames.Text = "Transition Frames:";
            // 
            // nudOpacityDuration
            // 
            this.nudOpacityDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacityDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacityDuration.Location = new System.Drawing.Point(337, 53);
            this.nudOpacityDuration.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudOpacityDuration.Name = "nudOpacityDuration";
            this.nudOpacityDuration.Size = new System.Drawing.Size(70, 20);
            this.nudOpacityDuration.TabIndex = 27;
            this.nudOpacityDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudAfterDuration
            // 
            this.nudAfterDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAfterDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAfterDuration.Location = new System.Drawing.Point(337, 88);
            this.nudAfterDuration.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudAfterDuration.Name = "nudAfterDuration";
            this.nudAfterDuration.Size = new System.Drawing.Size(70, 20);
            this.nudAfterDuration.TabIndex = 36;
            this.nudAfterDuration.Value = new decimal(new int[] {
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
            // lblAfterDuration
            // 
            this.lblAfterDuration.AutoSize = true;
            this.lblAfterDuration.Location = new System.Drawing.Point(196, 90);
            this.lblAfterDuration.Name = "lblAfterDuration";
            this.lblAfterDuration.Size = new System.Drawing.Size(140, 13);
            this.lblAfterDuration.TabIndex = 35;
            this.lblAfterDuration.Text = "AfterTransition Duration(ms):";
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
            this.cmbPicture.Items.AddRange(new object[] {
            "Original",
            "Full Screen",
            "Half Screen",
            "Stretch To Fit"});
            this.cmbPicture.Location = new System.Drawing.Point(49, 22);
            this.cmbPicture.Name = "cmbPicture";
            this.cmbPicture.Size = new System.Drawing.Size(202, 21);
            this.cmbPicture.TabIndex = 30;
            this.cmbPicture.Text = "Original";
            this.cmbPicture.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // nudOpacityEnd
            // 
            this.nudOpacityEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacityEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacityEnd.Location = new System.Drawing.Point(166, 53);
            this.nudOpacityEnd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudOpacityEnd.Name = "nudOpacityEnd";
            this.nudOpacityEnd.Size = new System.Drawing.Size(45, 20);
            this.nudOpacityEnd.TabIndex = 34;
            this.nudOpacityEnd.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(5, 55);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(95, 13);
            this.lblOpacity.TabIndex = 31;
            this.lblOpacity.Text = "Opacity Transition:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(149, 55);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 33;
            this.lblTo.Text = "to";
            // 
            // nudOpacityStart
            // 
            this.nudOpacityStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacityStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacityStart.Location = new System.Drawing.Point(101, 53);
            this.nudOpacityStart.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudOpacityStart.Name = "nudOpacityStart";
            this.nudOpacityStart.Size = new System.Drawing.Size(45, 20);
            this.nudOpacityStart.TabIndex = 32;
            this.nudOpacityStart.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.cmbEffectType.Size = new System.Drawing.Size(307, 21);
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
            this.btnCancel.Location = new System.Drawing.Point(168, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommand_PlayScreenEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpPlayScreenEffect);
            this.Name = "EventCommand_PlayScreenEffect";
            this.Size = new System.Drawing.Size(432, 221);
            this.grpPlayScreenEffect.ResumeLayout(false);
            this.grpPlayScreenEffect.PerformLayout();
            this.grpTransition.ResumeLayout(false);
            this.grpTransition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfterDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacityStart)).EndInit();
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
        private System.Windows.Forms.Label lblOpacityDuration;
        private DarkUI.Controls.DarkNumericUpDown nudOpacityDuration;
        private DarkUI.Controls.DarkNumericUpDown nudOpacityEnd;
        private System.Windows.Forms.Label lblTo;
        private DarkUI.Controls.DarkNumericUpDown nudOpacityStart;
        private System.Windows.Forms.Label lblOpacity;
        private DarkUI.Controls.DarkComboBox cmbPicture;
        private System.Windows.Forms.Label lblPicture;
        private DarkUI.Controls.DarkNumericUpDown nudFrames;
        private System.Windows.Forms.Label lblFrames;
        private DarkUI.Controls.DarkNumericUpDown nudAfterDuration;
        private System.Windows.Forms.Label lblAfterDuration;
        private System.Windows.Forms.Label lblAutocalculate;
        private System.Windows.Forms.Label lblColor;
        private DarkUI.Controls.DarkGroupBox grpTransition;
    }
}