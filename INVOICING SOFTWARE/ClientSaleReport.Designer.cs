namespace INVOICING_SOFTWARE
{
    partial class ClientSaleReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICEDataSet9 = new INVOICING_SOFTWARE.INVOICEDataSet9();
            this.clientsTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSet9TableAdapters.clientsTableAdapter();
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
            this.inventory = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.skusearch = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.invBrand = new System.Windows.Forms.TextBox();
            this.invSku = new System.Windows.Forms.TextBox();
            this.invProdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iNVOICEDataSet16 = new INVOICING_SOFTWARE.INVOICEDataSet16();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSet16TableAdapters.productTableAdapter();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.iNVOICEDataSet9;
            // 
            // iNVOICEDataSet9
            // 
            this.iNVOICEDataSet9.DataSetName = "INVOICEDataSet9";
            this.iNVOICEDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ExecuteGenReport
            // 
            this.ExecuteGenReport.BackColor = System.Drawing.Color.MediumPurple;
            this.ExecuteGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteGenReport.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGenReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExecuteGenReport.Location = new System.Drawing.Point(781, 489);
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
            this.label1.Location = new System.Drawing.Point(874, 355);
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
            this.toY.Location = new System.Drawing.Point(983, 371);
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
            this.toM.Location = new System.Drawing.Point(929, 371);
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
            this.toD.Location = new System.Drawing.Point(876, 371);
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
            this.label2.Location = new System.Drawing.Point(818, 365);
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
            this.label6.Location = new System.Drawing.Point(875, 277);
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
            this.fromY.Location = new System.Drawing.Point(984, 293);
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
            this.fromM.Location = new System.Drawing.Point(930, 293);
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
            this.fromD.Location = new System.Drawing.Point(877, 293);
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
            this.label3.Location = new System.Drawing.Point(780, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "FROM: ";
            // 
            // inventory
            // 
            this.inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory.Location = new System.Drawing.Point(878, 12);
            this.inventory.Name = "inventory";
            this.inventory.RowHeadersWidth = 56;
            this.inventory.RowTemplate.Height = 24;
            this.inventory.Size = new System.Drawing.Size(240, 150);
            this.inventory.TabIndex = 47;
            this.inventory.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(435, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 82;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(152, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 81;
            this.label4.Text = "SKU:";
            // 
            // skusearch
            // 
            this.skusearch.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skusearch.Location = new System.Drawing.Point(206, 391);
            this.skusearch.Name = "skusearch";
            this.skusearch.Size = new System.Drawing.Size(215, 34);
            this.skusearch.TabIndex = 80;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(139, 557);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 22);
            this.label22.TabIndex = 78;
            this.label22.Text = "Brand:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(148, 520);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 22);
            this.label21.TabIndex = 77;
            this.label21.Text = "SKU:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(136, 485);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 22);
            this.label20.TabIndex = 76;
            this.label20.Text = "Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.GridColor = System.Drawing.Color.Red;
            this.dataGridView2.Location = new System.Drawing.Point(12, 7);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersWidth = 56;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(734, 364);
            this.dataGridView2.TabIndex = 75;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // invBrand
            // 
            this.invBrand.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invBrand.Location = new System.Drawing.Point(206, 543);
            this.invBrand.Name = "invBrand";
            this.invBrand.Size = new System.Drawing.Size(215, 34);
            this.invBrand.TabIndex = 73;
            // 
            // invSku
            // 
            this.invSku.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invSku.Location = new System.Drawing.Point(206, 508);
            this.invSku.Name = "invSku";
            this.invSku.Size = new System.Drawing.Size(215, 34);
            this.invSku.TabIndex = 72;
            // 
            // invProdName
            // 
            this.invProdName.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invProdName.Location = new System.Drawing.Point(206, 473);
            this.invProdName.Name = "invProdName";
            this.invProdName.Size = new System.Drawing.Size(215, 34);
            this.invProdName.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(232, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 70;
            this.label5.Text = "Product credentials:";
            // 
            // iNVOICEDataSet16
            // 
            this.iNVOICEDataSet16.DataSetName = "INVOICEDataSet16";
            this.iNVOICEDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.iNVOICEDataSet16;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "sku";
            this.skuDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.Width = 150;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 1000;
            // 
            // ClientSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.stencil_removeprod;
            this.ClientSize = new System.Drawing.Size(1129, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skusearch);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.invBrand);
            this.Controls.Add(this.invSku);
            this.Controls.Add(this.invProdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventory);
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
            this.Name = "ClientSaleReport";
            this.Text = "ClientSaleReport";
            this.Load += new System.EventHandler(this.ClientSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private INVOICEDataSet9 iNVOICEDataSet9;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private INVOICEDataSet9TableAdapters.clientsTableAdapter clientsTableAdapter;
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
        private System.Windows.Forms.DataGridView inventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox skusearch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox invBrand;
        private System.Windows.Forms.TextBox invSku;
        private System.Windows.Forms.TextBox invProdName;
        private System.Windows.Forms.Label label5;
        private INVOICEDataSet16 iNVOICEDataSet16;
        private System.Windows.Forms.BindingSource productBindingSource;
        private INVOICEDataSet16TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
    }
}