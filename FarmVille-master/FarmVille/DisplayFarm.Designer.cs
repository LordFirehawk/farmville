namespace FarmVille
{
    partial class DisplayFarm
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
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(212, 206);
            this.DisplayPanel.TabIndex = 1;
            // 
            // DisplayFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.DisplayPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DisplayFarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Display Farm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DisplayPanel;
    }
}