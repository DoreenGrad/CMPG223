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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableProductsCurrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageControlProducts = new System.Windows.Forms.TabControl();
            this.Receive_Orders = new System.Windows.Forms.TabPage();
            this.dataGridSearchAndDelete = new System.Windows.Forms.DataGridView();
            this.groupBoxProductInformation = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtBProductType = new System.Windows.Forms.TextBox();
            this.lblProductKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductsCurrentBindingSource)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.tabPageControlProducts.SuspendLayout();
            this.Receive_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAndDelete)).BeginInit();
            this.groupBoxProductInformation.SuspendLayout();
            this.SuspendLayout();
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
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.button1);
            this.tabSearch.Controls.Add(this.button4);
            this.tabSearch.Controls.Add(this.button3);
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
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 550);
            this.Controls.Add(this.tabPageControlProducts);
            this.Name = "Order_Form";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductsCurrentBindingSource)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabPageControlProducts.ResumeLayout(false);
            this.Receive_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchAndDelete)).EndInit();
            this.groupBoxProductInformation.ResumeLayout(false);
            this.groupBoxProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableProductsCurrentBindingSource;
        private System.Windows.Forms.Button btnSearchUpdate;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
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