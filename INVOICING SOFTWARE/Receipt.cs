using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using System.IO;
using System.Drawing.Imaging;
using Humanizer;

namespace INVOICING_SOFTWARE
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void genReceipt_Click(object sender, EventArgs e)
        {
            double bal = 0;
            DialogResult choice = MessageBox.Show($"Approve Payment of Rs. {amtPaid.Text}?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                decimal d;

                if (decimal.TryParse(amtPaid.Text, out d))
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        if (meanPay.Text != "Cheque")
                        {
                            connection.Query($"INSERT INTO receipt (invoice_no1, date_paid, amt_paid, means) VALUES ('{invoiceno.Text}', '{datePaidY.Text}/{datePaidM.Text}/{datepaidD.Text}', '{amtPaid.Text}', '{meanPay.Text}')");

                            bal = (double.Parse(balRemain.Text)) - (double.Parse(amtPaid.Text));
                            connection.Query($"UPDATE invoice_record SET balance_remaining = '{bal}' WHERE invoice_no = '{invoiceno.Text}'");
                            balRemain.Text = $"{bal}";
                        }
                        else
                        {
                            connection.Query($"INSERT INTO receipt (invoice_no1, date_paid, amt_paid, means, depoDate, chequeNo) VALUES ('{invoiceno.Text}', '{datePaidY.Text}/{datePaidM.Text}/{datepaidD.Text}', '{amtPaid.Text}', '{meanPay.Text}', '{chequedateY.Text}/{chequedateM.Text}/{chequedateD.Text}', '{chequeNo.Text} @ {bank.Text}')");

                            bal = (double.Parse(balRemain.Text)) - (double.Parse(amtPaid.Text));
                            connection.Query($"UPDATE invoice_record SET balance_remaining = '{bal}' WHERE invoice_no = '{invoiceno.Text}'");
                            balRemain.Text = $"{bal}";
                        }

                    }
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        string receiptno = connection.ExecuteScalar($"SELECT TOP 1 receipt_no FROM receipt ORDER BY receipt_no DESC").ToString();
                        connection.Query($"INSERT INTO statement(Date, Company, Type, Reference, Value) VALUES ('{datePaidY.Text}/{datePaidM.Text}/{datepaidD.Text}', '{receiptCompany.Text}', 'Payment {meanPay.Text}', '{receiptno}', '-{amtPaid.Text}')");
                        try
                        {
                            var pdfReceipt = new Document(PageSize.A4, 40f, 25f, 40f, 30f);
                            string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\RECEIPTS\\{receiptno.TrimEnd(' ')}.pdf";
                            PdfWriter.GetInstance(pdfReceipt, new FileStream(path, FileMode.OpenOrCreate));
                            pdfReceipt.Open();

                            var imagepth = @"C:\Users\maste\OneDrive\Desktop\INVOICING SOFTWARE\RESOURCES\BACKGROUNDIMAGE\RECEIPT.jpg";
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

                            Paragraph title = new Paragraph($"                                    {datepaidD.Text}/{datePaidM.Text}/{datePaidY.Text}                {receiptno}", titleFont);

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
                            Paragraph companyname = new Paragraph($"          {receiptCompany.Text}", titleFontname);

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

                            double amount = double.Parse(amtPaid.Text);
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


                            title = new Paragraph($"        {invoiceno.Text}                                  Rs. {amtPaid.Text}/-", titleFontamt);

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
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);
                            
                            

                            title = new Paragraph($"{meanPay.Text}", titleFontamt);
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


                            title = new Paragraph($"Rs.{totalReceipt.Text}", titleFontamt);
                            title.Alignment = 2;
                            pdfReceipt.Add(title);

                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);

                            title = new Paragraph($"Rs.{bal}", titleFontamt);
                            title.Alignment = 2;
                            pdfReceipt.Add(title);

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
                            pdfReceipt.Add(spacer);
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

                            ///////////////////////////////MERCHANT COPY///////////////////////////////

                            title = new Paragraph($"                                    {datepaidD.Text}/{datePaidM.Text}/{datePaidY.Text}                {receiptno}", titleFont);

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
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);

                            titleFontname = FontFactory.GetFont("Courier", 16);
                            companyname = new Paragraph($"          {receiptCompany.Text}", titleFontname);

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

                            amount = double.Parse(amtPaid.Text);
                            amount1 = (int)amount;
                            amount = (amount - amount1) * 100;
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


                            title = new Paragraph($"        {invoiceno.Text}                                  Rs. {amtPaid.Text}/-", titleFontamt);

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
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);



                            title = new Paragraph($"{meanPay.Text}", titleFontamt);
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


                            title = new Paragraph($"Rs.{totalReceipt.Text}", titleFontamt);
                            title.Alignment = 2;
                            pdfReceipt.Add(title);

                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacer);
                            pdfReceipt.Add(spacersmol);

                            title = new Paragraph($"Rs.{bal}", titleFontamt);
                            title.Alignment = 2;
                            pdfReceipt.Add(title);





                            pdfReceipt.Close();

                            System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\RECEIPTS\\{receiptno.TrimEnd(' ')}.pdf");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Generating PDF of Receipt. Please check if all credentials were correctly entered and recreate a new receipt.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Error inputing amount paid.");
                }
                    
                
                    



            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(invoiceno.Text, out d))
            {
                double a, b;
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {
                    string invoicetext = connection.ExecuteScalar($"SELECT TOP 1 invoice_no FROM invoice_record ORDER BY invoice_no DESC").ToString();
                    
                    a = double.Parse(invoicetext);
                    b = double.Parse(invoiceno.Text);
                }

                //try
                //{

                
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        if (connection.ExecuteScalar($"SELECT company_name1 FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'") == null)
                        {
                            receiptCompany.Text = "ERROR";
                        }
                        else
                        {
                            receiptCompany.Text = connection.ExecuteScalar($"SELECT company_name1 FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'").ToString();
                        }

                        if (connection.ExecuteScalar($"SELECT date FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'") == null)
                        {
                            issueDate.Text = "ERROR";
                        }
                        else
                        {
                            issueDate.Text = connection.ExecuteScalar($"SELECT date FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'").ToString();
                        }

                        if (connection.ExecuteScalar($"SELECT net_amount FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'")== null)
                        {
                            totalReceipt.Text = "ERROR";
                        }
                        else
                        {
                            totalReceipt.Text = String.Format("{0:f2}", connection.ExecuteScalar($"SELECT net_amount FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'"));
                        }

                        if (connection.ExecuteScalar($"SELECT balance_remaining FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'") == null)
                        {
                            balRemain.Text = "ERROR";

                        }
                        else
                        {
                            balRemain.Text = String.Format("{0:f2}", connection.ExecuteScalar($"SELECT balance_remaining FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'"));
                        } 
                        

                     }
                //}
                //catch(Exception)
                //{
                //    MessageBox.Show("Invoice does not exist in records. Try again.");
                //}

                
            }
            else
            {
                MessageBox.Show("Invoice number is numerical only. Try again.");
            }
            
            
        }

        private void chequeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
