namespace INVOICING_SOFTWARE
{
    partial class delivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delivery));
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICEDataSet11 = new INVOICING_SOFTWARE.INVOICEDataSet11();
            this.label7 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.invUnitPrice = new System.Windows.Forms.TextBox();
            this.invBrand = new System.Windows.Forms.TextBox();
            this.invSku = new System.Windows.Forms.TextBox();
            this.invProdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSet11TableAdapters.productTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.productlist = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProdinv = new System.Windows.Forms.Button();
            this.skusearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nettotal = new System.Windows.Forms.TextBox();
            this.calcNet = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supInv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iNVOICEDataSet15 = new INVOICING_SOFTWARE.INVOICEDataSet15();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSet15TableAdapters.supplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(793, 350);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 22);
            this.label23.TabIndex = 66;
            this.label23.Text = "Unit Price:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(822, 319);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 22);
            this.label22.TabIndex = 65;
            this.label22.Text = "Brand:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(831, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 22);
            this.label21.TabIndex = 64;
            this.label21.Text = "SKU:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(819, 247);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 22);
            this.label20.TabIndex = 63;
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
            this.dataGridView2.Location = new System.Drawing.Point(25, 70);
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
            this.dataGridView2.TabIndex = 62;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.skuDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.Width = 250;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 425;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.iNVOICEDataSet11;
            // 
            // iNVOICEDataSet11
            // 
            this.iNVOICEDataSet11.DataSetName = "INVOICEDataSet11";
            this.iNVOICEDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(810, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Quantity Received:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(992, 394);
            this.qty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(112, 40);
            this.qty.TabIndex = 60;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // invUnitPrice
            // 
            this.invUnitPrice.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invUnitPrice.Location = new System.Drawing.Point(889, 340);
            this.invUnitPrice.Name = "invUnitPrice";
            this.invUnitPrice.Size = new System.Drawing.Size(215, 34);
            this.invUnitPrice.TabIndex = 59;
            // 
            // invBrand
            // 
            this.invBrand.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invBrand.Location = new System.Drawing.Point(889, 305);
            this.invBrand.Name = "invBrand";
            this.invBrand.Size = new System.Drawing.Size(215, 34);
            this.invBrand.TabIndex = 58;
            // 
            // invSku
            // 
            this.invSku.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invSku.Location = new System.Drawing.Point(889, 270);
            this.invSku.Name = "invSku";
            this.invSku.Size = new System.Drawing.Size(215, 34);
            this.invSku.TabIndex = 57;
            // 
            // invProdName
            // 
            this.invProdName.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invProdName.Location = new System.Drawing.Point(889, 235);
            this.invProdName.Name = "invProdName";
            this.invProdName.Size = new System.Drawing.Size(215, 34);
            this.invProdName.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(915, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "Product credentials:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Product:";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1118, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 69;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productlist
            // 
            this.productlist.AllowUserToAddRows = false;
            this.productlist.AllowUserToDeleteRows = false;
            this.productlist.AllowUserToResizeColumns = false;
            this.productlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.ProdDesc,
            this.unitPrice,
            this.val});
            this.productlist.Location = new System.Drawing.Point(25, 486);
            this.productlist.Name = "productlist";
            this.productlist.RowHeadersWidth = 56;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.productlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.productlist.RowTemplate.Height = 24;
            this.productlist.Size = new System.Drawing.Size(772, 344);
            this.productlist.TabIndex = 70;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 7;
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 85;
            // 
            // ProdDesc
            // 
            this.ProdDesc.HeaderText = "Product Description";
            this.ProdDesc.MinimumWidth = 7;
            this.ProdDesc.Name = "ProdDesc";
            this.ProdDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDesc.Width = 375;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 7;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unitPrice.Width = 135;
            // 
            // val
            // 
            this.val.HeaderText = "Value";
            this.val.MinimumWidth = 7;
            this.val.Name = "val";
            this.val.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.val.Width = 150;
            // 
            // addProdinv
            // 
            this.addProdinv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addProdinv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProdinv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProdinv.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdinv.ForeColor = System.Drawing.Color.Black;
            this.addProdinv.Location = new System.Drawing.Point(1157, 344);
            this.addProdinv.Name = "addProdinv";
            this.addProdinv.Size = new System.Drawing.Size(155, 90);
            this.addProdinv.TabIndex = 71;
            this.addProdinv.Text = "Add Product";
            this.addProdinv.UseVisualStyleBackColor = false;
            this.addProdinv.Click += new System.EventHandler(this.addProdinv_Click);
            // 
            // skusearch
            // 
            this.skusearch.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skusearch.Location = new System.Drawing.Point(889, 153);
            this.skusearch.Name = "skusearch";
            this.skusearch.Size = new System.Drawing.Size(215, 34);
            this.skusearch.TabIndex = 67;
            this.skusearch.TextChanged += new System.EventHandler(this.skusearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(835, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "SKU:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(797, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 73;
            this.label3.Text = "SUPPLIER:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(25, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 74;
            this.button2.Text = "Clear List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(849, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "NET TOTAL:";
            // 
            // nettotal
            // 
            this.nettotal.Font = new System.Drawing.Font("Nirmala UI", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nettotal.Location = new System.Drawing.Point(853, 618);
            this.nettotal.Name = "nettotal";
            this.nettotal.Size = new System.Drawing.Size(215, 41);
            this.nettotal.TabIndex = 75;
            // 
            // calcNet
            // 
            this.calcNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calcNet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcNet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcNet.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcNet.ForeColor = System.Drawing.Color.Black;
            this.calcNet.Location = new System.Drawing.Point(1094, 569);
            this.calcNet.Name = "calcNet";
            this.calcNet.Size = new System.Drawing.Size(218, 90);
            this.calcNet.TabIndex = 77;
            this.calcNet.Text = "Calculate Net Total";
            this.calcNet.UseVisualStyleBackColor = false;
            this.calcNet.Click += new System.EventHandler(this.calcNet_Click);
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accept.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.ForeColor = System.Drawing.Color.Black;
            this.accept.Location = new System.Drawing.Point(969, 734);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(218, 90);
            this.accept.TabIndex = 78;
            this.accept.Text = "ACCEPT DELIVERY";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.supplierBindingSource;
            this.comboBox1.DisplayMember = "SupplierName";
            this.comboBox1.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(899, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(403, 36);
            this.comboBox1.TabIndex = 79;
            this.comboBox1.ValueMember = "SupplierName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // supInv
            // 
            this.supInv.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supInv.Location = new System.Drawing.Point(1087, 70);
            this.supInv.Name = "supInv";
            this.supInv.Size = new System.Drawing.Size(215, 34);
            this.supInv.TabIndex = 80;
            this.supInv.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1014, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 81;
            this.label6.Text = "Invoice:";
            // 
            // iNVOICEDataSet15
            // 
            this.iNVOICEDataSet15.DataSetName = "INVOICEDataSet15";
            this.iNVOICEDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.iNVOICEDataSet15;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1345, 836);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supInv);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.calcNet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nettotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProdinv);
            this.Controls.Add(this.productlist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skusearch);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.invUnitPrice);
            this.Controls.Add(this.invBrand);
            this.Controls.Add(this.invSku);
            this.Controls.Add(this.invProdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "delivery";
            this.Text = "delivery";
            this.Load += new System.EventHandler(this.delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.TextBox invUnitPrice;
        private System.Windows.Forms.TextBox invBrand;
        private System.Windows.Forms.TextBox invSku;
        private System.Windows.Forms.TextBox invProdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private INVOICEDataSet11 iNVOICEDataSet11;
        private System.Windows.Forms.BindingSource productBindingSource;
        private INVOICEDataSet11TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView productlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn val;
        private System.Windows.Forms.Button addProdinv;
        private System.Windows.Forms.TextBox skusearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nettotal;
        private System.Windows.Forms.Button calcNet;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox supInv;
        private System.Windows.Forms.Label label6;
        private INVOICEDataSet15 iNVOICEDataSet15;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private INVOICEDataSet15TableAdapters.supplierTableAdapter supplierTableAdapter;
    }
}