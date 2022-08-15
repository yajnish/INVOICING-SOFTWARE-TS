using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using System.Reflection;
using System.Net;

namespace INVOICING_SOFTWARE
{
    public partial class delivery : Form
    {
        public delivery()
        {
            InitializeComponent();
        }
        public string sqlAddProd = "";
        public string telegramAddProd = "";
        public string telegramAddProd2 = "";
        public string telegramAddProd3 = "";
        public string telegramAddProd4 = "";
        public string telegramAddProd5 = "";
        public string telegramAddProd6 = "";
        public string telegramAddProd7 = "";

        public string datetoday = DateTime.Now.ToString("yyyy/MM/dd");
        private void delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVOICEDataSet15.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.iNVOICEDataSet15.supplier);
            // TODO: This line of code loads data into the 'iNVOICEDataSet11.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iNVOICEDataSet11.product);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            invSku.Text = dataGridView2.SelectedCells[0].Value.ToString();
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {
                    

                    if ((connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'")==null) || (connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'")==null))
                    {
                        invProdName.Text = "";
                        invBrand.Text = "";
                        invSku.Text = "";
                        invUnitPrice.Text = "";
                    }
                    else
                    {
                        invProdName.Text = connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'").ToString();
                        invBrand.Text = connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'").ToString();
                        invUnitPrice.Text = connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'").ToString();
                    }
                    
                   
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (skusearch.Text != "")
            {
                invSku.Text = skusearch.Text;
                try
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {


                        if ((connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'") == null))
                        {
                            invProdName.Text = "";
                            invBrand.Text = "";
                            invSku.Text = "";
                            invUnitPrice.Text = "";
                            MessageBox.Show("Product does not exist in Database!");
                        }
                        else
                        {
                            invProdName.Text = connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'").ToString();
                            invBrand.Text = connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'").ToString();
                            invUnitPrice.Text = connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'").ToString();
                        }


                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        double taxamt = 0;
        double netamt = 0;
        private void addProdinv_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = productlist.Rows.Count;
                double stock;
                string stockprod;
                
                double quan = (double)qty.Value;
                double value = quan * double.Parse(invUnitPrice.Text);
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {
                    stockprod = connection.ExecuteScalar($"SELECT stock FROM product WHERE sku = '{invSku.Text}'").ToString();
                    //taxamt1 = connection.ExecuteScalar($"SELECT tax FROM product WHERE sku = '{invSku.Text}'").ToString();
                }
                stock = double.Parse(stockprod);
                stock = stock + quan;
                productlist.Rows.Add(quan, $"{invProdName.Text} {invSku.Text}", (double.Parse(invUnitPrice.Text)).ToString("#.00"), String.Format("{0:f2}", value));
                
                if (telegramAddProd.Length < 3975)
                {
                    telegramAddProd = telegramAddProd + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                }
                else
                {
                    if (telegramAddProd2.Length < 3975)
                    {
                        telegramAddProd2 = telegramAddProd2 + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                    }
                    else
                    {
                        if (telegramAddProd3.Length < 3975)
                        {
                            telegramAddProd3 = telegramAddProd3 + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                        }
                        else
                        {
                            if (telegramAddProd4.Length < 3975)
                            {
                                telegramAddProd4 = telegramAddProd4 + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                            }
                            else
                            {
                                if (telegramAddProd5.Length < 3975)
                                {
                                    telegramAddProd5 = telegramAddProd5 + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                                }
                                else
                                {
                                    if (telegramAddProd6.Length < 3975)
                                    {
                                        telegramAddProd6 = telegramAddProd6 + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                                    }
                                    else
                                    {
                                        if (telegramAddProd7.Length < 3975)
                                        {
                                            telegramAddProd7 = telegramAddProd7 + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                                        }

                                    }
                                }
                            }
                        }

                    }

                }




                sqlAddProd = sqlAddProd + $"INSERT INTO purchase(date, productreceived, quantityreceived, supplier, cost_taxincluded, tax) VALUES ('{datetoday}', '{invProdName.Text} ({invSku.Text})', '{quan}', '{comboBox1.Text}:{supInv.Text}', '{value}', '{(value/1.15)*0.15}') UPDATE product SET stock = {stock} WHERE sku = '{invSku.Text}' ";
                //telegramAddProd = telegramAddProd + $"%0AProduct: {invProdName.Text} ({invSku.Text})%0AQuantity Received: {quan}%0ATotal Cost (+VAT): Rs. {value}%0AUpdated Stock: {stock}%0A----------------------";
                taxamt = taxamt +((value / 1.15) * 0.15);
                netamt = netamt + value;
            }
            catch (Exception)
            {
                sqlAddProd = "";
                invProdName.Text = "";
                invBrand.Text = "";
                invSku.Text = "";
                invUnitPrice.Text = "";
                taxamt = 0;
                telegramAddProd = "";
                telegramAddProd = "";
                telegramAddProd2 = "";
                telegramAddProd3 = "";
                telegramAddProd4 = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlAddProd = "";
            invProdName.Text = "";
            invBrand.Text = "";
            invSku.Text = "";
            invUnitPrice.Text = "";
            taxamt = 0;
            telegramAddProd = "";
            telegramAddProd2 = "";
            telegramAddProd3 = "";
            telegramAddProd4 = "";
            telegramAddProd5 = "";
            telegramAddProd6 = "";
            telegramAddProd7 = "";
            nettotal.Text = "";
            netamt = 0;

            productlist.Rows.Clear();
        }

        private void calcNet_Click(object sender, EventArgs e)
        {
            nettotal.Text = netamt.ToString();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show($"Approve Purchase Of Products?\nCheck if all goods have been delivered and net amount is okay.", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                //try
                //{
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        connection.Query($"{sqlAddProd}");
                    }
                var client = new WebClient();
                var content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=DELIVERY RECEIVED!%0AFrom: {comboBox1.Text} (Invoice:{supInv.Text})%0A----------------------%0A{telegramAddProd}");
                if (telegramAddProd2 != "")
                {
                    content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=>>>>>>{telegramAddProd2}");
                }
                if (telegramAddProd3 != "")
                {
                    content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=>>>>>>{telegramAddProd3}");
                }
                if (telegramAddProd4 != "")
                {
                    content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=>>>>>>{telegramAddProd4}");
                }
                if (telegramAddProd5 != "")
                {
                    content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=>>>>>>{telegramAddProd5}");
                }
                if (telegramAddProd6 != "")
                {
                    content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=>>>>>>{telegramAddProd6}");
                }
                if (telegramAddProd7 != "")
                {
                    content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=>>>>>>{telegramAddProd7}");
                }
                content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=NET TOTAL: {netamt}");
                //}
                //catch (Exception)
                //{

                //}

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void skusearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
