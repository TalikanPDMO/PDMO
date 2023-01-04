using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class NpcPhaseEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSpells = new DarkUI.Controls.DarkGroupBox();
            this.chkReplaceSpells = new DarkUI.Controls.DarkCheckBox();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.btnRemoveSpell = new DarkUI.Controls.DarkButton();
            this.btnAddSpell = new DarkUI.Controls.DarkButton();
            this.lstSpells = new System.Windows.Forms.ListBox();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnEditBeginEvent = new DarkUI.Controls.DarkButton();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.grpEditor = new DarkUI.Controls.DarkGroupBox();
            this.grpRegen = new DarkUI.Controls.DarkGroupBox();
            this.chkChangeRegen = new DarkUI.Controls.DarkCheckBox();
            this.nudMpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHpRegen = new System.Windows.Forms.Label();
            this.lblManaRegen = new System.Windows.Forms.Label();
            this.grpStats = new DarkUI.Controls.DarkGroupBox();
            this.nudSpdPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMRPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDefPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMagPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStrPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSpd = new System.Windows.Forms.Label();
            this.lblMR = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblMag = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.grpPhaseConditions = new DarkUI.Controls.DarkGroupBox();
            this.btnEditConditions = new DarkUI.Controls.DarkButton();
            this.lblX5 = new System.Windows.Forms.Label();
            this.lblX4 = new System.Windows.Forms.Label();
            this.lblX3 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.grpSpells.SuspendLayout();
            this.grpEditor.SuspendLayout();
            this.grpRegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).BeginInit();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).BeginInit();
            this.grpPhaseConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSpells
            // 
            this.grpSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpells.Controls.Add(this.chkReplaceSpells);
            this.grpSpells.Controls.Add(this.cmbSpell);
            this.grpSpells.Controls.Add(this.lblSpell);
            this.grpSpells.Controls.Add(this.btnRemoveSpell);
            this.grpSpells.Controls.Add(this.btnAddSpell);
            this.grpSpells.Controls.Add(this.lstSpells);
            this.grpSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpells.Location = new System.Drawing.Point(10, 134);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Size = new System.Drawing.Size(188, 185);
            this.grpSpells.TabIndex = 28;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells";
            // 
            // chkReplaceSpells
            // 
            this.chkReplaceSpells.AutoSize = true;
            this.chkReplaceSpells.Location = new System.Drawing.Point(23, 14);
            this.chkReplaceSpells.Name = "chkReplaceSpells";
            this.chkReplaceSpells.Size = new System.Drawing.Size(149, 17);
            this.chkReplaceSpells.TabIndex = 49;
            this.chkReplaceSpells.Text = "Replace all known spells?";
            // 
            // cmbSpell
            // 
            this.cmbSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSpell.DrawDropdownHoverOutline = false;
            this.cmbSpell.DrawFocusRectangle = false;
            this.cmbSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSpell.FormattingEnabled = true;
            this.cmbSpell.Location = new System.Drawing.Point(6, 133);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(173, 21);
            this.cmbSpell.TabIndex = 48;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(14, 117);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(33, 13);
            this.lblSpell.TabIndex = 47;
            this.lblSpell.Text = "Spell:";
            // 
            // btnRemoveSpell
            // 
            this.btnRemoveSpell.Location = new System.Drawing.Point(93, 158);
            this.btnRemoveSpell.Name = "btnRemoveSpell";
            this.btnRemoveSpell.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveSpell.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSpell.TabIndex = 46;
            this.btnRemoveSpell.Text = "Remove";
            this.btnRemoveSpell.Click += new System.EventHandler(this.btnRemoveSpell_Click);
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.Location = new System.Drawing.Point(12, 158);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddSpell.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpell.TabIndex = 45;
            this.btnAddSpell.Text = "Add";
            this.btnAddSpell.Click += new System.EventHandler(this.btnAddSpell_Click);
            // 
            // lstSpells
            // 
            this.lstSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstSpells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSpells.FormattingEnabled = true;
            this.lstSpells.Location = new System.Drawing.Point(6, 34);
            this.lstSpells.Name = "lstSpells";
            this.lstSpells.Size = new System.Drawing.Size(173, 80);
            this.lstSpells.TabIndex = 44;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditBeginEvent
            // 
            this.btnEditBeginEvent.Location = new System.Drawing.Point(194, 20);
            this.btnEditBeginEvent.Name = "btnEditBeginEvent";
            this.btnEditBeginEvent.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditBeginEvent.Size = new System.Drawing.Size(143, 23);
            this.btnEditBeginEvent.TabIndex = 30;
            this.btnEditBeginEvent.Text = "Edit Begin Event";
            this.btnEditBeginEvent.Click += new System.EventHandler(this.btnEditBeginEvent_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(44, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(94, 20);
            this.txtName.TabIndex = 33;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(154, 22);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 36;
            this.lblDesc.Text = "Desc:";
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = true;
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(195, 20);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(173, 47);
            this.txtDesc.TabIndex = 37;
            // 
            // grpEditor
            // 
            this.grpEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEditor.Controls.Add(this.grpRegen);
            this.grpEditor.Controls.Add(this.grpStats);
            this.grpEditor.Controls.Add(this.grpPhaseConditions);
            this.grpEditor.Controls.Add(this.txtDesc);
            this.grpEditor.Controls.Add(this.lblDesc);
            this.grpEditor.Controls.Add(this.lblName);
            this.grpEditor.Controls.Add(this.txtName);
            this.grpEditor.Controls.Add(this.btnSave);
            this.grpEditor.Controls.Add(this.btnCancel);
            this.grpEditor.Controls.Add(this.grpSpells);
            this.grpEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEditor.Location = new System.Drawing.Point(0, 2);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(375, 522);
            this.grpEditor.TabIndex = 18;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "Phase Editor";
            // 
            // grpRegen
            // 
            this.grpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpRegen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpRegen.Controls.Add(this.chkChangeRegen);
            this.grpRegen.Controls.Add(this.nudMpRegen);
            this.grpRegen.Controls.Add(this.nudHpRegen);
            this.grpRegen.Controls.Add(this.lblHpRegen);
            this.grpRegen.Controls.Add(this.lblManaRegen);
            this.grpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRegen.Location = new System.Drawing.Point(10, 337);
            this.grpRegen.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegen.Name = "grpRegen";
            this.grpRegen.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegen.Size = new System.Drawing.Size(172, 75);
            this.grpRegen.TabIndex = 52;
            this.grpRegen.TabStop = false;
            this.grpRegen.Text = "Regen";
            // 
            // chkChangeRegen
            // 
            this.chkChangeRegen.AutoSize = true;
            this.chkChangeRegen.Location = new System.Drawing.Point(50, 11);
            this.chkChangeRegen.Name = "chkChangeRegen";
            this.chkChangeRegen.Size = new System.Drawing.Size(118, 17);
            this.chkChangeRegen.TabIndex = 50;
            this.chkChangeRegen.Text = "Change from base?";
            this.chkChangeRegen.CheckedChanged += new System.EventHandler(this.chkChangeRegen_CheckedChanged);
            // 
            // nudMpRegen
            // 
            this.nudMpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpRegen.Location = new System.Drawing.Point(67, 48);
            this.nudMpRegen.Name = "nudMpRegen";
            this.nudMpRegen.Size = new System.Drawing.Size(51, 20);
            this.nudMpRegen.TabIndex = 31;
            this.nudMpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudHpRegen
            // 
            this.nudHpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHpRegen.Location = new System.Drawing.Point(5, 48);
            this.nudHpRegen.Name = "nudHpRegen";
            this.nudHpRegen.Size = new System.Drawing.Size(51, 20);
            this.nudHpRegen.TabIndex = 30;
            this.nudHpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblHpRegen
            // 
            this.lblHpRegen.AutoSize = true;
            this.lblHpRegen.Location = new System.Drawing.Point(11, 34);
            this.lblHpRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHpRegen.Name = "lblHpRegen";
            this.lblHpRegen.Size = new System.Drawing.Size(42, 13);
            this.lblHpRegen.TabIndex = 26;
            this.lblHpRegen.Text = "HP: (%)";
            // 
            // lblManaRegen
            // 
            this.lblManaRegen.AutoSize = true;
            this.lblManaRegen.Location = new System.Drawing.Point(66, 33);
            this.lblManaRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManaRegen.Name = "lblManaRegen";
            this.lblManaRegen.Size = new System.Drawing.Size(54, 13);
            this.lblManaRegen.TabIndex = 27;
            this.lblManaRegen.Text = "Mana: (%)";
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpStats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpStats.Controls.Add(this.lblX5);
            this.grpStats.Controls.Add(this.lblX4);
            this.grpStats.Controls.Add(this.lblX3);
            this.grpStats.Controls.Add(this.lblX2);
            this.grpStats.Controls.Add(this.lblX1);
            this.grpStats.Controls.Add(this.nudSpdPercentage);
            this.grpStats.Controls.Add(this.nudMRPercentage);
            this.grpStats.Controls.Add(this.nudDefPercentage);
            this.grpStats.Controls.Add(this.nudMagPercentage);
            this.grpStats.Controls.Add(this.nudStrPercentage);
            this.grpStats.Controls.Add(this.lblSpd);
            this.grpStats.Controls.Add(this.lblMR);
            this.grpStats.Controls.Add(this.lblDef);
            this.grpStats.Controls.Add(this.lblMag);
            this.grpStats.Controls.Add(this.lblStr);
            this.grpStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpStats.Location = new System.Drawing.Point(218, 134);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(141, 163);
            this.grpStats.TabIndex = 51;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats Multiplier";
            // 
            // nudSpdPercentage
            // 
            this.nudSpdPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpdPercentage.DecimalPlaces = 2;
            this.nudSpdPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpdPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSpdPercentage.Location = new System.Drawing.Point(80, 133);
            this.nudSpdPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpdPercentage.Name = "nudSpdPercentage";
            this.nudSpdPercentage.Size = new System.Drawing.Size(55, 20);
            this.nudSpdPercentage.TabIndex = 62;
            this.nudSpdPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMRPercentage
            // 
            this.nudMRPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMRPercentage.DecimalPlaces = 2;
            this.nudMRPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMRPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMRPercentage.Location = new System.Drawing.Point(80, 104);
            this.nudMRPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMRPercentage.Name = "nudMRPercentage";
            this.nudMRPercentage.Size = new System.Drawing.Size(55, 20);
            this.nudMRPercentage.TabIndex = 61;
            this.nudMRPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDefPercentage
            // 
            this.nudDefPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDefPercentage.DecimalPlaces = 2;
            this.nudDefPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDefPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDefPercentage.Location = new System.Drawing.Point(80, 76);
            this.nudDefPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDefPercentage.Name = "nudDefPercentage";
            this.nudDefPercentage.Size = new System.Drawing.Size(55, 20);
            this.nudDefPercentage.TabIndex = 60;
            this.nudDefPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMagPercentage
            // 
            this.nudMagPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMagPercentage.DecimalPlaces = 2;
            this.nudMagPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMagPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMagPercentage.Location = new System.Drawing.Point(80, 48);
            this.nudMagPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMagPercentage.Name = "nudMagPercentage";
            this.nudMagPercentage.Size = new System.Drawing.Size(55, 20);
            this.nudMagPercentage.TabIndex = 59;
            this.nudMagPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudStrPercentage
            // 
            this.nudStrPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStrPercentage.DecimalPlaces = 2;
            this.nudStrPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStrPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudStrPercentage.Location = new System.Drawing.Point(80, 20);
            this.nudStrPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStrPercentage.Name = "nudStrPercentage";
            this.nudStrPercentage.Size = new System.Drawing.Size(55, 20);
            this.nudStrPercentage.TabIndex = 58;
            this.nudStrPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSpd
            // 
            this.lblSpd.AutoSize = true;
            this.lblSpd.Location = new System.Drawing.Point(2, 137);
            this.lblSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(41, 13);
            this.lblSpd.TabIndex = 47;
            this.lblSpd.Text = "Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(3, 108);
            this.lblMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(61, 13);
            this.lblMR.TabIndex = 46;
            this.lblMR.Text = "Mag. resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(2, 80);
            this.lblDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(37, 13);
            this.lblDef.TabIndex = 45;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(3, 52);
            this.lblMag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(39, 13);
            this.lblMag.TabIndex = 44;
            this.lblMag.Text = "Magic:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(2, 24);
            this.lblStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(50, 13);
            this.lblStr.TabIndex = 43;
            this.lblStr.Text = "Strength:";
            // 
            // grpPhaseConditions
            // 
            this.grpPhaseConditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpPhaseConditions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPhaseConditions.Controls.Add(this.btnEditConditions);
            this.grpPhaseConditions.Controls.Add(this.btnEditBeginEvent);
            this.grpPhaseConditions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPhaseConditions.Location = new System.Drawing.Point(10, 73);
            this.grpPhaseConditions.Name = "grpPhaseConditions";
            this.grpPhaseConditions.Size = new System.Drawing.Size(358, 55);
            this.grpPhaseConditions.TabIndex = 38;
            this.grpPhaseConditions.TabStop = false;
            this.grpPhaseConditions.Text = "Conditions";
            // 
            // btnEditConditions
            // 
            this.btnEditConditions.Location = new System.Drawing.Point(7, 20);
            this.btnEditConditions.Name = "btnEditConditions";
            this.btnEditConditions.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditConditions.Size = new System.Drawing.Size(172, 23);
            this.btnEditConditions.TabIndex = 0;
            this.btnEditConditions.Text = "Edit Trigger Conditions";
            this.btnEditConditions.Click += new System.EventHandler(this.btnEditConditions_Click);
            // 
            // lblX5
            // 
            this.lblX5.AutoSize = true;
            this.lblX5.Location = new System.Drawing.Point(68, 135);
            this.lblX5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX5.Name = "lblX5";
            this.lblX5.Size = new System.Drawing.Size(12, 13);
            this.lblX5.TabIndex = 67;
            this.lblX5.Text = "x";
            // 
            // lblX4
            // 
            this.lblX4.AutoSize = true;
            this.lblX4.Location = new System.Drawing.Point(68, 106);
            this.lblX4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX4.Name = "lblX4";
            this.lblX4.Size = new System.Drawing.Size(12, 13);
            this.lblX4.TabIndex = 66;
            this.lblX4.Text = "x";
            // 
            // lblX3
            // 
            this.lblX3.AutoSize = true;
            this.lblX3.Location = new System.Drawing.Point(68, 78);
            this.lblX3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX3.Name = "lblX3";
            this.lblX3.Size = new System.Drawing.Size(12, 13);
            this.lblX3.TabIndex = 65;
            this.lblX3.Text = "x";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(68, 51);
            this.lblX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(12, 13);
            this.lblX2.TabIndex = 64;
            this.lblX2.Text = "x";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(68, 22);
            this.lblX1.Margin = new System.Windows.Forms.Padding(0);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(12, 13);
            this.lblX1.TabIndex = 63;
            this.lblX1.Text = "x";
            // 
            // NpcPhaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpEditor);
            this.Name = "NpcPhaseEditor";
            this.Size = new System.Drawing.Size(376, 527);
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.grpRegen.ResumeLayout(false);
            this.grpRegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).EndInit();
            this.grpPhaseConditions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpSpells;
        private DarkComboBox cmbSpell;
        private System.Windows.Forms.Label lblSpell;
        private DarkButton btnRemoveSpell;
        private DarkButton btnAddSpell;
        private System.Windows.Forms.ListBox lstSpells;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkButton btnEditBeginEvent;
        private DarkTextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private DarkTextBox txtDesc;
        private DarkGroupBox grpEditor;
        private DarkGroupBox grpPhaseConditions;
        private DarkButton btnEditConditions;
        private DarkCheckBox chkReplaceSpells;
        private DarkGroupBox grpStats;
        private DarkNumericUpDown nudSpdPercentage;
        private DarkNumericUpDown nudMRPercentage;
        private DarkNumericUpDown nudDefPercentage;
        private DarkNumericUpDown nudMagPercentage;
        private DarkNumericUpDown nudStrPercentage;
        private System.Windows.Forms.Label lblSpd;
        private System.Windows.Forms.Label lblMR;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.Label lblStr;
        private DarkGroupBox grpRegen;
        private DarkNumericUpDown nudMpRegen;
        private DarkNumericUpDown nudHpRegen;
        private System.Windows.Forms.Label lblHpRegen;
        private System.Windows.Forms.Label lblManaRegen;
        private DarkCheckBox chkChangeRegen;
        private System.Windows.Forms.Label lblX5;
        private System.Windows.Forms.Label lblX4;
        private System.Windows.Forms.Label lblX3;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
    }
}
