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

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo User\Documents\2021\Sem 2\CMPG 223\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
        
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
            int qty_on_hand = 0;

            this.Visible = false;
            Authentication_Form auth = new Authentication_Form();
            auth.ShowDialog();
            OrderInsertForm insert = new OrderInsertForm();
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

            string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
            SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
            sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key); //trim is for white spaces
            int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid     

            if (count == 1)
            {
                string qty = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlCmdQ = new SqlCommand(qty, sqlCon);
                qty_on_hand = Convert.ToInt32(sqlCmdQ.ExecuteScalar());

                string updateDate1 = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlComSt = new SqlCommand(updateDate1, sqlCon);
                sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand + insert.iQty_Ordered);
                sqlComSt.ExecuteNonQuery();

                string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                string insertData2 = "INSERT INTO ORDERS_DETAIL(Order_ID, Stock_ID, Qty_Ordered, Price_per_KG, Price_per_Unit) VALUES(@oi, @si, @qo, @ppk, @ppu)";
                SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@oi", orderID);
                sqlCom2.Parameters.AddWithValue("@si", stockID);
                sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
                sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
                sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
                sqlCom2.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("The stock key you have inserted is a new item in the Stock database, \nplease insert the item details for this stock item.");
                Stock_Form stockInsert = new Stock_Form();
                stockInsert.ShowDialog();

                string qty = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlCmdQ = new SqlCommand(qty, sqlCon);
                qty_on_hand = Convert.ToInt32(sqlCmdQ.ExecuteScalar());

                string updateDate1 = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlComSt = new SqlCommand(updateDate1, sqlCon);
                sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand + insert.iQty_Ordered);
                sqlComSt.ExecuteNonQuery();

                string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                string insertData2 = "INSERT INTO ORDERS_DETAIL(Order_ID, Stock_ID, Qty_Ordered, Price_per_KG, Price_per_Unit) VALUES(@oi, @si, @qo, @ppk, @ppu)";
                SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@oi", orderID);
                sqlCom2.Parameters.AddWithValue("@si", stockID);
                sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
                sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
                sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
                sqlCom2.ExecuteNonQuery();
            }
           
           

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

                string deleteData1 = "SELECT Stock_ID FROM ORDERS_DETAIL Where Order_ID = @id";
                SqlCommand sqlCmd1 = new SqlCommand(deleteData1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@id", tbOrderID.Text);
                string temp = sqlCmd1.ExecuteScalar().ToString();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_ID = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", temp); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {
                    string deleteData2 = "DELETE FROM ORDERS WHERE Order_ID LIKE @id";
                    SqlCommand sqlCom1 = new SqlCommand(deleteData2, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@id", tbOrderID.Text);
                    sqlCom1.ExecuteNonQuery();

                    string qty1 = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    int qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlCom3 = new SqlCommand(qty2, sqlCon);
                    int qty_on_hand2 = Convert.ToInt32(sqlCom3.ExecuteScalar());

                    int ans = qty_on_hand2 - qty_on_hand1;

                    string deleteData3 = "DELETE FROM ORDERS_DETAIL WHERE Order_ID LIKE @id";
                    SqlCommand sqlCom2 = new SqlCommand(deleteData3, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@id", tbOrderID.Text);
                    sqlCom2.ExecuteNonQuery();               

                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_ID = '" +temp+ "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", ans);
                    sqlComSt.ExecuteNonQuery();
                }

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }
        
            if (tbOrderID.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData0 = "SELECT Order_ID FROM ORDERS_DETAIL Where Order_Detail_ID = @id";
                SqlCommand sqlCmd0 = new SqlCommand(deleteData0, sqlCon);
                sqlCmd0.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                string temp0 = sqlCmd0.ExecuteScalar().ToString();

                string deleteData1 = "SELECT Stock_ID FROM ORDERS_DETAIL Where Order_Detail_ID = @id";
                SqlCommand sqlCmd1 = new SqlCommand(deleteData1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                string temp = sqlCmd1.ExecuteScalar().ToString();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_ID = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", temp); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {
                    /*string deleteData2 = "DELETE FROM ORDERS WHERE Order_ID LIKE @id";
                    SqlCommand sqlCom1 = new SqlCommand(deleteData2, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@id", temp0);
                    sqlCom1.ExecuteNonQuery();*/

                    string qty1 = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_Detail_ID = '" + tbOrderDetailsID.Text + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    int qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlCom3 = new SqlCommand(qty2, sqlCon);
                    int qty_on_hand2 = Convert.ToInt32(sqlCom3.ExecuteScalar());

                    int ans = qty_on_hand2 - qty_on_hand1;

                    string deleteData3 = "DELETE FROM ORDERS_DETAIL WHERE Order_Detail_ID LIKE @id";
                    SqlCommand sqlCom2 = new SqlCommand(deleteData3, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                    sqlCom2.ExecuteNonQuery();

                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", ans);
                    sqlComSt.ExecuteNonQuery();
                }

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
                int qty_on_hand1 = 0;
                int qty_on_hand2 = 0;
                int ans = 0;

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                OrderInsertForm insert = new OrderInsertForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {                  
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
                
                    string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                    SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                    qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                    if (qty_on_hand2 >= insert.iQty_Ordered)
                    {
                        ans = qty_on_hand2 - insert.iQty_Ordered;
                        qty_on_hand1 = qty_on_hand1 - ans;
                    }
                    else
                    {
                        ans = insert.iQty_Ordered - qty_on_hand2;
                        qty_on_hand1 = qty_on_hand1 + ans;
                    }
                        

                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                    sqlComSt.ExecuteNonQuery();

                    string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                    int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                    string updateDate2 = "UPDATE ORDERS_DETAIL SET Order_ID = @oi, Stock_ID = @si, Qty_Ordered = @qo, Price_per_KG = @ppk, Price_per_Unit = @ppu WHERE Order_ID = '" + tbOrderID.Text + "'";
                    SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@oi", orderID);
                    sqlCom2.Parameters.AddWithValue("@si", stockID);
                    sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
                    sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
                    sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
                    sqlCom2.ExecuteNonQuery();                   
                }
                else
                {
                    MessageBox.Show("The stock key you have inserted to be updated does not exist in the STOCk table");
                }

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }

            if (tbOrderID.Text.Length == 0)
            {
                int userID = 0;
                int orderID = 0;
                int qty_on_hand1 = 0;
                int qty_on_hand2 = 0;
                int ans = 0;

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                OrderInsertForm insert = new OrderInsertForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {

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

                    string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" +temp+ "'";
                    SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                    qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                    if (qty_on_hand2 >= insert.iQty_Ordered)
                    {
                        ans = qty_on_hand2 - insert.iQty_Ordered;
                        qty_on_hand1 = qty_on_hand1 - ans;
                    }
                    else
                    {
                        ans = insert.iQty_Ordered - qty_on_hand2;
                        qty_on_hand1 = qty_on_hand1 + ans;
                    }


                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                    sqlComSt.ExecuteNonQuery();

                    string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                    int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                    string updateDate2 = "UPDATE ORDERS_DETAIL SET Order_ID = @oi, Stock_ID = @si, Qty_Ordered = @qo, Price_per_KG = @ppk, Price_per_Unit = @ppu WHERE Order_Detail_ID = '" + tbOrderDetailsID.Text + "'";
                    SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@oi", temp);
                    sqlCom2.Parameters.AddWithValue("@si", stockID);
                    sqlCom2.Parameters.AddWithValue("@qo", insert.iQty_Ordered);
                    sqlCom2.Parameters.AddWithValue("@ppk", insert.dPrice_per_Kg);
                    sqlCom2.Parameters.AddWithValue("@ppu", insert.dPrice_per_Unit);
                    sqlCom2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The stock key you have inserted to be updated does not exist in the STOCk table");
                }

                sqlCon.Close();

                funcViewORDERS();
                funcViewORDERS_DETAILS();
            }
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainMenuForm myMainMenu = new MainMenuForm();
            myMainMenu.ShowDialog();
            Close();
        }
    }
}
