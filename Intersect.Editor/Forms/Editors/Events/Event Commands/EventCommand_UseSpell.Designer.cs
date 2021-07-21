
namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandUseSpell
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpUseSpell = new DarkUI.Controls.DarkGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTarget = new DarkUI.Controls.DarkComboBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.cmbSource = new DarkUI.Controls.DarkComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.label3 = new System.Windows.Forms.Label();
            this.grpUseSpell.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUseSpell
            // 
            this.grpUseSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpUseSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpUseSpell.Controls.Add(this.label3);
            this.grpUseSpell.Controls.Add(this.label2);
            this.grpUseSpell.Controls.Add(this.label1);
            this.grpUseSpell.Controls.Add(this.cmbTarget);
            this.grpUseSpell.Controls.Add(this.lblTarget);
            this.grpUseSpell.Controls.Add(this.cmbSpell);
            this.grpUseSpell.Controls.Add(this.lblSpell);
            this.grpUseSpell.Controls.Add(this.cmbSource);
            this.grpUseSpell.Controls.Add(this.lblSource);
            this.grpUseSpell.Controls.Add(this.btnCancel);
            this.grpUseSpell.Controls.Add(this.btnSave);
            this.grpUseSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpUseSpell.Location = new System.Drawing.Point(3, 4);
            this.grpUseSpell.Name = "grpUseSpell";
            this.grpUseSpell.Size = new System.Drawing.Size(257, 240);
            this.grpUseSpell.TabIndex = 18;
            this.grpUseSpell.TabStop = false;
            this.grpUseSpell.Text = "Use Spell:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rule 2 : If source is an event, damage are fixed. If\r\n source is the player, dama" +
    "ge can scale.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Rule 1 : Casting time and cooldown are not taken\r\n into account, we cast directly" +
    " the spell.";
            // 
            // cmbTarget
            // 
            this.cmbTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTarget.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTarget.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTarget.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTarget.DrawDropdownHoverOutline = false;
            this.cmbTarget.DrawFocusRectangle = false;
            this.cmbTarget.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTarget.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(64, 175);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(161, 21);
            this.cmbTarget.TabIndex = 26;
            this.cmbTarget.Text = null;
            this.cmbTarget.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(5, 177);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 25;
            this.lblTarget.Text = "Target:";
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
            this.cmbSpell.Location = new System.Drawing.Point(64, 118);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(161, 21);
            this.cmbSpell.TabIndex = 24;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(5, 120);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(33, 13);
            this.lblSpell.TabIndex = 23;
            this.lblSpell.Text = "Spell:";
            // 
            // cmbSource
            // 
            this.cmbSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSource.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSource.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSource.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSource.DrawDropdownHoverOutline = false;
            this.cmbSource.DrawFocusRectangle = false;
            this.cmbSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSource.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(64, 146);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(161, 21);
            this.cmbSource.TabIndex = 22;
            this.cmbSource.Text = null;
            this.cmbSource.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(5, 148);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 21;
            this.lblSource.Text = "Source:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(131, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Rule 3 : The spell range is taken into account.";
            // 
            // EventCommandUseSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpUseSpell);
            this.Name = "EventCommandUseSpell";
            this.Size = new System.Drawing.Size(264, 251);
            this.grpUseSpell.ResumeLayout(false);
            this.grpUseSpell.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox grpUseSpell;
        private DarkUI.Controls.DarkComboBox cmbSpell;
        private System.Windows.Forms.Label lblSpell;
        private DarkUI.Controls.DarkComboBox cmbSource;
        private System.Windows.Forms.Label lblSource;
        private DarkUI.Controls.DarkButton btnCancel;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkComboBox cmbTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
