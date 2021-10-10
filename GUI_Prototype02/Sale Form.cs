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

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public static string sID;
        public static string sIDD;

        public void funcView()
        {
            sqlCon.Open();
            string viewData = "SELECT S.Sale_ID, S.Sale_Date, D.Sale_Detail_ID, D.Sale_ID, D.Stock_ID, D.Sales_Price_per_Unit, D.Qty_Sold FROM SALE S, SALE_DETAIL D WHERE S.Sale_ID = D.Sale_ID";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(4) + "\t\t" + read.GetValue(1) + "\t" + read.GetValue(5) + "\t\t\t\t" + read.GetValue(6));
            }

            sqlCon.Close();
        }

        private void Sale_Products_Form_Load(object sender, EventArgs e)
        {
            funcView();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            int userID = 0;
            int saleID = 0;

            this.Visible = false;
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

                //Store Sale_ID primary key from the SALE table
                //and store Stock_ID primary key from the STOCK table
                //in the SALE_DETAIL table as foreign keys to establish
                //a relationship between the tables
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
            funcView();
        }

        private void tbOrderID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            string viewData = "SELECT S.Sale_ID, S.Sale_Date, D.Sale_Detail_ID, D.Sale_ID, D.Stock_ID, D.Sales_Price_per_Unit, D.Qty_Sold FROM SALE S, SALE_DETAIL D WHERE S.Sale_ID = D.Sale_ID AND S.Sale_ID LIKE '%"+tbSaleID.Text+"%'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(4) + "\t\t" + read.GetValue(1) + "\t" + read.GetValue(5) + "\t\t\t\t" + read.GetValue(6));
            }

            sqlCon.Close();
        }

        private void tbSaleDetailID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            string viewData = "SELECT S.Sale_ID, S.Sale_Date, D.Sale_Detail_ID, D.Sale_ID, D.Stock_ID, D.Sales_Price_per_Unit, D.Qty_Sold FROM SALE S, SALE_DETAIL D WHERE S.Sale_ID = D.Sale_ID AND D.Sale_Detail_ID LIKE '%" + tbSaleDetailID.Text + "%'";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(4) + "\t\t" + read.GetValue(1) + "\t" + read.GetValue(5) + "\t\t\t\t" + read.GetValue(6));
            }

            sqlCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dSale_Date;
            double dSales_Price_per_Unit;
            int dQty_Sold;

            DateTime NEWdSale_Date;
            double NEWdSales_Price_per_Unit;
            int NEWdQty_Sold;
            string temp = "";

            if ((tbSaleID.Text.Length != 0) || (tbSaleDetailID.Text.Length != 0))
            { 
                if (tbSaleDetailID.Text.Length == 0)
                {
                    int userID = 0;
                    int saleID = 0;
                    int qty_on_hand1 = 0;
                    int qty_on_hand2 = 0;
                    int ans = 0;

                    sqlCon.Open();
                    string tempr = "SELECT Sale_Detail_ID FROM SALE_DETAIL Where Sale_ID = @id";
                    SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                    sqlTemp.Parameters.AddWithValue("@id", tbSaleID.Text);
                    temp = sqlTemp.ExecuteScalar().ToString();
                    sqlCon.Close();

                    sID = tbSaleID.Text;
                    sIDD = temp;

                    this.Visible = false;
                    Sale_Update insert = new Sale_Update();
                    insert.ShowDialog();
                    this.Visible = true;

                    sqlCon.Open();

                    string stock1 = "SELECT Stock_ID FROM SALE_DETAIL WHERE Sale_ID = '" + tbSaleID.Text + "'";
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
                        string ddSale_Date = "SELECT Sale_Date FROM SALE WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand ddSale_Datecmd = new SqlCommand(ddSale_Date, sqlCon);
                        dSale_Date = DateTime.Parse(ddSale_Datecmd.ExecuteScalar().ToString());

                        string ddSales_Price_per_Unit = "SELECT Sales_Price_per_Unit FROM SALE_DETAIL WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand ddSales_Price_per_Unitcmd = new SqlCommand(ddSales_Price_per_Unit, sqlCon);
                        dSales_Price_per_Unit = double.Parse(ddSales_Price_per_Unitcmd.ExecuteScalar().ToString());

                        string ddQty_Sold = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand ddQty_Soldcmd = new SqlCommand(ddQty_Sold, sqlCon);
                        dQty_Sold = int.Parse(ddQty_Soldcmd.ExecuteScalar().ToString());

                        if (Sale_Update.dSale_Date.ToString().Length != 0)
                            NEWdSale_Date = Sale_Update.dSale_Date;
                        else
                            NEWdSale_Date = dSale_Date;

                        if (insert.tbSale_Price.Text.Length != 0)
                            NEWdSales_Price_per_Unit = Sale_Update.dSales_Price_per_Unit;
                        else
                            NEWdSales_Price_per_Unit = dSales_Price_per_Unit;

                        string updateDate1 = "UPDATE SALE SET Sale_Date = @sd WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                        sqlCom1.Parameters.AddWithValue("@sd", NEWdSale_Date);
                        sqlCom1.ExecuteNonQuery();

                        string query2 = "SELECT Sale_ID FROM SALE WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                        saleID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                        string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                        qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                        string qty2 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                        qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                        if (insert.tbQty_Sold.Text.Length != 0)
                        {
                            NEWdQty_Sold = Sale_Update.dQty_Sold;
                            if (qty_on_hand2 >= NEWdQty_Sold)
                            {
                                ans = qty_on_hand2 - Sale_Update.dQty_Sold;
                                qty_on_hand1 = qty_on_hand1 + ans;
                            }
                            else
                            {
                                ans = Sale_Update.dQty_Sold - qty_on_hand2;
                                qty_on_hand1 = qty_on_hand1 - ans;
                            }
                        }
                        else
                            NEWdQty_Sold = dQty_Sold;

                        string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                        sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                        sqlComSt.ExecuteNonQuery();

                        string updateDate2 = "UPDATE SALE_DETAIL SET Sale_ID = @si, Stock_ID = @sid, Sales_Price_per_Unit = @sppu, Qty_Sold = @qs WHERE Sale_ID = '" + tbSaleID.Text + "'";
                        SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                        sqlCom2.Parameters.AddWithValue("@si", saleID);
                        sqlCom2.Parameters.AddWithValue("@sid", stockID);
                        sqlCom2.Parameters.AddWithValue("@sppu", NEWdSales_Price_per_Unit);
                        sqlCom2.Parameters.AddWithValue("@qs", NEWdQty_Sold);
                        sqlCom2.ExecuteNonQuery();
                    }

                    sqlCon.Close();
                }
                funcView();


                if (tbSaleID.Text.Length == 0)
                {
                    int userID = 0;
                    int saleID = 0;
                    int qty_on_hand1 = 0;
                    int qty_on_hand2 = 0;
                    int ans = 0;

                    sqlCon.Open();
                    string tempr = "SELECT Sale_ID FROM SALE_DETAIL WHERE Sale_Detail_ID = @id";
                    SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                    sqlTemp.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                    temp = sqlTemp.ExecuteScalar().ToString();
                    sqlCon.Close();

                    sID = temp;
                    sIDD = tbSaleDetailID.Text;

                    this.Visible = false;
                    Sale_Update insert = new Sale_Update();
                    insert.ShowDialog();
                    this.Visible = true;

                    sqlCon.Open();

                    string stock1 = "SELECT Stock_ID FROM SALE_DETAIL WHERE Sale_ID = '" + temp + "'";
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
                        string ddSale_Date = "SELECT Sale_Date FROM SALE WHERE Sale_ID = '" + temp + "'";
                        SqlCommand ddSale_Datecmd = new SqlCommand(ddSale_Date, sqlCon);
                        dSale_Date = DateTime.Parse(ddSale_Datecmd.ExecuteScalar().ToString());

                        string ddSales_Price_per_Unit = "SELECT Sales_Price_per_Unit FROM SALE_DETAIL WHERE Sale_ID = '" + temp + "'";
                        SqlCommand ddSales_Price_per_Unitcmd = new SqlCommand(ddSales_Price_per_Unit, sqlCon);
                        dSales_Price_per_Unit = double.Parse(ddSales_Price_per_Unitcmd.ExecuteScalar().ToString());

                        string ddQty_Sold = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" + temp + "'";
                        SqlCommand ddQty_Soldcmd = new SqlCommand(ddQty_Sold, sqlCon);
                        dQty_Sold = int.Parse(ddQty_Soldcmd.ExecuteScalar().ToString());

                        if (Sale_Update.dSale_Date.ToString().Length != 0)
                            NEWdSale_Date = Sale_Update.dSale_Date;
                        else
                            NEWdSale_Date = dSale_Date;

                        if (insert.tbSale_Price.Text.Length != 0)
                            NEWdSales_Price_per_Unit = Sale_Update.dSales_Price_per_Unit;
                        else
                            NEWdSales_Price_per_Unit = dSales_Price_per_Unit;

                        string updateDate1 = "UPDATE SALE SET Sale_Date = @sd WHERE Sale_ID = '" + temp + "'";
                        SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                        sqlCom1.Parameters.AddWithValue("@sd", NEWdSale_Date);
                        sqlCom1.ExecuteNonQuery();

                        string qty1 = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlCmdQ1 = new SqlCommand(qty1, sqlCon);
                        qty_on_hand1 = Convert.ToInt32(sqlCmdQ1.ExecuteScalar());

                        string qty2 = "SELECT Qty_Sold FROM SALE_DETAIL WHERE Sale_ID = '" + temp + "'";
                        SqlCommand sqlCmdQ2 = new SqlCommand(qty2, sqlCon);
                        qty_on_hand2 = Convert.ToInt32(sqlCmdQ2.ExecuteScalar());

                        if (insert.tbQty_Sold.Text.Length != 0)
                        {
                            NEWdQty_Sold = Sale_Update.dQty_Sold;
                            if (qty_on_hand2 >= NEWdQty_Sold)
                            {
                                ans = qty_on_hand2 - Sale_Update.dQty_Sold;
                                qty_on_hand1 = qty_on_hand1 + ans;
                            }
                            else
                            {
                                ans = Sale_Update.dQty_Sold - qty_on_hand2;
                                qty_on_hand1 = qty_on_hand1 - ans;
                            }
                        }
                        else
                            NEWdQty_Sold = dQty_Sold;

                        string upd = "UPDATE STOCK SET Qty_on_Hand = @qoh WHERE Stock_Key = '" + stockKey + "'";
                        SqlCommand sqlComSt = new SqlCommand(upd, sqlCon);
                        sqlComSt.Parameters.AddWithValue("@qoh", qty_on_hand1);
                        sqlComSt.ExecuteNonQuery();

                        string updateDate2 = "UPDATE SALE_DETAIL SET Sale_ID = @si, Stock_ID = @sid, Sales_Price_per_Unit = @sppu, Qty_Sold = @qs WHERE Sale_Detail_ID = '" + tbSaleDetailID.Text + "'";
                        SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                        sqlCom2.Parameters.AddWithValue("@si", temp);
                        sqlCom2.Parameters.AddWithValue("@sid", stockID);
                        sqlCom2.Parameters.AddWithValue("@sppu", NEWdSales_Price_per_Unit);
                        sqlCom2.Parameters.AddWithValue("@qs", NEWdQty_Sold);
                        sqlCom2.ExecuteNonQuery();
                    }

                    sqlCon.Close();
                }
                funcView();
            }
            else if ((tbSaleID.Text.Length == 0) && (tbSaleDetailID.Text.Length == 0))
            {
                MessageBox.Show("Please enter a Sale ID or a Sale Detail ID to update");
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
