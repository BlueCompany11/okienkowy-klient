using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_okienkowy
{
    public class Logs : Form
    {
        private TextBox fromDateTextBox;
        private Label label1;
        private Label label2;
        private TextBox toDateTextBox;
        private Label label3;
        private Label label4;
        private Button getDataButton;

        public Logs()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.getDataButton = new System.Windows.Forms.Button();
            this.fromDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(158, 233);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 0;
            this.getDataButton.Text = "Get data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // fromDateTextBox
            // 
            this.fromDateTextBox.Location = new System.Drawing.Point(63, 67);
            this.fromDateTextBox.Name = "fromDateTextBox";
            this.fromDateTextBox.Size = new System.Drawing.Size(280, 20);
            this.fromDateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pattern: 2017-08-31 08:27:10";
            // 
            // toDateTextBox
            // 
            this.toDateTextBox.Location = new System.Drawing.Point(63, 102);
            this.toDateTextBox.Name = "toDateTextBox";
            this.toDateTextBox.Size = new System.Drawing.Size(280, 20);
            this.toDateTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // Logs
            // 
            this.ClientSize = new System.Drawing.Size(411, 346);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toDateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDateTextBox);
            this.Controls.Add(this.getDataButton);
            this.Name = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Logs_Load(object sender, EventArgs e)
        {

        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            DateTime from=new DateTime(); ;
            DateTime to=new DateTime(); ;
            //string from="";
            //string to = "";
            //potrzebne te converty, bo inaczej trzeba by pisac dodatkowe funckje na sprawdzanie czy poprawne dane zostaly wpisane
            try
            {
                from = Convert.ToDateTime(fromDateTextBox.Text);
                //from = fromDateTextBox.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Label From has wrong format");
            }
            try
            {
                to = Convert.ToDateTime(toDateTextBox.Text);
                //to = fromDateTextBox.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Label To has wrong format");
            }
            string queryLogs;
            DateTime temp = new DateTime();
            if (from != temp && to != temp)
            {
                queryLogs = "$MsG_" + from.ToString() + "_" + to.ToString() + "$";
                MessageBox.Show(queryLogs);
                Client.Connect(Client.client, Client.hostname, queryLogs);
            }
            else
            {
                return;
            }
        }

    }
}
