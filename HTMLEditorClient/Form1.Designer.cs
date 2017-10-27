namespace HTMLEditorClient
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuGetFromServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSynchronise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTool8p = new System.Windows.Forms.ToolStripMenuItem();
            this.pTool10p = new System.Windows.Forms.ToolStripMenuItem();
            this.pTool12p = new System.Windows.Forms.ToolStripMenuItem();
            this.pTool16p = new System.Windows.Forms.ToolStripMenuItem();
            this.pTool20p = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMark = new System.Windows.Forms.ToolStripMenuItem();
            this.inputCode = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.outputLineNumber = new System.Windows.Forms.Label();
            this.outputConnection = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolGetFromWeb = new System.Windows.Forms.ToolStripButton();
            this.toolGetFromServer = new System.Windows.Forms.ToolStripButton();
            this.toolSendToServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolWebPreview = new System.Windows.Forms.ToolStripButton();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuEdit,
            this.toolsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripSeparator1,
            this.menuGetFromServer,
            this.menuSynchronise,
            this.toolStripSeparator2,
            this.menuAbout,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(158, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(158, 22);
            this.menuSaveAs.Text = "Save as...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // menuGetFromServer
            // 
            this.menuGetFromServer.Name = "menuGetFromServer";
            this.menuGetFromServer.Size = new System.Drawing.Size(158, 22);
            this.menuGetFromServer.Text = "Get From Server";
            // 
            // menuSynchronise
            // 
            this.menuSynchronise.Name = "menuSynchronise";
            this.menuSynchronise.Size = new System.Drawing.Size(158, 22);
            this.menuSynchronise.Text = "Synchronise";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(158, 22);
            this.menuAbout.Text = "About";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(158, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopy,
            this.menuPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "Edit";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(102, 22);
            this.menuCopy.Text = "Copy";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(102, 22);
            this.menuPaste.Text = "Paste";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.menuMark});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pTool8p,
            this.pTool10p,
            this.pTool12p,
            this.pTool16p,
            this.pTool20p});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // pTool8p
            // 
            this.pTool8p.Name = "pTool8p";
            this.pTool8p.Size = new System.Drawing.Size(93, 22);
            this.pTool8p.Text = "8p";
            this.pTool8p.Click += new System.EventHandler(this.pTool8p_Click);
            // 
            // pTool10p
            // 
            this.pTool10p.Name = "pTool10p";
            this.pTool10p.Size = new System.Drawing.Size(93, 22);
            this.pTool10p.Text = "10p";
            this.pTool10p.Click += new System.EventHandler(this.pTool10p_Click);
            // 
            // pTool12p
            // 
            this.pTool12p.Name = "pTool12p";
            this.pTool12p.Size = new System.Drawing.Size(93, 22);
            this.pTool12p.Text = "12p";
            this.pTool12p.Click += new System.EventHandler(this.pTool12p_Click);
            // 
            // pTool16p
            // 
            this.pTool16p.Name = "pTool16p";
            this.pTool16p.Size = new System.Drawing.Size(93, 22);
            this.pTool16p.Text = "16p";
            this.pTool16p.Click += new System.EventHandler(this.pTool16p_Click);
            // 
            // pTool20p
            // 
            this.pTool20p.Name = "pTool20p";
            this.pTool20p.Size = new System.Drawing.Size(93, 22);
            this.pTool20p.Text = "20p";
            this.pTool20p.Click += new System.EventHandler(this.pTool20p_Click);
            // 
            // menuMark
            // 
            this.menuMark.Name = "menuMark";
            this.menuMark.Size = new System.Drawing.Size(121, 22);
            this.menuMark.Text = "Mark";
            this.menuMark.Click += new System.EventHandler(this.menuMark_Click);
            // 
            // inputCode
            // 
            this.inputCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCode.ContextMenuStrip = this.contextMenuStrip1;
            this.inputCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputCode.Location = new System.Drawing.Point(0, 54);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(1008, 652);
            this.inputCode.TabIndex = 2;
            this.inputCode.Text = "";
            this.inputCode.Click += new System.EventHandler(this.inputCode_Click);
            this.inputCode.TextChanged += new System.EventHandler(this.inputCode_TextChanged);
            this.inputCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputCode_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextCopy,
            this.contextPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 48);
            // 
            // contextCopy
            // 
            this.contextCopy.Name = "contextCopy";
            this.contextCopy.Size = new System.Drawing.Size(102, 22);
            this.contextCopy.Text = "Copy";
            this.contextCopy.Click += new System.EventHandler(this.contextCopy_Click);
            // 
            // contextPaste
            // 
            this.contextPaste.Name = "contextPaste";
            this.contextPaste.Size = new System.Drawing.Size(102, 22);
            this.contextPaste.Text = "Paste";
            this.contextPaste.Click += new System.EventHandler(this.contextPaste_Click);
            // 
            // outputLineNumber
            // 
            this.outputLineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputLineNumber.AutoSize = true;
            this.outputLineNumber.BackColor = System.Drawing.Color.Transparent;
            this.outputLineNumber.Location = new System.Drawing.Point(12, 710);
            this.outputLineNumber.Name = "outputLineNumber";
            this.outputLineNumber.Size = new System.Drawing.Size(39, 13);
            this.outputLineNumber.TabIndex = 4;
            this.outputLineNumber.Text = "Line: 1";
            // 
            // outputConnection
            // 
            this.outputConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputConnection.BackColor = System.Drawing.Color.Transparent;
            this.outputConnection.Location = new System.Drawing.Point(589, 707);
            this.outputConnection.Name = "outputConnection";
            this.outputConnection.Size = new System.Drawing.Size(407, 19);
            this.outputConnection.TabIndex = 6;
            this.outputConnection.Text = "Connection info: --";
            this.outputConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpen,
            this.toolSave,
            this.toolSaveAs,
            this.toolStripSeparator3,
            this.toolGetFromWeb,
            this.toolGetFromServer,
            this.toolSendToServer,
            this.toolStripSeparator4,
            this.toolWebPreview,
            this.toolAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolOpen.Image")));
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(28, 28);
            this.toolOpen.Text = "toolStripButton1";
            this.toolOpen.ToolTipText = "Open...";
            this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(28, 28);
            this.toolSave.Text = "toolStripButton2";
            this.toolSave.ToolTipText = "Save";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolSaveAs
            // 
            this.toolSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolSaveAs.Image")));
            this.toolSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSaveAs.Name = "toolSaveAs";
            this.toolSaveAs.Size = new System.Drawing.Size(28, 28);
            this.toolSaveAs.Text = "toolStripButton3";
            this.toolSaveAs.ToolTipText = "Save As...";
            this.toolSaveAs.Click += new System.EventHandler(this.toolSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolGetFromWeb
            // 
            this.toolGetFromWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGetFromWeb.Image = ((System.Drawing.Image)(resources.GetObject("toolGetFromWeb.Image")));
            this.toolGetFromWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGetFromWeb.Name = "toolGetFromWeb";
            this.toolGetFromWeb.Size = new System.Drawing.Size(28, 28);
            this.toolGetFromWeb.Text = "f";
            this.toolGetFromWeb.ToolTipText = "Get HTML from web";
            this.toolGetFromWeb.Click += new System.EventHandler(this.toolGetFromServer_Click);
            // 
            // toolGetFromServer
            // 
            this.toolGetFromServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGetFromServer.Image = ((System.Drawing.Image)(resources.GetObject("toolGetFromServer.Image")));
            this.toolGetFromServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGetFromServer.Name = "toolGetFromServer";
            this.toolGetFromServer.Size = new System.Drawing.Size(28, 28);
            this.toolGetFromServer.Text = "toolStripButton1";
            this.toolGetFromServer.ToolTipText = "Get HTML from server";
            // 
            // toolSendToServer
            // 
            this.toolSendToServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSendToServer.Image = ((System.Drawing.Image)(resources.GetObject("toolSendToServer.Image")));
            this.toolSendToServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSendToServer.Name = "toolSendToServer";
            this.toolSendToServer.Size = new System.Drawing.Size(28, 28);
            this.toolSendToServer.Text = "toolStripButton5";
            this.toolSendToServer.ToolTipText = "Synchronise with server";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolWebPreview
            // 
            this.toolWebPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWebPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolWebPreview.Image")));
            this.toolWebPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWebPreview.Name = "toolWebPreview";
            this.toolWebPreview.Size = new System.Drawing.Size(28, 28);
            this.toolWebPreview.Text = "toolStripButton1";
            this.toolWebPreview.Click += new System.EventHandler(this.toolWebPreview_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(28, 28);
            this.toolAbout.Text = "toolStripButton6";
            this.toolAbout.ToolTipText = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.outputConnection);
            this.Controls.Add(this.outputLineNumber);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML Editor";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox inputCode;
        private System.Windows.Forms.Label outputLineNumber;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTool8p;
        private System.Windows.Forms.ToolStripMenuItem pTool10p;
        private System.Windows.Forms.ToolStripMenuItem pTool12p;
        private System.Windows.Forms.ToolStripMenuItem pTool16p;
        private System.Windows.Forms.ToolStripMenuItem pTool20p;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuGetFromServer;
        private System.Windows.Forms.ToolStripMenuItem menuSynchronise;
        private System.Windows.Forms.ToolStripMenuItem menuMark;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label outputConnection;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolSaveAs;
        private System.Windows.Forms.ToolStripButton toolGetFromWeb;
        private System.Windows.Forms.ToolStripButton toolSendToServer;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextCopy;
        private System.Windows.Forms.ToolStripMenuItem contextPaste;
        private System.Windows.Forms.ToolStripButton toolGetFromServer;
        private System.Windows.Forms.ToolStripButton toolWebPreview;
    }
}

