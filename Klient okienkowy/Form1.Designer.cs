﻿namespace Klient_okienkowy
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
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TalkBox
            // 
            this.TalkBox.Location = new System.Drawing.Point(46, 93);
            this.TalkBox.Multiline = true;
            this.TalkBox.Name = "TalkBox";
            this.TalkBox.ReadOnly = true;
            this.TalkBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TalkBox.Size = new System.Drawing.Size(614, 461);
            this.TalkBox.TabIndex = 0;
            // 
            // SendMessagetxt
            // 
            this.SendMessagetxt.Location = new System.Drawing.Point(46, 578);
            this.SendMessagetxt.Multiline = true;
            this.SendMessagetxt.Name = "SendMessagetxt";
            this.SendMessagetxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendMessagetxt.Size = new System.Drawing.Size(456, 48);
            this.SendMessagetxt.TabIndex = 1;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(546, 578);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(114, 48);
            this.Sendbtn.TabIndex = 2;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(46, 26);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(85, 39);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 646);
            this.Controls.Add(this.historyButton);
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
        private System.Windows.Forms.Button historyButton;
    }
}

