
namespace WindowsFormsApp1
{
    partial class Controltab
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
            this.Account = new System.Windows.Forms.TabControl();
            this.Accounttab = new System.Windows.Forms.TabPage();
            this.Changetab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewPWCFtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Changebtn = new System.Windows.Forms.Button();
            this.NewPWtxt = new System.Windows.Forms.TextBox();
            this.AccountChangetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Deletetxt = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Addtab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Reloadbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DayCB = new System.Windows.Forms.TabPage();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Accounttxt = new System.Windows.Forms.TextBox();
            this.ProductCB = new System.Windows.Forms.ComboBox();
            this.ReceiCB = new System.Windows.Forms.ComboBox();
            this.DeliCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clrbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Account.SuspendLayout();
            this.Accounttab.SuspendLayout();
            this.Changetab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Addtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.DayCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.Controls.Add(this.Accounttab);
            this.Account.Controls.Add(this.DayCB);
            this.Account.Location = new System.Drawing.Point(12, 12);
            this.Account.Name = "Account";
            this.Account.SelectedIndex = 0;
            this.Account.Size = new System.Drawing.Size(1283, 426);
            this.Account.TabIndex = 0;
            // 
            // Accounttab
            // 
            this.Accounttab.Controls.Add(this.Changetab);
            this.Accounttab.Controls.Add(this.Reloadbtn);
            this.Accounttab.Controls.Add(this.dataGridView2);
            this.Accounttab.Location = new System.Drawing.Point(4, 25);
            this.Accounttab.Name = "Accounttab";
            this.Accounttab.Padding = new System.Windows.Forms.Padding(3);
            this.Accounttab.Size = new System.Drawing.Size(1275, 397);
            this.Accounttab.TabIndex = 0;
            this.Accounttab.Text = "Account";
            this.Accounttab.UseVisualStyleBackColor = true;
            // 
            // Changetab
            // 
            this.Changetab.Controls.Add(this.tabPage1);
            this.Changetab.Controls.Add(this.tabPage2);
            this.Changetab.Controls.Add(this.Addtab);
            this.Changetab.Location = new System.Drawing.Point(665, 6);
            this.Changetab.Name = "Changetab";
            this.Changetab.SelectedIndex = 0;
            this.Changetab.Size = new System.Drawing.Size(604, 285);
            this.Changetab.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NewPWCFtxt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Changebtn);
            this.tabPage1.Controls.Add(this.NewPWtxt);
            this.tabPage1.Controls.Add(this.AccountChangetxt);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewPWCFtxt
            // 
            this.NewPWCFtxt.Location = new System.Drawing.Point(144, 160);
            this.NewPWCFtxt.Name = "NewPWCFtxt";
            this.NewPWCFtxt.Size = new System.Drawing.Size(139, 22);
            this.NewPWCFtxt.TabIndex = 4;
            this.NewPWCFtxt.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Confirm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Changebtn
            // 
            this.Changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changebtn.Location = new System.Drawing.Point(379, 79);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(121, 49);
            this.Changebtn.TabIndex = 1;
            this.Changebtn.Text = "Change Account";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // NewPWtxt
            // 
            this.NewPWtxt.Location = new System.Drawing.Point(144, 92);
            this.NewPWtxt.Name = "NewPWtxt";
            this.NewPWtxt.Size = new System.Drawing.Size(139, 22);
            this.NewPWtxt.TabIndex = 3;
            this.NewPWtxt.UseSystemPasswordChar = true;
            // 
            // AccountChangetxt
            // 
            this.AccountChangetxt.Location = new System.Drawing.Point(144, 16);
            this.AccountChangetxt.Name = "AccountChangetxt";
            this.AccountChangetxt.Size = new System.Drawing.Size(139, 22);
            this.AccountChangetxt.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Account";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "New Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Deletetxt);
            this.tabPage2.Controls.Add(this.Deletebtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Account";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deletetxt
            // 
            this.Deletetxt.Location = new System.Drawing.Point(158, 27);
            this.Deletetxt.Name = "Deletetxt";
            this.Deletetxt.Size = new System.Drawing.Size(139, 22);
            this.Deletetxt.TabIndex = 5;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(363, 14);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(121, 49);
            this.Deletebtn.TabIndex = 6;
            this.Deletebtn.Text = "Delete Account";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Addtab
            // 
            this.Addtab.Controls.Add(this.label12);
            this.Addtab.Controls.Add(this.label11);
            this.Addtab.Controls.Add(this.label10);
            this.Addtab.Controls.Add(this.textBox3);
            this.Addtab.Controls.Add(this.textBox2);
            this.Addtab.Controls.Add(this.textBox1);
            this.Addtab.Controls.Add(this.button1);
            this.Addtab.Location = new System.Drawing.Point(4, 25);
            this.Addtab.Name = "Addtab";
            this.Addtab.Padding = new System.Windows.Forms.Padding(3);
            this.Addtab.Size = new System.Drawing.Size(596, 256);
            this.Addtab.TabIndex = 2;
            this.Addtab.Text = "Add Account";
            this.Addtab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Confirm Password";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Password";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Account";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Reloadbtn
            // 
            this.Reloadbtn.Location = new System.Drawing.Point(247, 297);
            this.Reloadbtn.Name = "Reloadbtn";
            this.Reloadbtn.Size = new System.Drawing.Size(121, 49);
            this.Reloadbtn.TabIndex = 11;
            this.Reloadbtn.Text = "Reload";
            this.Reloadbtn.UseVisualStyleBackColor = true;
            this.Reloadbtn.Click += new System.EventHandler(this.Reloadbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(642, 288);
            this.dataGridView2.TabIndex = 0;
            // 
            // DayCB
            // 
            this.DayCB.Controls.Add(this.MonthCB);
            this.DayCB.Controls.Add(this.YearCB);
            this.DayCB.Controls.Add(this.comboBox1);
            this.DayCB.Controls.Add(this.Accounttxt);
            this.DayCB.Controls.Add(this.ProductCB);
            this.DayCB.Controls.Add(this.ReceiCB);
            this.DayCB.Controls.Add(this.DeliCB);
            this.DayCB.Controls.Add(this.label5);
            this.DayCB.Controls.Add(this.label4);
            this.DayCB.Controls.Add(this.label3);
            this.DayCB.Controls.Add(this.label2);
            this.DayCB.Controls.Add(this.label1);
            this.DayCB.Controls.Add(this.Clrbtn);
            this.DayCB.Controls.Add(this.Searchbtn);
            this.DayCB.Controls.Add(this.dataGridView1);
            this.DayCB.Location = new System.Drawing.Point(4, 25);
            this.DayCB.Name = "DayCB";
            this.DayCB.Padding = new System.Windows.Forms.Padding(3);
            this.DayCB.Size = new System.Drawing.Size(1275, 397);
            this.DayCB.TabIndex = 1;
            this.DayCB.Text = "Delivery History";
            this.DayCB.UseVisualStyleBackColor = true;
            // 
            // MonthCB
            // 
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Location = new System.Drawing.Point(973, 85);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(75, 24);
            this.MonthCB.TabIndex = 16;
            // 
            // YearCB
            // 
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Location = new System.Drawing.Point(1054, 85);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(75, 24);
            this.YearCB.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(892, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // Accounttxt
            // 
            this.Accounttxt.Location = new System.Drawing.Point(892, 11);
            this.Accounttxt.Name = "Accounttxt";
            this.Accounttxt.Size = new System.Drawing.Size(237, 22);
            this.Accounttxt.TabIndex = 11;
            // 
            // ProductCB
            // 
            this.ProductCB.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ProductCB.FormattingEnabled = true;
            this.ProductCB.Location = new System.Drawing.Point(892, 309);
            this.ProductCB.Name = "ProductCB";
            this.ProductCB.Size = new System.Drawing.Size(237, 24);
            this.ProductCB.TabIndex = 10;
            // 
            // ReceiCB
            // 
            this.ReceiCB.FormattingEnabled = true;
            this.ReceiCB.Location = new System.Drawing.Point(892, 236);
            this.ReceiCB.Name = "ReceiCB";
            this.ReceiCB.Size = new System.Drawing.Size(237, 24);
            this.ReceiCB.TabIndex = 9;
            // 
            // DeliCB
            // 
            this.DeliCB.FormattingEnabled = true;
            this.DeliCB.Location = new System.Drawing.Point(892, 155);
            this.DeliCB.Name = "DeliCB";
            this.DeliCB.Size = new System.Drawing.Size(237, 24);
            this.DeliCB.TabIndex = 8;
            this.DeliCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delivering Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receiving Station";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clrbtn
            // 
            this.Clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clrbtn.Location = new System.Drawing.Point(1136, 85);
            this.Clrbtn.Name = "Clrbtn";
            this.Clrbtn.Size = new System.Drawing.Size(115, 44);
            this.Clrbtn.TabIndex = 2;
            this.Clrbtn.Text = "Clear";
            this.Clrbtn.UseVisualStyleBackColor = true;
            this.Clrbtn.Click += new System.EventHandler(this.Clrbtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.AutoSize = true;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(1136, 216);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(115, 44);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // Controltab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 450);
            this.Controls.Add(this.Account);
            this.Name = "Controltab";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controltab_FormClosing);
            this.Load += new System.EventHandler(this.Controltab_Load);
            this.Account.ResumeLayout(false);
            this.Accounttab.ResumeLayout(false);
            this.Changetab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Addtab.ResumeLayout(false);
            this.Addtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.DayCB.ResumeLayout(false);
            this.DayCB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Account;
        private System.Windows.Forms.TabPage Accounttab;
        private System.Windows.Forms.TabPage DayCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clrbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Accounttxt;
        private System.Windows.Forms.ComboBox ProductCB;
        private System.Windows.Forms.ComboBox ReceiCB;
        private System.Windows.Forms.ComboBox DeliCB;
        private System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox Deletetxt;
        private System.Windows.Forms.TextBox NewPWCFtxt;
        private System.Windows.Forms.TextBox NewPWtxt;
        private System.Windows.Forms.TextBox AccountChangetxt;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Reloadbtn;
        private System.Windows.Forms.TabControl Changetab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Addtab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}