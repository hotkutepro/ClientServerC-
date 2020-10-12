using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using MyStruct;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        Thread ketnoi;
        Socket client;
        IPEndPoint ipe;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ketnoi = new Thread(new ThreadStart(KetNoiDenServer));
            ketnoi.IsBackground = true;
            ketnoi.Start();
        }

        private void KetNoiDenServer()
        {
            ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), 2001);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            client.Connect(ipe);
            Thread langNghe = new Thread(LangNgheDuLieu);
            langNghe.IsBackground = true;
            langNghe.Start(client);
        }

        private void LangNgheDuLieu(object obj)
        {
            Socket sk = (Socket)obj;
            while (true)
            {
                byte[] buff = new byte[1024];
                int rev = client.Receive(buff);
                HamMaHoa(buff);

            }
        }

        private void HamMaHoa(byte[] buff)
        {
            MyStruct.Structure str = new MyStruct.Structure();
            MemoryStream stream = new MemoryStream(buff);
            BinaryFormatter bFormat = new BinaryFormatter();
            str = (Structure)bFormat.Deserialize(stream);
            rtbMsg.SelectionFont = str.MyFont;
            rtbMsg.SelectionColor = str.MyColor;
            rtbMsg.AppendText(str.TextChat);
            rtbMsg.ScrollToCaret();

                        
        }

        private void lbFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtbTextChat.Font = fontDialog1.Font;
            }
        }

        private void lbColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtbTextChat.ForeColor = colorDialog1.Color;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Structure str = new Structure();
            str.TextChat = rtbTextChat.Text;
            str.MyColor = rtbTextChat.ForeColor;
            str.MyFont = rtbTextChat.Font;
            MemoryStream st = new MemoryStream();
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(st, str);
            byte[] buff = new byte[1024];
            buff = st.ToArray();
            client.Send(buff);
            rtbTextChat.Text = "";
        }


    }
}
