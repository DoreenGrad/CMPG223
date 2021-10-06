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
            this.txtPriceUnit = new System.Windows.Forms.TextBox();
            this.txtPriceKg = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblWeightPerUnit = new System.Windows.Forms.Label();
            this.lblPricePerKg = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.txtDateReceived = new System.Windows.Forms.TextBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.mtbDateOrdered = new System.Windows.Forms.MaskedTextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.txtPriceUnit);
            this.groupBoxUnitInformation.Controls.Add(this.txtPriceKg);
            this.groupBoxUnitInformation.Controls.Add(this.txtQuantity);
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
            // txtPriceUnit
            // 
            this.txtPriceUnit.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPriceUnit.Location = new System.Drawing.Point(212, 117);
            this.txtPriceUnit.Name = "txtPriceUnit";
            this.txtPriceUnit.Size = new System.Drawing.Size(100, 25);
            this.txtPriceUnit.TabIndex = 5;
            this.txtPriceUnit.Text = "0";
            this.txtPriceUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceKg
            // 
            this.txtPriceKg.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPriceKg.Location = new System.Drawing.Point(212, 82);
            this.txtPriceKg.Name = "txtPriceKg";
            this.txtPriceKg.Size = new System.Drawing.Size(100, 25);
            this.txtPriceKg.TabIndex = 4;
            this.txtPriceKg.Text = "0";
            this.txtPriceKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(212, 47);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 25);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.groupBoxProductInformation.Controls.Add(this.txtDateReceived);
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
            this.groupBoxProductInformation.Controls.Add(this.mtbDateOrdered);
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
            // txtDateReceived
            // 
            this.txtDateReceived.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtDateReceived.Location = new System.Drawing.Point(212, 82);
            this.txtDateReceived.Name = "txtDateReceived";
            this.txtDateReceived.Size = new System.Drawing.Size(182, 25);
            this.txtDateReceived.TabIndex = 4;
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
            // mtbDateOrdered
            // 
            this.mtbDateOrdered.Font = new System.Drawing.Font("Verdana", 11F);
            this.mtbDateOrdered.Location = new System.Drawing.Point(212, 47);
            this.mtbDateOrdered.Mask = ">LLLL0000";
            this.mtbDateOrdered.Name = "mtbDateOrdered";
            this.mtbDateOrdered.Size = new System.Drawing.Size(100, 25);
            this.mtbDateOrdered.TabIndex = 3;
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
        private System.Windows.Forms.TextBox txtPriceUnit;
        private System.Windows.Forms.TextBox txtPriceKg;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblWeightPerUnit;
        private System.Windows.Forms.Label lblPricePerKg;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.TextBox txtDateReceived;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.MaskedTextBox mtbDateOrdered;
        private System.Windows.Forms.Label lblProductType;
    }
}