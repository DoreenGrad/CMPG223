using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Prototype02
{
    public partial class LoginForm02 : Form
    {
        private const string USERNAME = "admin", PASSWORD = "admin";
        private string username, password;
        private double ticks = 0;

        public LoginForm02()
        {
            InitializeComponent();
        }

        private void LoginForm02_Load(object sender, EventArgs e)
        {
            txtBUsername.Focus();
            txtBUsername.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllowAccess_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";

            username = txtBUsername.Text;
            password = txtBPassword.Text;

            if (username == USERNAME & password == PASSWORD)
            {
                this.Visible = false;

                ProductForm myProduct = new ProductForm();
                myProduct.ShowDialog();

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

                //timerPasswordShow.Start();
            }
            else
            {
                txtBPassword.UseSystemPasswordChar = true;
            }
        }

        /*private void timerPasswordShow_Tick(object sender, EventArgs e)
        {
            ticks += 0.5;

            if (ticks == 1.0)
            {
                checkBoxPasswordShow.Checked = false;
                timerPasswordShow.Stop();
                ticks = 0;
            }
        }*/

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
