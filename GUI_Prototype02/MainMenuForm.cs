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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(LoginForm01.ConnectionString);

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            string user = "SELECT Description FROM USERS WHERE Username = '"+LoginForm01.sUsername+ "' AND Password ='" + LoginForm01.sPassword + "'";
            SqlCommand usercmd = new SqlCommand(user, sqlCon);
            string desc = usercmd.ExecuteScalar().ToString();
            sqlCon.Close();

            if(desc == "Clerk")
            {
                stockToolStripMenuItem.Enabled = false;
            }

        }

        private void productsTool_Click(object sender, EventArgs e)
        {
           
        }

        private void reportTool_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            ReportForm myReport = new ReportForm();
            myReport.ShowDialog();

            this.Close();
        }

        private void helpTool_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            HelpForm myHelp = new HelpForm();
            myHelp.ShowDialog();

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//Testing
        }     

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            salesForm mySales = new salesForm();
            mySales.ShowDialog();
            this.Close();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Order_Form myMainMenu = new Order_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Stock_Form myMainMenu = new Stock_Form();
            myMainMenu.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            LoginForm01 log = new LoginForm01();
            log.ShowDialog();

            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            LoginForm01 log = new LoginForm01();
            log.ShowDialog();

            this.Close();
        }
    }
}
