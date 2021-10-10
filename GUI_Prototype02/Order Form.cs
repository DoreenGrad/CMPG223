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

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public static string oID;
        public static string oIDD;

        public void funcView()
        {
            sqlCon.Open();
            string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, D.Order_Detail_ID, D.Order_ID, D.Stock_ID, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL D WHERE O.Order_ID = D.Order_ID";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(6) + "\t\t" + read.GetValue(2) + "\t" + read.GetValue(3) + "\t" + read.GetValue(7) + "\t\t" + read.GetValue(8) + "\t\t\t" + read.GetValue(9));
            }

            sqlCon.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int orderID = 0;
            int qty_on_hand = 0;

            string sUsername = LoginForm01.sUsername;
            string sPassword = LoginForm01.sPassword;

            this.Visible = false;
            OrderInsertForm insert = new OrderInsertForm();
            insert.ShowDialog();
            this.Visible = true;

            sqlCon.Open();

            //Store User_ID primary key from the USERS table
            //in the ORDERS table as a foreign key to establish
            //a relationship between the two tables
            string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
            SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
            sqlCmd1.Parameters.AddWithValue("@username", sUsername); 
            sqlCmd1.Parameters.AddWithValue("@password", sPassword);
            int userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

            string insertData1 = "INSERT INTO ORDERS(User_ID, Date_Ordered, Date_Received) VALUES(@ui, @d_o, @d_r)";
            SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
            sqlCom1.Parameters.AddWithValue("@ui", userID);
            sqlCom1.Parameters.AddWithValue("@d_o", insert.sDate_Ordered);
            sqlCom1.Parameters.AddWithValue("@d_r", insert.sDate_Received);
            sqlCom1.ExecuteNonQuery();

            //Store Order_ID primary key from the ORDERS table
            //in the ORDERS_DETAIL table as a foreign key to establish
            //a relationship between the two tables
            //part 1
            string query2 = "SELECT TOP 1 Order_ID FROM ORDERS ORDER BY Order_ID DESC";
            SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
            orderID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

            string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
            SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
            sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key);
            int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); 

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

                //part 2
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

                //Store Stock_ID primary key from the STOCK table
                //in the ORDERS_DETAIL table as a foreign key to establish
                //a relationship between the two tables
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

            funcView();
        }

        private void Order_Form1_Load(object sender, EventArgs e)
        {
            funcView();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, D.Order_Detail_ID, D.Order_ID, D.Stock_ID, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL D WHERE O.Order_ID = D.Order_ID AND O.Order_ID LIKE '%" + tbOrderID.Text + "%'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(6) + "\t\t" + read.GetValue(2) + "\t" + read.GetValue(3) + "\t" + read.GetValue(7) + "\t\t" + read.GetValue(8) + "\t\t\t" + read.GetValue(9));
            }

            sqlCon.Close();
        }

        private void tbOrderDetailsID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            string viewData = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, D.Order_Detail_ID, D.Order_ID, D.Stock_ID, D.Qty_Ordered, D.Price_per_KG, D.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL D WHERE O.Order_ID = D.Order_ID AND D.Order_Detail_ID LIKE '%"+tbOrderDetailsID.Text+"%'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(4) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(6) + "\t\t" + read.GetValue(2) + "\t" + read.GetValue(3) + "\t" + read.GetValue(7) + "\t\t" + read.GetValue(8) + "\t\t\t" + read.GetValue(9));
            }

            sqlCon.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

                        string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_ID = '" + temp + "'";
                        SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                        sqlComSt.Parameters.AddWithValue("@qoh", ans);
                        sqlComSt.ExecuteNonQuery();
                    }

                    sqlCon.Close();

                    funcView();
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

                    funcView();
                }
            }
            else
            {
                funcView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime sDate_Ordered;
            DateTime sDate_Received;
            int iQty_Ordered;
            double dPrice_per_Kg;
            double dPrice_per_Unit;

            DateTime NEWsDate_Ordered;
            DateTime NEWsDate_Received;
            int NEWiQty_Ordered;
            double NEWdPrice_per_Kg;
            double NEWdPrice_per_Unit;

            string sUsername = LoginForm01.sUsername;
            string sPassword = LoginForm01.sPassword;

            if ((tbOrderID.Text.Length != 0) || (tbOrderDetailsID.Text.Length != 0))
            {
                if (tbOrderDetailsID.Text.Length == 0)
                {
                    int orderID = 0;
                    int qty_on_hand1 = 0;
                    int qty_on_hand2 = 0;
                    int ans = 0;

                    sqlCon.Open();
                    string tempr = "SELECT Order_Detail_ID FROM ORDERS_DETAIL Where Order_ID = @id";
                    SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                    sqlTemp.Parameters.AddWithValue("@id", tbOrderID.Text);
                    string temp = sqlTemp.ExecuteScalar().ToString();
                    sqlCon.Close();

                    oID = tbOrderID.Text;
                    oIDD = temp;

                    this.Visible = false;
                    Order_Update insert = new Order_Update();
                    insert.ShowDialog();
                    this.Visible = true;

                    sqlCon.Open();

                    string stock1 = "SELECT Stock_ID FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                    SqlCommand sqlCmdS1 = new SqlCommand(stock1, sqlCon);
                    int stockID = Convert.ToInt32(sqlCmdS1.ExecuteScalar());

                    string stock2 = "SELECT Stock_Key FROM STOCK WHERE Stock_ID = '" + stockID + "'";
                    SqlCommand sqlCmdS2 = new SqlCommand(stock2, sqlCon);
                    string stockKey = sqlCmdS2.ExecuteScalar().ToString();

                    string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
                    SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                    sqlCmdS.Parameters.AddWithValue("@sk", stockKey); //trim is for white spaces
                    int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                    if (count == 1)
                    {
                        string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
                        SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                        sqlCmd1.Parameters.AddWithValue("@username", sUsername);
                        sqlCmd1.Parameters.AddWithValue("@password", sPassword);
                        int userID = int.Parse(sqlCmd1.ExecuteScalar().ToString());

                        string ssDate_Ordered = "SELECT Date_Ordered FROM ORDERS WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand ssDate_Orderedcmd = new SqlCommand(ssDate_Ordered, sqlCon);
                        sDate_Ordered = DateTime.Parse(ssDate_Orderedcmd.ExecuteScalar().ToString());

                        string ssDate_Received = "SELECT Date_Received FROM ORDERS WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand ssDate_Receivedcmd = new SqlCommand(ssDate_Received, sqlCon);
                        sDate_Received = DateTime.Parse(ssDate_Receivedcmd.ExecuteScalar().ToString());

                        string iiQty_Ordered = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand iiQty_Orderedcmd = new SqlCommand(iiQty_Ordered, sqlCon);
                        iQty_Ordered = int.Parse(iiQty_Orderedcmd.ExecuteScalar().ToString());

                        string ddPrice_per_Kg = "SELECT Price_per_KG FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand ddPrice_per_Kgcmd = new SqlCommand(ddPrice_per_Kg, sqlCon);
                        dPrice_per_Kg = double.Parse(ddPrice_per_Kgcmd.ExecuteScalar().ToString());

                        string ddPrice_per_Unit = "SELECT Price_per_KG FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand ddPrice_per_Unitcmd = new SqlCommand(ddPrice_per_Unit, sqlCon);
                        dPrice_per_Unit = double.Parse(ddPrice_per_Unitcmd.ExecuteScalar().ToString());


                        if (Order_Update.sDate_Ordered.ToString().Length != 0)
                            NEWsDate_Ordered = Order_Update.sDate_Ordered;
                        else
                            NEWsDate_Ordered = sDate_Ordered;

                        if (Order_Update.sDate_Received.ToString().Length != 0)
                            NEWsDate_Received = Order_Update.sDate_Received;
                        else
                            NEWsDate_Received = sDate_Received;



                        if (insert.tbPrice_per_KG.Text.Length != 0)
                            NEWdPrice_per_Kg = Order_Update.dPrice_per_Kg;
                        else
                            NEWdPrice_per_Kg = dPrice_per_Kg;

                        if (insert.tbPrice_per_Unit.Text.Length != 0)
                            NEWdPrice_per_Unit = Order_Update.dPrice_per_Unit;
                        else
                            NEWdPrice_per_Unit = dPrice_per_Unit;

                        string updateDate1 = "UPDATE ORDERS SET User_ID = @ui, Date_Ordered = @d_o, Date_Received = @d_r WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                        sqlCom1.Parameters.AddWithValue("@ui", userID);
                        sqlCom1.Parameters.AddWithValue("@d_o", NEWsDate_Ordered);
                        sqlCom1.Parameters.AddWithValue("@d_r", NEWsDate_Received);
                        sqlCom1.ExecuteNonQuery();

                        string query2 = "SELECT Order_ID FROM ORDERS WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                        orderID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                        string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                        qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                        string qty2 = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                        qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                        if (insert.tbQty_Ordered.Text.Length != 0)
                        {
                            NEWiQty_Ordered = Order_Update.iQty_Ordered;
                            if (qty_on_hand2 >= NEWiQty_Ordered)
                            {
                                ans = qty_on_hand2 - Order_Update.iQty_Ordered;
                                qty_on_hand1 = qty_on_hand1 - ans;
                            }
                            else
                            {
                                ans = Order_Update.iQty_Ordered - qty_on_hand2;
                                qty_on_hand1 = qty_on_hand1 + ans;
                            }
                        }
                        else
                            NEWiQty_Ordered = iQty_Ordered;


                        string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                        sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                        sqlComSt.ExecuteNonQuery();

                        string updateDate2 = "UPDATE ORDERS_DETAIL SET Order_ID = @oi, Stock_ID = @si, Qty_Ordered = @qo, Price_per_KG = @ppk, Price_per_Unit = @ppu WHERE Order_ID = '" + tbOrderID.Text + "'";
                        SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                        sqlCom2.Parameters.AddWithValue("@oi", orderID);
                        sqlCom2.Parameters.AddWithValue("@si", stockID);
                        sqlCom2.Parameters.AddWithValue("@qo", NEWiQty_Ordered);
                        sqlCom2.Parameters.AddWithValue("@ppk", NEWdPrice_per_Kg);
                        sqlCom2.Parameters.AddWithValue("@ppu", NEWdPrice_per_Unit);
                        sqlCom2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("The stock key you have inserted to be updated does not exist in the STOCk table");
                    }

                    sqlCon.Close();

                    funcView();
                }

                if (tbOrderID.Text.Length == 0)
                {
                    int orderID = 0;
                    int qty_on_hand1 = 0;
                    int qty_on_hand2 = 0;
                    int ans = 0;

                    sqlCon.Open();
                    string tempr = "SELECT Order_ID FROM ORDERS_DETAIL Where Order_Detail_ID = @id";
                    SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                    sqlTemp.Parameters.AddWithValue("@id", tbOrderDetailsID.Text);
                    string temp = sqlTemp.ExecuteScalar().ToString();
                    sqlCon.Close();

                    oID = temp;
                    oIDD = tbOrderDetailsID.Text;

                    this.Visible = false;
                    Order_Update insert = new Order_Update();
                    insert.ShowDialog();
                    this.Visible = true;

                    sqlCon.Open();

                    string stock1 = "SELECT Stock_ID FROM ORDERS_DETAIL WHERE Order_ID = '" + temp + "'";
                    SqlCommand sqlCmdS1 = new SqlCommand(stock1, sqlCon);
                    int stockID = Convert.ToInt32(sqlCmdS1.ExecuteScalar());

                    string stock2 = "SELECT Stock_Key FROM STOCK WHERE Stock_ID = '" + stockID + "'";
                    SqlCommand sqlCmdS2 = new SqlCommand(stock2, sqlCon);
                    string stockKey = sqlCmdS2.ExecuteScalar().ToString();

                    string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
                    SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                    sqlCmdS.Parameters.AddWithValue("@sk", stockKey); //trim is for white spaces
                    int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                    if (count == 1)
                    {
                        string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
                        SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                        sqlCmd1.Parameters.AddWithValue("@username", sUsername);
                        sqlCmd1.Parameters.AddWithValue("@password", sPassword);
                        int userID = int.Parse(sqlCmd1.ExecuteScalar().ToString());

                        string ssDate_Ordered = "SELECT Date_Ordered FROM ORDERS WHERE Order_ID = '" + temp + "'";
                        SqlCommand ssDate_Orderedcmd = new SqlCommand(ssDate_Ordered, sqlCon);
                        sDate_Ordered = DateTime.Parse(ssDate_Orderedcmd.ExecuteScalar().ToString());

                        string ssDate_Received = "SELECT Date_Received FROM ORDERS WHERE Order_ID = '" + temp + "'";
                        SqlCommand ssDate_Receivedcmd = new SqlCommand(ssDate_Received, sqlCon);
                        sDate_Received = DateTime.Parse(ssDate_Receivedcmd.ExecuteScalar().ToString());

                        string iiQty_Ordered = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" + temp + "'";
                        SqlCommand iiQty_Orderedcmd = new SqlCommand(iiQty_Ordered, sqlCon);
                        iQty_Ordered = int.Parse(iiQty_Orderedcmd.ExecuteScalar().ToString());

                        string ddPrice_per_Kg = "SELECT Price_per_KG FROM ORDERS_DETAIL WHERE Order_ID = '" + temp + "'";
                        SqlCommand ddPrice_per_Kgcmd = new SqlCommand(ddPrice_per_Kg, sqlCon);
                        dPrice_per_Kg = double.Parse(ddPrice_per_Kgcmd.ExecuteScalar().ToString());

                        string ddPrice_per_Unit = "SELECT Price_per_KG FROM ORDERS_DETAIL WHERE Order_ID = '" + temp + "'";
                        SqlCommand ddPrice_per_Unitcmd = new SqlCommand(ddPrice_per_Unit, sqlCon);
                        dPrice_per_Unit = double.Parse(ddPrice_per_Unitcmd.ExecuteScalar().ToString());


                        if (Order_Update.sDate_Ordered.ToString().Length != 0)
                            NEWsDate_Ordered = Order_Update.sDate_Ordered;
                        else
                            NEWsDate_Ordered = sDate_Ordered;

                        if (Order_Update.sDate_Received.ToString().Length != 0)
                            NEWsDate_Received = Order_Update.sDate_Received;
                        else
                            NEWsDate_Received = sDate_Received;



                        if (insert.tbPrice_per_KG.Text.Length != 0)
                            NEWdPrice_per_Kg = Order_Update.dPrice_per_Kg;
                        else
                            NEWdPrice_per_Kg = dPrice_per_Kg;

                        if (insert.tbPrice_per_Unit.Text.Length != 0)
                            NEWdPrice_per_Unit = Order_Update.dPrice_per_Unit;
                        else
                            NEWdPrice_per_Unit = dPrice_per_Unit;

                        string updateDate1 = "UPDATE ORDERS SET User_ID = @ui, Date_Ordered = @d_o, Date_Received = @d_r WHERE Order_ID = '" + temp + "'";
                        SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                        sqlCom1.Parameters.AddWithValue("@ui", userID);
                        sqlCom1.Parameters.AddWithValue("@d_o", NEWsDate_Ordered);
                        sqlCom1.Parameters.AddWithValue("@d_r", NEWsDate_Received);
                        sqlCom1.ExecuteNonQuery();

                        string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                        qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                        string qty2 = "SELECT Qty_Ordered FROM ORDERS_DETAIL WHERE Order_ID = '" + temp + "'";
                        SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                        qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                        if (insert.tbQty_Ordered.Text.Length != 0)
                        {
                            NEWiQty_Ordered = Order_Update.iQty_Ordered;
                            if (qty_on_hand2 >= NEWiQty_Ordered)
                            {
                                ans = qty_on_hand2 - Order_Update.iQty_Ordered;
                                qty_on_hand1 = qty_on_hand1 - ans;
                            }
                            else
                            {
                                ans = Order_Update.iQty_Ordered - qty_on_hand2;
                                qty_on_hand1 = qty_on_hand1 + ans;
                            }
                        }
                        else
                            NEWiQty_Ordered = iQty_Ordered;


                        string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                        sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                        sqlComSt.ExecuteNonQuery();

                        string updateDate2 = "UPDATE ORDERS_DETAIL SET Order_ID = @oi, Stock_ID = @si, Qty_Ordered = @qo, Price_per_KG = @ppk, Price_per_Unit = @ppu WHERE Order_Detail_ID = '" + tbOrderDetailsID.Text + "'";
                        SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                        sqlCom2.Parameters.AddWithValue("@oi", temp);
                        sqlCom2.Parameters.AddWithValue("@si", stockID);
                        sqlCom2.Parameters.AddWithValue("@qo", NEWiQty_Ordered);
                        sqlCom2.Parameters.AddWithValue("@ppk", NEWdPrice_per_Kg);
                        sqlCom2.Parameters.AddWithValue("@ppu", NEWdPrice_per_Unit);
                        sqlCom2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("The stock key you have inserted to be updated does not exist in the STOCk table");
                    }

                    sqlCon.Close();

                    funcView();
                }
            }
            else if ((tbOrderID.Text.Length == 0) && (tbOrderDetailsID.Text.Length == 0))
            {
                MessageBox.Show("Please enter a Order ID or a Order Detail ID to update");
            }           
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainMenuForm myMainMenu = new MainMenuForm();
            myMainMenu.ShowDialog();
            this.Close();
        }
    }
}
