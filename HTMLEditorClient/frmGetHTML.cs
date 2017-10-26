using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLEditorClient
{
    public partial class frmGetHTML : Form
    {
        public frmMain parent;
        public HttpWebRequest request;
        public HttpWebResponse response;
        public frmGetHTML()
        {
            InitializeComponent();
        }

        private void btnGetHTMLFromHostname_Click(object sender, EventArgs e)
        {
            string urlAddress = inputHostnameGet.Text;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(urlAddress);
            }
            catch
            {
                MessageBox.Show("Cannot reach the host at " + urlAddress);
                return;
            }
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch
            {
                MessageBox.Show("No response from " + urlAddress);
                return;
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                parent.AppendText(data);
                this.Close();
            }
        }
    }
}
