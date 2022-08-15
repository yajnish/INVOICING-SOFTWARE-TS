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
using System.Data.SqlClient;

namespace INVOICING_SOFTWARE
{
    public partial class CreditNote : Form
    {
        public CreditNote()
        {
            InitializeComponent();
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

                if ((a >= b) || (a > 10000100))
                {
                    try
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                        {

                            receiptCompany.Text = connection.ExecuteScalar($"SELECT company_name1 FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'").ToString();
                            issueDate.Text = connection.ExecuteScalar($"SELECT date FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'").ToString();
                            totalReceipt.Text = String.Format("{0:f2}", connection.ExecuteScalar($"SELECT net_amount FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'"));
                            balRemain.Text = String.Format("{0:f2}", connection.ExecuteScalar($"SELECT balance_remaining FROM invoice_record WHERE invoice_no = '{invoiceno.Text}'"));


                        }
                    }
                    catch (Exception)
                    {

                    }
                    
                }
                else
                {
                    MessageBox.Show("Invoice does not exist in records. Try again.");
                }

            }
            else
            {
                MessageBox.Show("Invoice does not exist in records. Try again.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string crno;
            double bal = 0;
            DialogResult choice = MessageBox.Show($"Approve Credit Note of Rs. {amtPaid.Text}?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                decimal d;

                if (decimal.TryParse(amtPaid.Text, out d))
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {

                        connection.Query($"INSERT INTO creditnote (invoiceno, dateissued, amount) VALUES ('{invoiceno.Text}', '{datePaidY.Text}/{datePaidM.Text}/{datepaidD.Text}', '{double.Parse(amtPaid.Text)*1.15}')");
                        bal = (double.Parse(balRemain.Text)) - (double.Parse(amtPaid.Text) * 1.15);
                        connection.Query($"UPDATE invoice_record SET balance_remaining = '{bal}' WHERE invoice_no = '{invoiceno.Text}'");
                        balRemain.Text = $"{bal}";

                        crno = connection.ExecuteScalar($"SELECT TOP 1 creditnoteno FROM creditnote ORDER BY creditnoteno DESC").ToString();

                        connection.Query($"INSERT INTO statement(Date, Company, Type, Reference, Value) VALUES ('{datePaidY.Text}/{datePaidM.Text}/{datepaidD.Text}', '{receiptCompany.Text}', 'Credit Note', '{crno}', '-{amtPaid.Text}')");
                    }

                    //var pdfInvoice = new Document(PageSize.A4, 40f, 40f, 60f, 60f);
                    //string path = $"‪C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\INVOICES\\{crno.TrimEnd(' ')}.pdf";
                    //PdfWriter.GetInstance(pdfCN, new FileStream(path, FileMode.OpenOrCreate));
                    //pdfInvoice.Open();


                    //var imagepth = @"‪‪C:\Users\maste\OneDrive\Pictures\creditnote.jpg";
                    //using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                    //{
                    //    var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    //    jpg.ScaleToFit(pdfInvoice.PageSize);
                    //    jpg.SetAbsolutePosition(0, 0);
                    //    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    //    pdfInvoice.Add(jpg);
                    //}

                    using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        DataTable dt = new DataTable();
                        string queryString = $"select * from invoice_record WHERE invoice_no = '{invoiceno.Text}'";
                        SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                        adapt.Fill(dt);

                        cnlist.DataSource = dt;
                    }
                    try
                    {
                        var pdfCN = new Document(PageSize.A4, 20f, 20f, 40f, 60f);
                        string path1 = $"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\CREDIT NOTE\\{crno.TrimEnd(' ')}.pdf";
                        PdfWriter.GetInstance(pdfCN, new FileStream(path1, FileMode.OpenOrCreate));
                        pdfCN.Open();


                        string imagepth1 = @"C:\Users\maste\OneDrive\Desktop\INVOICING SOFTWARE\RESOURCES\BACKGROUNDIMAGE\CREDITNOTE.jpg";
                        using (FileStream fs = new FileStream(imagepth1, FileMode.Open))
                        {
                            var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                            jpg.ScaleToFit(pdfCN.PageSize);
                            jpg.SetAbsolutePosition(0, 0);
                            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                            pdfCN.Add(jpg);
                        }


                        var spacer = new Paragraph("")
                        {
                            SpacingBefore = 10f,
                            SpacingAfter = 10f,
                        };
                        pdfCN.Add(spacer);
                        pdfCN.Add(spacer);
                        pdfCN.Add(spacer);

                        Font titleFont = FontFactory.GetFont("Courier");

                        Paragraph title = new Paragraph($"CREDIT NOTE", titleFont);
                        title.Alignment = 1;
                        title.Font = FontFactory.GetFont("Courier", 16);

                        pdfCN.Add(title);
                        title = new Paragraph($"CUSTOMER COPY", titleFont);
                        title.Alignment = 2;
                        pdfCN.Add(title);

                        var spacerx = new Paragraph("")
                        {
                            SpacingBefore = 2f,
                            SpacingAfter = 2f,
                        };
                        pdfCN.Add(spacerx);

                        Paragraph dateToday = new Paragraph($"{datepaidD.Text}/{datePaidM.Text}/{datePaidY.Text}", titleFont);
                        dateToday.Alignment = 2;
                        pdfCN.Add(dateToday);
                        var spacer2 = new Paragraph("")
                        {
                            SpacingBefore = 4f,
                            SpacingAfter = 4f,
                        };
                        pdfCN.Add(spacer2);


                        var invoicenum = new Paragraph($"{crno}", titleFont);
                        invoicenum.Alignment = 2;
                        pdfCN.Add(invoicenum);

                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);



                        Paragraph compName = new Paragraph($"{receiptCompany.Text}");
                        compName.Alignment = 0;
                        pdfCN.Add(compName);

                        var spacer4 = new Paragraph("")
                        {
                            SpacingBefore = 0.5f,
                            SpacingAfter = 0.5f,
                        };
                        Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);
                        pdfCN.Add(spacer4);

                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                        {
                            string brn = connection.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();
                            string vat = connection.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();
                            string street = connection.ExecuteScalar($"SELECT street_name FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();
                            string city = connection.ExecuteScalar($"SELECT city FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();

                            string num = connection.ExecuteScalar($"SELECT contact_number FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();

                            Paragraph compBRN = new Paragraph($"BRN: {brn}", titleFont2);
                            compBRN.Alignment = 0;
                            pdfCN.Add(compBRN);
                            pdfCN.Add(spacer4);

                            Paragraph compVAT = new Paragraph($"VAT No: {vat}", titleFont2);
                            compVAT.Alignment = 0;
                            pdfCN.Add(compVAT);
                            pdfCN.Add(spacer4);

                            Paragraph compStreet = new Paragraph($"{street}", titleFont2);
                            compStreet.Alignment = 0;
                            pdfCN.Add(compStreet);
                            pdfCN.Add(spacer4);

                            Paragraph compCity = new Paragraph($"{city}", titleFont2);
                            compCity.Alignment = 0;
                            pdfCN.Add(compCity);
                            pdfCN.Add(spacer4);

                            Paragraph compNum = new Paragraph($"+230 {num}", titleFont2);
                            compNum.Alignment = 0;
                            pdfCN.Add(compNum);
                            pdfCN.Add(spacer2);

                        }

                        
                        

                        

                        cnlist.Columns[0].HeaderText = "Invoice";
                        cnlist.Columns[1].HeaderText = "Date Issued";
                        cnlist.Columns[2].HeaderText = "Name of Company";
                        cnlist.Columns[3].HeaderText = "Net Amount";
                        cnlist.Columns[4].HeaderText = "Tax";
                        cnlist.Columns[5].HeaderText = "Balance Remaining";
                        cnlist.Columns[6].HeaderText = "Due Date";

                        this.CNdescamt.Rows.Add($"{richDetail.Text} INVOICE REF:{invoiceno.Text}", amtPaid.Text);

                        PdfPTable producttable2 = new PdfPTable(CNdescamt.ColumnCount);
                        producttable2.DefaultCell.Padding = 3;
                        producttable2.WidthPercentage = 100;
                        producttable2.HorizontalAlignment = Element.ALIGN_LEFT;
                        producttable2.DefaultCell.BorderWidth = 1;
                        BaseColor couleur = new BaseColor(255, 255, 255);
                        Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 12, couleur);
                        foreach (DataGridViewColumn column in CNdescamt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(0,0,0);
                            producttable2.AddCell(cell);
                        }
                        float[] widths = new float[] { 3.5f, 1f };
                        producttable2.SetWidths(widths);

                        
                        pdfCN.Add(spacer2);

                        foreach (DataGridViewRow row in CNdescamt.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string text = cell.Value.ToString();
                                producttable2.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                            }
                        }

                        pdfCN.Add(producttable2);

                        pdfCN.Add(spacer2);
                        Chunk compSubtotal = new Chunk($"SUBTOTAL:\t\tRs. {amtPaid.Text}", titleFont);
                        compSubtotal.SetUnderline(1, -2);
                        Paragraph compSubtotal1 = new Paragraph(compSubtotal);
                        compSubtotal1.Alignment = 2;
                        pdfCN.Add(compSubtotal1);

                        Chunk compTax = new Chunk($"TAX(15%):\t\tRs. {double.Parse(amtPaid.Text)*0.15}", titleFont);
                        compTax.SetUnderline(1, -2);
                        Paragraph compTax1 = new Paragraph(compTax);
                        compTax1.Alignment = 2;
                        pdfCN.Add(compTax1);

                        Chunk compTotal = new Chunk($"NET AMOUNT:\t\tRs. {double.Parse(amtPaid.Text) * 1.15}", titleFont);
                        compTotal.SetUnderline(1, -2);
                        Paragraph compTotal1 = new Paragraph(compTotal);
                        compTotal1.Alignment = 2;
                        pdfCN.Add(compTotal1);
                        pdfCN.Add(spacer2);

                        title = new Paragraph($"Invoice Detail(AFTER CREDIT):", titleFont);
                        pdfCN.Add(spacer2);
                        
                        title.Alignment = 0;
                        title.Font = FontFactory.GetFont("Courier", 16);

                        pdfCN.Add(title);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        PdfPTable producttable = new PdfPTable(7);
                        producttable.DefaultCell.Padding = 3;
                        producttable.WidthPercentage = 100;
                        producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                        producttable.DefaultCell.BorderWidth = 1;

                        //BaseColor couleur = new BaseColor(255, 255, 255);
                        //Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                        foreach (DataGridViewColumn column in cnlist.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(0,0,0);
                            producttable.AddCell(cell);
                        }

                        widths = new float[] { 0.80f, 0.82f, 2.0f, 0.80f, 0.8f, 0.80f, 0.82f };
                        producttable.SetWidths(widths);

                        foreach (DataGridViewRow row in cnlist.Rows)
                        {
                            int counta = 1;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string text = cell.Value.ToString();
                                double d_;
                                if (counta != 1)
                                {
                                    if (cell.Value == null)
                                    {
                                        text = "";
                                    }
                                    else
                                    {
                                        text = cell.Value.ToString();
                                    }
                                    if (double.TryParse(text, out d_))
                                    {
                                        d_ = double.Parse(text);
                                        text = String.Format("{0:f2}", d_);
                                    }
                                }
                                counta = counta + 1;
                                producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                            }
                        }

                        pdfCN.Add(producttable);

                        pdfCN.NewPage();
                        //////////////////////////////////////////////////////////////////////////////////////////////////////
                        
                        
                        using (FileStream fs = new FileStream(imagepth1, FileMode.Open))
                        {
                            var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                            jpg.ScaleToFit(pdfCN.PageSize);
                            jpg.SetAbsolutePosition(0, 0);
                            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                            pdfCN.Add(jpg);
                        }


                        //var spacer = new Paragraph("")
                        //{
                        //    SpacingBefore = 10f,
                        //    SpacingAfter = 10f,
                        //};
                        pdfCN.Add(spacer);
                        pdfCN.Add(spacer);
                        pdfCN.Add(spacer);


                        titleFont = FontFactory.GetFont("Courier");

                        title = new Paragraph($"CREDIT NOTE", titleFont);
                        title.Alignment = 1;
                        title.Font = FontFactory.GetFont("Courier", 16);

                        pdfCN.Add(title);
                        title = new Paragraph($"MERCHANT COPY", titleFont);
                        title.Alignment = 2;
                        pdfCN.Add(title);

                        //var spacerx = new Paragraph("")
                        //{
                        //    SpacingBefore = 2f,
                        //    SpacingAfter = 2f,
                        //};
                        pdfCN.Add(spacerx);

                        dateToday = new Paragraph($"{datepaidD.Text}/{datePaidM.Text}/{datePaidY.Text}", titleFont);
                        dateToday.Alignment = 2;
                        pdfCN.Add(dateToday);
                        //var spacer2 = new Paragraph("")
                        //{
                        //    SpacingBefore = 4f,
                        //    SpacingAfter = 4f,
                        //};
                        pdfCN.Add(spacer2);

                        invoicenum = new Paragraph($"{crno}", titleFont);
                        invoicenum.Alignment = 2;
                        pdfCN.Add(invoicenum);

                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);



                        compName = new Paragraph($"{receiptCompany.Text}");
                        compName.Alignment = 0;
                        pdfCN.Add(compName);

                        //var spacer4 = new Paragraph("")
                        //{
                        //    SpacingBefore = 0.5f,
                        //    SpacingAfter = 0.5f,
                        //};
                        titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);
                        pdfCN.Add(spacer4);

                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                        {
                            string brn = connection.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();
                            string vat = connection.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();
                            string street = connection.ExecuteScalar($"SELECT street_name FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();
                            string city = connection.ExecuteScalar($"SELECT city FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();

                            string num = connection.ExecuteScalar($"SELECT contact_number FROM clients WHERE company_name = '{receiptCompany.Text}'").ToString();

                            Paragraph compBRN = new Paragraph($"BRN: {brn}", titleFont2);
                            compBRN.Alignment = 0;
                            pdfCN.Add(compBRN);
                            pdfCN.Add(spacer4);

                            Paragraph compVAT = new Paragraph($"VAT No: {vat}", titleFont2);
                            compVAT.Alignment = 0;
                            pdfCN.Add(compVAT);
                            pdfCN.Add(spacer4);

                            Paragraph compStreet = new Paragraph($"{street}", titleFont2);
                            compStreet.Alignment = 0;
                            pdfCN.Add(compStreet);
                            pdfCN.Add(spacer4);

                            Paragraph compCity = new Paragraph($"{city}", titleFont2);
                            compCity.Alignment = 0;
                            pdfCN.Add(compCity);
                            pdfCN.Add(spacer4);

                            Paragraph compNum = new Paragraph($"+230 {num}", titleFont2);
                            compNum.Alignment = 0;
                            pdfCN.Add(compNum);
                            pdfCN.Add(spacer2);

                        }




                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);

                        cnlist.Columns[0].HeaderText = "Invoice";
                        cnlist.Columns[1].HeaderText = "Date Issued";
                        cnlist.Columns[2].HeaderText = "Name of Company";
                        cnlist.Columns[3].HeaderText = "Net Amount";
                        cnlist.Columns[4].HeaderText = "Tax";
                        cnlist.Columns[5].HeaderText = "Balance Remaining";
                        cnlist.Columns[6].HeaderText = "Due Date";

                        this.CNdescamt.Rows.Add($"{richDetail.Text} INVOICE REF:{invoiceno.Text}", amtPaid.Text);

                        //producttable2 = new PdfPTable(CNdescamt.ColumnCount);
                        //producttable2.DefaultCell.Padding = 3;
                        //producttable2.WidthPercentage = 100;
                        //producttable2.HorizontalAlignment = Element.ALIGN_LEFT;
                        //producttable2.DefaultCell.BorderWidth = 1;
                        //couleur = new BaseColor(255, 255, 255);
                        //titleFont3 = FontFactory.GetFont("Helvetica Bold", 12, couleur);
                        //foreach (DataGridViewColumn column in CNdescamt.Columns)
                        //{
                        //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                        //    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                        //    producttable2.AddCell(cell);
                        //}
                        //widths = new float[] { 3.5f, 1f };
                        //producttable2.SetWidths(widths);

                        //pdfCN.Add(spacer2);
                        //pdfCN.Add(spacer2);

                        //foreach (DataGridViewRow row in CNdescamt.Rows)
                        //{
                        //    foreach (DataGridViewCell cell in row.Cells)
                        //    {
                        //        string text = cell.Value.ToString();
                        //        producttable2.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                        //    }
                        //}

                        pdfCN.Add(producttable2);

                        pdfCN.Add(spacer2);
                        compSubtotal = new Chunk($"SUBTOTAL:\t\tRs. {amtPaid.Text}", titleFont);
                        compSubtotal.SetUnderline(1, -2);
                        compSubtotal1 = new Paragraph(compSubtotal);
                        compSubtotal1.Alignment = 2;
                        pdfCN.Add(compSubtotal1);

                        compTax = new Chunk($"TAX(15%):\t\tRs. {String.Format("{0:f2}", double.Parse(amtPaid.Text) * 0.15)}", titleFont);
                        compTax.SetUnderline(1, -2);
                        compTax1 = new Paragraph(compTax);
                        compTax1.Alignment = 2;
                        pdfCN.Add(compTax1);

                        compTotal = new Chunk($"NET AMOUNT:\t\tRs. {String.Format("{0:f2}", double.Parse(amtPaid.Text) * 1.15)}", titleFont);
                        compTotal.SetUnderline(1, -2);
                        compTotal1 = new Paragraph(compTotal);
                        compTotal1.Alignment = 2;
                        pdfCN.Add(compTotal1);
                        pdfCN.Add(spacer2);

                        title = new Paragraph($"Invoice Detail(AFTER CREDIT):", titleFont);
                        

                        title.Alignment = 0;
                        title.Font = FontFactory.GetFont("Courier", 16);

                        pdfCN.Add(title);
                        pdfCN.Add(spacer2);
                        pdfCN.Add(spacer2);
                        
                        producttable = new PdfPTable(cnlist.ColumnCount);
                        producttable.DefaultCell.Padding = 3;
                        producttable.WidthPercentage = 100;
                        producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                        producttable.DefaultCell.BorderWidth = 1;

                        //BaseColor couleur = new BaseColor(255, 255, 255);
                        //Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                        foreach (DataGridViewColumn column in cnlist.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(0,0,0);
                            producttable.AddCell(cell);
                        }

                        widths = new float[] { 0.80f, 0.82f, 2.0f, 0.80f, 0.8f, 0.80f, 0.82f };
                        producttable.SetWidths(widths);

                        foreach (DataGridViewRow row in cnlist.Rows)
                        {
                            int counta = 1;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string text = cell.Value.ToString();
                                double d_;
                                if (counta != 1)
                                {
                                    if (cell.Value == null)
                                    {
                                        text = "";
                                    }
                                    else
                                    {
                                        text = cell.Value.ToString();
                                    }
                                    if (double.TryParse(text, out d_))
                                    {
                                        d_ = double.Parse(text);
                                        text = String.Format("{0:f2}", d_);
                                    }
                                }
                                counta = counta + 1;
                                producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                            }
                        }

                        pdfCN.Add(producttable);


                        pdfCN.Close();
                        
                        System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\CREDIT NOTE\\{crno.TrimEnd(' ')}.pdf");

                }
                    catch (Exception)
                {
                    MessageBox.Show("Error, Kuma tou problem, teigne re allimer!");
                }

            }
            }
        }

        private void amtPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditNote_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void datePaidY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datePaidM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datepaidD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void balRemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void issueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiptCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void invoiceno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
