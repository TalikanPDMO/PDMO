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
            this.grpEditor = new DarkUI.Controls.DarkGroupBox();
            this.grpSprite = new DarkUI.Controls.DarkGroupBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.nudRgbaA = new DarkUI.Controls.DarkNumericUpDown();
            this.lblGreen = new System.Windows.Forms.Label();
            this.nudRgbaG = new DarkUI.Controls.DarkNumericUpDown();
            this.lblBlue = new System.Windows.Forms.Label();
            this.nudRgbaB = new DarkUI.Controls.DarkNumericUpDown();
            this.lblRed = new System.Windows.Forms.Label();
            this.nudRgbaR = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbSprite = new DarkUI.Controls.DarkComboBox();
            this.picNpc = new System.Windows.Forms.PictureBox();
            this.chkChangeSprite = new DarkUI.Controls.DarkCheckBox();
            this.grpDuration = new DarkUI.Controls.DarkGroupBox();
            this.chkDurationEnable = new DarkUI.Controls.DarkCheckBox();
            this.nudDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblDurationMs = new System.Windows.Forms.Label();
            this.grpAttackSpeed = new DarkUI.Controls.DarkGroupBox();
            this.chkChangeAttackSpeed = new DarkUI.Controls.DarkCheckBox();
            this.nudAttackSpeedValue = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAttackSpeedValue = new System.Windows.Forms.Label();
            this.cmbAttackSpeedModifier = new DarkUI.Controls.DarkComboBox();
            this.lblAttackSpeedModifier = new System.Windows.Forms.Label();
            this.grpCombat = new DarkUI.Controls.DarkGroupBox();
            this.chkChangeCombat = new DarkUI.Controls.DarkCheckBox();
            this.nudCritMultiplier = new DarkUI.Controls.DarkNumericUpDown();
            this.lblCritMultiplier = new System.Windows.Forms.Label();
            this.nudScaling = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudCritChance = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbScalingStat = new DarkUI.Controls.DarkComboBox();
            this.lblScalingStat = new System.Windows.Forms.Label();
            this.lblScaling = new System.Windows.Forms.Label();
            this.cmbDamageType = new DarkUI.Controls.DarkComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.lblCritChance = new System.Windows.Forms.Label();
            this.cmbAttackAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblAttackAnimation = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.grpRegen = new DarkUI.Controls.DarkGroupBox();
            this.chkChangeRegen = new DarkUI.Controls.DarkCheckBox();
            this.nudMpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHpRegen = new System.Windows.Forms.Label();
            this.lblManaRegen = new System.Windows.Forms.Label();
            this.grpStats = new DarkUI.Controls.DarkGroupBox();
            this.lblX5 = new System.Windows.Forms.Label();
            this.lblX4 = new System.Windows.Forms.Label();
            this.lblX3 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
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
            this.grpPhaseBegin = new DarkUI.Controls.DarkGroupBox();
            this.lblBeginAnimation = new System.Windows.Forms.Label();
            this.cmbBeginAnimation = new DarkUI.Controls.DarkComboBox();
            this.btnEditConditions = new DarkUI.Controls.DarkButton();
            this.grpSpells.SuspendLayout();
            this.grpEditor.SuspendLayout();
            this.grpSprite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNpc)).BeginInit();
            this.grpDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.grpAttackSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).BeginInit();
            this.grpCombat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).BeginInit();
            this.grpRegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).BeginInit();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).BeginInit();
            this.grpPhaseBegin.SuspendLayout();
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
            this.grpSpells.Location = new System.Drawing.Point(4, 153);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Size = new System.Drawing.Size(203, 185);
            this.grpSpells.TabIndex = 28;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells Modifier";
            // 
            // chkReplaceSpells
            // 
            this.chkReplaceSpells.AutoSize = true;
            this.chkReplaceSpells.Location = new System.Drawing.Point(48, 14);
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
            this.cmbSpell.Size = new System.Drawing.Size(191, 21);
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
            this.btnRemoveSpell.Location = new System.Drawing.Point(103, 158);
            this.btnRemoveSpell.Name = "btnRemoveSpell";
            this.btnRemoveSpell.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveSpell.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSpell.TabIndex = 46;
            this.btnRemoveSpell.Text = "Remove";
            this.btnRemoveSpell.Click += new System.EventHandler(this.btnRemoveSpell_Click);
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.Location = new System.Drawing.Point(25, 158);
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
            this.lstSpells.Size = new System.Drawing.Size(191, 80);
            this.lstSpells.TabIndex = 44;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(86, 554);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditBeginEvent
            // 
            this.btnEditBeginEvent.Location = new System.Drawing.Point(281, 22);
            this.btnEditBeginEvent.Name = "btnEditBeginEvent";
            this.btnEditBeginEvent.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditBeginEvent.Size = new System.Drawing.Size(77, 23);
            this.btnEditBeginEvent.TabIndex = 30;
            this.btnEditBeginEvent.Text = "Begin Event";
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
            // grpEditor
            // 
            this.grpEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEditor.Controls.Add(this.grpSprite);
            this.grpEditor.Controls.Add(this.grpDuration);
            this.grpEditor.Controls.Add(this.grpAttackSpeed);
            this.grpEditor.Controls.Add(this.grpCombat);
            this.grpEditor.Controls.Add(this.grpRegen);
            this.grpEditor.Controls.Add(this.grpStats);
            this.grpEditor.Controls.Add(this.grpPhaseBegin);
            this.grpEditor.Controls.Add(this.lblName);
            this.grpEditor.Controls.Add(this.txtName);
            this.grpEditor.Controls.Add(this.btnSave);
            this.grpEditor.Controls.Add(this.btnCancel);
            this.grpEditor.Controls.Add(this.grpSpells);
            this.grpEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEditor.Location = new System.Drawing.Point(0, 2);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(373, 583);
            this.grpEditor.TabIndex = 18;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "Phase Editor";
            // 
            // grpSprite
            // 
            this.grpSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSprite.Controls.Add(this.lblAlpha);
            this.grpSprite.Controls.Add(this.nudRgbaA);
            this.grpSprite.Controls.Add(this.lblGreen);
            this.grpSprite.Controls.Add(this.nudRgbaG);
            this.grpSprite.Controls.Add(this.lblBlue);
            this.grpSprite.Controls.Add(this.nudRgbaB);
            this.grpSprite.Controls.Add(this.lblRed);
            this.grpSprite.Controls.Add(this.nudRgbaR);
            this.grpSprite.Controls.Add(this.cmbSprite);
            this.grpSprite.Controls.Add(this.picNpc);
            this.grpSprite.Controls.Add(this.chkChangeSprite);
            this.grpSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSprite.Location = new System.Drawing.Point(144, 7);
            this.grpSprite.Name = "grpSprite";
            this.grpSprite.Size = new System.Drawing.Size(224, 97);
            this.grpSprite.TabIndex = 66;
            this.grpSprite.TabStop = false;
            this.grpSprite.Text = "Sprite Modifier";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(141, 75);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(37, 13);
            this.lblAlpha.TabIndex = 83;
            this.lblAlpha.Text = "Alpha:";
            // 
            // nudRgbaA
            // 
            this.nudRgbaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaA.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaA.Location = new System.Drawing.Point(180, 73);
            this.nudRgbaA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaA.Name = "nudRgbaA";
            this.nudRgbaA.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaA.TabIndex = 82;
            this.nudRgbaA.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaA.ValueChanged += new System.EventHandler(this.DrawNpcSprite);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(141, 52);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 13);
            this.lblGreen.TabIndex = 81;
            this.lblGreen.Text = "Green:";
            // 
            // nudRgbaG
            // 
            this.nudRgbaG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaG.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaG.Location = new System.Drawing.Point(180, 50);
            this.nudRgbaG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaG.Name = "nudRgbaG";
            this.nudRgbaG.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaG.TabIndex = 80;
            this.nudRgbaG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaG.ValueChanged += new System.EventHandler(this.DrawNpcSprite);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(67, 75);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 13);
            this.lblBlue.TabIndex = 79;
            this.lblBlue.Text = "Blue:";
            // 
            // nudRgbaB
            // 
            this.nudRgbaB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaB.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaB.Location = new System.Drawing.Point(98, 73);
            this.nudRgbaB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaB.Name = "nudRgbaB";
            this.nudRgbaB.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaB.TabIndex = 78;
            this.nudRgbaB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaB.ValueChanged += new System.EventHandler(this.DrawNpcSprite);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(67, 52);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 13);
            this.lblRed.TabIndex = 77;
            this.lblRed.Text = "Red:";
            // 
            // nudRgbaR
            // 
            this.nudRgbaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaR.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaR.Location = new System.Drawing.Point(98, 50);
            this.nudRgbaR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaR.Name = "nudRgbaR";
            this.nudRgbaR.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaR.TabIndex = 76;
            this.nudRgbaR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaR.ValueChanged += new System.EventHandler(this.DrawNpcSprite);
            // 
            // cmbSprite
            // 
            this.cmbSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSprite.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSprite.DrawDropdownHoverOutline = false;
            this.cmbSprite.DrawFocusRectangle = false;
            this.cmbSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSprite.FormattingEnabled = true;
            this.cmbSprite.Items.AddRange(new object[] {
            "None"});
            this.cmbSprite.Location = new System.Drawing.Point(69, 26);
            this.cmbSprite.Name = "cmbSprite";
            this.cmbSprite.Size = new System.Drawing.Size(153, 21);
            this.cmbSprite.TabIndex = 67;
            this.cmbSprite.Text = "None";
            this.cmbSprite.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSprite.SelectedIndexChanged += new System.EventHandler(this.DrawNpcSprite);
            this.cmbSprite.EnabledChanged += new System.EventHandler(this.comboBoxes_EnableChanged);
            // 
            // picNpc
            // 
            this.picNpc.BackColor = System.Drawing.Color.Black;
            this.picNpc.Location = new System.Drawing.Point(3, 26);
            this.picNpc.Name = "picNpc";
            this.picNpc.Size = new System.Drawing.Size(64, 64);
            this.picNpc.TabIndex = 52;
            this.picNpc.TabStop = false;
            // 
            // chkChangeSprite
            // 
            this.chkChangeSprite.AutoSize = true;
            this.chkChangeSprite.Location = new System.Drawing.Point(124, 8);
            this.chkChangeSprite.Name = "chkChangeSprite";
            this.chkChangeSprite.Size = new System.Drawing.Size(98, 17);
            this.chkChangeSprite.TabIndex = 51;
            this.chkChangeSprite.Text = "Replace base?";
            this.chkChangeSprite.CheckedChanged += new System.EventHandler(this.chkChangeSprite_CheckedChanged);
            // 
            // grpDuration
            // 
            this.grpDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDuration.Controls.Add(this.chkDurationEnable);
            this.grpDuration.Controls.Add(this.nudDuration);
            this.grpDuration.Controls.Add(this.lblDurationMs);
            this.grpDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDuration.Location = new System.Drawing.Point(168, 543);
            this.grpDuration.Name = "grpDuration";
            this.grpDuration.Size = new System.Drawing.Size(200, 38);
            this.grpDuration.TabIndex = 65;
            this.grpDuration.TabStop = false;
            this.grpDuration.Text = "Phase Duration";
            // 
            // chkDurationEnable
            // 
            this.chkDurationEnable.AutoSize = true;
            this.chkDurationEnable.Location = new System.Drawing.Point(5, 16);
            this.chkDurationEnable.Name = "chkDurationEnable";
            this.chkDurationEnable.Size = new System.Drawing.Size(59, 17);
            this.chkDurationEnable.TabIndex = 51;
            this.chkDurationEnable.Text = "Enable";
            this.chkDurationEnable.CheckedChanged += new System.EventHandler(this.chkDurationEnable_CheckedChanged);
            // 
            // nudDuration
            // 
            this.nudDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDuration.Location = new System.Drawing.Point(64, 15);
            this.nudDuration.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(109, 20);
            this.nudDuration.TabIndex = 56;
            this.nudDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblDurationMs
            // 
            this.lblDurationMs.AutoSize = true;
            this.lblDurationMs.Location = new System.Drawing.Point(173, 19);
            this.lblDurationMs.Name = "lblDurationMs";
            this.lblDurationMs.Size = new System.Drawing.Size(26, 13);
            this.lblDurationMs.TabIndex = 29;
            this.lblDurationMs.Text = "(ms)";
            // 
            // grpAttackSpeed
            // 
            this.grpAttackSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAttackSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAttackSpeed.Controls.Add(this.chkChangeAttackSpeed);
            this.grpAttackSpeed.Controls.Add(this.nudAttackSpeedValue);
            this.grpAttackSpeed.Controls.Add(this.lblAttackSpeedValue);
            this.grpAttackSpeed.Controls.Add(this.cmbAttackSpeedModifier);
            this.grpAttackSpeed.Controls.Add(this.lblAttackSpeedModifier);
            this.grpAttackSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAttackSpeed.Location = new System.Drawing.Point(218, 401);
            this.grpAttackSpeed.Name = "grpAttackSpeed";
            this.grpAttackSpeed.Size = new System.Drawing.Size(150, 88);
            this.grpAttackSpeed.TabIndex = 64;
            this.grpAttackSpeed.TabStop = false;
            this.grpAttackSpeed.Text = "AttackSpeed Modifier";
            // 
            // chkChangeAttackSpeed
            // 
            this.chkChangeAttackSpeed.AutoSize = true;
            this.chkChangeAttackSpeed.Location = new System.Drawing.Point(51, 16);
            this.chkChangeAttackSpeed.Name = "chkChangeAttackSpeed";
            this.chkChangeAttackSpeed.Size = new System.Drawing.Size(98, 17);
            this.chkChangeAttackSpeed.TabIndex = 51;
            this.chkChangeAttackSpeed.Text = "Replace base?";
            this.chkChangeAttackSpeed.CheckedChanged += new System.EventHandler(this.chkChangeAttackSpeed_CheckedChanged);
            // 
            // nudAttackSpeedValue
            // 
            this.nudAttackSpeedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAttackSpeedValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAttackSpeedValue.Location = new System.Drawing.Point(53, 64);
            this.nudAttackSpeedValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAttackSpeedValue.Name = "nudAttackSpeedValue";
            this.nudAttackSpeedValue.Size = new System.Drawing.Size(92, 20);
            this.nudAttackSpeedValue.TabIndex = 56;
            this.nudAttackSpeedValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblAttackSpeedValue
            // 
            this.lblAttackSpeedValue.AutoSize = true;
            this.lblAttackSpeedValue.Location = new System.Drawing.Point(2, 66);
            this.lblAttackSpeedValue.Name = "lblAttackSpeedValue";
            this.lblAttackSpeedValue.Size = new System.Drawing.Size(37, 13);
            this.lblAttackSpeedValue.TabIndex = 29;
            this.lblAttackSpeedValue.Text = "Value:";
            // 
            // cmbAttackSpeedModifier
            // 
            this.cmbAttackSpeedModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAttackSpeedModifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAttackSpeedModifier.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAttackSpeedModifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAttackSpeedModifier.DrawDropdownHoverOutline = false;
            this.cmbAttackSpeedModifier.DrawFocusRectangle = false;
            this.cmbAttackSpeedModifier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAttackSpeedModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttackSpeedModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAttackSpeedModifier.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAttackSpeedModifier.FormattingEnabled = true;
            this.cmbAttackSpeedModifier.Location = new System.Drawing.Point(53, 38);
            this.cmbAttackSpeedModifier.Name = "cmbAttackSpeedModifier";
            this.cmbAttackSpeedModifier.Size = new System.Drawing.Size(92, 21);
            this.cmbAttackSpeedModifier.TabIndex = 28;
            this.cmbAttackSpeedModifier.Text = null;
            this.cmbAttackSpeedModifier.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackSpeedModifier.SelectedIndexChanged += new System.EventHandler(this.cmbAttackSpeedModifier_SelectedIndexChanged);
            this.cmbAttackSpeedModifier.EnabledChanged += new System.EventHandler(this.comboBoxes_EnableChanged);
            // 
            // lblAttackSpeedModifier
            // 
            this.lblAttackSpeedModifier.AutoSize = true;
            this.lblAttackSpeedModifier.Location = new System.Drawing.Point(2, 41);
            this.lblAttackSpeedModifier.Name = "lblAttackSpeedModifier";
            this.lblAttackSpeedModifier.Size = new System.Drawing.Size(47, 13);
            this.lblAttackSpeedModifier.TabIndex = 0;
            this.lblAttackSpeedModifier.Text = "Modifier:";
            // 
            // grpCombat
            // 
            this.grpCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCombat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCombat.Controls.Add(this.chkChangeCombat);
            this.grpCombat.Controls.Add(this.nudCritMultiplier);
            this.grpCombat.Controls.Add(this.lblCritMultiplier);
            this.grpCombat.Controls.Add(this.nudScaling);
            this.grpCombat.Controls.Add(this.nudDamage);
            this.grpCombat.Controls.Add(this.nudCritChance);
            this.grpCombat.Controls.Add(this.cmbScalingStat);
            this.grpCombat.Controls.Add(this.lblScalingStat);
            this.grpCombat.Controls.Add(this.lblScaling);
            this.grpCombat.Controls.Add(this.cmbDamageType);
            this.grpCombat.Controls.Add(this.lblDamageType);
            this.grpCombat.Controls.Add(this.lblCritChance);
            this.grpCombat.Controls.Add(this.cmbAttackAnimation);
            this.grpCombat.Controls.Add(this.lblAttackAnimation);
            this.grpCombat.Controls.Add(this.lblDamage);
            this.grpCombat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCombat.Location = new System.Drawing.Point(4, 340);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(203, 202);
            this.grpCombat.TabIndex = 53;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat Modifier";
            // 
            // chkChangeCombat
            // 
            this.chkChangeCombat.AutoSize = true;
            this.chkChangeCombat.Location = new System.Drawing.Point(104, 9);
            this.chkChangeCombat.Name = "chkChangeCombat";
            this.chkChangeCombat.Size = new System.Drawing.Size(98, 17);
            this.chkChangeCombat.TabIndex = 64;
            this.chkChangeCombat.Text = "Replace base?";
            this.chkChangeCombat.CheckedChanged += new System.EventHandler(this.chkChangeCombat_CheckedChanged);
            // 
            // nudCritMultiplier
            // 
            this.nudCritMultiplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritMultiplier.DecimalPlaces = 2;
            this.nudCritMultiplier.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCritMultiplier.Location = new System.Drawing.Point(108, 90);
            this.nudCritMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCritMultiplier.Name = "nudCritMultiplier";
            this.nudCritMultiplier.Size = new System.Drawing.Size(90, 20);
            this.nudCritMultiplier.TabIndex = 63;
            this.nudCritMultiplier.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblCritMultiplier
            // 
            this.lblCritMultiplier.AutoSize = true;
            this.lblCritMultiplier.Location = new System.Drawing.Point(105, 74);
            this.lblCritMultiplier.Name = "lblCritMultiplier";
            this.lblCritMultiplier.Size = new System.Drawing.Size(69, 13);
            this.lblCritMultiplier.TabIndex = 62;
            this.lblCritMultiplier.Text = "Crit Multiplier:";
            // 
            // nudScaling
            // 
            this.nudScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudScaling.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudScaling.Location = new System.Drawing.Point(108, 135);
            this.nudScaling.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudScaling.Name = "nudScaling";
            this.nudScaling.Size = new System.Drawing.Size(90, 20);
            this.nudScaling.TabIndex = 61;
            this.nudScaling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudDamage
            // 
            this.nudDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDamage.Location = new System.Drawing.Point(4, 46);
            this.nudDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(90, 20);
            this.nudDamage.TabIndex = 60;
            this.nudDamage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudCritChance
            // 
            this.nudCritChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritChance.Location = new System.Drawing.Point(5, 90);
            this.nudCritChance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCritChance.Name = "nudCritChance";
            this.nudCritChance.Size = new System.Drawing.Size(90, 20);
            this.nudCritChance.TabIndex = 59;
            this.nudCritChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbScalingStat
            // 
            this.cmbScalingStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbScalingStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbScalingStat.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbScalingStat.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbScalingStat.DrawDropdownHoverOutline = false;
            this.cmbScalingStat.DrawFocusRectangle = false;
            this.cmbScalingStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbScalingStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScalingStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScalingStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbScalingStat.FormattingEnabled = true;
            this.cmbScalingStat.Location = new System.Drawing.Point(5, 135);
            this.cmbScalingStat.Name = "cmbScalingStat";
            this.cmbScalingStat.Size = new System.Drawing.Size(90, 21);
            this.cmbScalingStat.TabIndex = 58;
            this.cmbScalingStat.Text = null;
            this.cmbScalingStat.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbScalingStat.EnabledChanged += new System.EventHandler(this.comboBoxes_EnableChanged);
            // 
            // lblScalingStat
            // 
            this.lblScalingStat.AutoSize = true;
            this.lblScalingStat.Location = new System.Drawing.Point(2, 118);
            this.lblScalingStat.Name = "lblScalingStat";
            this.lblScalingStat.Size = new System.Drawing.Size(67, 13);
            this.lblScalingStat.TabIndex = 57;
            this.lblScalingStat.Text = "Scaling Stat:";
            // 
            // lblScaling
            // 
            this.lblScaling.AutoSize = true;
            this.lblScaling.Location = new System.Drawing.Point(105, 118);
            this.lblScaling.Name = "lblScaling";
            this.lblScaling.Size = new System.Drawing.Size(84, 13);
            this.lblScaling.TabIndex = 56;
            this.lblScaling.Text = "Scaling Amount:";
            // 
            // cmbDamageType
            // 
            this.cmbDamageType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDamageType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDamageType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDamageType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDamageType.DrawDropdownHoverOutline = false;
            this.cmbDamageType.DrawFocusRectangle = false;
            this.cmbDamageType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDamageType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDamageType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDamageType.FormattingEnabled = true;
            this.cmbDamageType.Items.AddRange(new object[] {
            "Physical",
            "Magic",
            "True"});
            this.cmbDamageType.Location = new System.Drawing.Point(108, 46);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(90, 21);
            this.cmbDamageType.TabIndex = 54;
            this.cmbDamageType.Text = "Physical";
            this.cmbDamageType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDamageType.EnabledChanged += new System.EventHandler(this.comboBoxes_EnableChanged);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(105, 30);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(77, 13);
            this.lblDamageType.TabIndex = 53;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(1, 74);
            this.lblCritChance.Name = "lblCritChance";
            this.lblCritChance.Size = new System.Drawing.Size(82, 13);
            this.lblCritChance.TabIndex = 52;
            this.lblCritChance.Text = "Crit Chance (%):";
            // 
            // cmbAttackAnimation
            // 
            this.cmbAttackAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAttackAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAttackAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAttackAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAttackAnimation.DrawDropdownHoverOutline = false;
            this.cmbAttackAnimation.DrawFocusRectangle = false;
            this.cmbAttackAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAttackAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttackAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAttackAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAttackAnimation.FormattingEnabled = true;
            this.cmbAttackAnimation.Location = new System.Drawing.Point(4, 177);
            this.cmbAttackAnimation.Name = "cmbAttackAnimation";
            this.cmbAttackAnimation.Size = new System.Drawing.Size(194, 21);
            this.cmbAttackAnimation.TabIndex = 50;
            this.cmbAttackAnimation.Text = null;
            this.cmbAttackAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackAnimation.EnabledChanged += new System.EventHandler(this.comboBoxes_EnableChanged);
            // 
            // lblAttackAnimation
            // 
            this.lblAttackAnimation.AutoSize = true;
            this.lblAttackAnimation.Location = new System.Drawing.Point(1, 162);
            this.lblAttackAnimation.Name = "lblAttackAnimation";
            this.lblAttackAnimation.Size = new System.Drawing.Size(90, 13);
            this.lblAttackAnimation.TabIndex = 49;
            this.lblAttackAnimation.Text = "Attack Animation:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(1, 30);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(77, 13);
            this.lblDamage.TabIndex = 48;
            this.lblDamage.Text = "Base Damage:";
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
            this.grpRegen.Location = new System.Drawing.Point(218, 321);
            this.grpRegen.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegen.Name = "grpRegen";
            this.grpRegen.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegen.Size = new System.Drawing.Size(150, 75);
            this.grpRegen.TabIndex = 52;
            this.grpRegen.TabStop = false;
            this.grpRegen.Text = "Regen Modifier";
            // 
            // chkChangeRegen
            // 
            this.chkChangeRegen.AutoSize = true;
            this.chkChangeRegen.Location = new System.Drawing.Point(51, 16);
            this.chkChangeRegen.Name = "chkChangeRegen";
            this.chkChangeRegen.Size = new System.Drawing.Size(98, 17);
            this.chkChangeRegen.TabIndex = 50;
            this.chkChangeRegen.Text = "Replace base?";
            this.chkChangeRegen.CheckedChanged += new System.EventHandler(this.chkChangeRegen_CheckedChanged);
            // 
            // nudMpRegen
            // 
            this.nudMpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpRegen.Location = new System.Drawing.Point(67, 50);
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
            this.nudHpRegen.Location = new System.Drawing.Point(5, 50);
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
            this.lblHpRegen.Location = new System.Drawing.Point(11, 35);
            this.lblHpRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHpRegen.Name = "lblHpRegen";
            this.lblHpRegen.Size = new System.Drawing.Size(42, 13);
            this.lblHpRegen.TabIndex = 26;
            this.lblHpRegen.Text = "HP: (%)";
            // 
            // lblManaRegen
            // 
            this.lblManaRegen.AutoSize = true;
            this.lblManaRegen.Location = new System.Drawing.Point(66, 35);
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
            this.grpStats.Location = new System.Drawing.Point(218, 153);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(150, 163);
            this.grpStats.TabIndex = 51;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats Multiplier";
            // 
            // lblX5
            // 
            this.lblX5.AutoSize = true;
            this.lblX5.Location = new System.Drawing.Point(74, 135);
            this.lblX5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX5.Name = "lblX5";
            this.lblX5.Size = new System.Drawing.Size(12, 13);
            this.lblX5.TabIndex = 67;
            this.lblX5.Text = "x";
            // 
            // lblX4
            // 
            this.lblX4.AutoSize = true;
            this.lblX4.Location = new System.Drawing.Point(74, 106);
            this.lblX4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX4.Name = "lblX4";
            this.lblX4.Size = new System.Drawing.Size(12, 13);
            this.lblX4.TabIndex = 66;
            this.lblX4.Text = "x";
            // 
            // lblX3
            // 
            this.lblX3.AutoSize = true;
            this.lblX3.Location = new System.Drawing.Point(74, 78);
            this.lblX3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX3.Name = "lblX3";
            this.lblX3.Size = new System.Drawing.Size(12, 13);
            this.lblX3.TabIndex = 65;
            this.lblX3.Text = "x";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(74, 51);
            this.lblX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(12, 13);
            this.lblX2.TabIndex = 64;
            this.lblX2.Text = "x";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(74, 22);
            this.lblX1.Margin = new System.Windows.Forms.Padding(0);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(12, 13);
            this.lblX1.TabIndex = 63;
            this.lblX1.Text = "x";
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
            this.nudSpdPercentage.Location = new System.Drawing.Point(86, 133);
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
            this.nudMRPercentage.Location = new System.Drawing.Point(86, 104);
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
            this.nudDefPercentage.Location = new System.Drawing.Point(86, 76);
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
            this.nudMagPercentage.Location = new System.Drawing.Point(86, 48);
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
            this.nudStrPercentage.Location = new System.Drawing.Point(86, 20);
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
            this.lblSpd.Location = new System.Drawing.Point(8, 137);
            this.lblSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(41, 13);
            this.lblSpd.TabIndex = 47;
            this.lblSpd.Text = "Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(9, 108);
            this.lblMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(61, 13);
            this.lblMR.TabIndex = 46;
            this.lblMR.Text = "Mag. resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(8, 80);
            this.lblDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(37, 13);
            this.lblDef.TabIndex = 45;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(9, 52);
            this.lblMag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(39, 13);
            this.lblMag.TabIndex = 44;
            this.lblMag.Text = "Magic:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(8, 24);
            this.lblStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(50, 13);
            this.lblStr.TabIndex = 43;
            this.lblStr.Text = "Strength:";
            // 
            // grpPhaseBegin
            // 
            this.grpPhaseBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpPhaseBegin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPhaseBegin.Controls.Add(this.lblBeginAnimation);
            this.grpPhaseBegin.Controls.Add(this.cmbBeginAnimation);
            this.grpPhaseBegin.Controls.Add(this.btnEditConditions);
            this.grpPhaseBegin.Controls.Add(this.btnEditBeginEvent);
            this.grpPhaseBegin.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPhaseBegin.Location = new System.Drawing.Point(4, 101);
            this.grpPhaseBegin.Name = "grpPhaseBegin";
            this.grpPhaseBegin.Size = new System.Drawing.Size(364, 50);
            this.grpPhaseBegin.TabIndex = 38;
            this.grpPhaseBegin.TabStop = false;
            this.grpPhaseBegin.Text = "Phase Beginning";
            // 
            // lblBeginAnimation
            // 
            this.lblBeginAnimation.AutoSize = true;
            this.lblBeginAnimation.Location = new System.Drawing.Point(150, 10);
            this.lblBeginAnimation.Name = "lblBeginAnimation";
            this.lblBeginAnimation.Size = new System.Drawing.Size(81, 13);
            this.lblBeginAnimation.TabIndex = 66;
            this.lblBeginAnimation.Text = "NPC Animation:";
            // 
            // cmbBeginAnimation
            // 
            this.cmbBeginAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbBeginAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbBeginAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbBeginAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbBeginAnimation.DrawDropdownHoverOutline = false;
            this.cmbBeginAnimation.DrawFocusRectangle = false;
            this.cmbBeginAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBeginAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeginAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBeginAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbBeginAnimation.FormattingEnabled = true;
            this.cmbBeginAnimation.Location = new System.Drawing.Point(121, 24);
            this.cmbBeginAnimation.Name = "cmbBeginAnimation";
            this.cmbBeginAnimation.Size = new System.Drawing.Size(153, 21);
            this.cmbBeginAnimation.TabIndex = 65;
            this.cmbBeginAnimation.Text = null;
            this.cmbBeginAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // btnEditConditions
            // 
            this.btnEditConditions.Location = new System.Drawing.Point(5, 22);
            this.btnEditConditions.Name = "btnEditConditions";
            this.btnEditConditions.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditConditions.Size = new System.Drawing.Size(109, 23);
            this.btnEditConditions.TabIndex = 0;
            this.btnEditConditions.Text = "Trigger Conditions";
            this.btnEditConditions.Click += new System.EventHandler(this.btnEditConditions_Click);
            // 
            // NpcPhaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpEditor);
            this.Name = "NpcPhaseEditor";
            this.Size = new System.Drawing.Size(399, 588);
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.grpSprite.ResumeLayout(false);
            this.grpSprite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNpc)).EndInit();
            this.grpDuration.ResumeLayout(false);
            this.grpDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.grpAttackSpeed.ResumeLayout(false);
            this.grpAttackSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).EndInit();
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).EndInit();
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
            this.grpPhaseBegin.ResumeLayout(false);
            this.grpPhaseBegin.PerformLayout();
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
        private DarkGroupBox grpEditor;
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
        private DarkGroupBox grpAttackSpeed;
        private DarkNumericUpDown nudAttackSpeedValue;
        private System.Windows.Forms.Label lblAttackSpeedValue;
        private DarkComboBox cmbAttackSpeedModifier;
        private System.Windows.Forms.Label lblAttackSpeedModifier;
        private DarkGroupBox grpCombat;
        private DarkNumericUpDown nudCritMultiplier;
        private System.Windows.Forms.Label lblCritMultiplier;
        private DarkNumericUpDown nudScaling;
        private DarkNumericUpDown nudDamage;
        private DarkNumericUpDown nudCritChance;
        private DarkComboBox cmbScalingStat;
        private System.Windows.Forms.Label lblScalingStat;
        private System.Windows.Forms.Label lblScaling;
        private DarkComboBox cmbDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.Label lblCritChance;
        private DarkComboBox cmbAttackAnimation;
        private System.Windows.Forms.Label lblAttackAnimation;
        private System.Windows.Forms.Label lblDamage;
        private DarkCheckBox chkChangeAttackSpeed;
        private DarkCheckBox chkChangeCombat;
        private DarkComboBox cmbBeginAnimation;
        private DarkGroupBox grpPhaseBegin;
        private System.Windows.Forms.Label lblBeginAnimation;
        private DarkGroupBox grpDuration;
        private DarkCheckBox chkDurationEnable;
        private DarkNumericUpDown nudDuration;
        private System.Windows.Forms.Label lblDurationMs;
        private DarkGroupBox grpSprite;
        private DarkCheckBox chkChangeSprite;
        private System.Windows.Forms.PictureBox picNpc;
        private DarkComboBox cmbSprite;
        private System.Windows.Forms.Label lblBlue;
        private DarkNumericUpDown nudRgbaB;
        private System.Windows.Forms.Label lblRed;
        private DarkNumericUpDown nudRgbaR;
        private System.Windows.Forms.Label lblAlpha;
        private DarkNumericUpDown nudRgbaA;
        private System.Windows.Forms.Label lblGreen;
        private DarkNumericUpDown nudRgbaG;
    }
}
