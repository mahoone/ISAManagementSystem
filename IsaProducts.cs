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
    public partial class IsaProducts : Form
    {
        public IsaProducts()
        {
            InitializeComponent();
        }

        //Database connection
        OleDbConnection myConn = new OleDbConnection();
        DataTable dtCustomerOrders = null;
        OleDbDataAdapter daCustomerOrders = null;
        DataSet myDS = new DataSet();

        //Populate DTG with ISA Products from Database
        private void IsaProducts_Load(object sender, EventArgs e)
        {
            load_data();
        }

        //Load all ISA products
        private void load_data()
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    //Establish connection on form load
                    myConn.ConnectionString = DbConnection.dbConnect;

                    string sql = "SELECT product.prodID AS IsaIndex, product.name AS Product, product.status AS Status , product.transin AS TransferAllowed, product.intrate AS TaxFreeRate FROM product; ";


                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);

                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);

                    dtgIsa.DataSource = dtCustomerOrders;

                    //Hide 'ID' column
                    this.dtgIsa.Columns["IsaIndex"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Populate TextBoxes with data from DTG after row is clicked
        private void dtgIsa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgIsa.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                DbConnection.prodID = dtgIsa[0, e.RowIndex].Value.ToString();
                string product = dtgIsa[1, e.RowIndex].Value.ToString();
                string status = dtgIsa[2, e.RowIndex].Value.ToString();
                string tranllow = dtgIsa[3, e.RowIndex].Value.ToString();
                string rate = dtgIsa[4, e.RowIndex].Value.ToString();

                txtIsaProduct.Text = product;
                cbIsaStatus.Text = status;
                cbIsaTranAllow.Text = tranllow;
                txtIsaTfr.Text = rate;
            }
        }

        //Save any changes to database
        private void btnIsaSave_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    if (cbIsaStatus.Text != "" && cbIsaTranAllow.Text != "" && txtIsaTfr.Text != "")
                    {
                        string sql = @"UPDATE product Set status = @status, transin = @transin, intrate = @rate WHERE prodID = @prodID;";

                        daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                        daCustomerOrders.SelectCommand.Parameters.AddWithValue("@status", cbIsaStatus.Text);
                        daCustomerOrders.SelectCommand.Parameters.AddWithValue("@transin", cbIsaTranAllow.Text);
                        daCustomerOrders.SelectCommand.Parameters.AddWithValue("@rate", txtIsaTfr.Text);
                        daCustomerOrders.SelectCommand.Parameters.AddWithValue("@prodID", DbConnection.prodID);
                        dtCustomerOrders = new DataTable();
                        daCustomerOrders.Fill(dtCustomerOrders);

                        dtgIsa.DataSource = dtCustomerOrders;
                        load_data();
                        MessageBox.Show("Record Updated Successfully");

                        dtgIsa.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Record To Update");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Exit form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


