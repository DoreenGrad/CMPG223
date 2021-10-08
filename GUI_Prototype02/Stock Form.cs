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

// get and set methods
// try catch
// sql code
// tab / click events
// documentation

namespace GUI_Prototype02
{
    public partial class Stock_Form : Form
    {

        public Stock_Form()
        {
            InitializeComponent();
        }

        static string dir = Directory.GetCurrentDirectory() + @"\projectQueries.mdf";
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo User\Documents\2021\Sem 2\CMPG 223\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
    
        public void funcViewStock()
        {
            sqlCon.Open();
            string viewData = "SELECT * FROM STOCK";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            funcViewStock();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            StocInsertUpdateForm insert = new StocInsertUpdateForm();
            insert.ShowDialog();
            this.Visible = true;

            sqlCon.Open();

            string insertData1 = "INSERT INTO STOCK(Stock_Key, Stock_Description, Weight_per_Unit, Qty_on_Hand) VALUES(@sk, @sd, @wpu, @qoh)";
            SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
            sqlCom1.Parameters.AddWithValue("@sk", insert.sStock_key);
            sqlCom1.Parameters.AddWithValue("@sd", insert.sStock_Desc);
            sqlCom1.Parameters.AddWithValue("@wpu", insert.dWeight_per_Unit);
            sqlCom1.Parameters.AddWithValue("@qoh", insert.iQty_on_Hand);
            sqlCom1.ExecuteNonQuery();

            sqlCon.Close();
            funcViewStock();
        }

        private void tbOrderID_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            string viewData = "SELECT * FROM STOCK WHERE Stock_ID LIKE @id";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            sqlCom.Parameters.AddWithValue("@id", "%" + tbStockID.Text + "%");
            sqlCom.ExecuteNonQuery();

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        private void tbStockKey_TextChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            string viewData = "SELECT * FROM STOCK WHERE Stock_Key LIKE @id";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);
            sqlCom.Parameters.AddWithValue("@id", "%" + tbStockKey.Text + "%");
            sqlCom.ExecuteNonQuery();

            SqlDataReader read = sqlCom.ExecuteReader();

            lbView1.Items.Clear();
            while (read.Read())
            {
                lbView1.Items.Add(read.GetValue(0) + "\t\t" + read.GetValue(1) + "\t\t" + read.GetValue(2) + "\t\t\t" + read.GetValue(3) + "\t\t\t" + read.GetValue(4));
            }

            sqlCon.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbStockKey.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData1 = "DELETE FROM STOCK WHERE Stock_ID LIKE @id";

                SqlCommand sqlCom1 = new SqlCommand(deleteData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@id", tbStockID.Text);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();

                funcViewStock();
            }

            if (tbStockID.Text.Length == 0)
            {
                sqlCon.Open();

                string deleteData1 = "DELETE FROM STOCK WHERE Stock_Key LIKE @id";

                SqlCommand sqlCom1 = new SqlCommand(deleteData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@id", tbStockKey.Text);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();

                funcViewStock();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbStockKey.Text.Length == 0)
            {
                this.Visible = false;
                StocInsertUpdateForm insert = new StocInsertUpdateForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string insertData1 = "UPDATE STOCK SET Stock_Key = @sk, Stock_Description = @sd, Weight_per_Unit = @wpu, Qty_on_hand = @qoh WHERE Stock_ID = '"+tbStockID.Text+"'";
                SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@sk", insert.sStock_key);
                sqlCom1.Parameters.AddWithValue("@sd", insert.sStock_Desc);
                sqlCom1.Parameters.AddWithValue("@wpu", insert.dWeight_per_Unit);
                sqlCom1.Parameters.AddWithValue("@qoh", insert.iQty_on_Hand);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();
                funcViewStock();
            }

            if (tbStockID.Text.Length == 0)
            {
                this.Visible = false;
                StocInsertUpdateForm insert = new StocInsertUpdateForm();
                insert.ShowDialog();
                this.Visible = true;

                sqlCon.Open();

                string insertData1 = "UPDATE STOCK SET Stock_Key = @sk, Stock_Description = @sd, Weight_per_Unit = @wpu, Qty_on_hand = @qoh WHERE Stock_Key = '" + tbStockKey.Text + "'";
                SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@sk", insert.sStock_key);
                sqlCom1.Parameters.AddWithValue("@sd", insert.sStock_Desc);
                sqlCom1.Parameters.AddWithValue("@wpu", insert.dWeight_per_Unit);
                sqlCom1.Parameters.AddWithValue("@qoh", insert.iQty_on_Hand);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();
                funcViewStock();
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
