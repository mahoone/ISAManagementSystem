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
            //Establish connection on form load
            myConn.ConnectionString = DbConnection.dbConnect;
        }

        private void btnTaxCalculate_Click(object sender, EventArgs e)
        {

            double totalAccIneterest = 0.0;
            double balanceTotal;
            double accruedIntTotal;
            double annualRateTotal;
            double year = 365.0;

            if (myConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Open");
            }
            else
            {
                try
                {
                    string sql = "SELECT customer.title, customer.lastname, product.name, account.balance, account.accrued, product.intrate " +
                                 "FROM product INNER JOIN(customer INNER JOIN account ON customer.custID = account.custID) ON product.prodID = account.prodID;";


                    daCustomerOrders = new OleDbDataAdapter(sql, myConn);
                    dtCustomerOrders = new DataTable();
                    daCustomerOrders.Fill(dtCustomerOrders);

                    dtgShowTrans.DataSource = dtCustomerOrders;
                    
                    //Grab data from DGV
                    dtgShowTrans.Rows.OfType<DataGridViewRow>().ToList().ForEach(row =>
                    {
                        balanceTotal = Convert.ToDouble(row.Cells["balance"].Value);
                        accruedIntTotal = Convert.ToDouble(row.Cells["accrued"].Value);
                        annualRateTotal = Convert.ToDouble(row.Cells["intrate"].Value);

                        //perform the overnight calculation of accrued interest for all accounts
                        //Accrued Interest = Accrued Interest + (Balance * Account Annual Interest Rate / 365.0)
                        totalAccIneterest = accruedIntTotal + (balanceTotal * annualRateTotal / year);
                        totalAccIneterest = Math.Round(totalAccIneterest, 2);
                        totalAccIneterest.ToString();
                       
                        MessageBox.Show(totalAccIneterest.ToString());
                        txtTotalAnnual.Text = totalAccIneterest.ToString();

                        /*Trying to store results for individual acccounts in new column called "Total"
                        for (int i = 0; i < dtgShowTrans.Rows.Count; i++)
                        {
                            dtgShowTrans.Rows[i].Cells["Total"].Value = totalAccIneterest;
                            var rowNew = new DataGridViewRow();
                            dtgShowTrans.Rows.Add(rowNew);
                        }*/
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    
}
