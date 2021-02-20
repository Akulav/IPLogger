
namespace IPLogger
{
    partial class DefaultForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultForm));
            this.newIP = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.oldIP = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.historyLog = new System.Windows.Forms.ListBox();
            this.currentIPLabel = new System.Windows.Forms.Label();
            this.oldIPLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.country = new System.Windows.Forms.Label();
            this.tor = new System.Windows.Forms.Label();
            this.proxy = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.torLabel = new System.Windows.Forms.Label();
            this.proxyLabel = new System.Windows.Forms.Label();
            this.attacker = new System.Windows.Forms.Label();
            this.attackerLabel = new System.Windows.Forms.Label();
            this.abuserLabel = new System.Windows.Forms.Label();
            this.abuser = new System.Windows.Forms.Label();
            this.threatLabel = new System.Windows.Forms.Label();
            this.threat = new System.Windows.Forms.Label();
            this.anonymousLabel = new System.Windows.Forms.Label();
            this.anonymous = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newIP
            // 
            this.newIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.newIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIP.Location = new System.Drawing.Point(0, 0);
            this.newIP.Name = "newIP";
            this.newIP.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.newIP.Size = new System.Drawing.Size(926, 51);
            this.newIP.TabIndex = 0;
            this.newIP.Text = "IP";
            this.newIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(8, 105);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(470, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // oldIP
            // 
            this.oldIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.oldIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldIP.Location = new System.Drawing.Point(0, 51);
            this.oldIP.Name = "oldIP";
            this.oldIP.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.oldIP.Size = new System.Drawing.Size(926, 51);
            this.oldIP.TabIndex = 4;
            this.oldIP.Text = "IP";
            this.oldIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(9, 105);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(470, 36);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stop_Click);
            // 
            // historyLog
            // 
            this.historyLog.FormattingEnabled = true;
            this.historyLog.Location = new System.Drawing.Point(9, 143);
            this.historyLog.Name = "historyLog";
            this.historyLog.Size = new System.Drawing.Size(470, 238);
            this.historyLog.TabIndex = 6;
            // 
            // currentIPLabel
            // 
            this.currentIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIPLabel.Location = new System.Drawing.Point(12, 25);
            this.currentIPLabel.Name = "currentIPLabel";
            this.currentIPLabel.Size = new System.Drawing.Size(85, 20);
            this.currentIPLabel.TabIndex = 7;
            this.currentIPLabel.Text = "Current IP:";
            // 
            // oldIPLabel
            // 
            this.oldIPLabel.AutoSize = true;
            this.oldIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldIPLabel.Location = new System.Drawing.Point(12, 76);
            this.oldIPLabel.Name = "oldIPLabel";
            this.oldIPLabel.Size = new System.Drawing.Size(92, 20);
            this.oldIPLabel.TabIndex = 8;
            this.oldIPLabel.Text = "Previous IP:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(484, 105);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 26);
            this.country.TabIndex = 11;
            this.country.Text = "Location:";
            // 
            // tor
            // 
            this.tor.AutoSize = true;
            this.tor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tor.Location = new System.Drawing.Point(484, 189);
            this.tor.Name = "tor";
            this.tor.Size = new System.Drawing.Size(78, 26);
            this.tor.TabIndex = 12;
            this.tor.Text = "Is Tor: ";
            // 
            // proxy
            // 
            this.proxy.AutoSize = true;
            this.proxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxy.Location = new System.Drawing.Point(484, 148);
            this.proxy.Name = "proxy";
            this.proxy.Size = new System.Drawing.Size(103, 26);
            this.proxy.TabIndex = 13;
            this.proxy.Text = "Is Proxy: ";
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(772, 105);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(94, 26);
            this.countryLabel.TabIndex = 14;
            this.countryLabel.Text = "N/A";
            // 
            // torLabel
            // 
            this.torLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torLabel.Location = new System.Drawing.Point(772, 189);
            this.torLabel.Name = "torLabel";
            this.torLabel.Size = new System.Drawing.Size(94, 26);
            this.torLabel.TabIndex = 15;
            this.torLabel.Text = "N/A";
            // 
            // proxyLabel
            // 
            this.proxyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyLabel.Location = new System.Drawing.Point(772, 148);
            this.proxyLabel.Name = "proxyLabel";
            this.proxyLabel.Size = new System.Drawing.Size(94, 26);
            this.proxyLabel.TabIndex = 16;
            this.proxyLabel.Text = "N/A";
            // 
            // attacker
            // 
            this.attacker.AutoSize = true;
            this.attacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attacker.Location = new System.Drawing.Point(484, 229);
            this.attacker.Name = "attacker";
            this.attacker.Size = new System.Drawing.Size(127, 26);
            this.attacker.TabIndex = 17;
            this.attacker.Text = "Is Attacker: ";
            // 
            // attackerLabel
            // 
            this.attackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackerLabel.Location = new System.Drawing.Point(772, 229);
            this.attackerLabel.Name = "attackerLabel";
            this.attackerLabel.Size = new System.Drawing.Size(94, 26);
            this.attackerLabel.TabIndex = 18;
            this.attackerLabel.Text = "N/A";
            // 
            // abuserLabel
            // 
            this.abuserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abuserLabel.Location = new System.Drawing.Point(772, 266);
            this.abuserLabel.Name = "abuserLabel";
            this.abuserLabel.Size = new System.Drawing.Size(94, 26);
            this.abuserLabel.TabIndex = 20;
            this.abuserLabel.Text = "N/A";
            // 
            // abuser
            // 
            this.abuser.AutoSize = true;
            this.abuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abuser.Location = new System.Drawing.Point(484, 266);
            this.abuser.Name = "abuser";
            this.abuser.Size = new System.Drawing.Size(116, 26);
            this.abuser.TabIndex = 19;
            this.abuser.Text = "Is Abuser: ";
            // 
            // threatLabel
            // 
            this.threatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threatLabel.Location = new System.Drawing.Point(772, 305);
            this.threatLabel.Name = "threatLabel";
            this.threatLabel.Size = new System.Drawing.Size(94, 26);
            this.threatLabel.TabIndex = 22;
            this.threatLabel.Text = "N/A";
            // 
            // threat
            // 
            this.threat.AutoSize = true;
            this.threat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threat.Location = new System.Drawing.Point(484, 305);
            this.threat.Name = "threat";
            this.threat.Size = new System.Drawing.Size(102, 26);
            this.threat.TabIndex = 21;
            this.threat.Text = "Is Threat:";
            // 
            // anonymousLabel
            // 
            this.anonymousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anonymousLabel.Location = new System.Drawing.Point(772, 342);
            this.anonymousLabel.Name = "anonymousLabel";
            this.anonymousLabel.Size = new System.Drawing.Size(94, 26);
            this.anonymousLabel.TabIndex = 24;
            this.anonymousLabel.Text = "N/A";
            // 
            // anonymous
            // 
            this.anonymous.AutoSize = true;
            this.anonymous.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anonymous.Location = new System.Drawing.Point(484, 342);
            this.anonymous.Name = "anonymous";
            this.anonymous.Size = new System.Drawing.Size(157, 26);
            this.anonymous.TabIndex = 23;
            this.anonymous.Text = "Is Anonymous:";
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 384);
            this.Controls.Add(this.anonymousLabel);
            this.Controls.Add(this.anonymous);
            this.Controls.Add(this.threatLabel);
            this.Controls.Add(this.threat);
            this.Controls.Add(this.abuserLabel);
            this.Controls.Add(this.abuser);
            this.Controls.Add(this.attackerLabel);
            this.Controls.Add(this.attacker);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.proxyLabel);
            this.Controls.Add(this.country);
            this.Controls.Add(this.torLabel);
            this.Controls.Add(this.tor);
            this.Controls.Add(this.oldIPLabel);
            this.Controls.Add(this.proxy);
            this.Controls.Add(this.currentIPLabel);
            this.Controls.Add(this.historyLog);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.oldIP);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.newIP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultForm";
            this.Text = "IP DETECTOR";
            this.Resize += new System.EventHandler(this.DefaultForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newIP;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label oldIP;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListBox historyLog;
        private System.Windows.Forms.Label currentIPLabel;
        private System.Windows.Forms.Label oldIPLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label tor;
        private System.Windows.Forms.Label proxy;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label torLabel;
        private System.Windows.Forms.Label proxyLabel;
        private System.Windows.Forms.Label attacker;
        private System.Windows.Forms.Label attackerLabel;
        private System.Windows.Forms.Label abuserLabel;
        private System.Windows.Forms.Label abuser;
        private System.Windows.Forms.Label threatLabel;
        private System.Windows.Forms.Label threat;
        private System.Windows.Forms.Label anonymousLabel;
        private System.Windows.Forms.Label anonymous;
    }
}

