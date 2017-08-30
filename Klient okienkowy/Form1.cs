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
        string socketip;
        string nick;

        public TextBox PlaceForText
        {
            get { return TalkBox; }
        }

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            Client accesGiver = new Client(this);
            InitializeComponent();
            try
            {
                Client.client = new TcpClient(Client.hostname, Client.port);
                socketip = Client.client.Client.LocalEndPoint.ToString();
                nick = socketip;
                Task RecivedMessageTask = new Task(()=>Client.ReciveMessageAction(accesGiver));
                RecivedMessageTask.Start();
                Sendbtn.PerformClick();
                Client.stream = Client.client.GetStream();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Serwer wylaczony");
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Environment.Exit(0);
            };
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            string message = SendMessagetxt.Text;
            Client.Connect(Client.client, Client.hostname, message);
            SendMessagetxt.Clear();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Client.stream.Close();
            Client.client.Close();
            Client.client.Client.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client.hostname = 
            enterButton.Text = Client.hostname;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Client.hostname = enterButton.Text;
        }
    }
}
