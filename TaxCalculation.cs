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
using System.Globalization;
using System.Text.RegularExpressions;

namespace BankManagement
{
    public partial class TaxCalculation : Form
    {
        public TaxCalculation()
        {
            InitializeComponent();
        }

        //Database connection
        OleDbConnection myConn = new OleDbConnection();
        DataTable dtCustomerOrders = null;
        OleDbDataAdapter daCustomerOrders = null;
        DataSet myDS = new DataSet();

        private void TaxCalculation_Load(object sender, EventArgs e)
        {
            //Fill DGV with data
            load_all_customers();
        }

        //Grab all information needed to calculate accrued interest for each account.
        private void load_all_customers()
        {
            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    myConn.ConnectionString = DbConnection.dbConnect;

                    string sql = "SELECT customer.title, customer.lastname, product.name, account.balance, account.accrued, product.intrate " +
                                 "FROM product INNER JOIN(customer INNER JOIN account ON customer.custID = account.custID) ON product.prodID = account.prodID;";

                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);

                    dtgShowTrans.DataSource = dtCustomerOrders;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Select Row in dataGrid with right mouse 
        private void dtgShowTrans_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            myConn.ConnectionString = DbConnection.dbConnect;
            if (dtgShowTrans.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                dtgShowTrans.CurrentCell = dtgShowTrans.Rows[e.RowIndex].Cells[e.ColumnIndex];

                dtgShowTrans.Rows[e.RowIndex].Selected = true;
                dtgShowTrans.Focus();

                string customerName = dtgShowTrans[1, e.RowIndex].Value.ToString();
                string productName = dtgShowTrans[2, e.RowIndex].Value.ToString();
                string balanceTotal = dtgShowTrans[3, e.RowIndex].Value.ToString();
                string accruedIntTotal = dtgShowTrans[4, e.RowIndex].Value.ToString();

                txtCustSurname.Text = customerName;
                txtProduct.Text = productName;
                txtBalance.Text = balanceTotal;
                txtAccrued.Text = accruedIntTotal;
            }
        }

        //Calculate of accrued interest for all selected accounts
        private void btnTaxCalculate_Click(object sender, EventArgs e)
        {
            if (dtgShowTrans.SelectedRows.Count > 0) // make sure user select at least 1 row
            {
                //If validation successfull - show message to user
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtCustSurname.Text != "" && txtProduct.Text != "" && txtBalance.Text != "" && txtAccrued.Text != "")
                    {
                        //Regular expression validation 
                        string expression = @"^(0*100{1,1}\.?((?<=\.)0*)?%?$)|(^0*\d{0,2}\.?((?<=\.)\d*)?%?)$";
                        Regex objNotNumberPattern = new Regex(expression);
                        if (objNotNumberPattern.IsMatch(txtAnnualInterest.Text))
                        {
                            double totalAccIneterest = 0.0;
                            double year = 365.0;

                            double x = 0;
                            double y = 0;
                            double z = 0;

                            Double.TryParse(txtAccrued.Text, out x);
                            Double.TryParse(txtBalance.Text, out y);
                            Double.TryParse(txtAnnualInterest.Text, out z);

                            //perform the overnight calculation of accrued interest for all accounts
                            //Accrued Interest = Accrued Interest + (Balance * Account Annual Interest Rate / 365.0)
                            totalAccIneterest = x + (y * z / year);
                            totalAccIneterest = Math.Round(totalAccIneterest, 2);
                            totalAccIneterest.ToString();

                            txtTotalAnnual.Text = totalAccIneterest.ToString("P", CultureInfo.InvariantCulture);

                            MessageBox.Show("Total annual tax is " + txtTotalAnnual.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Please enter percentage values only");
                        }
                    }
                }
            }
        }

        //Textbox validation for tax free textbox
        private void txtAnnualInterest_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnnualInterest.Text))
            {
                e.Cancel = true;
                txtAnnualInterest.Focus();
                errorProvider2.SetError(txtAnnualInterest, "Please enter valid Annual Tax Rate in %");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtAnnualInterest, null);
            }
        }

        // Additional textbox validation, max 100, min 0.
        private void txtAnnualInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        //Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
