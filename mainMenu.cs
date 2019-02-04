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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Database connection
        OleDbConnection myConn = new OleDbConnection();
        DataTable dtCustomerOrders = null;
        OleDbDataAdapter daCustomerOrders = null;
        DataSet myDS = new DataSet();

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Establish connection on form load
            myConn.ConnectionString = DbConnection.dbConnect;
        }


        //Search on First Name basis --- Change to different search method
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT customer.title AS Title, customer.firstname AS FirstName, customer.lastname AS LastName," +
                "customer.dob AS DOB, customer.natins AS Nationality, customer.email AS Email, customer.allowance AS Allowance FROM customer WHERE firstname = @firstname;";


            daCustomerOrders = new OleDbDataAdapter(sql, myConn);
            daCustomerOrders.SelectCommand.Parameters.AddWithValue("@firstname", txtSearch.Text);

            dtCustomerOrders = new DataTable();
            daCustomerOrders.Fill(dtCustomerOrders);

            dtgAccounts.DataSource = dtCustomerOrders;
        }

        //Reset Search Text Box after first time use - click
        bool firstTime = true;
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (firstTime)
                {
                    firstTime = false;
                    txtSearch.Clear();
                }
            }
        }

        //Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Show all accounts
        private void btnShowAllAccounts_Click(object sender, EventArgs e)
        {
            string sql = "SELECT customer.title AS Title, customer.firstname AS FirstName, customer.lastname AS LastName," + 
                "customer.dob AS DOB, customer.natins AS Nationality, customer.email AS Email, customer.allowance AS Allowance FROM customer;";


            daCustomerOrders = new OleDbDataAdapter(sql, myConn);

            dtCustomerOrders = new DataTable();
            daCustomerOrders.Fill(dtCustomerOrders);

            dtgAccounts.DataSource = dtCustomerOrders;
        }

        private void dtgAccounts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }
    }
}
