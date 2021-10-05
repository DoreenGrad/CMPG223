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
    public partial class LoginForm01 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marce\Documents\GitHub\CMPG223\GUI_Prototype02\projectQueries.mdf;Integrated Security=True");
        private string username, password;

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
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.AddWithValue("@username", username.Trim()); //trim is for white spaces
            sqlCmd.Parameters.AddWithValue("@password", password.Trim());
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar().ToString()); //return 1 or 0, 1 is valid, 0 is invalid
            sqlCon.Close();

            if (count == 1)
            {
                this.Visible = false;

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
