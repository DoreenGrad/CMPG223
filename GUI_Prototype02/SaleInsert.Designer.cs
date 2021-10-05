namespace GUI_Prototype02
{
    partial class SaleInsert
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
            this.txtBPricePerKg = new System.Windows.Forms.TextBox();
            this.txtBWeightPerUnit = new System.Windows.Forms.TextBox();
            this.lblWeightPerUnit = new System.Windows.Forms.Label();
            this.lblPricePerKg = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.maskedTxtBProductKey = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.txtBPricePerKg);
            this.groupBoxUnitInformation.Controls.Add(this.txtBWeightPerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.lblWeightPerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.lblPricePerKg);
            this.groupBoxUnitInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnitInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(52, 107);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxUnitInformation.TabIndex = 11;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Sale Detail";
            // 
            // txtBPricePerKg
            // 
            this.txtBPricePerKg.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBPricePerKg.Location = new System.Drawing.Point(212, 82);
            this.txtBPricePerKg.Name = "txtBPricePerKg";
            this.txtBPricePerKg.Size = new System.Drawing.Size(100, 25);
            this.txtBPricePerKg.TabIndex = 4;
            this.txtBPricePerKg.Text = "0";
            this.txtBPricePerKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBWeightPerUnit
            // 
            this.txtBWeightPerUnit.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBWeightPerUnit.Location = new System.Drawing.Point(212, 47);
            this.txtBWeightPerUnit.Name = "txtBWeightPerUnit";
            this.txtBWeightPerUnit.Size = new System.Drawing.Size(100, 25);
            this.txtBWeightPerUnit.TabIndex = 3;
            this.txtBWeightPerUnit.Text = "0";
            this.txtBWeightPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWeightPerUnit
            // 
            this.lblWeightPerUnit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblWeightPerUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeightPerUnit.Location = new System.Drawing.Point(6, 42);
            this.lblWeightPerUnit.Name = "lblWeightPerUnit";
            this.lblWeightPerUnit.Size = new System.Drawing.Size(200, 35);
            this.lblWeightPerUnit.TabIndex = 0;
            this.lblWeightPerUnit.Text = "Sale Price Per unit";
            this.lblWeightPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPricePerKg
            // 
            this.lblPricePerKg.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblPricePerKg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPricePerKg.Location = new System.Drawing.Point(6, 77);
            this.lblPricePerKg.Name = "lblPricePerKg";
            this.lblPricePerKg.Size = new System.Drawing.Size(200, 35);
            this.lblPricePerKg.TabIndex = 1;
            this.lblPricePerKg.Text = "Quantity sold";
            this.lblPricePerKg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
            this.groupBoxProductInformation.Controls.Add(this.maskedTxtBProductKey);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(52, 12);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxProductInformation.TabIndex = 10;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Sale";
            // 
            // lblProductKey
            // 
            this.lblProductKey.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductKey.Location = new System.Drawing.Point(6, 42);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(200, 35);
            this.lblProductKey.TabIndex = 0;
            this.lblProductKey.Text = "Sale Date";
            this.lblProductKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTxtBProductKey
            // 
            this.maskedTxtBProductKey.Font = new System.Drawing.Font("Verdana", 11F);
            this.maskedTxtBProductKey.Location = new System.Drawing.Point(212, 47);
            this.maskedTxtBProductKey.Mask = ">LLLL0000";
            this.maskedTxtBProductKey.Name = "maskedTxtBProductKey";
            this.maskedTxtBProductKey.Size = new System.Drawing.Size(100, 25);
            this.maskedTxtBProductKey.TabIndex = 3;
            // 
            // SaleInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 454);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "SaleInsert";
            this.Text = "SaleInsert";
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox txtBPricePerKg;
        private System.Windows.Forms.TextBox txtBWeightPerUnit;
        private System.Windows.Forms.Label lblWeightPerUnit;
        private System.Windows.Forms.Label lblPricePerKg;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.MaskedTextBox maskedTxtBProductKey;
    }
}