namespace INVOICING_SOFTWARE
{
    partial class Statement
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
            this.invoicelist = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CompName = new System.Windows.Forms.TextBox();
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
            this.CompList = new System.Windows.Forms.DataGridView();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICEDataSet10 = new INVOICING_SOFTWARE.INVOICEDataSet10();
            this.clientsTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSet10TableAdapters.clientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicelist
            // 
            this.invoicelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicelist.Location = new System.Drawing.Point(764, 144);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.RowHeadersWidth = 56;
            this.invoicelist.RowTemplate.Height = 24;
            this.invoicelist.Size = new System.Drawing.Size(665, 150);
            this.invoicelist.TabIndex = 61;
            this.invoicelist.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(238, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 31);
            this.label4.TabIndex = 60;
            this.label4.Text = "Company Name:";
            // 
            // CompName
            // 
            this.CompName.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompName.Location = new System.Drawing.Point(441, 38);
            this.CompName.Name = "CompName";
            this.CompName.Size = new System.Drawing.Size(226, 34);
            this.CompName.TabIndex = 59;
            // 
            // ExecuteGenReport
            // 
            this.ExecuteGenReport.BackColor = System.Drawing.Color.MediumPurple;
            this.ExecuteGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteGenReport.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGenReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExecuteGenReport.Location = new System.Drawing.Point(307, 298);
            this.ExecuteGenReport.Name = "ExecuteGenReport";
            this.ExecuteGenReport.Size = new System.Drawing.Size(327, 99);
            this.ExecuteGenReport.TabIndex = 58;
            this.ExecuteGenReport.Text = "Get Statement of Account";
            this.ExecuteGenReport.UseVisualStyleBackColor = false;
            this.ExecuteGenReport.Click += new System.EventHandler(this.ExecuteGenReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(437, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 57;
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
            this.toY.Location = new System.Drawing.Point(546, 209);
            this.toY.Name = "toY";
            this.toY.Size = new System.Drawing.Size(121, 24);
            this.toY.TabIndex = 56;
            this.toY.Text = "2031";
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
            this.toM.Location = new System.Drawing.Point(492, 209);
            this.toM.Name = "toM";
            this.toM.Size = new System.Drawing.Size(48, 24);
            this.toM.TabIndex = 55;
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
            this.toD.Location = new System.Drawing.Point(439, 209);
            this.toD.Name = "toD";
            this.toD.Size = new System.Drawing.Size(47, 24);
            this.toD.TabIndex = 54;
            this.toD.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(381, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "TO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(438, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 52;
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
            this.fromY.Location = new System.Drawing.Point(547, 131);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(121, 24);
            this.fromY.TabIndex = 51;
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
            this.fromM.Location = new System.Drawing.Point(493, 131);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(48, 24);
            this.fromM.TabIndex = 50;
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
            this.fromD.Location = new System.Drawing.Point(440, 131);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(47, 24);
            this.fromD.TabIndex = 49;
            this.fromD.Text = "01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(343, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 48;
            this.label3.Text = "FROM: ";
            // 
            // CompList
            // 
            this.CompList.AutoGenerateColumns = false;
            this.CompList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companynameDataGridViewTextBoxColumn});
            this.CompList.DataSource = this.clientsBindingSource;
            this.CompList.Location = new System.Drawing.Point(21, 31);
            this.CompList.Name = "CompList";
            this.CompList.RowHeadersWidth = 56;
            this.CompList.RowTemplate.Height = 24;
            this.CompList.Size = new System.Drawing.Size(198, 391);
            this.CompList.TabIndex = 62;
            this.CompList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompList_CellContentClick);
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 135;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.iNVOICEDataSet10;
            // 
            // iNVOICEDataSet10
            // 
            this.iNVOICEDataSet10.DataSetName = "INVOICEDataSet10";
            this.iNVOICEDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.stencil_receipt__1_;
            this.ClientSize = new System.Drawing.Size(761, 475);
            this.Controls.Add(this.CompList);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CompName);
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
            this.Name = "Statement";
            this.Text = "Statement";
            this.Load += new System.EventHandler(this.Statement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicelist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompName;
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
        private System.Windows.Forms.DataGridView CompList;
        private INVOICEDataSet10 iNVOICEDataSet10;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private INVOICEDataSet10TableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
    }
}