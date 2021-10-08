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
    public partial class Authentication_Form : Form
    {
        public Authentication_Form()
        {
            InitializeComponent();
        }

        public string sUsername;
        public string sPassword;

        private void btnAllowAccess_Click(object sender, EventArgs e)
        {
            sUsername = tbUsername.Text;
            sPassword = tbPassword.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
