using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petru
{
    public partial class Form1 : Form
    {
        public string buffer = GetIPAddress();
        private Timer timer1;
        public Form1()
        {
            InitializeComponent();
            string root = @"C:\IP";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            TextWriter tsw = new StreamWriter(@"C:\IP\IP.txt", true);
            tsw.WriteLine(buffer + " - " + DateTime.Now.ToString("T") + "\n");
            tsw.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            InitTimer();
        }

        static string GetIPAddress()
        {
            String address = "";
            try
            {
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    address = stream.ReadToEnd();
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);

                return address;
            }

            catch { return "ERROR"; }
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string data = GetIPAddress();
            
            if (data == buffer) { ip.Text = data; goto END; }

            if (data == "ERROR") { goto END; }
            ip.Text = data;
            buffer = data;

            TextWriter tsw = new StreamWriter(@"C:\IP\IP.txt", true);
            tsw.WriteLine(ip.Text + " - " + DateTime.Now.ToString("T") + "\n");
            tsw.Close();
        END:;
        }
    }
}
