namespace GUI_Prototype02
{
    partial class Order_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableProductsCurrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPageControlProducts = new System.Windows.Forms.TabControl();
            this.Receive_Orders = new System.Windows.Forms.TabPage();
            this.dataGridSearchAndDelete = new System.Windows.Forms.DataGridView();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.txtBProductType = new System.Windows.Forms.TextBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductsCurrentBindingSource)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageControlProducts.SuspendLayout();
            this.Receive_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAndDelete)).BeginInit();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.maskedTextBox1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Purple;
            this.groupBox5.Location = new System.Drawing.Point(6, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 200);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search: Product Information";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox5.Location = new System.Drawing.Point(212, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 25);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox6.Location = new System.Drawing.Point(212, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 25);
            this.textBox6.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 35);
            this.label12.TabIndex = 0;
            this.label12.Text = "Product Key:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Verdana", 11F);
            this.maskedTextBox1.Location = new System.Drawing.Point(212, 47);
            this.maskedTextBox1.Mask = ">LLLL0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 25);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 35);
            this.label13.TabIndex = 1;
            this.label13.Text = "Product Type:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(6, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 35);
            this.label14.TabIndex = 2;
            this.label14.Text = "Product Description:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.tableProductsCurrentBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Purple;
            this.dataGridView1.Location = new System.Drawing.Point(6, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1340, 490);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnSearchUpdate.FlatAppearance.BorderSize = 2;
            this.btnSearchUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnSearchUpdate.Location = new System.Drawing.Point(830, 179);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnSearchUpdate.TabIndex = 6;
            this.btnSearchUpdate.Text = "DELETE";
            this.btnSearchUpdate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox1.Location = new System.Drawing.Point(212, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stock:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox2.Location = new System.Drawing.Point(212, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox3.Location = new System.Drawing.Point(212, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 11F);
            this.textBox4.Location = new System.Drawing.Point(212, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Weight per Unit (kg):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 35);
            this.label10.TabIndex = 1;
            this.label10.Text = "Price (per kg):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 35);
            this.label11.TabIndex = 2;
            this.label11.Text = "Price per Unit:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.button1);
            this.tabSearch.Controls.Add(this.button4);
            this.tabSearch.Controls.Add(this.button3);
            this.tabSearch.Controls.Add(this.groupBox4);
            this.tabSearch.Controls.Add(this.groupBox5);
            this.tabSearch.Controls.Add(this.dataGridView1);
            this.tabSearch.Controls.Add(this.btnSearchUpdate);
            this.tabSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(4, 27);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1352, 731);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Maintain Order";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Purple;
            this.groupBox4.Location = new System.Drawing.Point(424, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 200);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search: Unit Information";
            // 
            // tabPageControlProducts
            // 
            this.tabPageControlProducts.Controls.Add(this.tabSearch);
            this.tabPageControlProducts.Controls.Add(this.Receive_Orders);
            this.tabPageControlProducts.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageControlProducts.Location = new System.Drawing.Point(12, 12);
            this.tabPageControlProducts.Name = "tabPageControlProducts";
            this.tabPageControlProducts.SelectedIndex = 0;
            this.tabPageControlProducts.Size = new System.Drawing.Size(1360, 762);
            this.tabPageControlProducts.TabIndex = 2;
            // 
            // Receive_Orders
            // 
            this.Receive_Orders.Controls.Add(this.dataGridSearchAndDelete);
            this.Receive_Orders.Controls.Add(this.groupBoxProductInformation);
            this.Receive_Orders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receive_Orders.Location = new System.Drawing.Point(4, 27);
            this.Receive_Orders.Name = "Receive_Orders";
            this.Receive_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Receive_Orders.Size = new System.Drawing.Size(1352, 731);
            this.Receive_Orders.TabIndex = 1;
            this.Receive_Orders.Text = "Receive Orders";
            this.Receive_Orders.UseVisualStyleBackColor = true;
            // 
            // dataGridSearchAndDelete
            // 
            this.dataGridSearchAndDelete.AllowUserToAddRows = false;
            this.dataGridSearchAndDelete.AllowUserToDeleteRows = false;
            this.dataGridSearchAndDelete.AutoGenerateColumns = false;
            this.dataGridSearchAndDelete.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridSearchAndDelete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSearchAndDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchAndDelete.DataSource = this.tableProductsCurrentBindingSource;
            this.dataGridSearchAndDelete.GridColor = System.Drawing.Color.Purple;
            this.dataGridSearchAndDelete.Location = new System.Drawing.Point(6, 235);
            this.dataGridSearchAndDelete.Name = "dataGridSearchAndDelete";
            this.dataGridSearchAndDelete.ReadOnly = true;
            this.dataGridSearchAndDelete.Size = new System.Drawing.Size(1340, 434);
            this.dataGridSearchAndDelete.TabIndex = 6;
            // 
            // groupBoxProductInformation
            // 
            this.groupBoxProductInformation.Controls.Add(this.label22);
            this.groupBoxProductInformation.Controls.Add(this.maskedTextBox2);
            this.groupBoxProductInformation.Controls.Add(this.btnInsert);
            this.groupBoxProductInformation.Controls.Add(this.txtBProductType);
            this.groupBoxProductInformation.Controls.Add(this.lblProductKey);
            this.groupBoxProductInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductInformation.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxProductInformation.Location = new System.Drawing.Point(6, 29);
            this.groupBoxProductInformation.Name = "groupBoxProductInformation";
            this.groupBoxProductInformation.Size = new System.Drawing.Size(400, 200);
            this.groupBoxProductInformation.TabIndex = 0;
            this.groupBoxProductInformation.TabStop = false;
            this.groupBoxProductInformation.Text = "Insert Date";
            // 
            // txtBProductType
            // 
            this.txtBProductType.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBProductType.Location = new System.Drawing.Point(215, 69);
            this.txtBProductType.Name = "txtBProductType";
            this.txtBProductType.Size = new System.Drawing.Size(182, 25);
            this.txtBProductType.TabIndex = 4;
            // 
            // lblProductKey
            // 
            this.lblProductKey.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductKey.Location = new System.Drawing.Point(9, 59);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(200, 35);
            this.lblProductKey.TabIndex = 0;
            this.lblProductKey.Text = "Date:";
            this.lblProductKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnInsert.Location = new System.Drawing.Point(9, 116);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
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
            this.button3.Location = new System.Drawing.Point(830, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "INSERT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(1036, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(9, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(200, 35);
            this.label22.TabIndex = 6;
            this.label22.Text = "Order ID:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Verdana", 11F);
            this.maskedTextBox2.Location = new System.Drawing.Point(215, 38);
            this.maskedTextBox2.Mask = ">LLLL0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 25);
            this.maskedTextBox2.TabIndex = 7;
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
            this.button1.Location = new System.Drawing.Point(1036, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 786);
            this.Controls.Add(this.tabPageControlProducts);
            this.Name = "Order_Form";
            this.Text = "Order";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductsCurrentBindingSource)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageControlProducts.ResumeLayout(false);
            this.Receive_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAndDelete)).EndInit();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableProductsCurrentBindingSource;
        private System.Windows.Forms.Button btnSearchUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabPageControlProducts;
        private System.Windows.Forms.TabPage Receive_Orders;
        private System.Windows.Forms.DataGridView dataGridSearchAndDelete;
        private System.Windows.Forms.GroupBox groupBoxProductInformation;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBProductType;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.Button button1;
    }
}