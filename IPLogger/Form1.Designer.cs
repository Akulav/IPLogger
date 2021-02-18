
namespace Petru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultForm));
            this.ip = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.oldIP = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.Dock = System.Windows.Forms.DockStyle.Top;
            this.ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.Location = new System.Drawing.Point(0, 0);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(491, 51);
            this.ip.TabIndex = 0;
            this.ip.Text = "IP";
            this.ip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(9, 105);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(470, 36);
            this.start.TabIndex = 1;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // oldIP
            // 
            this.oldIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.oldIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldIP.Location = new System.Drawing.Point(0, 51);
            this.oldIP.Name = "oldIP";
            this.oldIP.Size = new System.Drawing.Size(491, 51);
            this.oldIP.TabIndex = 4;
            this.oldIP.Text = "IP";
            this.oldIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(9, 105);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(470, 36);
            this.stop.TabIndex = 5;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(9, 147);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(470, 342);
            this.history.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Old IP:";
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.history);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.oldIP);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultForm";
            this.Text = "IP DETECTOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label oldIP;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

