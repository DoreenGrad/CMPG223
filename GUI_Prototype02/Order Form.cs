﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Prototype02
{
    public partial class Order_Form : Form
    {
        public Order_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderInsert insert = new OrderInsert();

            insert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
