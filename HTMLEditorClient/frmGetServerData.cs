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
    public partial class frmGetServerData : Form
    {
        public frmMain parent;
        public frmGetServerData()
        {
            InitializeComponent();
        }
        public void Connect(String server, int port, String message)
        {
            try
            {
                TcpClient klijent = new TcpClient(server, port);

                Byte[] podaci = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = klijent.GetStream();
                stream.Write(podaci, 0, podaci.Length);

                podaci = new Byte[256];
                String responseData = String.Empty;

                Int32 bytes = stream.Read(podaci, 0, podaci.Length);
                responseData = System.Text.Encoding.ASCII.GetString(podaci, 0, bytes);
                parent.AppendText(responseData);
                stream.Close();
                klijent.Close();
            }
            catch(ArgumentNullException e)
            {
                MessageBox.Show("Greska pri unosu argumenata! Error code: " + e);
                return;
            }
            catch(SocketException e)
            {
                MessageBox.Show("Greska pri spajanju na server! Error code: " + e);
                return;
            }
        }
        private void btnGetFromServer_Click(object sender, EventArgs e)
        {
            try
            {
                Connect(inputHostname.Text, int.Parse(inputPort.Text), "GHT");
            }
            catch
            {
                MessageBox.Show("Unesite podatke u polja!");
            }
        }
    }
}
