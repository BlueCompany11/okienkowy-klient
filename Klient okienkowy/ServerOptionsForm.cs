using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_okienkowy
{
    public partial class ServerOptionsForm:Form
    {
        private Button enterButton;
        private Label label1;
        private TextBox ipTextBox;

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
            Client.hostname= "172.17.1.168";
        }
        //DO POPRAWY
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
            if(ipTextBox.Text == null)    //do testowania
            {
                Client.hostname = "172.17.1.168";
            }
            else
            {
                Client.hostname = ipTextBox.Text;
            }
            Form1 w;
            Form x = Application.OpenForms[1];
            w = (Form1)x;
            w.SetValues();
        }
    }
}
