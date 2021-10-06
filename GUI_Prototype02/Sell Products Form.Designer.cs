namespace GUI_Prototype02
{
    partial class Sale_Products_Form
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbSale_Detail = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnDel.FlatAppearance.BorderSize = 2;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Purple;
            this.btnDel.Location = new System.Drawing.Point(20, 509);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(194, 50);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdate.Location = new System.Drawing.Point(221, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnInsert.FlatAppearance.BorderSize = 2;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Purple;
            this.btnInsert.Location = new System.Drawing.Point(274, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblSale
            // 
            this.lblSale.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.Purple;
            this.lblSale.Location = new System.Drawing.Point(16, 24);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(458, 38);
            this.lblSale.TabIndex = 19;
            this.lblSale.Text = "Insert new Sale: ";
            this.lblSale.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Purple;
            this.lblLogin.Location = new System.Drawing.Point(16, 243);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(458, 38);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Select Sale:";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStockID);
            this.groupBox5.Controls.Add(this.txtSaleID);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.mtbSale_Detail);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Purple;
            this.groupBox5.Location = new System.Drawing.Point(21, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 162);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search by: ";
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtStockID.Location = new System.Drawing.Point(212, 117);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(182, 25);
            this.txtStockID.TabIndex = 5;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSaleID.Location = new System.Drawing.Point(212, 82);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(182, 25);
            this.txtSaleID.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 35);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sale Detail ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbSale_Detail
            // 
            this.mtbSale_Detail.Font = new System.Drawing.Font("Verdana", 11F);
            this.mtbSale_Detail.Location = new System.Drawing.Point(212, 47);
            this.mtbSale_Detail.Mask = ">LLLL0000";
            this.mtbSale_Detail.Name = "mtbSale_Detail";
            this.mtbSale_Detail.Size = new System.Drawing.Size(100, 25);
            this.mtbSale_Detail.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 35);
            this.label13.TabIndex = 1;
            this.label13.Text = "Sale ID:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(6, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 35);
            this.label14.TabIndex = 2;
            this.label14.Text = "Stock ID:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgView
            // 
            this.dtgView.AllowUserToAddRows = false;
            this.dtgView.AllowUserToDeleteRows = false;
            this.dtgView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.GridColor = System.Drawing.Color.Purple;
            this.dtgView.Location = new System.Drawing.Point(21, 284);
            this.dtgView.Name = "dtgView";
            this.dtgView.ReadOnly = true;
            this.dtgView.Size = new System.Drawing.Size(1018, 219);
            this.dtgView.TabIndex = 16;
            // 
            // Sale_Products_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 783);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dtgView);
            this.Name = "Sale_Products_Form";
            this.Text = "Sell Products";
            this.Load += new System.EventHandler(this.Sale_Products_Form_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbSale_Detail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgView;
    }
}