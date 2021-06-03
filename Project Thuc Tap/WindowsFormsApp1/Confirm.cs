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
    public partial class Confirm : Form
    { 
        public string newpassword;
        public string ChangedAccount;
        public string deleteAccount = "";

        public Confirm(string newpassword,string ChangedAccount)
        {
            InitializeComponent();
            this.newpassword = newpassword;
            this.ChangedAccount = ChangedAccount;
        }
        public Confirm()
        {
            InitializeComponent();
        }
        public Confirm(string deleteAccount)
        {
            InitializeComponent(); 
            this.deleteAccount = deleteAccount;
        }
        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            string query;
            if (AccountCFtxt.Text.ToString() == "admin" && PasstCFxt.Text.ToString() == "admin")
            {
                if (this.deleteAccount != "")
                {
                    query = "delete from Account where Account='" + this.deleteAccount + "'";
                }
                else
                    query = "update Account set Password='" + this.newpassword + "' where Account.Account='" + this.ChangedAccount + "'";
                Hiden.Data(query);
                MessageBox.Show("Your update is successful");

                this.Close();
            }
            else
                MessageBox.Show("Your account is not authorized or not correct");
        }
    }
}
