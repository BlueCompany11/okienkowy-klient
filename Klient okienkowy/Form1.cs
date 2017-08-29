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
            try
            {
                Client.client = new TcpClient(Client.hostname, Client.port);
                socketip = Client.client.Client.LocalEndPoint.ToString();
                nick = socketip;
                Task RecivedMessageTask = new Task(Client.ReciveMessageAction);
                RecivedMessageTask.Start();
                //Thread t = new Thread(reciveDataButton.PerformClick);
                //t.Start();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Serwer wylaczony");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Environment.Exit(0);
            };
            
        }

        private void talkText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            string message = SendMessagetxt.Text;
            Client.Connect(Client.client, Client.hostname, message);
            //te 2 linijki gdzies indziej

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
            Client.client.Client.Close();
        }

        private void reciveDataButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Client.recivedData);
            txtRecived += '\n';
            TalkBox.AppendText(txtRecived);
            Thread.Sleep(1000);
        }

    }
}
