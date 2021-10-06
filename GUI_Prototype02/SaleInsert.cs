using System;
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
    public partial class SaleInsertForm : Form
    {
        public SaleInsertForm()
        {
            InitializeComponent();
        }

        //public variables to access on the main form
        public DateTime dSale_Date;
        public int dQty_Sold;
        public double dSales_Price_per_Unit;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out dQty_Sold))
            {
                if (double.TryParse(txtSalePrice.Text, out dSales_Price_per_Unit))
                {                               
                    if (DateTime.TryParse(mtbSaleDate.Text, out dSale_Date))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sale date must be a date");

                    }
                }
                else
                {
                    MessageBox.Show("Price per unit must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Quantity ordered must be numeric");
            }
        }
    }
}
