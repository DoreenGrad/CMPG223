namespace GUI_Prototype02
{
    partial class OrderInsertUpdateForm
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
            this.tbPrice_per_Unit = new System.Windows.Forms.TextBox();
            this.tbPrice_per_Kg = new System.Windows.Forms.TextBox();
            this.tbQty_Ordered = new System.Windows.Forms.TextBox();
            this.lblWeightPerUnit = new System.Windows.Forms.Label();
            this.lblPricePerKg = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.tbDate_Ordered = new System.Windows.Forms.TextBox();
            this.tbDate_Received = new System.Windows.Forms.TextBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.tbPrice_per_Unit);
            this.groupBoxUnitInformation.Controls.Add(this.tbPrice_per_Kg);
            this.groupBoxUnitInformation.Controls.Add(this.tbQty_Ordered);
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
            // tbPrice_per_Unit
            // 
            this.tbPrice_per_Unit.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbPrice_per_Unit.Location = new System.Drawing.Point(212, 117);
            this.tbPrice_per_Unit.Name = "tbPrice_per_Unit";
            this.tbPrice_per_Unit.Size = new System.Drawing.Size(100, 25);
            this.tbPrice_per_Unit.TabIndex = 5;
            this.tbPrice_per_Unit.Text = "0";
            this.tbPrice_per_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrice_per_Kg
            // 
            this.tbPrice_per_Kg.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbPrice_per_Kg.Location = new System.Drawing.Point(212, 82);
            this.tbPrice_per_Kg.Name = "tbPrice_per_Kg";
            this.tbPrice_per_Kg.Size = new System.Drawing.Size(100, 25);
            this.tbPrice_per_Kg.TabIndex = 4;
            this.tbPrice_per_Kg.Text = "0";
            this.tbPrice_per_Kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbQty_Ordered
            // 
            this.tbQty_Ordered.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbQty_Ordered.Location = new System.Drawing.Point(212, 47);
            this.tbQty_Ordered.Name = "tbQty_Ordered";
            this.tbQty_Ordered.Size = new System.Drawing.Size(100, 25);
            this.tbQty_Ordered.TabIndex = 3;
            this.tbQty_Ordered.Text = "0";
            this.tbQty_Ordered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.tbDate_Ordered);
            this.groupBoxProductInformation.Controls.Add(this.tbDate_Received);
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
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
            // tbDate_Ordered
            // 
            this.tbDate_Ordered.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbDate_Ordered.Location = new System.Drawing.Point(212, 47);
            this.tbDate_Ordered.Name = "tbDate_Ordered";
            this.tbDate_Ordered.Size = new System.Drawing.Size(182, 25);
            this.tbDate_Ordered.TabIndex = 5;
            // 
            // tbDate_Received
            // 
            this.tbDate_Received.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbDate_Received.Location = new System.Drawing.Point(212, 82);
            this.tbDate_Received.Name = "tbDate_Received";
            this.tbDate_Received.Size = new System.Drawing.Size(182, 25);
            this.tbDate_Received.TabIndex = 4;
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
            // OrderInsertUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 291);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "OrderInsertUpdateForm";
            this.Text = "Order Insert/Update";
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox tbPrice_per_Unit;
        private System.Windows.Forms.TextBox tbPrice_per_Kg;
        private System.Windows.Forms.TextBox tbQty_Ordered;
        private System.Windows.Forms.Label lblWeightPerUnit;
        private System.Windows.Forms.Label lblPricePerKg;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.TextBox tbDate_Received;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox tbDate_Ordered;
    }
}