namespace INVOICING_SOFTWARE
{
    partial class GenReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenReport));
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toY = new System.Windows.Forms.ComboBox();
            this.toM = new System.Windows.Forms.ComboBox();
            this.toD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoicelist = new System.Windows.Forms.DataGridView();
            this.receiptlist = new System.Windows.Forms.DataGridView();
            this.ExecuteGenReport = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(118, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "DD            MM              YYYY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.fromY.Location = new System.Drawing.Point(227, 38);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(121, 24);
            this.fromY.TabIndex = 24;
            this.fromY.Text = "2021";
            this.fromY.SelectedIndexChanged += new System.EventHandler(this.fromY_SelectedIndexChanged);
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
            this.fromM.Location = new System.Drawing.Point(173, 38);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(48, 24);
            this.fromM.TabIndex = 23;
            this.fromM.Text = "01";
            this.fromM.SelectedIndexChanged += new System.EventHandler(this.fromM_SelectedIndexChanged);
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
            this.fromD.Location = new System.Drawing.Point(120, 38);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(47, 24);
            this.fromD.TabIndex = 22;
            this.fromD.Text = "01";
            this.fromD.SelectedIndexChanged += new System.EventHandler(this.fromD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "FROM: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(524, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "DD            MM              YYYY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.toY.Location = new System.Drawing.Point(633, 37);
            this.toY.Name = "toY";
            this.toY.Size = new System.Drawing.Size(121, 24);
            this.toY.TabIndex = 29;
            this.toY.Text = "2021";
            this.toY.SelectedIndexChanged += new System.EventHandler(this.toY_SelectedIndexChanged);
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
            this.toM.Location = new System.Drawing.Point(579, 37);
            this.toM.Name = "toM";
            this.toM.Size = new System.Drawing.Size(48, 24);
            this.toM.TabIndex = 28;
            this.toM.Text = "01";
            this.toM.SelectedIndexChanged += new System.EventHandler(this.toM_SelectedIndexChanged);
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
            this.toD.Location = new System.Drawing.Point(526, 37);
            this.toD.Name = "toD";
            this.toD.Size = new System.Drawing.Size(47, 24);
            this.toD.TabIndex = 27;
            this.toD.Text = "01";
            this.toD.SelectedIndexChanged += new System.EventHandler(this.toD_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(468, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "TO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // invoicelist
            // 
            this.invoicelist.AllowUserToAddRows = false;
            this.invoicelist.AllowUserToDeleteRows = false;
            this.invoicelist.AllowUserToResizeColumns = false;
            this.invoicelist.AllowUserToResizeRows = false;
            this.invoicelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicelist.Location = new System.Drawing.Point(29, 335);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.RowHeadersWidth = 56;
            this.invoicelist.RowTemplate.Height = 24;
            this.invoicelist.Size = new System.Drawing.Size(725, 192);
            this.invoicelist.TabIndex = 31;
            // 
            // receiptlist
            // 
            this.receiptlist.AllowUserToAddRows = false;
            this.receiptlist.AllowUserToDeleteRows = false;
            this.receiptlist.AllowUserToResizeColumns = false;
            this.receiptlist.AllowUserToResizeRows = false;
            this.receiptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptlist.Location = new System.Drawing.Point(30, 405);
            this.receiptlist.Name = "receiptlist";
            this.receiptlist.RowHeadersWidth = 56;
            this.receiptlist.RowTemplate.Height = 24;
            this.receiptlist.Size = new System.Drawing.Size(724, 196);
            this.receiptlist.TabIndex = 32;
            // 
            // ExecuteGenReport
            // 
            this.ExecuteGenReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExecuteGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteGenReport.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGenReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExecuteGenReport.Location = new System.Drawing.Point(262, 114);
            this.ExecuteGenReport.Name = "ExecuteGenReport";
            this.ExecuteGenReport.Size = new System.Drawing.Size(327, 99);
            this.ExecuteGenReport.TabIndex = 33;
            this.ExecuteGenReport.Text = "Get Sales Report";
            this.ExecuteGenReport.UseVisualStyleBackColor = false;
            this.ExecuteGenReport.Click += new System.EventHandler(this.ExecuteGenReport_Click);
            // 
            // inventory
            // 
            this.inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory.Location = new System.Drawing.Point(661, 136);
            this.inventory.Name = "inventory";
            this.inventory.RowHeadersWidth = 56;
            this.inventory.RowTemplate.Height = 24;
            this.inventory.Size = new System.Drawing.Size(27, 41);
            this.inventory.TabIndex = 34;
            this.inventory.Visible = false;
            // 
            // GenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.stencil_rem_prod;
            this.ClientSize = new System.Drawing.Size(779, 251);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.ExecuteGenReport);
            this.Controls.Add(this.receiptlist);
            this.Controls.Add(this.invoicelist);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.GenReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox toY;
        private System.Windows.Forms.ComboBox toM;
        private System.Windows.Forms.ComboBox toD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView invoicelist;
        private System.Windows.Forms.DataGridView receiptlist;
        private System.Windows.Forms.Button ExecuteGenReport;
        private System.Windows.Forms.DataGridView inventory;
    }
}