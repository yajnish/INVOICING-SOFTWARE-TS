namespace INVOICING_SOFTWARE
{
    partial class RemoveClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveClient));
            this.iNVOICEDataSet = new INVOICING_SOFTWARE.INVOICEDataSet();
            this.iNVOICEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICEDataSet1 = new INVOICING_SOFTWARE.INVOICEDataSet1();
            this.clientsTableAdapter = new INVOICING_SOFTWARE.INVOICEDataSet1TableAdapters.clientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remCompanyName = new System.Windows.Forms.TextBox();
            this.remContactNumber = new System.Windows.Forms.TextBox();
            this.remStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.remCity = new System.Windows.Forms.TextBox();
            this.updateAddress = new System.Windows.Forms.Button();
            this.updateContact = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.announce = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICEDataSet8 = new INVOICING_SOFTWARE.INVOICEDataSet8();
            this.clientsTableAdapter1 = new INVOICING_SOFTWARE.INVOICEDataSet8TableAdapters.clientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // iNVOICEDataSet
            // 
            this.iNVOICEDataSet.DataSetName = "INVOICEDataSet";
            this.iNVOICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVOICEDataSetBindingSource
            // 
            this.iNVOICEDataSetBindingSource.DataSource = this.iNVOICEDataSet;
            this.iNVOICEDataSetBindingSource.Position = 0;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.iNVOICEDataSet1;
            // 
            // iNVOICEDataSet1
            // 
            this.iNVOICEDataSet1.DataSetName = "INVOICEDataSet1";
            this.iNVOICEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(333, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(352, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Number:";
            // 
            // remCompanyName
            // 
            this.remCompanyName.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remCompanyName.Location = new System.Drawing.Point(526, 35);
            this.remCompanyName.Name = "remCompanyName";
            this.remCompanyName.Size = new System.Drawing.Size(249, 32);
            this.remCompanyName.TabIndex = 4;
            // 
            // remContactNumber
            // 
            this.remContactNumber.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remContactNumber.Location = new System.Drawing.Point(526, 94);
            this.remContactNumber.Name = "remContactNumber";
            this.remContactNumber.Size = new System.Drawing.Size(249, 32);
            this.remContactNumber.TabIndex = 5;
            // 
            // remStreet
            // 
            this.remStreet.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remStreet.Location = new System.Drawing.Point(526, 158);
            this.remStreet.Name = "remStreet";
            this.remStreet.Size = new System.Drawing.Size(249, 32);
            this.remStreet.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(445, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Street:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(466, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "City:";
            // 
            // remCity
            // 
            this.remCity.Font = new System.Drawing.Font("Corbel", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remCity.Location = new System.Drawing.Point(526, 218);
            this.remCity.Name = "remCity";
            this.remCity.Size = new System.Drawing.Size(249, 32);
            this.remCity.TabIndex = 9;
            // 
            // updateAddress
            // 
            this.updateAddress.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateAddress.Location = new System.Drawing.Point(614, 282);
            this.updateAddress.Name = "updateAddress";
            this.updateAddress.Size = new System.Drawing.Size(161, 89);
            this.updateAddress.TabIndex = 10;
            this.updateAddress.Text = "UPDATE ADDRESS";
            this.updateAddress.UseVisualStyleBackColor = true;
            this.updateAddress.Click += new System.EventHandler(this.updateAddress_Click);
            // 
            // updateContact
            // 
            this.updateContact.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateContact.Location = new System.Drawing.Point(419, 282);
            this.updateContact.Name = "updateContact";
            this.updateContact.Size = new System.Drawing.Size(161, 89);
            this.updateContact.TabIndex = 11;
            this.updateContact.Text = "UPDATE CONTACT";
            this.updateContact.UseVisualStyleBackColor = true;
            this.updateContact.Click += new System.EventHandler(this.updateContact_Click);
            // 
            // removebtn
            // 
            this.removebtn.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removebtn.Location = new System.Drawing.Point(419, 388);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(356, 53);
            this.removebtn.TabIndex = 12;
            this.removebtn.Text = "REMOVE CLIENT";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // announce
            // 
            this.announce.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announce.Location = new System.Drawing.Point(330, 471);
            this.announce.Name = "announce";
            this.announce.ReadOnly = true;
            this.announce.Size = new System.Drawing.Size(444, 34);
            this.announce.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companynameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(26, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 56;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(238, 453);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 135;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients";
            this.clientsBindingSource1.DataSource = this.iNVOICEDataSet8;
            // 
            // iNVOICEDataSet8
            // 
            this.iNVOICEDataSet8.DataSetName = "INVOICEDataSet8";
            this.iNVOICEDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // RemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.announce);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.updateContact);
            this.Controls.Add(this.updateAddress);
            this.Controls.Add(this.remCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remStreet);
            this.Controls.Add(this.remContactNumber);
            this.Controls.Add(this.remCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "RemoveClient";
            this.Text = "RemoveClient";
            this.Load += new System.EventHandler(this.RemoveClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource iNVOICEDataSetBindingSource;
        private INVOICEDataSet iNVOICEDataSet;
        private INVOICEDataSet1 iNVOICEDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private INVOICEDataSet1TableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remCompanyName;
        private System.Windows.Forms.TextBox remContactNumber;
        private System.Windows.Forms.TextBox remStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remCity;
        private System.Windows.Forms.Button updateAddress;
        private System.Windows.Forms.Button updateContact;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.TextBox announce;
        private System.Windows.Forms.DataGridView dataGridView1;
        private INVOICEDataSet8 iNVOICEDataSet8;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private INVOICEDataSet8TableAdapters.clientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
    }
}