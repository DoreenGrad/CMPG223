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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainMenuForm myMainMenu = new MainMenuForm();
            myMainMenu.ShowDialog();
            Close();
        }
    }
}
