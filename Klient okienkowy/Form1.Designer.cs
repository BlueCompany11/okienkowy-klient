namespace Klient_okienkowy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TalkBox = new System.Windows.Forms.TextBox();
            this.SendMessagetxt = new System.Windows.Forms.TextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TalkBox
            // 
            this.TalkBox.Location = new System.Drawing.Point(46, 30);
            this.TalkBox.Multiline = true;
            this.TalkBox.Name = "TalkBox";
            this.TalkBox.Size = new System.Drawing.Size(614, 461);
            this.TalkBox.TabIndex = 0;
            // 
            // SendMessagetxt
            // 
            this.SendMessagetxt.Location = new System.Drawing.Point(46, 508);
            this.SendMessagetxt.Multiline = true;
            this.SendMessagetxt.Name = "SendMessagetxt";
            this.SendMessagetxt.Size = new System.Drawing.Size(456, 48);
            this.SendMessagetxt.TabIndex = 1;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(546, 508);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(114, 48);
            this.Sendbtn.TabIndex = 2;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(100, 594);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(218, 20);
            this.ipTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server IP";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(337, 594);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 646);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.SendMessagetxt);
            this.Controls.Add(this.TalkBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TalkBox;
        private System.Windows.Forms.TextBox SendMessagetxt;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterButton;
    }
}

