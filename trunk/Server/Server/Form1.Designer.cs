﻿namespace Server
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
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Location = new System.Drawing.Point(23, 43);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(415, 285);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbMain_KeyPress);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(322, 334);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 368);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.rtbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Button btnListen;
    }
}

