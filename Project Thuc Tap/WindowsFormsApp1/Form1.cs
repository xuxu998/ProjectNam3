using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = SignInbtn;
           // pictureBox1.Image = Image.FromFile(@"E:\Code Visual\User.PNG");
           // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataTable GetData(string query)
        {
            string connectionString = @"Data Source=DESKTOP-7FQCTM2\SQLEXPRESS;Initial Catalog=Dat;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(data);
                connection.Close();
            }
            return data;

        }
        void CheckAccount()
        {
            int i = 0;
            if(Accounttxt.Text.ToString()=="admin"&& Passtxt.Text.ToString()=="admin")
            {
                Controltab controltab = new Controltab();
                this.Hide();
                controltab.ShowDialog();
                this.Show(); i = 1;
            }
            if (i == 0)
            {
                //if (GetData("select * from Account where Account ='" + Accounttxt.Text.ToString() + "' and Password='" + Passtxt.Text.ToString() + "'").Rows.Count != 0)
                //{
                    AGVData form = new AGVData(Accounttxt.Text.ToString());
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
               // }
               // else MessageBox.Show("Your account does not exist");
            }

        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            CheckAccount();
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

       
    }
}
