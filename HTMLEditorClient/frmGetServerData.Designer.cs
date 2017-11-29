namespace HTMLEditorClient
{
    partial class frmGetServerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetServerData));
            this.label1 = new System.Windows.Forms.Label();
            this.inputHostname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.btnGetFromServer = new System.Windows.Forms.Button();
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
            // inputHostname
            // 
            this.inputHostname.Location = new System.Drawing.Point(13, 30);
            this.inputHostname.Name = "inputHostname";
            this.inputHostname.Size = new System.Drawing.Size(359, 20);
            this.inputHostname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(13, 74);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(58, 20);
            this.inputPort.TabIndex = 3;
            // 
            // btnGetFromServer
            // 
            this.btnGetFromServer.Location = new System.Drawing.Point(12, 127);
            this.btnGetFromServer.Name = "btnGetFromServer";
            this.btnGetFromServer.Size = new System.Drawing.Size(150, 23);
            this.btnGetFromServer.TabIndex = 4;
            this.btnGetFromServer.Text = "Get";
            this.btnGetFromServer.UseVisualStyleBackColor = true;
            this.btnGetFromServer.Click += new System.EventHandler(this.btnGetFromServer_Click);
            // 
            // frmGetServerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.btnGetFromServer);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputHostname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGetServerData";
            this.Text = "Get From Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputHostname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.Button btnGetFromServer;
    }
}