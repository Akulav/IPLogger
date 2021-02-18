using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Petru
{
    public partial class DefaultForm : Form
    {
        private string buffer = GetIPAddress();
        private Timer eventLoop;

        public DefaultForm()
        {     
            InitializeComponent();
            stop.Visible = false;
            string root = @"C:\IP";

            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            TextWriter tsw = new StreamWriter(@"C:\IP\IP.txt", true);
            tsw.WriteLine(buffer + " - " + DateTime.Now.ToString("T") + "\n");
            tsw.Close();

            history.Items.Add(buffer + " - " + DateTime.Now.ToString("T"));
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            stop.Visible = true;
            InitTimer();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            eventLoop.Stop();
            stop.Visible = false;
            start.Visible = true;
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
            eventLoop = new Timer();
            eventLoop.Tick += new EventHandler(eventLoop_Tick);
            eventLoop.Interval = 6000; // in miliseconds
            eventLoop.Start();
        }

        private void eventLoop_Tick(object sender, EventArgs e)
        {
            string data = GetIPAddress();
            string time = DateTime.Now.ToString("T");
            int speed = speedChange.Value;

            eventLoop.Interval = speed;

            if (data == buffer) { ip.Text = data; goto END; }
            if (data == "ERROR") { goto END; }

            ip.Text = data;
            oldIP.Text = buffer;
            buffer = data;

            TextWriter tsw = new StreamWriter(@"C:\IP\IP.txt", true);
            tsw.WriteLine(data + " - " + time + "\n");
            tsw.Close();
            history.Items.Add(data + " - " + time);

        END:;
        }

        private void DefaultForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Show();
        }
    }
}
