﻿namespace GUI_Prototype02
{
    partial class Sale_Update
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
            this.dTP_Saledate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.groupBoxUnitInformation = new System.Windows.Forms.GroupBox();
            this.tbStock_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Qty_Sold = new System.Windows.Forms.TextBox();
            this.tbSale_Price_per_Unit = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQuantitySold = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbView1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnU = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBoxProductInformation.SuspendLayout();
            this.groupBoxUnitInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.groupBoxUnitInformation);
            this.groupBoxProductInformation.Controls.Add(this.dTP_Saledate);
            this.groupBoxProductInformation.Controls.Add(this.lblSaleDate);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(12, 199);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(374, 153);
            this.groupBoxProductInformation.TabIndex = 11;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Sale";
            // 
            // dTP_Saledate
            // 
            this.dTP_Saledate.Location = new System.Drawing.Point(159, 42);
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
            // groupBoxUnitInformation
            // 
            this.groupBoxUnitInformation.Controls.Add(this.tbStock_Key);
            this.groupBoxUnitInformation.Controls.Add(this.label1);
            this.groupBoxUnitInformation.Controls.Add(this.tb_Qty_Sold);
            this.groupBoxUnitInformation.Controls.Add(this.tbSale_Price_per_Unit);
            this.groupBoxUnitInformation.Controls.Add(this.lblSalePrice);
            this.groupBoxUnitInformation.Controls.Add(this.lblQuantitySold);
            this.groupBoxUnitInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnitInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxUnitInformation.Location = new System.Drawing.Point(428, 10);
            this.groupBoxUnitInformation.Name = "groupBoxUnitInformation";
            this.groupBoxUnitInformation.Size = new System.Drawing.Size(422, 189);
            this.groupBoxUnitInformation.TabIndex = 12;
            this.groupBoxUnitInformation.TabStop = false;
            this.groupBoxUnitInformation.Text = "Sale Detail";
            // 
            // tbStock_Key
            // 
            this.tbStock_Key.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbStock_Key.Location = new System.Drawing.Point(212, 113);
            this.tbStock_Key.Name = "tbStock_Key";
            this.tbStock_Key.Size = new System.Drawing.Size(157, 25);
            this.tbStock_Key.TabIndex = 14;
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
            this.tb_Qty_Sold.Text = "0";
            this.tb_Qty_Sold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSale_Price_per_Unit
            // 
            this.tbSale_Price_per_Unit.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbSale_Price_per_Unit.Location = new System.Drawing.Point(212, 47);
            this.tbSale_Price_per_Unit.Name = "tbSale_Price_per_Unit";
            this.tbSale_Price_per_Unit.Size = new System.Drawing.Size(157, 25);
            this.tbSale_Price_per_Unit.TabIndex = 3;
            this.tbSale_Price_per_Unit.Text = "0";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(392, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 153);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Detail";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox1.Location = new System.Drawing.Point(212, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 25);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stock key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox2.Location = new System.Drawing.Point(212, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox3.Location = new System.Drawing.Point(212, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sale Price Per unit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity sold:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(101, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Sale_Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sale_ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Sales:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbView1
            // 
            this.lbView1.FormattingEnabled = true;
            this.lbView1.Location = new System.Drawing.Point(12, 50);
            this.lbView1.Name = "lbView1";
            this.lbView1.Size = new System.Drawing.Size(797, 43);
            this.lbView1.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(341, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Sale_Price_per_Unit";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(244, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Stock_ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(146, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Sale_ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(9, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "Sale_Detail_ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(9, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 29);
            this.label12.TabIndex = 48;
            this.label12.Text = "Sales Detail:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(797, 43);
            this.listBox1.TabIndex = 53;
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
            this.btnU.Location = new System.Drawing.Point(171, 379);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(200, 50);
            this.btnU.TabIndex = 54;
            this.btnU.Text = "UPDATE";
            this.btnU.UseVisualStyleBackColor = true;
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
            this.btnC.Location = new System.Drawing.Point(417, 379);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(200, 50);
            this.btnC.TabIndex = 55;
            this.btnC.Text = "CANCEL";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // Sale_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProductInformation);
            this.Name = "Sale_Update";
            this.Text = "Sale_Update";
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.ResumeLayout(false);
            this.groupBoxUnitInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.DateTimePicker dTP_Saledate;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.GroupBox groupBoxUnitInformation;
        private System.Windows.Forms.TextBox tbStock_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Qty_Sold;
        private System.Windows.Forms.TextBox tbSale_Price_per_Unit;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQuantitySold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnC;
    }
}