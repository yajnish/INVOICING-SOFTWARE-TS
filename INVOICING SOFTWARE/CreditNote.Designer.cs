namespace INVOICING_SOFTWARE
{
    partial class CreditNote
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balRemain = new System.Windows.Forms.TextBox();
            this.totalReceipt = new System.Windows.Forms.TextBox();
            this.issueDate = new System.Windows.Forms.TextBox();
            this.receiptCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.invoiceno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePaidY = new System.Windows.Forms.ComboBox();
            this.datePaidM = new System.Windows.Forms.ComboBox();
            this.datepaidD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.amtPaid = new System.Windows.Forms.TextBox();
            this.richDetail = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cnlist = new System.Windows.Forms.DataGridView();
            this.CNdescamt = new System.Windows.Forms.DataGridView();
            this.DescriptionCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cnlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNdescamt)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(234, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Balance Remaining:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(343, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(292, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date Issued:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(309, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Company:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // balRemain
            // 
            this.balRemain.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balRemain.Location = new System.Drawing.Point(404, 271);
            this.balRemain.Name = "balRemain";
            this.balRemain.ReadOnly = true;
            this.balRemain.Size = new System.Drawing.Size(226, 27);
            this.balRemain.TabIndex = 19;
            this.balRemain.TextChanged += new System.EventHandler(this.balRemain_TextChanged);
            // 
            // totalReceipt
            // 
            this.totalReceipt.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReceipt.Location = new System.Drawing.Point(404, 204);
            this.totalReceipt.Name = "totalReceipt";
            this.totalReceipt.ReadOnly = true;
            this.totalReceipt.Size = new System.Drawing.Size(226, 27);
            this.totalReceipt.TabIndex = 18;
            this.totalReceipt.TextChanged += new System.EventHandler(this.totalReceipt_TextChanged);
            // 
            // issueDate
            // 
            this.issueDate.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDate.Location = new System.Drawing.Point(404, 144);
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            this.issueDate.Size = new System.Drawing.Size(226, 27);
            this.issueDate.TabIndex = 17;
            this.issueDate.TextChanged += new System.EventHandler(this.issueDate_TextChanged);
            // 
            // receiptCompany
            // 
            this.receiptCompany.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptCompany.Location = new System.Drawing.Point(404, 86);
            this.receiptCompany.Name = "receiptCompany";
            this.receiptCompany.ReadOnly = true;
            this.receiptCompany.Size = new System.Drawing.Size(226, 27);
            this.receiptCompany.TabIndex = 16;
            this.receiptCompany.TextChanged += new System.EventHandler(this.receiptCompany_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(129, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "INFORMATION:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Thistle;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(498, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 35);
            this.search.TabIndex = 14;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // invoiceno
            // 
            this.invoiceno.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceno.Location = new System.Drawing.Point(209, 25);
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.Size = new System.Drawing.Size(226, 27);
            this.invoiceno.TabIndex = 13;
            this.invoiceno.Text = "10000";
            this.invoiceno.TextChanged += new System.EventHandler(this.invoiceno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Invoice Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(20, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = "Date:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(21, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "DD            MM              YYYY";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // datePaidY
            // 
            this.datePaidY.FormattingEnabled = true;
            this.datePaidY.Items.AddRange(new object[] {
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
            this.datePaidY.Location = new System.Drawing.Point(130, 409);
            this.datePaidY.Name = "datePaidY";
            this.datePaidY.Size = new System.Drawing.Size(121, 24);
            this.datePaidY.TabIndex = 40;
            this.datePaidY.Text = "2021";
            this.datePaidY.SelectedIndexChanged += new System.EventHandler(this.datePaidY_SelectedIndexChanged);
            // 
            // datePaidM
            // 
            this.datePaidM.FormattingEnabled = true;
            this.datePaidM.Items.AddRange(new object[] {
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
            this.datePaidM.Location = new System.Drawing.Point(76, 409);
            this.datePaidM.Name = "datePaidM";
            this.datePaidM.Size = new System.Drawing.Size(48, 24);
            this.datePaidM.TabIndex = 39;
            this.datePaidM.Text = "01";
            this.datePaidM.SelectedIndexChanged += new System.EventHandler(this.datePaidM_SelectedIndexChanged);
            // 
            // datepaidD
            // 
            this.datepaidD.FormattingEnabled = true;
            this.datepaidD.Items.AddRange(new object[] {
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
            this.datepaidD.Location = new System.Drawing.Point(23, 409);
            this.datepaidD.Name = "datepaidD";
            this.datepaidD.Size = new System.Drawing.Size(47, 24);
            this.datepaidD.TabIndex = 38;
            this.datepaidD.Text = "01";
            this.datepaidD.SelectedIndexChanged += new System.EventHandler(this.datepaidD_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(20, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Credit Amount:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // amtPaid
            // 
            this.amtPaid.Font = new System.Drawing.Font("Arial Narrow", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPaid.Location = new System.Drawing.Point(19, 480);
            this.amtPaid.Name = "amtPaid";
            this.amtPaid.Size = new System.Drawing.Size(233, 31);
            this.amtPaid.TabIndex = 36;
            this.amtPaid.Text = "0.00";
            this.amtPaid.TextChanged += new System.EventHandler(this.amtPaid_TextChanged);
            // 
            // richDetail
            // 
            this.richDetail.Location = new System.Drawing.Point(286, 399);
            this.richDetail.Name = "richDetail";
            this.richDetail.Size = new System.Drawing.Size(344, 114);
            this.richDetail.TabIndex = 44;
            this.richDetail.Text = "Credit Note";
            this.richDetail.TextChanged += new System.EventHandler(this.richDetail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(282, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 45;
            this.label7.Text = "Details:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(162, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 87);
            this.button1.TabIndex = 46;
            this.button1.Text = "GENERATE CREDIT NOTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnlist
            // 
            this.cnlist.AllowUserToAddRows = false;
            this.cnlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cnlist.Location = new System.Drawing.Point(803, 92);
            this.cnlist.Name = "cnlist";
            this.cnlist.RowHeadersWidth = 56;
            this.cnlist.RowTemplate.Height = 24;
            this.cnlist.Size = new System.Drawing.Size(240, 150);
            this.cnlist.TabIndex = 47;
            this.cnlist.Visible = false;
            // 
            // CNdescamt
            // 
            this.CNdescamt.AllowUserToAddRows = false;
            this.CNdescamt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CNdescamt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescriptionCredit,
            this.amtCredit});
            this.CNdescamt.Location = new System.Drawing.Point(803, 259);
            this.CNdescamt.Name = "CNdescamt";
            this.CNdescamt.ReadOnly = true;
            this.CNdescamt.RowHeadersWidth = 56;
            this.CNdescamt.RowTemplate.Height = 24;
            this.CNdescamt.Size = new System.Drawing.Size(550, 150);
            this.CNdescamt.TabIndex = 48;
            // 
            // DescriptionCredit
            // 
            this.DescriptionCredit.HeaderText = "Description";
            this.DescriptionCredit.MinimumWidth = 7;
            this.DescriptionCredit.Name = "DescriptionCredit";
            this.DescriptionCredit.ReadOnly = true;
            this.DescriptionCredit.Width = 350;
            // 
            // amtCredit
            // 
            this.amtCredit.HeaderText = "Amount";
            this.amtCredit.MinimumWidth = 7;
            this.amtCredit.Name = "amtCredit";
            this.amtCredit.ReadOnly = true;
            this.amtCredit.Width = 135;
            // 
            // CreditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.stencil_receipt__1_;
            this.ClientSize = new System.Drawing.Size(727, 653);
            this.Controls.Add(this.CNdescamt);
            this.Controls.Add(this.cnlist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richDetail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePaidY);
            this.Controls.Add(this.datePaidM);
            this.Controls.Add(this.datepaidD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amtPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balRemain);
            this.Controls.Add(this.totalReceipt);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.receiptCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.invoiceno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreditNote";
            this.Text = "Credit Note";
            this.Load += new System.EventHandler(this.CreditNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cnlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNdescamt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balRemain;
        private System.Windows.Forms.TextBox totalReceipt;
        private System.Windows.Forms.TextBox issueDate;
        private System.Windows.Forms.TextBox receiptCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox invoiceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox datePaidY;
        private System.Windows.Forms.ComboBox datePaidM;
        private System.Windows.Forms.ComboBox datepaidD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox amtPaid;
        private System.Windows.Forms.RichTextBox richDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cnlist;
        private System.Windows.Forms.DataGridView CNdescamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtCredit;
    }
}