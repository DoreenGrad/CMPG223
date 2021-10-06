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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.tabPageControlProducts = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbSale_Detail = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgDel = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbOrdered = new System.Windows.Forms.RadioButton();
            this.dtgSearchInUpdate = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbSale_Detail = new System.Windows.Forms.ComboBox();
            this.cmbStockID = new System.Windows.Forms.ComboBox();
            this.cmbSaleID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageControlProducts.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDel)).BeginInit();
            this.tabPageView.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchInUpdate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 200);
            this.groupBox5.TabIndex = 23;
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
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(624, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = true;
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
            this.button4.Location = new System.Drawing.Point(418, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 21;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
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
            this.button3.Location = new System.Drawing.Point(418, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "INSERT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Purple;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1340, 415);
            this.dataGridView1.TabIndex = 19;
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
            this.btnSearchUpdate.Location = new System.Drawing.Point(624, 74);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnSearchUpdate.TabIndex = 18;
            this.btnSearchUpdate.Text = "DELETE";
            this.btnSearchUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPageControlProducts
            // 
            this.tabPageControlProducts.Controls.Add(this.tabSearch);
            this.tabPageControlProducts.Controls.Add(this.tabPageView);
            this.tabPageControlProducts.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageControlProducts.Location = new System.Drawing.Point(12, 12);
            this.tabPageControlProducts.Name = "tabPageControlProducts";
            this.tabPageControlProducts.SelectedIndex = 0;
            this.tabPageControlProducts.Size = new System.Drawing.Size(1360, 762);
            this.tabPageControlProducts.TabIndex = 24;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupBox4);
            this.tabSearch.Controls.Add(this.groupBox1);
            this.tabSearch.Controls.Add(this.dtgDel);
            this.tabSearch.Controls.Add(this.btnDel);
            this.tabSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(4, 27);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1352, 731);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Delete";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.txtPrice);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Purple;
            this.groupBox4.Location = new System.Drawing.Point(424, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 162);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unit Information";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(212, 87);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 25);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPrice.Location = new System.Drawing.Point(212, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 25);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price per Unit:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 35);
            this.label11.TabIndex = 2;
            this.label11.Text = "Quantity Ordered:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStockID);
            this.groupBox1.Controls.Add(this.txtSaleID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtbSale_Detail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Information";
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtStockID.Location = new System.Drawing.Point(212, 117);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(182, 25);
            this.txtStockID.TabIndex = 5;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSaleID.Location = new System.Drawing.Point(212, 82);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(182, 25);
            this.txtSaleID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Detail ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbSale_Detail
            // 
            this.mtbSale_Detail.Font = new System.Drawing.Font("Verdana", 11F);
            this.mtbSale_Detail.Location = new System.Drawing.Point(212, 47);
            this.mtbSale_Detail.Mask = ">LLLL0000";
            this.mtbSale_Detail.Name = "mtbSale_Detail";
            this.mtbSale_Detail.Size = new System.Drawing.Size(100, 25);
            this.mtbSale_Detail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgDel
            // 
            this.dtgDel.AllowUserToAddRows = false;
            this.dtgDel.AllowUserToDeleteRows = false;
            this.dtgDel.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgDel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDel.GridColor = System.Drawing.Color.Purple;
            this.dtgDel.Location = new System.Drawing.Point(6, 197);
            this.dtgDel.Name = "dtgDel";
            this.dtgDel.ReadOnly = true;
            this.dtgDel.Size = new System.Drawing.Size(1341, 519);
            this.dtgDel.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnDel.FlatAppearance.BorderSize = 2;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Purple;
            this.btnDel.Location = new System.Drawing.Point(1142, 141);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(194, 50);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.btnInsert);
            this.tabPageView.Controls.Add(this.groupBox3);
            this.tabPageView.Controls.Add(this.dtgSearchInUpdate);
            this.tabPageView.Controls.Add(this.groupBox2);
            this.tabPageView.Controls.Add(this.groupBox6);
            this.tabPageView.Controls.Add(this.btnUpdate);
            this.tabPageView.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageView.Location = new System.Drawing.Point(4, 27);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1352, 731);
            this.tabPageView.TabIndex = 3;
            this.tabPageView.Text = "Search, Insert and Update";
            this.tabPageView.UseVisualStyleBackColor = true;
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
            this.btnInsert.Location = new System.Drawing.Point(940, 675);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 50);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDelivered);
            this.groupBox3.Controls.Add(this.rbPaid);
            this.groupBox3.Controls.Add(this.rbOrdered);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(844, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 200);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procurement Information";
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.Font = new System.Drawing.Font("Verdana", 11F);
            this.rbDelivered.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDelivered.Location = new System.Drawing.Point(158, 48);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(94, 22);
            this.rbDelivered.TabIndex = 12;
            this.rbDelivered.Text = "Delivered";
            this.rbDelivered.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Enabled = false;
            this.rbPaid.Font = new System.Drawing.Font("Verdana", 11F);
            this.rbPaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPaid.Location = new System.Drawing.Point(158, 76);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(56, 22);
            this.rbPaid.TabIndex = 11;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // rbOrdered
            // 
            this.rbOrdered.AutoSize = true;
            this.rbOrdered.Checked = true;
            this.rbOrdered.Font = new System.Drawing.Font("Verdana", 11F);
            this.rbOrdered.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbOrdered.Location = new System.Drawing.Point(6, 48);
            this.rbOrdered.Name = "rbOrdered";
            this.rbOrdered.Size = new System.Drawing.Size(86, 22);
            this.rbOrdered.TabIndex = 10;
            this.rbOrdered.TabStop = true;
            this.rbOrdered.Text = "Ordered";
            this.rbOrdered.UseVisualStyleBackColor = true;
            // 
            // dtgSearchInUpdate
            // 
            this.dtgSearchInUpdate.AllowUserToAddRows = false;
            this.dtgSearchInUpdate.AllowUserToDeleteRows = false;
            this.dtgSearchInUpdate.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgSearchInUpdate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgSearchInUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearchInUpdate.GridColor = System.Drawing.Color.Purple;
            this.dtgSearchInUpdate.Location = new System.Drawing.Point(6, 235);
            this.dtgSearchInUpdate.Name = "dtgSearchInUpdate";
            this.dtgSearchInUpdate.ReadOnly = true;
            this.dtgSearchInUpdate.Size = new System.Drawing.Size(1340, 434);
            this.dtgSearchInUpdate.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbQuantity);
            this.groupBox2.Controls.Add(this.cmbPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(424, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit Information";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuantity.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "32,5",
            "65",
            "27,5",
            "30",
            "37,5",
            "75"});
            this.cmbQuantity.Location = new System.Drawing.Point(212, 86);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(182, 26);
            this.cmbQuantity.TabIndex = 14;
            // 
            // cmbPrice
            // 
            this.cmbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPrice.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Items.AddRange(new object[] {
            "0,5",
            "1",
            "0,5",
            "0,5",
            "0,5",
            "1"});
            this.cmbPrice.Location = new System.Drawing.Point(212, 47);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(182, 26);
            this.cmbPrice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price per Unit:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity Ordered:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbSale_Detail);
            this.groupBox6.Controls.Add(this.cmbStockID);
            this.groupBox6.Controls.Add(this.cmbSaleID);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.Purple;
            this.groupBox6.Location = new System.Drawing.Point(6, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(400, 200);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sale Information";
            // 
            // cmbSale_Detail
            // 
            this.cmbSale_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSale_Detail.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbSale_Detail.FormattingEnabled = true;
            this.cmbSale_Detail.Items.AddRange(new object[] {
            "MNCE0011",
            "MNCE0012",
            "MNCE0021",
            "WORS0011",
            "WORS0021",
            "WORS0022"});
            this.cmbSale_Detail.Location = new System.Drawing.Point(212, 47);
            this.cmbSale_Detail.Name = "cmbSale_Detail";
            this.cmbSale_Detail.Size = new System.Drawing.Size(182, 26);
            this.cmbSale_Detail.TabIndex = 11;
            // 
            // cmbStockID
            // 
            this.cmbStockID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStockID.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbStockID.FormattingEnabled = true;
            this.cmbStockID.Items.AddRange(new object[] {
            "Curry Mince",
            "Curry Mince",
            "Beef Mince",
            "Boerewors",
            "Kaaswors",
            "Kaaswors"});
            this.cmbStockID.Location = new System.Drawing.Point(212, 117);
            this.cmbStockID.Name = "cmbStockID";
            this.cmbStockID.Size = new System.Drawing.Size(182, 26);
            this.cmbStockID.TabIndex = 10;
            // 
            // cmbSaleID
            // 
            this.cmbSaleID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSaleID.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbSaleID.FormattingEnabled = true;
            this.cmbSaleID.Items.AddRange(new object[] {
            "Mince",
            "Mince",
            "Mince",
            "Wors",
            "Wors",
            "Wors"});
            this.cmbSaleID.Location = new System.Drawing.Point(212, 82);
            this.cmbSaleID.Name = "cmbSaleID";
            this.cmbSaleID.Size = new System.Drawing.Size(182, 26);
            this.cmbSaleID.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sale Detail ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sale ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 35);
            this.label15.TabIndex = 2;
            this.label15.Text = "Stock ID:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdate.Location = new System.Drawing.Point(1146, 675);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Sale_Products_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 783);
            this.Controls.Add(this.tabPageControlProducts);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchUpdate);
            this.Name = "Sale_Products_Form";
            this.Text = "Sell Products";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageControlProducts.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDel)).EndInit();
            this.tabPageView.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchInUpdate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchUpdate;
        private System.Windows.Forms.TabControl tabPageControlProducts;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbSale_Detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgDel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDelivered;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbOrdered;
        private System.Windows.Forms.DataGridView dtgSearchInUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbSale_Detail;
        private System.Windows.Forms.ComboBox cmbStockID;
        private System.Windows.Forms.ComboBox cmbSaleID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdate;
    }
}