using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmMapRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapRegion));
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpCrafts = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstGameObjects = new Intersect.Editor.Forms.Controls.GameObjectList();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpEditorParams = new DarkUI.Controls.DarkGroupBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblEditorColor = new System.Windows.Forms.Label();
            this.lblEditorName = new System.Windows.Forms.Label();
            this.txtEditorName = new DarkUI.Controls.DarkTextBox();
            this.grpEvents = new DarkUI.Controls.DarkGroupBox();
            this.cmbEventExit = new DarkUI.Controls.DarkComboBox();
            this.lblEventExit = new System.Windows.Forms.Label();
            this.cmbEventMove = new DarkUI.Controls.DarkComboBox();
            this.lblEventMove = new System.Windows.Forms.Label();
            this.cmbEventEnter = new DarkUI.Controls.DarkComboBox();
            this.lblEventEnter = new System.Windows.Forms.Label();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.grpRules = new DarkUI.Controls.DarkGroupBox();
            this.nudQuantity = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbIngredient = new DarkUI.Controls.DarkComboBox();
            this.btnDupIngredient = new DarkUI.Controls.DarkButton();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
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
            this.grpCommentary = new DarkUI.Controls.DarkGroupBox();
            this.txtCommentary = new DarkUI.Controls.DarkTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnSelectColor = new DarkUI.Controls.DarkButton();
            this.grpCrafts.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpEditorParams.SuspendLayout();
            this.grpEvents.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.grpCommentary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(330, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(172, 27);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(169, 27);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCrafts
            // 
            this.grpCrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCrafts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCrafts.Controls.Add(this.btnClearSearch);
            this.grpCrafts.Controls.Add(this.txtSearch);
            this.grpCrafts.Controls.Add(this.lstGameObjects);
            this.grpCrafts.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCrafts.Location = new System.Drawing.Point(12, 36);
            this.grpCrafts.Name = "grpCrafts";
            this.grpCrafts.Size = new System.Drawing.Size(203, 382);
            this.grpCrafts.TabIndex = 22;
            this.grpCrafts.TabStop = false;
            this.grpCrafts.Text = "Regions";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(179, 15);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearSearch.Size = new System.Drawing.Size(18, 20);
            this.btnClearSearch.TabIndex = 28;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 27;
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
            this.lstGameObjects.Location = new System.Drawing.Point(6, 40);
            this.lstGameObjects.Name = "lstGameObjects";
            this.lstGameObjects.SelectedImageIndex = 0;
            this.lstGameObjects.Size = new System.Drawing.Size(191, 337);
            this.lstGameObjects.TabIndex = 26;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.grpEditorParams);
            this.pnlContainer.Controls.Add(this.grpEvents);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpRules);
            this.pnlContainer.Location = new System.Drawing.Point(221, 36);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(586, 485);
            this.pnlContainer.TabIndex = 31;
            this.pnlContainer.Visible = false;
            // 
            // grpEditorParams
            // 
            this.grpEditorParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEditorParams.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEditorParams.Controls.Add(this.btnSelectColor);
            this.grpEditorParams.Controls.Add(this.pnlColor);
            this.grpEditorParams.Controls.Add(this.lblEditorColor);
            this.grpEditorParams.Controls.Add(this.lblEditorName);
            this.grpEditorParams.Controls.Add(this.txtEditorName);
            this.grpEditorParams.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEditorParams.Location = new System.Drawing.Point(261, 3);
            this.grpEditorParams.Name = "grpEditorParams";
            this.grpEditorParams.Size = new System.Drawing.Size(318, 45);
            this.grpEditorParams.TabIndex = 52;
            this.grpEditorParams.TabStop = false;
            this.grpEditorParams.Text = "Editor Parameters";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(189, 16);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(31, 23);
            this.pnlColor.TabIndex = 56;
            // 
            // lblEditorColor
            // 
            this.lblEditorColor.AutoSize = true;
            this.lblEditorColor.Location = new System.Drawing.Point(124, 21);
            this.lblEditorColor.Name = "lblEditorColor";
            this.lblEditorColor.Size = new System.Drawing.Size(64, 13);
            this.lblEditorColor.TabIndex = 55;
            this.lblEditorColor.Text = "Editor Color:";
            // 
            // lblEditorName
            // 
            this.lblEditorName.AutoSize = true;
            this.lblEditorName.Location = new System.Drawing.Point(4, 21);
            this.lblEditorName.Name = "lblEditorName";
            this.lblEditorName.Size = new System.Drawing.Size(82, 13);
            this.lblEditorName.TabIndex = 54;
            this.lblEditorName.Text = "Editor Name ID:";
            // 
            // txtEditorName
            // 
            this.txtEditorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtEditorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtEditorName.Location = new System.Drawing.Point(89, 19);
            this.txtEditorName.MaxLength = 2;
            this.txtEditorName.Name = "txtEditorName";
            this.txtEditorName.Size = new System.Drawing.Size(25, 20);
            this.txtEditorName.TabIndex = 53;
            this.txtEditorName.Text = "ID";
            this.txtEditorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEditorName.TextChanged += new System.EventHandler(this.txtEditorName_TextChanged);
            // 
            // grpEvents
            // 
            this.grpEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEvents.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEvents.Controls.Add(this.cmbEventExit);
            this.grpEvents.Controls.Add(this.lblEventExit);
            this.grpEvents.Controls.Add(this.cmbEventMove);
            this.grpEvents.Controls.Add(this.lblEventMove);
            this.grpEvents.Controls.Add(this.cmbEventEnter);
            this.grpEvents.Controls.Add(this.lblEventEnter);
            this.grpEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEvents.Location = new System.Drawing.Point(261, 52);
            this.grpEvents.Name = "grpEvents";
            this.grpEvents.Size = new System.Drawing.Size(318, 104);
            this.grpEvents.TabIndex = 51;
            this.grpEvents.TabStop = false;
            this.grpEvents.Text = "Events";
            // 
            // cmbEventExit
            // 
            this.cmbEventExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEventExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEventExit.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEventExit.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEventExit.DrawDropdownHoverOutline = false;
            this.cmbEventExit.DrawFocusRectangle = false;
            this.cmbEventExit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventExit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEventExit.FormattingEnabled = true;
            this.cmbEventExit.Location = new System.Drawing.Point(64, 73);
            this.cmbEventExit.Name = "cmbEventExit";
            this.cmbEventExit.Size = new System.Drawing.Size(250, 21);
            this.cmbEventExit.TabIndex = 50;
            this.cmbEventExit.Text = null;
            this.cmbEventExit.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEventExit.SelectedIndexChanged += new System.EventHandler(this.cmbEventExit_SelectedIndexChanged);
            // 
            // lblEventExit
            // 
            this.lblEventExit.AutoSize = true;
            this.lblEventExit.Location = new System.Drawing.Point(6, 76);
            this.lblEventExit.Name = "lblEventExit";
            this.lblEventExit.Size = new System.Drawing.Size(44, 13);
            this.lblEventExit.TabIndex = 49;
            this.lblEventExit.Text = "On Exit:";
            // 
            // cmbEventMove
            // 
            this.cmbEventMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEventMove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEventMove.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEventMove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEventMove.DrawDropdownHoverOutline = false;
            this.cmbEventMove.DrawFocusRectangle = false;
            this.cmbEventMove.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventMove.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEventMove.FormattingEnabled = true;
            this.cmbEventMove.Location = new System.Drawing.Point(64, 46);
            this.cmbEventMove.Name = "cmbEventMove";
            this.cmbEventMove.Size = new System.Drawing.Size(250, 21);
            this.cmbEventMove.TabIndex = 48;
            this.cmbEventMove.Text = null;
            this.cmbEventMove.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEventMove.SelectedIndexChanged += new System.EventHandler(this.cmbEventMove_SelectedIndexChanged);
            // 
            // lblEventMove
            // 
            this.lblEventMove.AutoSize = true;
            this.lblEventMove.Location = new System.Drawing.Point(6, 49);
            this.lblEventMove.Name = "lblEventMove";
            this.lblEventMove.Size = new System.Drawing.Size(54, 13);
            this.lblEventMove.TabIndex = 47;
            this.lblEventMove.Text = "On Move:";
            // 
            // cmbEventEnter
            // 
            this.cmbEventEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEventEnter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEventEnter.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEventEnter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEventEnter.DrawDropdownHoverOutline = false;
            this.cmbEventEnter.DrawFocusRectangle = false;
            this.cmbEventEnter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventEnter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventEnter.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEventEnter.FormattingEnabled = true;
            this.cmbEventEnter.Location = new System.Drawing.Point(64, 19);
            this.cmbEventEnter.Name = "cmbEventEnter";
            this.cmbEventEnter.Size = new System.Drawing.Size(250, 21);
            this.cmbEventEnter.TabIndex = 34;
            this.cmbEventEnter.Text = null;
            this.cmbEventEnter.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEventEnter.SelectedIndexChanged += new System.EventHandler(this.cmbEventEnter_SelectedIndexChanged);
            // 
            // lblEventEnter
            // 
            this.lblEventEnter.AutoSize = true;
            this.lblEventEnter.Location = new System.Drawing.Point(6, 22);
            this.lblEventEnter.Name = "lblEventEnter";
            this.lblEventEnter.Size = new System.Drawing.Size(52, 13);
            this.lblEventEnter.TabIndex = 33;
            this.lblEventEnter.Text = "On Enter:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblDesc);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.txtDesc);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(5, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(250, 153);
            this.grpGeneral.TabIndex = 31;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(225, 44);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 46;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 71);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 52;
            this.lblDesc.Text = "Description:";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 48);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 45;
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
            this.cmbFolder.Location = new System.Drawing.Point(49, 44);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(170, 21);
            this.cmbFolder.TabIndex = 44;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(10, 87);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 59);
            this.txtDesc.TabIndex = 51;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
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
            this.txtName.Location = new System.Drawing.Point(49, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpRules
            // 
            this.grpRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpRules.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpRules.Controls.Add(this.nudQuantity);
            this.grpRules.Controls.Add(this.cmbIngredient);
            this.grpRules.Controls.Add(this.btnDupIngredient);
            this.grpRules.Controls.Add(this.btnRemove);
            this.grpRules.Controls.Add(this.btnAdd);
            this.grpRules.Controls.Add(this.lblIngredient);
            this.grpRules.Controls.Add(this.lstIngredients);
            this.grpRules.Controls.Add(this.lblQuantity);
            this.grpRules.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRules.Location = new System.Drawing.Point(5, 215);
            this.grpRules.Name = "grpRules";
            this.grpRules.Size = new System.Drawing.Size(498, 267);
            this.grpRules.TabIndex = 30;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Rules";
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudQuantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudQuantity.Location = new System.Drawing.Point(12, 202);
            this.nudQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(251, 20);
            this.nudQuantity.TabIndex = 41;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbIngredient
            // 
            this.cmbIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbIngredient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbIngredient.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbIngredient.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbIngredient.DrawDropdownHoverOutline = false;
            this.cmbIngredient.DrawFocusRectangle = false;
            this.cmbIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIngredient.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbIngredient.FormattingEnabled = true;
            this.cmbIngredient.Location = new System.Drawing.Point(13, 160);
            this.cmbIngredient.Name = "cmbIngredient";
            this.cmbIngredient.Size = new System.Drawing.Size(250, 21);
            this.cmbIngredient.TabIndex = 40;
            this.cmbIngredient.Text = null;
            this.cmbIngredient.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // btnDupIngredient
            // 
            this.btnDupIngredient.Location = new System.Drawing.Point(188, 236);
            this.btnDupIngredient.Name = "btnDupIngredient";
            this.btnDupIngredient.Padding = new System.Windows.Forms.Padding(5);
            this.btnDupIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnDupIngredient.TabIndex = 39;
            this.btnDupIngredient.Text = "Duplicate";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(97, 236);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(79, 23);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(9, 145);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(30, 13);
            this.lblIngredient.TabIndex = 31;
            this.lblIngredient.Text = "Item:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIngredients.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstIngredients.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Items.AddRange(new object[] {
            "Ingredient: None x1"});
            this.lstIngredients.Location = new System.Drawing.Point(13, 19);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(380, 119);
            this.lstIngredients.TabIndex = 29;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 186);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity:";
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
            this.toolStrip.Size = new System.Drawing.Size(812, 25);
            this.toolStrip.TabIndex = 43;
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
            // grpCommentary
            // 
            this.grpCommentary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCommentary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCommentary.Controls.Add(this.txtCommentary);
            this.grpCommentary.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCommentary.Location = new System.Drawing.Point(12, 424);
            this.grpCommentary.Name = "grpCommentary";
            this.grpCommentary.Size = new System.Drawing.Size(203, 95);
            this.grpCommentary.TabIndex = 71;
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
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(224, 16);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectColor.Size = new System.Drawing.Size(90, 23);
            this.btnSelectColor.TabIndex = 57;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // FrmMapRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.ControlBox = false;
            this.Controls.Add(this.grpCommentary);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCrafts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMapRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapRegion Editor";
            this.Load += new System.EventHandler(this.frmMapRegion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpCrafts.ResumeLayout(false);
            this.grpCrafts.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.grpEditorParams.ResumeLayout(false);
            this.grpEditorParams.PerformLayout();
            this.grpEvents.ResumeLayout(false);
            this.grpEvents.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpRules.ResumeLayout(false);
            this.grpRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grpCommentary.ResumeLayout(false);
            this.grpCommentary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpCrafts;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkGroupBox grpRules;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblQuantity;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkButton btnDupIngredient;
        private DarkComboBox cmbIngredient;
        private DarkNumericUpDown nudQuantity;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private Controls.GameObjectList lstGameObjects;
        public System.Windows.Forms.ToolStripButton toolStripItemRelations;
        private DarkGroupBox grpCommentary;
        private DarkTextBox txtCommentary;
        private DarkGroupBox grpEvents;
        private DarkComboBox cmbEventExit;
        private System.Windows.Forms.Label lblEventExit;
        private DarkComboBox cmbEventMove;
        private System.Windows.Forms.Label lblEventMove;
        private DarkComboBox cmbEventEnter;
        private System.Windows.Forms.Label lblEventEnter;
        private System.Windows.Forms.Label lblDesc;
        private DarkTextBox txtDesc;
        private DarkGroupBox grpEditorParams;
        private System.Windows.Forms.Label lblEditorColor;
        private System.Windows.Forms.Label lblEditorName;
        private DarkTextBox txtEditorName;
        public System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private DarkButton btnSelectColor;
    }
}
