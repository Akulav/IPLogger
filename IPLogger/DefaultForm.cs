using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace IPLogger
{
    public partial class DefaultForm : Form
    {
        private string buffer = GetIPAddress();
        private Timer eventLoop;
        private int tickrate = 7000;

        public DefaultForm()
        {
            //make sure its double buffered
            DoubleBuffered = true;

            InitializeComponent();
            //hide button when initialized
            stopButton.Visible = false;

            //Write initial IP to desktop
            TextWriter tsw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" + "ip.txt", true);
            tsw.WriteLine(buffer + " - " + DateTime.Now.ToString("T") + "\n");
            tsw.Close();
            
            //Write initial IP to log in-app
            historyLog.Items.Add(buffer + " - " + DateTime.Now.ToString("T"));
        }

        private void start_Click(object sender, EventArgs e)
        {
            //swap start with stop button
            startButton.Visible = false;
            stopButton.Visible = true;
            //activate eventloop
            InitTimer();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //swap stop with start button
            stopButton.Visible = false;
            startButton.Visible = true;
            //stop eventloop
            eventLoop.Stop();
        }
        
        //Gets the current ip as string
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

        //starts the eventloop
        public void InitTimer()
        {
            eventLoop = new Timer();
            eventLoop.Tick += new EventHandler(eventLoop_Tick);
            eventLoop.Interval = tickrate; // in miliseconds
            eventLoop.Start();
        }

        //checks the ip and stores the old one. Uses the set speed as tick-rate
        private void eventLoop_Tick(object sender, EventArgs e)
        {
            string data = GetIPAddress();
            string time = DateTime.Now.ToString("T");
            tickrate = speedChange.Value;

            eventLoop.Interval = tickrate;

            if (data == buffer) { newIP.Text = data; goto END; }
            if (data == "ERROR") { goto END; }

            newIP.Text = data;
            oldIP.Text = buffer;
            buffer = data;

            TextWriter tsw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "ip.txt", true);
            tsw.WriteLine(data + " - " + time + "\n");
            tsw.Close();
            historyLog.Items.Add(data + " - " + time);

        END:;
        }

        //minimize event
        private void DefaultForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        //double click on system tray will launch the app to taskbar
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Show();
        }

    }
}
