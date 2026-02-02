namespace SystemHealthChecker
{
    partial class FormMain
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
            this.lblCpuText = new System.Windows.Forms.Label();
            this.lblCpuValue = new System.Windows.Forms.Label();
            this.lblCpuStatus = new System.Windows.Forms.Label();
            this.pbCpu = new System.Windows.Forms.ProgressBar();
            this.pbRam = new System.Windows.Forms.ProgressBar();
            this.lblRamStatus = new System.Windows.Forms.Label();
            this.lblRamValue = new System.Windows.Forms.Label();
            this.lblRamText = new System.Windows.Forms.Label();
            this.pbDisk = new System.Windows.Forms.ProgressBar();
            this.lblDiskStatus = new System.Windows.Forms.Label();
            this.lblDiskValue = new System.Windows.Forms.Label();
            this.lblDiskText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerHealth = new System.Windows.Forms.Timer(this.components);
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCpuText
            // 
            this.lblCpuText.AutoSize = true;
            this.lblCpuText.Location = new System.Drawing.Point(106, 97);
            this.lblCpuText.Name = "lblCpuText";
            this.lblCpuText.Size = new System.Drawing.Size(93, 20);
            this.lblCpuText.TabIndex = 0;
            this.lblCpuText.Text = "CPU Usage";
            // 
            // lblCpuValue
            // 
            this.lblCpuValue.AutoSize = true;
            this.lblCpuValue.Location = new System.Drawing.Point(394, 97);
            this.lblCpuValue.Name = "lblCpuValue";
            this.lblCpuValue.Size = new System.Drawing.Size(36, 20);
            this.lblCpuValue.TabIndex = 1;
            this.lblCpuValue.Text = "0 %";
            // 
            // lblCpuStatus
            // 
            this.lblCpuStatus.AutoSize = true;
            this.lblCpuStatus.Location = new System.Drawing.Point(106, 146);
            this.lblCpuStatus.Name = "lblCpuStatus";
            this.lblCpuStatus.Size = new System.Drawing.Size(114, 20);
            this.lblCpuStatus.TabIndex = 2;
            this.lblCpuStatus.Text = "Status: Normal";
            // 
            // pbCpu
            // 
            this.pbCpu.Location = new System.Drawing.Point(110, 120);
            this.pbCpu.Name = "pbCpu";
            this.pbCpu.Size = new System.Drawing.Size(324, 23);
            this.pbCpu.TabIndex = 3;
            // 
            // pbRam
            // 
            this.pbRam.Location = new System.Drawing.Point(110, 206);
            this.pbRam.Name = "pbRam";
            this.pbRam.Size = new System.Drawing.Size(324, 23);
            this.pbRam.TabIndex = 7;
            // 
            // lblRamStatus
            // 
            this.lblRamStatus.AutoSize = true;
            this.lblRamStatus.Location = new System.Drawing.Point(106, 232);
            this.lblRamStatus.Name = "lblRamStatus";
            this.lblRamStatus.Size = new System.Drawing.Size(114, 20);
            this.lblRamStatus.TabIndex = 6;
            this.lblRamStatus.Text = "Status: Normal";
            // 
            // lblRamValue
            // 
            this.lblRamValue.AutoSize = true;
            this.lblRamValue.Location = new System.Drawing.Point(394, 183);
            this.lblRamValue.Name = "lblRamValue";
            this.lblRamValue.Size = new System.Drawing.Size(36, 20);
            this.lblRamValue.TabIndex = 5;
            this.lblRamValue.Text = "0 %";
            // 
            // lblRamText
            // 
            this.lblRamText.AutoSize = true;
            this.lblRamText.Location = new System.Drawing.Point(106, 183);
            this.lblRamText.Name = "lblRamText";
            this.lblRamText.Size = new System.Drawing.Size(116, 20);
            this.lblRamText.TabIndex = 4;
            this.lblRamText.Text = "Memory Usage";
            // 
            // pbDisk
            // 
            this.pbDisk.Location = new System.Drawing.Point(110, 287);
            this.pbDisk.Name = "pbDisk";
            this.pbDisk.Size = new System.Drawing.Size(324, 23);
            this.pbDisk.TabIndex = 11;
            // 
            // lblDiskStatus
            // 
            this.lblDiskStatus.AutoSize = true;
            this.lblDiskStatus.Location = new System.Drawing.Point(106, 313);
            this.lblDiskStatus.Name = "lblDiskStatus";
            this.lblDiskStatus.Size = new System.Drawing.Size(114, 20);
            this.lblDiskStatus.TabIndex = 10;
            this.lblDiskStatus.Text = "Status: Normal";
            // 
            // lblDiskValue
            // 
            this.lblDiskValue.AutoSize = true;
            this.lblDiskValue.Location = new System.Drawing.Point(394, 264);
            this.lblDiskValue.Name = "lblDiskValue";
            this.lblDiskValue.Size = new System.Drawing.Size(36, 20);
            this.lblDiskValue.TabIndex = 9;
            this.lblDiskValue.Text = "0 %";
            // 
            // lblDiskText
            // 
            this.lblDiskText.AutoSize = true;
            this.lblDiskText.Location = new System.Drawing.Point(106, 264);
            this.lblDiskText.Name = "lblDiskText";
            this.lblDiskText.Size = new System.Drawing.Size(91, 20);
            this.lblDiskText.TabIndex = 8;
            this.lblDiskText.Text = "Disk Usage";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(128, 346);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 33);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start Monitoring";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(306, 346);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 33);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerHealth
            // 
            this.timerHealth.Interval = 2000;
            this.timerHealth.Tick += new System.EventHandler(this.timerHealth_Tick);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(110, 399);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(128, 20);
            this.lblLastUpdated.TabIndex = 14;
            this.lblLastUpdated.Text = "Last Updated: -.-";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbDisk);
            this.Controls.Add(this.lblDiskStatus);
            this.Controls.Add(this.lblDiskValue);
            this.Controls.Add(this.lblDiskText);
            this.Controls.Add(this.pbRam);
            this.Controls.Add(this.lblRamStatus);
            this.Controls.Add(this.lblRamValue);
            this.Controls.Add(this.lblRamText);
            this.Controls.Add(this.pbCpu);
            this.Controls.Add(this.lblCpuStatus);
            this.Controls.Add(this.lblCpuValue);
            this.Controls.Add(this.lblCpuText);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpuText;
        private System.Windows.Forms.Label lblCpuValue;
        private System.Windows.Forms.Label lblCpuStatus;
        private System.Windows.Forms.ProgressBar pbCpu;
        private System.Windows.Forms.ProgressBar pbRam;
        private System.Windows.Forms.Label lblRamStatus;
        private System.Windows.Forms.Label lblRamValue;
        private System.Windows.Forms.Label lblRamText;
        private System.Windows.Forms.ProgressBar pbDisk;
        private System.Windows.Forms.Label lblDiskStatus;
        private System.Windows.Forms.Label lblDiskValue;
        private System.Windows.Forms.Label lblDiskText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerHealth;
        private System.Windows.Forms.Label lblLastUpdated;
    }
}

