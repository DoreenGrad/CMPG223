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
    public partial class Order_Form : Form
    {
        public Order_Form()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
        public void funcView()
        {
            sqlCon.Open();

            //string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, D.Order_Detail_ID, D.Stock_Key, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL D";
            string viewData = "SELECT * FROM ORDERS";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            DataSet DA = new DataSet();

            sqlDA.SelectCommand = sqlCom;
            sqlDA.Fill(DA, "ORDERS");
            //sqlDA.Fill(DA, "ORDERS_DETAIL");

            dgView.DataSource = DA;
            dgView.DataMember = "ORDERS";
            //dgView.DataMember = "ORDERS_DETAIL";

            sqlCon.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //try
           // {
                OrderInsertUpdateForm insert = new OrderInsertUpdateForm();
                LoginForm01 user = new LoginForm01();
                insert.ShowDialog();

                sqlCon.Open();

                string insertData1 = "INSERT INTO ORDERS(User_ID, Date_Ordered, Date_Received) VALUES(@ui, @d_o, @d_r)";
                SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@ui", user.userID);
                sqlCom1.Parameters.AddWithValue("@d_o", insert.sDate_Ordered);
                sqlCom1.Parameters.AddWithValue("@d_r", insert.sDate_Received);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();

            /*string query1 = "SELECT Order_ID FROM TableName WHERE id=(SELECT max(id) FROM TableName);";
            SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
            sqlCmd1.Parameters.AddWithValue("@username", username.Trim()); //trim is for white spaces
            sqlCmd1.Parameters.AddWithValue("@password", password.Trim());
            userID = int.Parse(sqlCmd1.ExecuteScalar().ToString());

            sqlCon.Open();*/

            /*string insertData2 = "INSERT INTO ORDERS_DETAIL(Stock_Key, Qty_Ordered, Price_per_KG, Price_per_Unit) VALUES(@qty, @kg, @unit)";
            SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
            sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
            sqlCom2.Parameters.AddWithValue("@qty", insert.iQty_Ordered);
            sqlCom2.Parameters.AddWithValue("@kg", insert.dPrice_per_Kg);
            sqlCom2.Parameters.AddWithValue("@unit", insert.dPrice_per_Unit);
            sqlCom2.ExecuteNonQuery();

            sqlCon.Close();
            funcView();*/
           // }
           // catch
           // {
                //MessageBox.Show("Something went wrong :c");
           // }
        }

        private void Order_Form1_Load(object sender, EventArgs e)
        {
            funcView();
        }
    }
}
