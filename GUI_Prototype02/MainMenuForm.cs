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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void productsTool_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            salesForm mySales = new salesForm();
            mySales.ShowDialog();


            this.Visible = true;
        }

        private void reportTool_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            ReportForm myReport = new ReportForm();
            myReport.ShowDialog();

            this.Visible = true;
        }

        private void helpTool_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            HelpForm myHelp = new HelpForm();
            myHelp.ShowDialog();

            this.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//Testing
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Order_Form myMainMenu = new Order_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock_Form myMainMenu = new Stock_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            salesForm myMainMenu = new salesForm();
            myMainMenu.ShowDialog();
            this.Close();
        }
    }
}
