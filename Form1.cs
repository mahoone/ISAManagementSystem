﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtShowCustomers_Click(object sender, EventArgs e)
        {
            viewCustomers vc;
            vc = new viewCustomers();
            vc.ShowDialog();
        }
    }
}