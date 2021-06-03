
namespace WindowsFormsApp1
{
    partial class AGVData
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
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbDeliver2 = new System.Windows.Forms.ComboBox();
            this.cmbDeliver1 = new System.Windows.Forms.ComboBox();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.GroupBox();
            this.Tracking = new System.Windows.Forms.GroupBox();
            this.NextTag = new System.Windows.Forms.Label();
            this.NextMove = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.ListAGV = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Available3 = new System.Windows.Forms.Label();
            this.Available2 = new System.Windows.Forms.Label();
            this.Available1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Call1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Call2 = new System.Windows.Forms.CheckBox();
            this.Call3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disconnectbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortCb = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.RequestGRB = new System.Windows.Forms.GroupBox();
            this.Productlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeliStationlb = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AGV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Box.SuspendLayout();
            this.Tracking.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RequestGRB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(225, 54);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 24);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged_1);
            // 
            // cmbDeliver2
            // 
            this.cmbDeliver2.FormattingEnabled = true;
            this.cmbDeliver2.Location = new System.Drawing.Point(225, 174);
            this.cmbDeliver2.Name = "cmbDeliver2";
            this.cmbDeliver2.Size = new System.Drawing.Size(121, 24);
            this.cmbDeliver2.TabIndex = 1;
            // 
            // cmbDeliver1
            // 
            this.cmbDeliver1.FormattingEnabled = true;
            this.cmbDeliver1.Location = new System.Drawing.Point(225, 115);
            this.cmbDeliver1.Name = "cmbDeliver1";
            this.cmbDeliver1.Size = new System.Drawing.Size(121, 24);
            this.cmbDeliver1.TabIndex = 2;
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.Location = new System.Drawing.Point(413, 97);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(143, 61);
            this.Startbtn.TabIndex = 7;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.Tracking);
            this.Box.Controls.Add(this.groupBox2);
            this.Box.Controls.Add(this.groupBox1);
            this.Box.Controls.Add(this.RequestGRB);
            this.Box.Location = new System.Drawing.Point(6, 3);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(1121, 388);
            this.Box.TabIndex = 8;
            this.Box.TabStop = false;
            // 
            // Tracking
            // 
            this.Tracking.Controls.Add(this.NextTag);
            this.Tracking.Controls.Add(this.NextMove);
            this.Tracking.Controls.Add(this.label8);
            this.Tracking.Controls.Add(this.label7);
            this.Tracking.Controls.Add(this.Location);
            this.Tracking.Controls.Add(this.ListAGV);
            this.Tracking.Controls.Add(this.txtOutput);
            this.Tracking.Location = new System.Drawing.Point(613, 150);
            this.Tracking.Name = "Tracking";
            this.Tracking.Size = new System.Drawing.Size(502, 231);
            this.Tracking.TabIndex = 23;
            this.Tracking.TabStop = false;
            this.Tracking.Text = "Tracking";
            // 
            // NextTag
            // 
            this.NextTag.AutoSize = true;
            this.NextTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextTag.Location = new System.Drawing.Point(357, 55);
            this.NextTag.Name = "NextTag";
            this.NextTag.Size = new System.Drawing.Size(43, 24);
            this.NextTag.TabIndex = 16;
            this.NextTag.Text = "Tag";
            // 
            // NextMove
            // 
            this.NextMove.AutoSize = true;
            this.NextMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMove.Location = new System.Drawing.Point(324, 28);
            this.NextMove.Name = "NextMove";
            this.NextMove.Size = new System.Drawing.Size(125, 24);
            this.NextMove.TabIndex = 15;
            this.NextMove.Text = "Next Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "AGV Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Location";
            // 
            // Location
            // 
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(197, 52);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(108, 30);
            this.Location.TabIndex = 12;
            this.Location.Text = "Tag";
            this.Location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListAGV
            // 
            this.ListAGV.FormattingEnabled = true;
            this.ListAGV.Location = new System.Drawing.Point(38, 54);
            this.ListAGV.Name = "ListAGV";
            this.ListAGV.Size = new System.Drawing.Size(121, 24);
            this.ListAGV.TabIndex = 11;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(48, 188);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(420, 22);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Confirm);
            this.groupBox2.Controls.Add(this.Available3);
            this.groupBox2.Controls.Add(this.Available2);
            this.groupBox2.Controls.Add(this.Available1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Call1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Call2);
            this.groupBox2.Controls.Add(this.Call3);
            this.groupBox2.Location = new System.Drawing.Point(613, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 131);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(328, 52);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(140, 36);
            this.Confirm.TabIndex = 27;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Available3
            // 
            this.Available3.AutoSize = true;
            this.Available3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available3.Location = new System.Drawing.Point(17, 87);
            this.Available3.Name = "Available3";
            this.Available3.Size = new System.Drawing.Size(64, 24);
            this.Available3.TabIndex = 26;
            this.Available3.Text = "Ready";
            // 
            // Available2
            // 
            this.Available2.AutoSize = true;
            this.Available2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available2.Location = new System.Drawing.Point(17, 52);
            this.Available2.Name = "Available2";
            this.Available2.Size = new System.Drawing.Size(64, 24);
            this.Available2.TabIndex = 25;
            this.Available2.Text = "Ready";
            // 
            // Available1
            // 
            this.Available1.AutoSize = true;
            this.Available1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available1.Location = new System.Drawing.Point(17, 21);
            this.Available1.Name = "Available1";
            this.Available1.Size = new System.Drawing.Size(64, 24);
            this.Available1.TabIndex = 24;
            this.Available1.Text = "Ready";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "AGV 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "AGV 2";
            // 
            // Call1
            // 
            this.Call1.AutoSize = true;
            this.Call1.Location = new System.Drawing.Point(249, 24);
            this.Call1.Name = "Call1";
            this.Call1.Size = new System.Drawing.Size(18, 17);
            this.Call1.TabIndex = 18;
            this.Call1.UseVisualStyleBackColor = true;
            this.Call1.CheckedChanged += new System.EventHandler(this.Call1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "AGV 1";
            // 
            // Call2
            // 
            this.Call2.AutoSize = true;
            this.Call2.Location = new System.Drawing.Point(249, 58);
            this.Call2.Name = "Call2";
            this.Call2.Size = new System.Drawing.Size(18, 17);
            this.Call2.TabIndex = 19;
            this.Call2.UseVisualStyleBackColor = true;
            // 
            // Call3
            // 
            this.Call3.AutoSize = true;
            this.Call3.Location = new System.Drawing.Point(249, 93);
            this.Call3.Name = "Call3";
            this.Call3.Size = new System.Drawing.Size(18, 17);
            this.Call3.TabIndex = 20;
            this.Call3.UseVisualStyleBackColor = true;
            this.Call3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconnectbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Connectbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortCb);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 141);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // Disconnectbtn
            // 
            this.Disconnectbtn.Location = new System.Drawing.Point(435, 61);
            this.Disconnectbtn.Name = "Disconnectbtn";
            this.Disconnectbtn.Size = new System.Drawing.Size(121, 36);
            this.Disconnectbtn.TabIndex = 12;
            this.Disconnectbtn.Text = "Disconnect";
            this.Disconnectbtn.UseVisualStyleBackColor = true;
            this.Disconnectbtn.Click += new System.EventHandler(this.Disconnectbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Baud Rate";
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(304, 62);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(121, 35);
            this.Connectbtn.TabIndex = 11;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selected Port";
            // 
            // PortCb
            // 
            this.PortCb.FormattingEnabled = true;
            this.PortCb.Location = new System.Drawing.Point(138, 48);
            this.PortCb.Name = "PortCb";
            this.PortCb.Size = new System.Drawing.Size(143, 24);
            this.PortCb.TabIndex = 10;
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Location = new System.Drawing.Point(138, 86);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(143, 24);
            this.BaudRate.TabIndex = 14;
            // 
            // RequestGRB
            // 
            this.RequestGRB.Controls.Add(this.Startbtn);
            this.RequestGRB.Controls.Add(this.cmbMaterial);
            this.RequestGRB.Controls.Add(this.Productlb);
            this.RequestGRB.Controls.Add(this.cmbDeliver1);
            this.RequestGRB.Controls.Add(this.label1);
            this.RequestGRB.Controls.Add(this.DeliStationlb);
            this.RequestGRB.Controls.Add(this.cmbDeliver2);
            this.RequestGRB.Location = new System.Drawing.Point(6, 150);
            this.RequestGRB.Name = "RequestGRB";
            this.RequestGRB.Size = new System.Drawing.Size(598, 231);
            this.RequestGRB.TabIndex = 13;
            this.RequestGRB.TabStop = false;
            this.RequestGRB.Text = "Request";
            // 
            // Productlb
            // 
            this.Productlb.AutoSize = true;
            this.Productlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlb.Location = new System.Drawing.Point(32, 54);
            this.Productlb.Name = "Productlb";
            this.Productlb.Size = new System.Drawing.Size(148, 25);
            this.Productlb.TabIndex = 9;
            this.Productlb.Text = "Type of product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Delivering Station 2";
            // 
            // DeliStationlb
            // 
            this.DeliStationlb.AutoSize = true;
            this.DeliStationlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliStationlb.Location = new System.Drawing.Point(17, 174);
            this.DeliStationlb.Name = "DeliStationlb";
            this.DeliStationlb.Size = new System.Drawing.Size(180, 25);
            this.DeliStationlb.TabIndex = 8;
            this.DeliStationlb.Text = "Delivering Station 1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1141, 426);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Box);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1133, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1133, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AGV Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AGV);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1121, 388);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // AGV
            // 
            this.AGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AGV.Location = new System.Drawing.Point(120, 12);
            this.AGV.Name = "AGV";
            this.AGV.RowHeadersWidth = 51;
            this.AGV.RowTemplate.Height = 24;
            this.AGV.Size = new System.Drawing.Size(898, 370);
            this.AGV.TabIndex = 0;
            // 
            // AGVData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AGVData";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Box.ResumeLayout(false);
            this.Tracking.ResumeLayout(false);
            this.Tracking.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RequestGRB.ResumeLayout(false);
            this.RequestGRB.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbDeliver2;
        private System.Windows.Forms.ComboBox cmbDeliver1;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label Productlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeliStationlb;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox PortCb;
        private System.Windows.Forms.Button Disconnectbtn;
        private System.Windows.Forms.Button Connectbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox RequestGRB;
        private System.Windows.Forms.CheckBox Call1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Call2;
        private System.Windows.Forms.CheckBox Call3;
        private System.Windows.Forms.Label Available3;
        private System.Windows.Forms.Label Available2;
        private System.Windows.Forms.Label Available1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Tracking;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView AGV;
        private System.Windows.Forms.Label NextTag;
        private System.Windows.Forms.Label NextMove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.ComboBox ListAGV;
    }
}