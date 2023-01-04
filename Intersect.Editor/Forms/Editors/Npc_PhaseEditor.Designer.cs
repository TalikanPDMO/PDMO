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
            this.grpPhaseConditions = new DarkUI.Controls.DarkGroupBox();
            this.btnEditConditions = new DarkUI.Controls.DarkButton();
            this.chkReplaceSpells = new DarkUI.Controls.DarkCheckBox();
            this.grpSpells.SuspendLayout();
            this.grpEditor.SuspendLayout();
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
            this.grpSpells.Location = new System.Drawing.Point(10, 170);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Size = new System.Drawing.Size(236, 185);
            this.grpSpells.TabIndex = 28;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells";
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
            this.cmbSpell.Size = new System.Drawing.Size(224, 21);
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
            this.btnRemoveSpell.Location = new System.Drawing.Point(126, 158);
            this.btnRemoveSpell.Name = "btnRemoveSpell";
            this.btnRemoveSpell.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveSpell.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSpell.TabIndex = 46;
            this.btnRemoveSpell.Text = "Remove";
            this.btnRemoveSpell.Click += new System.EventHandler(this.btnRemoveSpell_Click);
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.Location = new System.Drawing.Point(45, 158);
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
            this.lstSpells.Size = new System.Drawing.Size(224, 80);
            this.lstSpells.TabIndex = 44;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
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
            this.grpEditor.Size = new System.Drawing.Size(374, 420);
            this.grpEditor.TabIndex = 18;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "Phase Editor";
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
            // chkReplaceSpells
            // 
            this.chkReplaceSpells.AutoSize = true;
            this.chkReplaceSpells.Location = new System.Drawing.Point(50, 13);
            this.chkReplaceSpells.Name = "chkReplaceSpells";
            this.chkReplaceSpells.Size = new System.Drawing.Size(152, 17);
            this.chkReplaceSpells.TabIndex = 49;
            this.chkReplaceSpells.Text = "Replace all known spells ?";
            // 
            // NpcPhaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpEditor);
            this.Name = "NpcPhaseEditor";
            this.Size = new System.Drawing.Size(391, 451);
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
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
    }
}
