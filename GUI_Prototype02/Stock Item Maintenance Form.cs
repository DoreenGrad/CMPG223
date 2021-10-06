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

// get and set methods
// try catch
// sql code
// tab / click events
// documentation

namespace GUI_Prototype02
{
    public partial class ProductForm : Form
    {

        public ProductForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
        public void funcView()
        {
            sqlCon.Open();

            //string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, D.Order_Detail_ID, D.Stock_Key, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL D";
            string viewData = "SELECT * FROM STOCK";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            DataSet DA = new DataSet();

            sqlDA.SelectCommand = sqlCom;
            sqlDA.Fill(DA, "STOCK");

            dgView.DataSource = DA;
            dgView.DataMember = "STOCK";

            sqlCon.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBUnitWeightPerUnit_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtBPricePerKg_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTxtBProductKey_Click(object sender, EventArgs e)
        {
        
        }

        private void txtBProductType_Click(object sender, EventArgs e)
        {
        }

        private void txtBProductDescription_Click(object sender, EventArgs e)
        {
          
        }

        private void txtBWeightPerUnit_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBPricePerKg_Click(object sender, EventArgs e)
        {
          
        }

        private void txtBPricePerUnit_Click(object sender, EventArgs e)
        {
          
        }

        private void txtBStock_Click(object sender, EventArgs e)
        {
        }

        private void btnViewUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            Stock_Insert insert = new Stock_Insert();
            LoginForm01 user = new LoginForm01();
            insert.ShowDialog();

            sqlCon.Open();

            string insertData1 = "INSERT INTO STOCK(Stock_Key, Stock_Description, Weight_per_Unit, Qty_on_Hand) VALUES(@sk, @sd, @wpu, @qoh)";
            SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
            sqlCom1.Parameters.AddWithValue("@sk", insert.sStock_key);
            sqlCom1.Parameters.AddWithValue("@sd", insert.sStock_Desc);
            sqlCom1.Parameters.AddWithValue("@wpu", insert.dWeight_per_Unit);
            sqlCom1.Parameters.AddWithValue("@qoh", insert.iQty_on_Hand);
            sqlCom1.ExecuteNonQuery();

            sqlCon.Close();
        }
    }
}
