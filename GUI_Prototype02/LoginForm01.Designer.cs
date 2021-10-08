
namespace GUI_Prototype02
{
    partial class LoginForm01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelWindow = new System.Windows.Forms.Panel();
            this.checkBoxPasswordShow = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBPassword = new System.Windows.Forms.TextBox();
            this.txtBUsername = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panelWindow.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.SystemColors.Window;
            this.panelWindow.Controls.Add(this.checkBoxPasswordShow);
            this.panelWindow.Controls.Add(this.btnExit);
            this.panelWindow.Controls.Add(this.btnLogin);
            this.panelWindow.Controls.Add(this.txtBPassword);
            this.panelWindow.Controls.Add(this.txtBUsername);
            this.panelWindow.Controls.Add(this.lblLogin);
            this.panelWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWindow.Location = new System.Drawing.Point(87, 120);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Padding = new System.Windows.Forms.Padding(5);
            this.panelWindow.Size = new System.Drawing.Size(843, 287);
            this.panelWindow.TabIndex = 0;
            // 
            // checkBoxPasswordShow
            // 
            this.checkBoxPasswordShow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPasswordShow.Location = new System.Drawing.Point(707, 136);
            this.checkBoxPasswordShow.Name = "checkBoxPasswordShow";
            this.checkBoxPasswordShow.Size = new System.Drawing.Size(145, 24);
            this.checkBoxPasswordShow.TabIndex = 5;
            this.checkBoxPasswordShow.Text = "Show Password";
            this.checkBoxPasswordShow.UseVisualStyleBackColor = true;
            this.checkBoxPasswordShow.CheckedChanged += new System.EventHandler(this.checkBoxPasswordShow_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Purple;
            this.btnExit.Location = new System.Drawing.Point(206, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Purple;
            this.btnLogin.Location = new System.Drawing.Point(501, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBPassword
            // 
            this.txtBPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtBPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPassword.ForeColor = System.Drawing.Color.Purple;
            this.txtBPassword.Location = new System.Drawing.Point(206, 130);
            this.txtBPassword.Name = "txtBPassword";
            this.txtBPassword.Size = new System.Drawing.Size(495, 31);
            this.txtBPassword.TabIndex = 2;
            this.txtBPassword.Text = "Enter Password";
            this.txtBPassword.UseSystemPasswordChar = true;
            this.txtBPassword.Click += new System.EventHandler(this.txtBPassword_Click);
            // 
            // txtBUsername
            // 
            this.txtBUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtBUsername.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUsername.ForeColor = System.Drawing.Color.Purple;
            this.txtBUsername.Location = new System.Drawing.Point(206, 86);
            this.txtBUsername.Name = "txtBUsername";
            this.txtBUsername.Size = new System.Drawing.Size(495, 31);
            this.txtBUsername.TabIndex = 1;
            this.txtBUsername.Text = "Enter Username";
            this.txtBUsername.Click += new System.EventHandler(this.txtBUsername_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Purple;
            this.lblLogin.Location = new System.Drawing.Point(200, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(500, 50);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelControl.Controls.Add(this.lblName);
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1075, 200);
            this.panelControl.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Purple;
            this.lblName.Location = new System.Drawing.Point(287, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(500, 100);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nama Ya Batho\r\nStock Management System";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(973, 447);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm01_Load);
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox checkBoxPasswordShow;
        public System.Windows.Forms.TextBox txtBPassword;
        public System.Windows.Forms.TextBox txtBUsername;
    }
}

