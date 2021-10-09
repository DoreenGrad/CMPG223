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
    public partial class Sale_Update : Form
    {
        public Sale_Update()
        {
            InitializeComponent();
        }


        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public void funcViewSALE()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM SALE WHERE Sale_ID = '" + salesForm.sID + "'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1));
            }

            sqlCon.Close();
        }

        public void funcViewSALE_DETAIL()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM SALE_DETAIL WHERE Sale_Detail_ID = '" + salesForm.sIDD + "'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView2.Items.Clear();
            while (read.Read())
            {
                lbView2.Items.Add(read.GetValue(0) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        public static DateTime dSale_Date;
        public static double dSales_Price_per_Unit;
        public static int dQty_Sold;

        private void btnU_Click(object sender, EventArgs e)
        {
            dSale_Date = dTP_Saledate.Value.Date;

            if (tbSale_Price.Text.Length != 0)
                dSales_Price_per_Unit = double.Parse(tbSale_Price.Text);

            if (tbQty_Sold.Text.Length != 0)
                dQty_Sold = int.Parse(tbQty_Sold.Text);
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            salesForm myMainMenu = new salesForm();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void Sale_Update_Load(object sender, EventArgs e)
        {
            funcViewSALE();
            funcViewSALE_DETAIL();
        }
    }
}
