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

        //Open ISA Products Form and show all available ISA's
        private void btnIsa_Click(object sender, EventArgs e)
        {
            IsaProducts isaForm = new IsaProducts();
            isaForm.Show();
        }

        //Open Tax Calculation Form
        private void btnCalcInterest_Click(object sender, EventArgs e)
        {
            TaxCalculation taxCal = new TaxCalculation();
            taxCal.Show();
        }

        //Open TotalForIsa form
        private void btnCalTotalIsa_Click(object sender, EventArgs e)
        {
            TotalForIsa totalForIsa = new TotalForIsa();
            totalForIsa.Show();
        }

        //Search for customers
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    string sql = "SELECT customer.title AS Title, customer.firstname AS FirstName, customer.lastname AS LastName," +
                    "customer.dob AS DOB, customer.natins AS Nationality, customer.email AS Email, customer.allowance AS Allowance FROM customer " +
                    "WHERE firstname = @firstname OR lastname = @lastname OR natins = @natins OR email = @email;";


                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@firstname", txtSearch.Text);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@lastname", txtSearch.Text);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@natins", txtSearch.Text);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@email", txtSearch.Text);

                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);

                    dtgAccounts.DataSource = dtCustomerOrders;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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


        //Show all Customers
        private void btnShowAllAccounts_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    string sql = "SELECT customer.custID AS CNO, customer.title AS Title, customer.firstname AS FirstName, customer.lastname AS LastName, customer.allowance AS CustomerAllowance, " +
                    "customer.dob AS DOB, customer.natins AS Nationality, customer.email AS Email FROM customer;";


                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);

                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);

                    dtgAccounts.DataSource = dtCustomerOrders;

                    //Hide 'ID' column
                    this.dtgAccounts.Columns["CNO"].Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //Show all accounts for individual customers
        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    string sql = "SELECT customer.custID AS CNO, product.name, account.balance, account.accrued AS InterestAccrued  FROM product INNER JOIN " +
                        "(customer INNER JOIN account ON customer.custID = account.custID) ON product.prodID = account.prodID WHERE (((customer.custID) = @custID));";


                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@custID", DbConnection.custID);
                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);
                    

                    dtgAccounts.DataSource = dtCustomerOrders;
                    //Hide 'ID' column
                    this.dtgAccounts.Columns["CNO"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //Select Row in dataGrid with right mouse 
        private void dtgAccounts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            myConn.ConnectionString = DbConnection.dbConnect;
            if (e.Button == MouseButtons.Right)
            {
                // Add this
                dtgAccounts.CurrentCell = dtgAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex];

                dtgAccounts.Rows[e.RowIndex].Selected = true;
                dtgAccounts.Focus();

                DbConnection.custID = dtgAccounts[0, e.RowIndex].Value.ToString();
            }
        }

       

        //View transactions per customer
        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    string sql = "SELECT customer.custID, product.name AS ISAProduct, account.balance, tranx.action, tranx.amnt AS Amount£, tranx.event AS DateOfTransaction FROM(product INNER " + "" +
                                "JOIN(customer INNER JOIN account ON customer.custID = account.custID) ON product.prodID = account.prodID) INNER JOIN tranx ON account.accID = tranx.accID " +
                                "WHERE(((customer.custID) = @custID)) ORDER BY tranx.event DESC;";


                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@custID", DbConnection.custID);
                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);
                    
                    dtgAccounts.DataSource = dtCustomerOrders;
                    //Hide 'ID' column
                    this.dtgAccounts.Columns["custID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
    }
}
