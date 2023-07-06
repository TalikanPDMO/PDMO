using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmNpc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNpc));
            this.grpNpcs = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstGameObjects = new Intersect.Editor.Forms.Controls.GameObjectList();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.grpTypes = new DarkUI.Controls.DarkGroupBox();
            this.cmbType1 = new DarkUI.Controls.DarkComboBox();
            this.lblType1 = new System.Windows.Forms.Label();
            this.cmbType2 = new DarkUI.Controls.DarkComboBox();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblEditorName = new System.Windows.Forms.Label();
            this.txtEditorName = new DarkUI.Controls.DarkTextBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.nudRgbaA = new DarkUI.Controls.DarkNumericUpDown();
            this.nudRgbaB = new DarkUI.Controls.DarkNumericUpDown();
            this.nudRgbaG = new DarkUI.Controls.DarkNumericUpDown();
            this.nudRgbaR = new DarkUI.Controls.DarkNumericUpDown();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.nudLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbSprite = new DarkUI.Controls.DarkComboBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.picNpc = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.nudSpawnDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSpawnDuration = new System.Windows.Forms.Label();
            this.nudSightRange = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSightRange = new System.Windows.Forms.Label();
            this.grpStats = new DarkUI.Controls.DarkGroupBox();
            this.nudExp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMana = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpd = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMR = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDef = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMag = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStr = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSpd = new System.Windows.Forms.Label();
            this.lblMR = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblMag = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpPhases = new DarkUI.Controls.DarkGroupBox();
            this.btnRemovePhase = new DarkUI.Controls.DarkButton();
            this.btnAddPhase = new DarkUI.Controls.DarkButton();
            this.lstPhases = new System.Windows.Forms.ListBox();
            this.grpCombat = new DarkUI.Controls.DarkGroupBox();
            this.grpAttackSpeed = new DarkUI.Controls.DarkGroupBox();
            this.nudAttackSpeedValue = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAttackSpeedValue = new System.Windows.Forms.Label();
            this.cmbAttackSpeedModifier = new DarkUI.Controls.DarkComboBox();
            this.lblAttackSpeedModifier = new System.Windows.Forms.Label();
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
            this.grpCommonEvents = new DarkUI.Controls.DarkGroupBox();
            this.cmbOnDeathEventParty = new DarkUI.Controls.DarkComboBox();
            this.lblOnDeathEventParty = new System.Windows.Forms.Label();
            this.cmbOnDeathEventKiller = new DarkUI.Controls.DarkComboBox();
            this.lblOnDeathEventKiller = new System.Windows.Forms.Label();
            this.grpBehavior = new DarkUI.Controls.DarkGroupBox();
            this.cmbNpcToSwarm = new DarkUI.Controls.DarkComboBox();
            this.lblNpcToSwarm = new System.Windows.Forms.Label();
            this.btnRemoveSwarm = new DarkUI.Controls.DarkButton();
            this.btnAddSwarm = new DarkUI.Controls.DarkButton();
            this.lstSwarm = new System.Windows.Forms.ListBox();
            this.chkAttackOnFlee = new DarkUI.Controls.DarkCheckBox();
            this.chkSwarmAll = new DarkUI.Controls.DarkCheckBox();
            this.nudSwarmRange = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSwarmRange = new System.Windows.Forms.Label();
            this.chkSwarmOnPlayer = new DarkUI.Controls.DarkCheckBox();
            this.lblMaxMove = new System.Windows.Forms.Label();
            this.nudMaxMove = new DarkUI.Controls.DarkNumericUpDown();
            this.nudResetRadius = new DarkUI.Controls.DarkNumericUpDown();
            this.lblResetRadius = new System.Windows.Forms.Label();
            this.lblFocusDamageDealer = new System.Windows.Forms.Label();
            this.chkFocusDamageDealer = new DarkUI.Controls.DarkCheckBox();
            this.nudFlee = new DarkUI.Controls.DarkNumericUpDown();
            this.lblFlee = new System.Windows.Forms.Label();
            this.chkSwarm = new DarkUI.Controls.DarkCheckBox();
            this.grpConditions = new DarkUI.Controls.DarkGroupBox();
            this.btnPlayerCanProjectileCond = new DarkUI.Controls.DarkButton();
            this.btnPlayerCanSpellCond = new DarkUI.Controls.DarkButton();
            this.btnAttackOnSightCond = new DarkUI.Controls.DarkButton();
            this.btnPlayerCanAttackCond = new DarkUI.Controls.DarkButton();
            this.btnPlayerFriendProtectorCond = new DarkUI.Controls.DarkButton();
            this.lblMovement = new System.Windows.Forms.Label();
            this.cmbMovement = new DarkUI.Controls.DarkComboBox();
            this.chkAggressive = new DarkUI.Controls.DarkCheckBox();
            this.grpRegen = new DarkUI.Controls.DarkGroupBox();
            this.chkRegenReset = new DarkUI.Controls.DarkCheckBox();
            this.nudMpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHpRegen = new System.Windows.Forms.Label();
            this.lblManaRegen = new System.Windows.Forms.Label();
            this.lblRegenHint = new System.Windows.Forms.Label();
            this.grpDrops = new DarkUI.Controls.DarkGroupBox();
            this.chkDropChanceIterative = new DarkUI.Controls.DarkCheckBox();
            this.chkDropAmountRandom = new DarkUI.Controls.DarkCheckBox();
            this.chkIndividualLoot = new DarkUI.Controls.DarkCheckBox();
            this.btnDropRemove = new DarkUI.Controls.DarkButton();
            this.btnDropAdd = new DarkUI.Controls.DarkButton();
            this.lstDrops = new System.Windows.Forms.ListBox();
            this.nudDropAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDropChance = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbDropItem = new DarkUI.Controls.DarkComboBox();
            this.lblDropAmount = new System.Windows.Forms.Label();
            this.lblDropChance = new System.Windows.Forms.Label();
            this.lblDropItem = new System.Windows.Forms.Label();
            this.grpNpcVsNpc = new DarkUI.Controls.DarkGroupBox();
            this.cmbHostileNPC = new DarkUI.Controls.DarkComboBox();
            this.lblNPC = new System.Windows.Forms.Label();
            this.btnRemoveAggro = new DarkUI.Controls.DarkButton();
            this.btnAddAggro = new DarkUI.Controls.DarkButton();
            this.lstAggro = new System.Windows.Forms.ListBox();
            this.chkAttackAllies = new DarkUI.Controls.DarkCheckBox();
            this.chkEnabled = new DarkUI.Controls.DarkCheckBox();
            this.grpSpells = new DarkUI.Controls.DarkGroupBox();
            this.nudSpellFrequency = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpellPriority = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPrioritySpell = new System.Windows.Forms.Label();
            this.nudAfterSpell = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAfterSpell = new System.Windows.Forms.Label();
            this.nudBeforeSpell = new DarkUI.Controls.DarkNumericUpDown();
            this.lblBeforeSpell = new System.Windows.Forms.Label();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblSpell = new System.Windows.Forms.Label();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.lstSpells = new System.Windows.Forms.ListBox();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
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
            this.searchableDarkTreeView1 = new Intersect.Editor.Forms.Controls.SearchableDarkTreeView();
            this.nudAttackRange = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAttackRange = new System.Windows.Forms.Label();
            this.grpNpcs.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSightRange)).BeginInit();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.grpPhases.SuspendLayout();
            this.grpCombat.SuspendLayout();
            this.grpAttackSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).BeginInit();
            this.grpCommonEvents.SuspendLayout();
            this.grpBehavior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwarmRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResetRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlee)).BeginInit();
            this.grpConditions.SuspendLayout();
            this.grpRegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).BeginInit();
            this.grpDrops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropChance)).BeginInit();
            this.grpNpcVsNpc.SuspendLayout();
            this.grpSpells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpellFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpellPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfterSpell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeforeSpell)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackRange)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNpcs
            // 
            this.grpNpcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpNpcs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpNpcs.Controls.Add(this.btnClearSearch);
            this.grpNpcs.Controls.Add(this.txtSearch);
            this.grpNpcs.Controls.Add(this.lstGameObjects);
            this.grpNpcs.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpNpcs.Location = new System.Drawing.Point(12, 39);
            this.grpNpcs.Name = "grpNpcs";
            this.grpNpcs.Size = new System.Drawing.Size(203, 570);
            this.grpNpcs.TabIndex = 13;
            this.grpNpcs.TabStop = false;
            this.grpNpcs.Text = "NPCs";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(179, 18);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearSearch.Size = new System.Drawing.Size(18, 20);
            this.btnClearSearch.TabIndex = 34;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 33;
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
            this.lstGameObjects.Location = new System.Drawing.Point(6, 44);
            this.lstGameObjects.Name = "lstGameObjects";
            this.lstGameObjects.SelectedImageIndex = 0;
            this.lstGameObjects.Size = new System.Drawing.Size(191, 520);
            this.lstGameObjects.TabIndex = 32;
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.grpTypes);
            this.grpGeneral.Controls.Add(this.lblEditorName);
            this.grpGeneral.Controls.Add(this.txtEditorName);
            this.grpGeneral.Controls.Add(this.lblAlpha);
            this.grpGeneral.Controls.Add(this.lblBlue);
            this.grpGeneral.Controls.Add(this.lblGreen);
            this.grpGeneral.Controls.Add(this.lblRed);
            this.grpGeneral.Controls.Add(this.nudRgbaA);
            this.grpGeneral.Controls.Add(this.nudRgbaB);
            this.grpGeneral.Controls.Add(this.nudRgbaG);
            this.grpGeneral.Controls.Add(this.nudRgbaR);
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.lblLevel);
            this.grpGeneral.Controls.Add(this.nudLevel);
            this.grpGeneral.Controls.Add(this.cmbSprite);
            this.grpGeneral.Controls.Add(this.lblPic);
            this.grpGeneral.Controls.Add(this.picNpc);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(2, 1);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(207, 251);
            this.grpGeneral.TabIndex = 14;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // grpTypes
            // 
            this.grpTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTypes.Controls.Add(this.cmbType1);
            this.grpTypes.Controls.Add(this.lblType1);
            this.grpTypes.Controls.Add(this.cmbType2);
            this.grpTypes.Controls.Add(this.lblType2);
            this.grpTypes.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTypes.Location = new System.Drawing.Point(4, 178);
            this.grpTypes.Margin = new System.Windows.Forms.Padding(2);
            this.grpTypes.Name = "grpTypes";
            this.grpTypes.Padding = new System.Windows.Forms.Padding(2);
            this.grpTypes.Size = new System.Drawing.Size(117, 70);
            this.grpTypes.TabIndex = 109;
            this.grpTypes.TabStop = false;
            this.grpTypes.Text = "Elemental Types";
            // 
            // cmbType1
            // 
            this.cmbType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbType1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbType1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbType1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbType1.DrawDropdownHoverOutline = false;
            this.cmbType1.DrawFocusRectangle = false;
            this.cmbType1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType1.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType1.FormattingEnabled = true;
            this.cmbType1.Location = new System.Drawing.Point(39, 19);
            this.cmbType1.Name = "cmbType1";
            this.cmbType1.Size = new System.Drawing.Size(75, 21);
            this.cmbType1.TabIndex = 106;
            this.cmbType1.Text = null;
            this.cmbType1.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbType1.SelectedIndexChanged += new System.EventHandler(this.cmbType1_SelectedIndexChanged);
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(1, 22);
            this.lblType1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(40, 13);
            this.lblType1.TabIndex = 105;
            this.lblType1.Text = "Type1:";
            // 
            // cmbType2
            // 
            this.cmbType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbType2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbType2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbType2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbType2.DrawDropdownHoverOutline = false;
            this.cmbType2.DrawFocusRectangle = false;
            this.cmbType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType2.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType2.FormattingEnabled = true;
            this.cmbType2.Location = new System.Drawing.Point(39, 46);
            this.cmbType2.Name = "cmbType2";
            this.cmbType2.Size = new System.Drawing.Size(75, 21);
            this.cmbType2.TabIndex = 108;
            this.cmbType2.Text = null;
            this.cmbType2.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbType2.SelectedIndexChanged += new System.EventHandler(this.cmbType2_SelectedIndexChanged);
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(1, 49);
            this.lblType2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(40, 13);
            this.lblType2.TabIndex = 107;
            this.lblType2.Text = "Type2:";
            // 
            // lblEditorName
            // 
            this.lblEditorName.AutoSize = true;
            this.lblEditorName.Location = new System.Drawing.Point(6, 69);
            this.lblEditorName.Name = "lblEditorName";
            this.lblEditorName.Size = new System.Drawing.Size(68, 13);
            this.lblEditorName.TabIndex = 104;
            this.lblEditorName.Text = "Editor Name:";
            // 
            // txtEditorName
            // 
            this.txtEditorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtEditorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtEditorName.Location = new System.Drawing.Point(74, 66);
            this.txtEditorName.Name = "txtEditorName";
            this.txtEditorName.Size = new System.Drawing.Size(130, 20);
            this.txtEditorName.TabIndex = 103;
            this.txtEditorName.TextChanged += new System.EventHandler(this.txtEditorName_TextChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(122, 230);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(37, 13);
            this.lblAlpha.TabIndex = 78;
            this.lblAlpha.Text = "Alpha:";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(122, 204);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 13);
            this.lblBlue.TabIndex = 77;
            this.lblBlue.Text = "Blue:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(122, 178);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 13);
            this.lblGreen.TabIndex = 76;
            this.lblGreen.Text = "Green:";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(122, 152);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 13);
            this.lblRed.TabIndex = 75;
            this.lblRed.Text = "Red:";
            // 
            // nudRgbaA
            // 
            this.nudRgbaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaA.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaA.Location = new System.Drawing.Point(162, 228);
            this.nudRgbaA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaA.Name = "nudRgbaA";
            this.nudRgbaA.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaA.TabIndex = 74;
            this.nudRgbaA.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaA.ValueChanged += new System.EventHandler(this.nudRgbaA_ValueChanged);
            // 
            // nudRgbaB
            // 
            this.nudRgbaB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaB.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaB.Location = new System.Drawing.Point(162, 202);
            this.nudRgbaB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaB.Name = "nudRgbaB";
            this.nudRgbaB.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaB.TabIndex = 73;
            this.nudRgbaB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaB.ValueChanged += new System.EventHandler(this.nudRgbaB_ValueChanged);
            // 
            // nudRgbaG
            // 
            this.nudRgbaG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaG.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaG.Location = new System.Drawing.Point(162, 176);
            this.nudRgbaG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaG.Name = "nudRgbaG";
            this.nudRgbaG.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaG.TabIndex = 72;
            this.nudRgbaG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaG.ValueChanged += new System.EventHandler(this.nudRgbaG_ValueChanged);
            // 
            // nudRgbaR
            // 
            this.nudRgbaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRgbaR.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRgbaR.Location = new System.Drawing.Point(162, 150);
            this.nudRgbaR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaR.Name = "nudRgbaR";
            this.nudRgbaR.Size = new System.Drawing.Size(42, 20);
            this.nudRgbaR.TabIndex = 71;
            this.nudRgbaR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRgbaR.ValueChanged += new System.EventHandler(this.nudRgbaR_ValueChanged);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(186, 42);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 67;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 46);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 66;
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
            this.cmbFolder.Location = new System.Drawing.Point(59, 42);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(123, 21);
            this.cmbFolder.TabIndex = 65;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(6, 92);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 64;
            this.lblLevel.Text = "Level:";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevel.Location = new System.Drawing.Point(59, 89);
            this.nudLevel.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(145, 20);
            this.nudLevel.TabIndex = 63;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
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
            this.cmbSprite.Location = new System.Drawing.Point(74, 126);
            this.cmbSprite.Name = "cmbSprite";
            this.cmbSprite.Size = new System.Drawing.Size(130, 21);
            this.cmbSprite.TabIndex = 11;
            this.cmbSprite.Text = "None";
            this.cmbSprite.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSprite.SelectedIndexChanged += new System.EventHandler(this.cmbSprite_SelectedIndexChanged);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(72, 110);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(37, 13);
            this.lblPic.TabIndex = 6;
            this.lblPic.Text = "Sprite:";
            // 
            // picNpc
            // 
            this.picNpc.BackColor = System.Drawing.Color.Black;
            this.picNpc.Location = new System.Drawing.Point(6, 112);
            this.picNpc.Name = "picNpc";
            this.picNpc.Size = new System.Drawing.Size(64, 64);
            this.picNpc.TabIndex = 4;
            this.picNpc.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
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
            this.txtName.Location = new System.Drawing.Point(59, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // nudSpawnDuration
            // 
            this.nudSpawnDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpawnDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpawnDuration.Location = new System.Drawing.Point(160, 222);
            this.nudSpawnDuration.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpawnDuration.Name = "nudSpawnDuration";
            this.nudSpawnDuration.Size = new System.Drawing.Size(64, 20);
            this.nudSpawnDuration.TabIndex = 61;
            this.nudSpawnDuration.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudSpawnDuration.ValueChanged += new System.EventHandler(this.nudSpawnDuration_ValueChanged);
            // 
            // lblSpawnDuration
            // 
            this.lblSpawnDuration.AutoSize = true;
            this.lblSpawnDuration.Location = new System.Drawing.Point(101, 224);
            this.lblSpawnDuration.Name = "lblSpawnDuration";
            this.lblSpawnDuration.Size = new System.Drawing.Size(62, 13);
            this.lblSpawnDuration.TabIndex = 7;
            this.lblSpawnDuration.Text = "Spawn(ms):";
            // 
            // nudSightRange
            // 
            this.nudSightRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSightRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSightRange.Location = new System.Drawing.Point(158, 15);
            this.nudSightRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSightRange.Name = "nudSightRange";
            this.nudSightRange.Size = new System.Drawing.Size(35, 20);
            this.nudSightRange.TabIndex = 62;
            this.nudSightRange.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSightRange.ValueChanged += new System.EventHandler(this.nudSightRange_ValueChanged);
            // 
            // lblSightRange
            // 
            this.lblSightRange.AutoSize = true;
            this.lblSightRange.Location = new System.Drawing.Point(90, 17);
            this.lblSightRange.Name = "lblSightRange";
            this.lblSightRange.Size = new System.Drawing.Size(69, 13);
            this.lblSightRange.TabIndex = 12;
            this.lblSightRange.Text = "Sight Range:";
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpStats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpStats.Controls.Add(this.nudExp);
            this.grpStats.Controls.Add(this.nudMana);
            this.grpStats.Controls.Add(this.nudHp);
            this.grpStats.Controls.Add(this.nudSpd);
            this.grpStats.Controls.Add(this.nudMR);
            this.grpStats.Controls.Add(this.nudDef);
            this.grpStats.Controls.Add(this.nudMag);
            this.grpStats.Controls.Add(this.nudStr);
            this.grpStats.Controls.Add(this.lblSpd);
            this.grpStats.Controls.Add(this.lblMR);
            this.grpStats.Controls.Add(this.lblDef);
            this.grpStats.Controls.Add(this.lblMag);
            this.grpStats.Controls.Add(this.lblStr);
            this.grpStats.Controls.Add(this.lblMana);
            this.grpStats.Controls.Add(this.lblHP);
            this.grpStats.Controls.Add(this.lblExp);
            this.grpStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpStats.Location = new System.Drawing.Point(3, 253);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(206, 194);
            this.grpStats.TabIndex = 15;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats:";
            // 
            // nudExp
            // 
            this.nudExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudExp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudExp.Location = new System.Drawing.Point(105, 149);
            this.nudExp.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(77, 20);
            this.nudExp.TabIndex = 45;
            this.nudExp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudExp.ValueChanged += new System.EventHandler(this.nudExp_ValueChanged);
            // 
            // nudMana
            // 
            this.nudMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMana.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMana.Location = new System.Drawing.Point(105, 35);
            this.nudMana.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMana.Name = "nudMana";
            this.nudMana.Size = new System.Drawing.Size(77, 20);
            this.nudMana.TabIndex = 44;
            this.nudMana.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMana.ValueChanged += new System.EventHandler(this.nudMana_ValueChanged);
            // 
            // nudHp
            // 
            this.nudHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHp.Location = new System.Drawing.Point(12, 35);
            this.nudHp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHp.Name = "nudHp";
            this.nudHp.Size = new System.Drawing.Size(77, 20);
            this.nudHp.TabIndex = 43;
            this.nudHp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHp.ValueChanged += new System.EventHandler(this.nudHp_ValueChanged);
            // 
            // nudSpd
            // 
            this.nudSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpd.Location = new System.Drawing.Point(13, 149);
            this.nudSpd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSpd.Name = "nudSpd";
            this.nudSpd.Size = new System.Drawing.Size(77, 20);
            this.nudSpd.TabIndex = 42;
            this.nudSpd.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpd.ValueChanged += new System.EventHandler(this.nudSpd_ValueChanged);
            // 
            // nudMR
            // 
            this.nudMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMR.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMR.Location = new System.Drawing.Point(105, 113);
            this.nudMR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMR.Name = "nudMR";
            this.nudMR.Size = new System.Drawing.Size(79, 20);
            this.nudMR.TabIndex = 41;
            this.nudMR.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMR.ValueChanged += new System.EventHandler(this.nudMR_ValueChanged);
            // 
            // nudDef
            // 
            this.nudDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDef.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDef.Location = new System.Drawing.Point(12, 113);
            this.nudDef.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDef.Name = "nudDef";
            this.nudDef.Size = new System.Drawing.Size(79, 20);
            this.nudDef.TabIndex = 40;
            this.nudDef.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDef.ValueChanged += new System.EventHandler(this.nudDef_ValueChanged);
            // 
            // nudMag
            // 
            this.nudMag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMag.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMag.Location = new System.Drawing.Point(105, 76);
            this.nudMag.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMag.Name = "nudMag";
            this.nudMag.Size = new System.Drawing.Size(77, 20);
            this.nudMag.TabIndex = 39;
            this.nudMag.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMag.ValueChanged += new System.EventHandler(this.nudMag_ValueChanged);
            // 
            // nudStr
            // 
            this.nudStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStr.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStr.Location = new System.Drawing.Point(13, 76);
            this.nudStr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(77, 20);
            this.nudStr.TabIndex = 38;
            this.nudStr.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStr.ValueChanged += new System.EventHandler(this.nudStr_ValueChanged);
            // 
            // lblSpd
            // 
            this.lblSpd.AutoSize = true;
            this.lblSpd.Location = new System.Drawing.Point(10, 136);
            this.lblSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(71, 13);
            this.lblSpd.TabIndex = 37;
            this.lblSpd.Text = "Move Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(104, 97);
            this.lblMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(71, 13);
            this.lblMR.TabIndex = 36;
            this.lblMR.Text = "Magic Resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(9, 97);
            this.lblDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(37, 13);
            this.lblDef.TabIndex = 35;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(106, 59);
            this.lblMag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(39, 13);
            this.lblMag.TabIndex = 34;
            this.lblMag.Text = "Magic:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(9, 60);
            this.lblStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(50, 13);
            this.lblStr.TabIndex = 33;
            this.lblStr.Text = "Strength:";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(108, 18);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(37, 13);
            this.lblMana.TabIndex = 15;
            this.lblMana.Text = "Mana:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(10, 19);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(25, 13);
            this.lblHP.TabIndex = 14;
            this.lblHP.Text = "HP:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(106, 136);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(28, 13);
            this.lblExp.TabIndex = 11;
            this.lblExp.Text = "Exp:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpPhases);
            this.pnlContainer.Controls.Add(this.grpCombat);
            this.pnlContainer.Controls.Add(this.grpCommonEvents);
            this.pnlContainer.Controls.Add(this.grpBehavior);
            this.pnlContainer.Controls.Add(this.grpRegen);
            this.pnlContainer.Controls.Add(this.grpDrops);
            this.pnlContainer.Controls.Add(this.grpNpcVsNpc);
            this.pnlContainer.Controls.Add(this.grpSpells);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpStats);
            this.pnlContainer.Location = new System.Drawing.Point(225, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlContainer.Size = new System.Drawing.Size(464, 529);
            this.pnlContainer.TabIndex = 17;
            // 
            // grpPhases
            // 
            this.grpPhases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpPhases.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPhases.Controls.Add(this.btnRemovePhase);
            this.grpPhases.Controls.Add(this.btnAddPhase);
            this.grpPhases.Controls.Add(this.lstPhases);
            this.grpPhases.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPhases.Location = new System.Drawing.Point(3, 1174);
            this.grpPhases.Name = "grpPhases";
            this.grpPhases.Size = new System.Drawing.Size(441, 85);
            this.grpPhases.TabIndex = 44;
            this.grpPhases.TabStop = false;
            this.grpPhases.Text = "Phases";
            // 
            // btnRemovePhase
            // 
            this.btnRemovePhase.Location = new System.Drawing.Point(346, 48);
            this.btnRemovePhase.Name = "btnRemovePhase";
            this.btnRemovePhase.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemovePhase.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePhase.TabIndex = 38;
            this.btnRemovePhase.Text = "Remove";
            this.btnRemovePhase.Click += new System.EventHandler(this.btnRemovePhase_Click);
            // 
            // btnAddPhase
            // 
            this.btnAddPhase.Location = new System.Drawing.Point(346, 19);
            this.btnAddPhase.Name = "btnAddPhase";
            this.btnAddPhase.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddPhase.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhase.TabIndex = 37;
            this.btnAddPhase.Text = "Add";
            this.btnAddPhase.Click += new System.EventHandler(this.btnAddPhase_Click);
            // 
            // lstPhases
            // 
            this.lstPhases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstPhases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPhases.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstPhases.FormattingEnabled = true;
            this.lstPhases.Location = new System.Drawing.Point(12, 15);
            this.lstPhases.Name = "lstPhases";
            this.lstPhases.Size = new System.Drawing.Size(328, 67);
            this.lstPhases.TabIndex = 29;
            this.lstPhases.DoubleClick += new System.EventHandler(this.lstPhases_DoubleClick);
            // 
            // grpCombat
            // 
            this.grpCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCombat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCombat.Controls.Add(this.nudAttackRange);
            this.grpCombat.Controls.Add(this.lblAttackRange);
            this.grpCombat.Controls.Add(this.grpAttackSpeed);
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
            this.grpCombat.Location = new System.Drawing.Point(215, 466);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(226, 411);
            this.grpCombat.TabIndex = 17;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat";
            // 
            // grpAttackSpeed
            // 
            this.grpAttackSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAttackSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAttackSpeed.Controls.Add(this.nudAttackSpeedValue);
            this.grpAttackSpeed.Controls.Add(this.lblAttackSpeedValue);
            this.grpAttackSpeed.Controls.Add(this.cmbAttackSpeedModifier);
            this.grpAttackSpeed.Controls.Add(this.lblAttackSpeedModifier);
            this.grpAttackSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAttackSpeed.Location = new System.Drawing.Point(12, 337);
            this.grpAttackSpeed.Name = "grpAttackSpeed";
            this.grpAttackSpeed.Size = new System.Drawing.Size(192, 69);
            this.grpAttackSpeed.TabIndex = 64;
            this.grpAttackSpeed.TabStop = false;
            this.grpAttackSpeed.Text = "Attack Speed";
            // 
            // nudAttackSpeedValue
            // 
            this.nudAttackSpeedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAttackSpeedValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAttackSpeedValue.Location = new System.Drawing.Point(60, 44);
            this.nudAttackSpeedValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAttackSpeedValue.Name = "nudAttackSpeedValue";
            this.nudAttackSpeedValue.Size = new System.Drawing.Size(114, 20);
            this.nudAttackSpeedValue.TabIndex = 56;
            this.nudAttackSpeedValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAttackSpeedValue.ValueChanged += new System.EventHandler(this.nudAttackSpeedValue_ValueChanged);
            // 
            // lblAttackSpeedValue
            // 
            this.lblAttackSpeedValue.AutoSize = true;
            this.lblAttackSpeedValue.Location = new System.Drawing.Point(9, 46);
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
            this.cmbAttackSpeedModifier.Location = new System.Drawing.Point(60, 16);
            this.cmbAttackSpeedModifier.Name = "cmbAttackSpeedModifier";
            this.cmbAttackSpeedModifier.Size = new System.Drawing.Size(114, 21);
            this.cmbAttackSpeedModifier.TabIndex = 28;
            this.cmbAttackSpeedModifier.Text = null;
            this.cmbAttackSpeedModifier.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackSpeedModifier.SelectedIndexChanged += new System.EventHandler(this.cmbAttackSpeedModifier_SelectedIndexChanged);
            // 
            // lblAttackSpeedModifier
            // 
            this.lblAttackSpeedModifier.AutoSize = true;
            this.lblAttackSpeedModifier.Location = new System.Drawing.Point(9, 19);
            this.lblAttackSpeedModifier.Name = "lblAttackSpeedModifier";
            this.lblAttackSpeedModifier.Size = new System.Drawing.Size(47, 13);
            this.lblAttackSpeedModifier.TabIndex = 0;
            this.lblAttackSpeedModifier.Text = "Modifier:";
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
            this.nudCritMultiplier.Location = new System.Drawing.Point(13, 110);
            this.nudCritMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCritMultiplier.Name = "nudCritMultiplier";
            this.nudCritMultiplier.Size = new System.Drawing.Size(191, 20);
            this.nudCritMultiplier.TabIndex = 63;
            this.nudCritMultiplier.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCritMultiplier.ValueChanged += new System.EventHandler(this.nudCritMultiplier_ValueChanged);
            // 
            // lblCritMultiplier
            // 
            this.lblCritMultiplier.AutoSize = true;
            this.lblCritMultiplier.Location = new System.Drawing.Point(10, 96);
            this.lblCritMultiplier.Name = "lblCritMultiplier";
            this.lblCritMultiplier.Size = new System.Drawing.Size(135, 13);
            this.lblCritMultiplier.TabIndex = 62;
            this.lblCritMultiplier.Text = "Crit Multiplier (Default 1.5x):";
            // 
            // nudScaling
            // 
            this.nudScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudScaling.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudScaling.Location = new System.Drawing.Point(12, 232);
            this.nudScaling.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudScaling.Name = "nudScaling";
            this.nudScaling.Size = new System.Drawing.Size(191, 20);
            this.nudScaling.TabIndex = 61;
            this.nudScaling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudScaling.ValueChanged += new System.EventHandler(this.nudScaling_ValueChanged);
            // 
            // nudDamage
            // 
            this.nudDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDamage.Location = new System.Drawing.Point(12, 34);
            this.nudDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(192, 20);
            this.nudDamage.TabIndex = 60;
            this.nudDamage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDamage.ValueChanged += new System.EventHandler(this.nudDamage_ValueChanged);
            // 
            // nudCritChance
            // 
            this.nudCritChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritChance.Location = new System.Drawing.Point(13, 71);
            this.nudCritChance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCritChance.Name = "nudCritChance";
            this.nudCritChance.Size = new System.Drawing.Size(191, 20);
            this.nudCritChance.TabIndex = 59;
            this.nudCritChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCritChance.ValueChanged += new System.EventHandler(this.nudCritChance_ValueChanged);
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
            this.cmbScalingStat.Location = new System.Drawing.Point(13, 192);
            this.cmbScalingStat.Name = "cmbScalingStat";
            this.cmbScalingStat.Size = new System.Drawing.Size(191, 21);
            this.cmbScalingStat.TabIndex = 58;
            this.cmbScalingStat.Text = null;
            this.cmbScalingStat.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbScalingStat.SelectedIndexChanged += new System.EventHandler(this.cmbScalingStat_SelectedIndexChanged);
            // 
            // lblScalingStat
            // 
            this.lblScalingStat.AutoSize = true;
            this.lblScalingStat.Location = new System.Drawing.Point(10, 175);
            this.lblScalingStat.Name = "lblScalingStat";
            this.lblScalingStat.Size = new System.Drawing.Size(67, 13);
            this.lblScalingStat.TabIndex = 57;
            this.lblScalingStat.Text = "Scaling Stat:";
            // 
            // lblScaling
            // 
            this.lblScaling.AutoSize = true;
            this.lblScaling.Location = new System.Drawing.Point(9, 216);
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
            this.cmbDamageType.Location = new System.Drawing.Point(13, 151);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(191, 21);
            this.cmbDamageType.TabIndex = 54;
            this.cmbDamageType.Text = "Physical";
            this.cmbDamageType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDamageType.SelectedIndexChanged += new System.EventHandler(this.cmbDamageType_SelectedIndexChanged);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(10, 134);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(77, 13);
            this.lblDamageType.TabIndex = 53;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(9, 58);
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
            this.cmbAttackAnimation.Location = new System.Drawing.Point(12, 272);
            this.cmbAttackAnimation.Name = "cmbAttackAnimation";
            this.cmbAttackAnimation.Size = new System.Drawing.Size(192, 21);
            this.cmbAttackAnimation.TabIndex = 50;
            this.cmbAttackAnimation.Text = null;
            this.cmbAttackAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAttackAnimation_SelectedIndexChanged);
            // 
            // lblAttackAnimation
            // 
            this.lblAttackAnimation.AutoSize = true;
            this.lblAttackAnimation.Location = new System.Drawing.Point(9, 257);
            this.lblAttackAnimation.Name = "lblAttackAnimation";
            this.lblAttackAnimation.Size = new System.Drawing.Size(90, 13);
            this.lblAttackAnimation.TabIndex = 49;
            this.lblAttackAnimation.Text = "Attack Animation:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(9, 18);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(77, 13);
            this.lblDamage.TabIndex = 48;
            this.lblDamage.Text = "Base Damage:";
            // 
            // grpCommonEvents
            // 
            this.grpCommonEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCommonEvents.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCommonEvents.Controls.Add(this.cmbOnDeathEventParty);
            this.grpCommonEvents.Controls.Add(this.lblOnDeathEventParty);
            this.grpCommonEvents.Controls.Add(this.cmbOnDeathEventKiller);
            this.grpCommonEvents.Controls.Add(this.lblOnDeathEventKiller);
            this.grpCommonEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCommonEvents.Location = new System.Drawing.Point(3, 1072);
            this.grpCommonEvents.Margin = new System.Windows.Forms.Padding(2);
            this.grpCommonEvents.Name = "grpCommonEvents";
            this.grpCommonEvents.Padding = new System.Windows.Forms.Padding(2);
            this.grpCommonEvents.Size = new System.Drawing.Size(206, 98);
            this.grpCommonEvents.TabIndex = 32;
            this.grpCommonEvents.TabStop = false;
            this.grpCommonEvents.Text = "Common Events";
            // 
            // cmbOnDeathEventParty
            // 
            this.cmbOnDeathEventParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbOnDeathEventParty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbOnDeathEventParty.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbOnDeathEventParty.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbOnDeathEventParty.DrawDropdownHoverOutline = false;
            this.cmbOnDeathEventParty.DrawFocusRectangle = false;
            this.cmbOnDeathEventParty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOnDeathEventParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnDeathEventParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOnDeathEventParty.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbOnDeathEventParty.FormattingEnabled = true;
            this.cmbOnDeathEventParty.Location = new System.Drawing.Point(12, 73);
            this.cmbOnDeathEventParty.Name = "cmbOnDeathEventParty";
            this.cmbOnDeathEventParty.Size = new System.Drawing.Size(182, 21);
            this.cmbOnDeathEventParty.TabIndex = 21;
            this.cmbOnDeathEventParty.Text = null;
            this.cmbOnDeathEventParty.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbOnDeathEventParty.SelectedIndexChanged += new System.EventHandler(this.cmbOnDeathEventParty_SelectedIndexChanged);
            // 
            // lblOnDeathEventParty
            // 
            this.lblOnDeathEventParty.AutoSize = true;
            this.lblOnDeathEventParty.Location = new System.Drawing.Point(9, 57);
            this.lblOnDeathEventParty.Name = "lblOnDeathEventParty";
            this.lblOnDeathEventParty.Size = new System.Drawing.Size(103, 13);
            this.lblOnDeathEventParty.TabIndex = 20;
            this.lblOnDeathEventParty.Text = "On Death (for party):";
            // 
            // cmbOnDeathEventKiller
            // 
            this.cmbOnDeathEventKiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbOnDeathEventKiller.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbOnDeathEventKiller.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbOnDeathEventKiller.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbOnDeathEventKiller.DrawDropdownHoverOutline = false;
            this.cmbOnDeathEventKiller.DrawFocusRectangle = false;
            this.cmbOnDeathEventKiller.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOnDeathEventKiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnDeathEventKiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOnDeathEventKiller.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbOnDeathEventKiller.FormattingEnabled = true;
            this.cmbOnDeathEventKiller.Location = new System.Drawing.Point(12, 32);
            this.cmbOnDeathEventKiller.Name = "cmbOnDeathEventKiller";
            this.cmbOnDeathEventKiller.Size = new System.Drawing.Size(182, 21);
            this.cmbOnDeathEventKiller.TabIndex = 19;
            this.cmbOnDeathEventKiller.Text = null;
            this.cmbOnDeathEventKiller.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbOnDeathEventKiller.SelectedIndexChanged += new System.EventHandler(this.cmbOnDeathEventKiller_SelectedIndexChanged);
            // 
            // lblOnDeathEventKiller
            // 
            this.lblOnDeathEventKiller.AutoSize = true;
            this.lblOnDeathEventKiller.Location = new System.Drawing.Point(9, 16);
            this.lblOnDeathEventKiller.Name = "lblOnDeathEventKiller";
            this.lblOnDeathEventKiller.Size = new System.Drawing.Size(101, 13);
            this.lblOnDeathEventKiller.TabIndex = 18;
            this.lblOnDeathEventKiller.Text = "On Death (for killer):";
            // 
            // grpBehavior
            // 
            this.grpBehavior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpBehavior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpBehavior.Controls.Add(this.cmbNpcToSwarm);
            this.grpBehavior.Controls.Add(this.lblNpcToSwarm);
            this.grpBehavior.Controls.Add(this.btnRemoveSwarm);
            this.grpBehavior.Controls.Add(this.btnAddSwarm);
            this.grpBehavior.Controls.Add(this.lstSwarm);
            this.grpBehavior.Controls.Add(this.chkAttackOnFlee);
            this.grpBehavior.Controls.Add(this.chkSwarmAll);
            this.grpBehavior.Controls.Add(this.nudSwarmRange);
            this.grpBehavior.Controls.Add(this.lblSwarmRange);
            this.grpBehavior.Controls.Add(this.chkSwarmOnPlayer);
            this.grpBehavior.Controls.Add(this.lblMaxMove);
            this.grpBehavior.Controls.Add(this.nudMaxMove);
            this.grpBehavior.Controls.Add(this.nudResetRadius);
            this.grpBehavior.Controls.Add(this.lblResetRadius);
            this.grpBehavior.Controls.Add(this.lblFocusDamageDealer);
            this.grpBehavior.Controls.Add(this.chkFocusDamageDealer);
            this.grpBehavior.Controls.Add(this.nudSpawnDuration);
            this.grpBehavior.Controls.Add(this.lblSpawnDuration);
            this.grpBehavior.Controls.Add(this.nudFlee);
            this.grpBehavior.Controls.Add(this.lblFlee);
            this.grpBehavior.Controls.Add(this.chkSwarm);
            this.grpBehavior.Controls.Add(this.grpConditions);
            this.grpBehavior.Controls.Add(this.lblMovement);
            this.grpBehavior.Controls.Add(this.cmbMovement);
            this.grpBehavior.Controls.Add(this.chkAggressive);
            this.grpBehavior.Controls.Add(this.nudSightRange);
            this.grpBehavior.Controls.Add(this.lblSightRange);
            this.grpBehavior.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpBehavior.Location = new System.Drawing.Point(215, 1);
            this.grpBehavior.Name = "grpBehavior";
            this.grpBehavior.Size = new System.Drawing.Size(226, 459);
            this.grpBehavior.TabIndex = 32;
            this.grpBehavior.TabStop = false;
            this.grpBehavior.Text = "Behavior:";
            // 
            // cmbNpcToSwarm
            // 
            this.cmbNpcToSwarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbNpcToSwarm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbNpcToSwarm.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbNpcToSwarm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbNpcToSwarm.DrawDropdownHoverOutline = false;
            this.cmbNpcToSwarm.DrawFocusRectangle = false;
            this.cmbNpcToSwarm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNpcToSwarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNpcToSwarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNpcToSwarm.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbNpcToSwarm.FormattingEnabled = true;
            this.cmbNpcToSwarm.Location = new System.Drawing.Point(87, 84);
            this.cmbNpcToSwarm.Name = "cmbNpcToSwarm";
            this.cmbNpcToSwarm.Size = new System.Drawing.Size(133, 21);
            this.cmbNpcToSwarm.TabIndex = 88;
            this.cmbNpcToSwarm.Text = null;
            this.cmbNpcToSwarm.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblNpcToSwarm
            // 
            this.lblNpcToSwarm.AutoSize = true;
            this.lblNpcToSwarm.Location = new System.Drawing.Point(4, 88);
            this.lblNpcToSwarm.Name = "lblNpcToSwarm";
            this.lblNpcToSwarm.Size = new System.Drawing.Size(84, 13);
            this.lblNpcToSwarm.TabIndex = 87;
            this.lblNpcToSwarm.Text = "NPCs to Swarm:";
            // 
            // btnRemoveSwarm
            // 
            this.btnRemoveSwarm.Location = new System.Drawing.Point(129, 164);
            this.btnRemoveSwarm.Name = "btnRemoveSwarm";
            this.btnRemoveSwarm.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveSwarm.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSwarm.TabIndex = 86;
            this.btnRemoveSwarm.Text = "Remove";
            this.btnRemoveSwarm.Click += new System.EventHandler(this.btnRemoveSwarm_Click);
            // 
            // btnAddSwarm
            // 
            this.btnAddSwarm.Location = new System.Drawing.Point(26, 164);
            this.btnAddSwarm.Name = "btnAddSwarm";
            this.btnAddSwarm.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddSwarm.Size = new System.Drawing.Size(75, 23);
            this.btnAddSwarm.TabIndex = 85;
            this.btnAddSwarm.Text = "Add";
            this.btnAddSwarm.Click += new System.EventHandler(this.btnAddSwarm_Click);
            // 
            // lstSwarm
            // 
            this.lstSwarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstSwarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSwarm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSwarm.FormattingEnabled = true;
            this.lstSwarm.Items.AddRange(new object[] {
            "NPC:"});
            this.lstSwarm.Location = new System.Drawing.Point(7, 108);
            this.lstSwarm.Name = "lstSwarm";
            this.lstSwarm.Size = new System.Drawing.Size(212, 54);
            this.lstSwarm.TabIndex = 84;
            // 
            // chkAttackOnFlee
            // 
            this.chkAttackOnFlee.AutoSize = true;
            this.chkAttackOnFlee.Location = new System.Drawing.Point(128, 249);
            this.chkAttackOnFlee.Name = "chkAttackOnFlee";
            this.chkAttackOnFlee.Size = new System.Drawing.Size(95, 17);
            this.chkAttackOnFlee.TabIndex = 83;
            this.chkAttackOnFlee.Text = "Attack on Flee";
            this.chkAttackOnFlee.CheckedChanged += new System.EventHandler(this.chkAttackOnFlee_CheckedChanged);
            // 
            // chkSwarmAll
            // 
            this.chkSwarmAll.AutoSize = true;
            this.chkSwarmAll.Location = new System.Drawing.Point(6, 62);
            this.chkSwarmAll.Name = "chkSwarmAll";
            this.chkSwarmAll.Size = new System.Drawing.Size(99, 17);
            this.chkSwarmAll.TabIndex = 82;
            this.chkSwarmAll.Text = "Swarm all kinds";
            this.chkSwarmAll.CheckedChanged += new System.EventHandler(this.chkSwarmAll_CheckedChanged);
            // 
            // nudSwarmRange
            // 
            this.nudSwarmRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSwarmRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSwarmRange.Location = new System.Drawing.Point(185, 61);
            this.nudSwarmRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSwarmRange.Name = "nudSwarmRange";
            this.nudSwarmRange.Size = new System.Drawing.Size(35, 20);
            this.nudSwarmRange.TabIndex = 81;
            this.nudSwarmRange.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSwarmRange.ValueChanged += new System.EventHandler(this.nudSwarmRange_ValueChanged);
            // 
            // lblSwarmRange
            // 
            this.lblSwarmRange.AutoSize = true;
            this.lblSwarmRange.Location = new System.Drawing.Point(110, 64);
            this.lblSwarmRange.Name = "lblSwarmRange";
            this.lblSwarmRange.Size = new System.Drawing.Size(77, 13);
            this.lblSwarmRange.TabIndex = 80;
            this.lblSwarmRange.Text = "Swarm Range:";
            // 
            // chkSwarmOnPlayer
            // 
            this.chkSwarmOnPlayer.AutoSize = true;
            this.chkSwarmOnPlayer.Location = new System.Drawing.Point(69, 40);
            this.chkSwarmOnPlayer.Name = "chkSwarmOnPlayer";
            this.chkSwarmOnPlayer.Size = new System.Drawing.Size(105, 17);
            this.chkSwarmOnPlayer.TabIndex = 79;
            this.chkSwarmOnPlayer.Text = "Swarm on Player";
            this.chkSwarmOnPlayer.CheckedChanged += new System.EventHandler(this.chkSwarmOnPlayer_CheckedChanged);
            // 
            // lblMaxMove
            // 
            this.lblMaxMove.AutoSize = true;
            this.lblMaxMove.Location = new System.Drawing.Point(154, 196);
            this.lblMaxMove.Name = "lblMaxMove";
            this.lblMaxMove.Size = new System.Drawing.Size(30, 13);
            this.lblMaxMove.TabIndex = 78;
            this.lblMaxMove.Text = "Max:";
            // 
            // nudMaxMove
            // 
            this.nudMaxMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMaxMove.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMaxMove.Location = new System.Drawing.Point(184, 193);
            this.nudMaxMove.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudMaxMove.Name = "nudMaxMove";
            this.nudMaxMove.Size = new System.Drawing.Size(36, 20);
            this.nudMaxMove.TabIndex = 77;
            this.nudMaxMove.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxMove.ValueChanged += new System.EventHandler(this.nudMaxMove_ValueChanged);
            // 
            // nudResetRadius
            // 
            this.nudResetRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudResetRadius.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudResetRadius.Location = new System.Drawing.Point(66, 222);
            this.nudResetRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudResetRadius.Name = "nudResetRadius";
            this.nudResetRadius.Size = new System.Drawing.Size(35, 20);
            this.nudResetRadius.TabIndex = 76;
            this.nudResetRadius.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudResetRadius.ValueChanged += new System.EventHandler(this.nudResetRadius_ValueChanged);
            // 
            // lblResetRadius
            // 
            this.lblResetRadius.AutoSize = true;
            this.lblResetRadius.Location = new System.Drawing.Point(1, 224);
            this.lblResetRadius.Name = "lblResetRadius";
            this.lblResetRadius.Size = new System.Drawing.Size(69, 13);
            this.lblResetRadius.TabIndex = 75;
            this.lblResetRadius.Text = "Reset radius:";
            // 
            // lblFocusDamageDealer
            // 
            this.lblFocusDamageDealer.AutoSize = true;
            this.lblFocusDamageDealer.Location = new System.Drawing.Point(1, 273);
            this.lblFocusDamageDealer.Name = "lblFocusDamageDealer";
            this.lblFocusDamageDealer.Size = new System.Drawing.Size(155, 13);
            this.lblFocusDamageDealer.TabIndex = 72;
            this.lblFocusDamageDealer.Text = "Focus Highest Damage Dealer:";
            // 
            // chkFocusDamageDealer
            // 
            this.chkFocusDamageDealer.AutoSize = true;
            this.chkFocusDamageDealer.Location = new System.Drawing.Point(162, 273);
            this.chkFocusDamageDealer.Name = "chkFocusDamageDealer";
            this.chkFocusDamageDealer.Size = new System.Drawing.Size(15, 14);
            this.chkFocusDamageDealer.TabIndex = 71;
            this.chkFocusDamageDealer.CheckedChanged += new System.EventHandler(this.chkFocusDamageDealer_CheckedChanged);
            // 
            // nudFlee
            // 
            this.nudFlee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFlee.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFlee.Location = new System.Drawing.Point(78, 248);
            this.nudFlee.Name = "nudFlee";
            this.nudFlee.Size = new System.Drawing.Size(39, 20);
            this.nudFlee.TabIndex = 70;
            this.nudFlee.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFlee.ValueChanged += new System.EventHandler(this.nudFlee_ValueChanged);
            // 
            // lblFlee
            // 
            this.lblFlee.AutoSize = true;
            this.lblFlee.Location = new System.Drawing.Point(2, 251);
            this.lblFlee.Name = "lblFlee";
            this.lblFlee.Size = new System.Drawing.Size(75, 13);
            this.lblFlee.TabIndex = 69;
            this.lblFlee.Text = "Flee Health %:";
            // 
            // chkSwarm
            // 
            this.chkSwarm.AutoSize = true;
            this.chkSwarm.Location = new System.Drawing.Point(6, 40);
            this.chkSwarm.Name = "chkSwarm";
            this.chkSwarm.Size = new System.Drawing.Size(58, 17);
            this.chkSwarm.TabIndex = 67;
            this.chkSwarm.Text = "Swarm";
            this.chkSwarm.CheckedChanged += new System.EventHandler(this.chkSwarm_CheckedChanged);
            // 
            // grpConditions
            // 
            this.grpConditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpConditions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpConditions.Controls.Add(this.btnPlayerCanProjectileCond);
            this.grpConditions.Controls.Add(this.btnPlayerCanSpellCond);
            this.grpConditions.Controls.Add(this.btnAttackOnSightCond);
            this.grpConditions.Controls.Add(this.btnPlayerCanAttackCond);
            this.grpConditions.Controls.Add(this.btnPlayerFriendProtectorCond);
            this.grpConditions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpConditions.Location = new System.Drawing.Point(8, 289);
            this.grpConditions.Name = "grpConditions";
            this.grpConditions.Size = new System.Drawing.Size(207, 165);
            this.grpConditions.TabIndex = 66;
            this.grpConditions.TabStop = false;
            this.grpConditions.Text = "Conditions:";
            // 
            // btnPlayerCanProjectileCond
            // 
            this.btnPlayerCanProjectileCond.Location = new System.Drawing.Point(5, 135);
            this.btnPlayerCanProjectileCond.Name = "btnPlayerCanProjectileCond";
            this.btnPlayerCanProjectileCond.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayerCanProjectileCond.Size = new System.Drawing.Size(196, 23);
            this.btnPlayerCanProjectileCond.TabIndex = 49;
            this.btnPlayerCanProjectileCond.Text = "Player Can Projectile (Default: True)";
            this.btnPlayerCanProjectileCond.Click += new System.EventHandler(this.btnPlayerCanProjectileCond_Click);
            // 
            // btnPlayerCanSpellCond
            // 
            this.btnPlayerCanSpellCond.Location = new System.Drawing.Point(5, 106);
            this.btnPlayerCanSpellCond.Name = "btnPlayerCanSpellCond";
            this.btnPlayerCanSpellCond.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayerCanSpellCond.Size = new System.Drawing.Size(196, 23);
            this.btnPlayerCanSpellCond.TabIndex = 48;
            this.btnPlayerCanSpellCond.Text = "Player Can Spell (Default: True)";
            this.btnPlayerCanSpellCond.Click += new System.EventHandler(this.btnPlayerCanSpellCond_Click);
            // 
            // btnAttackOnSightCond
            // 
            this.btnAttackOnSightCond.Location = new System.Drawing.Point(5, 48);
            this.btnAttackOnSightCond.Name = "btnAttackOnSightCond";
            this.btnAttackOnSightCond.Padding = new System.Windows.Forms.Padding(5);
            this.btnAttackOnSightCond.Size = new System.Drawing.Size(196, 23);
            this.btnAttackOnSightCond.TabIndex = 47;
            this.btnAttackOnSightCond.Text = "Should Not Attack Player On Sight";
            this.btnAttackOnSightCond.Click += new System.EventHandler(this.btnAttackOnSightCond_Click);
            // 
            // btnPlayerCanAttackCond
            // 
            this.btnPlayerCanAttackCond.Location = new System.Drawing.Point(5, 77);
            this.btnPlayerCanAttackCond.Name = "btnPlayerCanAttackCond";
            this.btnPlayerCanAttackCond.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayerCanAttackCond.Size = new System.Drawing.Size(196, 23);
            this.btnPlayerCanAttackCond.TabIndex = 46;
            this.btnPlayerCanAttackCond.Text = "Player Can Attack (Default: True)";
            this.btnPlayerCanAttackCond.Click += new System.EventHandler(this.btnPlayerCanAttackCond_Click);
            // 
            // btnPlayerFriendProtectorCond
            // 
            this.btnPlayerFriendProtectorCond.Location = new System.Drawing.Point(5, 19);
            this.btnPlayerFriendProtectorCond.Name = "btnPlayerFriendProtectorCond";
            this.btnPlayerFriendProtectorCond.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlayerFriendProtectorCond.Size = new System.Drawing.Size(196, 23);
            this.btnPlayerFriendProtectorCond.TabIndex = 44;
            this.btnPlayerFriendProtectorCond.Text = "Player Friend/Protector";
            this.btnPlayerFriendProtectorCond.Click += new System.EventHandler(this.btnPlayerFriendProtectorCond_Click);
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(1, 196);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(37, 13);
            this.lblMovement.TabIndex = 65;
            this.lblMovement.Text = "Move:";
            // 
            // cmbMovement
            // 
            this.cmbMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbMovement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbMovement.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMovement.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbMovement.DrawDropdownHoverOutline = false;
            this.cmbMovement.DrawFocusRectangle = false;
            this.cmbMovement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMovement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMovement.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMovement.FormattingEnabled = true;
            this.cmbMovement.Items.AddRange(new object[] {
            "Move Randomly",
            "Turn Randomly",
            "No Movement"});
            this.cmbMovement.Location = new System.Drawing.Point(40, 193);
            this.cmbMovement.Name = "cmbMovement";
            this.cmbMovement.Size = new System.Drawing.Size(112, 21);
            this.cmbMovement.TabIndex = 64;
            this.cmbMovement.Text = "Move Randomly";
            this.cmbMovement.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbMovement.SelectedIndexChanged += new System.EventHandler(this.cmbMovement_SelectedIndexChanged);
            // 
            // chkAggressive
            // 
            this.chkAggressive.AutoSize = true;
            this.chkAggressive.Location = new System.Drawing.Point(6, 15);
            this.chkAggressive.Name = "chkAggressive";
            this.chkAggressive.Size = new System.Drawing.Size(78, 17);
            this.chkAggressive.TabIndex = 1;
            this.chkAggressive.Text = "Aggressive";
            this.chkAggressive.CheckedChanged += new System.EventHandler(this.chkAggressive_CheckedChanged);
            // 
            // grpRegen
            // 
            this.grpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpRegen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpRegen.Controls.Add(this.chkRegenReset);
            this.grpRegen.Controls.Add(this.nudMpRegen);
            this.grpRegen.Controls.Add(this.nudHpRegen);
            this.grpRegen.Controls.Add(this.lblHpRegen);
            this.grpRegen.Controls.Add(this.lblManaRegen);
            this.grpRegen.Controls.Add(this.lblRegenHint);
            this.grpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRegen.Location = new System.Drawing.Point(2, 452);
            this.grpRegen.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegen.Name = "grpRegen";
            this.grpRegen.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegen.Size = new System.Drawing.Size(206, 99);
            this.grpRegen.TabIndex = 31;
            this.grpRegen.TabStop = false;
            this.grpRegen.Text = "Regen";
            // 
            // chkRegenReset
            // 
            this.chkRegenReset.AutoSize = true;
            this.chkRegenReset.Location = new System.Drawing.Point(67, 11);
            this.chkRegenReset.Name = "chkRegenReset";
            this.chkRegenReset.Size = new System.Drawing.Size(137, 17);
            this.chkRegenReset.TabIndex = 89;
            this.chkRegenReset.Text = "Start when Reset start?";
            this.chkRegenReset.CheckedChanged += new System.EventHandler(this.chkRegenReset_CheckedChanged);
            // 
            // nudMpRegen
            // 
            this.nudMpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpRegen.Location = new System.Drawing.Point(8, 69);
            this.nudMpRegen.Name = "nudMpRegen";
            this.nudMpRegen.Size = new System.Drawing.Size(86, 20);
            this.nudMpRegen.TabIndex = 31;
            this.nudMpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMpRegen.ValueChanged += new System.EventHandler(this.nudMpRegen_ValueChanged);
            // 
            // nudHpRegen
            // 
            this.nudHpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHpRegen.Location = new System.Drawing.Point(8, 32);
            this.nudHpRegen.Name = "nudHpRegen";
            this.nudHpRegen.Size = new System.Drawing.Size(86, 20);
            this.nudHpRegen.TabIndex = 30;
            this.nudHpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHpRegen.ValueChanged += new System.EventHandler(this.nudHpRegen_ValueChanged);
            // 
            // lblHpRegen
            // 
            this.lblHpRegen.AutoSize = true;
            this.lblHpRegen.Location = new System.Drawing.Point(5, 17);
            this.lblHpRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHpRegen.Name = "lblHpRegen";
            this.lblHpRegen.Size = new System.Drawing.Size(42, 13);
            this.lblHpRegen.TabIndex = 26;
            this.lblHpRegen.Text = "HP: (%)";
            // 
            // lblManaRegen
            // 
            this.lblManaRegen.AutoSize = true;
            this.lblManaRegen.Location = new System.Drawing.Point(5, 54);
            this.lblManaRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManaRegen.Name = "lblManaRegen";
            this.lblManaRegen.Size = new System.Drawing.Size(54, 13);
            this.lblManaRegen.TabIndex = 27;
            this.lblManaRegen.Text = "Mana: (%)";
            // 
            // lblRegenHint
            // 
            this.lblRegenHint.Location = new System.Drawing.Point(102, 31);
            this.lblRegenHint.Name = "lblRegenHint";
            this.lblRegenHint.Size = new System.Drawing.Size(100, 67);
            this.lblRegenHint.TabIndex = 0;
            this.lblRegenHint.Text = "% of HP/Mana to restore per tick.\r\n\r\nTick timer saved in server config.json.";
            // 
            // grpDrops
            // 
            this.grpDrops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDrops.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDrops.Controls.Add(this.chkDropChanceIterative);
            this.grpDrops.Controls.Add(this.chkDropAmountRandom);
            this.grpDrops.Controls.Add(this.chkIndividualLoot);
            this.grpDrops.Controls.Add(this.btnDropRemove);
            this.grpDrops.Controls.Add(this.btnDropAdd);
            this.grpDrops.Controls.Add(this.lstDrops);
            this.grpDrops.Controls.Add(this.nudDropAmount);
            this.grpDrops.Controls.Add(this.nudDropChance);
            this.grpDrops.Controls.Add(this.cmbDropItem);
            this.grpDrops.Controls.Add(this.lblDropAmount);
            this.grpDrops.Controls.Add(this.lblDropChance);
            this.grpDrops.Controls.Add(this.lblDropItem);
            this.grpDrops.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDrops.Location = new System.Drawing.Point(218, 885);
            this.grpDrops.Name = "grpDrops";
            this.grpDrops.Size = new System.Drawing.Size(226, 285);
            this.grpDrops.TabIndex = 30;
            this.grpDrops.TabStop = false;
            this.grpDrops.Text = "Drops";
            // 
            // chkDropChanceIterative
            // 
            this.chkDropChanceIterative.AutoSize = true;
            this.chkDropChanceIterative.Location = new System.Drawing.Point(153, 199);
            this.chkDropChanceIterative.Name = "chkDropChanceIterative";
            this.chkDropChanceIterative.Size = new System.Drawing.Size(70, 17);
            this.chkDropChanceIterative.TabIndex = 79;
            this.chkDropChanceIterative.Text = "Iterative?";
            this.chkDropChanceIterative.CheckedChanged += new System.EventHandler(this.chkDropChanceIterative_CheckedChanged);
            // 
            // chkDropAmountRandom
            // 
            this.chkDropAmountRandom.AutoSize = true;
            this.chkDropAmountRandom.Location = new System.Drawing.Point(153, 153);
            this.chkDropAmountRandom.Name = "chkDropAmountRandom";
            this.chkDropAmountRandom.Size = new System.Drawing.Size(72, 17);
            this.chkDropAmountRandom.TabIndex = 46;
            this.chkDropAmountRandom.Text = "Random?";
            this.chkDropAmountRandom.CheckedChanged += new System.EventHandler(this.chkDropAmountRandom_CheckedChanged);
            // 
            // chkIndividualLoot
            // 
            this.chkIndividualLoot.AutoSize = true;
            this.chkIndividualLoot.Location = new System.Drawing.Point(6, 262);
            this.chkIndividualLoot.Name = "chkIndividualLoot";
            this.chkIndividualLoot.Size = new System.Drawing.Size(165, 17);
            this.chkIndividualLoot.TabIndex = 78;
            this.chkIndividualLoot.Text = "Spawn Loot for all Attackers?";
            this.chkIndividualLoot.CheckedChanged += new System.EventHandler(this.chkIndividualLoot_CheckedChanged);
            // 
            // btnDropRemove
            // 
            this.btnDropRemove.Location = new System.Drawing.Point(126, 230);
            this.btnDropRemove.Name = "btnDropRemove";
            this.btnDropRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnDropRemove.Size = new System.Drawing.Size(75, 23);
            this.btnDropRemove.TabIndex = 64;
            this.btnDropRemove.Text = "Remove";
            this.btnDropRemove.Click += new System.EventHandler(this.btnDropRemove_Click);
            // 
            // btnDropAdd
            // 
            this.btnDropAdd.Location = new System.Drawing.Point(6, 230);
            this.btnDropAdd.Name = "btnDropAdd";
            this.btnDropAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnDropAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDropAdd.TabIndex = 63;
            this.btnDropAdd.Text = "Add";
            this.btnDropAdd.Click += new System.EventHandler(this.btnDropAdd_Click);
            // 
            // lstDrops
            // 
            this.lstDrops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstDrops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDrops.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstDrops.FormattingEnabled = true;
            this.lstDrops.Location = new System.Drawing.Point(9, 19);
            this.lstDrops.Name = "lstDrops";
            this.lstDrops.Size = new System.Drawing.Size(211, 67);
            this.lstDrops.TabIndex = 62;
            this.lstDrops.SelectedIndexChanged += new System.EventHandler(this.lstDrops_SelectedIndexChanged);
            // 
            // nudDropAmount
            // 
            this.nudDropAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDropAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDropAmount.Location = new System.Drawing.Point(6, 152);
            this.nudDropAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDropAmount.Name = "nudDropAmount";
            this.nudDropAmount.Size = new System.Drawing.Size(140, 20);
            this.nudDropAmount.TabIndex = 61;
            this.nudDropAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDropAmount.ValueChanged += new System.EventHandler(this.nudDropAmount_ValueChanged);
            // 
            // nudDropChance
            // 
            this.nudDropChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDropChance.DecimalPlaces = 2;
            this.nudDropChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDropChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDropChance.Location = new System.Drawing.Point(6, 198);
            this.nudDropChance.Name = "nudDropChance";
            this.nudDropChance.Size = new System.Drawing.Size(140, 20);
            this.nudDropChance.TabIndex = 60;
            this.nudDropChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDropChance.ValueChanged += new System.EventHandler(this.nudDropChance_ValueChanged);
            // 
            // cmbDropItem
            // 
            this.cmbDropItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDropItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDropItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDropItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDropItem.DrawDropdownHoverOutline = false;
            this.cmbDropItem.DrawFocusRectangle = false;
            this.cmbDropItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDropItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDropItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDropItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDropItem.FormattingEnabled = true;
            this.cmbDropItem.Location = new System.Drawing.Point(6, 110);
            this.cmbDropItem.Name = "cmbDropItem";
            this.cmbDropItem.Size = new System.Drawing.Size(214, 21);
            this.cmbDropItem.TabIndex = 17;
            this.cmbDropItem.Text = null;
            this.cmbDropItem.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDropItem.SelectedIndexChanged += new System.EventHandler(this.cmbDropItem_SelectedIndexChanged);
            // 
            // lblDropAmount
            // 
            this.lblDropAmount.AutoSize = true;
            this.lblDropAmount.Location = new System.Drawing.Point(3, 136);
            this.lblDropAmount.Name = "lblDropAmount";
            this.lblDropAmount.Size = new System.Drawing.Size(46, 13);
            this.lblDropAmount.TabIndex = 15;
            this.lblDropAmount.Text = "Amount:";
            // 
            // lblDropChance
            // 
            this.lblDropChance.AutoSize = true;
            this.lblDropChance.Location = new System.Drawing.Point(3, 181);
            this.lblDropChance.Name = "lblDropChance";
            this.lblDropChance.Size = new System.Drawing.Size(64, 13);
            this.lblDropChance.TabIndex = 13;
            this.lblDropChance.Text = "Chance (%):";
            // 
            // lblDropItem
            // 
            this.lblDropItem.AutoSize = true;
            this.lblDropItem.Location = new System.Drawing.Point(3, 93);
            this.lblDropItem.Name = "lblDropItem";
            this.lblDropItem.Size = new System.Drawing.Size(30, 13);
            this.lblDropItem.TabIndex = 11;
            this.lblDropItem.Text = "Item:";
            // 
            // grpNpcVsNpc
            // 
            this.grpNpcVsNpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpNpcVsNpc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpNpcVsNpc.Controls.Add(this.cmbHostileNPC);
            this.grpNpcVsNpc.Controls.Add(this.lblNPC);
            this.grpNpcVsNpc.Controls.Add(this.btnRemoveAggro);
            this.grpNpcVsNpc.Controls.Add(this.btnAddAggro);
            this.grpNpcVsNpc.Controls.Add(this.lstAggro);
            this.grpNpcVsNpc.Controls.Add(this.chkAttackAllies);
            this.grpNpcVsNpc.Controls.Add(this.chkEnabled);
            this.grpNpcVsNpc.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpNpcVsNpc.Location = new System.Drawing.Point(3, 798);
            this.grpNpcVsNpc.Name = "grpNpcVsNpc";
            this.grpNpcVsNpc.Size = new System.Drawing.Size(206, 273);
            this.grpNpcVsNpc.TabIndex = 29;
            this.grpNpcVsNpc.TabStop = false;
            this.grpNpcVsNpc.Text = "NPC vs NPC Combat/Hostility ";
            // 
            // cmbHostileNPC
            // 
            this.cmbHostileNPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbHostileNPC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbHostileNPC.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbHostileNPC.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbHostileNPC.DrawDropdownHoverOutline = false;
            this.cmbHostileNPC.DrawFocusRectangle = false;
            this.cmbHostileNPC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHostileNPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHostileNPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHostileNPC.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbHostileNPC.FormattingEnabled = true;
            this.cmbHostileNPC.Location = new System.Drawing.Point(9, 84);
            this.cmbHostileNPC.Name = "cmbHostileNPC";
            this.cmbHostileNPC.Size = new System.Drawing.Size(191, 21);
            this.cmbHostileNPC.TabIndex = 45;
            this.cmbHostileNPC.Text = null;
            this.cmbHostileNPC.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblNPC
            // 
            this.lblNPC.AutoSize = true;
            this.lblNPC.Location = new System.Drawing.Point(6, 67);
            this.lblNPC.Name = "lblNPC";
            this.lblNPC.Size = new System.Drawing.Size(32, 13);
            this.lblNPC.TabIndex = 44;
            this.lblNPC.Text = "NPC:";
            // 
            // btnRemoveAggro
            // 
            this.btnRemoveAggro.Location = new System.Drawing.Point(125, 241);
            this.btnRemoveAggro.Name = "btnRemoveAggro";
            this.btnRemoveAggro.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveAggro.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAggro.TabIndex = 43;
            this.btnRemoveAggro.Text = "Remove";
            this.btnRemoveAggro.Click += new System.EventHandler(this.btnRemoveAggro_Click);
            // 
            // btnAddAggro
            // 
            this.btnAddAggro.Location = new System.Drawing.Point(9, 241);
            this.btnAddAggro.Name = "btnAddAggro";
            this.btnAddAggro.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddAggro.Size = new System.Drawing.Size(75, 23);
            this.btnAddAggro.TabIndex = 42;
            this.btnAddAggro.Text = "Add";
            this.btnAddAggro.Click += new System.EventHandler(this.btnAddAggro_Click);
            // 
            // lstAggro
            // 
            this.lstAggro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstAggro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAggro.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstAggro.FormattingEnabled = true;
            this.lstAggro.Items.AddRange(new object[] {
            "NPC:"});
            this.lstAggro.Location = new System.Drawing.Point(9, 122);
            this.lstAggro.Name = "lstAggro";
            this.lstAggro.Size = new System.Drawing.Size(191, 106);
            this.lstAggro.TabIndex = 41;
            // 
            // chkAttackAllies
            // 
            this.chkAttackAllies.AutoSize = true;
            this.chkAttackAllies.Location = new System.Drawing.Point(8, 42);
            this.chkAttackAllies.Name = "chkAttackAllies";
            this.chkAttackAllies.Size = new System.Drawing.Size(90, 17);
            this.chkAttackAllies.TabIndex = 1;
            this.chkAttackAllies.Text = "Attack Allies?";
            this.chkAttackAllies.CheckedChanged += new System.EventHandler(this.chkAttackAllies_CheckedChanged);
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(8, 19);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(71, 17);
            this.chkEnabled.TabIndex = 0;
            this.chkEnabled.Text = "Enabled?";
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // grpSpells
            // 
            this.grpSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpells.Controls.Add(this.nudSpellFrequency);
            this.grpSpells.Controls.Add(this.nudSpellPriority);
            this.grpSpells.Controls.Add(this.lblPrioritySpell);
            this.grpSpells.Controls.Add(this.nudAfterSpell);
            this.grpSpells.Controls.Add(this.lblAfterSpell);
            this.grpSpells.Controls.Add(this.nudBeforeSpell);
            this.grpSpells.Controls.Add(this.lblBeforeSpell);
            this.grpSpells.Controls.Add(this.cmbSpell);
            this.grpSpells.Controls.Add(this.lblFreq);
            this.grpSpells.Controls.Add(this.lblSpell);
            this.grpSpells.Controls.Add(this.btnRemove);
            this.grpSpells.Controls.Add(this.btnAdd);
            this.grpSpells.Controls.Add(this.lstSpells);
            this.grpSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpells.Location = new System.Drawing.Point(2, 553);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Size = new System.Drawing.Size(207, 239);
            this.grpSpells.TabIndex = 28;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells";
            // 
            // nudSpellFrequency
            // 
            this.nudSpellFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpellFrequency.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpellFrequency.Location = new System.Drawing.Point(158, 17);
            this.nudSpellFrequency.Name = "nudSpellFrequency";
            this.nudSpellFrequency.Size = new System.Drawing.Size(45, 20);
            this.nudSpellFrequency.TabIndex = 63;
            this.nudSpellFrequency.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpellFrequency.ValueChanged += new System.EventHandler(this.nudSpellFrequency_ValueChanged);
            // 
            // nudSpellPriority
            // 
            this.nudSpellPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpellPriority.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpellPriority.Location = new System.Drawing.Point(82, 187);
            this.nudSpellPriority.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSpellPriority.Name = "nudSpellPriority";
            this.nudSpellPriority.Size = new System.Drawing.Size(40, 20);
            this.nudSpellPriority.TabIndex = 62;
            this.nudSpellPriority.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpellPriority.ValueChanged += new System.EventHandler(this.nudSpellPriority_ValueChanged);
            // 
            // lblPrioritySpell
            // 
            this.lblPrioritySpell.AutoSize = true;
            this.lblPrioritySpell.Location = new System.Drawing.Point(82, 172);
            this.lblPrioritySpell.Name = "lblPrioritySpell";
            this.lblPrioritySpell.Size = new System.Drawing.Size(41, 13);
            this.lblPrioritySpell.TabIndex = 61;
            this.lblPrioritySpell.Text = "Priority:";
            // 
            // nudAfterSpell
            // 
            this.nudAfterSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAfterSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAfterSpell.Location = new System.Drawing.Point(137, 187);
            this.nudAfterSpell.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAfterSpell.Name = "nudAfterSpell";
            this.nudAfterSpell.Size = new System.Drawing.Size(55, 20);
            this.nudAfterSpell.TabIndex = 60;
            this.nudAfterSpell.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAfterSpell.ValueChanged += new System.EventHandler(this.nudAfterSpell_ValueChanged);
            // 
            // lblAfterSpell
            // 
            this.lblAfterSpell.AutoSize = true;
            this.lblAfterSpell.Location = new System.Drawing.Point(138, 172);
            this.lblAfterSpell.Name = "lblAfterSpell";
            this.lblAfterSpell.Size = new System.Drawing.Size(54, 13);
            this.lblAfterSpell.TabIndex = 59;
            this.lblAfterSpell.Text = "After (ms):";
            // 
            // nudBeforeSpell
            // 
            this.nudBeforeSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBeforeSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBeforeSpell.Location = new System.Drawing.Point(13, 187);
            this.nudBeforeSpell.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudBeforeSpell.Name = "nudBeforeSpell";
            this.nudBeforeSpell.Size = new System.Drawing.Size(55, 20);
            this.nudBeforeSpell.TabIndex = 58;
            this.nudBeforeSpell.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudBeforeSpell.ValueChanged += new System.EventHandler(this.nudBeforeSpell_ValueChanged);
            // 
            // lblBeforeSpell
            // 
            this.lblBeforeSpell.AutoSize = true;
            this.lblBeforeSpell.Location = new System.Drawing.Point(10, 172);
            this.lblBeforeSpell.Name = "lblBeforeSpell";
            this.lblBeforeSpell.Size = new System.Drawing.Size(63, 13);
            this.lblBeforeSpell.TabIndex = 57;
            this.lblBeforeSpell.Text = "Before (ms):";
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
            this.cmbSpell.Location = new System.Drawing.Point(13, 150);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(179, 21);
            this.cmbSpell.TabIndex = 43;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(7, 20);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(149, 13);
            this.lblFreq.TabIndex = 41;
            this.lblFreq.Text = "Use spells when available (%):";
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(10, 134);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(33, 13);
            this.lblSpell.TabIndex = 39;
            this.lblSpell.Text = "Spell:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(117, 213);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstSpells
            // 
            this.lstSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstSpells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSpells.FormattingEnabled = true;
            this.lstSpells.Location = new System.Drawing.Point(4, 40);
            this.lstSpells.Name = "lstSpells";
            this.lstSpells.Size = new System.Drawing.Size(199, 93);
            this.lstSpells.TabIndex = 29;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(476, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.toolStrip.Size = new System.Drawing.Size(699, 25);
            this.toolStrip.TabIndex = 45;
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
            // searchableDarkTreeView1
            // 
            this.searchableDarkTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.searchableDarkTreeView1.ItemProvider = null;
            this.searchableDarkTreeView1.Location = new System.Drawing.Point(11, 27);
            this.searchableDarkTreeView1.Margin = new System.Windows.Forms.Padding(2);
            this.searchableDarkTreeView1.Name = "searchableDarkTreeView1";
            this.searchableDarkTreeView1.SearchText = "";
            this.searchableDarkTreeView1.SelectedId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.searchableDarkTreeView1.Size = new System.Drawing.Size(240, 480);
            this.searchableDarkTreeView1.TabIndex = 46;
            this.searchableDarkTreeView1.Visible = false;
            // 
            // nudAttackRange
            // 
            this.nudAttackRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAttackRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAttackRange.Location = new System.Drawing.Point(12, 313);
            this.nudAttackRange.Name = "nudAttackRange";
            this.nudAttackRange.Size = new System.Drawing.Size(192, 20);
            this.nudAttackRange.TabIndex = 70;
            this.nudAttackRange.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAttackRange.ValueChanged += new System.EventHandler(this.nudAttackRange_ValueChanged);
            // 
            // lblAttackRange
            // 
            this.lblAttackRange.AutoSize = true;
            this.lblAttackRange.Location = new System.Drawing.Point(8, 296);
            this.lblAttackRange.Name = "lblAttackRange";
            this.lblAttackRange.Size = new System.Drawing.Size(76, 13);
            this.lblAttackRange.TabIndex = 69;
            this.lblAttackRange.Text = "Attack Range:";
            // 
            // FrmNpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(699, 615);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpNpcs);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.searchableDarkTreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmNpc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNpc_FormClosed);
            this.Load += new System.EventHandler(this.frmNpc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpNpcs.ResumeLayout(false);
            this.grpNpcs.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpTypes.ResumeLayout(false);
            this.grpTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRgbaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSightRange)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.grpPhases.ResumeLayout(false);
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            this.grpAttackSpeed.ResumeLayout(false);
            this.grpAttackSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).EndInit();
            this.grpCommonEvents.ResumeLayout(false);
            this.grpCommonEvents.PerformLayout();
            this.grpBehavior.ResumeLayout(false);
            this.grpBehavior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSwarmRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResetRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlee)).EndInit();
            this.grpConditions.ResumeLayout(false);
            this.grpRegen.ResumeLayout(false);
            this.grpRegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).EndInit();
            this.grpDrops.ResumeLayout(false);
            this.grpDrops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropChance)).EndInit();
            this.grpNpcVsNpc.ResumeLayout(false);
            this.grpNpcVsNpc.PerformLayout();
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpellFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpellPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfterSpell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeforeSpell)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackRange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkGroupBox grpNpcs;
        private DarkGroupBox grpGeneral;
        private DarkComboBox cmbSprite;
        private System.Windows.Forms.Label lblSpawnDuration;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.PictureBox picNpc;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkGroupBox grpStats;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblSightRange;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkGroupBox grpSpells;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.ListBox lstSpells;
        private System.Windows.Forms.Label lblSpell;
        private System.Windows.Forms.Label lblFreq;
        private DarkGroupBox grpNpcVsNpc;
        private System.Windows.Forms.Label lblNPC;
        private DarkButton btnRemoveAggro;
        private DarkButton btnAddAggro;
        private System.Windows.Forms.ListBox lstAggro;
        private DarkCheckBox chkAttackAllies;
        private DarkCheckBox chkEnabled;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkGroupBox grpCombat;
        private DarkComboBox cmbScalingStat;
        private System.Windows.Forms.Label lblScalingStat;
        private System.Windows.Forms.Label lblScaling;
        private DarkComboBox cmbDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.Label lblCritChance;
        private DarkComboBox cmbAttackAnimation;
        private System.Windows.Forms.Label lblAttackAnimation;
        private System.Windows.Forms.Label lblDamage;
        private DarkComboBox cmbHostileNPC;
        private DarkComboBox cmbSpell;
        private DarkNumericUpDown nudSpd;
        private DarkNumericUpDown nudMR;
        private DarkNumericUpDown nudDef;
        private DarkNumericUpDown nudMag;
        private DarkNumericUpDown nudStr;
        private System.Windows.Forms.Label lblSpd;
        private System.Windows.Forms.Label lblMR;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.Label lblStr;
        private DarkNumericUpDown nudScaling;
        private DarkNumericUpDown nudDamage;
        private DarkNumericUpDown nudCritChance;
        private DarkNumericUpDown nudSightRange;
        private DarkNumericUpDown nudSpawnDuration;
        private DarkNumericUpDown nudMana;
        private DarkNumericUpDown nudHp;
        private DarkNumericUpDown nudExp;
        private System.Windows.Forms.Label lblLevel;
        private DarkNumericUpDown nudLevel;
        private DarkGroupBox grpDrops;
        private DarkButton btnDropRemove;
        private DarkButton btnDropAdd;
        private System.Windows.Forms.ListBox lstDrops;
        private DarkNumericUpDown nudDropAmount;
        private DarkNumericUpDown nudDropChance;
        private DarkComboBox cmbDropItem;
        private System.Windows.Forms.Label lblDropAmount;
        private System.Windows.Forms.Label lblDropChance;
        private System.Windows.Forms.Label lblDropItem;
        private DarkGroupBox grpRegen;
        private DarkNumericUpDown nudMpRegen;
        private DarkNumericUpDown nudHpRegen;
        private System.Windows.Forms.Label lblHpRegen;
        private System.Windows.Forms.Label lblManaRegen;
        private System.Windows.Forms.Label lblRegenHint;
        private DarkGroupBox grpCommonEvents;
        private DarkGroupBox grpBehavior;
        private DarkCheckBox chkSwarm;
        private DarkGroupBox grpConditions;
        private DarkButton btnAttackOnSightCond;
        private DarkButton btnPlayerCanAttackCond;
        private DarkButton btnPlayerFriendProtectorCond;
        private System.Windows.Forms.Label lblMovement;
        private DarkComboBox cmbMovement;
        private DarkCheckBox chkAggressive;
        private DarkComboBox cmbOnDeathEventParty;
        private System.Windows.Forms.Label lblOnDeathEventParty;
        private DarkComboBox cmbOnDeathEventKiller;
        private System.Windows.Forms.Label lblOnDeathEventKiller;
        private DarkNumericUpDown nudFlee;
        private System.Windows.Forms.Label lblFlee;
        private System.Windows.Forms.Label lblFocusDamageDealer;
        private DarkCheckBox chkFocusDamageDealer;
        private DarkNumericUpDown nudCritMultiplier;
        private System.Windows.Forms.Label lblCritMultiplier;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Controls.SearchableDarkTreeView searchableDarkTreeView1;
        private DarkGroupBox grpAttackSpeed;
        private DarkNumericUpDown nudAttackSpeedValue;
        private System.Windows.Forms.Label lblAttackSpeedValue;
        private DarkComboBox cmbAttackSpeedModifier;
        private System.Windows.Forms.Label lblAttackSpeedModifier;
        private DarkNumericUpDown nudRgbaA;
        private DarkNumericUpDown nudRgbaB;
        private DarkNumericUpDown nudRgbaG;
        private DarkNumericUpDown nudRgbaR;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private DarkNumericUpDown nudResetRadius;
        private System.Windows.Forms.Label lblResetRadius;
        private DarkCheckBox chkIndividualLoot;
        private Controls.GameObjectList lstGameObjects;
        private System.Windows.Forms.Label lblMaxMove;
        private DarkNumericUpDown nudMaxMove;
        private DarkButton btnPlayerCanProjectileCond;
        private DarkButton btnPlayerCanSpellCond;
        private DarkNumericUpDown nudSwarmRange;
        private System.Windows.Forms.Label lblSwarmRange;
        private DarkCheckBox chkSwarmOnPlayer;
        private DarkCheckBox chkSwarmAll;
        private DarkComboBox cmbNpcToSwarm;
        private System.Windows.Forms.Label lblNpcToSwarm;
        private DarkButton btnRemoveSwarm;
        private DarkButton btnAddSwarm;
        private System.Windows.Forms.ListBox lstSwarm;
        private DarkCheckBox chkAttackOnFlee;
        private System.Windows.Forms.Label lblEditorName;
        private DarkTextBox txtEditorName;
        public System.Windows.Forms.ToolStripButton toolStripItemRelations;
        private DarkCheckBox chkDropAmountRandom;
        private DarkCheckBox chkDropChanceIterative;
        private DarkGroupBox grpPhases;
        private DarkButton btnRemovePhase;
        private DarkButton btnAddPhase;
        private System.Windows.Forms.ListBox lstPhases;
        private DarkCheckBox chkRegenReset;
        private DarkComboBox cmbType1;
        private System.Windows.Forms.Label lblType1;
        private DarkComboBox cmbType2;
        private System.Windows.Forms.Label lblType2;
        private DarkGroupBox grpTypes;
        private DarkNumericUpDown nudSpellPriority;
        private System.Windows.Forms.Label lblPrioritySpell;
        private DarkNumericUpDown nudAfterSpell;
        private System.Windows.Forms.Label lblAfterSpell;
        private DarkNumericUpDown nudBeforeSpell;
        private System.Windows.Forms.Label lblBeforeSpell;
        private DarkNumericUpDown nudSpellFrequency;
        private DarkNumericUpDown nudAttackRange;
        private System.Windows.Forms.Label lblAttackRange;
    }
}