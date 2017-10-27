namespace HTMLEditorClient
{
    partial class frmWebPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebPreview));
            this.outputWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // outputWebBrowser
            // 
            this.outputWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.outputWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.outputWebBrowser.Name = "outputWebBrowser";
            this.outputWebBrowser.Size = new System.Drawing.Size(784, 562);
            this.outputWebBrowser.TabIndex = 0;
            // 
            // frmWebPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.outputWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebPreview";
            this.Text = "Web Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser outputWebBrowser;
    }
}