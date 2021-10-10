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
    public partial class Order_Update : Form
    {
        public Order_Update()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public void funcView()
        {
            sqlCon.Open();
            string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, D.Order_Detail_ID, D.Order_ID, D.Stock_ID, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL D WHERE (O.Order_ID = D.Order_ID) AND ((O.Order_ID = '"+Order_Form.oID+"') OR (D.Order_Detail_ID = '"+Order_Form.oIDD+"'))";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(6) + "\t\t" + read.GetValue(2) + "\t" + read.GetValue(3) + "\t" + read.GetValue(7) + "\t\t" + read.GetValue(8) + "\t\t\t" + read.GetValue(9));
            }

            sqlCon.Close();
        }

        public static DateTime sDate_Ordered;
        public static DateTime sDate_Received;
        public static int iQty_Ordered;
        public static double dPrice_per_Kg;
        public static double dPrice_per_Unit;

        private void Order_Update_Load(object sender, EventArgs e)
        {
            funcView();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            sDate_Ordered = dTP_Ordered.Value.Date;
            sDate_Received = dTP_Received.Value.Date;

            if(tbQty_Ordered.Text.Length!=0)
                iQty_Ordered = int.Parse(tbQty_Ordered.Text);

            if (tbPrice_per_KG.Text.Length != 0)
                dPrice_per_Kg = double.Parse(tbPrice_per_KG.Text);

            if (tbPrice_per_Unit.Text.Length != 0)
                dPrice_per_Unit = double.Parse(tbPrice_per_Unit.Text);
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Order_Form myMainMenu = new Order_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }
    }
}
