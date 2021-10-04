
namespace GUI_Prototype02
{
    partial class LoginForm02
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAllowAccess = new System.Windows.Forms.Button();
            this.txtBPassword = new System.Windows.Forms.TextBox();
            this.txtBUsername = new System.Windows.Forms.TextBox();
            this.lblAuthentication = new System.Windows.Forms.Label();
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
            this.panelWindow.Controls.Add(this.btnCancel);
            this.panelWindow.Controls.Add(this.btnAllowAccess);
            this.panelWindow.Controls.Add(this.txtBPassword);
            this.panelWindow.Controls.Add(this.txtBUsername);
            this.panelWindow.Controls.Add(this.lblAuthentication);
            this.panelWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWindow.Location = new System.Drawing.Point(87, 120);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Padding = new System.Windows.Forms.Padding(5);
            this.panelWindow.Size = new System.Drawing.Size(900, 325);
            this.panelWindow.TabIndex = 2;
            // 
            // checkBoxPasswordShow
            // 
            this.checkBoxPasswordShow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPasswordShow.Location = new System.Drawing.Point(707, 136);
            this.checkBoxPasswordShow.Name = "checkBoxPasswordShow";
            this.checkBoxPasswordShow.Size = new System.Drawing.Size(145, 24);
            this.checkBoxPasswordShow.TabIndex = 6;
            this.checkBoxPasswordShow.Text = "Show Password";
            this.checkBoxPasswordShow.UseVisualStyleBackColor = true;
            this.checkBoxPasswordShow.CheckedChanged += new System.EventHandler(this.checkBoxPasswordShow_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Purple;
            this.btnCancel.Location = new System.Drawing.Point(206, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAllowAccess
            // 
            this.btnAllowAccess.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnAllowAccess.FlatAppearance.BorderSize = 2;
            this.btnAllowAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAllowAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAllowAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllowAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllowAccess.ForeColor = System.Drawing.Color.Purple;
            this.btnAllowAccess.Location = new System.Drawing.Point(501, 194);
            this.btnAllowAccess.Name = "btnAllowAccess";
            this.btnAllowAccess.Size = new System.Drawing.Size(200, 50);
            this.btnAllowAccess.TabIndex = 4;
            this.btnAllowAccess.Text = "ALLOW ACCESS";
            this.btnAllowAccess.UseVisualStyleBackColor = true;
            this.btnAllowAccess.Click += new System.EventHandler(this.btnAllowAccess_Click);
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
            this.txtBPassword.TabIndex = 3;
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
            this.txtBUsername.TabIndex = 2;
            this.txtBUsername.Text = "Enter Username";
            this.txtBUsername.Click += new System.EventHandler(this.txtBUsername_Click);
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthentication.ForeColor = System.Drawing.Color.Purple;
            this.lblAuthentication.Location = new System.Drawing.Point(200, 5);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(500, 50);
            this.lblAuthentication.TabIndex = 1;
            this.lblAuthentication.Text = "Authentication";
            this.lblAuthentication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.Control;
            this.panelControl.Controls.Add(this.lblName);
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1075, 200);
            this.panelControl.TabIndex = 3;
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
            // LoginForm02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1075, 500);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.LoginForm02_Load);
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAllowAccess;
        private System.Windows.Forms.TextBox txtBPassword;
        private System.Windows.Forms.TextBox txtBUsername;
        private System.Windows.Forms.Label lblAuthentication;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkBoxPasswordShow;
    }
}