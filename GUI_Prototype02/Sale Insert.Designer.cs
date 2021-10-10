namespace GUI_Prototype02
{
    partial class insertSaleForm
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
            this.groupBoxUnitInformation = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Qty_Sold = new System.Windows.Forms.TextBox();
            this.tbSale_Price_per_Unit = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQuantitySold = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.dTP_Saledate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.comboBox1);
            this.groupBoxUnitInformation.Controls.Add(this.label1);
            this.groupBoxUnitInformation.Controls.Add(this.tb_Qty_Sold);
            this.groupBoxUnitInformation.Controls.Add(this.tbSale_Price_per_Unit);
            this.groupBoxUnitInformation.Controls.Add(this.lblSalePrice);
            this.groupBoxUnitInformation.Controls.Add(this.lblQuantitySold);
            this.groupBoxUnitInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnitInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(12, 107);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(422, 189);
            this.groupBoxUnitInformation.TabIndex = 11;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Sale Detail";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stock key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Qty_Sold
            // 
            this.tb_Qty_Sold.Font = new System.Drawing.Font("Verdana", 11F);
            this.tb_Qty_Sold.Location = new System.Drawing.Point(212, 82);
            this.tb_Qty_Sold.Name = "tb_Qty_Sold";
            this.tb_Qty_Sold.Size = new System.Drawing.Size(157, 25);
            this.tb_Qty_Sold.TabIndex = 4;
            this.tb_Qty_Sold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSale_Price_per_Unit
            // 
            this.tbSale_Price_per_Unit.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbSale_Price_per_Unit.Location = new System.Drawing.Point(212, 47);
            this.tbSale_Price_per_Unit.Name = "tbSale_Price_per_Unit";
            this.tbSale_Price_per_Unit.Size = new System.Drawing.Size(157, 25);
            this.tbSale_Price_per_Unit.TabIndex = 3;
            this.tbSale_Price_per_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalePrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalePrice.Location = new System.Drawing.Point(6, 42);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(200, 35);
            this.lblSalePrice.TabIndex = 0;
            this.lblSalePrice.Text = "Sale Price Per unit:";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantitySold
            // 
            this.lblQuantitySold.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantitySold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantitySold.Location = new System.Drawing.Point(6, 77);
            this.lblQuantitySold.Name = "lblQuantitySold";
            this.lblQuantitySold.Size = new System.Drawing.Size(200, 35);
            this.lblQuantitySold.TabIndex = 1;
            this.lblQuantitySold.Text = "Quantity sold:";
            this.lblQuantitySold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnInsert.Location = new System.Drawing.Point(12, 302);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.dTP_Saledate);
            this.groupBoxProductInformation.Controls.Add(this.lblSaleDate);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(422, 89);
            this.groupBoxProductInformation.TabIndex = 10;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Sale";
            // 
            // dTP_Saledate
            // 
            this.dTP_Saledate.Location = new System.Drawing.Point(192, 42);
            this.dTP_Saledate.Name = "dTP_Saledate";
            this.dTP_Saledate.Size = new System.Drawing.Size(200, 27);
            this.dTP_Saledate.TabIndex = 5;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblSaleDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaleDate.Location = new System.Drawing.Point(6, 42);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(200, 35);
            this.lblSaleDate.TabIndex = 0;
            this.lblSaleDate.Text = "Sale Date:";
            this.lblSaleDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnC
            // 
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnC.FlatAppearance.BorderSize = 2;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Purple;
            this.btnC.Location = new System.Drawing.Point(234, 302);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(200, 50);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "CANCEL";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // insertSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 377);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "insertSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Sale";
            this.Load += new System.EventHandler(this.insertSaleForm_Load);
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox tb_Qty_Sold;
        private System.Windows.Forms.TextBox tbSale_Price_per_Unit;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQuantitySold;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.DateTimePicker dTP_Saledate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}