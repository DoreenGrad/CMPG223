namespace GUI_Prototype02
{
    partial class OrderInsert
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
            this.txtBPricePerUnit = new System.Windows.Forms.TextBox();
            this.txtBPricePerKg = new System.Windows.Forms.TextBox();
            this.txtBWeightPerUnit = new System.Windows.Forms.TextBox();
            this.lblWeightPerUnit = new System.Windows.Forms.Label();
            this.lblPricePerKg = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.txtBProductType = new System.Windows.Forms.TextBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.maskedTxtBProductKey = new System.Windows.Forms.MaskedTextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.txtBPricePerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.txtBPricePerKg);
            this.groupBoxUnitInformation.Controls.Add(this.txtBWeightPerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.lblWeightPerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.lblPricePerKg);
            this.groupBoxUnitInformation.Controls.Add(this.lblPricePerUnit);
            this.groupBoxUnitInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnitInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(430, 12);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxUnitInformation.TabIndex = 8;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Order Detail";
            // 
            // txtBPricePerUnit
            // 
            this.txtBPricePerUnit.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBPricePerUnit.Location = new System.Drawing.Point(212, 117);
            this.txtBPricePerUnit.Name = "txtBPricePerUnit";
            this.txtBPricePerUnit.Size = new System.Drawing.Size(100, 25);
            this.txtBPricePerUnit.TabIndex = 5;
            this.txtBPricePerUnit.Text = "0";
            this.txtBPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.lblWeightPerUnit.Text = "Quantity:";
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
            this.lblPricePerKg.Text = "Price per KG";
            this.lblPricePerKg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblPricePerUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPricePerUnit.Location = new System.Drawing.Point(6, 112);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(200, 35);
            this.lblPricePerUnit.TabIndex = 2;
            this.lblPricePerUnit.Text = "Price per unit:";
            this.lblPricePerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnInsert.Location = new System.Drawing.Point(310, 218);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.txtBProductType);
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
            this.groupBoxProductInformation.Controls.Add(this.maskedTxtBProductKey);
            this.groupBoxProductInformation.Controls.Add(this.lblProductType);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxProductInformation.TabIndex = 7;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Order";
            // 
            // txtBProductType
            // 
            this.txtBProductType.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBProductType.Location = new System.Drawing.Point(212, 82);
            this.txtBProductType.Name = "txtBProductType";
            this.txtBProductType.Size = new System.Drawing.Size(182, 25);
            this.txtBProductType.TabIndex = 4;
            // 
            // lblProductKey
            // 
            this.lblProductKey.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductKey.Location = new System.Drawing.Point(6, 42);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(200, 35);
            this.lblProductKey.TabIndex = 0;
            this.lblProductKey.Text = "Date Ordered";
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
            // lblProductType
            // 
            this.lblProductType.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductType.Location = new System.Drawing.Point(6, 77);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(200, 35);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Date Received";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 291);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "OrderInsert";
            this.Text = "OrderInsert";
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox txtBPricePerUnit;
        private System.Windows.Forms.TextBox txtBPricePerKg;
        private System.Windows.Forms.TextBox txtBWeightPerUnit;
        private System.Windows.Forms.Label lblWeightPerUnit;
        private System.Windows.Forms.Label lblPricePerKg;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.TextBox txtBProductType;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.MaskedTextBox maskedTxtBProductKey;
        private System.Windows.Forms.Label lblProductType;
    }
}