
namespace GUI_Prototype02
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblViewOr = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.lblDeleteOr = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.lblUpdateOr = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.lblCreateOr = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox14 = new System.Windows.Forms.RichTextBox();
            this.pnlOrders.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Purple;
            this.btnBack.Location = new System.Drawing.Point(779, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Blue;
            this.lblOrder.Location = new System.Drawing.Point(12, 9);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(200, 21);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.Text = "Orders button";
            this.lblOrder.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Blue;
            this.lblStock.Location = new System.Drawing.Point(12, 41);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(203, 22);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock button";
            this.lblStock.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblSales
            // 
            this.lblSales.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.Blue;
            this.lblSales.Location = new System.Drawing.Point(12, 77);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(203, 22);
            this.lblSales.TabIndex = 10;
            this.lblSales.Text = "Sale button";
            this.lblSales.Click += new System.EventHandler(this.lblSales_Click);
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.label2);
            this.pnlOrders.Controls.Add(this.richTextBox1);
            this.pnlOrders.Controls.Add(this.lblViewOr);
            this.pnlOrders.Controls.Add(this.richTextBox7);
            this.pnlOrders.Controls.Add(this.lblDeleteOr);
            this.pnlOrders.Controls.Add(this.richTextBox6);
            this.pnlOrders.Controls.Add(this.lblUpdateOr);
            this.pnlOrders.Controls.Add(this.richTextBox5);
            this.pnlOrders.Controls.Add(this.lblCreateOr);
            this.pnlOrders.Controls.Add(this.richTextBox4);
            this.pnlOrders.Location = new System.Drawing.Point(15, 33);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(671, 644);
            this.pnlOrders.TabIndex = 18;
            this.pnlOrders.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(3, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Return to main menu";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(6, 606);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(638, 35);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "Click the main menu buton on the order page\n";
            // 
            // lblViewOr
            // 
            this.lblViewOr.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblViewOr.Location = new System.Drawing.Point(3, 8);
            this.lblViewOr.Name = "lblViewOr";
            this.lblViewOr.Size = new System.Drawing.Size(200, 21);
            this.lblViewOr.TabIndex = 25;
            this.lblViewOr.Text = "View an order";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox7.Location = new System.Drawing.Point(6, 32);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(638, 99);
            this.richTextBox7.TabIndex = 26;
            this.richTextBox7.Text = resources.GetString("richTextBox7.Text");
            // 
            // lblDeleteOr
            // 
            this.lblDeleteOr.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteOr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDeleteOr.Location = new System.Drawing.Point(3, 469);
            this.lblDeleteOr.Name = "lblDeleteOr";
            this.lblDeleteOr.Size = new System.Drawing.Size(182, 24);
            this.lblDeleteOr.TabIndex = 23;
            this.lblDeleteOr.Text = "Delete an order";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox6.Location = new System.Drawing.Point(6, 496);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(638, 104);
            this.richTextBox6.TabIndex = 24;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            // 
            // lblUpdateOr
            // 
            this.lblUpdateOr.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateOr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblUpdateOr.Location = new System.Drawing.Point(3, 280);
            this.lblUpdateOr.Name = "lblUpdateOr";
            this.lblUpdateOr.Size = new System.Drawing.Size(171, 20);
            this.lblUpdateOr.TabIndex = 21;
            this.lblUpdateOr.Text = "Update an order";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox5.Location = new System.Drawing.Point(6, 305);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(638, 161);
            this.richTextBox5.TabIndex = 22;
            this.richTextBox5.Text = resources.GetString("richTextBox5.Text");
            // 
            // lblCreateOr
            // 
            this.lblCreateOr.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateOr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCreateOr.Location = new System.Drawing.Point(3, 134);
            this.lblCreateOr.Name = "lblCreateOr";
            this.lblCreateOr.Size = new System.Drawing.Size(200, 24);
            this.lblCreateOr.TabIndex = 19;
            this.lblCreateOr.Text = "Create an order";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox4.Location = new System.Drawing.Point(6, 161);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(638, 116);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.label5);
            this.pnlStock.Controls.Add(this.richTextBox2);
            this.pnlStock.Controls.Add(this.label1);
            this.pnlStock.Controls.Add(this.richTextBox8);
            this.pnlStock.Controls.Add(this.label3);
            this.pnlStock.Controls.Add(this.richTextBox10);
            this.pnlStock.Controls.Add(this.label4);
            this.pnlStock.Controls.Add(this.richTextBox11);
            this.pnlStock.Location = new System.Drawing.Point(15, 66);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(671, 528);
            this.pnlStock.TabIndex = 19;
            this.pnlStock.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(3, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Return to main menu";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(6, 488);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(638, 37);
            this.richTextBox2.TabIndex = 30;
            this.richTextBox2.Text = "Click the main menu buton on the order page\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "View Stock";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox8.Location = new System.Drawing.Point(6, 32);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(638, 99);
            this.richTextBox8.TabIndex = 26;
            this.richTextBox8.Text = resources.GetString("richTextBox8.Text");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(3, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Update Stock";
            // 
            // richTextBox10
            // 
            this.richTextBox10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox10.Location = new System.Drawing.Point(6, 305);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(638, 161);
            this.richTextBox10.TabIndex = 22;
            this.richTextBox10.Text = resources.GetString("richTextBox10.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Add stock";
            // 
            // richTextBox11
            // 
            this.richTextBox11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox11.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox11.Location = new System.Drawing.Point(6, 161);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(638, 116);
            this.richTextBox11.TabIndex = 20;
            this.richTextBox11.Text = resources.GetString("richTextBox11.Text");
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.label6);
            this.pnlSales.Controls.Add(this.richTextBox9);
            this.pnlSales.Controls.Add(this.label7);
            this.pnlSales.Controls.Add(this.richTextBox12);
            this.pnlSales.Controls.Add(this.label8);
            this.pnlSales.Controls.Add(this.richTextBox13);
            this.pnlSales.Controls.Add(this.label9);
            this.pnlSales.Controls.Add(this.richTextBox14);
            this.pnlSales.Location = new System.Drawing.Point(15, 96);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(671, 528);
            this.pnlSales.TabIndex = 31;
            this.pnlSales.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(3, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Return to main menu";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox9.Location = new System.Drawing.Point(6, 488);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(638, 37);
            this.richTextBox9.TabIndex = 30;
            this.richTextBox9.Text = "Click the main menu buton on the order page\n";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "View Sales";
            // 
            // richTextBox12
            // 
            this.richTextBox12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox12.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox12.Location = new System.Drawing.Point(6, 32);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(638, 99);
            this.richTextBox12.TabIndex = 26;
            this.richTextBox12.Text = resources.GetString("richTextBox12.Text");
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(3, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Update Sales";
            // 
            // richTextBox13
            // 
            this.richTextBox13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox13.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox13.Location = new System.Drawing.Point(6, 305);
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(638, 161);
            this.richTextBox13.TabIndex = 22;
            this.richTextBox13.Text = resources.GetString("richTextBox13.Text");
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(3, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Add Sales";
            // 
            // richTextBox14
            // 
            this.richTextBox14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox14.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox14.Location = new System.Drawing.Point(6, 161);
            this.richTextBox14.Name = "richTextBox14";
            this.richTextBox14.Size = new System.Drawing.Size(638, 116);
            this.richTextBox14.TabIndex = 20;
            this.richTextBox14.Text = resources.GetString("richTextBox14.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 786);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.pnlStock);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnBack);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.pnlOrders.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblCreateOr;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label lblUpdateOr;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label lblViewOr;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label lblDeleteOr;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox14;
    }
}