using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    class DbConnection
    {
        public static readonly string dbConnect = @"Provider = Microsoft.ACE.OLEDB.12.0;"
          + @"Data Source = " + Application.StartupPath + @"\dbOutlawHess.mdb";

        //Customer Data
        public static string custID;
        public static string firstName;
        public static string lastName;


        //Product Data
        public static string prodID;
    }
}
