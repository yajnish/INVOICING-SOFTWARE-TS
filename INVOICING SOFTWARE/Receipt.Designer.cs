namespace INVOICING_SOFTWARE
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceno = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptCompany = new System.Windows.Forms.TextBox();
            this.issueDate = new System.Windows.Forms.TextBox();
            this.totalReceipt = new System.Windows.Forms.TextBox();
            this.balRemain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.meanPay = new System.Windows.Forms.ComboBox();
            this.amtPaid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chequeNo = new System.Windows.Forms.TextBox();
            this.genReceipt = new System.Windows.Forms.Button();
            this.chequedateD = new System.Windows.Forms.ComboBox();
            this.chequedateM = new System.Windows.Forms.ComboBox();
            this.chequedateY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePaidY = new System.Windows.Forms.ComboBox();
            this.datePaidM = new System.Windows.Forms.ComboBox();
            this.datepaidD = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Invoice Number:";
            // 
            // invoiceno
            // 
            this.invoiceno.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceno.Location = new System.Drawing.Point(201, 25);
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.Size = new System.Drawing.Size(226, 28);
            this.invoiceno.TabIndex = 1;
            this.invoiceno.Text = "10000";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Thistle;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Corbel", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(490, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 35);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(121, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "INFORMATION:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // receiptCompany
            // 
            this.receiptCompany.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptCompany.Location = new System.Drawing.Point(396, 86);
            this.receiptCompany.Name = "receiptCompany";
            this.receiptCompany.ReadOnly = true;
            this.receiptCompany.Size = new System.Drawing.Size(226, 28);
            this.receiptCompany.TabIndex = 4;
            // 
            // issueDate
            // 
            this.issueDate.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDate.Location = new System.Drawing.Point(396, 144);
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            this.issueDate.Size = new System.Drawing.Size(226, 28);
            this.issueDate.TabIndex = 5;
            // 
            // totalReceipt
            // 
            this.totalReceipt.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReceipt.Location = new System.Drawing.Point(396, 204);
            this.totalReceipt.Name = "totalReceipt";
            this.totalReceipt.ReadOnly = true;
            this.totalReceipt.Size = new System.Drawing.Size(226, 28);
            this.totalReceipt.TabIndex = 6;
            // 
            // balRemain
            // 
            this.balRemain.Font = new System.Drawing.Font("Arial Narrow", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balRemain.Location = new System.Drawing.Point(396, 271);
            this.balRemain.Name = "balRemain";
            this.balRemain.ReadOnly = true;
            this.balRemain.Size = new System.Drawing.Size(226, 28);
            this.balRemain.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(301, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Company:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(284, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Issued:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(335, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(226, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Balance Remaining:";
            // 
            // meanPay
            // 
            this.meanPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanPay.FormattingEnabled = true;
            this.meanPay.Items.AddRange(new object[] {
            "Cash",
            "Online Transfer",
            "Juice",
            "Cheque"});
            this.meanPay.Location = new System.Drawing.Point(357, 333);
            this.meanPay.Name = "meanPay";
            this.meanPay.Size = new System.Drawing.Size(233, 28);
            this.meanPay.TabIndex = 12;
            this.meanPay.Text = "Choose Means of Payment";
            // 
            // amtPaid
            // 
            this.amtPaid.Font = new System.Drawing.Font("Arial Narrow", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPaid.Location = new System.Drawing.Point(22, 456);
            this.amtPaid.Name = "amtPaid";
            this.amtPaid.Size = new System.Drawing.Size(233, 33);
            this.amtPaid.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Enter Amount Being Paid:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(369, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Enter Cheque No. (if any)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // chequeNo
            // 
            this.chequeNo.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeNo.Location = new System.Drawing.Point(357, 410);
            this.chequeNo.Name = "chequeNo";
            this.chequeNo.Size = new System.Drawing.Size(226, 29);
            this.chequeNo.TabIndex = 29;
            this.chequeNo.TextChanged += new System.EventHandler(this.chequeNo_TextChanged);
            // 
            // genReceipt
            // 
            this.genReceipt.BackColor = System.Drawing.Color.Thistle;
            this.genReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genReceipt.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genReceipt.ForeColor = System.Drawing.Color.Black;
            this.genReceipt.Location = new System.Drawing.Point(201, 588);
            this.genReceipt.Name = "genReceipt";
            this.genReceipt.Size = new System.Drawing.Size(245, 68);
            this.genReceipt.TabIndex = 30;
            this.genReceipt.Text = "Generate Receipt";
            this.genReceipt.UseVisualStyleBackColor = false;
            this.genReceipt.Click += new System.EventHandler(this.genReceipt_Click);
            // 
            // chequedateD
            // 
            this.chequedateD.FormattingEnabled = true;
            this.chequedateD.Items.AddRange(new object[] {
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
            this.chequedateD.Location = new System.Drawing.Point(356, 483);
            this.chequedateD.Name = "chequedateD";
            this.chequedateD.Size = new System.Drawing.Size(47, 24);
            this.chequedateD.TabIndex = 22;
            this.chequedateD.Text = "31";
            // 
            // chequedateM
            // 
            this.chequedateM.FormattingEnabled = true;
            this.chequedateM.Items.AddRange(new object[] {
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
            this.chequedateM.Location = new System.Drawing.Point(409, 483);
            this.chequedateM.Name = "chequedateM";
            this.chequedateM.Size = new System.Drawing.Size(48, 24);
            this.chequedateM.TabIndex = 23;
            this.chequedateM.Text = "12";
            // 
            // chequedateY
            // 
            this.chequedateY.FormattingEnabled = true;
            this.chequedateY.Items.AddRange(new object[] {
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
            this.chequedateY.Location = new System.Drawing.Point(463, 483);
            this.chequedateY.Name = "chequedateY";
            this.chequedateY.Size = new System.Drawing.Size(121, 24);
            this.chequedateY.TabIndex = 24;
            this.chequedateY.Text = "2030";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(354, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "DD            MM              YYYY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "DD            MM              YYYY";
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
            this.datePaidY.Location = new System.Drawing.Point(133, 385);
            this.datePaidY.Name = "datePaidY";
            this.datePaidY.Size = new System.Drawing.Size(121, 24);
            this.datePaidY.TabIndex = 33;
            this.datePaidY.Text = "2021";
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
            this.datePaidM.Location = new System.Drawing.Point(79, 385);
            this.datePaidM.Name = "datePaidM";
            this.datePaidM.Size = new System.Drawing.Size(48, 24);
            this.datePaidM.TabIndex = 32;
            this.datePaidM.Text = "01";
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
            this.datepaidD.Location = new System.Drawing.Point(26, 385);
            this.datepaidD.Name = "datepaidD";
            this.datepaidD.Size = new System.Drawing.Size(47, 24);
            this.datepaidD.TabIndex = 31;
            this.datepaidD.Text = "01";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(23, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 22);
            this.label11.TabIndex = 35;
            this.label11.Text = "Date of Payment:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(335, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "Enter Cheque Deposit Date(if any)";
            // 
            // bank
            // 
            this.bank.FormattingEnabled = true;
            this.bank.Items.AddRange(new object[] {
            "MCB",
            "SBM",
            "MAUBANK"});
            this.bank.Location = new System.Drawing.Point(462, 536);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(121, 24);
            this.bank.TabIndex = 37;
            this.bank.Text = "Bank";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Corbel", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(392, 538);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 22);
            this.label13.TabIndex = 38;
            this.label13.Text = "BANK:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 668);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePaidY);
            this.Controls.Add(this.datePaidM);
            this.Controls.Add(this.datepaidD);
            this.Controls.Add(this.genReceipt);
            this.Controls.Add(this.chequeNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amtPaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chequedateY);
            this.Controls.Add(this.chequedateM);
            this.Controls.Add(this.chequedateD);
            this.Controls.Add(this.meanPay);
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
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoiceno;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receiptCompany;
        private System.Windows.Forms.TextBox issueDate;
        private System.Windows.Forms.TextBox totalReceipt;
        private System.Windows.Forms.TextBox balRemain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox meanPay;
        private System.Windows.Forms.TextBox amtPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chequeNo;
        private System.Windows.Forms.Button genReceipt;
        private System.Windows.Forms.ComboBox chequedateD;
        private System.Windows.Forms.ComboBox chequedateM;
        private System.Windows.Forms.ComboBox chequedateY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox datePaidY;
        private System.Windows.Forms.ComboBox datePaidM;
        private System.Windows.Forms.ComboBox datepaidD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.Label label13;
    }
}