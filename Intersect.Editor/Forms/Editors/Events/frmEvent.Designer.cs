using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events
{
    partial class FrmEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Show Text");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Show Options");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Input Variable");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Add Chatbox Text");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Dialogue", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Set Variable");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Set Self Switch");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Conditional Branch");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Exit Event Process");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Go To Label");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Start Common Event");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Logic Flow", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Restore HP");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Restore MP");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Level Up");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Give Experience");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Set Exp. Boost");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Change Level");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Change Spells");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Change Items");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Change Sprite");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Change Player Color");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Change Face");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Change Gender");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Set Access");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Change Class");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Equip/Unequip Item");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Change Name Color");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Change Player Label");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Change Player Name");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Reset Stat Point Allocations");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Player Control", new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95,
            treeNode96,
            treeNode97,
            treeNode98,
            treeNode99,
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Warp Player");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Set Move Route");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Wait for Route Completion");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Hold Player");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Release Player");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("Spawn NPC");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Despawn NPC");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Hide Player");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("Show Player");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Movement", new System.Windows.Forms.TreeNode[] {
            treeNode102,
            treeNode103,
            treeNode104,
            treeNode105,
            treeNode106,
            treeNode107,
            treeNode108,
            treeNode109,
            treeNode110});
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("Use Spell");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Show Popup");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Play Animation");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Play BGM");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Fadeout BGM");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Play Sound");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Stop Sounds");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Show Picture");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Hide Picture");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("Special Effects", new System.Windows.Forms.TreeNode[] {
            treeNode112,
            treeNode113,
            treeNode114,
            treeNode115,
            treeNode116,
            treeNode117,
            treeNode118,
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("Start Quest");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Complete Quest Task");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("End Quest");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Quest Control", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode123,
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Wait...");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Etc", new System.Windows.Forms.TreeNode[] {
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("Open Bank");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Open Shop");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Open Crafting Station");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("Shop and Bank", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode129,
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("Create Guild");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("Disband Guild");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Open Guild Bank");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("Set Guild Bank Slots Count");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Guilds", new System.Windows.Forms.TreeNode[] {
            treeNode132,
            treeNode133,
            treeNode134,
            treeNode135});
            this.lblName = new System.Windows.Forms.Label();
            this.txtEventname = new DarkUI.Controls.DarkTextBox();
            this.grpEntityOptions = new DarkUI.Controls.DarkGroupBox();
            this.grpExtra = new DarkUI.Controls.DarkGroupBox();
            this.chkCollideOnDash = new DarkUI.Controls.DarkCheckBox();
            this.chkInteractionFreeze = new DarkUI.Controls.DarkCheckBox();
            this.chkWalkingAnimation = new DarkUI.Controls.DarkCheckBox();
            this.chkDirectionFix = new DarkUI.Controls.DarkCheckBox();
            this.chkHideName = new DarkUI.Controls.DarkCheckBox();
            this.chkWalkThrough = new DarkUI.Controls.DarkCheckBox();
            this.grpInspector = new DarkUI.Controls.DarkGroupBox();
            this.pnlFacePreview = new System.Windows.Forms.Panel();
            this.lblInspectorDesc = new System.Windows.Forms.Label();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.chkDisableInspector = new DarkUI.Controls.DarkCheckBox();
            this.cmbPreviewFace = new DarkUI.Controls.DarkComboBox();
            this.lblFace = new System.Windows.Forms.Label();
            this.grpPreview = new DarkUI.Controls.DarkGroupBox();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.grpMovement = new DarkUI.Controls.DarkGroupBox();
            this.lblLayer = new System.Windows.Forms.Label();
            this.cmbLayering = new DarkUI.Controls.DarkComboBox();
            this.cmbEventFreq = new DarkUI.Controls.DarkComboBox();
            this.cmbEventSpeed = new DarkUI.Controls.DarkComboBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnSetRoute = new DarkUI.Controls.DarkButton();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbMoveType = new DarkUI.Controls.DarkComboBox();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.grpTriggers = new DarkUI.Controls.DarkGroupBox();
            this.chkPvpStadium = new DarkUI.Controls.DarkCheckBox();
            this.btnMapTrigger = new DarkUI.Controls.DarkButton();
            this.lblMapTrigger = new System.Windows.Forms.Label();
            this.cmbVariable = new DarkUI.Controls.DarkComboBox();
            this.lblVariableTrigger = new System.Windows.Forms.Label();
            this.txtCommand = new DarkUI.Controls.DarkTextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblTriggerVal = new System.Windows.Forms.Label();
            this.cmbTriggerVal = new DarkUI.Controls.DarkComboBox();
            this.cmbTrigger = new DarkUI.Controls.DarkComboBox();
            this.grpEventConditions = new DarkUI.Controls.DarkGroupBox();
            this.btnEditConditions = new DarkUI.Controls.DarkButton();
            this.grpNewCommands = new DarkUI.Controls.DarkGroupBox();
            this.lblCloseCommands = new System.Windows.Forms.Label();
            this.lstCommands = new System.Windows.Forms.TreeView();
            this.grpEventCommands = new DarkUI.Controls.DarkGroupBox();
            this.lstEventCommands = new System.Windows.Forms.ListBox();
            this.grpCreateCommands = new DarkUI.Controls.DarkGroupBox();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.commandMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPageOptions = new DarkUI.Controls.DarkGroupBox();
            this.btnClearPage = new DarkUI.Controls.DarkButton();
            this.btnDeletePage = new DarkUI.Controls.DarkButton();
            this.btnPastePage = new DarkUI.Controls.DarkButton();
            this.btnCopyPage = new DarkUI.Controls.DarkButton();
            this.btnNewPage = new DarkUI.Controls.DarkButton();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.btnRelations = new DarkUI.Controls.DarkButton();
            this.chkIsGlobal = new DarkUI.Controls.DarkCheckBox();
            this.pnlTabsContainer = new System.Windows.Forms.Panel();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnTabsRight = new DarkUI.Controls.DarkButton();
            this.btnTabsLeft = new DarkUI.Controls.DarkButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpCommentary = new DarkUI.Controls.DarkGroupBox();
            this.txtCommentary = new DarkUI.Controls.DarkTextBox();
            this.grpEntityOptions.SuspendLayout();
            this.grpExtra.SuspendLayout();
            this.grpInspector.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.grpMovement.SuspendLayout();
            this.grpTriggers.SuspendLayout();
            this.grpEventConditions.SuspendLayout();
            this.grpNewCommands.SuspendLayout();
            this.grpEventCommands.SuspendLayout();
            this.commandMenu.SuspendLayout();
            this.grpPageOptions.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.pnlTabsContainer.SuspendLayout();
            this.grpCommentary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtEventname
            // 
            this.txtEventname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtEventname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtEventname.Location = new System.Drawing.Point(48, 19);
            this.txtEventname.Name = "txtEventname";
            this.txtEventname.Size = new System.Drawing.Size(124, 20);
            this.txtEventname.TabIndex = 2;
            this.txtEventname.TextChanged += new System.EventHandler(this.txtEventname_TextChanged);
            // 
            // grpEntityOptions
            // 
            this.grpEntityOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEntityOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEntityOptions.Controls.Add(this.grpExtra);
            this.grpEntityOptions.Controls.Add(this.grpInspector);
            this.grpEntityOptions.Controls.Add(this.grpPreview);
            this.grpEntityOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEntityOptions.Location = new System.Drawing.Point(21, 150);
            this.grpEntityOptions.Name = "grpEntityOptions";
            this.grpEntityOptions.Size = new System.Drawing.Size(326, 423);
            this.grpEntityOptions.TabIndex = 12;
            this.grpEntityOptions.TabStop = false;
            this.grpEntityOptions.Text = "Entity Options";
            // 
            // grpExtra
            // 
            this.grpExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpExtra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpExtra.Controls.Add(this.chkCollideOnDash);
            this.grpExtra.Controls.Add(this.chkInteractionFreeze);
            this.grpExtra.Controls.Add(this.chkWalkingAnimation);
            this.grpExtra.Controls.Add(this.chkDirectionFix);
            this.grpExtra.Controls.Add(this.chkHideName);
            this.grpExtra.Controls.Add(this.chkWalkThrough);
            this.grpExtra.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpExtra.Location = new System.Drawing.Point(6, 297);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(315, 64);
            this.grpExtra.TabIndex = 9;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Extra";
            // 
            // chkCollideOnDash
            // 
            this.chkCollideOnDash.AutoSize = true;
            this.chkCollideOnDash.Location = new System.Drawing.Point(123, 41);
            this.chkCollideOnDash.Name = "chkCollideOnDash";
            this.chkCollideOnDash.Size = new System.Drawing.Size(100, 17);
            this.chkCollideOnDash.TabIndex = 7;
            this.chkCollideOnDash.Text = "Collide on Dash";
            this.chkCollideOnDash.CheckedChanged += new System.EventHandler(this.chkCollideOnDash_CheckedChanged);
            // 
            // chkInteractionFreeze
            // 
            this.chkInteractionFreeze.AutoSize = true;
            this.chkInteractionFreeze.Location = new System.Drawing.Point(6, 41);
            this.chkInteractionFreeze.Name = "chkInteractionFreeze";
            this.chkInteractionFreeze.Size = new System.Drawing.Size(111, 17);
            this.chkInteractionFreeze.TabIndex = 6;
            this.chkInteractionFreeze.Text = "Interaction Freeze";
            this.chkInteractionFreeze.CheckedChanged += new System.EventHandler(this.chkInteractionFreeze_CheckedChanged);
            // 
            // chkWalkingAnimation
            // 
            this.chkWalkingAnimation.AutoSize = true;
            this.chkWalkingAnimation.Location = new System.Drawing.Point(214, 19);
            this.chkWalkingAnimation.Name = "chkWalkingAnimation";
            this.chkWalkingAnimation.Size = new System.Drawing.Size(91, 17);
            this.chkWalkingAnimation.TabIndex = 5;
            this.chkWalkingAnimation.Text = "Walking Anim";
            this.chkWalkingAnimation.CheckedChanged += new System.EventHandler(this.chkWalkingAnimation_CheckedChanged);
            // 
            // chkDirectionFix
            // 
            this.chkDirectionFix.AutoSize = true;
            this.chkDirectionFix.Location = new System.Drawing.Point(156, 19);
            this.chkDirectionFix.Name = "chkDirectionFix";
            this.chkDirectionFix.Size = new System.Drawing.Size(55, 17);
            this.chkDirectionFix.TabIndex = 4;
            this.chkDirectionFix.Text = "Dir Fix";
            this.chkDirectionFix.CheckedChanged += new System.EventHandler(this.chkDirectionFix_CheckedChanged);
            // 
            // chkHideName
            // 
            this.chkHideName.AutoSize = true;
            this.chkHideName.Location = new System.Drawing.Point(75, 19);
            this.chkHideName.Name = "chkHideName";
            this.chkHideName.Size = new System.Drawing.Size(79, 17);
            this.chkHideName.TabIndex = 3;
            this.chkHideName.Text = "Hide Name";
            this.chkHideName.CheckedChanged += new System.EventHandler(this.chkHideName_CheckedChanged);
            // 
            // chkWalkThrough
            // 
            this.chkWalkThrough.AutoSize = true;
            this.chkWalkThrough.Location = new System.Drawing.Point(6, 19);
            this.chkWalkThrough.Name = "chkWalkThrough";
            this.chkWalkThrough.Size = new System.Drawing.Size(69, 17);
            this.chkWalkThrough.TabIndex = 2;
            this.chkWalkThrough.Text = "Passable";
            this.chkWalkThrough.CheckedChanged += new System.EventHandler(this.chkWalkThrough_CheckedChanged);
            // 
            // grpInspector
            // 
            this.grpInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpInspector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpInspector.Controls.Add(this.pnlFacePreview);
            this.grpInspector.Controls.Add(this.lblInspectorDesc);
            this.grpInspector.Controls.Add(this.txtDesc);
            this.grpInspector.Controls.Add(this.chkDisableInspector);
            this.grpInspector.Controls.Add(this.cmbPreviewFace);
            this.grpInspector.Controls.Add(this.lblFace);
            this.grpInspector.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpInspector.Location = new System.Drawing.Point(6, 179);
            this.grpInspector.Name = "grpInspector";
            this.grpInspector.Size = new System.Drawing.Size(316, 117);
            this.grpInspector.TabIndex = 7;
            this.grpInspector.TabStop = false;
            this.grpInspector.Text = "Entity Inspector Options";
            // 
            // pnlFacePreview
            // 
            this.pnlFacePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFacePreview.Location = new System.Drawing.Point(9, 46);
            this.pnlFacePreview.Name = "pnlFacePreview";
            this.pnlFacePreview.Size = new System.Drawing.Size(64, 64);
            this.pnlFacePreview.TabIndex = 12;
            // 
            // lblInspectorDesc
            // 
            this.lblInspectorDesc.Location = new System.Drawing.Point(79, 42);
            this.lblInspectorDesc.Name = "lblInspectorDesc";
            this.lblInspectorDesc.Size = new System.Drawing.Size(112, 19);
            this.lblInspectorDesc.TabIndex = 11;
            this.lblInspectorDesc.Text = "Inspector Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(79, 61);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(231, 50);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // chkDisableInspector
            // 
            this.chkDisableInspector.Location = new System.Drawing.Point(204, 15);
            this.chkDisableInspector.Name = "chkDisableInspector";
            this.chkDisableInspector.Size = new System.Drawing.Size(107, 21);
            this.chkDisableInspector.TabIndex = 4;
            this.chkDisableInspector.Text = "Disable Inspector";
            this.chkDisableInspector.CheckedChanged += new System.EventHandler(this.chkDisablePreview_CheckedChanged);
            // 
            // cmbPreviewFace
            // 
            this.cmbPreviewFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbPreviewFace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbPreviewFace.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbPreviewFace.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbPreviewFace.DrawDropdownHoverOutline = false;
            this.cmbPreviewFace.DrawFocusRectangle = false;
            this.cmbPreviewFace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPreviewFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreviewFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPreviewFace.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbPreviewFace.FormattingEnabled = true;
            this.cmbPreviewFace.Location = new System.Drawing.Point(46, 15);
            this.cmbPreviewFace.Name = "cmbPreviewFace";
            this.cmbPreviewFace.Size = new System.Drawing.Size(135, 21);
            this.cmbPreviewFace.TabIndex = 10;
            this.cmbPreviewFace.Text = null;
            this.cmbPreviewFace.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbPreviewFace.SelectedIndexChanged += new System.EventHandler(this.cmbPreviewFace_SelectedIndexChanged);
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Location = new System.Drawing.Point(6, 18);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(34, 13);
            this.lblFace.TabIndex = 9;
            this.lblFace.Text = "Face:";
            // 
            // grpPreview
            // 
            this.grpPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpPreview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPreview.Controls.Add(this.lblAnimation);
            this.grpPreview.Controls.Add(this.cmbAnimation);
            this.grpPreview.Controls.Add(this.grpMovement);
            this.grpPreview.Controls.Add(this.pnlPreview);
            this.grpPreview.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPreview.Location = new System.Drawing.Point(6, 13);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(315, 160);
            this.grpPreview.TabIndex = 10;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Location = new System.Drawing.Point(12, 117);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(56, 13);
            this.lblAnimation.TabIndex = 2;
            this.lblAnimation.Text = "Animation:";
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
            this.cmbAnimation.Location = new System.Drawing.Point(10, 133);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(295, 21);
            this.cmbAnimation.TabIndex = 1;
            this.cmbAnimation.Text = null;
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAnimation_SelectedIndexChanged);
            // 
            // grpMovement
            // 
            this.grpMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpMovement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpMovement.Controls.Add(this.lblLayer);
            this.grpMovement.Controls.Add(this.cmbLayering);
            this.grpMovement.Controls.Add(this.cmbEventFreq);
            this.grpMovement.Controls.Add(this.cmbEventSpeed);
            this.grpMovement.Controls.Add(this.lblFreq);
            this.grpMovement.Controls.Add(this.lblSpeed);
            this.grpMovement.Controls.Add(this.btnSetRoute);
            this.grpMovement.Controls.Add(this.lblType);
            this.grpMovement.Controls.Add(this.cmbMoveType);
            this.grpMovement.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpMovement.Location = new System.Drawing.Point(108, 8);
            this.grpMovement.Name = "grpMovement";
            this.grpMovement.Size = new System.Drawing.Size(201, 122);
            this.grpMovement.TabIndex = 8;
            this.grpMovement.TabStop = false;
            this.grpMovement.Text = "Movement";
            // 
            // lblLayer
            // 
            this.lblLayer.AutoSize = true;
            this.lblLayer.Location = new System.Drawing.Point(1, 100);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(36, 13);
            this.lblLayer.TabIndex = 7;
            this.lblLayer.Text = "Layer:";
            // 
            // cmbLayering
            // 
            this.cmbLayering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbLayering.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbLayering.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbLayering.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbLayering.DrawDropdownHoverOutline = false;
            this.cmbLayering.DrawFocusRectangle = false;
            this.cmbLayering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLayering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLayering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLayering.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbLayering.FormattingEnabled = true;
            this.cmbLayering.Items.AddRange(new object[] {
            "Below Player",
            "Same as Player",
            "Above Player"});
            this.cmbLayering.Location = new System.Drawing.Point(43, 97);
            this.cmbLayering.Name = "cmbLayering";
            this.cmbLayering.Size = new System.Drawing.Size(123, 21);
            this.cmbLayering.TabIndex = 1;
            this.cmbLayering.Text = "Below Player";
            this.cmbLayering.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbLayering.SelectedIndexChanged += new System.EventHandler(this.cmbLayering_SelectedIndexChanged);
            // 
            // cmbEventFreq
            // 
            this.cmbEventFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEventFreq.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEventFreq.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEventFreq.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEventFreq.DrawDropdownHoverOutline = false;
            this.cmbEventFreq.DrawFocusRectangle = false;
            this.cmbEventFreq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventFreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventFreq.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEventFreq.FormattingEnabled = true;
            this.cmbEventFreq.Items.AddRange(new object[] {
            "Not Very Often",
            "Not Often",
            "Normal",
            "Often",
            "Very Often"});
            this.cmbEventFreq.Location = new System.Drawing.Point(43, 71);
            this.cmbEventFreq.Name = "cmbEventFreq";
            this.cmbEventFreq.Size = new System.Drawing.Size(123, 21);
            this.cmbEventFreq.TabIndex = 6;
            this.cmbEventFreq.Text = "Not Very Often";
            this.cmbEventFreq.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEventFreq.SelectedIndexChanged += new System.EventHandler(this.cmbEventFreq_SelectedIndexChanged);
            // 
            // cmbEventSpeed
            // 
            this.cmbEventSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEventSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEventSpeed.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEventSpeed.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEventSpeed.DrawDropdownHoverOutline = false;
            this.cmbEventSpeed.DrawFocusRectangle = false;
            this.cmbEventSpeed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEventSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEventSpeed.FormattingEnabled = true;
            this.cmbEventSpeed.Items.AddRange(new object[] {
            "Slowest",
            "Slower",
            "Normal",
            "Faster",
            "Fastest"});
            this.cmbEventSpeed.Location = new System.Drawing.Point(43, 45);
            this.cmbEventSpeed.Name = "cmbEventSpeed";
            this.cmbEventSpeed.Size = new System.Drawing.Size(123, 21);
            this.cmbEventSpeed.TabIndex = 5;
            this.cmbEventSpeed.Text = "Slowest";
            this.cmbEventSpeed.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEventSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbEventSpeed_SelectedIndexChanged);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(1, 74);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(31, 13);
            this.lblFreq.TabIndex = 4;
            this.lblFreq.Text = "Freq:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(1, 48);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Speed:";
            // 
            // btnSetRoute
            // 
            this.btnSetRoute.Enabled = false;
            this.btnSetRoute.Location = new System.Drawing.Point(124, 18);
            this.btnSetRoute.Name = "btnSetRoute";
            this.btnSetRoute.Padding = new System.Windows.Forms.Padding(5);
            this.btnSetRoute.Size = new System.Drawing.Size(75, 23);
            this.btnSetRoute.TabIndex = 2;
            this.btnSetRoute.Text = "Set Route....";
            this.btnSetRoute.Click += new System.EventHandler(this.btnSetRoute_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(1, 22);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type:";
            // 
            // cmbMoveType
            // 
            this.cmbMoveType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbMoveType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbMoveType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMoveType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbMoveType.DrawDropdownHoverOutline = false;
            this.cmbMoveType.DrawFocusRectangle = false;
            this.cmbMoveType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMoveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMoveType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMoveType.FormattingEnabled = true;
            this.cmbMoveType.Items.AddRange(new object[] {
            "None",
            "Random",
            "Move Route"});
            this.cmbMoveType.Location = new System.Drawing.Point(35, 19);
            this.cmbMoveType.Name = "cmbMoveType";
            this.cmbMoveType.Size = new System.Drawing.Size(87, 21);
            this.cmbMoveType.TabIndex = 0;
            this.cmbMoveType.Text = "None";
            this.cmbMoveType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbMoveType.SelectedIndexChanged += new System.EventHandler(this.cmbMoveType_SelectedIndexChanged);
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreview.Location = new System.Drawing.Point(6, 17);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(96, 96);
            this.pnlPreview.TabIndex = 0;
            this.pnlPreview.DoubleClick += new System.EventHandler(this.pnlPreview_DoubleClick);
            // 
            // grpTriggers
            // 
            this.grpTriggers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpTriggers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTriggers.Controls.Add(this.chkPvpStadium);
            this.grpTriggers.Controls.Add(this.btnMapTrigger);
            this.grpTriggers.Controls.Add(this.lblMapTrigger);
            this.grpTriggers.Controls.Add(this.cmbVariable);
            this.grpTriggers.Controls.Add(this.lblVariableTrigger);
            this.grpTriggers.Controls.Add(this.txtCommand);
            this.grpTriggers.Controls.Add(this.lblCommand);
            this.grpTriggers.Controls.Add(this.lblTriggerVal);
            this.grpTriggers.Controls.Add(this.cmbTriggerVal);
            this.grpTriggers.Controls.Add(this.cmbTrigger);
            this.grpTriggers.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTriggers.Location = new System.Drawing.Point(25, 517);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(317, 44);
            this.grpTriggers.TabIndex = 21;
            this.grpTriggers.TabStop = false;
            this.grpTriggers.Text = "Trigger";
            // 
            // chkPvpStadium
            // 
            this.chkPvpStadium.AutoSize = true;
            this.chkPvpStadium.Location = new System.Drawing.Point(133, 17);
            this.chkPvpStadium.Name = "chkPvpStadium";
            this.chkPvpStadium.Size = new System.Drawing.Size(92, 17);
            this.chkPvpStadium.TabIndex = 8;
            this.chkPvpStadium.Text = "PvpStadium ?";
            this.chkPvpStadium.CheckedChanged += new System.EventHandler(this.chkPvpStadium_CheckedChanged);
            // 
            // btnMapTrigger
            // 
            this.btnMapTrigger.Location = new System.Drawing.Point(115, 14);
            this.btnMapTrigger.Name = "btnMapTrigger";
            this.btnMapTrigger.Padding = new System.Windows.Forms.Padding(5);
            this.btnMapTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnMapTrigger.TabIndex = 8;
            this.btnMapTrigger.Text = "Select Map";
            this.btnMapTrigger.Click += new System.EventHandler(this.btnMapTrigger_Click);
            // 
            // lblMapTrigger
            // 
            this.lblMapTrigger.AutoSize = true;
            this.lblMapTrigger.Location = new System.Drawing.Point(192, 19);
            this.lblMapTrigger.MaximumSize = new System.Drawing.Size(119, 13);
            this.lblMapTrigger.Name = "lblMapTrigger";
            this.lblMapTrigger.Size = new System.Drawing.Size(33, 13);
            this.lblMapTrigger.TabIndex = 15;
            this.lblMapTrigger.Text = "None";
            this.lblMapTrigger.Visible = false;
            // 
            // cmbVariable
            // 
            this.cmbVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbVariable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbVariable.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbVariable.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbVariable.DrawDropdownHoverOutline = false;
            this.cmbVariable.DrawFocusRectangle = false;
            this.cmbVariable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariable.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Items.AddRange(new object[] {
            "None"});
            this.cmbVariable.Location = new System.Drawing.Point(181, 15);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(130, 21);
            this.cmbVariable.TabIndex = 14;
            this.cmbVariable.Text = "None";
            this.cmbVariable.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbVariable.SelectedIndexChanged += new System.EventHandler(this.cmbVariable_SelectedIndexChanged);
            // 
            // lblVariableTrigger
            // 
            this.lblVariableTrigger.AutoSize = true;
            this.lblVariableTrigger.Location = new System.Drawing.Point(113, 19);
            this.lblVariableTrigger.Name = "lblVariableTrigger";
            this.lblVariableTrigger.Size = new System.Drawing.Size(48, 13);
            this.lblVariableTrigger.TabIndex = 13;
            this.lblVariableTrigger.Text = "Variable:";
            this.lblVariableTrigger.Visible = false;
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtCommand.Location = new System.Drawing.Point(181, 15);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(130, 20);
            this.txtCommand.TabIndex = 12;
            this.txtCommand.Visible = false;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(113, 19);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(70, 13);
            this.lblCommand.TabIndex = 11;
            this.lblCommand.Text = "/Command: /";
            this.lblCommand.Visible = false;
            // 
            // lblTriggerVal
            // 
            this.lblTriggerVal.AutoSize = true;
            this.lblTriggerVal.Location = new System.Drawing.Point(113, 17);
            this.lblTriggerVal.Name = "lblTriggerVal";
            this.lblTriggerVal.Size = new System.Drawing.Size(53, 13);
            this.lblTriggerVal.TabIndex = 10;
            this.lblTriggerVal.Text = "Projectile:";
            this.lblTriggerVal.Visible = false;
            // 
            // cmbTriggerVal
            // 
            this.cmbTriggerVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTriggerVal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTriggerVal.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTriggerVal.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTriggerVal.DrawDropdownHoverOutline = false;
            this.cmbTriggerVal.DrawFocusRectangle = false;
            this.cmbTriggerVal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTriggerVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriggerVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTriggerVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTriggerVal.FormattingEnabled = true;
            this.cmbTriggerVal.Items.AddRange(new object[] {
            "None"});
            this.cmbTriggerVal.Location = new System.Drawing.Point(181, 15);
            this.cmbTriggerVal.Name = "cmbTriggerVal";
            this.cmbTriggerVal.Size = new System.Drawing.Size(130, 21);
            this.cmbTriggerVal.TabIndex = 9;
            this.cmbTriggerVal.Text = "None";
            this.cmbTriggerVal.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTriggerVal.Visible = false;
            // 
            // cmbTrigger
            // 
            this.cmbTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTrigger.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTrigger.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTrigger.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTrigger.DrawDropdownHoverOutline = false;
            this.cmbTrigger.DrawFocusRectangle = false;
            this.cmbTrigger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrigger.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTrigger.FormattingEnabled = true;
            this.cmbTrigger.Items.AddRange(new object[] {
            "Action Button",
            "Player Touch",
            "Autorun",
            "Projectile Hit"});
            this.cmbTrigger.Location = new System.Drawing.Point(2, 15);
            this.cmbTrigger.Name = "cmbTrigger";
            this.cmbTrigger.Size = new System.Drawing.Size(111, 21);
            this.cmbTrigger.TabIndex = 2;
            this.cmbTrigger.Text = "Action Button";
            this.cmbTrigger.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTrigger.SelectedIndexChanged += new System.EventHandler(this.cmbTrigger_SelectedIndexChanged);
            // 
            // grpEventConditions
            // 
            this.grpEventConditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEventConditions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEventConditions.Controls.Add(this.btnEditConditions);
            this.grpEventConditions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEventConditions.Location = new System.Drawing.Point(21, 89);
            this.grpEventConditions.Name = "grpEventConditions";
            this.grpEventConditions.Size = new System.Drawing.Size(326, 55);
            this.grpEventConditions.TabIndex = 5;
            this.grpEventConditions.TabStop = false;
            this.grpEventConditions.Text = "Conditions";
            // 
            // btnEditConditions
            // 
            this.btnEditConditions.Location = new System.Drawing.Point(7, 20);
            this.btnEditConditions.Name = "btnEditConditions";
            this.btnEditConditions.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditConditions.Size = new System.Drawing.Size(304, 23);
            this.btnEditConditions.TabIndex = 0;
            this.btnEditConditions.Text = "Spawn/Execution Conditions";
            this.btnEditConditions.Click += new System.EventHandler(this.btnEditConditions_Click);
            // 
            // grpNewCommands
            // 
            this.grpNewCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpNewCommands.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpNewCommands.Controls.Add(this.lblCloseCommands);
            this.grpNewCommands.Controls.Add(this.lstCommands);
            this.grpNewCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpNewCommands.Location = new System.Drawing.Point(353, 89);
            this.grpNewCommands.Name = "grpNewCommands";
            this.grpNewCommands.Size = new System.Drawing.Size(457, 484);
            this.grpNewCommands.TabIndex = 7;
            this.grpNewCommands.TabStop = false;
            this.grpNewCommands.Text = "Add Commands";
            this.grpNewCommands.Visible = false;
            // 
            // lblCloseCommands
            // 
            this.lblCloseCommands.AutoSize = true;
            this.lblCloseCommands.Location = new System.Drawing.Point(437, 14);
            this.lblCloseCommands.Name = "lblCloseCommands";
            this.lblCloseCommands.Size = new System.Drawing.Size(14, 13);
            this.lblCloseCommands.TabIndex = 1;
            this.lblCloseCommands.Text = "X";
            this.lblCloseCommands.Click += new System.EventHandler(this.lblCloseCommands_Click);
            // 
            // lstCommands
            // 
            this.lstCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstCommands.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstCommands.Location = new System.Drawing.Point(6, 32);
            this.lstCommands.Name = "lstCommands";
            treeNode69.Name = "showtext";
            treeNode69.Tag = "1";
            treeNode69.Text = "Show Text";
            treeNode70.Name = "showoptions";
            treeNode70.Tag = "2";
            treeNode70.Text = "Show Options";
            treeNode71.Name = "inputvariable";
            treeNode71.Tag = "49";
            treeNode71.Text = "Input Variable";
            treeNode72.Name = "addchatboxtext";
            treeNode72.Tag = "3";
            treeNode72.Text = "Add Chatbox Text";
            treeNode73.Name = "dialogue";
            treeNode73.Text = "Dialogue";
            treeNode74.Name = "setvariable";
            treeNode74.Tag = "5";
            treeNode74.Text = "Set Variable";
            treeNode75.Name = "setselfswitch";
            treeNode75.Tag = "6";
            treeNode75.Text = "Set Self Switch";
            treeNode76.Name = "conditionalbranch";
            treeNode76.Tag = "7";
            treeNode76.Text = "Conditional Branch";
            treeNode77.Name = "exiteventprocess";
            treeNode77.Tag = "8";
            treeNode77.Text = "Exit Event Process";
            treeNode78.Name = "label";
            treeNode78.Tag = "9";
            treeNode78.Text = "Label";
            treeNode79.Name = "gotolabel";
            treeNode79.Tag = "10";
            treeNode79.Text = "Go To Label";
            treeNode80.Name = "startcommonevent";
            treeNode80.Tag = "11";
            treeNode80.Text = "Start Common Event";
            treeNode81.Name = "logicflow";
            treeNode81.Text = "Logic Flow";
            treeNode82.Name = "restorehp";
            treeNode82.Tag = "12";
            treeNode82.Text = "Restore HP";
            treeNode83.Name = "restoremp";
            treeNode83.Tag = "13";
            treeNode83.Text = "Restore MP";
            treeNode84.Name = "levelup";
            treeNode84.Tag = "14";
            treeNode84.Text = "Level Up";
            treeNode85.Name = "giveexperience";
            treeNode85.Tag = "15";
            treeNode85.Text = "Give Experience";
            treeNode86.Name = "setexpboost";
            treeNode86.Tag = "60";
            treeNode86.Text = "Set Exp. Boost";
            treeNode87.Name = "changelevel";
            treeNode87.Tag = "16";
            treeNode87.Text = "Change Level";
            treeNode88.Name = "changespells";
            treeNode88.Tag = "17";
            treeNode88.Text = "Change Spells";
            treeNode89.Name = "changeitems";
            treeNode89.Tag = "18";
            treeNode89.Text = "Change Items";
            treeNode90.Name = "changesprite";
            treeNode90.Tag = "19";
            treeNode90.Text = "Change Sprite";
            treeNode91.Name = "changeplayercolor";
            treeNode91.Tag = "51";
            treeNode91.Text = "Change Player Color";
            treeNode92.Name = "changeface";
            treeNode92.Tag = "20";
            treeNode92.Text = "Change Face";
            treeNode93.Name = "changegender";
            treeNode93.Tag = "21";
            treeNode93.Text = "Change Gender";
            treeNode94.Name = "setaccess";
            treeNode94.Tag = "22";
            treeNode94.Text = "Set Access";
            treeNode95.Name = "changeclass";
            treeNode95.Tag = "38";
            treeNode95.Text = "Change Class";
            treeNode96.Name = "equipitem";
            treeNode96.Tag = "47";
            treeNode96.Text = "Equip/Unequip Item";
            treeNode97.Name = "changenamecolor";
            treeNode97.Tag = "48";
            treeNode97.Text = "Change Name Color";
            treeNode98.Name = "changeplayerlabel";
            treeNode98.Tag = "50";
            treeNode98.Text = "Change Player Label";
            treeNode99.Name = "changename";
            treeNode99.Tag = "52";
            treeNode99.Text = "Change Player Name";
            treeNode100.Name = "resetstatallocations";
            treeNode100.Tag = "57";
            treeNode100.Text = "Reset Stat Point Allocations";
            treeNode101.Name = "playercontrol";
            treeNode101.Text = "Player Control";
            treeNode102.Name = "warpplayer";
            treeNode102.Tag = "23";
            treeNode102.Text = "Warp Player";
            treeNode103.Name = "setmoveroute";
            treeNode103.Tag = "24";
            treeNode103.Text = "Set Move Route";
            treeNode104.Name = "waitmoveroute";
            treeNode104.Tag = "25";
            treeNode104.Text = "Wait for Route Completion";
            treeNode105.Name = "holdplayer";
            treeNode105.Tag = "26";
            treeNode105.Text = "Hold Player";
            treeNode106.Name = "releaseplayer";
            treeNode106.Tag = "27";
            treeNode106.Text = "Release Player";
            treeNode107.Name = "spawnnpc";
            treeNode107.Tag = "28";
            treeNode107.Text = "Spawn NPC";
            treeNode108.Name = "despawnnpcs";
            treeNode108.Tag = "39";
            treeNode108.Text = "Despawn NPC";
            treeNode109.Name = "hideplayer";
            treeNode109.Tag = "45";
            treeNode109.Text = "Hide Player";
            treeNode110.Name = "showplayer";
            treeNode110.Tag = "46";
            treeNode110.Text = "Show Player";
            treeNode111.Name = "movement";
            treeNode111.Text = "Movement";
            treeNode112.Name = "usespell";
            treeNode112.Tag = "58";
            treeNode112.Text = "Use Spell";
            treeNode113.Name = "showpopup";
            treeNode113.Tag = "59";
            treeNode113.Text = "Show Popup";
            treeNode114.Name = "playanimation";
            treeNode114.Tag = "29";
            treeNode114.Text = "Play Animation";
            treeNode115.Name = "playbgm";
            treeNode115.Tag = "30";
            treeNode115.Text = "Play BGM";
            treeNode116.Name = "fadeoutbgm";
            treeNode116.Tag = "31";
            treeNode116.Text = "Fadeout BGM";
            treeNode117.Name = "playsound";
            treeNode117.Tag = "32";
            treeNode117.Text = "Play Sound";
            treeNode118.Name = "stopsounds";
            treeNode118.Tag = "33";
            treeNode118.Text = "Stop Sounds";
            treeNode119.Name = "showpicture";
            treeNode119.Tag = "43";
            treeNode119.Text = "Show Picture";
            treeNode120.Name = "hidepicture";
            treeNode120.Tag = "44";
            treeNode120.Text = "Hide Picture";
            treeNode121.Name = "specialeffects";
            treeNode121.Text = "Special Effects";
            treeNode122.Name = "startquest";
            treeNode122.Tag = "40";
            treeNode122.Text = "Start Quest";
            treeNode123.Name = "completequesttask";
            treeNode123.Tag = "41";
            treeNode123.Text = "Complete Quest Task";
            treeNode124.Name = "endquest";
            treeNode124.Tag = "42";
            treeNode124.Text = "End Quest";
            treeNode125.Name = "questcontrol";
            treeNode125.Text = "Quest Control";
            treeNode126.Name = "wait";
            treeNode126.Tag = "34";
            treeNode126.Text = "Wait...";
            treeNode127.Name = "etc";
            treeNode127.Text = "Etc";
            treeNode128.Name = "openbank";
            treeNode128.Tag = "35";
            treeNode128.Text = "Open Bank";
            treeNode129.Name = "openshop";
            treeNode129.Tag = "36";
            treeNode129.Text = "Open Shop";
            treeNode130.Name = "opencraftingstation";
            treeNode130.Tag = "37";
            treeNode130.Text = "Open Crafting Station";
            treeNode131.Name = "shopandbank";
            treeNode131.Text = "Shop and Bank";
            treeNode132.Name = "createguild";
            treeNode132.Tag = "53";
            treeNode132.Text = "Create Guild";
            treeNode133.Name = "disbandguild";
            treeNode133.Tag = "54";
            treeNode133.Text = "Disband Guild";
            treeNode134.Name = "openguildbank";
            treeNode134.Tag = "55";
            treeNode134.Text = "Open Guild Bank";
            treeNode135.Name = "setguildbankslots";
            treeNode135.Tag = "56";
            treeNode135.Text = "Set Guild Bank Slots Count";
            treeNode136.Name = "guilds";
            treeNode136.Text = "Guilds";
            this.lstCommands.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode81,
            treeNode101,
            treeNode111,
            treeNode121,
            treeNode125,
            treeNode127,
            treeNode131,
            treeNode136});
            this.lstCommands.Size = new System.Drawing.Size(445, 440);
            this.lstCommands.TabIndex = 2;
            this.lstCommands.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstCommands_NodeMouseDoubleClick);
            // 
            // grpEventCommands
            // 
            this.grpEventCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEventCommands.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEventCommands.Controls.Add(this.lstEventCommands);
            this.grpEventCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEventCommands.Location = new System.Drawing.Point(353, 89);
            this.grpEventCommands.Name = "grpEventCommands";
            this.grpEventCommands.Size = new System.Drawing.Size(457, 484);
            this.grpEventCommands.TabIndex = 6;
            this.grpEventCommands.TabStop = false;
            this.grpEventCommands.Text = "Commands";
            // 
            // lstEventCommands
            // 
            this.lstEventCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstEventCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEventCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstEventCommands.FormattingEnabled = true;
            this.lstEventCommands.HorizontalScrollbar = true;
            this.lstEventCommands.Items.AddRange(new object[] {
            "@>"});
            this.lstEventCommands.Location = new System.Drawing.Point(6, 19);
            this.lstEventCommands.Name = "lstEventCommands";
            this.lstEventCommands.Size = new System.Drawing.Size(445, 457);
            this.lstEventCommands.TabIndex = 0;
            this.lstEventCommands.SelectedIndexChanged += new System.EventHandler(this.lstEventCommands_SelectedIndexChanged);
            this.lstEventCommands.DoubleClick += new System.EventHandler(this.lstEventCommands_DoubleClick);
            this.lstEventCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEventCommands_KeyDown);
            this.lstEventCommands.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstEventCommands_Click);
            // 
            // grpCreateCommands
            // 
            this.grpCreateCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCreateCommands.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCreateCommands.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCreateCommands.Location = new System.Drawing.Point(353, 89);
            this.grpCreateCommands.Name = "grpCreateCommands";
            this.grpCreateCommands.Size = new System.Drawing.Size(457, 484);
            this.grpCreateCommands.TabIndex = 8;
            this.grpCreateCommands.TabStop = false;
            this.grpCreateCommands.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(628, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(93, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(727, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(93, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // commandMenu
            // 
            this.commandMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.commandMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.commandMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.btnDelete});
            this.commandMenu.Name = "commandMenu";
            this.commandMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.commandMenu.Size = new System.Drawing.Size(108, 136);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(107, 22);
            this.btnInsert.Text = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCut
            // 
            this.btnCut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(107, 22);
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(107, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(107, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpPageOptions
            // 
            this.grpPageOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpPageOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPageOptions.Controls.Add(this.btnClearPage);
            this.grpPageOptions.Controls.Add(this.btnDeletePage);
            this.grpPageOptions.Controls.Add(this.btnPastePage);
            this.grpPageOptions.Controls.Add(this.btnCopyPage);
            this.grpPageOptions.Controls.Add(this.btnNewPage);
            this.grpPageOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPageOptions.Location = new System.Drawing.Point(313, 5);
            this.grpPageOptions.Name = "grpPageOptions";
            this.grpPageOptions.Size = new System.Drawing.Size(510, 50);
            this.grpPageOptions.TabIndex = 13;
            this.grpPageOptions.TabStop = false;
            this.grpPageOptions.Text = "Page Options";
            // 
            // btnClearPage
            // 
            this.btnClearPage.Location = new System.Drawing.Point(402, 16);
            this.btnClearPage.Name = "btnClearPage";
            this.btnClearPage.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearPage.Size = new System.Drawing.Size(93, 30);
            this.btnClearPage.TabIndex = 17;
            this.btnClearPage.Text = "Clear Page";
            this.btnClearPage.Click += new System.EventHandler(this.btnClearPage_Click);
            // 
            // btnDeletePage
            // 
            this.btnDeletePage.Enabled = false;
            this.btnDeletePage.Location = new System.Drawing.Point(303, 16);
            this.btnDeletePage.Name = "btnDeletePage";
            this.btnDeletePage.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeletePage.Size = new System.Drawing.Size(93, 30);
            this.btnDeletePage.TabIndex = 16;
            this.btnDeletePage.Text = "Delete Page";
            this.btnDeletePage.Click += new System.EventHandler(this.btnDeletePage_Click);
            // 
            // btnPastePage
            // 
            this.btnPastePage.Location = new System.Drawing.Point(204, 16);
            this.btnPastePage.Name = "btnPastePage";
            this.btnPastePage.Padding = new System.Windows.Forms.Padding(5);
            this.btnPastePage.Size = new System.Drawing.Size(93, 30);
            this.btnPastePage.TabIndex = 15;
            this.btnPastePage.Text = "Paste Page";
            this.btnPastePage.Click += new System.EventHandler(this.btnPastePage_Click);
            // 
            // btnCopyPage
            // 
            this.btnCopyPage.Location = new System.Drawing.Point(105, 16);
            this.btnCopyPage.Name = "btnCopyPage";
            this.btnCopyPage.Padding = new System.Windows.Forms.Padding(5);
            this.btnCopyPage.Size = new System.Drawing.Size(93, 30);
            this.btnCopyPage.TabIndex = 14;
            this.btnCopyPage.Text = "Copy Page";
            this.btnCopyPage.Click += new System.EventHandler(this.btnCopyPage_Click);
            // 
            // btnNewPage
            // 
            this.btnNewPage.Location = new System.Drawing.Point(6, 16);
            this.btnNewPage.Name = "btnNewPage";
            this.btnNewPage.Padding = new System.Windows.Forms.Padding(5);
            this.btnNewPage.Size = new System.Drawing.Size(93, 30);
            this.btnNewPage.TabIndex = 13;
            this.btnNewPage.Text = "New Page";
            this.btnNewPage.Click += new System.EventHandler(this.btnNewPage_Click);
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.btnRelations);
            this.grpGeneral.Controls.Add(this.chkIsGlobal);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtEventname);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(12, 5);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(295, 49);
            this.grpGeneral.TabIndex = 18;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // btnRelations
            // 
            this.btnRelations.Location = new System.Drawing.Point(200, 8);
            this.btnRelations.Name = "btnRelations";
            this.btnRelations.Padding = new System.Windows.Forms.Padding(5);
            this.btnRelations.Size = new System.Drawing.Size(93, 20);
            this.btnRelations.TabIndex = 14;
            this.btnRelations.Text = "View Relations";
            this.btnRelations.Click += new System.EventHandler(this.btnRelations_Click);
            // 
            // chkIsGlobal
            // 
            this.chkIsGlobal.AutoSize = true;
            this.chkIsGlobal.Location = new System.Drawing.Point(205, 30);
            this.chkIsGlobal.Name = "chkIsGlobal";
            this.chkIsGlobal.Size = new System.Drawing.Size(87, 17);
            this.chkIsGlobal.TabIndex = 3;
            this.chkIsGlobal.Text = "Global Event";
            this.chkIsGlobal.CheckedChanged += new System.EventHandler(this.chkIsGlobal_CheckedChanged);
            // 
            // pnlTabsContainer
            // 
            this.pnlTabsContainer.Controls.Add(this.pnlTabs);
            this.pnlTabsContainer.Location = new System.Drawing.Point(12, 61);
            this.pnlTabsContainer.Name = "pnlTabsContainer";
            this.pnlTabsContainer.Size = new System.Drawing.Size(811, 22);
            this.pnlTabsContainer.TabIndex = 22;
            // 
            // pnlTabs
            // 
            this.pnlTabs.AutoSize = true;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(811, 22);
            this.pnlTabs.TabIndex = 23;
            // 
            // btnTabsRight
            // 
            this.btnTabsRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabsRight.Location = new System.Drawing.Point(773, 61);
            this.btnTabsRight.Name = "btnTabsRight";
            this.btnTabsRight.Padding = new System.Windows.Forms.Padding(5);
            this.btnTabsRight.Size = new System.Drawing.Size(50, 23);
            this.btnTabsRight.TabIndex = 1;
            this.btnTabsRight.Text = ">";
            this.btnTabsRight.Click += new System.EventHandler(this.btnTabsRight_Click);
            // 
            // btnTabsLeft
            // 
            this.btnTabsLeft.Location = new System.Drawing.Point(12, 61);
            this.btnTabsLeft.Name = "btnTabsLeft";
            this.btnTabsLeft.Padding = new System.Windows.Forms.Padding(5);
            this.btnTabsLeft.Size = new System.Drawing.Size(50, 23);
            this.btnTabsLeft.TabIndex = 0;
            this.btnTabsLeft.Text = "<";
            this.btnTabsLeft.Click += new System.EventHandler(this.btnTabsLeft_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 498);
            this.panel1.TabIndex = 23;
            // 
            // grpCommentary
            // 
            this.grpCommentary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCommentary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCommentary.Controls.Add(this.txtCommentary);
            this.grpCommentary.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCommentary.Location = new System.Drawing.Point(12, 582);
            this.grpCommentary.Name = "grpCommentary";
            this.grpCommentary.Size = new System.Drawing.Size(610, 75);
            this.grpCommentary.TabIndex = 71;
            this.grpCommentary.TabStop = false;
            this.grpCommentary.Text = "Commentary";
            // 
            // txtCommentary
            // 
            this.txtCommentary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtCommentary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtCommentary.Location = new System.Drawing.Point(3, 16);
            this.txtCommentary.Multiline = true;
            this.txtCommentary.Name = "txtCommentary";
            this.txtCommentary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommentary.Size = new System.Drawing.Size(601, 54);
            this.txtCommentary.TabIndex = 61;
            this.txtCommentary.TextChanged += new System.EventHandler(this.txtCommentary_TextChanged);
            // 
            // FrmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(835, 661);
            this.Controls.Add(this.grpCommentary);
            this.Controls.Add(this.grpNewCommands);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.btnTabsRight);
            this.Controls.Add(this.btnTabsLeft);
            this.Controls.Add(this.grpEntityOptions);
            this.Controls.Add(this.grpEventConditions);
            this.Controls.Add(this.grpPageOptions);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlTabsContainer);
            this.Controls.Add(this.grpEventCommands);
            this.Controls.Add(this.grpCreateCommands);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEvent_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEvent_FormClosed);
            this.Load += new System.EventHandler(this.frmEvent_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmEvent_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEvent_KeyDown);
            this.grpEntityOptions.ResumeLayout(false);
            this.grpExtra.ResumeLayout(false);
            this.grpExtra.PerformLayout();
            this.grpInspector.ResumeLayout(false);
            this.grpInspector.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            this.grpPreview.PerformLayout();
            this.grpMovement.ResumeLayout(false);
            this.grpMovement.PerformLayout();
            this.grpTriggers.ResumeLayout(false);
            this.grpTriggers.PerformLayout();
            this.grpEventConditions.ResumeLayout(false);
            this.grpNewCommands.ResumeLayout(false);
            this.grpNewCommands.PerformLayout();
            this.grpEventCommands.ResumeLayout(false);
            this.commandMenu.ResumeLayout(false);
            this.grpPageOptions.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.pnlTabsContainer.ResumeLayout(false);
            this.pnlTabsContainer.PerformLayout();
            this.grpCommentary.ResumeLayout(false);
            this.grpCommentary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblName;
        private DarkTextBox txtEventname;
        private DarkGroupBox grpEventCommands;
        private ListBox lstEventCommands;
        private DarkGroupBox grpEventConditions;
        private DarkGroupBox grpExtra;
        private DarkGroupBox grpMovement;
        private DarkGroupBox grpInspector;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkComboBox cmbEventFreq;
        private DarkComboBox cmbEventSpeed;
        private Label lblFreq;
        private Label lblSpeed;
        private DarkButton btnSetRoute;
        private Label lblType;
        private DarkComboBox cmbMoveType;
        private DarkComboBox cmbTrigger;
        private DarkComboBox cmbLayering;
        private DarkCheckBox chkWalkThrough;
        private DarkGroupBox grpNewCommands;
        private DarkGroupBox grpCreateCommands;
        private ContextMenuStrip commandMenu;
        private ToolStripMenuItem btnInsert;
        private ToolStripMenuItem btnEdit;
        private ToolStripMenuItem btnDelete;
        private DarkCheckBox chkHideName;
        private DarkCheckBox chkDisableInspector;
        private DarkComboBox cmbPreviewFace;
        private Label lblFace;
        private DarkTextBox txtDesc;
        private DarkGroupBox grpPreview;
        private DarkGroupBox grpPageOptions;
        private DarkButton btnNewPage;
        private DarkButton btnCopyPage;
        private DarkButton btnPastePage;
        private DarkButton btnDeletePage;
        private DarkButton btnClearPage;
        private DarkGroupBox grpEntityOptions;
        private Label lblInspectorDesc;
        private Panel pnlPreview;
        private Panel pnlFacePreview;
        private DarkCheckBox chkWalkingAnimation;
        private DarkCheckBox chkDirectionFix;
        private DarkGroupBox grpGeneral;
        private Label lblAnimation;
        private DarkComboBox cmbAnimation;
        private DarkCheckBox chkIsGlobal;
        private Label lblLayer;
        private Label lblCloseCommands;
        private DarkCheckBox chkInteractionFreeze;
        private Label lblTriggerVal;
        private DarkComboBox cmbTriggerVal;
        private Panel pnlTabsContainer;
        private DarkGroupBox grpTriggers;
        private Panel panel1;
        private DarkButton btnTabsLeft;
        private DarkButton btnTabsRight;
        private Panel pnlTabs;
        private TreeView lstCommands;
        private DarkButton btnEditConditions;
        private DarkTextBox txtCommand;
        private Label lblCommand;
        private ToolStripMenuItem btnCut;
        private ToolStripMenuItem btnCopy;
        private ToolStripMenuItem btnPaste;
        private DarkComboBox cmbVariable;
        private Label lblVariableTrigger;
        private Label lblMapTrigger;
        private DarkButton btnMapTrigger;
        private DarkCheckBox chkCollideOnDash;
        private DarkButton btnRelations;
        private DarkCheckBox chkPvpStadium;
        private DarkGroupBox grpCommentary;
        private DarkTextBox txtCommentary;
    }
}