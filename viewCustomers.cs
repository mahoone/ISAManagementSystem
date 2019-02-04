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
    public partial class viewCustomers : Form
    {
        public viewCustomers()
        {
            InitializeComponent();
        }

        OleDbConnection myConn = new OleDbConnection();
        DataTable dtCustomerOrders = null;
        OleDbDataAdapter daCustomerOrders = null;
        DataSet myDS = new DataSet();

        private void viewCustomers_Load(object sender, EventArgs e)
        {
            myConn.ConnectionString = DbConnection.dbConnect;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM account WHERE firstname = @firstname;"; 


            daCustomerOrders = new OleDbDataAdapter(sql, myConn);
            daCustomerOrders.SelectCommand.Parameters.AddWithValue("@firstname", txtSearch.Text);

            dtCustomerOrders = new DataTable();
            daCustomerOrders.Fill(dtCustomerOrders);

            dtgShowCustomers.DataSource = dtCustomerOrders;
        }

        private void dtgShowCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnection.custid = dtgShowCustomers[0, e.RowIndex].Value.ToString();
            DbConnection.firstName = dtgShowCustomers[1, e.RowIndex].Value.ToString();
            DbConnection.lastName = dtgShowCustomers[2, e.RowIndex].Value.ToString();
            ShowAccount vc;
            vc = new ShowAccount();
            vc.ShowDialog();
        }
    }
}
