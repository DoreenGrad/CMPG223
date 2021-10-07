
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
            this.rtbOrder = new System.Windows.Forms.RichTextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.rtxErrors = new System.Windows.Forms.RichTextBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblViewOr = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.lblDeleteOr = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.lblUpdateOr = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.lblCreateOr = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.pnlOrders.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(1172, 12);
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
            // rtbOrder
            // 
            this.rtbOrder.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOrder.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.rtbOrder.Location = new System.Drawing.Point(15, 33);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.Size = new System.Drawing.Size(670, 130);
            this.rtbOrder.TabIndex = 6;
            this.rtbOrder.Text = resources.GetString("rtbOrder.Text");
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Blue;
            this.lblStock.Location = new System.Drawing.Point(12, 156);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(203, 22);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock button";
            this.lblStock.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(15, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(670, 99);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblSales
            // 
            this.lblSales.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.Blue;
            this.lblSales.Location = new System.Drawing.Point(12, 268);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(203, 22);
            this.lblSales.TabIndex = 10;
            this.lblSales.Text = "Sale button";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(15, 293);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(670, 99);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // lblReport
            // 
            this.lblReport.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.Blue;
            this.lblReport.Location = new System.Drawing.Point(12, 382);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(203, 22);
            this.lblReport.TabIndex = 12;
            this.lblReport.Text = "Report button";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox3.Location = new System.Drawing.Point(15, 407);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(670, 68);
            this.richTextBox3.TabIndex = 13;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // rtxErrors
            // 
            this.rtxErrors.BackColor = System.Drawing.SystemColors.Menu;
            this.rtxErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxErrors.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.rtxErrors.Location = new System.Drawing.Point(802, 101);
            this.rtxErrors.Name = "rtxErrors";
            this.rtxErrors.Size = new System.Drawing.Size(570, 374);
            this.rtxErrors.TabIndex = 15;
            this.rtxErrors.Text = resources.GetString("rtxErrors.Text");
            this.rtxErrors.Visible = false;
            // 
            // lblErrors
            // 
            this.lblErrors.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblErrors.Location = new System.Drawing.Point(799, 76);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(203, 22);
            this.lblErrors.TabIndex = 17;
            this.lblErrors.Text = "Show common errors";
            this.lblErrors.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlOrders
            // 
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
            this.pnlOrders.Size = new System.Drawing.Size(671, 614);
            this.pnlOrders.TabIndex = 18;
            this.pnlOrders.Visible = false;
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
            this.richTextBox7.BackColor = System.Drawing.SystemColors.Menu;
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
            this.richTextBox6.BackColor = System.Drawing.SystemColors.Menu;
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
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Menu;
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
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox4.Location = new System.Drawing.Point(6, 161);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(638, 116);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 786);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.rtxErrors);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.rtbOrder);
            this.Controls.Add(this.btnBack);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.pnlOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.RichTextBox rtbOrder;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox rtxErrors;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblCreateOr;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label lblUpdateOr;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label lblViewOr;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label lblDeleteOr;
        private System.Windows.Forms.RichTextBox richTextBox6;
    }
}