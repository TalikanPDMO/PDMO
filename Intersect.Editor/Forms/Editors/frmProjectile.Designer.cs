using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmProjectile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectile));
            this.grpProjectiles = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstGameObjects = new Intersect.Editor.Forms.Controls.GameObjectList();
            this.grpSpawns = new DarkUI.Controls.DarkGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSpawns = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpProperties = new DarkUI.Controls.DarkGroupBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.nudKnockback = new DarkUI.Controls.DarkNumericUpDown();
            this.nudRange = new DarkUI.Controls.DarkNumericUpDown();
            this.nudAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpawn = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpeed = new DarkUI.Controls.DarkNumericUpDown();
            this.lblKnockback = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkGrapple = new DarkUI.Controls.DarkCheckBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblSpawn = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.grpAnimations = new DarkUI.Controls.DarkGroupBox();
            this.cmbUniqueAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblUniqueAnimation = new System.Windows.Forms.Label();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.chkRotation = new DarkUI.Controls.DarkCheckBox();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.lstAnimations = new System.Windows.Forms.ListBox();
            this.lblSpawnRange = new System.Windows.Forms.Label();
            this.scrlSpawnRange = new DarkUI.Controls.DarkScrollBar();
            this.grpIgnoreCollisions = new DarkUI.Controls.DarkGroupBox();
            this.chkIgnoreInactiveResources = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreZDimensionBlocks = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreMapBlocks = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreActiveResources = new DarkUI.Controls.DarkCheckBox();
            this.chkLinkedSpawns = new DarkUI.Controls.DarkCheckBox();
            this.chkPierceTarget = new DarkUI.Controls.DarkCheckBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpCollisionOptions = new DarkUI.Controls.DarkGroupBox();
            this.chkStopProjectiles = new DarkUI.Controls.DarkCheckBox();
            this.chkBlockTarget = new DarkUI.Controls.DarkCheckBox();
            this.grpAmmo = new DarkUI.Controls.DarkGroupBox();
            this.nudConsume = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.lblAmmoItem = new System.Windows.Forms.Label();
            this.lblAmmoAmount = new System.Windows.Forms.Label();
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
            this.grpProjectiles.SuspendLayout();
            this.grpSpawns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpawns)).BeginInit();
            this.grpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnockback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.grpAnimations.SuspendLayout();
            this.grpIgnoreCollisions.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpCollisionOptions.SuspendLayout();
            this.grpAmmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsume)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProjectiles
            // 
            this.grpProjectiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpProjectiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpProjectiles.Controls.Add(this.btnClearSearch);
            this.grpProjectiles.Controls.Add(this.txtSearch);
            this.grpProjectiles.Controls.Add(this.lstGameObjects);
            this.grpProjectiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpProjectiles.Location = new System.Drawing.Point(12, 36);
            this.grpProjectiles.Name = "grpProjectiles";
            this.grpProjectiles.Size = new System.Drawing.Size(203, 479);
            this.grpProjectiles.TabIndex = 15;
            this.grpProjectiles.TabStop = false;
            this.grpProjectiles.Text = "Projectiles";
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
            this.lstGameObjects.Size = new System.Drawing.Size(191, 429);
            this.lstGameObjects.TabIndex = 32;
            // 
            // grpSpawns
            // 
            this.grpSpawns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpawns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpawns.Controls.Add(this.label5);
            this.grpSpawns.Controls.Add(this.label4);
            this.grpSpawns.Controls.Add(this.label3);
            this.grpSpawns.Controls.Add(this.label2);
            this.grpSpawns.Controls.Add(this.picSpawns);
            this.grpSpawns.Controls.Add(this.label1);
            this.grpSpawns.Controls.Add(this.label10);
            this.grpSpawns.Controls.Add(this.label9);
            this.grpSpawns.Controls.Add(this.label8);
            this.grpSpawns.Controls.Add(this.label7);
            this.grpSpawns.Controls.Add(this.label6);
            this.grpSpawns.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpawns.Location = new System.Drawing.Point(1, 259);
            this.grpSpawns.Name = "grpSpawns";
            this.grpSpawns.Size = new System.Drawing.Size(186, 192);
            this.grpSpawns.TabIndex = 17;
            this.grpSpawns.TabStop = false;
            this.grpSpawns.Text = "Projectile Spawns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "1";
            // 
            // picSpawns
            // 
            this.picSpawns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpawns.Location = new System.Drawing.Point(15, 19);
            this.picSpawns.Name = "picSpawns";
            this.picSpawns.Size = new System.Drawing.Size(160, 160);
            this.picSpawns.TabIndex = 17;
            this.picSpawns.TabStop = false;
            this.picSpawns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSpawns_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "4";
            // 
            // grpProperties
            // 
            this.grpProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpProperties.Controls.Add(this.btnAddFolder);
            this.grpProperties.Controls.Add(this.lblFolder);
            this.grpProperties.Controls.Add(this.cmbFolder);
            this.grpProperties.Controls.Add(this.cmbSpell);
            this.grpProperties.Controls.Add(this.nudKnockback);
            this.grpProperties.Controls.Add(this.nudRange);
            this.grpProperties.Controls.Add(this.nudAmount);
            this.grpProperties.Controls.Add(this.nudSpawn);
            this.grpProperties.Controls.Add(this.nudSpeed);
            this.grpProperties.Controls.Add(this.lblKnockback);
            this.grpProperties.Controls.Add(this.lblAmount);
            this.grpProperties.Controls.Add(this.chkGrapple);
            this.grpProperties.Controls.Add(this.lblSpell);
            this.grpProperties.Controls.Add(this.lblName);
            this.grpProperties.Controls.Add(this.txtName);
            this.grpProperties.Controls.Add(this.lblRange);
            this.grpProperties.Controls.Add(this.lblSpawn);
            this.grpProperties.Controls.Add(this.lblSpeed);
            this.grpProperties.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpProperties.Location = new System.Drawing.Point(1, 1);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(186, 252);
            this.grpProperties.TabIndex = 18;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Properties";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(157, 43);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 52;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 46);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 51;
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
            this.cmbFolder.Location = new System.Drawing.Point(57, 43);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(94, 21);
            this.cmbFolder.TabIndex = 50;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
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
            this.cmbSpell.Location = new System.Drawing.Point(9, 225);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(167, 21);
            this.cmbSpell.TabIndex = 46;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // nudKnockback
            // 
            this.nudKnockback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudKnockback.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudKnockback.Location = new System.Drawing.Point(107, 175);
            this.nudKnockback.Name = "nudKnockback";
            this.nudKnockback.Size = new System.Drawing.Size(69, 20);
            this.nudKnockback.TabIndex = 45;
            this.nudKnockback.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudKnockback.ValueChanged += new System.EventHandler(this.nudKnockback_ValueChanged);
            // 
            // nudRange
            // 
            this.nudRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRange.Location = new System.Drawing.Point(107, 149);
            this.nudRange.Name = "nudRange";
            this.nudRange.Size = new System.Drawing.Size(69, 20);
            this.nudRange.TabIndex = 44;
            this.nudRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRange.ValueChanged += new System.EventHandler(this.nudRange_ValueChanged);
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAmount.Location = new System.Drawing.Point(107, 123);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(69, 20);
            this.nudAmount.TabIndex = 43;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // nudSpawn
            // 
            this.nudSpawn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpawn.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpawn.Location = new System.Drawing.Point(107, 96);
            this.nudSpawn.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpawn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpawn.Name = "nudSpawn";
            this.nudSpawn.Size = new System.Drawing.Size(69, 20);
            this.nudSpawn.TabIndex = 42;
            this.nudSpawn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpawn.ValueChanged += new System.EventHandler(this.nudSpawnDelay_ValueChanged);
            // 
            // nudSpeed
            // 
            this.nudSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpeed.Location = new System.Drawing.Point(107, 70);
            this.nudSpeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(69, 20);
            this.nudSpeed.TabIndex = 41;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // lblKnockback
            // 
            this.lblKnockback.AutoSize = true;
            this.lblKnockback.Location = new System.Drawing.Point(6, 175);
            this.lblKnockback.Name = "lblKnockback";
            this.lblKnockback.Size = new System.Drawing.Size(65, 13);
            this.lblKnockback.TabIndex = 40;
            this.lblKnockback.Text = "Knockback:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 123);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 38;
            this.lblAmount.Text = "Quantity:";
            // 
            // chkGrapple
            // 
            this.chkGrapple.AutoSize = true;
            this.chkGrapple.Location = new System.Drawing.Point(90, 202);
            this.chkGrapple.Name = "chkGrapple";
            this.chkGrapple.Size = new System.Drawing.Size(90, 17);
            this.chkGrapple.TabIndex = 36;
            this.chkGrapple.Text = "Graple hook?";
            this.chkGrapple.CheckedChanged += new System.EventHandler(this.chkGrapple_CheckedChanged);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(6, 206);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(74, 13);
            this.lblSpell.TabIndex = 24;
            this.lblSpell.Text = "Collision Spell:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(57, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(6, 151);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(42, 13);
            this.lblRange.TabIndex = 7;
            this.lblRange.Text = "Range:";
            // 
            // lblSpawn
            // 
            this.lblSpawn.AutoSize = true;
            this.lblSpawn.Location = new System.Drawing.Point(6, 98);
            this.lblSpawn.Name = "lblSpawn";
            this.lblSpawn.Size = new System.Drawing.Size(95, 13);
            this.lblSpawn.TabIndex = 4;
            this.lblSpawn.Text = "Spawn Delay (ms):";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(6, 72);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Speed (ms):";
            // 
            // grpAnimations
            // 
            this.grpAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAnimations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAnimations.Controls.Add(this.cmbUniqueAnimation);
            this.grpAnimations.Controls.Add(this.lblUniqueAnimation);
            this.grpAnimations.Controls.Add(this.cmbAnimation);
            this.grpAnimations.Controls.Add(this.btnRemove);
            this.grpAnimations.Controls.Add(this.btnAdd);
            this.grpAnimations.Controls.Add(this.chkRotation);
            this.grpAnimations.Controls.Add(this.lblAnimation);
            this.grpAnimations.Controls.Add(this.lstAnimations);
            this.grpAnimations.Controls.Add(this.lblSpawnRange);
            this.grpAnimations.Controls.Add(this.scrlSpawnRange);
            this.grpAnimations.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAnimations.Location = new System.Drawing.Point(193, 1);
            this.grpAnimations.Name = "grpAnimations";
            this.grpAnimations.Size = new System.Drawing.Size(273, 252);
            this.grpAnimations.TabIndex = 27;
            this.grpAnimations.TabStop = false;
            this.grpAnimations.Text = "Animations";
            // 
            // cmbUniqueAnimation
            // 
            this.cmbUniqueAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbUniqueAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbUniqueAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbUniqueAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbUniqueAnimation.DrawDropdownHoverOutline = false;
            this.cmbUniqueAnimation.DrawFocusRectangle = false;
            this.cmbUniqueAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUniqueAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniqueAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUniqueAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbUniqueAnimation.FormattingEnabled = true;
            this.cmbUniqueAnimation.Location = new System.Drawing.Point(147, 143);
            this.cmbUniqueAnimation.Name = "cmbUniqueAnimation";
            this.cmbUniqueAnimation.Size = new System.Drawing.Size(97, 21);
            this.cmbUniqueAnimation.TabIndex = 41;
            this.cmbUniqueAnimation.Text = null;
            this.cmbUniqueAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbUniqueAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbUniqueAnimation_SelectedIndexChanged);
            // 
            // lblUniqueAnimation
            // 
            this.lblUniqueAnimation.AutoSize = true;
            this.lblUniqueAnimation.Location = new System.Drawing.Point(10, 146);
            this.lblUniqueAnimation.Name = "lblUniqueAnimation";
            this.lblUniqueAnimation.Size = new System.Drawing.Size(133, 13);
            this.lblUniqueAnimation.TabIndex = 40;
            this.lblUniqueAnimation.Text = "Unique Animation Position:";
            // 
            // cmbAnimation
            // 
            this.cmbAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAnimation.DrawDropdownHoverOutline = false;
            this.cmbAnimation.DrawFocusRectangle = false;
            this.cmbAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnimation.FormattingEnabled = true;
            this.cmbAnimation.Location = new System.Drawing.Point(71, 116);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(192, 21);
            this.cmbAnimation.TabIndex = 39;
            this.cmbAnimation.Text = null;
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAnimation_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(188, 223);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkRotation
            // 
            this.chkRotation.AutoSize = true;
            this.chkRotation.Location = new System.Drawing.Point(12, 200);
            this.chkRotation.Name = "chkRotation";
            this.chkRotation.Size = new System.Drawing.Size(138, 17);
            this.chkRotation.TabIndex = 36;
            this.chkRotation.Text = "Auto Rotate Animation?";
            this.chkRotation.CheckedChanged += new System.EventHandler(this.chkRotation_CheckedChanged);
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Location = new System.Drawing.Point(9, 119);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(56, 13);
            this.lblAnimation.TabIndex = 31;
            this.lblAnimation.Text = "Animation:";
            // 
            // lstAnimations
            // 
            this.lstAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstAnimations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAnimations.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstAnimations.FormattingEnabled = true;
            this.lstAnimations.Items.AddRange(new object[] {
            "[Spawn Range: 1 - 1] Animation: None"});
            this.lstAnimations.Location = new System.Drawing.Point(12, 17);
            this.lstAnimations.Name = "lstAnimations";
            this.lstAnimations.Size = new System.Drawing.Size(251, 93);
            this.lstAnimations.TabIndex = 29;
            this.lstAnimations.Click += new System.EventHandler(this.lstAnimations_Click);
            // 
            // lblSpawnRange
            // 
            this.lblSpawnRange.AutoSize = true;
            this.lblSpawnRange.Location = new System.Drawing.Point(9, 171);
            this.lblSpawnRange.Name = "lblSpawnRange";
            this.lblSpawnRange.Size = new System.Drawing.Size(102, 13);
            this.lblSpawnRange.TabIndex = 28;
            this.lblSpawnRange.Text = "Spawn Range: 1 - 1";
            // 
            // scrlSpawnRange
            // 
            this.scrlSpawnRange.Location = new System.Drawing.Point(12, 184);
            this.scrlSpawnRange.Minimum = 1;
            this.scrlSpawnRange.Name = "scrlSpawnRange";
            this.scrlSpawnRange.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlSpawnRange.Size = new System.Drawing.Size(251, 17);
            this.scrlSpawnRange.TabIndex = 27;
            this.scrlSpawnRange.Value = 1;
            this.scrlSpawnRange.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlSpawnRange_Scroll);
            // 
            // grpIgnoreCollisions
            // 
            this.grpIgnoreCollisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpIgnoreCollisions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpIgnoreCollisions.Controls.Add(this.chkIgnoreInactiveResources);
            this.grpIgnoreCollisions.Controls.Add(this.chkIgnoreZDimensionBlocks);
            this.grpIgnoreCollisions.Controls.Add(this.chkIgnoreMapBlocks);
            this.grpIgnoreCollisions.Controls.Add(this.chkIgnoreActiveResources);
            this.grpIgnoreCollisions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpIgnoreCollisions.Location = new System.Drawing.Point(192, 259);
            this.grpIgnoreCollisions.Name = "grpIgnoreCollisions";
            this.grpIgnoreCollisions.Size = new System.Drawing.Size(135, 107);
            this.grpIgnoreCollisions.TabIndex = 29;
            this.grpIgnoreCollisions.TabStop = false;
            this.grpIgnoreCollisions.Text = "Ignore Collision:";
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
            // chkLinkedSpawns
            // 
            this.chkLinkedSpawns.AutoSize = true;
            this.chkLinkedSpawns.Location = new System.Drawing.Point(6, 16);
            this.chkLinkedSpawns.Name = "chkLinkedSpawns";
            this.chkLinkedSpawns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkLinkedSpawns.Size = new System.Drawing.Size(105, 17);
            this.chkLinkedSpawns.TabIndex = 40;
            this.chkLinkedSpawns.Text = "Linked Spawns?";
            this.chkLinkedSpawns.CheckedChanged += new System.EventHandler(this.chkLinkedSpawns_CheckedChanged);
            // 
            // chkPierceTarget
            // 
            this.chkPierceTarget.AutoSize = true;
            this.chkPierceTarget.Location = new System.Drawing.Point(6, 39);
            this.chkPierceTarget.Name = "chkPierceTarget";
            this.chkPierceTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPierceTarget.Size = new System.Drawing.Size(96, 17);
            this.chkPierceTarget.TabIndex = 39;
            this.chkPierceTarget.Text = "Pierce Target?";
            this.chkPierceTarget.CheckedChanged += new System.EventHandler(this.chkPierce_CheckedChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.grpCollisionOptions);
            this.pnlContainer.Controls.Add(this.grpAmmo);
            this.pnlContainer.Controls.Add(this.grpIgnoreCollisions);
            this.pnlContainer.Controls.Add(this.grpProperties);
            this.pnlContainer.Controls.Add(this.grpAnimations);
            this.pnlContainer.Controls.Add(this.grpSpawns);
            this.pnlContainer.Location = new System.Drawing.Point(221, 36);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(473, 454);
            this.pnlContainer.TabIndex = 30;
            this.pnlContainer.Visible = false;
            // 
            // grpCollisionOptions
            // 
            this.grpCollisionOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCollisionOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCollisionOptions.Controls.Add(this.chkLinkedSpawns);
            this.grpCollisionOptions.Controls.Add(this.chkStopProjectiles);
            this.grpCollisionOptions.Controls.Add(this.chkBlockTarget);
            this.grpCollisionOptions.Controls.Add(this.chkPierceTarget);
            this.grpCollisionOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCollisionOptions.Location = new System.Drawing.Point(331, 259);
            this.grpCollisionOptions.Name = "grpCollisionOptions";
            this.grpCollisionOptions.Size = new System.Drawing.Size(135, 107);
            this.grpCollisionOptions.TabIndex = 39;
            this.grpCollisionOptions.TabStop = false;
            this.grpCollisionOptions.Text = "Collision Options:";
            // 
            // chkStopProjectiles
            // 
            this.chkStopProjectiles.AutoSize = true;
            this.chkStopProjectiles.Location = new System.Drawing.Point(6, 85);
            this.chkStopProjectiles.Name = "chkStopProjectiles";
            this.chkStopProjectiles.Size = new System.Drawing.Size(105, 17);
            this.chkStopProjectiles.TabIndex = 33;
            this.chkStopProjectiles.Text = "Stop Projectiles?";
            this.chkStopProjectiles.CheckedChanged += new System.EventHandler(this.chkStopProjectiles_CheckedChanged);
            // 
            // chkBlockTarget
            // 
            this.chkBlockTarget.AutoSize = true;
            this.chkBlockTarget.Location = new System.Drawing.Point(6, 62);
            this.chkBlockTarget.Name = "chkBlockTarget";
            this.chkBlockTarget.Size = new System.Drawing.Size(93, 17);
            this.chkBlockTarget.TabIndex = 36;
            this.chkBlockTarget.Text = "Block Target?";
            this.chkBlockTarget.CheckedChanged += new System.EventHandler(this.chkBlockTarget_CheckedChanged);
            // 
            // grpAmmo
            // 
            this.grpAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAmmo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAmmo.Controls.Add(this.nudConsume);
            this.grpAmmo.Controls.Add(this.cmbItem);
            this.grpAmmo.Controls.Add(this.lblAmmoItem);
            this.grpAmmo.Controls.Add(this.lblAmmoAmount);
            this.grpAmmo.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAmmo.Location = new System.Drawing.Point(193, 372);
            this.grpAmmo.Name = "grpAmmo";
            this.grpAmmo.Size = new System.Drawing.Size(272, 79);
            this.grpAmmo.TabIndex = 30;
            this.grpAmmo.TabStop = false;
            this.grpAmmo.Text = "Ammunition Requirements: ";
            // 
            // nudConsume
            // 
            this.nudConsume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudConsume.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudConsume.Location = new System.Drawing.Point(83, 53);
            this.nudConsume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConsume.Name = "nudConsume";
            this.nudConsume.Size = new System.Drawing.Size(180, 20);
            this.nudConsume.TabIndex = 46;
            this.nudConsume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConsume.ValueChanged += new System.EventHandler(this.nudConsume_ValueChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbItem.DrawDropdownHoverOutline = false;
            this.cmbItem.DrawFocusRectangle = false;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(83, 19);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(180, 21);
            this.cmbItem.TabIndex = 26;
            this.cmbItem.Text = null;
            this.cmbItem.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lblAmmoItem
            // 
            this.lblAmmoItem.AutoSize = true;
            this.lblAmmoItem.Location = new System.Drawing.Point(9, 19);
            this.lblAmmoItem.Name = "lblAmmoItem";
            this.lblAmmoItem.Size = new System.Drawing.Size(30, 13);
            this.lblAmmoItem.TabIndex = 25;
            this.lblAmmoItem.Text = "Item:";
            // 
            // lblAmmoAmount
            // 
            this.lblAmmoAmount.AutoSize = true;
            this.lblAmmoAmount.Location = new System.Drawing.Point(9, 53);
            this.lblAmmoAmount.Name = "lblAmmoAmount";
            this.lblAmmoAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmmoAmount.TabIndex = 9;
            this.lblAmmoAmount.Text = "Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 31;
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
            this.toolStrip.Size = new System.Drawing.Size(698, 25);
            this.toolStrip.TabIndex = 46;
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
            // FrmProjectile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(698, 527);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpProjectiles);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmProjectile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projectile Editor";
            this.Load += new System.EventHandler(this.frmProjectile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpProjectiles.ResumeLayout(false);
            this.grpProjectiles.PerformLayout();
            this.grpSpawns.ResumeLayout(false);
            this.grpSpawns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpawns)).EndInit();
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnockback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.grpAnimations.ResumeLayout(false);
            this.grpAnimations.PerformLayout();
            this.grpIgnoreCollisions.ResumeLayout(false);
            this.grpIgnoreCollisions.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.grpCollisionOptions.ResumeLayout(false);
            this.grpCollisionOptions.PerformLayout();
            this.grpAmmo.ResumeLayout(false);
            this.grpAmmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsume)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpProjectiles;
        private DarkGroupBox grpSpawns;
        public System.Windows.Forms.PictureBox picSpawns;
        private DarkGroupBox grpProperties;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblSpawn;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private System.Windows.Forms.Label lblSpell;
        private DarkCheckBox chkGrapple;
        private DarkGroupBox grpAnimations;
        private DarkCheckBox chkRotation;
        private System.Windows.Forms.Label lblAnimation;
        private System.Windows.Forms.ListBox lstAnimations;
        private System.Windows.Forms.Label lblSpawnRange;
        private DarkScrollBar scrlSpawnRange;
        private DarkGroupBox grpIgnoreCollisions;
        private DarkCheckBox chkIgnoreInactiveResources;
        private DarkCheckBox chkIgnoreZDimensionBlocks;
        private DarkCheckBox chkIgnoreMapBlocks;
        private DarkCheckBox chkIgnoreActiveResources;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private System.Windows.Forms.Label lblKnockback;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkGroupBox grpAmmo;
        private System.Windows.Forms.Label lblAmmoAmount;
        private DarkComboBox cmbItem;
        private System.Windows.Forms.Label lblAmmoItem;
        private DarkComboBox cmbAnimation;
        private DarkComboBox cmbSpell;
        private DarkNumericUpDown nudKnockback;
        private DarkNumericUpDown nudRange;
        private DarkNumericUpDown nudAmount;
        private DarkNumericUpDown nudSpawn;
        private DarkNumericUpDown nudSpeed;
        private DarkNumericUpDown nudConsume;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DarkCheckBox chkPierceTarget;
        private Controls.GameObjectList lstGameObjects;
        private DarkComboBox cmbUniqueAnimation;
        private System.Windows.Forms.Label lblUniqueAnimation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DarkCheckBox chkLinkedSpawns;
        public System.Windows.Forms.ToolStripButton toolStripItemRelations;
        private DarkGroupBox grpCollisionOptions;
        private DarkCheckBox chkStopProjectiles;
        private DarkCheckBox chkBlockTarget;
    }
}