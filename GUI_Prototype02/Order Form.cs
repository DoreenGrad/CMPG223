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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
        public void funcView()
        {
            sqlCon.Open();

            string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received" +
                "D.Order_Detail_ID, D.Stock_ID, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit " +     
                "FROM ORDERS O, Order_Detail D";

            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            DataSet DA = new DataSet();

            sqlDA.SelectCommand = sqlCom;
            sqlDA.Fill(DA, "ORDERS");
            sqlDA.Fill(DA, "Order_Detail");

            dgView.DataSource = DA;
            dgView.DataMember = "ORDERS";
            dgView.DataMember = "Order_Detail";

            sqlCon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OrderInsertForm insert = new OrderInsertForm();
                insert.ShowDialog();

                sqlCon.Open();

                string insertData1 = "INSERT INTO ORDERS(Date_Ordered, Date_Received) VALUES(@d_o, @d_r)";
                SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@d_o", insert.sDate_Ordered);
                sqlCom1.Parameters.AddWithValue("@director", insert.sDate_Received);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();

                sqlCon.Open();

                string insertData2 = "INSERT INTO Order_Detail(Qty_Ordered, Price_per_KG, Price_per_Unit) VALUES(@qty, @kg, @unit)";
                SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@qty", insert.iQty_Ordered);
                sqlCom2.Parameters.AddWithValue("@kg", insert.dPrice_per_Kg);
                sqlCom2.Parameters.AddWithValue("@unit", insert.dPrice_per_Unit);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();
                funcView();
            }
            catch
            {
                MessageBox.Show("Something went wrong :c");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            funcView();
        }
    }
}
