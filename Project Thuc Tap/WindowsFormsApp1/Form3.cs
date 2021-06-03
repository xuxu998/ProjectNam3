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
    public partial class Controltab : Form
    {
        public Controltab()
        {
            InitializeComponent();
            this.AcceptButton = Searchbtn;
            List<string> DeliveringStation = new List<string> { " ", "Station 1" , "Station 2"  };
            List<string> ReceivingStation = new List<string> { " ", "Station 1", "Station 2", "Station 3" };
            List<string> Product = new List<string> {" ", "Type 1","Type 2","Type 3"};
            List<string> Year = new List<string> {"    ","2021","2020","2019","2018","2017","2016","2015" };
            List<string> Month = new List<string> { "  ", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            List<string> Day = new List<string> { "  ", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            DeliCB.DataSource = DeliveringStation;
            ReceiCB.DataSource = ReceivingStation;
            ProductCB.DataSource = Product;
            YearCB.DataSource = Year;
            MonthCB.DataSource = Month;
            comboBox1.DataSource = Day;
            dataGridView2.DataSource = Hiden.Data("select * from Account");
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void Controltab_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string account =Accounttxt.Text.ToString();
            string date = YearCB.SelectedItem.ToString() + MonthCB.SelectedItem.ToString() + comboBox1.SelectedItem.ToString(); 
            string deli = Hiden.filter(DeliCB.SelectedItem.ToString());
            string recei = Hiden.filter(ReceiCB.SelectedItem.ToString());
            string product = ProductCB.SelectedItem.ToString();
          dataGridView1.DataSource = Hiden.Data(Hiden.decode(Hiden.ToInt(account,date,deli,recei,product),account,date,deli,recei,product));
          //textBox1.Text = Hiden.decode(Hiden.ToInt(account, date, deli, recei, product), account, date, deli, recei, product);
        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            DeliCB.SelectedIndex = 0;
            ReceiCB.SelectedIndex = 0;
            ProductCB.SelectedIndex = 0;
            Accounttxt.Text = "";
            YearCB.SelectedIndex = 0;
            MonthCB.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void Controltab_Load(object sender, EventArgs e)
        {

        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            if (NewPWCFtxt.Text.ToString() == NewPWtxt.Text.ToString())
            {
                Confirm confirm = new Confirm(NewPWCFtxt.Text.ToString(),AccountChangetxt.Text.ToString());
                this.Hide();
                confirm.ShowDialog();
                NewPWCFtxt.Text = "";
                NewPWtxt.Text = "";
                AccountChangetxt.Text = "";
                this.Show();
     
            }
            else
            {
                MessageBox.Show("Your new password and confirmed password do not match each other. You need to check again");
            }
            //GetData("update account set password='1234' where account.account='user2'");
        }

        private void Reloadbtn_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource=Hiden.Data("select * from Account");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Deletetxt.Text.ToString()!="admin")
            {
                Confirm confirm = new Confirm(Deletetxt.Text.ToString());
                this.Hide();
                confirm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You can not delete this account");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
