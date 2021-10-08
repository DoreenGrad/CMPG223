namespace GUI_Prototype02
{
    partial class Order_Update
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
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.dTP_Received = new System.Windows.Forms.DateTimePicker();
            this.dTP_Ordered = new System.Windows.Forms.DateTimePicker();
            this.tbStock_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.groupBoxUnitInformation = new System.Windows.Forms.GroupBox();
            this.tbPrice_per_Unit = new System.Windows.Forms.TextBox();
            this.tbPrice_per_Kg = new System.Windows.Forms.TextBox();
            this.tbQty_Ordered = new System.Windows.Forms.TextBox();
            this.lblWeightPerUnit = new System.Windows.Forms.Label();
            this.lblPricePerKg = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.lbView1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxProductInformation.SuspendLayout();
            this.groupBoxUnitInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.dTP_Received);
            this.groupBoxProductInformation.Controls.Add(this.dTP_Ordered);
            this.groupBoxProductInformation.Controls.Add(this.tbStock_Key);
            this.groupBoxProductInformation.Controls.Add(this.label1);
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
            this.groupBoxProductInformation.Controls.Add(this.lblProductType);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(12, 224);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(408, 139);
            this.groupBoxProductInformation.TabIndex = 8;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Order";
            // 
            // dTP_Received
            // 
            this.dTP_Received.Location = new System.Drawing.Point(194, 61);
            this.dTP_Received.Name = "dTP_Received";
            this.dTP_Received.Size = new System.Drawing.Size(200, 27);
            this.dTP_Received.TabIndex = 9;
            // 
            // dTP_Ordered
            // 
            this.dTP_Ordered.Location = new System.Drawing.Point(194, 28);
            this.dTP_Ordered.Name = "dTP_Ordered";
            this.dTP_Ordered.Size = new System.Drawing.Size(200, 27);
            this.dTP_Ordered.TabIndex = 8;
            // 
            // tbStock_Key
            // 
            this.tbStock_Key.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbStock_Key.Location = new System.Drawing.Point(194, 93);
            this.tbStock_Key.Name = "tbStock_Key";
            this.tbStock_Key.Size = new System.Drawing.Size(200, 25);
            this.tbStock_Key.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductKey
            // 
            this.lblProductKey.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductKey.Location = new System.Drawing.Point(6, 26);
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
            this.lblProductType.Location = new System.Drawing.Point(6, 58);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(200, 35);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Date Received";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(426, 224);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(407, 144);
            this.groupBoxUnitInformation.TabIndex = 9;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Order Detail";
            // 
            // tbPrice_per_Unit
            // 
            this.tbPrice_per_Unit.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbPrice_per_Unit.Location = new System.Drawing.Point(211, 93);
            this.tbPrice_per_Unit.Name = "tbPrice_per_Unit";
            this.tbPrice_per_Unit.Size = new System.Drawing.Size(182, 25);
            this.tbPrice_per_Unit.TabIndex = 5;
            this.tbPrice_per_Unit.Text = "0";
            this.tbPrice_per_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrice_per_Kg
            // 
            this.tbPrice_per_Kg.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbPrice_per_Kg.Location = new System.Drawing.Point(212, 58);
            this.tbPrice_per_Kg.Name = "tbPrice_per_Kg";
            this.tbPrice_per_Kg.Size = new System.Drawing.Size(181, 25);
            this.tbPrice_per_Kg.TabIndex = 4;
            this.tbPrice_per_Kg.Text = "0";
            this.tbPrice_per_Kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbQty_Ordered
            // 
            this.tbQty_Ordered.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbQty_Ordered.Location = new System.Drawing.Point(212, 23);
            this.tbQty_Ordered.Name = "tbQty_Ordered";
            this.tbQty_Ordered.Size = new System.Drawing.Size(181, 25);
            this.tbQty_Ordered.TabIndex = 3;
            this.tbQty_Ordered.Text = "0";
            this.tbQty_Ordered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWeightPerUnit
            // 
            this.lblWeightPerUnit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblWeightPerUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeightPerUnit.Location = new System.Drawing.Point(6, 18);
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
            this.lblPricePerKg.Location = new System.Drawing.Point(6, 58);
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
            this.lblPricePerUnit.Location = new System.Drawing.Point(6, 93);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(200, 35);
            this.lblPricePerUnit.TabIndex = 2;
            this.lblPricePerUnit.Text = "Price per unit:";
            this.lblPricePerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnC.Location = new System.Drawing.Point(384, 388);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(200, 50);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "CANCEL";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnU.FlatAppearance.BorderSize = 2;
            this.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.Purple;
            this.btnU.Location = new System.Drawing.Point(151, 388);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(200, 50);
            this.btnU.TabIndex = 12;
            this.btnU.Text = "UPDATE";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // lbView1
            // 
            this.lbView1.FormattingEnabled = true;
            this.lbView1.Location = new System.Drawing.Point(12, 60);
            this.lbView1.Name = "lbView1";
            this.lbView1.Size = new System.Drawing.Size(807, 43);
            this.lbView1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(393, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date_Received";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(194, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Date_Ordered";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(102, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "User_ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Order_ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(807, 43);
            this.listBox1.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(622, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Price_per_Kg";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(485, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Price_per_Unit";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(340, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Qty_Ordered";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(252, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Stock_ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(158, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Order_ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Order_Detail_ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Orders:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(12, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 29);
            this.label12.TabIndex = 38;
            this.label12.Text = "Orders Detail:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Order_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbView1);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.groupBoxUnitInformation);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "Order_Update";
            this.Text = "Order_Update";
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.DateTimePicker dTP_Received;
        private System.Windows.Forms.DateTimePicker dTP_Ordered;
        private System.Windows.Forms.TextBox tbStock_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox tbPrice_per_Unit;
        private System.Windows.Forms.TextBox tbPrice_per_Kg;
        private System.Windows.Forms.TextBox tbQty_Ordered;
        private System.Windows.Forms.Label lblWeightPerUnit;
        private System.Windows.Forms.Label lblPricePerKg;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.ListBox lbView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}