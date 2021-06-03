using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string user = "";
        public Form2(string user)
        {
            InitializeComponent();
            List<string> DeliveringStation = new List<string> { " ", "Station E", "Station F", "Station G" };
            List<string> ReceivingStation = new List<string> { " ", "Station A", "Station B", "Station C" };
            List<string> Product = new List<string> { "None", "Type 1", "Type 2", "Type 3" };
            RCstationcb.DataSource = ReceivingStation;
            cmbDeliver1.DataSource = DeliveringStation;
            cmbMaterial.DataSource = Product;
            this.user = user;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string query = "insert into HistoryDelivery values ('" + user + "','" + Hiden.Date(time.ToString()) + "','" + Hiden.filter(RCstationcb.SelectedItem.ToString()) + "','" + Hiden.filter(cmbDeliver1.SelectedItem.ToString()) + "','" + cmbMaterial.SelectedItem.ToString() + "')";
            Hiden.Data(query);
            RCstationcb.SelectedIndex = 0;
            cmbDeliver1.SelectedIndex = 0;
            cmbMaterial.SelectedIndex = 0;
            MessageBox.Show("Your request has been successful");
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
