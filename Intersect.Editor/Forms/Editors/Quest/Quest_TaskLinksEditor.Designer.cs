using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Quest
{
    partial class QuestTaskLinksEditor
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
            this.grpEditor = new DarkUI.Controls.DarkGroupBox();
            this.lblNoTaskLink = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.btnRemoveLink = new DarkUI.Controls.DarkButton();
            this.btnNewLink = new DarkUI.Controls.DarkButton();
            this.btnEditTaskLinkEvent = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.cmbTaskLinks = new DarkUI.Controls.DarkComboBox();
            this.lblLinks = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.grpLinkedTasks = new DarkUI.Controls.DarkGroupBox();
            this.lblNoAvailableTask = new System.Windows.Forms.Label();
            this.cmbTask = new DarkUI.Controls.DarkComboBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnRemoveTask = new DarkUI.Controls.DarkButton();
            this.btnAddTask = new DarkUI.Controls.DarkButton();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.grpEditor.SuspendLayout();
            this.grpLinkedTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditor
            // 
            this.grpEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEditor.Controls.Add(this.txtDesc);
            this.grpEditor.Controls.Add(this.lblDesc);
            this.grpEditor.Controls.Add(this.lblNoTaskLink);
            this.grpEditor.Controls.Add(this.lblName);
            this.grpEditor.Controls.Add(this.txtName);
            this.grpEditor.Controls.Add(this.btnRemoveLink);
            this.grpEditor.Controls.Add(this.btnNewLink);
            this.grpEditor.Controls.Add(this.btnEditTaskLinkEvent);
            this.grpEditor.Controls.Add(this.btnSave);
            this.grpEditor.Controls.Add(this.cmbTaskLinks);
            this.grpEditor.Controls.Add(this.lblLinks);
            this.grpEditor.Controls.Add(this.btnCancel);
            this.grpEditor.Controls.Add(this.grpLinkedTasks);
            this.grpEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEditor.Location = new System.Drawing.Point(0, 2);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(255, 420);
            this.grpEditor.TabIndex = 18;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "TaskLinks Editor";
            // 
            // lblNoTaskLink
            // 
            this.lblNoTaskLink.AutoSize = true;
            this.lblNoTaskLink.Location = new System.Drawing.Point(76, 22);
            this.lblNoTaskLink.Name = "lblNoTaskLink";
            this.lblNoTaskLink.Size = new System.Drawing.Size(164, 13);
            this.lblNoTaskLink.TabIndex = 35;
            this.lblNoTaskLink.Text = "Currently no task link in this quest";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(72, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 33;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnRemoveLink
            // 
            this.btnRemoveLink.Location = new System.Drawing.Point(170, 43);
            this.btnRemoveLink.Name = "btnRemoveLink";
            this.btnRemoveLink.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveLink.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveLink.TabIndex = 32;
            this.btnRemoveLink.Text = "Remove";
            this.btnRemoveLink.Click += new System.EventHandler(this.btnRemoveLink_Click);
            // 
            // btnNewLink
            // 
            this.btnNewLink.Location = new System.Drawing.Point(72, 43);
            this.btnNewLink.Name = "btnNewLink";
            this.btnNewLink.Padding = new System.Windows.Forms.Padding(5);
            this.btnNewLink.Size = new System.Drawing.Size(75, 23);
            this.btnNewLink.TabIndex = 31;
            this.btnNewLink.Text = "New";
            this.btnNewLink.Click += new System.EventHandler(this.btnNewLink_Click);
            // 
            // btnEditTaskLinkEvent
            // 
            this.btnEditTaskLinkEvent.Location = new System.Drawing.Point(10, 361);
            this.btnEditTaskLinkEvent.Name = "btnEditTaskLinkEvent";
            this.btnEditTaskLinkEvent.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditTaskLinkEvent.Size = new System.Drawing.Size(236, 23);
            this.btnEditTaskLinkEvent.TabIndex = 30;
            this.btnEditTaskLinkEvent.Text = "Edit Link Completion Event";
            this.btnEditTaskLinkEvent.Click += new System.EventHandler(this.btnEditTaskLinkEvent_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTaskLinks
            // 
            this.cmbTaskLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTaskLinks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTaskLinks.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTaskLinks.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTaskLinks.DrawDropdownHoverOutline = false;
            this.cmbTaskLinks.DrawFocusRectangle = false;
            this.cmbTaskLinks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskLinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaskLinks.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTaskLinks.FormattingEnabled = true;
            this.cmbTaskLinks.Items.AddRange(new object[] {
            "Link name 1",
            "Link name 2",
            "Link name 3"});
            this.cmbTaskLinks.Location = new System.Drawing.Point(72, 18);
            this.cmbTaskLinks.Name = "cmbTaskLinks";
            this.cmbTaskLinks.Size = new System.Drawing.Size(173, 21);
            this.cmbTaskLinks.TabIndex = 22;
            this.cmbTaskLinks.Text = "Link name 1";
            this.cmbTaskLinks.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTaskLinks.SelectedIndexChanged += new System.EventHandler(this.cmbTaskLinks_SelectedIndexChanged);
            // 
            // lblLinks
            // 
            this.lblLinks.AutoSize = true;
            this.lblLinks.Location = new System.Drawing.Point(4, 22);
            this.lblLinks.Name = "lblLinks";
            this.lblLinks.Size = new System.Drawing.Size(62, 13);
            this.lblLinks.TabIndex = 21;
            this.lblLinks.Text = "Task Links:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpLinkedTasks
            // 
            this.grpLinkedTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpLinkedTasks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLinkedTasks.Controls.Add(this.lblNoAvailableTask);
            this.grpLinkedTasks.Controls.Add(this.cmbTask);
            this.grpLinkedTasks.Controls.Add(this.lblTask);
            this.grpLinkedTasks.Controls.Add(this.btnRemoveTask);
            this.grpLinkedTasks.Controls.Add(this.btnAddTask);
            this.grpLinkedTasks.Controls.Add(this.lstTasks);
            this.grpLinkedTasks.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLinkedTasks.Location = new System.Drawing.Point(10, 170);
            this.grpLinkedTasks.Name = "grpLinkedTasks";
            this.grpLinkedTasks.Size = new System.Drawing.Size(236, 185);
            this.grpLinkedTasks.TabIndex = 28;
            this.grpLinkedTasks.TabStop = false;
            this.grpLinkedTasks.Text = "Linked Tasks";
            this.grpLinkedTasks.Visible = false;
            // 
            // lblNoAvailableTask
            // 
            this.lblNoAvailableTask.AutoSize = true;
            this.lblNoAvailableTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAvailableTask.Location = new System.Drawing.Point(26, 125);
            this.lblNoAvailableTask.Name = "lblNoAvailableTask";
            this.lblNoAvailableTask.Size = new System.Drawing.Size(199, 13);
            this.lblNoAvailableTask.TabIndex = 36;
            this.lblNoAvailableTask.Text = "There is no available task for a TaskLink";
            this.lblNoAvailableTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTask
            // 
            this.cmbTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTask.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTask.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTask.DrawDropdownHoverOutline = false;
            this.cmbTask.DrawFocusRectangle = false;
            this.cmbTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTask.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(17, 120);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(213, 21);
            this.cmbTask.TabIndex = 48;
            this.cmbTask.Text = null;
            this.cmbTask.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(14, 104);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(34, 13);
            this.lblTask.TabIndex = 47;
            this.lblTask.Text = "Task:";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(126, 148);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 46;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(45, 148);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 45;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTasks.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(10, 19);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(220, 80);
            this.lstTasks.TabIndex = 44;
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = true;
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(72, 98);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(173, 66);
            this.txtDesc.TabIndex = 37;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(17, 122);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 36;
            this.lblDesc.Text = "Desc:";
            // 
            // QuestTaskLinksEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpEditor);
            this.Name = "QuestTaskLinksEditor";
            this.Size = new System.Drawing.Size(255, 422);
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.grpLinkedTasks.ResumeLayout(false);
            this.grpLinkedTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpEditor;
        private DarkButton btnSave;
        private DarkComboBox cmbTaskLinks;
        private System.Windows.Forms.Label lblLinks;
        private DarkButton btnCancel;
        private DarkGroupBox grpLinkedTasks;
        private DarkButton btnEditTaskLinkEvent;
        private DarkButton btnRemoveLink;
        private DarkButton btnNewLink;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkComboBox cmbTask;
        private System.Windows.Forms.Label lblTask;
        private DarkButton btnRemoveTask;
        private DarkButton btnAddTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblNoTaskLink;
        private System.Windows.Forms.Label lblNoAvailableTask;
        private DarkTextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
    }
}
