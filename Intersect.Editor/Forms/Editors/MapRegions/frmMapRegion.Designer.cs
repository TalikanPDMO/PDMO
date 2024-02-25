using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.MapRegions
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
            this.grpConditions = new DarkUI.Controls.DarkGroupBox();
            this.lblCannotExit = new System.Windows.Forms.Label();
            this.txtCannotExit = new DarkUI.Controls.DarkTextBox();
            this.lblCannotEnter = new System.Windows.Forms.Label();
            this.txtCannotEnter = new DarkUI.Controls.DarkTextBox();
            this.btnEditExitConditions = new DarkUI.Controls.DarkButton();
            this.btnEditEnterConditions = new DarkUI.Controls.DarkButton();
            this.grpEditorParams = new DarkUI.Controls.DarkGroupBox();
            this.btnSelectColor = new DarkUI.Controls.DarkButton();
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
            this.grpCommands = new DarkUI.Controls.DarkGroupBox();
            this.lblEditCommand = new System.Windows.Forms.Label();
            this.cmbNewCommand = new DarkUI.Controls.DarkComboBox();
            this.btnDuplicate = new DarkUI.Controls.DarkButton();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.lblNewCommand = new System.Windows.Forms.Label();
            this.lstCommands = new System.Windows.Forms.ListBox();
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
            this.grpCrafts.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpConditions.SuspendLayout();
            this.grpEditorParams.SuspendLayout();
            this.grpEvents.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpCommands.SuspendLayout();
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
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpConditions);
            this.pnlContainer.Controls.Add(this.grpEditorParams);
            this.pnlContainer.Controls.Add(this.grpEvents);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpCommands);
            this.pnlContainer.Location = new System.Drawing.Point(221, 36);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(613, 485);
            this.pnlContainer.TabIndex = 31;
            this.pnlContainer.Visible = false;
            // 
            // grpConditions
            // 
            this.grpConditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpConditions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpConditions.Controls.Add(this.lblCannotExit);
            this.grpConditions.Controls.Add(this.txtCannotExit);
            this.grpConditions.Controls.Add(this.lblCannotEnter);
            this.grpConditions.Controls.Add(this.txtCannotEnter);
            this.grpConditions.Controls.Add(this.btnEditExitConditions);
            this.grpConditions.Controls.Add(this.btnEditEnterConditions);
            this.grpConditions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpConditions.Location = new System.Drawing.Point(5, 158);
            this.grpConditions.Name = "grpConditions";
            this.grpConditions.Size = new System.Drawing.Size(574, 124);
            this.grpConditions.TabIndex = 58;
            this.grpConditions.TabStop = false;
            this.grpConditions.Text = "MapRegion Conditions";
            // 
            // lblCannotExit
            // 
            this.lblCannotExit.AutoSize = true;
            this.lblCannotExit.Location = new System.Drawing.Point(314, 51);
            this.lblCannotExit.Name = "lblCannotExit";
            this.lblCannotExit.Size = new System.Drawing.Size(110, 13);
            this.lblCannotExit.TabIndex = 58;
            this.lblCannotExit.Text = "Cannot Exit Message:";
            // 
            // txtCannotExit
            // 
            this.txtCannotExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtCannotExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCannotExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtCannotExit.Location = new System.Drawing.Point(315, 68);
            this.txtCannotExit.Multiline = true;
            this.txtCannotExit.Name = "txtCannotExit";
            this.txtCannotExit.Size = new System.Drawing.Size(250, 50);
            this.txtCannotExit.TabIndex = 57;
            this.txtCannotExit.TextChanged += new System.EventHandler(this.txtCannotExit_TextChanged);
            // 
            // lblCannotEnter
            // 
            this.lblCannotEnter.AutoSize = true;
            this.lblCannotEnter.Location = new System.Drawing.Point(9, 51);
            this.lblCannotEnter.Name = "lblCannotEnter";
            this.lblCannotEnter.Size = new System.Drawing.Size(118, 13);
            this.lblCannotEnter.TabIndex = 56;
            this.lblCannotEnter.Text = "Cannot Enter Message:";
            // 
            // txtCannotEnter
            // 
            this.txtCannotEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtCannotEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCannotEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtCannotEnter.Location = new System.Drawing.Point(10, 68);
            this.txtCannotEnter.Multiline = true;
            this.txtCannotEnter.Name = "txtCannotEnter";
            this.txtCannotEnter.Size = new System.Drawing.Size(250, 50);
            this.txtCannotEnter.TabIndex = 55;
            this.txtCannotEnter.TextChanged += new System.EventHandler(this.txtCannotEnter_TextChanged);
            // 
            // btnEditExitConditions
            // 
            this.btnEditExitConditions.Location = new System.Drawing.Point(354, 22);
            this.btnEditExitConditions.Name = "btnEditExitConditions";
            this.btnEditExitConditions.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditExitConditions.Size = new System.Drawing.Size(175, 23);
            this.btnEditExitConditions.TabIndex = 2;
            this.btnEditExitConditions.Text = "Edit Exit Conditions (None)";
            this.btnEditExitConditions.Click += new System.EventHandler(this.btnEditExitConditions_Click);
            // 
            // btnEditEnterConditions
            // 
            this.btnEditEnterConditions.Location = new System.Drawing.Point(49, 22);
            this.btnEditEnterConditions.Name = "btnEditEnterConditions";
            this.btnEditEnterConditions.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditEnterConditions.Size = new System.Drawing.Size(175, 23);
            this.btnEditEnterConditions.TabIndex = 1;
            this.btnEditEnterConditions.Text = "Edit Enter Conditions (None)";
            this.btnEditEnterConditions.Click += new System.EventHandler(this.btnEditEnterConditions_Click);
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
            // grpCommands
            // 
            this.grpCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCommands.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCommands.Controls.Add(this.lblEditCommand);
            this.grpCommands.Controls.Add(this.cmbNewCommand);
            this.grpCommands.Controls.Add(this.btnDuplicate);
            this.grpCommands.Controls.Add(this.btnRemove);
            this.grpCommands.Controls.Add(this.btnAdd);
            this.grpCommands.Controls.Add(this.lblNewCommand);
            this.grpCommands.Controls.Add(this.lstCommands);
            this.grpCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCommands.Location = new System.Drawing.Point(5, 285);
            this.grpCommands.Name = "grpCommands";
            this.grpCommands.Size = new System.Drawing.Size(574, 198);
            this.grpCommands.TabIndex = 30;
            this.grpCommands.TabStop = false;
            this.grpCommands.Text = "MapRegion Commands:";
            // 
            // lblEditCommand
            // 
            this.lblEditCommand.AutoSize = true;
            this.lblEditCommand.Location = new System.Drawing.Point(13, 149);
            this.lblEditCommand.Name = "lblEditCommand";
            this.lblEditCommand.Size = new System.Drawing.Size(156, 13);
            this.lblEditCommand.TabIndex = 41;
            this.lblEditCommand.Text = "Double-click to edit a command";
            // 
            // cmbNewCommand
            // 
            this.cmbNewCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbNewCommand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbNewCommand.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbNewCommand.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbNewCommand.DrawDropdownHoverOutline = false;
            this.cmbNewCommand.DrawFocusRectangle = false;
            this.cmbNewCommand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNewCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNewCommand.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbNewCommand.FormattingEnabled = true;
            this.cmbNewCommand.Location = new System.Drawing.Point(306, 144);
            this.cmbNewCommand.Name = "cmbNewCommand";
            this.cmbNewCommand.Size = new System.Drawing.Size(250, 21);
            this.cmbNewCommand.TabIndex = 40;
            this.cmbNewCommand.Text = null;
            this.cmbNewCommand.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(98, 170);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Padding = new System.Windows.Forms.Padding(5);
            this.btnDuplicate.Size = new System.Drawing.Size(79, 23);
            this.btnDuplicate.TabIndex = 39;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(13, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(79, 23);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(383, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNewCommand
            // 
            this.lblNewCommand.AutoSize = true;
            this.lblNewCommand.Location = new System.Drawing.Point(222, 149);
            this.lblNewCommand.Name = "lblNewCommand";
            this.lblNewCommand.Size = new System.Drawing.Size(82, 13);
            this.lblNewCommand.TabIndex = 31;
            this.lblNewCommand.Text = "New Command:";
            // 
            // lstCommands
            // 
            this.lstCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCommands.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.Location = new System.Drawing.Point(13, 19);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(543, 119);
            this.lstCommands.TabIndex = 29;
            this.lstCommands.DoubleClick += new System.EventHandler(this.lstCommands_DoubleClick);
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
            this.toolStrip.Size = new System.Drawing.Size(846, 25);
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
            // FrmMapRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(846, 561);
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
            this.grpConditions.ResumeLayout(false);
            this.grpConditions.PerformLayout();
            this.grpEditorParams.ResumeLayout(false);
            this.grpEditorParams.PerformLayout();
            this.grpEvents.ResumeLayout(false);
            this.grpEvents.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpCommands.ResumeLayout(false);
            this.grpCommands.PerformLayout();
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
        private DarkGroupBox grpCommands;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.Label lblNewCommand;
        private System.Windows.Forms.ListBox lstCommands;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkButton btnDuplicate;
        private DarkComboBox cmbNewCommand;
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
        private DarkGroupBox grpConditions;
        private DarkButton btnEditExitConditions;
        private DarkButton btnEditEnterConditions;
        private System.Windows.Forms.Label lblEditCommand;
        private System.Windows.Forms.Label lblCannotExit;
        private DarkTextBox txtCannotExit;
        private System.Windows.Forms.Label lblCannotEnter;
        private DarkTextBox txtCannotEnter;
    }
}
