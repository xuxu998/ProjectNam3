
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Productlb = new System.Windows.Forms.Label();
            this.DeliStationlb = new System.Windows.Forms.Label();
            this.RCVStationlb = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbDeliver1 = new System.Windows.Forms.ComboBox();
            this.RCstationcb = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Startbtn);
            this.tabPage1.Controls.Add(this.Productlb);
            this.tabPage1.Controls.Add(this.DeliStationlb);
            this.tabPage1.Controls.Add(this.RCVStationlb);
            this.tabPage1.Controls.Add(this.cmbMaterial);
            this.tabPage1.Controls.Add(this.cmbDeliver1);
            this.tabPage1.Controls.Add(this.RCstationcb);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AGVSetting ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.Location = new System.Drawing.Point(502, 91);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(143, 61);
            this.Startbtn.TabIndex = 6;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Productlb
            // 
            this.Productlb.AutoSize = true;
            this.Productlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlb.Location = new System.Drawing.Point(42, 186);
            this.Productlb.Name = "Productlb";
            this.Productlb.Size = new System.Drawing.Size(148, 25);
            this.Productlb.TabIndex = 5;
            this.Productlb.Text = "Type of product";
            // 
            // DeliStationlb
            // 
            this.DeliStationlb.AutoSize = true;
            this.DeliStationlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliStationlb.Location = new System.Drawing.Point(42, 106);
            this.DeliStationlb.Name = "DeliStationlb";
            this.DeliStationlb.Size = new System.Drawing.Size(164, 25);
            this.DeliStationlb.TabIndex = 4;
            this.DeliStationlb.Text = "Delivering Station";
            // 
            // RCVStationlb
            // 
            this.RCVStationlb.AutoSize = true;
            this.RCVStationlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCVStationlb.Location = new System.Drawing.Point(42, 39);
            this.RCVStationlb.Name = "RCVStationlb";
            this.RCVStationlb.Size = new System.Drawing.Size(163, 25);
            this.RCVStationlb.TabIndex = 3;
            this.RCVStationlb.Text = "Receiving Station";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(238, 187);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 24);
            this.cmbMaterial.TabIndex = 2;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // cmbDeliver1
            // 
            this.cmbDeliver1.FormattingEnabled = true;
            this.cmbDeliver1.Location = new System.Drawing.Point(238, 110);
            this.cmbDeliver1.Name = "cmbDeliver1";
            this.cmbDeliver1.Size = new System.Drawing.Size(121, 24);
            this.cmbDeliver1.TabIndex = 1;
            // 
            // RCstationcb
            // 
            this.RCstationcb.FormattingEnabled = true;
            this.RCstationcb.Location = new System.Drawing.Point(238, 43);
            this.RCstationcb.Name = "RCstationcb";
            this.RCstationcb.Size = new System.Drawing.Size(121, 24);
            this.RCstationcb.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AGVStatus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Productlb;
        private System.Windows.Forms.Label DeliStationlb;
        private System.Windows.Forms.Label RCVStationlb;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbDeliver1;
        private System.Windows.Forms.ComboBox RCstationcb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Startbtn;
    }
}