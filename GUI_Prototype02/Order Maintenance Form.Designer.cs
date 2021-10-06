namespace GUI_Prototype02
{
    partial class Order_Maintenance_Form
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
            this.tableProductsCurrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbOrdered = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbOrderDetail = new System.Windows.Forms.ComboBox();
            this.cmbStockID = new System.Windows.Forms.ComboBox();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbOrder_Detail = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.tabPageControlProducts = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductsCurrentBindingSource)).BeginInit();
            this.tabPageView.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageControlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.btnInsert);
            this.tabPageView.Controls.Add(this.groupBox3);
            this.tabPageView.Controls.Add(this.dataGridView2);
            this.tabPageView.Controls.Add(this.groupBox1);
            this.tabPageView.Controls.Add(this.groupBox2);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.tableProductsCurrentBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.Purple;
            this.dataGridView2.Location = new System.Drawing.Point(6, 235);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1340, 434);
            this.dataGridView2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbQuantity);
            this.groupBox1.Controls.Add(this.cmbPrice);
            this.groupBox1.Controls.Add(this.cmbWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(424, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Information";
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
            this.cmbQuantity.Location = new System.Drawing.Point(212, 117);
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
            "65",
            "65",
            "55",
            "60",
            "75",
            "75"});
            this.cmbPrice.Location = new System.Drawing.Point(212, 82);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(182, 26);
            this.cmbPrice.TabIndex = 13;
            // 
            // cmbWeight
            // 
            this.cmbWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWeight.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Items.AddRange(new object[] {
            "0,5",
            "1",
            "0,5",
            "0,5",
            "0,5",
            "1"});
            this.cmbWeight.Location = new System.Drawing.Point(212, 47);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(182, 26);
            this.cmbWeight.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Weight per Unit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price per kg:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity Ordered:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbOrderDetail);
            this.groupBox2.Controls.Add(this.cmbStockID);
            this.groupBox2.Controls.Add(this.cmbOrderID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(6, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Information";
            // 
            // cmbOrderDetail
            // 
            this.cmbOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderDetail.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbOrderDetail.FormattingEnabled = true;
            this.cmbOrderDetail.Items.AddRange(new object[] {
            "MNCE0011",
            "MNCE0012",
            "MNCE0021",
            "WORS0011",
            "WORS0021",
            "WORS0022"});
            this.cmbOrderDetail.Location = new System.Drawing.Point(212, 47);
            this.cmbOrderDetail.Name = "cmbOrderDetail";
            this.cmbOrderDetail.Size = new System.Drawing.Size(182, 26);
            this.cmbOrderDetail.TabIndex = 11;
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
            // cmbOrderID
            // 
            this.cmbOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderID.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Items.AddRange(new object[] {
            "Mince",
            "Mince",
            "Mince",
            "Wors",
            "Wors",
            "Wors"});
            this.cmbOrderID.Location = new System.Drawing.Point(212, 82);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(182, 26);
            this.cmbOrderID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order Detail ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Order ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 35);
            this.label7.TabIndex = 2;
            this.label7.Text = "Stock ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupBox4);
            this.tabSearch.Controls.Add(this.groupBox5);
            this.tabSearch.Controls.Add(this.dataGridView1);
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
            this.groupBox4.Controls.Add(this.txtWeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
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
            this.txtQuantity.Location = new System.Drawing.Point(212, 117);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 25);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPrice.Location = new System.Drawing.Point(212, 82);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 25);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtWeight.Location = new System.Drawing.Point(212, 47);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 25);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.Text = "0";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Weight per Unit:";
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
            this.label10.Text = "Price per kg:";
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
            this.label11.Text = "Quantity Ordered:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStockID);
            this.groupBox5.Controls.Add(this.txtOrderID);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.mtbOrder_Detail);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Purple;
            this.groupBox5.Location = new System.Drawing.Point(6, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 162);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Information";
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtStockID.Location = new System.Drawing.Point(212, 117);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(182, 25);
            this.txtStockID.TabIndex = 5;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtOrderID.Location = new System.Drawing.Point(212, 82);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(182, 25);
            this.txtOrderID.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 35);
            this.label12.TabIndex = 0;
            this.label12.Text = "Order Detail ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbOrder_Detail
            // 
            this.mtbOrder_Detail.Font = new System.Drawing.Font("Verdana", 11F);
            this.mtbOrder_Detail.Location = new System.Drawing.Point(212, 47);
            this.mtbOrder_Detail.Mask = ">LLLL0000";
            this.mtbOrder_Detail.Name = "mtbOrder_Detail";
            this.mtbOrder_Detail.Size = new System.Drawing.Size(100, 25);
            this.mtbOrder_Detail.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 35);
            this.label13.TabIndex = 1;
            this.label13.Text = "Order ID:";
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
            this.label14.Text = "Stock ID:";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 219);
            this.dataGridView1.TabIndex = 8;
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
            this.btnDel.Location = new System.Drawing.Point(830, 141);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(194, 50);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
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
            this.tabPageControlProducts.TabIndex = 1;
            // 
            // Order_Maintenance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 791);
            this.Controls.Add(this.tabPageControlProducts);
            this.Name = "Order_Maintenance_Form";
            this.Text = "Order Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.tableProductsCurrentBindingSource)).EndInit();
            this.tabPageView.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageControlProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tableProductsCurrentBindingSource;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDelivered;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbOrdered;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOrderDetail;
        private System.Windows.Forms.ComboBox cmbStockID;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbOrder_Detail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TabControl tabPageControlProducts;
        private System.Windows.Forms.Button btnInsert;
    }
}