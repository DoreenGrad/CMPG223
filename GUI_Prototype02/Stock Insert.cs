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
    public partial class StocInsertUpdateForm : Form
    {
        public StocInsertUpdateForm()
        {
            InitializeComponent();
        }

        //public variables to access on the main form
        public string sStock_key;
        public string sStock_Desc;
        public double dWeight_per_Unit;
        public int iQty_on_Hand;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbWeight_per_Unit.Text, out dWeight_per_Unit))
            {
                if (int.TryParse(tbQty_on_Hand.Text, out iQty_on_Hand))
                {
                    sStock_key = tbStock_Key.Text;
                    sStock_Desc = tbStock_Desc.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Quantity on hand must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Weight per unit must be numeric");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock_Form myMainMenu = new Stock_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }
    }
}
