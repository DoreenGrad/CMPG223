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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridSearchAndDelete = new System.Windows.Forms.DataGridView();
            this.groupBoxUnitInformation = new System.Windows.Forms.GroupBox();
            this.txtBStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtBPricePerUnit = new System.Windows.Forms.TextBox();
            this.txtBPricePerKg = new System.Windows.Forms.TextBox();
            this.txtBWeightPerUnit = new System.Windows.Forms.TextBox();
            this.lblWeightPerUnit = new System.Windows.Forms.Label();
            this.lblPricePerKg = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.txtBProductDescription = new System.Windows.Forms.TextBox();
            this.txtBProductType = new System.Windows.Forms.TextBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.maskedTxtBProductKey = new System.Windows.Forms.MaskedTextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAndDelete)).BeginInit();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(836, 655);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 25;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(836, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 24;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
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
            this.btnInsert.Location = new System.Drawing.Point(836, 520);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridSearchAndDelete
            // 
            this.dataGridSearchAndDelete.AllowUserToAddRows = false;
            this.dataGridSearchAndDelete.AllowUserToDeleteRows = false;
            this.dataGridSearchAndDelete.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridSearchAndDelete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSearchAndDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchAndDelete.GridColor = System.Drawing.Color.Purple;
            this.dataGridSearchAndDelete.Location = new System.Drawing.Point(12, 12);
            this.dataGridSearchAndDelete.Name = "dataGridSearchAndDelete";
            this.dataGridSearchAndDelete.ReadOnly = true;
            this.dataGridSearchAndDelete.Size = new System.Drawing.Size(1340, 490);
            this.dataGridSearchAndDelete.TabIndex = 22;
            // 
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.txtBStock);
            this.groupBoxUnitInformation.Controls.Add(this.lblStock);
            this.groupBoxUnitInformation.Controls.Add(this.txtBPricePerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.txtBPricePerKg);
            this.groupBoxUnitInformation.Controls.Add(this.txtBWeightPerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.lblWeightPerUnit);
            this.groupBoxUnitInformation.Controls.Add(this.lblPricePerKg);
            this.groupBoxUnitInformation.Controls.Add(this.lblPricePerUnit);
            this.groupBoxUnitInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnitInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(430, 508);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxUnitInformation.TabIndex = 21;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Unit Information";
            // 
            // txtBStock
            // 
            this.txtBStock.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBStock.Location = new System.Drawing.Point(212, 152);
            this.txtBStock.Name = "txtBStock";
            this.txtBStock.Size = new System.Drawing.Size(100, 25);
            this.txtBStock.TabIndex = 7;
            this.txtBStock.Text = "0";
            this.txtBStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStock.Location = new System.Drawing.Point(6, 147);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(200, 35);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblWeightPerUnit.Text = "Weight per Unit (kg):";
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
            this.lblPricePerKg.Text = "Price (per kg):";
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
            this.lblPricePerUnit.Text = "Price per Unit:";
            this.lblPricePerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.txtBProductDescription);
            this.groupBoxProductInformation.Controls.Add(this.txtBProductType);
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
            this.groupBoxProductInformation.Controls.Add(this.maskedTxtBProductKey);
            this.groupBoxProductInformation.Controls.Add(this.lblProductType);
            this.groupBoxProductInformation.Controls.Add(this.lblProductDescription);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(12, 508);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxProductInformation.TabIndex = 20;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Product Information";
            // 
            // txtBProductDescription
            // 
            this.txtBProductDescription.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBProductDescription.Location = new System.Drawing.Point(212, 117);
            this.txtBProductDescription.Name = "txtBProductDescription";
            this.txtBProductDescription.Size = new System.Drawing.Size(182, 25);
            this.txtBProductDescription.TabIndex = 5;
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
            this.lblProductKey.Text = "Product Key:";
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
            this.lblProductType.Text = "Product Type:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductDescription.Location = new System.Drawing.Point(6, 112);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(200, 35);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Product Description:";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(1087, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Sale_Products_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 786);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridSearchAndDelete);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "Sale_Products_Form";
            this.Text = "Sell Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAndDelete)).EndInit();
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridSearchAndDelete;
        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox txtBStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBPricePerUnit;
        private System.Windows.Forms.TextBox txtBPricePerKg;
        private System.Windows.Forms.TextBox txtBWeightPerUnit;
        private System.Windows.Forms.Label lblWeightPerUnit;
        private System.Windows.Forms.Label lblPricePerKg;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.TextBox txtBProductDescription;
        private System.Windows.Forms.TextBox txtBProductType;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.MaskedTextBox maskedTxtBProductKey;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Button button1;
    }
}