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
using System.IO;

namespace GUI_Prototype02
{
    public partial class Order_Form : Form
    {
        public Order_Form()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security = True");
        
        public void funcViewORDERS()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM ORDERS";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3));
            }

            sqlCon.Close();
        }

        public void funcViewORDERS_DETAILS()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM ORDERS_DETAIL";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView2.Items.Clear();
            while (read.Read())
            {
                lbView2.Items.Add(read.GetValue(0) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(5));
            }

            sqlCon.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int userID = 0;
            int orderID = 0;

            this.Visible = false;
            Authentication_Form auth = new Authentication_Form();
            auth.ShowDialog();
            OrderInsertUpdateForm insert = new OrderInsertUpdateForm();
            insert.ShowDialog();
            this.Visible = true;

            sqlCon.Open();

            string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
            SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
            sqlCmd1.Parameters.AddWithValue("@username", auth.sUsername); 
            sqlCmd1.Parameters.AddWithValue("@password", auth.sPassword);
            userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

            string insertData1 = "INSERT INTO ORDERS(User_ID, Date_Ordered, Date_Received) VALUES(@ui, @d_o, @d_r)";
            SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
            sqlCom1.Parameters.AddWithValue("@ui", userID);
            sqlCom1.Parameters.AddWithValue("@d_o", insert.sDate_Ordered);
            sqlCom1.Parameters.AddWithValue("@d_r", insert.sDate_Received);
            sqlCom1.ExecuteNonQuery();

            string query2 = "SELECT TOP 1 Order_ID FROM ORDERS ORDER BY Order_ID DESC";
            SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
            orderID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

            string insertData2 = "INSERT INTO ORDERS_DETAIL(Order_ID, Stock_Key, Qty_Ordered, Price_per_KG, Price_per_Unit) VALUES(@oi, @sk, @qo, @ppk, @ppu)";
            SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
            sqlCom2.Parameters.AddWithValue("@oi", orderID);
            sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
            sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
            sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
            sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
            sqlCom2.ExecuteNonQuery();

            sqlCon.Close();

            funcViewORDERS();
            funcViewORDERS_DETAILS();
        }

        private void Order_Form1_Load(object sender, EventArgs e)
        {
            funcViewORDERS();
            funcViewORDERS_DETAILS();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            string viewData = "SELECT * FROM ORDERS WHERE Order_ID LIKE @id";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            sqlCom.Parameters.AddWithValue("@id", "%" + tbOrderID.Text + "%");
            sqlCom.ExecuteNonQuery();

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3));
            }

            sqlCon.Close();
        }

        private void tbOrderDetailsID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            string viewData = "SELECT * FROM ORDERS_DETAIL WHERE Order_Detail_ID LIKE @id";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            sqlCom.Parameters.AddWithValue("@id", "%" + tbOrderDetailsID.Text + "%");
            sqlCom.ExecuteNonQuery();

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView2.Items.Clear();
            while (read.Read())
            {
                lbView2.Items.Add(read.GetValue(0) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(5));
            }

            sqlCon.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbOrderDetailsID.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData1 = "DELETE FROM ORDERS WHERE Order_ID LIKE @id";

                SqlCommand sqlCom1 = new SqlCommand(deleteData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@id", tbOrderID.Text);
                sqlCom1.ExecuteNonQuery();

                string deleteData2 = "DELETE FROM ORDERS_DETAIL WHERE Order_ID LIKE @id";

                SqlCommand sqlCom2 = new SqlCommand(deleteData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@id", tbOrderID.Text);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }

            if (tbOrderID.Text.Length == 0)
            {
                sqlCon.Open();
                string deleteData1 = "SELECT Order_ID FROM ORDERS_DETAIL Where Order_Detail_ID = @id";
                SqlCommand sqlCmd1 = new SqlCommand(deleteData1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                string temp = sqlCmd1.ExecuteScalar().ToString();

                string deleteData2 = "DELETE FROM ORDERS_DETAIL WHERE Order_Detail_ID LIKE @id";
                SqlCommand sqlCmd2 = new SqlCommand(deleteData2, sqlCon);
                sqlCmd2.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                sqlCmd2.ExecuteNonQuery();

                string deleteData3 = "DELETE FROM ORDERS WHERE Order_ID LIKE @id";
                SqlCommand sqlCmd3 = new SqlCommand(deleteData3, sqlCon);
                sqlCmd3.Parameters.AddWithValue("@id", temp);
                sqlCmd3.ExecuteNonQuery();

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbOrderDetailsID.Text.Length == 0)
            {
                int userID = 0;
                int orderID = 0;

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                OrderInsertUpdateForm insert = new OrderInsertUpdateForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@username", auth.sUsername);
                sqlCmd1.Parameters.AddWithValue("@password", auth.sPassword);
                userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

                string updateDate1 = "UPDATE ORDERS SET User_ID = @ui, Date_Ordered = @d_o, Date_Received = @d_r WHERE Order_ID = '"+tbOrderID.Text+"'";
                SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@ui", userID);
                sqlCom1.Parameters.AddWithValue("@d_o", insert.sDate_Ordered);
                sqlCom1.Parameters.AddWithValue("@d_r", insert.sDate_Received);
                sqlCom1.ExecuteNonQuery();

                string query2 = "SELECT Order_ID FROM ORDERS WHERE Order_ID = '" + tbOrderID.Text + "'";
                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                orderID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                string updateDate2 = "UPDATE ORDERS_DETAIL SET Order_ID = @oi, Stock_Key = @sk, Qty_Ordered = @qo, Price_per_KG = @ppk, Price_per_Unit = @ppu WHERE Order_ID = '" + tbOrderID.Text + "'";
                SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@oi", orderID);
                sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
                sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
                sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
                sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }

            if (tbOrderID.Text.Length == 0)
            {
                int userID = 0;
                int orderID = 0;

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                OrderInsertUpdateForm insert = new OrderInsertUpdateForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string tempr = "SELECT Order_ID FROM ORDERS_DETAIL Where Order_Detail_ID = @id";
                SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                sqlTemp.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                string temp = sqlTemp.ExecuteScalar().ToString();

                string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@username", auth.sUsername);
                sqlCmd1.Parameters.AddWithValue("@password", auth.sPassword);
                userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

                string updateDate1 = "UPDATE ORDERS SET User_ID = @ui, Date_Ordered = @d_o, Date_Received = @d_r WHERE Order_ID = '"+temp+"'";
                SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@ui", userID);
                sqlCom1.Parameters.AddWithValue("@d_o", insert.sDate_Ordered);
                sqlCom1.Parameters.AddWithValue("@d_r", insert.sDate_Received);
                sqlCom1.ExecuteNonQuery();


                string updateDate2 = "UPDATE ORDERS_DETAIL SET Order_ID = @oi, Stock_Key = @sk, Qty_Ordered = @qo, Price_per_KG = @ppk, Price_per_Unit = @ppu WHERE Order_Detail_ID = '" + tbOrderDetailsID.Text + "'";
                SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@oi", temp);
                sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
                sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
                sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
                sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }
        }
    }
}
