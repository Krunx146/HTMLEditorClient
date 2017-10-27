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
    public partial class frmWebPreview : Form
    {
        public frmWebPreview(string HTMLcode)
        {
            InitializeComponent();
            outputWebBrowser.ScriptErrorsSuppressed = true;
            DisplayHtml(HTMLcode);
        }
        private void DisplayHtml(string html)
        {
            outputWebBrowser.Navigate("about:blank");
            if (outputWebBrowser.Document != null)
            {
                outputWebBrowser.Document.Write(string.Empty);
            }
            outputWebBrowser.DocumentText = html;
        }
    }
}
