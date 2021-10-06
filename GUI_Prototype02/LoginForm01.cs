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
    public partial class LoginForm01 : Form
    {
        static string dir = Directory.GetCurrentDirectory() + @"\projectQueries.mdf";
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dir + ";Integrated Security=True");

        private string username, password;
        public int userID;
        public LoginForm01()
        {
            InitializeComponent();
        }

        private void LoginForm01_Load(object sender, EventArgs e)
        {
            txtBUsername.Focus();
            txtBUsername.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";

            username = txtBUsername.Text;
            password = txtBPassword.Text;
            
            sqlCon.Open();
            string query = "SELECT COUNT(1) FROM USERS WHERE Username=@username AND Password=@password";
            string query1 = "SELECT User_ID FROM USERS WHERE Username=@username and Password=@password";

            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.AddWithValue("@username", username.Trim()); //trim is for white spaces
            sqlCmd.Parameters.AddWithValue("@password", password.Trim());
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid

            SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
            sqlCmd1.Parameters.AddWithValue("@username", username.Trim()); //trim is for white spaces
            sqlCmd1.Parameters.AddWithValue("@password", password.Trim());
            userID = int.Parse(sqlCmd1.ExecuteScalar().ToString());
            sqlCon.Close();

            if (count == 1)
            {
                this.Visible = false;
                MessageBox.Show(userID.ToString());
                
                MainMenuForm myMainMenu = new MainMenuForm();
                myMainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Login Error", "Incorrect Username or Password.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBUsername.Text = "Enter Username";
                txtBPassword.Text = "Enter Password";

                txtBUsername.Focus();
                txtBUsername.SelectAll();
            }
        }

        private void checkBoxPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordShow.Checked == true)
            {
                txtBPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtBUsername_Click(object sender, EventArgs e)
        {
            txtBUsername.SelectAll();
        }

        private void txtBPassword_Click(object sender, EventArgs e)
        {
            txtBPassword.SelectAll();
        }
    }
}
