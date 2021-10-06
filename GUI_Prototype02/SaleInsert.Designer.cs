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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQuantitySold = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.mtbSaleDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.txtQuantity);
            this.groupBoxUnitInformation.Controls.Add(this.txtSalePrice);
            this.groupBoxUnitInformation.Controls.Add(this.lblSalePrice);
            this.groupBoxUnitInformation.Controls.Add(this.lblQuantitySold);
            this.groupBoxUnitInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnitInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(52, 107);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxUnitInformation.TabIndex = 11;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Sale Detail";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(212, 82);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 25);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSalePrice.Location = new System.Drawing.Point(212, 47);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 25);
            this.txtSalePrice.TabIndex = 3;
            this.txtSalePrice.Text = "0";
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnInsert.Location = new System.Drawing.Point(468, 107);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.lblSaleDate);
            this.groupBoxProductInformation.Controls.Add(this.mtbSaleDate);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(52, 12);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxProductInformation.TabIndex = 10;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Sale";
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
            // mtbSaleDate
            // 
            this.mtbSaleDate.Font = new System.Drawing.Font("Verdana", 11F);
            this.mtbSaleDate.Location = new System.Drawing.Point(212, 47);
            this.mtbSaleDate.Mask = ">LLLL0000";
            this.mtbSaleDate.Name = "mtbSaleDate";
            this.mtbSaleDate.Size = new System.Drawing.Size(100, 25);
            this.mtbSaleDate.TabIndex = 3;
            // 
            // insertSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 357);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "insertSaleForm";
            this.Text = "INSERT SALES";
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQuantitySold;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.MaskedTextBox mtbSaleDate;
    }
}