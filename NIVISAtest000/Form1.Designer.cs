namespace NIVISAtest000
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.scanBtn = new System.Windows.Forms.Button();
            this.devicesCB = new System.Windows.Forms.ComboBox();
            this.infoLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.readSPbtn = new System.Windows.Forms.Button();
            this.writeSPbtn = new System.Windows.Forms.Button();
            this.baudRateCB = new System.Windows.Forms.ComboBox();
            this.openSPbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.commandTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readUSBbtn = new System.Windows.Forms.Button();
            this.writeUSBbtn = new System.Windows.Forms.Button();
            this.openUSBbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.readGPIBbtn = new System.Windows.Forms.Button();
            this.writeGPIBbtn = new System.Windows.Forms.Button();
            this.openGPIBbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(634, 13);
            this.scanBtn.Margin = new System.Windows.Forms.Padding(4);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(125, 32);
            this.scanBtn.TabIndex = 0;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // devicesCB
            // 
            this.devicesCB.FormattingEnabled = true;
            this.devicesCB.Location = new System.Drawing.Point(22, 13);
            this.devicesCB.Margin = new System.Windows.Forms.Padding(4);
            this.devicesCB.Name = "devicesCB";
            this.devicesCB.Size = new System.Drawing.Size(532, 32);
            this.devicesCB.TabIndex = 1;
            // 
            // infoLB
            // 
            this.infoLB.BackColor = System.Drawing.Color.Turquoise;
            this.infoLB.Location = new System.Drawing.Point(13, 560);
            this.infoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLB.Name = "infoLB";
            this.infoLB.Size = new System.Drawing.Size(944, 36);
            this.infoLB.TabIndex = 2;
            this.infoLB.Text = "label1";
            this.infoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readSPbtn);
            this.groupBox1.Controls.Add(this.writeSPbtn);
            this.groupBox1.Controls.Add(this.baudRateCB);
            this.groupBox1.Controls.Add(this.openSPbtn);
            this.groupBox1.Location = new System.Drawing.Point(22, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SerialPort";
            // 
            // readSPbtn
            // 
            this.readSPbtn.Location = new System.Drawing.Point(262, 78);
            this.readSPbtn.Name = "readSPbtn";
            this.readSPbtn.Size = new System.Drawing.Size(124, 39);
            this.readSPbtn.TabIndex = 3;
            this.readSPbtn.Text = "Read";
            this.readSPbtn.UseVisualStyleBackColor = true;
            this.readSPbtn.Click += new System.EventHandler(this.readSPbtn_Click);
            // 
            // writeSPbtn
            // 
            this.writeSPbtn.Location = new System.Drawing.Point(26, 78);
            this.writeSPbtn.Name = "writeSPbtn";
            this.writeSPbtn.Size = new System.Drawing.Size(133, 39);
            this.writeSPbtn.TabIndex = 2;
            this.writeSPbtn.Text = "Write";
            this.writeSPbtn.UseVisualStyleBackColor = true;
            this.writeSPbtn.Click += new System.EventHandler(this.writeSPbtn_Click);
            // 
            // baudRateCB
            // 
            this.baudRateCB.FormattingEnabled = true;
            this.baudRateCB.Location = new System.Drawing.Point(26, 31);
            this.baudRateCB.Name = "baudRateCB";
            this.baudRateCB.Size = new System.Drawing.Size(177, 32);
            this.baudRateCB.TabIndex = 1;
            // 
            // openSPbtn
            // 
            this.openSPbtn.Location = new System.Drawing.Point(262, 27);
            this.openSPbtn.Name = "openSPbtn";
            this.openSPbtn.Size = new System.Drawing.Size(124, 39);
            this.openSPbtn.TabIndex = 0;
            this.openSPbtn.Text = "Open";
            this.openSPbtn.UseVisualStyleBackColor = true;
            this.openSPbtn.Click += new System.EventHandler(this.openSPbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(22, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 316);
            this.listBox1.TabIndex = 4;
            // 
            // commandTB
            // 
            this.commandTB.Location = new System.Drawing.Point(22, 191);
            this.commandTB.Name = "commandTB";
            this.commandTB.Size = new System.Drawing.Size(461, 31);
            this.commandTB.TabIndex = 5;
            this.commandTB.Text = "*IDN?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readUSBbtn);
            this.groupBox2.Controls.Add(this.writeUSBbtn);
            this.groupBox2.Controls.Add(this.openUSBbtn);
            this.groupBox2.Location = new System.Drawing.Point(492, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 133);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USB";
            // 
            // readUSBbtn
            // 
            this.readUSBbtn.Location = new System.Drawing.Point(262, 78);
            this.readUSBbtn.Name = "readUSBbtn";
            this.readUSBbtn.Size = new System.Drawing.Size(124, 39);
            this.readUSBbtn.TabIndex = 3;
            this.readUSBbtn.Text = "Read";
            this.readUSBbtn.UseVisualStyleBackColor = true;
            this.readUSBbtn.Click += new System.EventHandler(this.readUSBbtn_Click);
            // 
            // writeUSBbtn
            // 
            this.writeUSBbtn.Location = new System.Drawing.Point(26, 78);
            this.writeUSBbtn.Name = "writeUSBbtn";
            this.writeUSBbtn.Size = new System.Drawing.Size(133, 39);
            this.writeUSBbtn.TabIndex = 2;
            this.writeUSBbtn.Text = "Write";
            this.writeUSBbtn.UseVisualStyleBackColor = true;
            this.writeUSBbtn.Click += new System.EventHandler(this.writeUSBbtn_Click);
            // 
            // openUSBbtn
            // 
            this.openUSBbtn.Location = new System.Drawing.Point(262, 27);
            this.openUSBbtn.Name = "openUSBbtn";
            this.openUSBbtn.Size = new System.Drawing.Size(124, 39);
            this.openUSBbtn.TabIndex = 0;
            this.openUSBbtn.Text = "Open";
            this.openUSBbtn.UseVisualStyleBackColor = true;
            this.openUSBbtn.Click += new System.EventHandler(this.openUSBbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.readGPIBbtn);
            this.groupBox3.Controls.Add(this.writeGPIBbtn);
            this.groupBox3.Controls.Add(this.openGPIBbtn);
            this.groupBox3.Location = new System.Drawing.Point(489, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 133);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPIB";
            // 
            // readGPIBbtn
            // 
            this.readGPIBbtn.Location = new System.Drawing.Point(262, 78);
            this.readGPIBbtn.Name = "readGPIBbtn";
            this.readGPIBbtn.Size = new System.Drawing.Size(124, 39);
            this.readGPIBbtn.TabIndex = 3;
            this.readGPIBbtn.Text = "Read";
            this.readGPIBbtn.UseVisualStyleBackColor = true;
            this.readGPIBbtn.Click += new System.EventHandler(this.readGPIBbtn_Click);
            // 
            // writeGPIBbtn
            // 
            this.writeGPIBbtn.Location = new System.Drawing.Point(26, 78);
            this.writeGPIBbtn.Name = "writeGPIBbtn";
            this.writeGPIBbtn.Size = new System.Drawing.Size(133, 39);
            this.writeGPIBbtn.TabIndex = 2;
            this.writeGPIBbtn.Text = "Write";
            this.writeGPIBbtn.UseVisualStyleBackColor = true;
            this.writeGPIBbtn.Click += new System.EventHandler(this.writeGPIBbtn_Click);
            // 
            // openGPIBbtn
            // 
            this.openGPIBbtn.Location = new System.Drawing.Point(262, 27);
            this.openGPIBbtn.Name = "openGPIBbtn";
            this.openGPIBbtn.Size = new System.Drawing.Size(124, 39);
            this.openGPIBbtn.TabIndex = 0;
            this.openGPIBbtn.Text = "Open";
            this.openGPIBbtn.UseVisualStyleBackColor = true;
            this.openGPIBbtn.Click += new System.EventHandler(this.openGPIBbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.commandTB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoLB);
            this.Controls.Add(this.devicesCB);
            this.Controls.Add(this.scanBtn);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(992, 661);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.ComboBox devicesCB;
        private System.Windows.Forms.Label infoLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button readSPbtn;
        private System.Windows.Forms.Button writeSPbtn;
        private System.Windows.Forms.ComboBox baudRateCB;
        private System.Windows.Forms.Button openSPbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox commandTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button readUSBbtn;
        private System.Windows.Forms.Button writeUSBbtn;
        private System.Windows.Forms.Button openUSBbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button readGPIBbtn;
        private System.Windows.Forms.Button writeGPIBbtn;
        private System.Windows.Forms.Button openGPIBbtn;
    }
}

