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

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Socket server;
        IPEndPoint ipe;
        List<Socket> lstClient = new List<Socket>();
        Thread xulyClient;
        string myIP = "";

        public void layIP(){
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress adr in host.AddressList)
            {
                if (adr.AddressFamily.ToString() == "InterNetwork")
                {
                    myIP = adr.ToString();
                }
            }
            ipe = new IPEndPoint(IPAddress.Parse(myIP), 2001);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }

        private void rtbMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            layIP();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            xulyClient = new Thread(new ThreadStart(LangNghe));
            xulyClient.IsBackground = true;
            xulyClient.Start();
        }

        private void LangNghe()
        {
            server.Bind(ipe);
            server.Listen(3);
            while (true)
            {
                Socket sk = server.Accept();
                lstClient.Add(sk);

                Thread clientProcess = new Thread(MyThreadClient);
                clientProcess.IsBackground = true;
                clientProcess.Start(sk);

                rtbMain.SelectionFont = new Font("Arial", 18, FontStyle.Bold);
                rtbMain.SelectionColor = Color.Aqua;
                rtbMain.AppendText("Chap Nhan ket noi tu " + sk.RemoteEndPoint.ToString());
                rtbMain.ScrollToCaret();
            }
        }

        public void MyThreadClient(object obj)
        {
            Socket clientSk = (Socket)obj;
            while (true)
            {
                byte[] buff = new byte[1024];
                int receive = clientSk.Receive(buff);
                foreach (Socket sk in lstClient) {
                    sk.Send(buff, buff.Length, SocketFlags.None);
                }

            }

        }
    }
}
