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
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");

        public void funcViewSALE()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM SALE";
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
            string viewData = "SELECT * FROM SALE_DETAIL";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView2.Items.Clear();
            while (read.Read())
            {
                lbView2.Items.Add(read.GetValue(0) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        private void Sale_Products_Form_Load(object sender, EventArgs e)
        {
            funcViewSALE();
            funcViewSALE_DETAIL();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            int userID = 0;
            int saleID = 0;

            this.Visible = false;
            Authentication_Form auth = new Authentication_Form();
            auth.ShowDialog();
            insertSaleForm insert = new insertSaleForm();
            insert.ShowDialog();
            this.Visible = true;

            sqlCon.Open();            
          
            string querySALE = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
            SqlCommand sqlCmdS = new SqlCommand(querySALE, sqlCon);
            sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key); //trim is for white spaces
            int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid     

            if (count == 1)
            {
                string insertData1 = "INSERT INTO SALE(Sale_Date) VALUES(@sd)";
                SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@sd", insert.dSale_Date);
                sqlCom1.ExecuteNonQuery();

                string query2 = "SELECT TOP 1 Sale_ID FROM SALE ORDER BY Sale_ID DESC";
                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                saleID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                string insertData2 = "INSERT INTO SALE_DETAIL(Sale_ID, Stock_ID, Sales_Price_per_Unit, Qty_Sold) VALUES(@si, @sti, @sppu, @qs)";
                SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@si", saleID);
                sqlCom2.Parameters.AddWithValue("@sti", stockID);
                sqlCom2.Parameters.AddWithValue("@sppu", insert.dSales_Price_per_Unit);
                sqlCom2.Parameters.AddWithValue("@qs", insert.dQty_Sold);
                sqlCom2.ExecuteNonQuery();


                string qty1 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Stock_ID = '" + stockID + "'";
                SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                int qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                string qty2 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + stockID + "'";
                SqlCommand sqlCom3 = new SqlCommand(qty2, sqlCon);
                int qty_on_hand2 = Convert.ToInt32(sqlCom3.ExecuteScalar());

                int ans = qty_on_hand2 - qty_on_hand1;

                string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_ID = '" + stockID + "'";
                SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                sqlComSt.Parameters.AddWithValue("@qoh", ans);
                sqlComSt.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("The stock key you have inserted does not exist in the Stock database, \nplease insert a stock key that exists.");
                Stock_Form stockInsert = new Stock_Form();
                stockInsert.ShowDialog();             
            }

            sqlCon.Close();
            funcViewSALE();
            funcViewSALE_DETAIL();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbSaleDetailID.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData1 = "SELECT Stock_ID FROM SALE_DETAIL Where Sale_ID = @id";
                SqlCommand sqlCmd1 = new SqlCommand(deleteData1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@id", tbSaleID.Text);
                string temp = sqlCmd1.ExecuteScalar().ToString();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_ID = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", temp); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {
                    string deleteData2 = "DELETE FROM SALE WHERE Sale_ID LIKE @id";
                    SqlCommand sqlCom1 = new SqlCommand(deleteData2, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@id", tbSaleID.Text);
                    sqlCom1.ExecuteNonQuery();

                    string qty1 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" + tbSaleID.Text + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    int qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlCom3 = new SqlCommand(qty2, sqlCon);
                    int qty_on_hand2 = Convert.ToInt32(sqlCom3.ExecuteScalar());

                    int ans = qty_on_hand2 + qty_on_hand1;

                    string deleteData3 = "DELETE FROM SALE_DETAIL WHERE Sale_ID LIKE @id";
                    SqlCommand sqlCom2 = new SqlCommand(deleteData3, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@id", tbSaleID.Text);
                    sqlCom2.ExecuteNonQuery();

                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", ans);
                    sqlComSt.ExecuteNonQuery();
                }

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
            }

            if (tbSaleID.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData0 = "SELECT Sale_ID FROM SALE_DETAIL Where Sale_Detail_ID = @id";
                SqlCommand sqlCmd0 = new SqlCommand(deleteData0, sqlCon);
                sqlCmd0.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                string temp0 = sqlCmd0.ExecuteScalar().ToString();

                string deleteData1 = "SELECT Stock_ID FROM SALE_DETAIL Where Sale_Detail_ID = @id";
                SqlCommand sqlCmd1 = new SqlCommand(deleteData1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                string temp = sqlCmd1.ExecuteScalar().ToString();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_ID = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", temp); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {
                    string deleteData2 = "DELETE FROM SALE WHERE Sale_ID LIKE @id";
                    SqlCommand sqlCom1 = new SqlCommand(deleteData2, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@id", temp0);
                    sqlCom1.ExecuteNonQuery();

                    string qty1 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_Detail_ID = '" + tbSaleDetailID.Text + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    int qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlCom3 = new SqlCommand(qty2, sqlCon);
                    int qty_on_hand2 = Convert.ToInt32(sqlCom3.ExecuteScalar());

                    int ans = qty_on_hand2 + qty_on_hand1;

                    string deleteData3 = "DELETE FROM SALE_DETAIL WHERE Sale_Detail_ID LIKE @id";
                    SqlCommand sqlCom2 = new SqlCommand(deleteData3, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                    sqlCom2.ExecuteNonQuery();

                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", ans);
                    sqlComSt.ExecuteNonQuery();
                }

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
            }
        }

        private void tbOrderID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            string viewData = "SELECT * FROM SALE WHERE Sale_ID LIKE @id";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            sqlCom.Parameters.AddWithValue("@id", "%" + tbSaleID.Text + "%");
            sqlCom.ExecuteNonQuery();

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1));
            }

            sqlCon.Close();
        }

        private void tbSaleDetailID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            string viewData = "SELECT * FROM SALE_DETAIL WHERE Sale_Detail_ID LIKE @id";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            sqlCom.Parameters.AddWithValue("@id", "%" + tbSaleDetailID.Text + "%");
            sqlCom.ExecuteNonQuery();

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView2.Items.Clear();
            while (read.Read())
            {
                lbView2.Items.Add(read.GetValue(0) + "\t\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbSaleDetailID.Text.Length == 0)
            {
                int userID = 0;
                int saleID = 0;
                int qty_on_hand1 = 0;
                int qty_on_hand2 = 0;
                int ans = 0;

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                insertSaleForm insert = new insertSaleForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {
                    string updateDate1 = "UPDATE SALE SET Sale_Date = @sd WHERE Sale_ID = '" + tbSaleID.Text + "'";
                    SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@sd", insert.dSale_Date);
                    sqlCom1.ExecuteNonQuery();

                    string query2 = "SELECT Sale_ID FROM SALE WHERE Sale_ID = '" + tbSaleID.Text + "'";
                    SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                    saleID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                    string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" + tbSaleID.Text + "'";
                    SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                    qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                    if (qty_on_hand2 >= insert.dQty_Sold)
                    {
                        ans = qty_on_hand2 - insert.dQty_Sold;
                        qty_on_hand1 = qty_on_hand1 + ans;
                    }
                    else
                    {
                        ans = insert.dQty_Sold - qty_on_hand2;
                        qty_on_hand1 = qty_on_hand1 - ans;
                    }


                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                    sqlComSt.ExecuteNonQuery();

                    string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                    int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                    string updateDate2 = "UPDATE SALE_DETAIL SET Sale_ID = @si, Stock_ID = @sid, Sales_Price_per_Unit = @sppu, Qty_Sold = @qs WHERE Sale_ID = '" + tbSaleID.Text + "'";
                    SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@si", saleID);
                    sqlCom2.Parameters.AddWithValue("@sid", stockID);
                    sqlCom2.Parameters.AddWithValue("@sppu", insert.dSales_Price_per_Unit);
                    sqlCom2.Parameters.AddWithValue("@qs", insert.dQty_Sold);
                    sqlCom2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The stock key you have inserted to be updated does not exist in the STOCk table");
                }

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
            }

            if (tbSaleID.Text.Length == 0)
            {
                int userID = 0;
                int saleID = 0;
                int qty_on_hand1 = 0;
                int qty_on_hand2 = 0;
                int ans = 0;

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                insertSaleForm insert = new insertSaleForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string querySTPOCK = "SELECT COUNT(1) FROM STOCK WHERE Stock_Key = @sk";
                SqlCommand sqlCmdS = new SqlCommand(querySTPOCK, sqlCon);
                sqlCmdS.Parameters.AddWithValue("@sk", insert.sStock_Key); //trim is for white spaces
                int count = Convert.ToInt32(sqlCmdS.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid    

                if (count == 1)
                {

                    string tempr = "SELECT Sale_ID FROM SALE_DETAIL Where Sale_Detail_ID = @id";
                    SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                    sqlTemp.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                    string temp = sqlTemp.ExecuteScalar().ToString();

                    string updateDate1 = "UPDATE SALE SET Sale_Date = @sd WHERE Sale_ID = '" + temp + "'";
                    SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@sd", insert.dSale_Date);
                    sqlCom1.ExecuteNonQuery();

                    string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                    qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                    string qty2 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" +temp+ "'";
                    SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                    qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                    if (qty_on_hand2 >= insert.dQty_Sold)
                    {
                        ans = qty_on_hand2 - insert.dQty_Sold;
                        qty_on_hand1 = qty_on_hand1 + ans;
                    }
                    else
                    {
                        ans = insert.dQty_Sold - qty_on_hand2;
                        qty_on_hand1 = qty_on_hand1 - ans;
                    }

                    string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                    sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                    sqlComSt.ExecuteNonQuery();

                    string stock = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + insert.sStock_Key + "'";
                    SqlCommand sqlCmdSI = new SqlCommand(stock, sqlCon);
                    int stockID = Convert.ToInt32(sqlCmdSI.ExecuteScalar());

                    string updateDate2 = "UPDATE SALE_DETAIL SET Sale_ID = @si, Stock_ID = @sid, Sales_Price_per_Unit = @sppu, Qty_Sold = @qs WHERE Sale_Detail_ID = '" + tbSaleDetailID.Text + "'";
                    SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                    sqlCom2.Parameters.AddWithValue("@si", temp);
                    sqlCom2.Parameters.AddWithValue("@sid", stockID);
                    sqlCom2.Parameters.AddWithValue("@sppu", insert.dSales_Price_per_Unit);
                    sqlCom2.Parameters.AddWithValue("@qs", insert.dQty_Sold);
                    sqlCom2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("The stock key you have inserted to be updated does not exist in the STOCk table");
                }

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
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
