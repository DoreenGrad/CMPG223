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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainMenuForm myMainMenu = new MainMenuForm();
            myMainMenu.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlOrders.Visible = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock_Form myMainMenu = new Stock_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (lblErrors.Text == "Hide common Errors")
            {
                rtxErrors.Visible = false;
                lblErrors.Text = "Show common Errors";
            }
            else
            {
                rtxErrors.Visible = true;
                lblErrors.Text = "Hide common Errors";
            }
           
        }
    }
}
