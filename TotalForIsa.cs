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
    public partial class TotalForIsa : Form
    {
        public TotalForIsa()
        {
            InitializeComponent();
        }

        //Database connection
        OleDbConnection myConn = new OleDbConnection();
        DataTable dtCustomerOrders = null;
        OleDbDataAdapter daCustomerOrders = null;
        DataSet myDS = new DataSet();

        private void TotalForIsa_Load(object sender, EventArgs e)
        {
            //Establish connection on form load
            myConn.ConnectionString = DbConnection.dbConnect;
        }


        //Add total invested in all ISA accounts for individual customer
        private void btnTotalInvested_Click(object sender, EventArgs e)
        {
            // make sure user select at least 1 row 
            if (dtgCustomerIsaTotal.SelectedRows.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < dtgCustomerIsaTotal.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dtgCustomerIsaTotal.Rows[i].Cells[5].Value);
                }
                txtTotalIsa.Text = sum.ToString();
            }
        }

        //Search for customer based on first or last name
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
                    //Search customer, account and product tables based on first/last names of customers
                    string sql = "SELECT customer.custID AS CNO, customer.title AS Title, customer.firstname AS FirstName," +
                       " customer.lastname AS LastName, product.name, account.balance, account.accrued AS InterestAccrued  FROM product INNER JOIN " +
                       "(customer INNER JOIN account ON customer.custID = account.custID) ON product.prodID = account.prodID WHERE firstname = @firstname OR lastname = @lastname;";

                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@firstname", txtSearchTwo.Text);
                    daCustomerOrders.SelectCommand.Parameters.AddWithValue("@lastname", txtSearchTwo.Text);

                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);

                    dtgCustomerIsaTotal.DataSource = dtCustomerOrders;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Clear search box
        bool firstTime = true;
        private void txtSearchTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstTime)
            {
                firstTime = false;
                txtSearchTwo.Clear();
            }
        }


        //Pop up message on form load
        private void TotalForIsa_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Please search for customer using First or Last name.");
        }

        //Exit app
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
