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
    public partial class ReportForm : Form
    {
        static string dir = Directory.GetCurrentDirectory() + @"\projectQueries.mdf";
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dir + ";Integrated Security=True";

        public static DateTime startDate;
        public static DateTime endDate;

        string SQL = "";

        SqlCommand sqlCmd;
        SqlDataAdapter Adapt;
        DataSet ds;
        SqlDataReader reader;
        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainMenuForm myMainMenu = new MainMenuForm();
            myMainMenu.ShowDialog();
            Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startDate = dTP_Start.Value;
            endDate = dTP_End.Value;

            sqlCon.Open();
            Adapt = new SqlDataAdapter();
            ds = new DataSet();

            //if sale details selected
            if (cbxType.SelectedIndex == 0)
            {
                SQL = "SELECT S.Sale_ID, S.Sale_Date, D.Sale_Detail_ID, D.Sale_ID, D.Stock_ID, D.Sales_Price_per_Unit, D.Qty_Sold FROM SALE S, SALE_DETAIL D WHERE S.Sale_ID = D.Sale_ID AND S.Sale_Date BETWEEN '" + startDate + "' AND '" + endDate + "'";

                SqlCommand sqlCmd = new SqlCommand(SQL, sqlCon);
                Adapt.SelectCommand = sqlCmd;
                Adapt.Fill(ds, "SourceTbl");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SourceTbl";
                sqlCon.Close();
            }
            //if order details selected
            else if (cbxType.SelectedIndex == 1)
            { 
                SQL = "SELECT O.Order_ID, O.User_ID, O.Date_Ordered, O.Date_Received, OD.Order_Detail_ID, OD.Order_ID, OD.Stock_ID, OD.Qty_Ordered, OD.Price_per_KG, OD.Price_per_Unit FROM ORDERS O, ORDERS_DETAIL OD WHERE O.Order_ID = OD.Order_ID AND O.Date_Ordered BETWEEN '" + startDate + "' AND '" + endDate + "'";

                SqlCommand sqlCmd = new SqlCommand(SQL, sqlCon);
                Adapt.SelectCommand = sqlCmd;
                Adapt.Fill(ds, "SourceTbl");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SourceTbl";
                sqlCon.Close();
            }
            else
            {
                MessageBox.Show("Please select a report type.");
                sqlCon.Close();
            }           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Create a Blank worksheet and open it.\n" +
                "2. On the Data tab, click the Get Data icon, select From Database > From SQL Server Database.\n" +
                "3. Enter the name of your SQL Server in the text field and click OK.\n" +
                "4. Select the appropriate option and click Connect.\n" +
                "5. Click OK to proceed.\n" +
                "6. In the Navigator window, select the database and then the table that you would like to import in Excel and click on Load.\n" +
                "7. Next, click on Close & Load icon.");

        }
    }
}
