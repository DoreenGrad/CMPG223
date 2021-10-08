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

        public void funcViewORDERS()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM ORDERS WHERE Order_ID = '"+Order_Form.oID+"'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3));
            }

            sqlCon.Close();
        }

        public void funcViewORDERS_DETAILS1()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM ORDERS_DETAIL WHERE Order_ID = '" + Order_Form.oID + "'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView2.Items.Clear();
            while (read.Read())
            {
                lbView2.Items.Add(read.GetValue(0) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(5));
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
            funcViewORDERS();
            funcViewORDERS_DETAILS1();
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
