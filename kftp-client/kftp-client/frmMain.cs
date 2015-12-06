using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace kftp_client
{
    public partial class frmMain : Form
    {

        TcpClient ftpClient;
        TcpClient dataClient;

        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        public frmMain()
        {
            InitializeComponent();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            ftpClient = new TcpClient();
            ftpClient.BeginConnect(txtMayChu.Text, int.Parse(txtPort.Text), XulyCallback, ftpClient);
        }

        private void XulyCallback(IAsyncResult ar)
        {
            ftpClient.EndConnect(ar);

            ns = ftpClient.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);

            ThreadPool.QueueUserWorkItem(Xuly);
        }

        void Log(string txt)
        {
            rTxtLog.Text += DateTime.Now.ToString() + ": " + txt + "\r\n";
        }

        private void Xuly(object state)
        {
            try
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    string respone = string.Empty;

                    if (string.IsNullOrEmpty(line)) break;

                    // log
                    Log(line);

                    string[] temp = line.Split(' ');
                    string code = temp[0].ToUpper();
                    string agrs = string.Empty;
                    if (temp.Length > 1)
                        agrs = line.Substring(4);

                    switch (code)
                    {
                        case "220":
                            respone = Code220(agrs);
                            break;
                        case "331":
                            respone = Code331(agrs);
                            break;
                    }

                    if(string.IsNullOrEmpty(respone) == false)
                    {
                        sw.WriteLine(respone);
                        sw.Flush();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private string Code331(string agrs)
        {
            throw new NotImplementedException();
        }

        private string Code220(string agrs)
        {
            return "USER " + txtTaiKhoan.Text;
        }
    }
}
