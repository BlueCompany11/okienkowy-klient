using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace Klient_okienkowy
{
    public partial class Form1 : Form
    {
        string txtRecived;
        string socketip;
        string nick;
        public Form1()
        {
            InitializeComponent();
            Client.client = new TcpClient(Client.hostname, Client.port);
            socketip = Client.client.Client.LocalEndPoint.ToString();
            nick = socketip;
        }

        private void talkText_TextChanged(object sender, EventArgs e)
        {
            //tbData.AppendText(str);

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            string message = SendMessagetxt.Text;
            txtRecived=Client.Connect(Client.client, Client.hostname, "ID: " + nick + " " + message);
            txtRecived += '\n';
            TalkBox.AppendText(txtRecived);
            SendMessagetxt.Clear();
        }

        private void SendMessagetxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TalkBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Client.stream.Close();
            Client.client.Close();
        }
    }
}
