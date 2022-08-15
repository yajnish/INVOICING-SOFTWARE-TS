using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace INVOICING_SOFTWARE
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
        decimal d;
        private void Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //var client = new WebClient();
            //var content = client.DownloadString("https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=@ToolsSpecialistDailyOp&text=Hi");
            

            if ((prodName.Text != "") && (prodUnitPrice.Text != "") && (prodSKU.Text != ""))
            {

                if (decimal.TryParse(prodUnitPrice.Text, out d))
                {
                    try
                    {

                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                        {
                            double costp = double.Parse(costprice.Text);
                            double tax;
                            tax = Math.Round(((costp/1.15)*0.15),2);
                            connection.Query($"INSERT INTO product(sku, product_name, brand, costprice, tax, sellingprice, stock) VALUES ('{ prodSKU.Text }', '{ prodName.Text }', '{ prodBrand.Text }', '{costprice.Text}', '{tax}', '{sellPrice.Text}', '0') INSERT INTO product(sku, product_name, brand, costprice, tax, sellingprice, stock) VALUES ('QIP{ prodSKU.Text }', '{ prodName.Text }', '{ prodBrand.Text }', '{costprice.Text}', '{tax}', '{sellPrice.Text}', '0')");
                            announce.Text = "Product added successfully!";
                            
                           
                        }
                        string telmessage = $"NEW PRODUCT HAS BEEN ADDED TO DATABASE!%0ASKU:{prodSKU.Text}%0AName:{prodName.Text}%0ACost Price(Vat Inclusive): Rs. {costprice.Text}%0ASelling Price: Rs. {sellPrice.Text} (X{multi.Text})";
                        try
                        {
                            var client = new WebClient();
                            var content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text={telmessage}");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Product added. Connection Failed.\nNotify admin about product addition.");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Product already exists!");
                        announce.Text = "Product not added!";
                    }
                    
                }
                else
                {
                    announce.Text = "ERROR! Enter correct details please.";
                }

            }
            else
            {
                announce.Text = "ERROR! Enter correct details please.";
            }
        }

        private void taxExempt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void calCost_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(prodUnitPrice.Text, out d))
            {
                if (taxorno.Checked == true)
                {

                    costprice.Text = prodUnitPrice.Text;
                }
                else
                {
                    double uniprice = double.Parse(prodUnitPrice.Text);
                    double cost = uniprice * 1.15;
                    costprice.Text = $"{Math.Round(cost,2).ToString("#.00")}";
                }
            }
            else
            {
                announce.Text = "ERROR! Unit Price Incorrect!";
            }
        }

        private void calSell_Click(object sender, EventArgs e)
        {
            decimal m;
            if ((decimal.TryParse(costprice.Text, out d))&&((decimal.TryParse(multi.Text, out m))))
            {
                double multiplier;
                multiplier = double.Parse(multi.Text);
                double uniprice = double.Parse(prodUnitPrice.Text);
                double cost = double.Parse(costprice.Text);
                double sell = cost * multiplier;
                //                If Yournumber mod 25 >= 13 then
                //YourNumber = YourNumber + (25 - (YourNumber Mod 25))
                //else
                //                    YourNumber = YourNumber - (YourNumber mod 25)
                //End if

                if (sell%25 >= 13)
                {
                    sell = sell + (25 - (sell % 25));

                }
                else
                {
                    sell = sell - (sell % 25);
                }

                sellPrice.Text = $"{sell.ToString("#.00")}";
            }
            else
            {
                announce.Text = "ERROR! Cost Price Or Multiplier Incorrect!";
            }
        }

        private void prodSKU_TextChanged(object sender, EventArgs e)
        {
            announce.Text = "";
        }
    }
}
