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
using Humanizer;
using System.Net;

namespace INVOICING_SOFTWARE
{
    public partial class GenerateInvoice : Form
    {
        double sum = 0;
        double actualsum = 0;
        double costp = 0;
        string products = "";
        public string sqlAddProd = "";
        public string sqlAddProdSales = "";
        public string telegramAddProd = "";
        public string telegramAddProd2 = "";
        public string telegramAddProd3 = "";

        public string datetoday = DateTime.Now.ToString("yyyy/MM/dd");
        public GenerateInvoice()
        {
            InitializeComponent();
        }
        double salesid;
        private void GenerateInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVOICEDataSet14.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.iNVOICEDataSet14.Users);
            // TODO: This line of code loads data into the 'iNVOICEDataSet13.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter3.Fill(this.iNVOICEDataSet13.product);
            // TODO: This line of code loads data into the 'iNVOICEDataSet12.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter2.Fill(this.iNVOICEDataSet12.product);
            // TODO: This line of code loads data into the 'iNVOICEDataSet7.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.iNVOICEDataSet7.product);
            // TODO: This line of code loads data into the 'iNVOICEDataSet6.clients' table. You can move, or remove it, as needed.
            //this.clientsTableAdapter3.Fill(this.iNVOICEDataSet6.clients);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {
                string salesidtxt;
                if (connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC") == null)
                {
                    salesidtxt = "9999";
                }
                else
                {
                    salesidtxt = connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC").ToString();
                }
                
                salesid = double.Parse(salesidtxt);

            }
            salesid = salesid + 1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        //private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    invbrn.Text = dataGridView1.SelectedCells[0].Value.ToString();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //invClName.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            //{
            //    invbrn.Text = connection.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{invClName.Text}'").ToString();
            //    invVat.Text = connection.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{invClName.Text}'").ToString();
            //    //invStreet.Text = connection.ExecuteScalar($"SELECT street_name FROM clients WHERE company_name = '{invClName.Text}'").ToString();
            //    invCity.Text = connection.ExecuteScalar($"SELECT city FROM clients WHERE company_name = '{invClName.Text}'").ToString();
            //    invNum.Text = connection.ExecuteScalar($"SELECT contact_number FROM clients WHERE company_name = '{invClName.Text}'").ToString();
            //}

        }
        //var taxyesorno = 0;
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            invSku.Text = dataGridView2.SelectedCells[0].Value.ToString();
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
                    }
                    else
                    {
                        invProdName.Text = connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'").ToString();
                        invBrand.Text = connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'").ToString();
                        string pricesell = connection.ExecuteScalar($"SELECT sellingprice FROM product WHERE sku = '{invSku.Text}'").ToString();
                        double sellp = double.Parse(pricesell);
                        invUnitPrice.Text = sellp.ToString("#.00");
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        
        private void addProdinv_Click(object sender, EventArgs e)
        {
            
            //try
            //{
                int rows = productlist.Rows.Count;
                if (rows <= 20)
                {
                    double quan = (double)qty.Value;
                    double uniprice = double.Parse(invUnitPrice.Text);
                    
                    if (vatinv.Checked==true)
                    {
                        uniprice = uniprice / 1.15;
                    }
                    double value;
                    sum = sum + (quan*uniprice);
                    value = Math.Round((quan * uniprice),2);
                    
                    //sum = sum + value;
                    //if (taxE.Checked == true)
                    //{
                    //    sumTE = sumTE + value;
                    //    productlist.Rows.Add(quan, $"{invProdName.Text} {invSku.Text} {invBrand.Text}", invUnitPrice.Text, String.Format("{0:f2}", value));
                    //}
                    //else
                    //{
                    double stock;
                    string stockprod="0",costprice="0";
                    
                    //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    //{
                    //    stockprod = connection.ExecuteScalar($"SELECT stock FROM product WHERE sku = '{invSku.Text}'").ToString();
                    //    costprice = connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'").ToString();
                    //    //taxamt1 = connection.ExecuteScalar($"SELECT tax FROM product WHERE sku = '{invSku.Text}'").ToString();
                    //}
                    stock = double.Parse(stockprod);
                    stock = stock - quan;
                    costp = costp + double.Parse(costprice);
                    //uniprice = Math.Round((uniprice / 1.15), 2);
                    if (stock < 0)
                    {
                        MessageBox.Show("NOT ENOUGH STOCK!\nClear List, Check Stock and Restart Sale!");
                    }
                    productlist.Rows.Add(quan, $"({invBrand.Text}) {invProdName.Text} {invSku.Text}", String.Format("{0:f2}", uniprice), String.Format("{0:f2}", (quan*uniprice)));
                    //}
                    sqlAddProd = sqlAddProd + $"INSERT INTO productsale (date, sku, product_name, quantity, salesid) VALUES ('{datetoday}', '{invSku.Text}', '{invProdName.Text}', '{quan}', '{salesid}') UPDATE product SET stock = '{stock}' WHERE sku = '{invSku.Text}'";
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
                        }

                    }
                    sqlAddProdSales = sqlAddProdSales + $"{invProdName.Text}({invSku.Text})X{quan},";
                }
                else
                {
                    MessageBox.Show("Maximum number of rows reached, generate another invoice please.");
                }

            //}
            //catch (Exception)
            //{

            //}





        }

        private void qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productlist.Rows.Clear();
            
            tax.Text = "0.00";
            totalNet.Text = "0.00";
            discountTE.Text = "0.00";
            totalTE.Text = "0.00";
            sum = 0;
            products = "";
            actualsum = 0;
            costp = 0;
            products = "";
            sqlAddProd = "";
            sqlAddProdSales = "";
            telegramAddProd = "";
            telegramAddProd2 = "";
            telegramAddProd3 = "";
    }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void calcTotal_Click(object sender, EventArgs e)
        {
            totalTE.Text = $"{ Math.Round(sum, 2).ToString("#.00")}";
            double totale;
            double disc;
            try
            {
                disc = double.Parse(discountTE.Text);
                if (vatinv.Checked == true)
                {
                    double disc2 = disc / 1.15;
                    totale = sum - disc2;
                    //{ Math.Round((totale*0.15), 2).ToString("#.00")}
                    tax.Text = $"{ Math.Round((totale * 0.15), 2).ToString("#.00")}";
                    totale = totale * 1.15;
                    totalNet.Text = $"{Math.Round(((sum - disc2)*1.15), 2).ToString("#.00")}";
                }
                else
                {
                    totalNet.Text = $"{Math.Round((sum - disc), 2).ToString("#.00")}";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inputing details.");
            }
            

            
            //sum = sum - double.Parse(discountTE.Text) - double.Parse(discountnotTE.Text);
            
            //totalNotTE.Text = String.Format("{0:f2}", sumnotTE);
            
            //tax.Text = String.Format("{0:f2}", ((sumnotTE - double.Parse(discountnotTE.Text)) * 0.15));
            //totalNet.Text = String.Format("{0:f2}", (((sumnotTE - double.Parse(discountnotTE.Text)) * 0.15) + sum));
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        PdfPCell cell = new PdfPCell();
        private void button1_Click(object sender, EventArgs e) //button to GENERATE INVOICE
        {
            decimal d;
            if ((decimal.TryParse(discountTE.Text, out d)) && (decimal.TryParse(reserveAmt.Text, out d)))
            {

            }
            else
            {
                MessageBox.Show("Wrong input for amounts of discount or reservation!");
                goto Here;

            }

            string userpassword;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {
                userpassword = connection.ExecuteScalar($"SELECT password FROM Users WHERE name = '{users.Text}'").ToString();
            }
            DialogResult choice;
            if (textBox1.Text == userpassword)
            {
                
                choice = MessageBox.Show($"Approve Transaction?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    if (justsale.Checked == true)
                    {
                        try
                        {
                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                connection.Query($"{sqlAddProd}");
                                connection.Query($"INSERT INTO sales(date, customer, products_sold, netamount, taxamount, discount, margin, salesperson, paymentmethod) VALUES ('{datetoday}', '{invClName.Text} vat:{invVat.Text} brn:{invbrn.Text}', '{sqlAddProdSales}', '{totalNet.Text}', '{tax.Text}', '{discountTE.Text}', '{(double.Parse(totalNet.Text)) - costp}', '{users.Text}', {paymethod.Text})");
                            }
                            //var client = new WebClient();
                            //var content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=SALE!%0AClient: {invClName.Text}%0A----------------------%0A{sqlAddProdSales}%0A----------------------%0ADiscount: {discountTE.Text}%0ANet Total: Rs.{totalNet.Text}%0A----------------------");
                            MessageBox.Show("Sale recorded.");

                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                string salesidtxt;
                                if (connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC") == null)
                                {
                                    salesidtxt = "9999";
                                }
                                else
                                {
                                    salesidtxt = connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC").ToString();
                                }

                                salesid = double.Parse(salesidtxt);

                            }
                            salesid = salesid + 1;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sale Not recorded Or Connection Failed!");
                        }
                    }
                    if(receipt.Checked == true)
                    {
                        try
                        {
                            var pdfReceipt = new Document(PageSize.A4, 40f, 25f, 40f, 30f);
                            string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\RECEIPTS\\R{salesid}.pdf";
                            PdfWriter.GetInstance(pdfReceipt, new FileStream(path, FileMode.OpenOrCreate));
                            pdfReceipt.Open();

                            var imagepth = @"C:\Users\maste\OneDrive\Desktop\TOOLS SPECIALIST OP\RESOURCES\RECEIPT.jpg";
                            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                            {
                                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                jpg.ScaleToFit(pdfReceipt.PageSize);
                                jpg.SetAbsolutePosition(0, 0);
                                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                                pdfReceipt.Add(jpg);
                            }
                            var spacer = new Paragraph("")
                            {
                                SpacingBefore = 1f,
                                SpacingAfter = 1f,
                            };
                            var spacersmol = new Paragraph("")
                            {
                                SpacingBefore = 0.1f,
                                SpacingAfter = 0.1f,
                            };
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            Font titleFont = FontFactory.GetFont("Courier", 10);

                            Paragraph title = new Paragraph($"                                    {datetoday}                   R{salesid}", titleFont);

                            title.Alignment = 1;
                            pdfReceipt.Add(title);

                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            Font titleFontname = FontFactory.GetFont("Courier", 16);
                            Paragraph companyname = new Paragraph($"          {invClName.Text}", titleFontname);

                            companyname.Alignment = 0;
                            companyname.Font = FontFactory.GetFont("Courier", 12);

                            pdfReceipt.Add(companyname);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);

                            double amount = double.Parse(totalNet.Text);
                            int amount1 = (int)amount;
                            amount = (amount - amount1) * 100; //remainder
                            string amt = amount1.ToWords();
                            int amountcent;
                            amountcent = (int)amount;
                            string amtCent = amountcent.ToWords();
                            Paragraph amount_inWords = new Paragraph();
                            Font titleFontamt = FontFactory.GetFont("Courier", 12);
                            if (amountcent == 0)
                            {

                                string amtiw = $"{amt.ToUpper()} RUPEES ONLY";
                                float n = amtiw.Length;
                                if (n > 60)
                                {
                                    titleFontamt = FontFactory.GetFont("Courier", 9);
                                }
                                amount_inWords = new Paragraph($"{amt.ToUpper()} RUPEES ONLY", titleFontamt);
                            }
                            else
                            {
                                string amtiw = $"{amt.ToUpper()} RUPEES AND {amtCent.ToUpper()} CENTS ONLY";
                                float n = amtiw.Length;
                                if (n > 60)
                                {
                                    titleFontamt = FontFactory.GetFont("Courier", 9);
                                }
                                amount_inWords = new Paragraph($"{amt.ToUpper()} RUPEES AND {amtCent.ToUpper()} CENTS ONLY", titleFontamt);
                            }
                            titleFontamt = FontFactory.GetFont("Courier", 12);
                            amount_inWords.Alignment = 0;
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            pdfReceipt.Add(amount_inWords);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);


                            title = new Paragraph($"        {salesid}", titleFontamt);

                            title.Alignment = 0;
                            pdfReceipt.Add(title);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            pdfReceipt.Add(spacer);

                            title = new Paragraph($"                                                                                                  Rs. {totalNet.Text}/-");
                            title.Alignment = 0;
                            pdfReceipt.Add(title);





                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);



                            title = new Paragraph($"{paymethod.Text}", titleFontamt);
                            title.Alignment = 2;
                            pdfReceipt.Add(title);

                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);


                            //title = new Paragraph($"Rs.{totalReceipt.Text}", titleFontamt);
                            //title.Alignment = 2;
                            //pdfReceipt.Add(title);

                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            //title = new Paragraph($"Rs.{bal}", titleFontamt);
                            //title.Alignment = 2;
                            //pdfReceipt.Add(title);

                            ///////////////////////////////END OF CUSTOMER COPY/////////////////////////


                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer); pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacersmol);

                            /////////////////////////////////MERCHANT COPY///////////////////////////////
                            title = new Paragraph($"                                    {datetoday}                   R{salesid}", titleFont);

                            title.Alignment = 1;
                            pdfReceipt.Add(title);

                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            titleFontname = FontFactory.GetFont("Courier", 16);
                            companyname = new Paragraph($"          {invClName.Text}", titleFontname);

                            companyname.Alignment = 0;
                            companyname.Font = FontFactory.GetFont("Courier", 12);

                            pdfReceipt.Add(companyname);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);

                            amount = double.Parse(totalNet.Text);
                            amount1 = (int)amount;
                            amount = (amount - amount1) * 100; //remainder
                            amt = amount1.ToWords();

                            amountcent = (int)amount;
                            amtCent = amountcent.ToWords();
                            amount_inWords = new Paragraph();
                            titleFontamt = FontFactory.GetFont("Courier", 12);
                            if (amountcent == 0)
                            {

                                string amtiw = $"{amt.ToUpper()} RUPEES ONLY";
                                float n = amtiw.Length;
                                if (n > 60)
                                {
                                    titleFontamt = FontFactory.GetFont("Courier", 9);
                                }
                                amount_inWords = new Paragraph($"{amt.ToUpper()} RUPEES ONLY", titleFontamt);
                            }
                            else
                            {
                                string amtiw = $"{amt.ToUpper()} RUPEES AND {amtCent.ToUpper()} CENTS ONLY";
                                float n = amtiw.Length;
                                if (n > 60)
                                {
                                    titleFontamt = FontFactory.GetFont("Courier", 9);
                                }
                                amount_inWords = new Paragraph($"{amt.ToUpper()} RUPEES AND {amtCent.ToUpper()} CENTS ONLY", titleFontamt);
                            }
                            titleFontamt = FontFactory.GetFont("Courier", 12);
                            amount_inWords.Alignment = 0;
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            pdfReceipt.Add(amount_inWords);
                            pdfReceipt.Add(spacersmol);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);


                            title = new Paragraph($"        {salesid}", titleFontamt);

                            title.Alignment = 0;
                            pdfReceipt.Add(title);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            pdfReceipt.Add(spacer);

                            title = new Paragraph($"                                                                                                  Rs. {totalNet.Text}/-");
                            title.Alignment = 0;
                            pdfReceipt.Add(title);





                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);



                            title = new Paragraph($"{paymethod.Text}", titleFontamt);
                            title.Alignment = 2;
                            pdfReceipt.Add(title);


                            pdfReceipt.Close();

                            System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\RECEIPTS\\R{salesid}.pdf");

                            //var client = new WebClient();
                            //var content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=SALE!%0AClient: {invClName.Text}%0A----------------------%0A{sqlAddProdSales}%0A----------------------%0ADiscount: {discountTE.Text}%0ANet Total: Rs.{totalNet.Text}%0A----------------------");
                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                connection.Query($"{sqlAddProd}");
                                connection.Query($"INSERT INTO sales(date, customer, products_sold, netamount, taxamount, discount, margin, salesperson, paymentmethod) VALUES ('{datetoday}', '{invClName.Text} vat:{invVat.Text} brn:{invbrn.Text}', '{sqlAddProdSales}', '{totalNet.Text}', '{tax.Text}', '{discountTE.Text}', '{(double.Parse(totalNet.Text)) - costp}', '{users.Text}', {paymethod.Text})");
                            }
                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                string salesidtxt;
                                if (connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC") == null)
                                {
                                    salesidtxt = "9999";
                                }
                                else
                                {
                                    salesidtxt = connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC").ToString();
                                }

                                salesid = double.Parse(salesidtxt);

                            }
                            salesid = salesid + 1;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Generating PDF of Receipt. Please check if all credentials were correctly entered and recreate a new receipt.");
                        }
                    }
                    if (vatinv.Checked == true)
                    {
                        try
                        {
                            var pdfInvoice = new Document(PageSize.A4, 50f, 50f, 45f, 50f);
                            string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\INVOICES\\INV{salesid}.pdf";
                            PdfWriter.GetInstance(pdfInvoice, new FileStream(path, FileMode.OpenOrCreate));
                            pdfInvoice.Open();

                            var imagepth = @"C:\Users\maste\OneDrive\Desktop\TOOLS SPECIALIST OP\RESOURCES\invoice.jpg";
                            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                            {
                                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                jpg.ScaleToFit(pdfInvoice.PageSize);
                                jpg.SetAbsolutePosition(0, 0);
                                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                                pdfInvoice.Add(jpg);
                            }

                            var spacer = new Paragraph("")
                            {
                                SpacingBefore = 10f,
                                SpacingAfter = 10f,
                            };
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);

                            Font titleFont = FontFactory.GetFont("Helvetica", 12);


                            Paragraph title = new Paragraph($"Customer Copy", titleFont);

                            title.Alignment = 2;
                            pdfInvoice.Add(title);

                            pdfInvoice.Add(spacer);


                            titleFont = FontFactory.GetFont("Helvetica", 9);

                            var spacerx = new Paragraph("")
                            {
                                SpacingBefore = 2f,
                                SpacingAfter = 2f,
                            };
                            pdfInvoice.Add(spacerx);
                            pdfInvoice.Add(spacerx);

                            Paragraph dateToday = new Paragraph($"{DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                            dateToday.Alignment = 2;

                            pdfInvoice.Add(dateToday);

                            pdfInvoice.Add(spacerx);

                            var spacer4 = new Paragraph("")
                            {
                                SpacingBefore = 0.5f,
                                SpacingAfter = 0.5f,
                            };

                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            var invoicenum = new Paragraph($"INV{salesid}", titleFont);
                            invoicenum.Alignment = 2;
                            pdfInvoice.Add(invoicenum);

                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            Paragraph compName = new Paragraph($"                                            {invClName.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);



                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);

                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                                            {invNum.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                                            {invCity.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            compName = new Paragraph($"                                            {invVat.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                                            {invbrn.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);
                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);


                            //Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);

                            PdfPTable producttable = new PdfPTable(productlist.ColumnCount);
                            producttable.DefaultCell.Padding = 8;
                            producttable.WidthPercentage = 100;
                            producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                            producttable.DefaultCell.BorderWidth = 0;
                            BaseColor couleur = new BaseColor(255, 255, 255);
                            Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                            foreach (DataGridViewColumn column in productlist.Columns)
                            {
                                cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                                producttable.AddCell(cell);
                            }
                            float[] widths = new float[] { 0.65f, 3.5f, 0.80f, 0.80f };
                            producttable.SetWidths(widths);


                            foreach (DataGridViewRow row in productlist.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string text = cell.Value.ToString();

                                    producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                                }
                            }

                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                            pdfInvoice.Add(producttable);

                            PdfPTable tabletotal = new PdfPTable(2);
                            tabletotal.DefaultCell.Padding = 8;
                            tabletotal.WidthPercentage = 40;
                            tabletotal.HorizontalAlignment = Element.ALIGN_RIGHT;

                            tabletotal.DefaultCell.BorderWidth = 1;
                            couleur = new BaseColor(0, 0, 0);
                            titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                            widths = new float[] { 1.5f, 1f };
                            tabletotal.SetWidths(widths);

                            cell = new PdfPCell(new Phrase("SUB-TOTAL:", titleFont3));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255);
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{totalTE.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("DISCOUNT:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{discountTE.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("TAX:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{tax.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("NET TOTAL:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{totalNet.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);


                            pdfInvoice.Add(tabletotal);

                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                            title = new Paragraph($"Payment Method: {paymethod.Text}", titleFont);

                            title.Alignment = 2;
                            pdfInvoice.Add(title);


                            pdfInvoice.NewPage();
                            //////////////////////////////////////////////////////NEW PAGE////////////////////////////////////////////////////////

                            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                            {
                                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                jpg.ScaleToFit(pdfInvoice.PageSize);
                                jpg.SetAbsolutePosition(0, 0);
                                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                                pdfInvoice.Add(jpg);
                            }

                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);

                            titleFont = FontFactory.GetFont("Helvetica", 12);


                            title = new Paragraph($"Customer Copy", titleFont);

                            title.Alignment = 2;
                            pdfInvoice.Add(title);

                            pdfInvoice.Add(spacer);


                            titleFont = FontFactory.GetFont("Helvetica", 9);


                            pdfInvoice.Add(spacerx);
                            pdfInvoice.Add(spacerx);

                            dateToday = new Paragraph($"{DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                            dateToday.Alignment = 2;

                            pdfInvoice.Add(dateToday);

                            pdfInvoice.Add(spacerx);



                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            invoicenum = new Paragraph($"INV{salesid}", titleFont);
                            invoicenum.Alignment = 2;
                            pdfInvoice.Add(invoicenum);

                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            compName = new Paragraph($"                                            {invClName.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);



                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);

                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                                            {invNum.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                                            {invCity.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            compName = new Paragraph($"                                            {invVat.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                                            {invbrn.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);
                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);


                            //Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);

                            producttable = new PdfPTable(productlist.ColumnCount);
                            producttable.DefaultCell.Padding = 8;
                            producttable.WidthPercentage = 100;
                            producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                            producttable.DefaultCell.BorderWidth = 0;
                            couleur = new BaseColor(255, 255, 255);
                            titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                            foreach (DataGridViewColumn column in productlist.Columns)
                            {
                                cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                                producttable.AddCell(cell);
                            }
                            widths = new float[] { 0.65f, 3.5f, 0.80f, 0.80f };
                            producttable.SetWidths(widths);


                            foreach (DataGridViewRow row in productlist.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string text = cell.Value.ToString();

                                    producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                                }
                            }

                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                            pdfInvoice.Add(producttable);

                            tabletotal = new PdfPTable(2);
                            tabletotal.DefaultCell.Padding = 8;
                            tabletotal.WidthPercentage = 40;
                            tabletotal.HorizontalAlignment = Element.ALIGN_RIGHT;

                            tabletotal.DefaultCell.BorderWidth = 1;
                            couleur = new BaseColor(0, 0, 0);
                            titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                            widths = new float[] { 1.5f, 1f };
                            tabletotal.SetWidths(widths);

                            cell = new PdfPCell(new Phrase("SUB-TOTAL:", titleFont3));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255);
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{totalTE.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("DISCOUNT:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);
                            double disco = double.Parse(discountTE.Text);
                            cell = new PdfPCell(new Phrase($"{disco / 1.15}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("TAX:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{tax.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("NET TOTAL:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{totalNet.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);


                            pdfInvoice.Add(tabletotal);

                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                            title = new Paragraph($"Payment Method: {paymethod.Text}", titleFont);

                            title.Alignment = 2;
                            pdfInvoice.Add(title);



                            pdfInvoice.Close();

                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                connection.Query($"{sqlAddProd}");
                                connection.Query($"INSERT INTO sales(date, customer, products_sold, netamount, taxamount, discount, margin, salesperson, paymentmethod) VALUES ('{datetoday}', '{invClName.Text} vat:{invVat.Text} brn:{invbrn.Text}', '{sqlAddProdSales}', '{totalNet.Text}', '{tax.Text}', '{discountTE.Text}', '{(double.Parse(totalNet.Text)) - costp}', '{users.Text}', '{paymethod.Text}')");
                            }


                            System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\INVOICES\\INV{salesid}.pdf");

                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                string salesidtxt;
                                if (connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC") == null)
                                {
                                    salesidtxt = "9999";
                                }
                                else
                                {
                                    salesidtxt = connection.ExecuteScalar($"SELECT TOP 1 saleID FROM sales ORDER BY saleID DESC").ToString();
                                }

                                salesid = double.Parse(salesidtxt);

                            }
                            salesid = salesid + 1;
                            //var client = new WebClient();
                            //var content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=SALE!%0AClient: {invClName.Text}%0A----------------------%0A{sqlAddProdSales}%0A----------------------%0ADiscount: {discountTE.Text}%0ANet Total: Rs.{totalNet.Text}%0A----------------------");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error approving transaction for VAT INVOICE!");
                        }


                    }


                }
                if (quotation.Checked==true)
                {
                    Random rnd = new Random();
                    int saveno = rnd.Next(1, 51);
                    var pdfInvoice = new Document(PageSize.A4, 50f, 50f, 45f, 50f);
                    string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\QUOTATION\\quotation{salesid}{saveno}.pdf";
                    PdfWriter.GetInstance(pdfInvoice, new FileStream(path, FileMode.OpenOrCreate));
                    pdfInvoice.Open();

                    var imagepth = @"C:\Users\maste\OneDrive\Desktop\TOOLS SPECIALIST OP\RESOURCES\quotation.jpg";
                    using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                    {
                        var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                        jpg.ScaleToFit(pdfInvoice.PageSize);
                        jpg.SetAbsolutePosition(0, 0);
                        jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                        pdfInvoice.Add(jpg);
                    }

                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);
                    

                    Font titleFont = FontFactory.GetFont("Helvetica", 12);


                    Paragraph title = new Paragraph($"", titleFont);

                    title.Alignment = 2;
                    pdfInvoice.Add(title);

                    pdfInvoice.Add(spacer);


                    titleFont = FontFactory.GetFont("Helvetica", 9);

                    var spacerx = new Paragraph("")
                    {
                        SpacingBefore = 2f,
                        SpacingAfter = 2f,
                    };
                    

                    Paragraph dateToday = new Paragraph($"{DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                    dateToday.Alignment = 2;

                    pdfInvoice.Add(dateToday);

                    var spacer4 = new Paragraph("")
                    {
                        SpacingBefore = 0.5f,
                        SpacingAfter = 0.5f,
                    };

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer);

                    Paragraph compName = new Paragraph($"                                            {invClName.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);



                    pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4);

                    pdfInvoice.Add(spacerx);

                    compName = new Paragraph($"                                            {invNum.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacerx);

                    compName = new Paragraph($"                                            {invCity.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    compName = new Paragraph($"                                            {invVat.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacerx);

                    compName = new Paragraph($"                                            {invbrn.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);
                    pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);


                    //Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);

                    PdfPTable producttable = new PdfPTable(productlist.ColumnCount);
                    producttable.DefaultCell.Padding = 8;
                    producttable.WidthPercentage = 100;
                    producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                    producttable.DefaultCell.BorderWidth = 0;
                    BaseColor couleur = new BaseColor(255, 255, 255);
                    Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                    foreach (DataGridViewColumn column in productlist.Columns)
                    {
                        cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                        producttable.AddCell(cell);
                    }
                    float[] widths = new float[] { 0.65f, 3.5f, 0.80f, 0.80f };
                    producttable.SetWidths(widths);


                    foreach (DataGridViewRow row in productlist.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string text = cell.Value.ToString();

                            producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                        }
                    }

                    pdfInvoice.Add(spacerx);
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(producttable);

                    PdfPTable tabletotal = new PdfPTable(2);
                    tabletotal.DefaultCell.Padding = 8;
                    tabletotal.WidthPercentage = 40;
                    tabletotal.HorizontalAlignment = Element.ALIGN_RIGHT;

                    tabletotal.DefaultCell.BorderWidth = 1;
                    couleur = new BaseColor(0, 0, 0);
                    titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                    widths = new float[] { 1.5f, 1f };
                    tabletotal.SetWidths(widths);

                    //cell = new PdfPCell(new Phrase("SUB-TOTAL:", titleFont3));
                    //cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255);
                    //cell.HorizontalAlignment = 2;
                    //tabletotal.AddCell(cell);

                    //cell = new PdfPCell(new Phrase($"{totalTE.Text}", titleFont3));
                    //cell.HorizontalAlignment = 2;
                    //tabletotal.AddCell(cell);

                    //cell = new PdfPCell(new Phrase("DISCOUNT:", titleFont3));
                    //cell.HorizontalAlignment = 2;
                    //tabletotal.AddCell(cell);

                    //cell = new PdfPCell(new Phrase($"{discountTE.Text}", titleFont3));
                    //cell.HorizontalAlignment = 2;
                    //tabletotal.AddCell(cell);

                    //cell = new PdfPCell(new Phrase("TAX:", titleFont3));
                    //cell.HorizontalAlignment = 2;
                    //tabletotal.AddCell(cell);

                    //cell = new PdfPCell(new Phrase($"{tax.Text}", titleFont3));
                    //cell.HorizontalAlignment = 2;
                    //tabletotal.AddCell(cell);

                    cell = new PdfPCell(new Phrase("NET TOTAL:", titleFont3));
                    cell.HorizontalAlignment = 2;
                    tabletotal.AddCell(cell);

                    cell = new PdfPCell(new Phrase($"{totalNet.Text}", titleFont3));
                    cell.HorizontalAlignment = 2;
                    tabletotal.AddCell(cell);


                    pdfInvoice.Add(tabletotal);

                    pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                    //title = new Paragraph($"Payment Method: {paymethod.Text}", titleFont);

                    //title.Alignment = 2;
                    pdfInvoice.Close();
                    System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\QUOTATION\\quotation{salesid}{saveno}.pdf");


                }

                if (radioButton1.Checked==true)
                {
                    double reserID = 0;
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        string residtxt;
                        if (connection.ExecuteScalar($"SELECT TOP 1 reservationID FROM reserve ORDER BY reservationID DESC") == null)
                        {
                            residtxt = "0";
                        }
                        else
                        {
                            residtxt = connection.ExecuteScalar($"SELECT TOP 1 reservationID FROM reserve ORDER BY reservationID DESC").ToString();
                        }

                        reserID = double.Parse(residtxt);

                    }
                    reserID = reserID + 1;

                    var pdfInvoice = new Document(PageSize.A4, 50f, 65f, 13f, 50f);
                    string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\RESERVATIONS\\reservation{reserID}.pdf";
                    PdfWriter.GetInstance(pdfInvoice, new FileStream(path, FileMode.OpenOrCreate));
                    pdfInvoice.Open();

                    var imagepth = @"C:\Users\maste\OneDrive\Desktop\TOOLS SPECIALIST OP\RESOURCES\reservation.jpg";
                    using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                    {
                        var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                        jpg.ScaleToFit(pdfInvoice.PageSize);
                        jpg.SetAbsolutePosition(0, 0);
                        jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                        pdfInvoice.Add(jpg);
                    }

                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    
                    
                    


                    Font titleFont = FontFactory.GetFont("Helvetica", 12);


                    Paragraph title = new Paragraph($"", titleFont);

                    title.Alignment = 2;
                    pdfInvoice.Add(title);

                    pdfInvoice.Add(spacer);


                    titleFont = FontFactory.GetFont("Helvetica", 9);

                    var spacerx = new Paragraph("")
                    {
                        SpacingBefore = 2f,
                        SpacingAfter = 2f,
                    };


                    Paragraph dateToday = new Paragraph($"{DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                    dateToday.Alignment = 2;

                    pdfInvoice.Add(dateToday);

                    var spacer4 = new Paragraph("")
                    {
                        SpacingBefore = 0.5f,
                        SpacingAfter = 0.5f,
                    };

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    var invoicenum = new Paragraph($"{reserID}", titleFont);
                    invoicenum.Alignment = 2;
                    pdfInvoice.Add(invoicenum);

                    pdfInvoice.Add(spacer); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    Paragraph compName = new Paragraph($"                          {invClName.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    compName = new Paragraph($"                          {invNum.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    string sqlAddProdSales2 = sqlAddProdSales;
                    compName = new Paragraph($"                          {sqlAddProdSales2}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    compName = new Paragraph($"                          Rs.{reserveAmt.Text} (Remaining: Rs.{(double.Parse(totalNet.Text) - double.Parse(reserveAmt.Text))})", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(dateToday);

                   

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    invoicenum = new Paragraph($"{reserID}", titleFont);
                    invoicenum.Alignment = 2;
                    pdfInvoice.Add(invoicenum);

                    pdfInvoice.Add(spacer); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    compName = new Paragraph($"                          {invClName.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    compName = new Paragraph($"                          {invNum.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    sqlAddProdSales2 = sqlAddProdSales;
                    compName = new Paragraph($"                          {sqlAddProdSales2}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    compName = new Paragraph($"                          Rs.{reserveAmt.Text} (Remaining: Rs.{(double.Parse(totalNet.Text) - double.Parse(reserveAmt.Text))})", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer); pdfInvoice.Add(spacer); pdfInvoice.Add(spacer); pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer); pdfInvoice.Add(spacer); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                    pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                    titleFont = FontFactory.GetFont("Helvetica", 20);
                    compName = new Paragraph($" {invClName.Text}", titleFont);
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);


                    pdfInvoice.Close();
                    System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\RESERVATIONS\\reservation{reserID}.pdf");

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        connection.Query($"INSERT INTO reserve(name, deposit, remainingbal) VALUES ('{invClName.Text}', '{reserveAmt.Text}', '{(double.Parse(totalNet.Text))-(double.Parse(reserveAmt.Text))}')");

                     

                    }
                    var client = new WebClient();
                    var content = client.DownloadString($"https://api.telegram.org/bot1730758408:AAHiT90iD2---QpV0EjX1k0ZbulRe4hbn_s/sendMessage?chat_id=-1001563600716&text=RESERVATION!%0AClient: {invClName.Text}%0A----------------------%0A{sqlAddProdSales}%0A----------------------%0ADeposit Amount: {reserveAmt.Text}%0ARemaining: Rs.{(double.Parse(totalNet.Text) - double.Parse(reserveAmt.Text))}%0ANet Total: Rs.{totalNet.Text} (Not Settled)%0A----------------------");

                }

            }
            else
            {
                MessageBox.Show($"Wrong password for username {users.Text}!");
            }
            //choice = MessageBox.Show($"Approve Transaction?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (1==0)
            {


                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {
                    connection.Query($"INSERT INTO invoice_record(date, company_name1, net_amount, Tax, balance_remaining, duedate) VALUES ('01/02/03', '{ invClName.Text }', '{ totalNet.Text }', '{tax.Text}', '{totalNet.Text}', '01/02/03')");

                    string invoicetext = connection.ExecuteScalar($"SELECT TOP 1 invoice_no FROM invoice_record ORDER BY invoice_no DESC").ToString();
                    connection.Query($"INSERT INTO statement(Date, Company, Type, Reference, Value) VALUES ('01/02/03', '{invClName.Text}', 'Sales Invoice', '{invoicetext}', '{totalNet.Text}')");
                    //try
                    //{
                    var pdfInvoice = new Document(PageSize.A4, 40f, 40f, 45f, 50f);
                    string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\INVOICES\\{invoicetext.TrimEnd(' ')}.pdf";
                    PdfWriter.GetInstance(pdfInvoice, new FileStream(path, FileMode.OpenOrCreate));
                    pdfInvoice.Open();


                    var imagepth = @"C:\Users\maste\OneDrive\Desktop\INVOICING SOFTWARE\RESOURCES\BACKGROUNDIMAGE\invoice temp.jpg";
                    using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                    {
                        var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                        jpg.ScaleToFit(pdfInvoice.PageSize);
                        jpg.SetAbsolutePosition(0, 0);
                        jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                        pdfInvoice.Add(jpg);
                    }

                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);




                    Font titleFont = FontFactory.GetFont("Helvetica", 20);

                    Paragraph title = new Paragraph($"", titleFont);

                    //title.Alignment = 0;


                    //pdfInvoice.Add(title);
                    title.Font = FontFactory.GetFont("Courier", 12);
                    titleFont = FontFactory.GetFont("Courier", 12);
                    title = new Paragraph($"CUSTOMER COPY", titleFont);
                    title.Alignment = 2;
                    pdfInvoice.Add(title);

                    var spacerx = new Paragraph("")
                    {
                        SpacingBefore = 2f,
                        SpacingAfter = 2f,
                    };
                    pdfInvoice.Add(spacerx);




                    //Font f = new Font(FontFamily.GenericSerif, 10, Font.Bold);
                    //invoicenum.Font = FontFactory.GetFont("Courier", 16);
                    //title.Add(new Chunk(glue));
                    Paragraph dateToday = new Paragraph($"", titleFont);
                    dateToday.Alignment = 2;
                    pdfInvoice.Add(dateToday);
                    var spacer2 = new Paragraph("")
                    {
                        SpacingBefore = 4f,
                        SpacingAfter = 4f,
                    };
                    pdfInvoice.Add(spacer2);

                    var invoicenum = new Paragraph($"{invoicetext}", titleFont);
                    invoicenum.Alignment = 2;
                    pdfInvoice.Add(invoicenum);

                    pdfInvoice.Add(spacer2);

                    Paragraph due = new Paragraph($"", titleFont);
                    due.Alignment = 2;
                    pdfInvoice.Add(due);

                    var spacer3 = new Paragraph("")
                    {
                        SpacingBefore = 18f,
                        SpacingAfter = 4f,
                    };
                    pdfInvoice.Add(spacer3);
                    pdfInvoice.Add(spacer3);

                    Paragraph compName = new Paragraph($"{invClName.Text}");
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    var spacer4 = new Paragraph("")
                    {
                        SpacingBefore = 0.5f,
                        SpacingAfter = 0.5f,
                    };
                    Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);
                    pdfInvoice.Add(spacer4);

                    Paragraph compBRN = new Paragraph($"BRN: {invbrn.Text}", titleFont2);
                    compBRN.Alignment = 0;
                    pdfInvoice.Add(compBRN);
                    pdfInvoice.Add(spacer4);

                    Paragraph compVAT = new Paragraph($"VAT No: {invVat.Text}", titleFont2);
                    compVAT.Alignment = 0;
                    pdfInvoice.Add(compVAT);
                    pdfInvoice.Add(spacer4);

                    //Paragraph compStreet = new Paragraph($"{invStreet.Text}", titleFont2);
                    //compStreet.Alignment = 0;
                    //pdfInvoice.Add(compStreet);
                    //pdfInvoice.Add(spacer4);

                    Paragraph compCity = new Paragraph($"{invCity.Text}", titleFont2);
                    compCity.Alignment = 0;
                    pdfInvoice.Add(compCity);
                    pdfInvoice.Add(spacer4);

                    Paragraph compNum = new Paragraph($"+230 {invNum.Text}", titleFont2);
                    compNum.Alignment = 0;
                    pdfInvoice.Add(compNum);
                    pdfInvoice.Add(spacer2);

                    PdfPTable producttable = new PdfPTable(productlist.ColumnCount);
                    producttable.DefaultCell.Padding = 3;
                    producttable.WidthPercentage = 100;
                    producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                    producttable.DefaultCell.BorderWidth = 0;
                    BaseColor couleur = new BaseColor(255, 255, 255);
                    Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 12, couleur);
                    foreach (DataGridViewColumn column in productlist.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                        producttable.AddCell(cell);
                    }
                    float[] widths = new float[] { 0.65f, 3.5f, 0.80f, 0.80f };
                    producttable.SetWidths(widths);

                    foreach (DataGridViewRow row in productlist.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string text = cell.Value.ToString();

                            producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                        }
                    }

                    pdfInvoice.Add(producttable);

                    Chunk compDiscount = new Chunk($"DISCOUNT: \t\tRs. {discountTE.Text}", titleFont);
                    compDiscount.SetUnderline(1, -2);
                    Paragraph compDiscount1 = new Paragraph(compDiscount);
                    compDiscount1.Alignment = 2;
                    pdfInvoice.Add(compDiscount1);

                    //Chunk compSubtotal = new Chunk($"SUBTOTAL: \t\tRs. {subTotal.Text}", titleFont);
                    //compSubtotal.SetUnderline(1, -2);
                    //Paragraph compSubtotal1 = new Paragraph(compSubtotal);
                    //compSubtotal1.Alignment = 2;
                    //pdfInvoice.Add(compSubtotal1);

                    Chunk compTax = new Chunk($"TAX(15%): \tRs. {tax.Text}", titleFont);
                    compTax.SetUnderline(1, -2);
                    Paragraph compTax1 = new Paragraph(compTax);
                    compTax1.Alignment = 2;
                    pdfInvoice.Add(compTax1);

                    Chunk compTotal = new Chunk($"NET AMOUNT: \t\tRs. {totalNet.Text}", titleFont);
                    compTotal.SetUnderline(1, -2);
                    Paragraph compTotal1 = new Paragraph(compTotal);
                    compTotal1.Alignment = 2;
                    pdfInvoice.Add(compTotal1);

                    pdfInvoice.Add(spacer);

                    couleur = new BaseColor(0, 0, 0);
                    titleFont3 = FontFactory.GetFont("Helvetica Bold", 12, couleur);
                    Paragraph lastline = new Paragraph("In case of recovery of the total amount due or part of it, all fees and commissions due to the solicitor and/or any other institutions will be payable by the buyer.", titleFont3);
                    pdfInvoice.Add(lastline);

                    lastline = new Paragraph("Received goods in good order and condition.", titleFont3);
                    pdfInvoice.Add(lastline);

                    pdfInvoice.NewPage();
                    /////////////////////////////////////////////////NEWPAGE///////////////////////////////////////////////////////////
                    using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                    {
                        var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                        jpg.ScaleToFit(pdfInvoice.PageSize);
                        jpg.SetAbsolutePosition(0, 0);
                        jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                        pdfInvoice.Add(jpg);
                    }
                    pdfInvoice.Add(spacer);
                    pdfInvoice.Add(spacer);

                    titleFont = FontFactory.GetFont("Helvetica", 20);

                    title = new Paragraph($"", titleFont);

                    title.Alignment = 0;


                    //pdfInvoice.Add(title);
                    title.Font = FontFactory.GetFont("Courier", 12);
                    titleFont = FontFactory.GetFont("Courier", 12);
                    title = new Paragraph($"MERCHANT COPY", titleFont);
                    title.Alignment = 2;
                    pdfInvoice.Add(title);


                    pdfInvoice.Add(spacerx);




                    //Font f = new Font(FontFamily.GenericSerif, 10, Font.Bold);
                    //invoicenum.Font = FontFactory.GetFont("Courier", 16);
                    //title.Add(new Chunk(glue));
                    dateToday = new Paragraph($"date", titleFont);
                    dateToday.Alignment = 2;
                    pdfInvoice.Add(dateToday);

                    pdfInvoice.Add(spacer2);

                    invoicenum = new Paragraph($"{invoicetext}", titleFont);
                    invoicenum.Alignment = 2;
                    pdfInvoice.Add(invoicenum);

                    pdfInvoice.Add(spacer2);

                    due = new Paragraph($"due", titleFont);
                    due.Alignment = 2;
                    pdfInvoice.Add(due);


                    pdfInvoice.Add(spacer3);
                    pdfInvoice.Add(spacer3);

                    compName = new Paragraph($"{invClName.Text}");
                    compName.Alignment = 0;
                    pdfInvoice.Add(compName);

                    titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);
                    pdfInvoice.Add(spacer4);

                    compBRN = new Paragraph($"BRN: {invbrn.Text}", titleFont2);
                    compBRN.Alignment = 0;
                    pdfInvoice.Add(compBRN);
                    pdfInvoice.Add(spacer4);

                    compVAT = new Paragraph($"VAT No: {invVat.Text}", titleFont2);
                    compVAT.Alignment = 0;
                    pdfInvoice.Add(compVAT);
                    pdfInvoice.Add(spacer4);

                    //compStreet = new Paragraph($"{invStreet.Text}", titleFont2);
                    //compStreet.Alignment = 0;
                    //pdfInvoice.Add(compStreet);
                    //pdfInvoice.Add(spacer4);

                    compCity = new Paragraph($"{invCity.Text}", titleFont2);
                    compCity.Alignment = 0;
                    pdfInvoice.Add(compCity);
                    pdfInvoice.Add(spacer4);

                    compNum = new Paragraph($"+230 {invNum.Text}", titleFont2);
                    compNum.Alignment = 0;
                    pdfInvoice.Add(compNum);
                    pdfInvoice.Add(spacer2);

                    producttable = new PdfPTable(productlist.ColumnCount);
                    producttable.DefaultCell.Padding = 3;
                    producttable.WidthPercentage = 100;
                    producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                    producttable.DefaultCell.BorderWidth = 0;
                    couleur = new BaseColor(255, 255, 255);
                    titleFont3 = FontFactory.GetFont("Helvetica Bold", 12, couleur);

                    foreach (DataGridViewColumn column in productlist.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                        producttable.AddCell(cell);
                    }
                    widths = new float[] { 0.65f, 3.5f, 0.80f, 0.80f };
                    producttable.SetWidths(widths);

                    foreach (DataGridViewRow row in productlist.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string text = cell.Value.ToString();

                            producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                        }
                    }

                    pdfInvoice.Add(producttable);

                    compDiscount = new Chunk($"DISCOUNT: \t\tRs. {discountTE.Text}", titleFont);
                    compDiscount.SetUnderline(1, -2);
                    compDiscount1 = new Paragraph(compDiscount);
                    compDiscount1.Alignment = 2;
                    pdfInvoice.Add(compDiscount1);

                    //compSubtotal = new Chunk($"SUBTOTAL: \t\tRs. {subTotal.Text}", titleFont);
                    //compSubtotal.SetUnderline(1, -2);
                    //compSubtotal1 = new Paragraph(compSubtotal);
                    //compSubtotal1.Alignment = 2;
                    //pdfInvoice.Add(compSubtotal1);


                    compTax = new Chunk($"TAX(15%): \tRs. {tax.Text}", titleFont);
                    compTax.SetUnderline(1, -2);
                    compTax1 = new Paragraph(compTax);
                    compTax1.Alignment = 2;
                    pdfInvoice.Add(compTax1);

                    compTotal = new Chunk($"NET AMOUNT: \t\tRs. {totalNet.Text}", titleFont);
                    compTotal.SetUnderline(1, -2);
                    compTotal1 = new Paragraph(compTotal);
                    compTotal1.Alignment = 2;
                    pdfInvoice.Add(compTotal1);

                    pdfInvoice.Add(spacer);


                    couleur = new BaseColor(0, 0, 0);
                    titleFont3 = FontFactory.GetFont("Helvetica Bold", 12, couleur);
                    lastline = new Paragraph("In case of recovery of the total amount due or part of it, all fees and commissions due to the solicitor and/or any other institutions will be payable by the buyer.", titleFont3);
                    pdfInvoice.Add(lastline);

                    lastline = new Paragraph("Received goods in good order and condition.", titleFont3);
                    pdfInvoice.Add(lastline);

                    pdfInvoice.Close();

                    System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\INVOICES\\{invoicetext.TrimEnd(' ')}.pdf");


                }
                //catch (Exception)
                //{
                //    MessageBox.Show("Error Generating PDF of Invoice. Please check if all credentials were correctly entered and recreate a new invoice.");
                //}
                
            }
        Here:;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void productlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void invSku_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void invUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void invBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void invProdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                            invUnitPrice.Text = connection.ExecuteScalar($"SELECT sellingprice FROM product WHERE sku = '{invSku.Text}'").ToString();
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox1.ForeColor = Color.Black;

            textBox1.PasswordChar = '●';
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                reserveAmt.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
                button4.Visible = true;
            }
            else
            {

                reserveAmt.Visible = false;
                label5.Visible = false;
                textBox2.Visible = false;
                button4.Visible = false;

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {
                if ((connection.ExecuteScalar($"SELECT deposit FROM reserve WHERE reservationID = '{textBox2.Text}'") == null))
                {
                    
                    MessageBox.Show("Product does not exist in Database!");
                }
                else
                {
                    string name = connection.ExecuteScalar($"SELECT name FROM reserve WHERE reservationID = '{textBox2.Text}'").ToString();
                    string depo = connection.ExecuteScalar($"SELECT deposit FROM reserve WHERE reservationID = '{textBox2.Text}'").ToString();
                    string rem = connection.ExecuteScalar($"SELECT remainingbal FROM reserve WHERE reservationID = '{textBox2.Text}'").ToString();

                    MessageBox.Show($"Reservation ID: {textBox2.Text}\nName: {name}\nDeposit: Rs.{(double.Parse(depo)).ToString("#.00")}\nRemaining: Rs.{(double.Parse(rem)).ToString("#.00")}");
                }
            }

        }

        private void discountTE_TextChanged(object sender, EventArgs e)
        {
            decimal d;
            if ((decimal.TryParse(discountTE.Text, out d)))
            {
                double discou = double.Parse(discountTE.Text);
                percentdisc.Text = $"= {Math.Round((((discou / sum) * 100) *1.15), 2).ToString("#.00")}%";
            }
            else
            {
                percentdisc.Text = "NIL";
            }
        }
    }
}

        //private void label23_Click(object sender, EventArgs e)
        //{

        //}

        //private void label19_Click(object sender, EventArgs e)
        //{

        //}

        //private void TaxExemptedST_Click(object sender, EventArgs e)
        //{

        //}

        //private void tax_TextChanged(object sender, EventArgs e)
        //{

//        //}
//    }
//}
