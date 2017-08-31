using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_okienkowy
{
    public partial class ServerOptionsForm : Form
    {
        private Button enterButton;
        private Label label1;
        private TextBox ipTextBox;
        IPAddress[] ipv4Addresses = Array.FindAll(
Dns.GetHostEntry(string.Empty).AddressList,
a => a.AddressFamily == AddressFamily.InterNetwork);
        public ServerOptionsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(143, 189);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 8;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server IP";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(67, 136);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(218, 20);
            this.ipTextBox.TabIndex = 6;
            ipTextBox.Text = ipv4Addresses[0].ToString();
            // 
            // ServerOptionsForm
            // 
            this.ClientSize = new System.Drawing.Size(375, 300);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.Name = "ServerOptionsForm";
            this.Load += new System.EventHandler(this.ServerOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ServerOptionsForm_Load(object sender, EventArgs e)
        {
            IPAddress[] ipv4Addresses = Array.FindAll(
                    Dns.GetHostEntry(string.Empty).AddressList,
                    a => a.AddressFamily == AddressFamily.InterNetwork);
            Client.hostname = ipv4Addresses[0].ToString();
        }
        //DO POPRAWY
        /// <summary>
        /// Logic for pressed enter ip button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            //Control[] q = this.Controls.Find("Form1",true); //jest to w zlej kolekcji, trzeba to napisac w form1 i dawac jako referencje
            //if (q[0] != null)
            //{
            //    Form1 a = (Form1)q[0];
            //    a.SetValues();
            //}
            if (CheckIfIpIsCorrect(ipTextBox.Text) == false)
            {
                MessageBox.Show("Invalid IP");
                return;
            }
            else
            {
                Client.hostname = ipTextBox.Text;
            }
            this.Close();
            Form1 w;
            Form x = Application.OpenForms[0];
            w = (Form1)x;
            w.SetValues();

        }

    }
}
