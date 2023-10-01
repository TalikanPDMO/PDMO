using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Quest
{
    partial class QuestTaskAlternativesEditor
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
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNoTaskAlternative = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.btnRemoveAlternative = new DarkUI.Controls.DarkButton();
            this.btnNewAlternative = new DarkUI.Controls.DarkButton();
            this.btnEditTaskAlternativeEvent = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.cmbTaskAlternatives = new DarkUI.Controls.DarkComboBox();
            this.lblAlternatives = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.grpAlternativeTasks = new DarkUI.Controls.DarkGroupBox();
            this.lblNoAvailableTask = new System.Windows.Forms.Label();
            this.cmbTaskOrTaskLink = new DarkUI.Controls.DarkComboBox();
            this.lblTaskOrTaskLink = new System.Windows.Forms.Label();
            this.btnRemoveTask = new DarkUI.Controls.DarkButton();
            this.btnAddTask = new DarkUI.Controls.DarkButton();
            this.lstTasksOrTaskLinks = new System.Windows.Forms.ListBox();
            this.grpEditor.SuspendLayout();
            this.grpAlternativeTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditor
            // 
            this.grpEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEditor.Controls.Add(this.txtDesc);
            this.grpEditor.Controls.Add(this.lblDesc);
            this.grpEditor.Controls.Add(this.lblNoTaskAlternative);
            this.grpEditor.Controls.Add(this.lblName);
            this.grpEditor.Controls.Add(this.txtName);
            this.grpEditor.Controls.Add(this.btnRemoveAlternative);
            this.grpEditor.Controls.Add(this.btnNewAlternative);
            this.grpEditor.Controls.Add(this.btnEditTaskAlternativeEvent);
            this.grpEditor.Controls.Add(this.btnSave);
            this.grpEditor.Controls.Add(this.cmbTaskAlternatives);
            this.grpEditor.Controls.Add(this.lblAlternatives);
            this.grpEditor.Controls.Add(this.btnCancel);
            this.grpEditor.Controls.Add(this.grpAlternativeTasks);
            this.grpEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEditor.Location = new System.Drawing.Point(0, 2);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(265, 420);
            this.grpEditor.TabIndex = 18;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "TaskAlternatives Editor";
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = true;
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(53, 98);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(201, 66);
            this.txtDesc.TabIndex = 37;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 122);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 36;
            this.lblDesc.Text = "Desc:";
            // 
            // lblNoTaskAlternative
            // 
            this.lblNoTaskAlternative.AutoSize = true;
            this.lblNoTaskAlternative.Location = new System.Drawing.Point(65, 22);
            this.lblNoTaskAlternative.Name = "lblNoTaskAlternative";
            this.lblNoTaskAlternative.Size = new System.Drawing.Size(197, 13);
            this.lblNoTaskAlternative.TabIndex = 35;
            this.lblNoTaskAlternative.Text = "Currently no task alternative in this quest";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 74);
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
            this.txtName.Location = new System.Drawing.Point(53, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 33;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnRemoveAlternative
            // 
            this.btnRemoveAlternative.Location = new System.Drawing.Point(170, 43);
            this.btnRemoveAlternative.Name = "btnRemoveAlternative";
            this.btnRemoveAlternative.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveAlternative.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAlternative.TabIndex = 32;
            this.btnRemoveAlternative.Text = "Remove";
            this.btnRemoveAlternative.Click += new System.EventHandler(this.btnRemoveAlternative_Click);
            // 
            // btnNewAlternative
            // 
            this.btnNewAlternative.Location = new System.Drawing.Point(72, 43);
            this.btnNewAlternative.Name = "btnNewAlternative";
            this.btnNewAlternative.Padding = new System.Windows.Forms.Padding(5);
            this.btnNewAlternative.Size = new System.Drawing.Size(75, 23);
            this.btnNewAlternative.TabIndex = 31;
            this.btnNewAlternative.Text = "New";
            this.btnNewAlternative.Click += new System.EventHandler(this.btnNewAlternative_Click);
            // 
            // btnEditTaskAlternativeEvent
            // 
            this.btnEditTaskAlternativeEvent.Location = new System.Drawing.Point(15, 362);
            this.btnEditTaskAlternativeEvent.Name = "btnEditTaskAlternativeEvent";
            this.btnEditTaskAlternativeEvent.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditTaskAlternativeEvent.Size = new System.Drawing.Size(236, 23);
            this.btnEditTaskAlternativeEvent.TabIndex = 30;
            this.btnEditTaskAlternativeEvent.Text = "Edit Alternative Completion Event";
            this.btnEditTaskAlternativeEvent.Click += new System.EventHandler(this.btnEditTaskAlternativeEvent_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTaskAlternatives
            // 
            this.cmbTaskAlternatives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTaskAlternatives.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTaskAlternatives.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTaskAlternatives.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTaskAlternatives.DrawDropdownHoverOutline = false;
            this.cmbTaskAlternatives.DrawFocusRectangle = false;
            this.cmbTaskAlternatives.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskAlternatives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskAlternatives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaskAlternatives.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTaskAlternatives.FormattingEnabled = true;
            this.cmbTaskAlternatives.Items.AddRange(new object[] {
            "Alternative name 1",
            "Alternative name 2",
            "Alternative name 3"});
            this.cmbTaskAlternatives.Location = new System.Drawing.Point(80, 18);
            this.cmbTaskAlternatives.Name = "cmbTaskAlternatives";
            this.cmbTaskAlternatives.Size = new System.Drawing.Size(173, 21);
            this.cmbTaskAlternatives.TabIndex = 22;
            this.cmbTaskAlternatives.Text = "Alternative name 1";
            this.cmbTaskAlternatives.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTaskAlternatives.SelectedIndexChanged += new System.EventHandler(this.cmbTaskAlternatives_SelectedIndexChanged);
            // 
            // lblAlternatives
            // 
            this.lblAlternatives.AutoSize = true;
            this.lblAlternatives.Location = new System.Drawing.Point(9, 22);
            this.lblAlternatives.Name = "lblAlternatives";
            this.lblAlternatives.Size = new System.Drawing.Size(54, 13);
            this.lblAlternatives.TabIndex = 21;
            this.lblAlternatives.Text = "Task Alts:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(96, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAlternativeTasks
            // 
            this.grpAlternativeTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAlternativeTasks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAlternativeTasks.Controls.Add(this.lblNoAvailableTask);
            this.grpAlternativeTasks.Controls.Add(this.cmbTaskOrTaskLink);
            this.grpAlternativeTasks.Controls.Add(this.lblTaskOrTaskLink);
            this.grpAlternativeTasks.Controls.Add(this.btnRemoveTask);
            this.grpAlternativeTasks.Controls.Add(this.btnAddTask);
            this.grpAlternativeTasks.Controls.Add(this.lstTasksOrTaskLinks);
            this.grpAlternativeTasks.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAlternativeTasks.Location = new System.Drawing.Point(15, 171);
            this.grpAlternativeTasks.Name = "grpAlternativeTasks";
            this.grpAlternativeTasks.Size = new System.Drawing.Size(236, 185);
            this.grpAlternativeTasks.TabIndex = 28;
            this.grpAlternativeTasks.TabStop = false;
            this.grpAlternativeTasks.Text = "Alternative Tasks";
            this.grpAlternativeTasks.Visible = false;
            // 
            // lblNoAvailableTask
            // 
            this.lblNoAvailableTask.AutoSize = true;
            this.lblNoAvailableTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAvailableTask.Location = new System.Drawing.Point(3, 125);
            this.lblNoAvailableTask.Name = "lblNoAvailableTask";
            this.lblNoAvailableTask.Size = new System.Drawing.Size(231, 13);
            this.lblNoAvailableTask.TabIndex = 36;
            this.lblNoAvailableTask.Text = "No task/tasklink available for a TaskAlternative";
            this.lblNoAvailableTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTaskOrTaskLink
            // 
            this.cmbTaskOrTaskLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTaskOrTaskLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTaskOrTaskLink.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTaskOrTaskLink.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTaskOrTaskLink.DrawDropdownHoverOutline = false;
            this.cmbTaskOrTaskLink.DrawFocusRectangle = false;
            this.cmbTaskOrTaskLink.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskOrTaskLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskOrTaskLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaskOrTaskLink.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTaskOrTaskLink.FormattingEnabled = true;
            this.cmbTaskOrTaskLink.Location = new System.Drawing.Point(17, 120);
            this.cmbTaskOrTaskLink.Name = "cmbTaskOrTaskLink";
            this.cmbTaskOrTaskLink.Size = new System.Drawing.Size(213, 21);
            this.cmbTaskOrTaskLink.TabIndex = 48;
            this.cmbTaskOrTaskLink.Text = null;
            this.cmbTaskOrTaskLink.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblTaskOrTaskLink
            // 
            this.lblTaskOrTaskLink.AutoSize = true;
            this.lblTaskOrTaskLink.Location = new System.Drawing.Point(14, 104);
            this.lblTaskOrTaskLink.Name = "lblTaskOrTaskLink";
            this.lblTaskOrTaskLink.Size = new System.Drawing.Size(93, 13);
            this.lblTaskOrTaskLink.TabIndex = 47;
            this.lblTaskOrTaskLink.Text = "Task or TaskLink:";
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
            // lstTasksOrTaskLinks
            // 
            this.lstTasksOrTaskLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstTasksOrTaskLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTasksOrTaskLinks.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstTasksOrTaskLinks.FormattingEnabled = true;
            this.lstTasksOrTaskLinks.Location = new System.Drawing.Point(10, 19);
            this.lstTasksOrTaskLinks.Name = "lstTasksOrTaskLinks";
            this.lstTasksOrTaskLinks.Size = new System.Drawing.Size(220, 80);
            this.lstTasksOrTaskLinks.TabIndex = 44;
            // 
            // QuestTaskAlternativesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpEditor);
            this.Name = "QuestTaskAlternativesEditor";
            this.Size = new System.Drawing.Size(268, 422);
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.grpAlternativeTasks.ResumeLayout(false);
            this.grpAlternativeTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpEditor;
        private DarkButton btnSave;
        private DarkComboBox cmbTaskAlternatives;
        private System.Windows.Forms.Label lblAlternatives;
        private DarkButton btnCancel;
        private DarkGroupBox grpAlternativeTasks;
        private DarkButton btnEditTaskAlternativeEvent;
        private DarkButton btnRemoveAlternative;
        private DarkButton btnNewAlternative;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkComboBox cmbTaskOrTaskLink;
        private System.Windows.Forms.Label lblTaskOrTaskLink;
        private DarkButton btnRemoveTask;
        private DarkButton btnAddTask;
        private System.Windows.Forms.ListBox lstTasksOrTaskLinks;
        private System.Windows.Forms.Label lblNoTaskAlternative;
        private System.Windows.Forms.Label lblNoAvailableTask;
        private DarkTextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
    }
}
