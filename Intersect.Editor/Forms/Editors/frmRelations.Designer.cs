namespace Intersect.Editor.Forms
{
    partial class FrmRelations
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
            this.treeViewItems = new DarkUI.Controls.DarkTreeView();
            this.SuspendLayout();
            // 
            // treeViewItems
            // 
            this.treeViewItems.Location = new System.Drawing.Point(12, 12);
            this.treeViewItems.MaxDragChange = 20;
            this.treeViewItems.Name = "treeViewItems";
            this.treeViewItems.Size = new System.Drawing.Size(313, 435);
            this.treeViewItems.TabIndex = 10;
            // 
            // FrmRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(337, 459);
            this.Controls.Add(this.treeViewItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relations";
            this.Load += new System.EventHandler(this.frmRelations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTreeView treeViewItems;
    }
}