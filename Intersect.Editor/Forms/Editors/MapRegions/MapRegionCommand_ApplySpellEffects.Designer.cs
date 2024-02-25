using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.MapRegions
{
    partial class MapRegionCommandApplySpellEffects
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
            this.grpApplySpellEffects = new DarkUI.Controls.DarkGroupBox();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.btnEditCmdConditions = new DarkUI.Controls.DarkButton();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSpell = new System.Windows.Forms.Label();
            this.grpApplySpellEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpApplySpellEffects
            // 
            this.grpApplySpellEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpApplySpellEffects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpApplySpellEffects.Controls.Add(this.lblSpell);
            this.grpApplySpellEffects.Controls.Add(this.lblInstructions);
            this.grpApplySpellEffects.Controls.Add(this.cmbSpell);
            this.grpApplySpellEffects.Controls.Add(this.btnEditCmdConditions);
            this.grpApplySpellEffects.Controls.Add(this.btnCancel);
            this.grpApplySpellEffects.Controls.Add(this.btnSave);
            this.grpApplySpellEffects.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpApplySpellEffects.Location = new System.Drawing.Point(3, 3);
            this.grpApplySpellEffects.Name = "grpApplySpellEffects";
            this.grpApplySpellEffects.Size = new System.Drawing.Size(316, 162);
            this.grpApplySpellEffects.TabIndex = 17;
            this.grpApplySpellEffects.TabStop = false;
            this.grpApplySpellEffects.Text = "Apply Spell Effects:";
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
            this.cmbSpell.Items.AddRange(new object[] {
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
            this.cmbSpell.Location = new System.Drawing.Point(39, 100);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(270, 21);
            this.cmbSpell.TabIndex = 55;
            this.cmbSpell.Text = "None";
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // btnEditCmdConditions
            // 
            this.btnEditCmdConditions.Location = new System.Drawing.Point(55, 71);
            this.btnEditCmdConditions.Name = "btnEditCmdConditions";
            this.btnEditCmdConditions.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditCmdConditions.Size = new System.Drawing.Size(213, 23);
            this.btnEditCmdConditions.TabIndex = 54;
            this.btnEditCmdConditions.Text = "Edit Command Conditions (None)";
            this.btnEditCmdConditions.Click += new System.EventHandler(this.btnEditCmdConditions_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(4, 23);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(308, 41);
            this.lblInstructions.TabIndex = 56;
            this.lblInstructions.Text = "Only take into account DoT/HoT, Stats Buffs and Extra Effects. %Chance are always" +
    " 100% and Duration are infinite while inside the region (Tick Duration is needed" +
    " if HoT/DoT)";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(4, 104);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(33, 13);
            this.lblSpell.TabIndex = 57;
            this.lblSpell.Text = "Spell:";
            // 
            // MapRegionCommandApplySpellEffects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpApplySpellEffects);
            this.Name = "MapRegionCommandApplySpellEffects";
            this.Size = new System.Drawing.Size(322, 168);
            this.grpApplySpellEffects.ResumeLayout(false);
            this.grpApplySpellEffects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpApplySpellEffects;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkButton btnEditCmdConditions;
        private DarkComboBox cmbSpell;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSpell;
    }
}
