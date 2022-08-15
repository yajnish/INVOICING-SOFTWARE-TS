namespace INVOICING_SOFTWARE
{
    partial class CNReport
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
            this.ExecuteGenReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toY = new System.Windows.Forms.ComboBox();
            this.toM = new System.Windows.Forms.ComboBox();
            this.toD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invoicelist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteGenReport
            // 
            this.ExecuteGenReport.BackColor = System.Drawing.Color.MediumPurple;
            this.ExecuteGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteGenReport.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGenReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExecuteGenReport.Location = new System.Drawing.Point(230, 122);
            this.ExecuteGenReport.Name = "ExecuteGenReport";
            this.ExecuteGenReport.Size = new System.Drawing.Size(327, 99);
            this.ExecuteGenReport.TabIndex = 44;
            this.ExecuteGenReport.Text = "Get a pdf report";
            this.ExecuteGenReport.UseVisualStyleBackColor = false;
            this.ExecuteGenReport.Click += new System.EventHandler(this.ExecuteGenReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(527, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "DD            MM              YYYY";
            // 
            // toY
            // 
            this.toY.FormattingEnabled = true;
            this.toY.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.toY.Location = new System.Drawing.Point(636, 46);
            this.toY.Name = "toY";
            this.toY.Size = new System.Drawing.Size(121, 24);
            this.toY.TabIndex = 42;
            this.toY.Text = "2021";
            // 
            // toM
            // 
            this.toM.FormattingEnabled = true;
            this.toM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.toM.Location = new System.Drawing.Point(582, 46);
            this.toM.Name = "toM";
            this.toM.Size = new System.Drawing.Size(48, 24);
            this.toM.TabIndex = 41;
            this.toM.Text = "01";
            // 
            // toD
            // 
            this.toD.FormattingEnabled = true;
            this.toD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.toD.Location = new System.Drawing.Point(529, 46);
            this.toD.Name = "toD";
            this.toD.Size = new System.Drawing.Size(47, 24);
            this.toD.TabIndex = 40;
            this.toD.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(471, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "TO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(121, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "DD            MM              YYYY";
            // 
            // fromY
            // 
            this.fromY.FormattingEnabled = true;
            this.fromY.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.fromY.Location = new System.Drawing.Point(230, 47);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(121, 24);
            this.fromY.TabIndex = 37;
            this.fromY.Text = "2021";
            // 
            // fromM
            // 
            this.fromM.FormattingEnabled = true;
            this.fromM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.fromM.Location = new System.Drawing.Point(176, 47);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(48, 24);
            this.fromM.TabIndex = 36;
            this.fromM.Text = "01";
            // 
            // fromD
            // 
            this.fromD.FormattingEnabled = true;
            this.fromD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.fromD.Location = new System.Drawing.Point(123, 47);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(47, 24);
            this.fromD.TabIndex = 35;
            this.fromD.Text = "01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "FROM: ";
            // 
            // invoicelist
            // 
            this.invoicelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicelist.Location = new System.Drawing.Point(875, 179);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.RowHeadersWidth = 56;
            this.invoicelist.RowTemplate.Height = 24;
            this.invoicelist.Size = new System.Drawing.Size(160, 107);
            this.invoicelist.TabIndex = 45;
            // 
            // CNReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.stencil_receipt__1_;
            this.ClientSize = new System.Drawing.Size(820, 275);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.ExecuteGenReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toY);
            this.Controls.Add(this.toM);
            this.Controls.Add(this.toD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.label3);
            this.Name = "CNReport";
            this.Text = "CNReport";
            this.Load += new System.EventHandler(this.CNReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteGenReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox toY;
        private System.Windows.Forms.ComboBox toM;
        private System.Windows.Forms.ComboBox toD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView invoicelist;
    }
}