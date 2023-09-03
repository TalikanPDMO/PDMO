﻿using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmSpell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpell));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.cmbTilesAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblTilesAnimation = new System.Windows.Forms.Label();
            this.cmbImpactAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblImpactAnimation = new System.Windows.Forms.Label();
            this.lblElementalType = new System.Windows.Forms.Label();
            this.cmbElementalType = new DarkUI.Controls.DarkComboBox();
            this.lblEditorName = new System.Windows.Forms.Label();
            this.txtEditorName = new DarkUI.Controls.DarkTextBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.chkBound = new DarkUI.Controls.DarkCheckBox();
            this.cmbHitAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.lblHitAnimation = new System.Windows.Forms.Label();
            this.cmbSprite = new DarkUI.Controls.DarkComboBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.picSpell = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new DarkUI.Controls.DarkComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.grpSpellCost = new DarkUI.Controls.DarkGroupBox();
            this.chkIgnoreCdr = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreGlobalCooldown = new DarkUI.Controls.DarkCheckBox();
            this.btnAddCooldownGroup = new DarkUI.Controls.DarkButton();
            this.cmbCooldownGroup = new DarkUI.Controls.DarkComboBox();
            this.lblCooldownGroup = new System.Windows.Forms.Label();
            this.nudCooldownDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.nudCastDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMpCost = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHPCost = new DarkUI.Controls.DarkNumericUpDown();
            this.lblMPCost = new System.Windows.Forms.Label();
            this.lblHPCost = new System.Windows.Forms.Label();
            this.lblCastDuration = new System.Windows.Forms.Label();
            this.lblCooldownDuration = new System.Windows.Forms.Label();
            this.grpCasting = new DarkUI.Controls.DarkGroupBox();
            this.cmbCastTargetAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblCastTargetAnimation = new System.Windows.Forms.Label();
            this.btnDynamicRequirements = new DarkUI.Controls.DarkButton();
            this.lblCannotCast = new System.Windows.Forms.Label();
            this.txtCannotCast = new DarkUI.Controls.DarkTextBox();
            this.cmbCastAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblCastAnimation = new System.Windows.Forms.Label();
            this.grpTargetInfo = new DarkUI.Controls.DarkGroupBox();
            this.chkSquareRadius = new DarkUI.Controls.DarkCheckBox();
            this.chkSquareRange = new DarkUI.Controls.DarkCheckBox();
            this.nudDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.nudHitRadius = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHitRadius = new System.Windows.Forms.Label();
            this.cmbTargetType = new DarkUI.Controls.DarkComboBox();
            this.lblCastRange = new System.Windows.Forms.Label();
            this.lblTargetType = new System.Windows.Forms.Label();
            this.nudCastRange = new DarkUI.Controls.DarkNumericUpDown();
            this.lblProjectile = new System.Windows.Forms.Label();
            this.cmbProjectile = new DarkUI.Controls.DarkComboBox();
            this.grpWarp = new DarkUI.Controls.DarkGroupBox();
            this.nudWarpY = new DarkUI.Controls.DarkNumericUpDown();
            this.nudWarpX = new DarkUI.Controls.DarkNumericUpDown();
            this.btnVisualMapSelector = new DarkUI.Controls.DarkButton();
            this.cmbWarpMap = new DarkUI.Controls.DarkComboBox();
            this.cmbDirection = new DarkUI.Controls.DarkComboBox();
            this.lblWarpDir = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.grpEvent = new DarkUI.Controls.DarkGroupBox();
            this.cmbEvent = new DarkUI.Controls.DarkComboBox();
            this.grpCombat = new DarkUI.Controls.DarkGroupBox();
            this.grpDamage = new DarkUI.Controls.DarkGroupBox();
            this.nudManaSteal = new DarkUI.Controls.DarkNumericUpDown();
            this.lblManaSteal = new System.Windows.Forms.Label();
            this.nudHPSteal = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHPSteal = new System.Windows.Forms.Label();
            this.cmbCritEffectSpell = new DarkUI.Controls.DarkComboBox();
            this.lblCritEffectSpell = new System.Windows.Forms.Label();
            this.nudCritMultiplier = new DarkUI.Controls.DarkNumericUpDown();
            this.lblCritMultiplier = new System.Windows.Forms.Label();
            this.nudCritChance = new DarkUI.Controls.DarkNumericUpDown();
            this.nudScaling = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMPDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHPDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbScalingStat = new DarkUI.Controls.DarkComboBox();
            this.lblScalingStat = new System.Windows.Forms.Label();
            this.chkFriendly = new DarkUI.Controls.DarkCheckBox();
            this.lblCritChance = new System.Windows.Forms.Label();
            this.lblScaling = new System.Windows.Forms.Label();
            this.cmbDamageType = new DarkUI.Controls.DarkComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.lblHPDamage = new System.Windows.Forms.Label();
            this.lblManaDamage = new System.Windows.Forms.Label();
            this.chkReplaceCritEffectSpell = new DarkUI.Controls.DarkCheckBox();
            this.grpNextSpell = new DarkUI.Controls.DarkGroupBox();
            this.lblNextSpellChance = new System.Windows.Forms.Label();
            this.nudNextSpellChance = new DarkUI.Controls.DarkNumericUpDown();
            this.chkReUseValues = new DarkUI.Controls.DarkCheckBox();
            this.cmbNextSpell = new DarkUI.Controls.DarkComboBox();
            this.grpStats = new DarkUI.Controls.DarkGroupBox();
            this.nudSpdChance = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMRChance = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDefChance = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMagChance = new DarkUI.Controls.DarkNumericUpDown();
            this.lblStatsChance = new System.Windows.Forms.Label();
            this.nudStrChance = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPercentage5 = new System.Windows.Forms.Label();
            this.lblPercentage4 = new System.Windows.Forms.Label();
            this.lblPercentage3 = new System.Windows.Forms.Label();
            this.lblPercentage2 = new System.Windows.Forms.Label();
            this.lblPercentage1 = new System.Windows.Forms.Label();
            this.nudSpdPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMRPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDefPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMagPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStrPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlus5 = new System.Windows.Forms.Label();
            this.lblPlus4 = new System.Windows.Forms.Label();
            this.lblPlus3 = new System.Windows.Forms.Label();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.lblPlus1 = new System.Windows.Forms.Label();
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
            this.grpHotDot = new DarkUI.Controls.DarkGroupBox();
            this.nudTick = new DarkUI.Controls.DarkNumericUpDown();
            this.chkHOTDOT = new DarkUI.Controls.DarkCheckBox();
            this.lblTick = new System.Windows.Forms.Label();
            this.grpEffect = new DarkUI.Controls.DarkGroupBox();
            this.nudEffectChance = new DarkUI.Controls.DarkNumericUpDown();
            this.lblEffectChance = new System.Windows.Forms.Label();
            this.lblEffect = new System.Windows.Forms.Label();
            this.cmbExtraEffect = new DarkUI.Controls.DarkComboBox();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.cmbTransform = new DarkUI.Controls.DarkComboBox();
            this.lblSprite = new System.Windows.Forms.Label();
            this.grpEffectDuration = new DarkUI.Controls.DarkGroupBox();
            this.nudBuffDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblBuffDuration = new System.Windows.Forms.Label();
            this.grpDash = new DarkUI.Controls.DarkGroupBox();
            this.grpDashCollisions = new DarkUI.Controls.DarkGroupBox();
            this.chkIgnoreInactiveResources = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreZDimensionBlocks = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreMapBlocks = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreActiveResources = new DarkUI.Controls.DarkCheckBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.scrlRange = new DarkUI.Controls.DarkScrollBar();
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
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpSpells = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstGameObjects = new Intersect.Editor.Forms.Controls.GameObjectList();
            this.pnlContainer.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpell)).BeginInit();
            this.grpSpellCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCooldownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCastDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPCost)).BeginInit();
            this.grpCasting.SuspendLayout();
            this.grpTargetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCastRange)).BeginInit();
            this.grpWarp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpX)).BeginInit();
            this.grpEvent.SuspendLayout();
            this.grpCombat.SuspendLayout();
            this.grpDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudManaSteal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPSteal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMPDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPDamage)).BeginInit();
            this.grpNextSpell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextSpellChance)).BeginInit();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            this.grpHotDot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTick)).BeginInit();
            this.grpEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEffectChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            this.grpEffectDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuffDuration)).BeginInit();
            this.grpDash.SuspendLayout();
            this.grpDashCollisions.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.grpSpells.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpSpellCost);
            this.pnlContainer.Controls.Add(this.grpCasting);
            this.pnlContainer.Controls.Add(this.grpTargetInfo);
            this.pnlContainer.Controls.Add(this.grpWarp);
            this.pnlContainer.Controls.Add(this.grpEvent);
            this.pnlContainer.Controls.Add(this.grpCombat);
            this.pnlContainer.Controls.Add(this.grpDash);
            this.pnlContainer.Location = new System.Drawing.Point(221, 40);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(755, 673);
            this.pnlContainer.TabIndex = 41;
            this.pnlContainer.Visible = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.cmbTilesAnimation);
            this.grpGeneral.Controls.Add(this.lblTilesAnimation);
            this.grpGeneral.Controls.Add(this.cmbImpactAnimation);
            this.grpGeneral.Controls.Add(this.lblImpactAnimation);
            this.grpGeneral.Controls.Add(this.lblElementalType);
            this.grpGeneral.Controls.Add(this.cmbElementalType);
            this.grpGeneral.Controls.Add(this.lblEditorName);
            this.grpGeneral.Controls.Add(this.txtEditorName);
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.chkBound);
            this.grpGeneral.Controls.Add(this.cmbHitAnimation);
            this.grpGeneral.Controls.Add(this.lblDesc);
            this.grpGeneral.Controls.Add(this.txtDesc);
            this.grpGeneral.Controls.Add(this.lblHitAnimation);
            this.grpGeneral.Controls.Add(this.cmbSprite);
            this.grpGeneral.Controls.Add(this.lblIcon);
            this.grpGeneral.Controls.Add(this.picSpell);
            this.grpGeneral.Controls.Add(this.lblType);
            this.grpGeneral.Controls.Add(this.cmbType);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(2, 0);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(234, 353);
            this.grpGeneral.TabIndex = 17;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // cmbTilesAnimation
            // 
            this.cmbTilesAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTilesAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTilesAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTilesAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTilesAnimation.DrawDropdownHoverOutline = false;
            this.cmbTilesAnimation.DrawFocusRectangle = false;
            this.cmbTilesAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTilesAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTilesAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTilesAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTilesAnimation.FormattingEnabled = true;
            this.cmbTilesAnimation.Location = new System.Drawing.Point(72, 303);
            this.cmbTilesAnimation.Name = "cmbTilesAnimation";
            this.cmbTilesAnimation.Size = new System.Drawing.Size(156, 21);
            this.cmbTilesAnimation.TabIndex = 67;
            this.cmbTilesAnimation.Text = null;
            this.cmbTilesAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTilesAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbTilesAnimation_SelectedIndexChanged);
            // 
            // lblTilesAnimation
            // 
            this.lblTilesAnimation.AutoSize = true;
            this.lblTilesAnimation.Location = new System.Drawing.Point(2, 306);
            this.lblTilesAnimation.Name = "lblTilesAnimation";
            this.lblTilesAnimation.Size = new System.Drawing.Size(58, 13);
            this.lblTilesAnimation.TabIndex = 66;
            this.lblTilesAnimation.Text = "Tiles Anim:";
            // 
            // cmbImpactAnimation
            // 
            this.cmbImpactAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbImpactAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbImpactAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbImpactAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbImpactAnimation.DrawDropdownHoverOutline = false;
            this.cmbImpactAnimation.DrawFocusRectangle = false;
            this.cmbImpactAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbImpactAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpactAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbImpactAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbImpactAnimation.FormattingEnabled = true;
            this.cmbImpactAnimation.Location = new System.Drawing.Point(72, 278);
            this.cmbImpactAnimation.Name = "cmbImpactAnimation";
            this.cmbImpactAnimation.Size = new System.Drawing.Size(156, 21);
            this.cmbImpactAnimation.TabIndex = 65;
            this.cmbImpactAnimation.Text = null;
            this.cmbImpactAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbImpactAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbImpactAnimation_SelectedIndexChanged);
            // 
            // lblImpactAnimation
            // 
            this.lblImpactAnimation.AutoSize = true;
            this.lblImpactAnimation.Location = new System.Drawing.Point(2, 281);
            this.lblImpactAnimation.Name = "lblImpactAnimation";
            this.lblImpactAnimation.Size = new System.Drawing.Size(68, 13);
            this.lblImpactAnimation.TabIndex = 64;
            this.lblImpactAnimation.Text = "Impact Anim:";
            // 
            // lblElementalType
            // 
            this.lblElementalType.AutoSize = true;
            this.lblElementalType.Location = new System.Drawing.Point(2, 167);
            this.lblElementalType.Name = "lblElementalType";
            this.lblElementalType.Size = new System.Drawing.Size(83, 13);
            this.lblElementalType.TabIndex = 63;
            this.lblElementalType.Text = "Elemental Type:";
            // 
            // cmbElementalType
            // 
            this.cmbElementalType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbElementalType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbElementalType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbElementalType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbElementalType.DrawDropdownHoverOutline = false;
            this.cmbElementalType.DrawFocusRectangle = false;
            this.cmbElementalType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbElementalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElementalType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbElementalType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbElementalType.FormattingEnabled = true;
            this.cmbElementalType.Location = new System.Drawing.Point(86, 164);
            this.cmbElementalType.Name = "cmbElementalType";
            this.cmbElementalType.Size = new System.Drawing.Size(143, 21);
            this.cmbElementalType.TabIndex = 62;
            this.cmbElementalType.Text = "None";
            this.cmbElementalType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbElementalType.SelectedIndexChanged += new System.EventHandler(this.cmbElementalType_SelectedIndexChanged);
            // 
            // lblEditorName
            // 
            this.lblEditorName.AutoSize = true;
            this.lblEditorName.Location = new System.Drawing.Point(3, 71);
            this.lblEditorName.Name = "lblEditorName";
            this.lblEditorName.Size = new System.Drawing.Size(68, 13);
            this.lblEditorName.TabIndex = 61;
            this.lblEditorName.Text = "Editor Name:";
            // 
            // txtEditorName
            // 
            this.txtEditorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtEditorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtEditorName.Location = new System.Drawing.Point(74, 68);
            this.txtEditorName.Name = "txtEditorName";
            this.txtEditorName.Size = new System.Drawing.Size(155, 20);
            this.txtEditorName.TabIndex = 60;
            this.txtEditorName.TextChanged += new System.EventHandler(this.txtEditorName_TextChanged);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(211, 42);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 59;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(2, 46);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 58;
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
            this.cmbFolder.Location = new System.Drawing.Point(56, 43);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(146, 21);
            this.cmbFolder.TabIndex = 57;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // chkBound
            // 
            this.chkBound.AutoSize = true;
            this.chkBound.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBound.Location = new System.Drawing.Point(143, 190);
            this.chkBound.Name = "chkBound";
            this.chkBound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBound.Size = new System.Drawing.Size(63, 17);
            this.chkBound.TabIndex = 56;
            this.chkBound.Text = "Bound?";
            this.chkBound.CheckedChanged += new System.EventHandler(this.chkBound_CheckedChanged);
            // 
            // cmbHitAnimation
            // 
            this.cmbHitAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbHitAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbHitAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbHitAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbHitAnimation.DrawDropdownHoverOutline = false;
            this.cmbHitAnimation.DrawFocusRectangle = false;
            this.cmbHitAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHitAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHitAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHitAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbHitAnimation.FormattingEnabled = true;
            this.cmbHitAnimation.Location = new System.Drawing.Point(72, 328);
            this.cmbHitAnimation.Name = "cmbHitAnimation";
            this.cmbHitAnimation.Size = new System.Drawing.Size(157, 21);
            this.cmbHitAnimation.TabIndex = 21;
            this.cmbHitAnimation.Text = null;
            this.cmbHitAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbHitAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbHitAnimation_SelectedIndexChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(2, 192);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 19;
            this.lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(5, 208);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(223, 66);
            this.txtDesc.TabIndex = 18;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // lblHitAnimation
            // 
            this.lblHitAnimation.AutoSize = true;
            this.lblHitAnimation.Location = new System.Drawing.Point(2, 331);
            this.lblHitAnimation.Name = "lblHitAnimation";
            this.lblHitAnimation.Size = new System.Drawing.Size(54, 13);
            this.lblHitAnimation.TabIndex = 16;
            this.lblHitAnimation.Text = "Hits Anim:";
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
            this.cmbSprite.Location = new System.Drawing.Point(56, 135);
            this.cmbSprite.Name = "cmbSprite";
            this.cmbSprite.Size = new System.Drawing.Size(172, 21);
            this.cmbSprite.TabIndex = 11;
            this.cmbSprite.Text = "None";
            this.cmbSprite.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSprite.SelectedIndexChanged += new System.EventHandler(this.cmbSprite_SelectedIndexChanged);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(53, 119);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(31, 13);
            this.lblIcon.TabIndex = 6;
            this.lblIcon.Text = "Icon:";
            // 
            // picSpell
            // 
            this.picSpell.BackColor = System.Drawing.Color.Black;
            this.picSpell.Location = new System.Drawing.Point(5, 124);
            this.picSpell.Name = "picSpell";
            this.picSpell.Size = new System.Drawing.Size(32, 32);
            this.picSpell.TabIndex = 4;
            this.picSpell.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(2, 98);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbType.DrawDropdownHoverOutline = false;
            this.cmbType.DrawFocusRectangle = false;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Combat Spell",
            "Warp to Map",
            "Warp to Target",
            "Dash",
            "Event"});
            this.cmbType.Location = new System.Drawing.Point(56, 95);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(173, 21);
            this.cmbType.TabIndex = 2;
            this.cmbType.Text = "Combat Spell";
            this.cmbType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 20);
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
            this.txtName.Location = new System.Drawing.Point(56, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpSpellCost
            // 
            this.grpSpellCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpellCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpellCost.Controls.Add(this.chkIgnoreCdr);
            this.grpSpellCost.Controls.Add(this.chkIgnoreGlobalCooldown);
            this.grpSpellCost.Controls.Add(this.btnAddCooldownGroup);
            this.grpSpellCost.Controls.Add(this.cmbCooldownGroup);
            this.grpSpellCost.Controls.Add(this.lblCooldownGroup);
            this.grpSpellCost.Controls.Add(this.nudCooldownDuration);
            this.grpSpellCost.Controls.Add(this.nudCastDuration);
            this.grpSpellCost.Controls.Add(this.nudMpCost);
            this.grpSpellCost.Controls.Add(this.nudHPCost);
            this.grpSpellCost.Controls.Add(this.lblMPCost);
            this.grpSpellCost.Controls.Add(this.lblHPCost);
            this.grpSpellCost.Controls.Add(this.lblCastDuration);
            this.grpSpellCost.Controls.Add(this.lblCooldownDuration);
            this.grpSpellCost.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpellCost.Location = new System.Drawing.Point(242, 201);
            this.grpSpellCost.Name = "grpSpellCost";
            this.grpSpellCost.Size = new System.Drawing.Size(487, 152);
            this.grpSpellCost.TabIndex = 36;
            this.grpSpellCost.TabStop = false;
            this.grpSpellCost.Text = "Spell Cost:";
            // 
            // chkIgnoreCdr
            // 
            this.chkIgnoreCdr.AutoSize = true;
            this.chkIgnoreCdr.Location = new System.Drawing.Point(11, 120);
            this.chkIgnoreCdr.Name = "chkIgnoreCdr";
            this.chkIgnoreCdr.Size = new System.Drawing.Size(164, 17);
            this.chkIgnoreCdr.TabIndex = 57;
            this.chkIgnoreCdr.Text = "Ignore Cooldown Reduction?";
            this.chkIgnoreCdr.CheckedChanged += new System.EventHandler(this.chkIgnoreCdr_CheckedChanged);
            // 
            // chkIgnoreGlobalCooldown
            // 
            this.chkIgnoreGlobalCooldown.AutoSize = true;
            this.chkIgnoreGlobalCooldown.Location = new System.Drawing.Point(12, 97);
            this.chkIgnoreGlobalCooldown.Name = "chkIgnoreGlobalCooldown";
            this.chkIgnoreGlobalCooldown.Size = new System.Drawing.Size(145, 17);
            this.chkIgnoreGlobalCooldown.TabIndex = 56;
            this.chkIgnoreGlobalCooldown.Text = "Ignore Global Cooldown?";
            this.chkIgnoreGlobalCooldown.CheckedChanged += new System.EventHandler(this.chkIgnoreGlobalCooldown_CheckedChanged);
            // 
            // btnAddCooldownGroup
            // 
            this.btnAddCooldownGroup.Location = new System.Drawing.Point(391, 112);
            this.btnAddCooldownGroup.Name = "btnAddCooldownGroup";
            this.btnAddCooldownGroup.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddCooldownGroup.Size = new System.Drawing.Size(18, 21);
            this.btnAddCooldownGroup.TabIndex = 55;
            this.btnAddCooldownGroup.Text = "+";
            this.btnAddCooldownGroup.Click += new System.EventHandler(this.btnAddCooldownGroup_Click);
            // 
            // cmbCooldownGroup
            // 
            this.cmbCooldownGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCooldownGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCooldownGroup.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCooldownGroup.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCooldownGroup.DrawDropdownHoverOutline = false;
            this.cmbCooldownGroup.DrawFocusRectangle = false;
            this.cmbCooldownGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCooldownGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCooldownGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCooldownGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCooldownGroup.FormattingEnabled = true;
            this.cmbCooldownGroup.Location = new System.Drawing.Point(226, 113);
            this.cmbCooldownGroup.Name = "cmbCooldownGroup";
            this.cmbCooldownGroup.Size = new System.Drawing.Size(159, 21);
            this.cmbCooldownGroup.TabIndex = 54;
            this.cmbCooldownGroup.Text = null;
            this.cmbCooldownGroup.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbCooldownGroup.SelectedIndexChanged += new System.EventHandler(this.cmbCooldownGroup_SelectedIndexChanged);
            // 
            // lblCooldownGroup
            // 
            this.lblCooldownGroup.AutoSize = true;
            this.lblCooldownGroup.Location = new System.Drawing.Point(223, 96);
            this.lblCooldownGroup.Name = "lblCooldownGroup";
            this.lblCooldownGroup.Size = new System.Drawing.Size(89, 13);
            this.lblCooldownGroup.TabIndex = 53;
            this.lblCooldownGroup.Text = "Cooldown Group:";
            // 
            // nudCooldownDuration
            // 
            this.nudCooldownDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCooldownDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCooldownDuration.Location = new System.Drawing.Point(225, 71);
            this.nudCooldownDuration.Maximum = new decimal(new int[] {
            -100,
            49,
            0,
            0});
            this.nudCooldownDuration.Name = "nudCooldownDuration";
            this.nudCooldownDuration.Size = new System.Drawing.Size(184, 20);
            this.nudCooldownDuration.TabIndex = 39;
            this.nudCooldownDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCooldownDuration.ValueChanged += new System.EventHandler(this.nudCooldownDuration_ValueChanged);
            // 
            // nudCastDuration
            // 
            this.nudCastDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCastDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCastDuration.Location = new System.Drawing.Point(225, 32);
            this.nudCastDuration.Maximum = new decimal(new int[] {
            -100,
            49,
            0,
            0});
            this.nudCastDuration.Name = "nudCastDuration";
            this.nudCastDuration.Size = new System.Drawing.Size(184, 20);
            this.nudCastDuration.TabIndex = 38;
            this.nudCastDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCastDuration.ValueChanged += new System.EventHandler(this.nudCastDuration_ValueChanged);
            // 
            // nudMpCost
            // 
            this.nudMpCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpCost.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpCost.Location = new System.Drawing.Point(13, 71);
            this.nudMpCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMpCost.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMpCost.Name = "nudMpCost";
            this.nudMpCost.Size = new System.Drawing.Size(184, 20);
            this.nudMpCost.TabIndex = 37;
            this.nudMpCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMpCost.ValueChanged += new System.EventHandler(this.nudMpCost_ValueChanged);
            // 
            // nudHPCost
            // 
            this.nudHPCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHPCost.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHPCost.Location = new System.Drawing.Point(13, 32);
            this.nudHPCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHPCost.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudHPCost.Name = "nudHPCost";
            this.nudHPCost.Size = new System.Drawing.Size(184, 20);
            this.nudHPCost.TabIndex = 36;
            this.nudHPCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHPCost.ValueChanged += new System.EventHandler(this.nudHPCost_ValueChanged);
            // 
            // lblMPCost
            // 
            this.lblMPCost.AutoSize = true;
            this.lblMPCost.Location = new System.Drawing.Point(9, 55);
            this.lblMPCost.Name = "lblMPCost";
            this.lblMPCost.Size = new System.Drawing.Size(61, 13);
            this.lblMPCost.TabIndex = 23;
            this.lblMPCost.Text = "Mana Cost:";
            // 
            // lblHPCost
            // 
            this.lblHPCost.AutoSize = true;
            this.lblHPCost.Location = new System.Drawing.Point(9, 16);
            this.lblHPCost.Name = "lblHPCost";
            this.lblHPCost.Size = new System.Drawing.Size(49, 13);
            this.lblHPCost.TabIndex = 22;
            this.lblHPCost.Text = "HP Cost:";
            // 
            // lblCastDuration
            // 
            this.lblCastDuration.AutoSize = true;
            this.lblCastDuration.Location = new System.Drawing.Point(222, 16);
            this.lblCastDuration.Name = "lblCastDuration";
            this.lblCastDuration.Size = new System.Drawing.Size(79, 13);
            this.lblCastDuration.TabIndex = 7;
            this.lblCastDuration.Text = "Cast Time (ms):";
            // 
            // lblCooldownDuration
            // 
            this.lblCooldownDuration.AutoSize = true;
            this.lblCooldownDuration.Location = new System.Drawing.Point(222, 55);
            this.lblCooldownDuration.Name = "lblCooldownDuration";
            this.lblCooldownDuration.Size = new System.Drawing.Size(79, 13);
            this.lblCooldownDuration.TabIndex = 12;
            this.lblCooldownDuration.Text = "Cooldown (ms):";
            // 
            // grpCasting
            // 
            this.grpCasting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCasting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCasting.Controls.Add(this.cmbCastTargetAnimation);
            this.grpCasting.Controls.Add(this.lblCastTargetAnimation);
            this.grpCasting.Controls.Add(this.btnDynamicRequirements);
            this.grpCasting.Controls.Add(this.lblCannotCast);
            this.grpCasting.Controls.Add(this.txtCannotCast);
            this.grpCasting.Controls.Add(this.cmbCastAnimation);
            this.grpCasting.Controls.Add(this.lblCastAnimation);
            this.grpCasting.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCasting.Location = new System.Drawing.Point(242, 3);
            this.grpCasting.Name = "grpCasting";
            this.grpCasting.Size = new System.Drawing.Size(255, 144);
            this.grpCasting.TabIndex = 18;
            this.grpCasting.TabStop = false;
            this.grpCasting.Text = "Casting";
            // 
            // cmbCastTargetAnimation
            // 
            this.cmbCastTargetAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCastTargetAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCastTargetAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCastTargetAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCastTargetAnimation.DrawDropdownHoverOutline = false;
            this.cmbCastTargetAnimation.DrawFocusRectangle = false;
            this.cmbCastTargetAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCastTargetAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCastTargetAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCastTargetAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCastTargetAnimation.FormattingEnabled = true;
            this.cmbCastTargetAnimation.Location = new System.Drawing.Point(68, 112);
            this.cmbCastTargetAnimation.Name = "cmbCastTargetAnimation";
            this.cmbCastTargetAnimation.Size = new System.Drawing.Size(181, 21);
            this.cmbCastTargetAnimation.TabIndex = 58;
            this.cmbCastTargetAnimation.Text = null;
            this.cmbCastTargetAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbCastTargetAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbCastTargetAnimation_SelectedIndexChanged);
            // 
            // lblCastTargetAnimation
            // 
            this.lblCastTargetAnimation.AutoSize = true;
            this.lblCastTargetAnimation.Location = new System.Drawing.Point(2, 115);
            this.lblCastTargetAnimation.Name = "lblCastTargetAnimation";
            this.lblCastTargetAnimation.Size = new System.Drawing.Size(67, 13);
            this.lblCastTargetAnimation.TabIndex = 57;
            this.lblCastTargetAnimation.Text = "Target Anim:";
            // 
            // btnDynamicRequirements
            // 
            this.btnDynamicRequirements.Location = new System.Drawing.Point(142, 10);
            this.btnDynamicRequirements.Name = "btnDynamicRequirements";
            this.btnDynamicRequirements.Padding = new System.Windows.Forms.Padding(3);
            this.btnDynamicRequirements.Size = new System.Drawing.Size(103, 22);
            this.btnDynamicRequirements.TabIndex = 20;
            this.btnDynamicRequirements.Text = "Edit Requirements";
            this.btnDynamicRequirements.Click += new System.EventHandler(this.btnDynamicRequirements_Click);
            // 
            // lblCannotCast
            // 
            this.lblCannotCast.AutoSize = true;
            this.lblCannotCast.Location = new System.Drawing.Point(4, 20);
            this.lblCannotCast.Name = "lblCannotCast";
            this.lblCannotCast.Size = new System.Drawing.Size(114, 13);
            this.lblCannotCast.TabIndex = 56;
            this.lblCannotCast.Text = "Cannot Cast Message:";
            // 
            // txtCannotCast
            // 
            this.txtCannotCast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtCannotCast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCannotCast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtCannotCast.Location = new System.Drawing.Point(3, 37);
            this.txtCannotCast.Multiline = true;
            this.txtCannotCast.Name = "txtCannotCast";
            this.txtCannotCast.Size = new System.Drawing.Size(246, 41);
            this.txtCannotCast.TabIndex = 55;
            this.txtCannotCast.TextChanged += new System.EventHandler(this.txtCannotCast_TextChanged);
            // 
            // cmbCastAnimation
            // 
            this.cmbCastAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCastAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCastAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCastAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCastAnimation.DrawDropdownHoverOutline = false;
            this.cmbCastAnimation.DrawFocusRectangle = false;
            this.cmbCastAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCastAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCastAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCastAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCastAnimation.FormattingEnabled = true;
            this.cmbCastAnimation.Location = new System.Drawing.Point(68, 88);
            this.cmbCastAnimation.Name = "cmbCastAnimation";
            this.cmbCastAnimation.Size = new System.Drawing.Size(181, 21);
            this.cmbCastAnimation.TabIndex = 20;
            this.cmbCastAnimation.Text = null;
            this.cmbCastAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbCastAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbCastAnimation_SelectedIndexChanged);
            // 
            // lblCastAnimation
            // 
            this.lblCastAnimation.AutoSize = true;
            this.lblCastAnimation.Location = new System.Drawing.Point(2, 91);
            this.lblCastAnimation.Name = "lblCastAnimation";
            this.lblCastAnimation.Size = new System.Drawing.Size(66, 13);
            this.lblCastAnimation.TabIndex = 14;
            this.lblCastAnimation.Text = "Caster Anim:";
            // 
            // grpTargetInfo
            // 
            this.grpTargetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpTargetInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTargetInfo.Controls.Add(this.chkSquareRadius);
            this.grpTargetInfo.Controls.Add(this.chkSquareRange);
            this.grpTargetInfo.Controls.Add(this.nudDuration);
            this.grpTargetInfo.Controls.Add(this.lblDuration);
            this.grpTargetInfo.Controls.Add(this.nudHitRadius);
            this.grpTargetInfo.Controls.Add(this.lblHitRadius);
            this.grpTargetInfo.Controls.Add(this.cmbTargetType);
            this.grpTargetInfo.Controls.Add(this.lblCastRange);
            this.grpTargetInfo.Controls.Add(this.lblTargetType);
            this.grpTargetInfo.Controls.Add(this.nudCastRange);
            this.grpTargetInfo.Controls.Add(this.lblProjectile);
            this.grpTargetInfo.Controls.Add(this.cmbProjectile);
            this.grpTargetInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTargetInfo.Location = new System.Drawing.Point(504, 3);
            this.grpTargetInfo.Name = "grpTargetInfo";
            this.grpTargetInfo.Size = new System.Drawing.Size(225, 192);
            this.grpTargetInfo.TabIndex = 19;
            this.grpTargetInfo.TabStop = false;
            this.grpTargetInfo.Text = "Targetting Info";
            this.grpTargetInfo.Visible = false;
            // 
            // chkSquareRadius
            // 
            this.chkSquareRadius.AutoSize = true;
            this.chkSquareRadius.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSquareRadius.Location = new System.Drawing.Point(116, 101);
            this.chkSquareRadius.Name = "chkSquareRadius";
            this.chkSquareRadius.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSquareRadius.Size = new System.Drawing.Size(102, 17);
            this.chkSquareRadius.TabIndex = 61;
            this.chkSquareRadius.Text = "Square Radius?";
            this.chkSquareRadius.CheckedChanged += new System.EventHandler(this.chkSquareRadius_CheckedChanged);
            // 
            // chkSquareRange
            // 
            this.chkSquareRange.AutoSize = true;
            this.chkSquareRange.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSquareRange.Location = new System.Drawing.Point(116, 58);
            this.chkSquareRange.Name = "chkSquareRange";
            this.chkSquareRange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSquareRange.Size = new System.Drawing.Size(101, 17);
            this.chkSquareRange.TabIndex = 60;
            this.chkSquareRange.Text = "Square Range?";
            this.chkSquareRange.CheckedChanged += new System.EventHandler(this.chkSquareRange_CheckedChanged);
            // 
            // nudDuration
            // 
            this.nudDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDuration.Location = new System.Drawing.Point(9, 159);
            this.nudDuration.Maximum = new decimal(new int[] {
            -100,
            49,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(206, 20);
            this.nudDuration.TabIndex = 38;
            this.nudDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudOnHitDuration_ValueChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(8, 143);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(72, 13);
            this.lblDuration.TabIndex = 37;
            this.lblDuration.Text = "Duration (ms):";
            // 
            // nudHitRadius
            // 
            this.nudHitRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHitRadius.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHitRadius.Location = new System.Drawing.Point(9, 118);
            this.nudHitRadius.Name = "nudHitRadius";
            this.nudHitRadius.Size = new System.Drawing.Size(206, 20);
            this.nudHitRadius.TabIndex = 35;
            this.nudHitRadius.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHitRadius.ValueChanged += new System.EventHandler(this.nudHitRadius_ValueChanged);
            // 
            // lblHitRadius
            // 
            this.lblHitRadius.AutoSize = true;
            this.lblHitRadius.Location = new System.Drawing.Point(6, 102);
            this.lblHitRadius.Name = "lblHitRadius";
            this.lblHitRadius.Size = new System.Drawing.Size(59, 13);
            this.lblHitRadius.TabIndex = 16;
            this.lblHitRadius.Text = "Hit Radius:";
            // 
            // cmbTargetType
            // 
            this.cmbTargetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTargetType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTargetType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTargetType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTargetType.DrawDropdownHoverOutline = false;
            this.cmbTargetType.DrawFocusRectangle = false;
            this.cmbTargetType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTargetType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTargetType.FormattingEnabled = true;
            this.cmbTargetType.Items.AddRange(new object[] {
            "Self",
            "Single Target (includes self)",
            "AOE",
            "Linear (projectile)",
            "On Hit",
            "Trap"});
            this.cmbTargetType.Location = new System.Drawing.Point(9, 32);
            this.cmbTargetType.Name = "cmbTargetType";
            this.cmbTargetType.Size = new System.Drawing.Size(206, 21);
            this.cmbTargetType.TabIndex = 15;
            this.cmbTargetType.Text = "Self";
            this.cmbTargetType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTargetType.SelectedIndexChanged += new System.EventHandler(this.cmbTargetType_SelectedIndexChanged);
            // 
            // lblCastRange
            // 
            this.lblCastRange.AutoSize = true;
            this.lblCastRange.Location = new System.Drawing.Point(6, 60);
            this.lblCastRange.Name = "lblCastRange";
            this.lblCastRange.Size = new System.Drawing.Size(66, 13);
            this.lblCastRange.TabIndex = 13;
            this.lblCastRange.Text = "Cast Range:";
            // 
            // lblTargetType
            // 
            this.lblTargetType.AutoSize = true;
            this.lblTargetType.Location = new System.Drawing.Point(6, 16);
            this.lblTargetType.Name = "lblTargetType";
            this.lblTargetType.Size = new System.Drawing.Size(68, 13);
            this.lblTargetType.TabIndex = 12;
            this.lblTargetType.Text = "Target Type:";
            // 
            // nudCastRange
            // 
            this.nudCastRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCastRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCastRange.Location = new System.Drawing.Point(9, 76);
            this.nudCastRange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCastRange.Name = "nudCastRange";
            this.nudCastRange.Size = new System.Drawing.Size(206, 20);
            this.nudCastRange.TabIndex = 36;
            this.nudCastRange.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCastRange.ValueChanged += new System.EventHandler(this.nudCastRange_ValueChanged);
            // 
            // lblProjectile
            // 
            this.lblProjectile.AutoSize = true;
            this.lblProjectile.Location = new System.Drawing.Point(6, 143);
            this.lblProjectile.Name = "lblProjectile";
            this.lblProjectile.Size = new System.Drawing.Size(80, 13);
            this.lblProjectile.TabIndex = 18;
            this.lblProjectile.Text = "Projectile/Area:";
            // 
            // cmbProjectile
            // 
            this.cmbProjectile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbProjectile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbProjectile.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbProjectile.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbProjectile.DrawDropdownHoverOutline = false;
            this.cmbProjectile.DrawFocusRectangle = false;
            this.cmbProjectile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProjectile.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbProjectile.FormattingEnabled = true;
            this.cmbProjectile.Location = new System.Drawing.Point(9, 159);
            this.cmbProjectile.Name = "cmbProjectile";
            this.cmbProjectile.Size = new System.Drawing.Size(206, 21);
            this.cmbProjectile.TabIndex = 19;
            this.cmbProjectile.Text = null;
            this.cmbProjectile.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbProjectile.Visible = false;
            this.cmbProjectile.SelectedIndexChanged += new System.EventHandler(this.cmbProjectile_SelectedIndexChanged);
            // 
            // grpWarp
            // 
            this.grpWarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpWarp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpWarp.Controls.Add(this.nudWarpY);
            this.grpWarp.Controls.Add(this.nudWarpX);
            this.grpWarp.Controls.Add(this.btnVisualMapSelector);
            this.grpWarp.Controls.Add(this.cmbWarpMap);
            this.grpWarp.Controls.Add(this.cmbDirection);
            this.grpWarp.Controls.Add(this.lblWarpDir);
            this.grpWarp.Controls.Add(this.lblY);
            this.grpWarp.Controls.Add(this.lblX);
            this.grpWarp.Controls.Add(this.lblMap);
            this.grpWarp.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpWarp.Location = new System.Drawing.Point(504, 3);
            this.grpWarp.Name = "grpWarp";
            this.grpWarp.Size = new System.Drawing.Size(225, 192);
            this.grpWarp.TabIndex = 35;
            this.grpWarp.TabStop = false;
            this.grpWarp.Text = "Warp Caster:";
            this.grpWarp.Visible = false;
            // 
            // nudWarpY
            // 
            this.nudWarpY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWarpY.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWarpY.Location = new System.Drawing.Point(30, 91);
            this.nudWarpY.Name = "nudWarpY";
            this.nudWarpY.Size = new System.Drawing.Size(190, 20);
            this.nudWarpY.TabIndex = 35;
            this.nudWarpY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWarpY.ValueChanged += new System.EventHandler(this.nudWarpY_ValueChanged);
            // 
            // nudWarpX
            // 
            this.nudWarpX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWarpX.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWarpX.Location = new System.Drawing.Point(30, 63);
            this.nudWarpX.Name = "nudWarpX";
            this.nudWarpX.Size = new System.Drawing.Size(190, 20);
            this.nudWarpX.TabIndex = 34;
            this.nudWarpX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWarpX.ValueChanged += new System.EventHandler(this.nudWarpX_ValueChanged);
            // 
            // btnVisualMapSelector
            // 
            this.btnVisualMapSelector.Location = new System.Drawing.Point(3, 151);
            this.btnVisualMapSelector.Name = "btnVisualMapSelector";
            this.btnVisualMapSelector.Padding = new System.Windows.Forms.Padding(5);
            this.btnVisualMapSelector.Size = new System.Drawing.Size(220, 23);
            this.btnVisualMapSelector.TabIndex = 33;
            this.btnVisualMapSelector.Text = "Open Visual Interface";
            this.btnVisualMapSelector.Click += new System.EventHandler(this.btnVisualMapSelector_Click);
            // 
            // cmbWarpMap
            // 
            this.cmbWarpMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbWarpMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbWarpMap.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbWarpMap.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbWarpMap.DrawDropdownHoverOutline = false;
            this.cmbWarpMap.DrawFocusRectangle = false;
            this.cmbWarpMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWarpMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarpMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWarpMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbWarpMap.FormattingEnabled = true;
            this.cmbWarpMap.Location = new System.Drawing.Point(3, 34);
            this.cmbWarpMap.Name = "cmbWarpMap";
            this.cmbWarpMap.Size = new System.Drawing.Size(220, 21);
            this.cmbWarpMap.TabIndex = 30;
            this.cmbWarpMap.Text = null;
            this.cmbWarpMap.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbWarpMap.SelectedIndexChanged += new System.EventHandler(this.cmbWarpMap_SelectedIndexChanged);
            // 
            // cmbDirection
            // 
            this.cmbDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDirection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDirection.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDirection.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDirection.DrawDropdownHoverOutline = false;
            this.cmbDirection.DrawFocusRectangle = false;
            this.cmbDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDirection.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Retain Direction",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.cmbDirection.Location = new System.Drawing.Point(30, 122);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(189, 21);
            this.cmbDirection.TabIndex = 32;
            this.cmbDirection.Text = "Retain Direction";
            this.cmbDirection.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // lblWarpDir
            // 
            this.lblWarpDir.AutoSize = true;
            this.lblWarpDir.Location = new System.Drawing.Point(6, 125);
            this.lblWarpDir.Name = "lblWarpDir";
            this.lblWarpDir.Size = new System.Drawing.Size(23, 13);
            this.lblWarpDir.TabIndex = 31;
            this.lblWarpDir.Text = "Dir:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(7, 93);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 29;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(7, 65);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 28;
            this.lblX.Text = "X:";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(6, 18);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(31, 13);
            this.lblMap.TabIndex = 27;
            this.lblMap.Text = "Map:";
            // 
            // grpEvent
            // 
            this.grpEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEvent.Controls.Add(this.cmbEvent);
            this.grpEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEvent.Location = new System.Drawing.Point(242, 150);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Size = new System.Drawing.Size(255, 45);
            this.grpEvent.TabIndex = 40;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Event";
            this.grpEvent.Visible = false;
            // 
            // cmbEvent
            // 
            this.cmbEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEvent.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEvent.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEvent.DrawDropdownHoverOutline = false;
            this.cmbEvent.DrawFocusRectangle = false;
            this.cmbEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(9, 17);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(240, 21);
            this.cmbEvent.TabIndex = 17;
            this.cmbEvent.Text = null;
            this.cmbEvent.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbEvent_SelectedIndexChanged);
            // 
            // grpCombat
            // 
            this.grpCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCombat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCombat.Controls.Add(this.grpDamage);
            this.grpCombat.Controls.Add(this.grpNextSpell);
            this.grpCombat.Controls.Add(this.grpStats);
            this.grpCombat.Controls.Add(this.grpHotDot);
            this.grpCombat.Controls.Add(this.grpEffect);
            this.grpCombat.Controls.Add(this.grpEffectDuration);
            this.grpCombat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCombat.Location = new System.Drawing.Point(3, 359);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(732, 461);
            this.grpCombat.TabIndex = 39;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat Spell";
            this.grpCombat.Visible = false;
            // 
            // grpDamage
            // 
            this.grpDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDamage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDamage.Controls.Add(this.nudManaSteal);
            this.grpDamage.Controls.Add(this.lblManaSteal);
            this.grpDamage.Controls.Add(this.nudHPSteal);
            this.grpDamage.Controls.Add(this.lblHPSteal);
            this.grpDamage.Controls.Add(this.cmbCritEffectSpell);
            this.grpDamage.Controls.Add(this.lblCritEffectSpell);
            this.grpDamage.Controls.Add(this.nudCritMultiplier);
            this.grpDamage.Controls.Add(this.lblCritMultiplier);
            this.grpDamage.Controls.Add(this.nudCritChance);
            this.grpDamage.Controls.Add(this.nudScaling);
            this.grpDamage.Controls.Add(this.nudMPDamage);
            this.grpDamage.Controls.Add(this.nudHPDamage);
            this.grpDamage.Controls.Add(this.cmbScalingStat);
            this.grpDamage.Controls.Add(this.lblScalingStat);
            this.grpDamage.Controls.Add(this.chkFriendly);
            this.grpDamage.Controls.Add(this.lblCritChance);
            this.grpDamage.Controls.Add(this.lblScaling);
            this.grpDamage.Controls.Add(this.cmbDamageType);
            this.grpDamage.Controls.Add(this.lblDamageType);
            this.grpDamage.Controls.Add(this.lblHPDamage);
            this.grpDamage.Controls.Add(this.lblManaDamage);
            this.grpDamage.Controls.Add(this.chkReplaceCritEffectSpell);
            this.grpDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDamage.Location = new System.Drawing.Point(6, 15);
            this.grpDamage.Name = "grpDamage";
            this.grpDamage.Size = new System.Drawing.Size(291, 264);
            this.grpDamage.TabIndex = 49;
            this.grpDamage.TabStop = false;
            this.grpDamage.Text = "Damage";
            // 
            // nudManaSteal
            // 
            this.nudManaSteal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudManaSteal.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudManaSteal.Location = new System.Drawing.Point(142, 71);
            this.nudManaSteal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudManaSteal.Name = "nudManaSteal";
            this.nudManaSteal.Size = new System.Drawing.Size(42, 20);
            this.nudManaSteal.TabIndex = 69;
            this.nudManaSteal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudManaSteal.ValueChanged += new System.EventHandler(this.nudManaSteal_ValueChanged);
            // 
            // lblManaSteal
            // 
            this.lblManaSteal.AutoSize = true;
            this.lblManaSteal.Location = new System.Drawing.Point(92, 73);
            this.lblManaSteal.Name = "lblManaSteal";
            this.lblManaSteal.Size = new System.Drawing.Size(51, 13);
            this.lblManaSteal.TabIndex = 68;
            this.lblManaSteal.Text = "Steal (%):";
            // 
            // nudHPSteal
            // 
            this.nudHPSteal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHPSteal.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHPSteal.Location = new System.Drawing.Point(142, 32);
            this.nudHPSteal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHPSteal.Name = "nudHPSteal";
            this.nudHPSteal.Size = new System.Drawing.Size(42, 20);
            this.nudHPSteal.TabIndex = 67;
            this.nudHPSteal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHPSteal.ValueChanged += new System.EventHandler(this.nudHPSteal_ValueChanged);
            // 
            // lblHPSteal
            // 
            this.lblHPSteal.AutoSize = true;
            this.lblHPSteal.Location = new System.Drawing.Point(92, 34);
            this.lblHPSteal.Name = "lblHPSteal";
            this.lblHPSteal.Size = new System.Drawing.Size(51, 13);
            this.lblHPSteal.TabIndex = 66;
            this.lblHPSteal.Text = "Steal (%):";
            // 
            // cmbCritEffectSpell
            // 
            this.cmbCritEffectSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCritEffectSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCritEffectSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCritEffectSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCritEffectSpell.DrawDropdownHoverOutline = false;
            this.cmbCritEffectSpell.DrawFocusRectangle = false;
            this.cmbCritEffectSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCritEffectSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCritEffectSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCritEffectSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCritEffectSpell.FormattingEnabled = true;
            this.cmbCritEffectSpell.Items.AddRange(new object[] {
            "None"});
            this.cmbCritEffectSpell.Location = new System.Drawing.Point(126, 208);
            this.cmbCritEffectSpell.Name = "cmbCritEffectSpell";
            this.cmbCritEffectSpell.Size = new System.Drawing.Size(160, 21);
            this.cmbCritEffectSpell.TabIndex = 65;
            this.cmbCritEffectSpell.Text = "None";
            this.cmbCritEffectSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbCritEffectSpell.SelectedIndexChanged += new System.EventHandler(this.cmbCritEffectSpell_SelectedIndexChanged);
            // 
            // lblCritEffectSpell
            // 
            this.lblCritEffectSpell.AutoSize = true;
            this.lblCritEffectSpell.Location = new System.Drawing.Point(135, 191);
            this.lblCritEffectSpell.Name = "lblCritEffectSpell";
            this.lblCritEffectSpell.Size = new System.Drawing.Size(82, 13);
            this.lblCritEffectSpell.TabIndex = 64;
            this.lblCritEffectSpell.Text = "Crit Effect Spell:";
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
            this.nudCritMultiplier.Location = new System.Drawing.Point(137, 165);
            this.nudCritMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCritMultiplier.Name = "nudCritMultiplier";
            this.nudCritMultiplier.Size = new System.Drawing.Size(110, 20);
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
            this.lblCritMultiplier.Location = new System.Drawing.Point(134, 148);
            this.lblCritMultiplier.Name = "lblCritMultiplier";
            this.lblCritMultiplier.Size = new System.Drawing.Size(135, 13);
            this.lblCritMultiplier.TabIndex = 62;
            this.lblCritMultiplier.Text = "Crit Multiplier (Default 1.5x):";
            // 
            // nudCritChance
            // 
            this.nudCritChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritChance.Location = new System.Drawing.Point(136, 123);
            this.nudCritChance.Name = "nudCritChance";
            this.nudCritChance.Size = new System.Drawing.Size(110, 20);
            this.nudCritChance.TabIndex = 61;
            this.nudCritChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCritChance.ValueChanged += new System.EventHandler(this.nudCritChance_ValueChanged);
            // 
            // nudScaling
            // 
            this.nudScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudScaling.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudScaling.Location = new System.Drawing.Point(10, 208);
            this.nudScaling.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudScaling.Name = "nudScaling";
            this.nudScaling.Size = new System.Drawing.Size(110, 20);
            this.nudScaling.TabIndex = 60;
            this.nudScaling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudScaling.ValueChanged += new System.EventHandler(this.nudScaling_ValueChanged);
            // 
            // nudMPDamage
            // 
            this.nudMPDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMPDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMPDamage.Location = new System.Drawing.Point(8, 71);
            this.nudMPDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMPDamage.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMPDamage.Name = "nudMPDamage";
            this.nudMPDamage.Size = new System.Drawing.Size(83, 20);
            this.nudMPDamage.TabIndex = 59;
            this.nudMPDamage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMPDamage.ValueChanged += new System.EventHandler(this.nudMPDamage_ValueChanged);
            // 
            // nudHPDamage
            // 
            this.nudHPDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHPDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHPDamage.Location = new System.Drawing.Point(8, 32);
            this.nudHPDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHPDamage.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudHPDamage.Name = "nudHPDamage";
            this.nudHPDamage.Size = new System.Drawing.Size(83, 20);
            this.nudHPDamage.TabIndex = 58;
            this.nudHPDamage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHPDamage.ValueChanged += new System.EventHandler(this.nudHPDamage_ValueChanged);
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
            this.cmbScalingStat.Location = new System.Drawing.Point(11, 165);
            this.cmbScalingStat.Name = "cmbScalingStat";
            this.cmbScalingStat.Size = new System.Drawing.Size(110, 21);
            this.cmbScalingStat.TabIndex = 57;
            this.cmbScalingStat.Text = null;
            this.cmbScalingStat.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbScalingStat.SelectedIndexChanged += new System.EventHandler(this.cmbScalingStat_SelectedIndexChanged);
            // 
            // lblScalingStat
            // 
            this.lblScalingStat.AutoSize = true;
            this.lblScalingStat.Location = new System.Drawing.Point(7, 148);
            this.lblScalingStat.Name = "lblScalingStat";
            this.lblScalingStat.Size = new System.Drawing.Size(67, 13);
            this.lblScalingStat.TabIndex = 56;
            this.lblScalingStat.Text = "Scaling Stat:";
            // 
            // chkFriendly
            // 
            this.chkFriendly.AutoSize = true;
            this.chkFriendly.Location = new System.Drawing.Point(218, 11);
            this.chkFriendly.Name = "chkFriendly";
            this.chkFriendly.Size = new System.Drawing.Size(62, 17);
            this.chkFriendly.TabIndex = 55;
            this.chkFriendly.Text = "Friendly";
            this.chkFriendly.CheckedChanged += new System.EventHandler(this.chkFriendly_CheckedChanged);
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(135, 107);
            this.lblCritChance.Name = "lblCritChance";
            this.lblCritChance.Size = new System.Drawing.Size(82, 13);
            this.lblCritChance.TabIndex = 54;
            this.lblCritChance.Text = "Crit Chance (%):";
            // 
            // lblScaling
            // 
            this.lblScaling.AutoSize = true;
            this.lblScaling.Location = new System.Drawing.Point(8, 192);
            this.lblScaling.Name = "lblScaling";
            this.lblScaling.Size = new System.Drawing.Size(84, 13);
            this.lblScaling.TabIndex = 52;
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
            this.cmbDamageType.Location = new System.Drawing.Point(11, 122);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(110, 21);
            this.cmbDamageType.TabIndex = 50;
            this.cmbDamageType.Text = "Physical";
            this.cmbDamageType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDamageType.SelectedIndexChanged += new System.EventHandler(this.cmbDamageType_SelectedIndexChanged);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(7, 105);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(77, 13);
            this.lblDamageType.TabIndex = 49;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblHPDamage
            // 
            this.lblHPDamage.AutoSize = true;
            this.lblHPDamage.Location = new System.Drawing.Point(6, 16);
            this.lblHPDamage.Name = "lblHPDamage";
            this.lblHPDamage.Size = new System.Drawing.Size(68, 13);
            this.lblHPDamage.TabIndex = 46;
            this.lblHPDamage.Text = "HP Damage:";
            // 
            // lblManaDamage
            // 
            this.lblManaDamage.AutoSize = true;
            this.lblManaDamage.Location = new System.Drawing.Point(6, 56);
            this.lblManaDamage.Name = "lblManaDamage";
            this.lblManaDamage.Size = new System.Drawing.Size(80, 13);
            this.lblManaDamage.TabIndex = 47;
            this.lblManaDamage.Text = "Mana Damage:";
            // 
            // chkReplaceCritEffectSpell
            // 
            this.chkReplaceCritEffectSpell.Location = new System.Drawing.Point(128, 231);
            this.chkReplaceCritEffectSpell.Name = "chkReplaceCritEffectSpell";
            this.chkReplaceCritEffectSpell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkReplaceCritEffectSpell.Size = new System.Drawing.Size(162, 20);
            this.chkReplaceCritEffectSpell.TabIndex = 41;
            this.chkReplaceCritEffectSpell.Text = "Replace initial spell on crit";
            this.chkReplaceCritEffectSpell.CheckedChanged += new System.EventHandler(this.chkReplaceCritEffectSpell_CheckedChanged);
            // 
            // grpNextSpell
            // 
            this.grpNextSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpNextSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpNextSpell.Controls.Add(this.lblNextSpellChance);
            this.grpNextSpell.Controls.Add(this.nudNextSpellChance);
            this.grpNextSpell.Controls.Add(this.chkReUseValues);
            this.grpNextSpell.Controls.Add(this.cmbNextSpell);
            this.grpNextSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpNextSpell.Location = new System.Drawing.Point(6, 285);
            this.grpNextSpell.Name = "grpNextSpell";
            this.grpNextSpell.Size = new System.Drawing.Size(291, 89);
            this.grpNextSpell.TabIndex = 54;
            this.grpNextSpell.TabStop = false;
            this.grpNextSpell.Text = "Next Spell Effect";
            // 
            // lblNextSpellChance
            // 
            this.lblNextSpellChance.AutoSize = true;
            this.lblNextSpellChance.Location = new System.Drawing.Point(7, 57);
            this.lblNextSpellChance.Name = "lblNextSpellChance";
            this.lblNextSpellChance.Size = new System.Drawing.Size(64, 13);
            this.lblNextSpellChance.TabIndex = 73;
            this.lblNextSpellChance.Text = "Chance (%):";
            // 
            // nudNextSpellChance
            // 
            this.nudNextSpellChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudNextSpellChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudNextSpellChance.Location = new System.Drawing.Point(71, 54);
            this.nudNextSpellChance.Name = "nudNextSpellChance";
            this.nudNextSpellChance.Size = new System.Drawing.Size(43, 20);
            this.nudNextSpellChance.TabIndex = 74;
            this.nudNextSpellChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudNextSpellChance.ValueChanged += new System.EventHandler(this.nudNextSpellChance_ValueChanged);
            // 
            // chkReUseValues
            // 
            this.chkReUseValues.Location = new System.Drawing.Point(130, 55);
            this.chkReUseValues.Name = "chkReUseValues";
            this.chkReUseValues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkReUseValues.Size = new System.Drawing.Size(101, 17);
            this.chkReUseValues.TabIndex = 41;
            this.chkReUseValues.Text = "Re-use values";
            this.chkReUseValues.CheckedChanged += new System.EventHandler(this.chkReUseValues_CheckedChanged);
            // 
            // cmbNextSpell
            // 
            this.cmbNextSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbNextSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbNextSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbNextSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbNextSpell.DrawDropdownHoverOutline = false;
            this.cmbNextSpell.DrawFocusRectangle = false;
            this.cmbNextSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNextSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNextSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNextSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbNextSpell.FormattingEnabled = true;
            this.cmbNextSpell.Items.AddRange(new object[] {
            "None"});
            this.cmbNextSpell.Location = new System.Drawing.Point(7, 24);
            this.cmbNextSpell.Name = "cmbNextSpell";
            this.cmbNextSpell.Size = new System.Drawing.Size(278, 21);
            this.cmbNextSpell.TabIndex = 66;
            this.cmbNextSpell.Text = "None";
            this.cmbNextSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbNextSpell.SelectedIndexChanged += new System.EventHandler(this.cmbNextSpell_SelectedIndexChanged);
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpStats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpStats.Controls.Add(this.nudSpdChance);
            this.grpStats.Controls.Add(this.nudMRChance);
            this.grpStats.Controls.Add(this.nudDefChance);
            this.grpStats.Controls.Add(this.nudMagChance);
            this.grpStats.Controls.Add(this.lblStatsChance);
            this.grpStats.Controls.Add(this.nudStrChance);
            this.grpStats.Controls.Add(this.lblPercentage5);
            this.grpStats.Controls.Add(this.lblPercentage4);
            this.grpStats.Controls.Add(this.lblPercentage3);
            this.grpStats.Controls.Add(this.lblPercentage2);
            this.grpStats.Controls.Add(this.lblPercentage1);
            this.grpStats.Controls.Add(this.nudSpdPercentage);
            this.grpStats.Controls.Add(this.nudMRPercentage);
            this.grpStats.Controls.Add(this.nudDefPercentage);
            this.grpStats.Controls.Add(this.nudMagPercentage);
            this.grpStats.Controls.Add(this.nudStrPercentage);
            this.grpStats.Controls.Add(this.lblPlus5);
            this.grpStats.Controls.Add(this.lblPlus4);
            this.grpStats.Controls.Add(this.lblPlus3);
            this.grpStats.Controls.Add(this.lblPlus2);
            this.grpStats.Controls.Add(this.lblPlus1);
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
            this.grpStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpStats.Location = new System.Drawing.Point(494, 15);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(233, 163);
            this.grpStats.TabIndex = 50;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stat Modifiers";
            // 
            // nudSpdChance
            // 
            this.nudSpdChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpdChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpdChance.Location = new System.Drawing.Point(182, 140);
            this.nudSpdChance.Name = "nudSpdChance";
            this.nudSpdChance.Size = new System.Drawing.Size(43, 20);
            this.nudSpdChance.TabIndex = 72;
            this.nudSpdChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpdChance.ValueChanged += new System.EventHandler(this.nudSpdChance_ValueChanged);
            // 
            // nudMRChance
            // 
            this.nudMRChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMRChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMRChance.Location = new System.Drawing.Point(182, 111);
            this.nudMRChance.Name = "nudMRChance";
            this.nudMRChance.Size = new System.Drawing.Size(43, 20);
            this.nudMRChance.TabIndex = 71;
            this.nudMRChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMRChance.ValueChanged += new System.EventHandler(this.nudMRChance_ValueChanged);
            // 
            // nudDefChance
            // 
            this.nudDefChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDefChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDefChance.Location = new System.Drawing.Point(182, 83);
            this.nudDefChance.Name = "nudDefChance";
            this.nudDefChance.Size = new System.Drawing.Size(43, 20);
            this.nudDefChance.TabIndex = 70;
            this.nudDefChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDefChance.ValueChanged += new System.EventHandler(this.nudDefChance_ValueChanged);
            // 
            // nudMagChance
            // 
            this.nudMagChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMagChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMagChance.Location = new System.Drawing.Point(182, 55);
            this.nudMagChance.Name = "nudMagChance";
            this.nudMagChance.Size = new System.Drawing.Size(43, 20);
            this.nudMagChance.TabIndex = 69;
            this.nudMagChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMagChance.ValueChanged += new System.EventHandler(this.nudMagChance_ValueChanged);
            // 
            // lblStatsChance
            // 
            this.lblStatsChance.AutoSize = true;
            this.lblStatsChance.Location = new System.Drawing.Point(168, 11);
            this.lblStatsChance.Name = "lblStatsChance";
            this.lblStatsChance.Size = new System.Drawing.Size(64, 13);
            this.lblStatsChance.TabIndex = 65;
            this.lblStatsChance.Text = "Chance (%):";
            // 
            // nudStrChance
            // 
            this.nudStrChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStrChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStrChance.Location = new System.Drawing.Point(182, 27);
            this.nudStrChance.Name = "nudStrChance";
            this.nudStrChance.Size = new System.Drawing.Size(43, 20);
            this.nudStrChance.TabIndex = 68;
            this.nudStrChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStrChance.ValueChanged += new System.EventHandler(this.nudStrChance_ValueChanged);
            // 
            // lblPercentage5
            // 
            this.lblPercentage5.AutoSize = true;
            this.lblPercentage5.Location = new System.Drawing.Point(157, 142);
            this.lblPercentage5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage5.Name = "lblPercentage5";
            this.lblPercentage5.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage5.TabIndex = 67;
            this.lblPercentage5.Text = "%";
            // 
            // lblPercentage4
            // 
            this.lblPercentage4.AutoSize = true;
            this.lblPercentage4.Location = new System.Drawing.Point(157, 113);
            this.lblPercentage4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage4.Name = "lblPercentage4";
            this.lblPercentage4.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage4.TabIndex = 66;
            this.lblPercentage4.Text = "%";
            // 
            // lblPercentage3
            // 
            this.lblPercentage3.AutoSize = true;
            this.lblPercentage3.Location = new System.Drawing.Point(157, 84);
            this.lblPercentage3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage3.Name = "lblPercentage3";
            this.lblPercentage3.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage3.TabIndex = 65;
            this.lblPercentage3.Text = "%";
            // 
            // lblPercentage2
            // 
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Location = new System.Drawing.Point(157, 56);
            this.lblPercentage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage2.TabIndex = 64;
            this.lblPercentage2.Text = "%";
            // 
            // lblPercentage1
            // 
            this.lblPercentage1.AutoSize = true;
            this.lblPercentage1.Location = new System.Drawing.Point(157, 29);
            this.lblPercentage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage1.Name = "lblPercentage1";
            this.lblPercentage1.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage1.TabIndex = 63;
            this.lblPercentage1.Text = "%";
            // 
            // nudSpdPercentage
            // 
            this.nudSpdPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpdPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpdPercentage.Location = new System.Drawing.Point(114, 140);
            this.nudSpdPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpdPercentage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSpdPercentage.Name = "nudSpdPercentage";
            this.nudSpdPercentage.Size = new System.Drawing.Size(43, 20);
            this.nudSpdPercentage.TabIndex = 62;
            this.nudSpdPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpdPercentage.ValueChanged += new System.EventHandler(this.nudSpdPercentage_ValueChanged);
            // 
            // nudMRPercentage
            // 
            this.nudMRPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMRPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMRPercentage.Location = new System.Drawing.Point(114, 111);
            this.nudMRPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMRPercentage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMRPercentage.Name = "nudMRPercentage";
            this.nudMRPercentage.Size = new System.Drawing.Size(43, 20);
            this.nudMRPercentage.TabIndex = 61;
            this.nudMRPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMRPercentage.ValueChanged += new System.EventHandler(this.nudMRPercentage_ValueChanged);
            // 
            // nudDefPercentage
            // 
            this.nudDefPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDefPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDefPercentage.Location = new System.Drawing.Point(114, 83);
            this.nudDefPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDefPercentage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudDefPercentage.Name = "nudDefPercentage";
            this.nudDefPercentage.Size = new System.Drawing.Size(43, 20);
            this.nudDefPercentage.TabIndex = 60;
            this.nudDefPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDefPercentage.ValueChanged += new System.EventHandler(this.nudDefPercentage_ValueChanged);
            // 
            // nudMagPercentage
            // 
            this.nudMagPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMagPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMagPercentage.Location = new System.Drawing.Point(114, 55);
            this.nudMagPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMagPercentage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMagPercentage.Name = "nudMagPercentage";
            this.nudMagPercentage.Size = new System.Drawing.Size(43, 20);
            this.nudMagPercentage.TabIndex = 59;
            this.nudMagPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMagPercentage.ValueChanged += new System.EventHandler(this.nudMagPercentage_ValueChanged);
            // 
            // nudStrPercentage
            // 
            this.nudStrPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStrPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStrPercentage.Location = new System.Drawing.Point(114, 27);
            this.nudStrPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStrPercentage.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudStrPercentage.Name = "nudStrPercentage";
            this.nudStrPercentage.Size = new System.Drawing.Size(43, 20);
            this.nudStrPercentage.TabIndex = 58;
            this.nudStrPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStrPercentage.ValueChanged += new System.EventHandler(this.nudStrPercentage_ValueChanged);
            // 
            // lblPlus5
            // 
            this.lblPlus5.AutoSize = true;
            this.lblPlus5.Location = new System.Drawing.Point(101, 142);
            this.lblPlus5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus5.Name = "lblPlus5";
            this.lblPlus5.Size = new System.Drawing.Size(13, 13);
            this.lblPlus5.TabIndex = 57;
            this.lblPlus5.Text = "+";
            // 
            // lblPlus4
            // 
            this.lblPlus4.AutoSize = true;
            this.lblPlus4.Location = new System.Drawing.Point(101, 112);
            this.lblPlus4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus4.Name = "lblPlus4";
            this.lblPlus4.Size = new System.Drawing.Size(13, 13);
            this.lblPlus4.TabIndex = 56;
            this.lblPlus4.Text = "+";
            // 
            // lblPlus3
            // 
            this.lblPlus3.AutoSize = true;
            this.lblPlus3.Location = new System.Drawing.Point(101, 84);
            this.lblPlus3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus3.Name = "lblPlus3";
            this.lblPlus3.Size = new System.Drawing.Size(13, 13);
            this.lblPlus3.TabIndex = 55;
            this.lblPlus3.Text = "+";
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Location = new System.Drawing.Point(101, 56);
            this.lblPlus2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(13, 13);
            this.lblPlus2.TabIndex = 54;
            this.lblPlus2.Text = "+";
            // 
            // lblPlus1
            // 
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Location = new System.Drawing.Point(101, 29);
            this.lblPlus1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.Size = new System.Drawing.Size(13, 13);
            this.lblPlus1.TabIndex = 53;
            this.lblPlus1.Text = "+";
            // 
            // nudSpd
            // 
            this.nudSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpd.Location = new System.Drawing.Point(61, 140);
            this.nudSpd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSpd.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nudSpd.Name = "nudSpd";
            this.nudSpd.Size = new System.Drawing.Size(40, 20);
            this.nudSpd.TabIndex = 52;
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
            this.nudMR.Location = new System.Drawing.Point(61, 111);
            this.nudMR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMR.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nudMR.Name = "nudMR";
            this.nudMR.Size = new System.Drawing.Size(40, 20);
            this.nudMR.TabIndex = 51;
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
            this.nudDef.Location = new System.Drawing.Point(61, 83);
            this.nudDef.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDef.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nudDef.Name = "nudDef";
            this.nudDef.Size = new System.Drawing.Size(40, 20);
            this.nudDef.TabIndex = 50;
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
            this.nudMag.Location = new System.Drawing.Point(61, 55);
            this.nudMag.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMag.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nudMag.Name = "nudMag";
            this.nudMag.Size = new System.Drawing.Size(40, 20);
            this.nudMag.TabIndex = 49;
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
            this.nudStr.Location = new System.Drawing.Point(61, 27);
            this.nudStr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStr.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(40, 20);
            this.nudStr.TabIndex = 48;
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
            this.lblSpd.Location = new System.Drawing.Point(1, 144);
            this.lblSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(41, 13);
            this.lblSpd.TabIndex = 47;
            this.lblSpd.Text = "Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(2, 115);
            this.lblMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(61, 13);
            this.lblMR.TabIndex = 46;
            this.lblMR.Text = "Mag. resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(1, 87);
            this.lblDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(37, 13);
            this.lblDef.TabIndex = 45;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(2, 59);
            this.lblMag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(39, 13);
            this.lblMag.TabIndex = 44;
            this.lblMag.Text = "Magic:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(1, 31);
            this.lblStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(50, 13);
            this.lblStr.TabIndex = 43;
            this.lblStr.Text = "Strength:";
            // 
            // grpHotDot
            // 
            this.grpHotDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpHotDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpHotDot.Controls.Add(this.nudTick);
            this.grpHotDot.Controls.Add(this.chkHOTDOT);
            this.grpHotDot.Controls.Add(this.lblTick);
            this.grpHotDot.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpHotDot.Location = new System.Drawing.Point(303, 87);
            this.grpHotDot.Name = "grpHotDot";
            this.grpHotDot.Size = new System.Drawing.Size(188, 91);
            this.grpHotDot.TabIndex = 53;
            this.grpHotDot.TabStop = false;
            this.grpHotDot.Text = "Heal/Damage Over Time";
            // 
            // nudTick
            // 
            this.nudTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudTick.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudTick.Location = new System.Drawing.Point(99, 40);
            this.nudTick.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudTick.Name = "nudTick";
            this.nudTick.Size = new System.Drawing.Size(80, 20);
            this.nudTick.TabIndex = 40;
            this.nudTick.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTick.ValueChanged += new System.EventHandler(this.nudTick_ValueChanged);
            // 
            // chkHOTDOT
            // 
            this.chkHOTDOT.Location = new System.Drawing.Point(5, 19);
            this.chkHOTDOT.Name = "chkHOTDOT";
            this.chkHOTDOT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHOTDOT.Size = new System.Drawing.Size(86, 24);
            this.chkHOTDOT.TabIndex = 22;
            this.chkHOTDOT.Text = "HOT/DOT?";
            this.chkHOTDOT.CheckedChanged += new System.EventHandler(this.chkHOTDOT_CheckedChanged);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(100, 24);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(53, 13);
            this.lblTick.TabIndex = 38;
            this.lblTick.Text = "Tick (ms):";
            // 
            // grpEffect
            // 
            this.grpEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEffect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEffect.Controls.Add(this.nudEffectChance);
            this.grpEffect.Controls.Add(this.lblEffectChance);
            this.grpEffect.Controls.Add(this.lblEffect);
            this.grpEffect.Controls.Add(this.cmbExtraEffect);
            this.grpEffect.Controls.Add(this.picSprite);
            this.grpEffect.Controls.Add(this.cmbTransform);
            this.grpEffect.Controls.Add(this.lblSprite);
            this.grpEffect.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEffect.Location = new System.Drawing.Point(303, 184);
            this.grpEffect.Name = "grpEffect";
            this.grpEffect.Size = new System.Drawing.Size(423, 190);
            this.grpEffect.TabIndex = 52;
            this.grpEffect.TabStop = false;
            this.grpEffect.Text = "Effect";
            // 
            // nudEffectChance
            // 
            this.nudEffectChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudEffectChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudEffectChance.Location = new System.Drawing.Point(75, 64);
            this.nudEffectChance.Name = "nudEffectChance";
            this.nudEffectChance.Size = new System.Drawing.Size(51, 20);
            this.nudEffectChance.TabIndex = 64;
            this.nudEffectChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudEffectChance.ValueChanged += new System.EventHandler(this.nudEffectChance_ValueChanged);
            // 
            // lblEffectChance
            // 
            this.lblEffectChance.AutoSize = true;
            this.lblEffectChance.Location = new System.Drawing.Point(5, 66);
            this.lblEffectChance.Name = "lblEffectChance";
            this.lblEffectChance.Size = new System.Drawing.Size(64, 13);
            this.lblEffectChance.TabIndex = 64;
            this.lblEffectChance.Text = "Chance (%):";
            // 
            // lblEffect
            // 
            this.lblEffect.AutoSize = true;
            this.lblEffect.Location = new System.Drawing.Point(4, 19);
            this.lblEffect.Name = "lblEffect";
            this.lblEffect.Size = new System.Drawing.Size(65, 13);
            this.lblEffect.TabIndex = 35;
            this.lblEffect.Text = "Extra Effect:";
            // 
            // cmbExtraEffect
            // 
            this.cmbExtraEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbExtraEffect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbExtraEffect.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbExtraEffect.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbExtraEffect.DrawDropdownHoverOutline = false;
            this.cmbExtraEffect.DrawFocusRectangle = false;
            this.cmbExtraEffect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExtraEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtraEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExtraEffect.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbExtraEffect.FormattingEnabled = true;
            this.cmbExtraEffect.Items.AddRange(new object[] {
            "None",
            "Silence",
            "Stun",
            "Snare",
            "Blind",
            "Stealth",
            "Transform",
            "Cleanse",
            "Invulnerable",
            "Shield",
            "Sleep",
            "On Hit",
            "Taunt"});
            this.cmbExtraEffect.Location = new System.Drawing.Point(5, 35);
            this.cmbExtraEffect.Name = "cmbExtraEffect";
            this.cmbExtraEffect.Size = new System.Drawing.Size(174, 21);
            this.cmbExtraEffect.TabIndex = 36;
            this.cmbExtraEffect.Text = "None";
            this.cmbExtraEffect.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbExtraEffect.SelectedIndexChanged += new System.EventHandler(this.cmbExtraEffect_SelectedIndexChanged);
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.Black;
            this.picSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSprite.Location = new System.Drawing.Point(190, 58);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(225, 120);
            this.picSprite.TabIndex = 43;
            this.picSprite.TabStop = false;
            // 
            // cmbTransform
            // 
            this.cmbTransform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTransform.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTransform.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTransform.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTransform.DrawDropdownHoverOutline = false;
            this.cmbTransform.DrawFocusRectangle = false;
            this.cmbTransform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransform.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTransform.FormattingEnabled = true;
            this.cmbTransform.Items.AddRange(new object[] {
            "None"});
            this.cmbTransform.Location = new System.Drawing.Point(234, 32);
            this.cmbTransform.Name = "cmbTransform";
            this.cmbTransform.Size = new System.Drawing.Size(179, 21);
            this.cmbTransform.TabIndex = 44;
            this.cmbTransform.Text = "None";
            this.cmbTransform.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTransform.SelectedIndexChanged += new System.EventHandler(this.cmbTransform_SelectedIndexChanged);
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(233, 16);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(37, 13);
            this.lblSprite.TabIndex = 40;
            this.lblSprite.Text = "Sprite:";
            // 
            // grpEffectDuration
            // 
            this.grpEffectDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEffectDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEffectDuration.Controls.Add(this.nudBuffDuration);
            this.grpEffectDuration.Controls.Add(this.lblBuffDuration);
            this.grpEffectDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEffectDuration.Location = new System.Drawing.Point(301, 15);
            this.grpEffectDuration.Name = "grpEffectDuration";
            this.grpEffectDuration.Size = new System.Drawing.Size(188, 66);
            this.grpEffectDuration.TabIndex = 51;
            this.grpEffectDuration.TabStop = false;
            this.grpEffectDuration.Text = "Stat Boost/Effect Duration";
            // 
            // nudBuffDuration
            // 
            this.nudBuffDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBuffDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBuffDuration.Location = new System.Drawing.Point(80, 30);
            this.nudBuffDuration.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudBuffDuration.Name = "nudBuffDuration";
            this.nudBuffDuration.Size = new System.Drawing.Size(101, 20);
            this.nudBuffDuration.TabIndex = 39;
            this.nudBuffDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudBuffDuration.ValueChanged += new System.EventHandler(this.nudBuffDuration_ValueChanged);
            // 
            // lblBuffDuration
            // 
            this.lblBuffDuration.AutoSize = true;
            this.lblBuffDuration.Location = new System.Drawing.Point(6, 32);
            this.lblBuffDuration.Name = "lblBuffDuration";
            this.lblBuffDuration.Size = new System.Drawing.Size(72, 13);
            this.lblBuffDuration.TabIndex = 33;
            this.lblBuffDuration.Text = "Duration (ms):";
            // 
            // grpDash
            // 
            this.grpDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDash.Controls.Add(this.grpDashCollisions);
            this.grpDash.Controls.Add(this.lblRange);
            this.grpDash.Controls.Add(this.scrlRange);
            this.grpDash.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDash.Location = new System.Drawing.Point(504, 3);
            this.grpDash.Name = "grpDash";
            this.grpDash.Size = new System.Drawing.Size(200, 181);
            this.grpDash.TabIndex = 38;
            this.grpDash.TabStop = false;
            this.grpDash.Text = "Dash";
            this.grpDash.Visible = false;
            // 
            // grpDashCollisions
            // 
            this.grpDashCollisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDashCollisions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDashCollisions.Controls.Add(this.chkIgnoreInactiveResources);
            this.grpDashCollisions.Controls.Add(this.chkIgnoreZDimensionBlocks);
            this.grpDashCollisions.Controls.Add(this.chkIgnoreMapBlocks);
            this.grpDashCollisions.Controls.Add(this.chkIgnoreActiveResources);
            this.grpDashCollisions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDashCollisions.Location = new System.Drawing.Point(12, 62);
            this.grpDashCollisions.Name = "grpDashCollisions";
            this.grpDashCollisions.Size = new System.Drawing.Size(180, 106);
            this.grpDashCollisions.TabIndex = 41;
            this.grpDashCollisions.TabStop = false;
            this.grpDashCollisions.Text = "Ignore Collision:";
            // 
            // chkIgnoreInactiveResources
            // 
            this.chkIgnoreInactiveResources.AutoSize = true;
            this.chkIgnoreInactiveResources.Location = new System.Drawing.Point(6, 62);
            this.chkIgnoreInactiveResources.Name = "chkIgnoreInactiveResources";
            this.chkIgnoreInactiveResources.Size = new System.Drawing.Size(118, 17);
            this.chkIgnoreInactiveResources.TabIndex = 38;
            this.chkIgnoreInactiveResources.Text = "Inactive Resources";
            this.chkIgnoreInactiveResources.CheckedChanged += new System.EventHandler(this.chkIgnoreInactiveResources_CheckedChanged);
            // 
            // chkIgnoreZDimensionBlocks
            // 
            this.chkIgnoreZDimensionBlocks.AutoSize = true;
            this.chkIgnoreZDimensionBlocks.Location = new System.Drawing.Point(6, 85);
            this.chkIgnoreZDimensionBlocks.Name = "chkIgnoreZDimensionBlocks";
            this.chkIgnoreZDimensionBlocks.Size = new System.Drawing.Size(120, 17);
            this.chkIgnoreZDimensionBlocks.TabIndex = 37;
            this.chkIgnoreZDimensionBlocks.Text = "Z-Dimension Blocks";
            this.chkIgnoreZDimensionBlocks.CheckedChanged += new System.EventHandler(this.chkIgnoreZDimensionBlocks_CheckedChanged);
            // 
            // chkIgnoreMapBlocks
            // 
            this.chkIgnoreMapBlocks.AutoSize = true;
            this.chkIgnoreMapBlocks.Location = new System.Drawing.Point(6, 16);
            this.chkIgnoreMapBlocks.Name = "chkIgnoreMapBlocks";
            this.chkIgnoreMapBlocks.Size = new System.Drawing.Size(82, 17);
            this.chkIgnoreMapBlocks.TabIndex = 33;
            this.chkIgnoreMapBlocks.Text = "Map Blocks";
            this.chkIgnoreMapBlocks.CheckedChanged += new System.EventHandler(this.chkIgnoreMapBlocks_CheckedChanged);
            // 
            // chkIgnoreActiveResources
            // 
            this.chkIgnoreActiveResources.AutoSize = true;
            this.chkIgnoreActiveResources.Location = new System.Drawing.Point(6, 39);
            this.chkIgnoreActiveResources.Name = "chkIgnoreActiveResources";
            this.chkIgnoreActiveResources.Size = new System.Drawing.Size(110, 17);
            this.chkIgnoreActiveResources.TabIndex = 36;
            this.chkIgnoreActiveResources.Text = "Active Resources";
            this.chkIgnoreActiveResources.CheckedChanged += new System.EventHandler(this.chkIgnoreActiveResources_CheckedChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(11, 25);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(51, 13);
            this.lblRange.TabIndex = 40;
            this.lblRange.Text = "Range: 0";
            // 
            // scrlRange
            // 
            this.scrlRange.Location = new System.Drawing.Point(14, 38);
            this.scrlRange.Maximum = 10;
            this.scrlRange.Name = "scrlRange";
            this.scrlRange.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlRange.Size = new System.Drawing.Size(168, 18);
            this.scrlRange.TabIndex = 39;
            this.scrlRange.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlRange_Scroll);
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
            this.toolStrip.Size = new System.Drawing.Size(984, 25);
            this.toolStrip.TabIndex = 51;
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(486, 726);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 726);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpSpells
            // 
            this.grpSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpells.Controls.Add(this.btnClearSearch);
            this.grpSpells.Controls.Add(this.txtSearch);
            this.grpSpells.Controls.Add(this.lstGameObjects);
            this.grpSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpells.Location = new System.Drawing.Point(12, 40);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Size = new System.Drawing.Size(203, 673);
            this.grpSpells.TabIndex = 16;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(179, 17);
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
            this.txtSearch.Location = new System.Drawing.Point(6, 17);
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
            this.lstGameObjects.Location = new System.Drawing.Point(6, 43);
            this.lstGameObjects.Name = "lstGameObjects";
            this.lstGameObjects.SelectedImageIndex = 0;
            this.lstGameObjects.Size = new System.Drawing.Size(191, 624);
            this.lstGameObjects.TabIndex = 32;
            // 
            // FrmSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.grpSpells);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSpell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spell Editor                       ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSpell_FormClosed);
            this.Load += new System.EventHandler(this.frmSpell_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.pnlContainer.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpell)).EndInit();
            this.grpSpellCost.ResumeLayout(false);
            this.grpSpellCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCooldownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCastDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPCost)).EndInit();
            this.grpCasting.ResumeLayout(false);
            this.grpCasting.PerformLayout();
            this.grpTargetInfo.ResumeLayout(false);
            this.grpTargetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCastRange)).EndInit();
            this.grpWarp.ResumeLayout(false);
            this.grpWarp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarpX)).EndInit();
            this.grpEvent.ResumeLayout(false);
            this.grpCombat.ResumeLayout(false);
            this.grpDamage.ResumeLayout(false);
            this.grpDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudManaSteal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPSteal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMPDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPDamage)).EndInit();
            this.grpNextSpell.ResumeLayout(false);
            this.grpNextSpell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextSpellChance)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            this.grpHotDot.ResumeLayout(false);
            this.grpHotDot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTick)).EndInit();
            this.grpEffect.ResumeLayout(false);
            this.grpEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEffectChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            this.grpEffectDuration.ResumeLayout(false);
            this.grpEffectDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuffDuration)).EndInit();
            this.grpDash.ResumeLayout(false);
            this.grpDash.PerformLayout();
            this.grpDashCollisions.ResumeLayout(false);
            this.grpDashCollisions.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpSpells;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblCooldownDuration;
        private DarkComboBox cmbSprite;
        private System.Windows.Forms.Label lblCastDuration;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox picSpell;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkGroupBox grpCasting;
        private System.Windows.Forms.Label lblHitAnimation;
        private System.Windows.Forms.Label lblCastAnimation;
        private System.Windows.Forms.Label lblType;
        private DarkComboBox cmbType;
        private DarkGroupBox grpTargetInfo;
        private System.Windows.Forms.Label lblHitRadius;
        private DarkComboBox cmbTargetType;
        private System.Windows.Forms.Label lblCastRange;
        private System.Windows.Forms.Label lblTargetType;
        private DarkGroupBox grpWarp;
        private DarkGroupBox grpSpellCost;
        private System.Windows.Forms.Label lblMPCost;
        private System.Windows.Forms.Label lblHPCost;
        private System.Windows.Forms.Label lblDesc;
        private DarkTextBox txtDesc;
        private DarkGroupBox grpDash;
        private System.Windows.Forms.Label lblRange;
        private DarkScrollBar scrlRange;
        private System.Windows.Forms.Label lblProjectile;
        private DarkGroupBox grpCombat;
        private DarkComboBox cmbExtraEffect;
        private System.Windows.Forms.Label lblEffect;
        private System.Windows.Forms.Label lblBuffDuration;
        private DarkCheckBox chkHOTDOT;
        private System.Windows.Forms.Label lblTick;
        private DarkGroupBox grpDashCollisions;
        private DarkCheckBox chkIgnoreInactiveResources;
        private DarkCheckBox chkIgnoreZDimensionBlocks;
        private DarkCheckBox chkIgnoreMapBlocks;
        private DarkCheckBox chkIgnoreActiveResources;
        private DarkComboBox cmbTransform;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.Label lblSprite;
        private DarkGroupBox grpEvent;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkUI.Controls.DarkGroupBox grpStats;
        private DarkUI.Controls.DarkGroupBox grpDamage;
        private System.Windows.Forms.Label lblHPDamage;
        private System.Windows.Forms.Label lblManaDamage;
        private System.Windows.Forms.Label lblScaling;
        private DarkComboBox cmbDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private DarkUI.Controls.DarkGroupBox grpHotDot;
        private DarkUI.Controls.DarkGroupBox grpEffect;
        private DarkUI.Controls.DarkGroupBox grpEffectDuration;
        private System.Windows.Forms.Label lblCritChance;
        private DarkUI.Controls.DarkCheckBox chkFriendly;
        private DarkComboBox cmbScalingStat;
        private System.Windows.Forms.Label lblScalingStat;
        private DarkButton btnDynamicRequirements;
        private DarkComboBox cmbHitAnimation;
        private DarkComboBox cmbCastAnimation;
        private DarkComboBox cmbProjectile;
        private DarkComboBox cmbEvent;
        private DarkNumericUpDown nudWarpY;
        private DarkNumericUpDown nudWarpX;
        private DarkButton btnVisualMapSelector;
        private DarkComboBox cmbWarpMap;
        private DarkComboBox cmbDirection;
        private System.Windows.Forms.Label lblWarpDir;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMap;
        private DarkNumericUpDown nudCooldownDuration;
        private DarkNumericUpDown nudCastDuration;
        private DarkNumericUpDown nudMpCost;
        private DarkNumericUpDown nudHPCost;
        private DarkNumericUpDown nudHitRadius;
        private DarkNumericUpDown nudCritChance;
        private DarkNumericUpDown nudScaling;
        private DarkNumericUpDown nudMPDamage;
        private DarkNumericUpDown nudHPDamage;
        private DarkNumericUpDown nudTick;
        private DarkNumericUpDown nudBuffDuration;
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
        private DarkNumericUpDown nudCastRange;
        private DarkNumericUpDown nudCritMultiplier;
        private System.Windows.Forms.Label lblCritMultiplier;
        private DarkNumericUpDown nudDuration;
        private System.Windows.Forms.Label lblDuration;
        private DarkCheckBox chkBound;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label lblPercentage5;
        private System.Windows.Forms.Label lblPercentage4;
        private System.Windows.Forms.Label lblPercentage3;
        private System.Windows.Forms.Label lblPercentage2;
        private System.Windows.Forms.Label lblPercentage1;
        private DarkNumericUpDown nudSpdPercentage;
        private DarkNumericUpDown nudMRPercentage;
        private DarkNumericUpDown nudDefPercentage;
        private DarkNumericUpDown nudMagPercentage;
        private DarkNumericUpDown nudStrPercentage;
        private System.Windows.Forms.Label lblPlus5;
        private System.Windows.Forms.Label lblPlus4;
        private System.Windows.Forms.Label lblPlus3;
        private System.Windows.Forms.Label lblPlus2;
        private System.Windows.Forms.Label lblPlus1;
        private DarkButton btnAddCooldownGroup;
        private DarkComboBox cmbCooldownGroup;
        private System.Windows.Forms.Label lblCooldownGroup;
        private DarkCheckBox chkIgnoreGlobalCooldown;
        private DarkCheckBox chkIgnoreCdr;
        private Controls.GameObjectList lstGameObjects;
        private System.Windows.Forms.Label lblCannotCast;
        private DarkTextBox txtCannotCast;
        private DarkNumericUpDown nudEffectChance;
        private System.Windows.Forms.Label lblEffectChance;
        private DarkCheckBox chkSquareRadius;
        private DarkCheckBox chkSquareRange;
        private DarkCheckBox chkReplaceCritEffectSpell;
        private DarkComboBox cmbCritEffectSpell;
        private System.Windows.Forms.Label lblCritEffectSpell;
        private DarkGroupBox grpNextSpell;
        private DarkCheckBox chkReUseValues;
        private DarkComboBox cmbNextSpell;
        private DarkNumericUpDown nudHPSteal;
        private System.Windows.Forms.Label lblHPSteal;
        private DarkNumericUpDown nudManaSteal;
        private System.Windows.Forms.Label lblManaSteal;
        private System.Windows.Forms.Label lblStatsChance;
        private DarkNumericUpDown nudStrChance;
        private DarkNumericUpDown nudSpdChance;
        private DarkNumericUpDown nudMRChance;
        private DarkNumericUpDown nudDefChance;
        private DarkNumericUpDown nudMagChance;
        private System.Windows.Forms.Label lblEditorName;
        private DarkTextBox txtEditorName;
        public System.Windows.Forms.ToolStripButton toolStripItemRelations;
        private System.Windows.Forms.Label lblNextSpellChance;
        private DarkNumericUpDown nudNextSpellChance;
        private System.Windows.Forms.Label lblElementalType;
        private DarkComboBox cmbElementalType;
        private DarkComboBox cmbCastTargetAnimation;
        private System.Windows.Forms.Label lblCastTargetAnimation;
        private DarkComboBox cmbImpactAnimation;
        private System.Windows.Forms.Label lblImpactAnimation;
        private DarkComboBox cmbTilesAnimation;
        private System.Windows.Forms.Label lblTilesAnimation;
    }
}