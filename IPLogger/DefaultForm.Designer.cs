
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
            this.speedChange = new System.Windows.Forms.TrackBar();
            this.checkSpeedLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speedChange)).BeginInit();
            this.SuspendLayout();
            // 
            // newIP
            // 
            this.newIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.newIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIP.Location = new System.Drawing.Point(0, 0);
            this.newIP.Name = "newIP";
            this.newIP.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.newIP.Size = new System.Drawing.Size(491, 51);
            this.newIP.TabIndex = 0;
            this.newIP.Text = "IP";
            this.newIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(9, 156);
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
            this.oldIP.Size = new System.Drawing.Size(491, 51);
            this.oldIP.TabIndex = 4;
            this.oldIP.Text = "IP";
            this.oldIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(9, 156);
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
            this.historyLog.Location = new System.Drawing.Point(9, 208);
            this.historyLog.Name = "historyLog";
            this.historyLog.Size = new System.Drawing.Size(470, 316);
            this.historyLog.TabIndex = 6;
            // 
            // currentIPLabel
            // 
            this.currentIPLabel.AutoSize = true;
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
            this.oldIPLabel.Size = new System.Drawing.Size(56, 20);
            this.oldIPLabel.TabIndex = 8;
            this.oldIPLabel.Text = "Old IP:";
            // 
            // speedChange
            // 
            this.speedChange.LargeChange = 1000;
            this.speedChange.Location = new System.Drawing.Point(131, 105);
            this.speedChange.Maximum = 30000;
            this.speedChange.Minimum = 5000;
            this.speedChange.Name = "speedChange";
            this.speedChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speedChange.Size = new System.Drawing.Size(348, 45);
            this.speedChange.SmallChange = 100;
            this.speedChange.TabIndex = 9;
            this.speedChange.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speedChange.Value = 7000;
            // 
            // checkSpeedLabel
            // 
            this.checkSpeedLabel.AutoSize = true;
            this.checkSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSpeedLabel.Location = new System.Drawing.Point(12, 117);
            this.checkSpeedLabel.Name = "checkSpeedLabel";
            this.checkSpeedLabel.Size = new System.Drawing.Size(113, 20);
            this.checkSpeedLabel.TabIndex = 10;
            this.checkSpeedLabel.Text = "Check Speed: ";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 536);
            this.Controls.Add(this.checkSpeedLabel);
            this.Controls.Add(this.speedChange);
            this.Controls.Add(this.oldIPLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.speedChange)).EndInit();
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
        private System.Windows.Forms.TrackBar speedChange;
        private System.Windows.Forms.Label checkSpeedLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

