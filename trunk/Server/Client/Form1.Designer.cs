namespace Client
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbTextChat = new System.Windows.Forms.RichTextBox();
            this.lbFont = new System.Windows.Forms.LinkLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lbColor = new System.Windows.Forms.LinkLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(425, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(425, 377);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbTextChat
            // 
            this.rtbTextChat.Location = new System.Drawing.Point(35, 358);
            this.rtbTextChat.Name = "rtbTextChat";
            this.rtbTextChat.Size = new System.Drawing.Size(384, 42);
            this.rtbTextChat.TabIndex = 2;
            this.rtbTextChat.Text = "";
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Location = new System.Drawing.Point(50, 330);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(25, 13);
            this.lbFont.TabIndex = 3;
            this.lbFont.TabStop = true;
            this.lbFont.Text = "font";
            this.lbFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbFont_LinkClicked);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(81, 330);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(30, 13);
            this.lbColor.TabIndex = 4;
            this.lbColor.TabStop = true;
            this.lbColor.Text = "color";
            this.lbColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbColor_LinkClicked);
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(35, 50);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(371, 265);
            this.rtbMsg.TabIndex = 6;
            this.rtbMsg.Text = "";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(57, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(349, 20);
            this.txtIP.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 412);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbFont);
            this.Controls.Add(this.rtbTextChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbTextChat;
        private System.Windows.Forms.LinkLabel lbFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.LinkLabel lbColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.TextBox txtIP;
    }
}

