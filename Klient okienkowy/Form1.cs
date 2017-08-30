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

        void child_OnChildTextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Wywolanie funkcji");
            TalkBox.AppendText((string)sender+'\n');
        }

        public TextBox PlaceForText
        {
            get { return TalkBox; }
        }

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
                //do wypisywania wiadomosci
                Client child = new Client();
                child.OnChildTextChanged += new EventHandler(child_OnChildTextChanged);
                //Thread t = new Thread(reciveDataButton.PerformClick);
                //t.Start();
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
            //te 2 linijki gdzies indziej

            SendMessagetxt.Clear();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Client.stream.Close();
            Client.client.Close();
            Client.client.Client.Close();
        }

    }
}
