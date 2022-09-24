namespace GoogleTranslateBrowserApp
{
    partial class GTApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GTApp));
            this.webPanel = new System.Windows.Forms.Panel();
            this.reloadButton = new System.Windows.Forms.Button();
            this.webPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webPanel
            // 
            this.webPanel.Controls.Add(this.reloadButton);
            this.webPanel.Location = new System.Drawing.Point(12, 12);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(776, 426);
            this.webPanel.TabIndex = 0;
            this.webPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.webPanel_Paint);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(0, 403);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 0;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // GTApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.webPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GTApp";
            this.Text = "Google Translate App NOT GOOGLE OFFICIAL ";
            this.Load += new System.EventHandler(this.GTApp_Load);
            this.webPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel webPanel;
        private Button reloadButton;
    }
}