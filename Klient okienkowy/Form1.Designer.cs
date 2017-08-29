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
            this.reciveDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TalkBox
            // 
            this.TalkBox.Location = new System.Drawing.Point(46, 30);
            this.TalkBox.Multiline = true;
            this.TalkBox.Name = "TalkBox";
            this.TalkBox.Size = new System.Drawing.Size(614, 461);
            this.TalkBox.TabIndex = 0;
            this.TalkBox.TextChanged += new System.EventHandler(this.TalkBox_TextChanged);
            // 
            // SendMessagetxt
            // 
            this.SendMessagetxt.Location = new System.Drawing.Point(46, 536);
            this.SendMessagetxt.Multiline = true;
            this.SendMessagetxt.Name = "SendMessagetxt";
            this.SendMessagetxt.Size = new System.Drawing.Size(456, 48);
            this.SendMessagetxt.TabIndex = 1;
            this.SendMessagetxt.TextChanged += new System.EventHandler(this.SendMessagetxt_TextChanged);
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(538, 536);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 48);
            this.Sendbtn.TabIndex = 2;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // reciveDataButton
            // 
            this.reciveDataButton.Location = new System.Drawing.Point(538, 590);
            this.reciveDataButton.Name = "reciveDataButton";
            this.reciveDataButton.Size = new System.Drawing.Size(75, 40);
            this.reciveDataButton.TabIndex = 3;
            this.reciveDataButton.Text = "Recive Data";
            this.reciveDataButton.UseVisualStyleBackColor = true;
            this.reciveDataButton.Click += new System.EventHandler(this.reciveDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 646);
            this.Controls.Add(this.reciveDataButton);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.SendMessagetxt);
            this.Controls.Add(this.TalkBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TalkBox;
        private System.Windows.Forms.TextBox SendMessagetxt;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Button reciveDataButton;
    }
}

