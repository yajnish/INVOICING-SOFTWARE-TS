namespace INVOICING_SOFTWARE
{
    partial class Add_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodBrand = new System.Windows.Forms.TextBox();
            this.prodSKU = new System.Windows.Forms.TextBox();
            this.prodUnitPrice = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.announce = new System.Windows.Forms.TextBox();
            this.taxorno = new System.Windows.Forms.CheckBox();
            this.sellPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.multi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calSell = new System.Windows.Forms.Button();
            this.costprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(191, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(210, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "SKU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(101, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price(Rs.):";
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(281, 106);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(430, 42);
            this.prodName.TabIndex = 4;
            // 
            // prodBrand
            // 
            this.prodBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBrand.Location = new System.Drawing.Point(281, 170);
            this.prodBrand.Name = "prodBrand";
            this.prodBrand.Size = new System.Drawing.Size(430, 42);
            this.prodBrand.TabIndex = 5;
            // 
            // prodSKU
            // 
            this.prodSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodSKU.Location = new System.Drawing.Point(281, 42);
            this.prodSKU.Name = "prodSKU";
            this.prodSKU.Size = new System.Drawing.Size(430, 42);
            this.prodSKU.TabIndex = 6;
            this.prodSKU.TextChanged += new System.EventHandler(this.prodSKU_TextChanged);
            // 
            // prodUnitPrice
            // 
            this.prodUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodUnitPrice.Location = new System.Drawing.Point(281, 235);
            this.prodUnitPrice.Name = "prodUnitPrice";
            this.prodUnitPrice.Size = new System.Drawing.Size(430, 42);
            this.prodUnitPrice.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Orange;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Corbel", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(290, 619);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(280, 85);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // announce
            // 
            this.announce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.announce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.announce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.announce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.announce.Location = new System.Drawing.Point(81, 718);
            this.announce.Name = "announce";
            this.announce.ReadOnly = true;
            this.announce.Size = new System.Drawing.Size(656, 35);
            this.announce.TabIndex = 9;
            this.announce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxorno
            // 
            this.taxorno.AutoSize = true;
            this.taxorno.BackColor = System.Drawing.Color.Transparent;
            this.taxorno.Checked = true;
            this.taxorno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.taxorno.Font = new System.Drawing.Font("Nirmala UI", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxorno.Location = new System.Drawing.Point(547, 319);
            this.taxorno.Name = "taxorno";
            this.taxorno.Size = new System.Drawing.Size(180, 36);
            this.taxorno.TabIndex = 12;
            this.taxorno.Text = "Tax Included?";
            this.taxorno.UseVisualStyleBackColor = false;
            // 
            // sellPrice
            // 
            this.sellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPrice.Location = new System.Drawing.Point(281, 550);
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(430, 42);
            this.sellPrice.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(75, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selling Price(Rs.):";
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.15385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(281, 467);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(141, 49);
            this.multi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(146, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Multiplier:";
            // 
            // calSell
            // 
            this.calSell.BackColor = System.Drawing.Color.Orange;
            this.calSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calSell.Font = new System.Drawing.Font("Nirmala UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calSell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calSell.Location = new System.Drawing.Point(445, 467);
            this.calSell.Name = "calSell";
            this.calSell.Size = new System.Drawing.Size(266, 53);
            this.calSell.TabIndex = 17;
            this.calSell.Text = "Calculate Selling Price";
            this.calSell.UseVisualStyleBackColor = false;
            this.calSell.Click += new System.EventHandler(this.calSell_Click);
            // 
            // costprice
            // 
            this.costprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costprice.Location = new System.Drawing.Point(281, 394);
            this.costprice.Name = "costprice";
            this.costprice.ReadOnly = true;
            this.costprice.Size = new System.Drawing.Size(430, 42);
            this.costprice.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(96, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cost Price(Rs.):";
            // 
            // calCost
            // 
            this.calCost.BackColor = System.Drawing.Color.Orange;
            this.calCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calCost.Font = new System.Drawing.Font("Nirmala UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calCost.Location = new System.Drawing.Point(281, 313);
            this.calCost.Name = "calCost";
            this.calCost.Size = new System.Drawing.Size(251, 53);
            this.calCost.TabIndex = 20;
            this.calCost.Text = "Calculate Cost Price";
            this.calCost.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.calCost.UseVisualStyleBackColor = false;
            this.calCost.Click += new System.EventHandler(this.calCost_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 768);
            this.Controls.Add(this.calCost);
            this.Controls.Add(this.costprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calSell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taxorno);
            this.Controls.Add(this.announce);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.prodUnitPrice);
            this.Controls.Add(this.prodSKU);
            this.Controls.Add(this.prodBrand);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Product";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.TextBox prodBrand;
        private System.Windows.Forms.TextBox prodSKU;
        private System.Windows.Forms.TextBox prodUnitPrice;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox announce;
        private System.Windows.Forms.CheckBox taxorno;
        private System.Windows.Forms.TextBox sellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox multi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calSell;
        private System.Windows.Forms.TextBox costprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calCost;
    }
}