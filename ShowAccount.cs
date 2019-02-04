using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BankManagement
{
    public partial class ShowAccount : Form
    {
        public ShowAccount()
        {
            InitializeComponent();
        }

        OleDbConnection myConn = new OleDbConnection();


        private void ShowAccount_Load(object sender, EventArgs e)
        {
            myConn.ConnectionString = DbConnection.dbConnect;
            txtIdShow.Text = DbConnection.custid;
            txtNameShow.Text = DbConnection.firstName;
            txtSurnameShow.Text = DbConnection.lastName;
        }
    }
}
