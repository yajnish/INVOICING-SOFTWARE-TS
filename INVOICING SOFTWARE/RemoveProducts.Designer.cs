namespace INVOICING_SOFTWARE
{
    partial class RemoveProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProducts));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICEDataSet = new INVOICING_SOFTWARE.INVOICEDataSet();
            this.productTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSetTableAdapters.productTableAdapter();
            this.prodnamedel = new System.Windows.Forms.TextBox();
            this.prodpricedel = new System.Windows.Forms.TextBox();
            this.announceDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateRec = new System.Windows.Forms.Button();
            this.deleteRec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.Location = new System.Drawing.Point(12, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 56;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(275, 547);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 135;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.iNVOICEDataSet;
            // 
            // iNVOICEDataSet
            // 
            this.iNVOICEDataSet.DataSetName = "INVOICEDataSet";
            this.iNVOICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // prodnamedel
            // 
            this.prodnamedel.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnamedel.Location = new System.Drawing.Point(641, 58);
            this.prodnamedel.Name = "prodnamedel";
            this.prodnamedel.Size = new System.Drawing.Size(176, 38);
            this.prodnamedel.TabIndex = 3;
            // 
            // prodpricedel
            // 
            this.prodpricedel.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodpricedel.Location = new System.Drawing.Point(641, 130);
            this.prodpricedel.Name = "prodpricedel";
            this.prodpricedel.Size = new System.Drawing.Size(176, 38);
            this.prodpricedel.TabIndex = 4;
            // 
            // announceDel
            // 
            this.announceDel.BackColor = System.Drawing.Color.MistyRose;
            this.announceDel.Font = new System.Drawing.Font("Corbel", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announceDel.ForeColor = System.Drawing.Color.Black;
            this.announceDel.Location = new System.Drawing.Point(360, 530);
            this.announceDel.Name = "announceDel";
            this.announceDel.ReadOnly = true;
            this.announceDel.Size = new System.Drawing.Size(457, 38);
            this.announceDel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(531, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(497, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unit Price:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // updateRec
            // 
            this.updateRec.BackColor = System.Drawing.Color.Indigo;
            this.updateRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateRec.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRec.ForeColor = System.Drawing.Color.White;
            this.updateRec.Location = new System.Drawing.Point(560, 275);
            this.updateRec.Name = "updateRec";
            this.updateRec.Size = new System.Drawing.Size(257, 69);
            this.updateRec.TabIndex = 9;
            this.updateRec.Text = "UPDATE PRICE";
            this.updateRec.UseVisualStyleBackColor = false;
            this.updateRec.Click += new System.EventHandler(this.updateRec_Click);
            // 
            // deleteRec
            // 
            this.deleteRec.BackColor = System.Drawing.Color.Indigo;
            this.deleteRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteRec.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRec.ForeColor = System.Drawing.Color.White;
            this.deleteRec.Location = new System.Drawing.Point(560, 391);
            this.deleteRec.Name = "deleteRec";
            this.deleteRec.Size = new System.Drawing.Size(257, 69);
            this.deleteRec.TabIndex = 10;
            this.deleteRec.Text = "REMOVE";
            this.deleteRec.UseVisualStyleBackColor = false;
            this.deleteRec.Click += new System.EventHandler(this.deleteRec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose Product";
            // 
            // RemoveProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(859, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteRec);
            this.Controls.Add(this.updateRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.announceDel);
            this.Controls.Add(this.prodpricedel);
            this.Controls.Add(this.prodnamedel);
            this.Controls.Add(this.dataGridView2);
            this.Name = "RemoveProducts";
            this.Text = "Remove Products";
            this.Load += new System.EventHandler(this.RemoveProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private INVOICEDataSet iNVOICEDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private INVOICEDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox prodnamedel;
        private System.Windows.Forms.TextBox prodpricedel;
        private System.Windows.Forms.TextBox announceDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateRec;
        private System.Windows.Forms.Button deleteRec;
        private System.Windows.Forms.Label label3;
    }
}