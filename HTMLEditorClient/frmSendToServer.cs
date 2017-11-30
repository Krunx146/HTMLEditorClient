using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLEditorClient
{
    public partial class frmSendToServer : Form
    {
        public frmMain parent;
        public frmSendToServer()
        {
            InitializeComponent();
        }

        private void inputRequireAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (inputRequireAuth.Checked == true)
            {
                inputAuthCode.ReadOnly = false;
            }
            else inputAuthCode.ReadOnly = true;
        }
    }
}
