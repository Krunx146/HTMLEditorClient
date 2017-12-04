using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
        public void Synchronise(String server, int port, String message)
        {
            try
            {
                TcpClient klijent = new TcpClient(server, port);

                Byte[] podaci = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = klijent.GetStream();
                stream.Write(podaci, 0, podaci.Length);

                podaci = new Byte[256];
                stream.Close();
                klijent.Close();
                MessageBox.Show("Data succesfully sent!");
                this.Close();
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Greska pri unosu argumenata! Error code: " + e);
                return;
            }
            catch (SocketException e)
            {
                MessageBox.Show("Greska pri spajanju na server! Error code: " + e);
                return;
            }
        }
        private void inputRequireAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (inputRequireAuth.Checked == true)
            {
                inputAuthCode.ReadOnly = false;
            }
            else inputAuthCode.ReadOnly = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Synchronise(inputHostname.Text, int.Parse(inputPort.Text), "RHT" + parent.GetTextLength().ToString("00000") + parent.GetText());
            }
            catch
            {
                MessageBox.Show("Unesite podatke u polja!");
            }
        }
    }
}
