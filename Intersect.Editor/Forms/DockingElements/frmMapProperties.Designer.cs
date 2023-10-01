namespace Intersect.Editor.Forms.DockingElements
{
    partial class FrmMapProperties
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
            this.gridMapProperties = new System.Windows.Forms.PropertyGrid();
            this.btnCopyProperties = new DarkUI.Controls.DarkButton();
            this.btnPasteProperties = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // gridMapProperties
            // 
            this.gridMapProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMapProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.gridMapProperties.CategoryForeColor = System.Drawing.Color.Gainsboro;
            this.gridMapProperties.CategorySplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridMapProperties.CommandsBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridMapProperties.CommandsForeColor = System.Drawing.Color.Gainsboro;
            this.gridMapProperties.CommandsVisibleIfAvailable = false;
            this.gridMapProperties.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.gridMapProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMapProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.gridMapProperties.HelpBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridMapProperties.HelpForeColor = System.Drawing.Color.Gainsboro;
            this.gridMapProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.gridMapProperties.Location = new System.Drawing.Point(0, 0);
            this.gridMapProperties.Name = "gridMapProperties";
            this.gridMapProperties.Size = new System.Drawing.Size(201, 181);
            this.gridMapProperties.TabIndex = 0;
            this.gridMapProperties.ToolbarVisible = false;
            this.gridMapProperties.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.gridMapProperties.ViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridMapProperties.ViewForeColor = System.Drawing.Color.Gainsboro;
            // 
            // btnCopyProperties
            // 
            this.btnCopyProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCopyProperties.Location = new System.Drawing.Point(0, 181);
            this.btnCopyProperties.Name = "btnCopyProperties";
            this.btnCopyProperties.Padding = new System.Windows.Forms.Padding(5);
            this.btnCopyProperties.Size = new System.Drawing.Size(100, 25);
            this.btnCopyProperties.TabIndex = 14;
            this.btnCopyProperties.Text = "Copy Properties";
            this.btnCopyProperties.Click += new System.EventHandler(this.btnCopyProperties_Click);
            // 
            // btnPasteProperties
            // 
            this.btnPasteProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPasteProperties.Location = new System.Drawing.Point(101, 181);
            this.btnPasteProperties.Name = "btnPasteProperties";
            this.btnPasteProperties.Padding = new System.Windows.Forms.Padding(5);
            this.btnPasteProperties.Size = new System.Drawing.Size(100, 25);
            this.btnPasteProperties.TabIndex = 15;
            this.btnPasteProperties.Text = "Paste Properties";
            this.btnPasteProperties.Click += new System.EventHandler(this.btnPasteProperties_Click);
            // 
            // FrmMapProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(199, 206);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.btnPasteProperties);
            this.Controls.Add(this.btnCopyProperties);
            this.Controls.Add(this.gridMapProperties);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMapProperties";
            this.Text = "Map Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid gridMapProperties;
        private DarkUI.Controls.DarkButton btnCopyProperties;
        private DarkUI.Controls.DarkButton btnPasteProperties;
    }
}