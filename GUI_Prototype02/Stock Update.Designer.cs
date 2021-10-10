namespace GUI_Prototype02
{
    partial class Stock_Update
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbQty_on_Hand = new System.Windows.Forms.TextBox();
            this.tbWeight_per_Unit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStock_Desc = new System.Windows.Forms.TextBox();
            this.tbStock_Key = new System.Windows.Forms.TextBox();
            this.stockKeyLb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbView1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnU = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbQty_on_Hand);
            this.groupBox5.Controls.Add(this.tbWeight_per_Unit);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbStock_Desc);
            this.groupBox5.Controls.Add(this.tbStock_Key);
            this.groupBox5.Controls.Add(this.stockKeyLb);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Purple;
            this.groupBox5.Location = new System.Drawing.Point(12, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 196);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stock";
            // 
            // tbQty_on_Hand
            // 
            this.tbQty_on_Hand.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbQty_on_Hand.Location = new System.Drawing.Point(212, 152);
            this.tbQty_on_Hand.Name = "tbQty_on_Hand";
            this.tbQty_on_Hand.Size = new System.Drawing.Size(182, 25);
            this.tbQty_on_Hand.TabIndex = 10;
            // 
            // tbWeight_per_Unit
            // 
            this.tbWeight_per_Unit.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbWeight_per_Unit.Location = new System.Drawing.Point(212, 121);
            this.tbWeight_per_Unit.Name = "tbWeight_per_Unit";
            this.tbWeight_per_Unit.Size = new System.Drawing.Size(182, 25);
            this.tbWeight_per_Unit.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity on hand:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weight per unit (kg):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStock_Desc
            // 
            this.tbStock_Desc.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbStock_Desc.Location = new System.Drawing.Point(212, 86);
            this.tbStock_Desc.Name = "tbStock_Desc";
            this.tbStock_Desc.Size = new System.Drawing.Size(182, 25);
            this.tbStock_Desc.TabIndex = 5;
            // 
            // tbStock_Key
            // 
            this.tbStock_Key.Font = new System.Drawing.Font("Verdana", 11F);
            this.tbStock_Key.Location = new System.Drawing.Point(212, 46);
            this.tbStock_Key.Name = "tbStock_Key";
            this.tbStock_Key.Size = new System.Drawing.Size(182, 25);
            this.tbStock_Key.TabIndex = 4;
            // 
            // stockKeyLb
            // 
            this.stockKeyLb.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.stockKeyLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stockKeyLb.Location = new System.Drawing.Point(6, 41);
            this.stockKeyLb.Name = "stockKeyLb";
            this.stockKeyLb.Size = new System.Drawing.Size(200, 35);
            this.stockKeyLb.TabIndex = 1;
            this.stockKeyLb.Text = "Stock Key:";
            this.stockKeyLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(6, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 35);
            this.label14.TabIndex = 2;
            this.label14.Text = "Stock Description:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbView1
            // 
            this.lbView1.FormattingEnabled = true;
            this.lbView1.Location = new System.Drawing.Point(12, 26);
            this.lbView1.Name = "lbView1";
            this.lbView1.Size = new System.Drawing.Size(649, 43);
            this.lbView1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(484, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Qty_On_Hand";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(347, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Weight_per_Unit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(192, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Stock_Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(100, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Stock_Key";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(9, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Stock_ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.btnU.Location = new System.Drawing.Point(135, 295);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(200, 50);
            this.btnU.TabIndex = 50;
            this.btnU.Text = "UPDATE";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
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
            this.btnC.Location = new System.Drawing.Point(341, 295);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(200, 50);
            this.btnC.TabIndex = 51;
            this.btnC.Text = "CANCEL";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Stock_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 346);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbView1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Stock_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stock";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Stock_Update_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stockKeyLb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnC;
        public System.Windows.Forms.TextBox tbQty_on_Hand;
        public System.Windows.Forms.TextBox tbWeight_per_Unit;
        public System.Windows.Forms.TextBox tbStock_Desc;
        public System.Windows.Forms.TextBox tbStock_Key;
    }
}