using System;

namespace INVOICING_SOFTWARE
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.delivery = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.genInvoice = new System.Windows.Forms.Button();
            this.numINV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.delivery);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.removeProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 613);
            this.panel1.TabIndex = 8;
            // 
            // delivery
            // 
            this.delivery.BackColor = System.Drawing.Color.Transparent;
            this.delivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delivery.FlatAppearance.BorderSize = 0;
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Font = new System.Drawing.Font("Nirmala UI", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delivery.Location = new System.Drawing.Point(3, 348);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(209, 87);
            this.delivery.TabIndex = 5;
            this.delivery.Text = "DELIVERY";
            this.delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delivery.UseVisualStyleBackColor = false;
            this.delivery.Click += new System.EventHandler(this.delivery_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.invReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 135);
            this.panel3.TabIndex = 4;
            // 
            // invReport
            // 
            this.invReport.BackColor = System.Drawing.Color.Transparent;
            this.invReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invReport.FlatAppearance.BorderSize = 0;
            this.invReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invReport.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invReport.Image = ((System.Drawing.Image)(resources.GetObject("invReport.Image")));
            this.invReport.Location = new System.Drawing.Point(11, 6);
            this.invReport.Name = "invReport";
            this.invReport.Size = new System.Drawing.Size(197, 129);
            this.invReport.TabIndex = 6;
            this.invReport.Text = "Generate Reports";
            this.invReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.invReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.invReport.UseVisualStyleBackColor = false;
            this.invReport.Click += new System.EventHandler(this.invReport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 142);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.TSLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::INVOICING_SOFTWARE.Properties.Resources.stencil_logo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.Transparent;
            this.addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Nirmala UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProduct.Image = global::INVOICING_SOFTWARE.Properties.Resources.add_product1;
            this.addProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProduct.Location = new System.Drawing.Point(11, 144);
            this.addProduct.Name = "addProduct";
            this.addProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addProduct.Size = new System.Drawing.Size(162, 71);
            this.addProduct.TabIndex = 0;
            this.addProduct.Text = "Add Product";
            this.addProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.BackColor = System.Drawing.Color.Transparent;
            this.removeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeProduct.FlatAppearance.BorderSize = 0;
            this.removeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProduct.Font = new System.Drawing.Font("Nirmala UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeProduct.Image = global::INVOICING_SOFTWARE.Properties.Resources.remove_product;
            this.removeProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeProduct.Location = new System.Drawing.Point(11, 221);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(209, 87);
            this.removeProduct.TabIndex = 1;
            this.removeProduct.Text = "Remove Or Update Product";
            this.removeProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeProduct.UseVisualStyleBackColor = false;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.genInvoice);
            this.panel4.Controls.Add(this.numINV);
            this.panel4.Location = new System.Drawing.Point(241, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 183);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(150, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::INVOICING_SOFTWARE.Properties.Resources.stencil_500__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 159);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // genInvoice
            // 
            this.genInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.genInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genInvoice.Font = new System.Drawing.Font("Nirmala UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.genInvoice.Image = global::INVOICING_SOFTWARE.Properties.Resources.addINV;
            this.genInvoice.Location = new System.Drawing.Point(471, 6);
            this.genInvoice.Name = "genInvoice";
            this.genInvoice.Size = new System.Drawing.Size(156, 146);
            this.genInvoice.TabIndex = 4;
            this.genInvoice.Text = "Make A Sale";
            this.genInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.genInvoice.UseVisualStyleBackColor = false;
            this.genInvoice.Click += new System.EventHandler(this.genInvoice_Click);
            // 
            // numINV
            // 
            this.numINV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numINV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numINV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.numINV.Location = new System.Drawing.Point(175, 6);
            this.numINV.Name = "numINV";
            this.numINV.Size = new System.Drawing.Size(279, 35);
            this.numINV.TabIndex = 9;
            this.numINV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numINV.TextChanged += new System.EventHandler(this.numINV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Coral;
            this.closeBtn.Image = global::INVOICING_SOFTWARE.Properties.Resources.off;
            this.closeBtn.Location = new System.Drawing.Point(820, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(72, 63);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(675, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 87);
            this.button1.TabIndex = 6;
            this.button1.Text = "PACK UP";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.Color.Black;
            this.balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balance.FlatAppearance.BorderSize = 0;
            this.balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balance.Font = new System.Drawing.Font("Nirmala UI", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balance.Location = new System.Drawing.Point(675, 383);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(209, 113);
            this.balance.TabIndex = 12;
            this.balance.Text = "Total For Today";
            this.balance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.balance.UseVisualStyleBackColor = false;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(851, 353);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 56;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(33, 24);
            this.grid.TabIndex = 13;
            this.grid.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 613);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YC INVOICE SOFTWARE";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.Button genInvoice;
        private System.Windows.Forms.Button invReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numINV;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delivery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.DataGridView grid;
    }
}

