namespace HTMLEditorClient
{
    partial class frmGetHTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetHTML));
            this.label1 = new System.Windows.Forms.Label();
            this.inputHostnameGet = new System.Windows.Forms.TextBox();
            this.btnGetHTMLFromHostname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname:";
            // 
            // inputHostnameGet
            // 
            this.inputHostnameGet.Location = new System.Drawing.Point(16, 29);
            this.inputHostnameGet.Name = "inputHostnameGet";
            this.inputHostnameGet.Size = new System.Drawing.Size(356, 20);
            this.inputHostnameGet.TabIndex = 1;
            this.inputHostnameGet.Text = "http://google.com";
            this.inputHostnameGet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputHostnameGet_KeyDown);
            // 
            // btnGetHTMLFromHostname
            // 
            this.btnGetHTMLFromHostname.Location = new System.Drawing.Point(16, 55);
            this.btnGetHTMLFromHostname.Name = "btnGetHTMLFromHostname";
            this.btnGetHTMLFromHostname.Size = new System.Drawing.Size(75, 23);
            this.btnGetHTMLFromHostname.TabIndex = 2;
            this.btnGetHTMLFromHostname.Text = "Get";
            this.btnGetHTMLFromHostname.UseVisualStyleBackColor = true;
            this.btnGetHTMLFromHostname.Click += new System.EventHandler(this.btnGetHTMLFromHostname_Click);
            // 
            // frmGetHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 91);
            this.Controls.Add(this.btnGetHTMLFromHostname);
            this.Controls.Add(this.inputHostnameGet);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGetHTML";
            this.Text = "Get HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputHostnameGet;
        private System.Windows.Forms.Button btnGetHTMLFromHostname;
    }
}