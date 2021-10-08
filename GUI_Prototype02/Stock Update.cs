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
    public partial class Stock_Update : Form
    {
        public Stock_Update()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public void funcViewStock()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM STOCK WHERE Stock_ID = '"+Stock_Form.sID+"'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        public static string sStock_key;
        public static string sStock_Desc;
        public static double dWeight_per_Unit;
        public static int iQty_on_Hand;

        private void btnU_Click(object sender, EventArgs e)
        {
            if (tbStock_Key.Text.Length != 0)
                sStock_key = tbStock_Key.Text;

            if (tbStock_Desc.Text.Length != 0)
                sStock_Desc = tbStock_Desc.Text;

            if (tbWeight_per_Unit.Text.Length != 0)
                dWeight_per_Unit = double.Parse(tbWeight_per_Unit.Text);

            if (tbQty_on_Hand.Text.Length != 0)
                iQty_on_Hand = int.Parse(tbQty_on_Hand.Text);
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock_Form myMainMenu = new Stock_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void Stock_Update_Load(object sender, EventArgs e)
        {
            funcViewStock();
        }
    }
}
