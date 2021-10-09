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

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public static string sID;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sStock_key;
            string sStock_Desc;
            double dWeight_per_Unit;
            int iQty_on_Hand;

            string NEWsStock_key;
            string NEWsStock_Desc;
            double NEWdWeight_per_Unit;
            int NEWiQty_on_Hand;

            if((tbStockID.Text.Length !=0) || (tbStockKey.Text.Length !=0))
            {
                if (tbStockKey.Text.Length == 0)
                {
                    sID = tbStockID.Text;

                    this.Visible = false;
                    Stock_Update insert = new Stock_Update();
                    insert.ShowDialog();
                    this.Visible = true;

                    sqlCon.Open();

                    string ssStock_key = "SELECT Stock_Key FROM STOCK WHERE Stock_ID = '" + tbStockID.Text + "'";
                    SqlCommand ssStock_keycmd = new SqlCommand(ssStock_key, sqlCon);
                    sStock_key = ssStock_keycmd.ExecuteScalar().ToString();

                    string ssStock_Desc = "SELECT Stock_Description FROM STOCK WHERE Stock_ID = '" + tbStockID.Text + "'";
                    SqlCommand ssStock_Desccmd = new SqlCommand(ssStock_Desc, sqlCon);
                    sStock_Desc = ssStock_Desccmd.ExecuteScalar().ToString();

                    string ddWeight_per_Unit = "SELECT Weight_per_Unit FROM STOCK WHERE Stock_ID = '" + tbStockID.Text + "'";
                    SqlCommand ddWeight_per_Unitcmd = new SqlCommand(ddWeight_per_Unit, sqlCon);
                    dWeight_per_Unit = double.Parse(ddWeight_per_Unitcmd.ExecuteScalar().ToString());

                    string iiQty_on_Hand = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + tbStockID.Text + "'";
                    SqlCommand iiQty_on_Handcmd = new SqlCommand(iiQty_on_Hand, sqlCon);
                    iQty_on_Hand = int.Parse(iiQty_on_Handcmd.ExecuteScalar().ToString());

                    if (insert.tbStock_Key.Text.Length != 0)
                        NEWsStock_key = Stock_Update.sStock_key;
                    else
                        NEWsStock_key = sStock_key;

                    if (insert.tbStock_Desc.Text.Length != 0)
                        NEWsStock_Desc = Stock_Update.sStock_Desc;
                    else
                        NEWsStock_Desc = sStock_Desc;

                    if (insert.tbWeight_per_Unit.Text.Length != 0)
                        NEWdWeight_per_Unit = Stock_Update.dWeight_per_Unit;
                    else
                        NEWdWeight_per_Unit = dWeight_per_Unit;

                    if (insert.tbQty_on_Hand.Text.Length != 0)
                        NEWiQty_on_Hand = Stock_Update.iQty_on_Hand;
                    else
                        NEWiQty_on_Hand = iQty_on_Hand;

                    string insertData1 = "UPDATE STOCK SET Stock_Key = @sk, Stock_Description = @sd, Weight_per_Unit = @wpu, Qty_on_hand = @qoh WHERE Stock_ID = '" + tbStockID.Text + "'";
                    SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@sk", NEWsStock_key);
                    sqlCom1.Parameters.AddWithValue("@sd", NEWsStock_Desc);
                    sqlCom1.Parameters.AddWithValue("@wpu", NEWdWeight_per_Unit);
                    sqlCom1.Parameters.AddWithValue("@qoh", NEWiQty_on_Hand);
                    sqlCom1.ExecuteNonQuery();

                    sqlCon.Close();
                    funcViewStock();
                }

                if (tbStockID.Text.Length == 0)
                {
                    sqlCon.Open();

                    string id = "SELECT Stock_ID FROM STOCK WHERE Stock_Key = '" + tbStockKey.Text + "'";
                    SqlCommand idcmd = new SqlCommand(id, sqlCon);
                    string temp = idcmd.ExecuteScalar().ToString();

                    sID = temp;

                    this.Visible = false;
                    Stock_Update insert = new Stock_Update();
                    insert.ShowDialog();
                    this.Visible = true;

                    string ssStock_key = "SELECT Stock_Key FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand ssStock_keycmd = new SqlCommand(ssStock_key, sqlCon);
                    sStock_key = ssStock_keycmd.ExecuteScalar().ToString();

                    string ssStock_Desc = "SELECT Stock_Description FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand ssStock_Desccmd = new SqlCommand(ssStock_Desc, sqlCon);
                    sStock_Desc = ssStock_Desccmd.ExecuteScalar().ToString();

                    string ddWeight_per_Unit = "SELECT Weight_per_Unit FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand ddWeight_per_Unitcmd = new SqlCommand(ddWeight_per_Unit, sqlCon);
                    dWeight_per_Unit = double.Parse(ddWeight_per_Unitcmd.ExecuteScalar().ToString());

                    string iiQty_on_Hand = "SELECT Qty_on_Hand FROM STOCK WHERE Stock_ID = '" + temp + "'";
                    SqlCommand iiQty_on_Handcmd = new SqlCommand(iiQty_on_Hand, sqlCon);
                    iQty_on_Hand = int.Parse(iiQty_on_Handcmd.ExecuteScalar().ToString());

                    if (insert.tbStock_Key.Text.Length != 0)
                        NEWsStock_key = Stock_Update.sStock_key;
                    else
                        NEWsStock_key = sStock_key;

                    if (insert.tbStock_Desc.Text.Length != 0)
                        NEWsStock_Desc = Stock_Update.sStock_Desc;
                    else
                        NEWsStock_Desc = sStock_Desc;

                    if (insert.tbWeight_per_Unit.Text.Length != 0)
                        NEWdWeight_per_Unit = Stock_Update.dWeight_per_Unit;
                    else
                        NEWdWeight_per_Unit = dWeight_per_Unit;

                    if (insert.tbQty_on_Hand.Text.Length != 0)
                        NEWiQty_on_Hand = Stock_Update.iQty_on_Hand;
                    else
                        NEWiQty_on_Hand = iQty_on_Hand;

                    string insertData1 = "UPDATE STOCK SET Stock_Key = @sk, Stock_Description = @sd, Weight_per_Unit = @wpu, Qty_on_hand = @qoh WHERE Stock_ID = '" + temp + "'";
                    SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                    sqlCom1.Parameters.AddWithValue("@sk", NEWsStock_key);
                    sqlCom1.Parameters.AddWithValue("@sd", NEWsStock_Desc);
                    sqlCom1.Parameters.AddWithValue("@wpu", NEWdWeight_per_Unit);
                    sqlCom1.Parameters.AddWithValue("@qoh", NEWiQty_on_Hand);
                    sqlCom1.ExecuteNonQuery();

                    sqlCon.Close();
                    funcViewStock();
                }
            }
            else if((tbStockID.Text.Length == 0) && (tbStockKey.Text.Length == 0))
            {
                MessageBox.Show("Please enter a Stock ID or a Stock Key to update");
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
