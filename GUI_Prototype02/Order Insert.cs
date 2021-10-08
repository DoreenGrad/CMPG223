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
    public partial class OrderInsertForm : Form
    {
        public OrderInsertForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        public void loadStockKeys()
        {
            sqlCon.Open();
            string viewData = "SELECT Stock_Key FROM STOCK";
            SqlCommand sqlCom = new SqlCommand(viewData, sqlCon);

            SqlDataReader read = sqlCom.ExecuteReader();

            comboBox1.Items.Clear();

            while (read.Read())
            {
                comboBox1.Items.Add(read.GetValue(0));
            }

            sqlCon.Close();

        }

        //public variables to access on the main form
        public DateTime sDate_Ordered;
        public DateTime sDate_Received;
        public int iQty_Ordered;
        public double dPrice_per_Kg;
        public double dPrice_per_Unit;
        public string sStock_Key;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbQty_Ordered.Text, out iQty_Ordered))
            {
                if(double.TryParse(tbPrice_per_Kg.Text, out dPrice_per_Kg))
                {
                    if (double.TryParse(tbPrice_per_Unit.Text, out dPrice_per_Unit))
                    {
                        sDate_Ordered = dTP_Ordered.Value.Date;
                        sDate_Received = dTP_Received.Value.Date;
                        sStock_Key = comboBox1.Text;
                        this.Close();  
                    }
                    else
                    {
                        MessageBox.Show("Price per kg must be numeric");
                    }
                }
                else
                {
                    MessageBox.Show("Price per kg must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Quantity ordered must be numeric");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Order_Form myMainMenu = new Order_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void OrderInsertForm_Load(object sender, EventArgs e)
        {
            loadStockKeys();
        }
    }
}
