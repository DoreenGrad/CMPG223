using System;
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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        bool firstClick = true;
        bool firstclickST = true;
        bool firstclickS = true;
        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainMenuForm myMainMenu = new MainMenuForm();
            myMainMenu.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (firstClick == true)
            {
                pnlOrders.Visible = true;
                firstClick = false;
            }
            else
                 if (firstClick == false)
            {
                pnlOrders.Visible = false;
                firstClick = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (firstclickST == true)
            {
                pnlStock.Visible = true;
                firstclickST = false;
            }
            else
                 if (firstclickST == false)
            {
                pnlStock.Visible = false;
                firstclickST = true;
            }
        }

        private void lblSales_Click(object sender, EventArgs e)
        {
            if (firstclickS == true)
            {
                pnlSales.Visible = true;
                firstclickS = false;
            }
            else
                if (firstclickS == false)
            {
                pnlSales.Visible = false;
                firstclickS = true;
            }
        }
    }
}
