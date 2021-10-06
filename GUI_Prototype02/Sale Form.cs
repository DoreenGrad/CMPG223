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

        SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security = True");

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

            string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
            SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
            sqlCmd1.Parameters.AddWithValue("@username", auth.sUsername);
            sqlCmd1.Parameters.AddWithValue("@password", auth.sPassword);
            userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

            string insertData1 = "INSERT INTO SALE(Sale_Date) VALUES(@sd)";
            SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
            sqlCom1.Parameters.AddWithValue("@sd", insert.dSale_Date);
            sqlCom1.ExecuteNonQuery();

            string query2 = "SELECT TOP 1 Sale_ID FROM SALE ORDER BY Sale_ID DESC";
            SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
            saleID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

            string insertData2 = "INSERT INTO SALE_DETAIL(Sale_ID, Stock_Key, Sales_Price_per_Unit, Qty_Sold) VALUES(@si, @sk, @sppu, @qs)";
            SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
            sqlCom2.Parameters.AddWithValue("@si", saleID);
            sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
            sqlCom2.Parameters.AddWithValue("@sppu", insert.dSales_Price_per_Unit);
            sqlCom2.Parameters.AddWithValue("@qs", insert.dQty_Sold);
            sqlCom2.ExecuteNonQuery();

            sqlCon.Close();

            funcViewSALE();
            funcViewSALE_DETAIL();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbSaleDetailID.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData1 = "DELETE FROM SALE WHERE Sale_ID LIKE @id";

                SqlCommand sqlCom1 = new SqlCommand(deleteData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@id", tbSaleID.Text);
                sqlCom1.ExecuteNonQuery();

                string deleteData2 = "DELETE FROM SALE_DETAIL WHERE Sale_ID LIKE @id";

                SqlCommand sqlCom2 = new SqlCommand(deleteData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@id", tbSaleID.Text);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
            }

            if (tbSaleID.Text.Length == 0)
            {
                sqlCon.Open();
                string deleteData1 = "SELECT Sale_ID FROM SALE_DETAIL Where Sale_Detail_ID = @id";
                SqlCommand sqlCmd1 = new SqlCommand(deleteData1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                string temp = sqlCmd1.ExecuteScalar().ToString();

                string deleteData2 = "DELETE FROM SALE_DETAIL WHERE Sale_Detail_ID LIKE @id";
                SqlCommand sqlCmd2 = new SqlCommand(deleteData2, sqlCon);
                sqlCmd2.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                sqlCmd2.ExecuteNonQuery();

                string deleteData3 = "DELETE FROM SALE WHERE Sale_ID LIKE @id";
                SqlCommand sqlCmd3 = new SqlCommand(deleteData3, sqlCon);
                sqlCmd3.Parameters.AddWithValue("@id", temp);
                sqlCmd3.ExecuteNonQuery();

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

                this.Visible = false;
                Authentication_Form auth = new Authentication_Form();
                auth.ShowDialog();
                insertSaleForm insert = new insertSaleForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@username", auth.sUsername);
                sqlCmd1.Parameters.AddWithValue("@password", auth.sPassword);
                userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

                string updateDate1 = "UPDATE SALE SET Sale_Date = @sd WHERE Sale_ID = '"+tbSaleID.Text+"'";
                SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@sd", insert.dSale_Date);
                sqlCom1.ExecuteNonQuery();

                string query2 = "SELECT TOP 1 Sale_ID FROM SALE ORDER BY Sale_ID DESC";
                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                saleID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                string updateDate2 = "UPDATE SALE_DETAIL SET Sale_ID = @si, Stock_Key = @sk, Sales_Price_per_Unit = @sppu, Qty_Sold = @qs WHERE Sale_ID = '" + tbSaleID.Text + "'";
                SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@si", saleID);
                sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
                sqlCom2.Parameters.AddWithValue("@sppu", insert.dSales_Price_per_Unit);
                sqlCom2.Parameters.AddWithValue("@qs", insert.dQty_Sold);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
            }

            if (tbSaleID.Text.Length == 0)
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

                string tempr = "SELECT Sale_ID FROM SALE_DETAIL Where Sale_Detail_ID = @id";
                SqlCommand sqlTemp = new SqlCommand(tempr, sqlCon);
                sqlTemp.Parameters.AddWithValue("@id", tbSaleDetailID.Text);
                string temp = sqlTemp.ExecuteScalar().ToString();

                string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                sqlCmd1.Parameters.AddWithValue("@username", auth.sUsername);
                sqlCmd1.Parameters.AddWithValue("@password", auth.sPassword);
                userID = Convert.ToInt32(sqlCmd1.ExecuteScalar());

                string updateDate1 = "UPDATE SALE SET Sale_Date = @sd WHERE Sale_ID = '" + temp + "'";
                SqlCommand sqlCom1 = new SqlCommand(updateDate1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@sd", insert.dSale_Date);
                sqlCom1.ExecuteNonQuery();

                string query2 = "SELECT TOP 1 Sale_ID FROM SALE ORDER BY Sale_ID DESC";
                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                saleID = Convert.ToInt32(sqlCmd2.ExecuteScalar());

                string updateDate2 = "UPDATE SALE_DETAIL SET Sale_ID = @si, Stock_Key = @sk, Sales_Price_per_Unit = @sppu, Qty_Sold = @qs WHERE Sale_ID = '" + tbSaleDetailID.Text + "'";
                SqlCommand sqlCom2 = new SqlCommand(updateDate2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@si", saleID);
                sqlCom2.Parameters.AddWithValue("@sk", insert.sStock_Key);
                sqlCom2.Parameters.AddWithValue("@sppu", insert.dSales_Price_per_Unit);
                sqlCom2.Parameters.AddWithValue("@qs", insert.dQty_Sold);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();

                funcViewSALE();
                funcViewSALE_DETAIL();
            }
        }
    }
}
