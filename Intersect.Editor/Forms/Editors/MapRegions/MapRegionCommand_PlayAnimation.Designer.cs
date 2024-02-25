using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.MapRegions
{
    partial class MapRegionCommandPlayAnimation
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
            this.grpPlayAnimation = new DarkUI.Controls.DarkGroupBox();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.btnEditCmdConditions = new DarkUI.Controls.DarkButton();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.grpPlayAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayAnimation
            // 
            this.grpPlayAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpPlayAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPlayAnimation.Controls.Add(this.lblAnimation);
            this.grpPlayAnimation.Controls.Add(this.lblInstructions);
            this.grpPlayAnimation.Controls.Add(this.cmbAnimation);
            this.grpPlayAnimation.Controls.Add(this.btnEditCmdConditions);
            this.grpPlayAnimation.Controls.Add(this.btnCancel);
            this.grpPlayAnimation.Controls.Add(this.btnSave);
            this.grpPlayAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPlayAnimation.Location = new System.Drawing.Point(3, 3);
            this.grpPlayAnimation.Name = "grpPlayAnimation";
            this.grpPlayAnimation.Size = new System.Drawing.Size(316, 162);
            this.grpPlayAnimation.TabIndex = 17;
            this.grpPlayAnimation.TabStop = false;
            this.grpPlayAnimation.Text = "Play Animation:";
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
            this.cmbAnimation.Items.AddRange(new object[] {
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
            this.cmbAnimation.Location = new System.Drawing.Point(60, 100);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(250, 21);
            this.cmbAnimation.TabIndex = 55;
            this.cmbAnimation.Text = "None";
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
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
            this.lblInstructions.TabIndex = 57;
            this.lblInstructions.Text = "Animations are played on the entity infinitely while inside the region. ScreenEff" +
    "ects only for players and the Pending Duration is infinite while inside the regi" +
    "on";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Location = new System.Drawing.Point(4, 104);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(56, 13);
            this.lblAnimation.TabIndex = 58;
            this.lblAnimation.Text = "Animation:";
            // 
            // MapRegionCommandPlayAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpPlayAnimation);
            this.Name = "MapRegionCommandPlayAnimation";
            this.Size = new System.Drawing.Size(323, 170);
            this.grpPlayAnimation.ResumeLayout(false);
            this.grpPlayAnimation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpPlayAnimation;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkButton btnEditCmdConditions;
        private DarkComboBox cmbAnimation;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAnimation;
    }
}
