namespace HTMLEditorClient
{
    partial class frmSendToServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendToServer));
            this.label1 = new System.Windows.Forms.Label();
            this.inputHostname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.inputRequireAuth = new System.Windows.Forms.CheckBox();
            this.inputAuthCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
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
            this.inputHostname.Location = new System.Drawing.Point(16, 30);
            this.inputHostname.Name = "inputHostname";
            this.inputHostname.Size = new System.Drawing.Size(249, 20);
            this.inputHostname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(271, 30);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(100, 20);
            this.inputPort.TabIndex = 3;
            // 
            // inputRequireAuth
            // 
            this.inputRequireAuth.AutoSize = true;
            this.inputRequireAuth.Location = new System.Drawing.Point(16, 71);
            this.inputRequireAuth.Name = "inputRequireAuth";
            this.inputRequireAuth.Size = new System.Drawing.Size(145, 17);
            this.inputRequireAuth.TabIndex = 4;
            this.inputRequireAuth.Text = "Require Authentification?";
            this.inputRequireAuth.UseVisualStyleBackColor = true;
            this.inputRequireAuth.CheckedChanged += new System.EventHandler(this.inputRequireAuth_CheckedChanged);
            // 
            // inputAuthCode
            // 
            this.inputAuthCode.Location = new System.Drawing.Point(16, 131);
            this.inputAuthCode.Name = "inputAuthCode";
            this.inputAuthCode.PasswordChar = '•';
            this.inputAuthCode.ReadOnly = true;
            this.inputAuthCode.Size = new System.Drawing.Size(355, 20);
            this.inputAuthCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Authentification code:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 166);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send to Server";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // frmSendToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAuthCode);
            this.Controls.Add(this.inputRequireAuth);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputHostname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendToServer";
            this.Text = "Synchronise with Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputHostname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.CheckBox inputRequireAuth;
        private System.Windows.Forms.TextBox inputAuthCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}