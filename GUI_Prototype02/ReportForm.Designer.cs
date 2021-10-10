
namespace GUI_Prototype02
{
    partial class ReportForm
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTP_Start = new System.Windows.Forms.DateTimePicker();
            this.dTP_End = new System.Windows.Forms.DateTimePicker();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Purple;
            this.btnPrint.Location = new System.Drawing.Point(858, 450);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 50);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 324);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Start Date of Report: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select End Date of Report: ";
            // 
            // dTP_Start
            // 
            this.dTP_Start.Location = new System.Drawing.Point(217, 39);
            this.dTP_Start.Name = "dTP_Start";
            this.dTP_Start.Size = new System.Drawing.Size(200, 20);
            this.dTP_Start.TabIndex = 9;
            // 
            // dTP_End
            // 
            this.dTP_End.Location = new System.Drawing.Point(217, 65);
            this.dTP_End.Name = "dTP_End";
            this.dTP_End.Size = new System.Drawing.Size(200, 20);
            this.dTP_End.TabIndex = 10;
            // 
            // btnMM
            // 
            this.btnMM.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnMM.FlatAppearance.BorderSize = 2;
            this.btnMM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.ForeColor = System.Drawing.Color.Purple;
            this.btnMM.Location = new System.Drawing.Point(858, 12);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(200, 50);
            this.btnMM.TabIndex = 46;
            this.btnMM.Text = "Main Menu";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(217, 91);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(108, 23);
            this.btnReport.TabIndex = 47;
            this.btnReport.Text = "Request report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Sale details",
            "Order details"});
            this.cbxType.Location = new System.Drawing.Point(217, 12);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 48;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(54, 20);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(65, 13);
            this.lblReport.TabIndex = 49;
            this.lblReport.Text = "Report type:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 504);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.dTP_End);
            this.Controls.Add(this.dTP_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP_Start;
        private System.Windows.Forms.DateTimePicker dTP_End;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblReport;
    }
}