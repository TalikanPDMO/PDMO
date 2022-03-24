namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandShowPopup
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
            this.grpShowPopup = new DarkUI.Controls.DarkGroupBox();
            this.lblSync = new System.Windows.Forms.Label();
            this.chkSyncAll = new DarkUI.Controls.DarkCheckBox();
            this.chkSyncGuild = new DarkUI.Controls.DarkCheckBox();
            this.chkSyncParty = new DarkUI.Controls.DarkCheckBox();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.nudOpacity = new DarkUI.Controls.DarkNumericUpDown();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.cmbFace = new DarkUI.Controls.DarkComboBox();
            this.lblFace = new System.Windows.Forms.Label();
            this.txtTitle = new DarkUI.Controls.DarkTextBox();
            this.lblPopupTitle = new System.Windows.Forms.Label();
            this.lblCommands = new System.Windows.Forms.Label();
            this.txtText = new DarkUI.Controls.DarkTextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.nudHideTime = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHide = new System.Windows.Forms.Label();
            this.cmbBgPicture = new DarkUI.Controls.DarkComboBox();
            this.lblBgPicture = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpShowPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHideTime)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShowPopup
            // 
            this.grpShowPopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpShowPopup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpShowPopup.Controls.Add(this.lblSync);
            this.grpShowPopup.Controls.Add(this.chkSyncAll);
            this.grpShowPopup.Controls.Add(this.chkSyncGuild);
            this.grpShowPopup.Controls.Add(this.chkSyncParty);
            this.grpShowPopup.Controls.Add(this.lblOpacity);
            this.grpShowPopup.Controls.Add(this.nudOpacity);
            this.grpShowPopup.Controls.Add(this.pnlFace);
            this.grpShowPopup.Controls.Add(this.cmbFace);
            this.grpShowPopup.Controls.Add(this.lblFace);
            this.grpShowPopup.Controls.Add(this.txtTitle);
            this.grpShowPopup.Controls.Add(this.lblPopupTitle);
            this.grpShowPopup.Controls.Add(this.lblCommands);
            this.grpShowPopup.Controls.Add(this.txtText);
            this.grpShowPopup.Controls.Add(this.lblText);
            this.grpShowPopup.Controls.Add(this.nudHideTime);
            this.grpShowPopup.Controls.Add(this.lblHide);
            this.grpShowPopup.Controls.Add(this.cmbBgPicture);
            this.grpShowPopup.Controls.Add(this.lblBgPicture);
            this.grpShowPopup.Controls.Add(this.btnCancel);
            this.grpShowPopup.Controls.Add(this.btnSave);
            this.grpShowPopup.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpShowPopup.Location = new System.Drawing.Point(3, 3);
            this.grpShowPopup.Name = "grpShowPopup";
            this.grpShowPopup.Size = new System.Drawing.Size(399, 322);
            this.grpShowPopup.TabIndex = 18;
            this.grpShowPopup.TabStop = false;
            this.grpShowPopup.Text = "Show Popup:";
            // 
            // lblSync
            // 
            this.lblSync.AutoSize = true;
            this.lblSync.Location = new System.Drawing.Point(6, 100);
            this.lblSync.Name = "lblSync";
            this.lblSync.Size = new System.Drawing.Size(82, 13);
            this.lblSync.TabIndex = 47;
            this.lblSync.Text = "Include Players:";
            // 
            // chkSyncAll
            // 
            this.chkSyncAll.AutoSize = true;
            this.chkSyncAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.chkSyncAll.Location = new System.Drawing.Point(208, 99);
            this.chkSyncAll.Name = "chkSyncAll";
            this.chkSyncAll.Size = new System.Drawing.Size(37, 17);
            this.chkSyncAll.TabIndex = 46;
            this.chkSyncAll.Text = "All";
            // 
            // chkSyncGuild
            // 
            this.chkSyncGuild.AutoSize = true;
            this.chkSyncGuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.chkSyncGuild.Location = new System.Drawing.Point(150, 99);
            this.chkSyncGuild.Name = "chkSyncGuild";
            this.chkSyncGuild.Size = new System.Drawing.Size(50, 17);
            this.chkSyncGuild.TabIndex = 45;
            this.chkSyncGuild.Text = "Guild";
            // 
            // chkSyncParty
            // 
            this.chkSyncParty.AutoSize = true;
            this.chkSyncParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.chkSyncParty.Location = new System.Drawing.Point(94, 99);
            this.chkSyncParty.Name = "chkSyncParty";
            this.chkSyncParty.Size = new System.Drawing.Size(50, 17);
            this.chkSyncParty.TabIndex = 44;
            this.chkSyncParty.Text = "Party";
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(264, 23);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(82, 13);
            this.lblOpacity.TabIndex = 38;
            this.lblOpacity.Text = "Opacity (0-255):";
            // 
            // nudOpacity
            // 
            this.nudOpacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOpacity.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOpacity.Location = new System.Drawing.Point(346, 21);
            this.nudOpacity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOpacity.Name = "nudOpacity";
            this.nudOpacity.Size = new System.Drawing.Size(40, 20);
            this.nudOpacity.TabIndex = 37;
            this.nudOpacity.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // pnlFace
            // 
            this.pnlFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFace.Location = new System.Drawing.Point(21, 182);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Size = new System.Drawing.Size(96, 96);
            this.pnlFace.TabIndex = 36;
            // 
            // cmbFace
            // 
            this.cmbFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFace.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFace.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFace.DrawDropdownHoverOutline = false;
            this.cmbFace.DrawFocusRectangle = false;
            this.cmbFace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFace.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFace.FormattingEnabled = true;
            this.cmbFace.Location = new System.Drawing.Point(8, 154);
            this.cmbFace.Name = "cmbFace";
            this.cmbFace.Size = new System.Drawing.Size(133, 21);
            this.cmbFace.TabIndex = 35;
            this.cmbFace.Text = null;
            this.cmbFace.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFace.SelectedIndexChanged += new System.EventHandler(this.cmbFace_SelectedIndexChanged);
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Location = new System.Drawing.Point(6, 138);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(34, 13);
            this.lblFace.TabIndex = 34;
            this.lblFace.Text = "Face:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTitle.Location = new System.Drawing.Point(178, 145);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTitle.Size = new System.Drawing.Size(212, 20);
            this.txtTitle.TabIndex = 33;
            // 
            // lblPopupTitle
            // 
            this.lblPopupTitle.AutoSize = true;
            this.lblPopupTitle.Location = new System.Drawing.Point(147, 147);
            this.lblPopupTitle.Name = "lblPopupTitle";
            this.lblPopupTitle.Size = new System.Drawing.Size(30, 13);
            this.lblPopupTitle.TabIndex = 32;
            this.lblPopupTitle.Text = "Title:";
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.BackColor = System.Drawing.Color.Transparent;
            this.lblCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommands.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCommands.Location = new System.Drawing.Point(301, 282);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(83, 13);
            this.lblCommands.TabIndex = 31;
            this.lblCommands.Text = "Text Commands";
            this.lblCommands.Click += new System.EventHandler(this.lblCommands_Click);
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtText.Location = new System.Drawing.Point(150, 179);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtText.Size = new System.Drawing.Size(240, 100);
            this.txtText.TabIndex = 30;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(147, 165);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 29;
            this.lblText.Text = "Text:";
            // 
            // nudHideTime
            // 
            this.nudHideTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHideTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHideTime.Location = new System.Drawing.Point(112, 51);
            this.nudHideTime.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudHideTime.Name = "nudHideTime";
            this.nudHideTime.Size = new System.Drawing.Size(149, 20);
            this.nudHideTime.TabIndex = 27;
            this.nudHideTime.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(6, 51);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(79, 13);
            this.lblHide.TabIndex = 26;
            this.lblHide.Text = "Hide After (ms):";
            // 
            // cmbBgPicture
            // 
            this.cmbBgPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbBgPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbBgPicture.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbBgPicture.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbBgPicture.DrawDropdownHoverOutline = false;
            this.cmbBgPicture.DrawFocusRectangle = false;
            this.cmbBgPicture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBgPicture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBgPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBgPicture.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbBgPicture.FormattingEnabled = true;
            this.cmbBgPicture.Location = new System.Drawing.Point(112, 20);
            this.cmbBgPicture.Name = "cmbBgPicture";
            this.cmbBgPicture.Size = new System.Drawing.Size(149, 21);
            this.cmbBgPicture.TabIndex = 22;
            this.cmbBgPicture.Text = null;
            this.cmbBgPicture.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblBgPicture
            // 
            this.lblBgPicture.AutoSize = true;
            this.lblBgPicture.Location = new System.Drawing.Point(6, 22);
            this.lblBgPicture.Name = "lblBgPicture";
            this.lblBgPicture.Size = new System.Drawing.Size(105, 13);
            this.lblBgPicture.TabIndex = 21;
            this.lblBgPicture.Text = "Custom background:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(94, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommandShowPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpShowPopup);
            this.Name = "EventCommandShowPopup";
            this.Size = new System.Drawing.Size(405, 330);
            this.grpShowPopup.ResumeLayout(false);
            this.grpShowPopup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHideTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox grpShowPopup;
        private DarkUI.Controls.DarkComboBox cmbBgPicture;
        private System.Windows.Forms.Label lblBgPicture;
        private DarkUI.Controls.DarkButton btnCancel;
        private DarkUI.Controls.DarkButton btnSave;
        private System.Windows.Forms.Label lblHide;
        private DarkUI.Controls.DarkNumericUpDown nudHideTime;
        private System.Windows.Forms.Label lblCommands;
        private DarkUI.Controls.DarkTextBox txtText;
        private System.Windows.Forms.Label lblText;
        private DarkUI.Controls.DarkTextBox txtTitle;
        private System.Windows.Forms.Label lblPopupTitle;
        private System.Windows.Forms.Panel pnlFace;
        private DarkUI.Controls.DarkComboBox cmbFace;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.Label lblOpacity;
        private DarkUI.Controls.DarkNumericUpDown nudOpacity;
        private System.Windows.Forms.Label lblSync;
        private DarkUI.Controls.DarkCheckBox chkSyncAll;
        private DarkUI.Controls.DarkCheckBox chkSyncGuild;
        private DarkUI.Controls.DarkCheckBox chkSyncParty;
    }
}