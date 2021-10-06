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

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\24361879\Not School\Documents\GitHub\NEWClone\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adap;
        DataSet ds;

        public void loadAll()
        {
            sqlCon.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM SALE, SALE_DETAIL";

            command = new SqlCommand(sql, sqlCon);
            adap.SelectCommand = command;
            adap.Fill(ds, "SALE");

            dtgView.DataSource = ds;
            dtgView.DataMember = "SALE";

            command = new SqlCommand(sql, sqlCon);
            adap.SelectCommand = command;
            adap.Fill(ds, "SALE_DETAIL");

            dtgView.DataSource = ds;
            dtgView.DataMember = "SALE_DETAIL";

            sqlCon.Close();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                insertSaleForm insert = new insertSaleForm();
                insert.ShowDialog();

                sqlCon.Open();

                string insertData1 = "INSERT INTO SALE(Sale_Detail, Date_Received) VALUES(@s_d)";
                SqlCommand sqlCom1 = new SqlCommand(insertData1, sqlCon);
                sqlCom1.Parameters.AddWithValue("@s_d", insert.dSale_Date);
                sqlCom1.ExecuteNonQuery();

                sqlCon.Close();

                sqlCon.Open();

                string insertData2 = "INSERT INTO ORDER_DETAIL(Qty_Ordered, Price_per_KG, Price_per_Unit) VALUES(@qty, @kg, @unit)";
                SqlCommand sqlCom2 = new SqlCommand(insertData2, sqlCon);
                sqlCom2.Parameters.AddWithValue("@qty", insert.dQty_Sold);
                sqlCom2.Parameters.AddWithValue("@unit", insert.dSales_Price_per_Unit);
                sqlCom2.ExecuteNonQuery();

                sqlCon.Close();
                loadAll();
            }
            catch
            {
                MessageBox.Show("Something went wrong :c");
            }
        }

        private void Sale_Products_Form_Load(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
