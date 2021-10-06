﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Prototype02
{
    public partial class OrderInsertForm : Form
    {
        public OrderInsertForm()
        {
            InitializeComponent();
        }

        //public variables to access on the main form
        public string sDate_Ordered;
        public string sDate_Received;
        public int iQty_Ordered;
        public double dPrice_per_Kg;
        public double dPrice_per_Unit;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if(int.TryParse(tbQty_Ordered.Text, out iQty_Ordered))
            {
                if(double.TryParse(tbPrice_per_Kg.Text, out dPrice_per_Kg))
                {
                    if (double.TryParse(tbPrice_per_Unit.Text, out dPrice_per_Unit))
                    {
                        sDate_Ordered = tbDate_Ordered.Text;
                        sDate_Received = tbDate_Received.Text;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Price per kg must be numeric");
                    }
                }
                else
                {
                    MessageBox.Show("Price per kg must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Quantity ordered must be numeric");
            }

        }
    }
}
