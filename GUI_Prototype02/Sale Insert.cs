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
    public partial class insertSaleForm : Form
    {
        public insertSaleForm()
        {
            InitializeComponent();
        }

        //public variables to access on the main form
        public DateTime dSale_Date;
        public double dSales_Price_per_Unit;
        public int dQty_Sold;
        public string sStock_Key;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbSale_Price_per_Unit.Text, out dSales_Price_per_Unit))
            {                               
                if (int.TryParse(tb_Qty_Sold.Text, out dQty_Sold))
                {
                    dSale_Date = dTP_Saledate.Value.Date;
                    sStock_Key = tbStock_Key.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Quantity sold must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Price per unit must be numeric");
            }    
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            salesForm myMainMenu = new salesForm();
            myMainMenu.ShowDialog();
            this.Close();
        }
    }
}
