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
using System.Data.SqlClient;
using iTextSharp.text.html.simpleparser;
using System.Configuration;

namespace INVOICING_SOFTWARE
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            invoicelist.Visible = false;
            receiptlist.Visible = false;
        }
        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"select * from invoice_record WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();


            double sumINVOICE = 0;
            
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;



                
                //for (int i = 0; i < invoicelist.Rows.Count; ++i)
                //{

                //    sumINVOICE += (double)Convert.ToInt32(invoicelist.Rows[i].Cells[3].Value);
                //}


                //SqlDataAdapter adapt2 = new SqlDataAdapter(queryreceipt, connection);
                //adapt2.Fill(dt2);

                //receiptlist.DataSource = dt2;

                double sumReceipt = 0;
                for (int ind = 0; ind < invoicelist.Rows.Count; ++ind)
                {

                    sumReceipt += Convert.ToDouble(invoicelist.Rows[ind].Cells[3].Value);
                }
                double taxamt = 0;

                for (int index = 0; index < invoicelist.Rows.Count; ++index)
                {

                    taxamt += Convert.ToDouble(invoicelist.Rows[index].Cells[4].Value);
                }

                try
                {
                    var pdfReport = new Document(PageSize.A4.Rotate(), 20f, 20f, 50f, 50f);
                    Random rnd = new Random();
                    int saveno = rnd.Next(1, 51);
                    string path = $"‪C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\SALES REPORT\\R{fromY.Text}{fromM.Text}{fromD.Text}to{toY.Text}{toM.Text}{toD.Text}_{saveno}.pdf";

                    PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                    pdfReport.Open();

                    var imagepth = @"‪C:\Users\maste\OneDrive\Desktop\INVOICING SOFTWARE\RESOURCES\BACKGROUNDIMAGE\sales report.jpg";
                    using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                    {
                        var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                        jpg.ScaleToFit(pdfReport.PageSize);
                        jpg.SetAbsolutePosition(0, 0);
                        jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                        pdfReport.Add(jpg);
                    }

                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };
                    pdfReport.Add(spacer);
                    pdfReport.Add(spacer);
                    pdfReport.Add(spacer);


                    Font titleFont = FontFactory.GetFont("Courier");

                    Paragraph title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
                    title.Alignment = 0;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                    pdfReport.Add(title);

                    pdfReport.Add(spacer);

                    title = new Paragraph($"SALES REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Courier", 16);

                    pdfReport.Add(title);

                    pdfReport.Add(spacer);

                    invoicelist.Columns[0].HeaderText = "Invoice";
                    invoicelist.Columns[1].HeaderText = "Date Issued";
                    invoicelist.Columns[2].HeaderText = "Name of Company";
                    invoicelist.Columns[3].HeaderText = "Net Amount";
                    invoicelist.Columns[4].HeaderText = "Tax";
                    invoicelist.Columns[5].HeaderText = "Remaining Balance";
                    invoicelist.Columns[6].HeaderText = "Due Date";

                    PdfPTable producttable = new PdfPTable(7);
                    producttable.DefaultCell.Padding = 3;
                    producttable.WidthPercentage = 100;
                    producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                    producttable.DefaultCell.BorderWidth = 1;
                    BaseColor couleur = new BaseColor(255, 255, 255);
                    Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                    foreach (DataGridViewColumn column in invoicelist.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                        producttable.AddCell(cell);
                    }

                    float[] widths = new float[] { 0.80f, 0.82f, 2.0f, 0.80f, 0.8f, 0.80f, 0.82f };
                    producttable.SetWidths(widths);

                    foreach (DataGridViewRow row in invoicelist.Rows)
                    {
                        int counta = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string text = cell.Value.ToString();
                            double d;
                            if (cell.Value == null)
                            {
                                text = "";
                            }
                            else
                            {
                                text = cell.Value.ToString();
                            }
                            if (counta != 1)
                            {
                                if (double.TryParse(text, out d))
                                {
                                    d = double.Parse(text);
                                    text = String.Format("{0:f2}", d);
                                }
                            }
                            if (counta == 3)
                            {
                                using (IDbConnection connection2 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                                {
                                    string invbrn;
                                    string invVat;
                                    if (connection2.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{text}'") == null)
                                    {
                                        invbrn = "";
                                    }
                                    else
                                    {
                                        invbrn = connection2.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{text}'").ToString();
                                    }
                                    if (connection2.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{text}'") == null)
                                    {
                                        invVat = "";
                                    }
                                    else
                                    {
                                        invVat = connection2.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{text}'").ToString();
                                    }

                                    //string invStreet = connection.ExecuteScalar($"SELECT street_name FROM clients WHERE company_name = '{invClName.Text}'").ToString();
                                    //string invCity = connection.ExecuteScalar($"SELECT city FROM clients WHERE company_name = '{invClName.Text}'").ToString();
                                    //string invNum = connection.ExecuteScalar($"SELECT contact_number FROM clients WHERE company_name = '{invClName.Text}'").ToString();
                                    text = text + $" BRN:{invbrn} VAT NO:{invVat}";
                                }


                            }
                            counta = counta + 1;
                            producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                        }
                    }

                    pdfReport.Add(producttable);



                    //pdfReport.NewPage();

                    //title = new Paragraph($"LIST OF RECEIPTS FOR THE SELECTED PERIOD OF TIME", titleFont);

                    //title.Alignment = 1;
                    //title.Font = FontFactory.GetFont("Courier", 16);

                    //pdfReport.Add(title);

                    //receiptlist.Columns[0].HeaderText = "Receipt";
                    //receiptlist.Columns[1].HeaderText = "Invoice";
                    //receiptlist.Columns[2].HeaderText = "Date Paid";
                    //receiptlist.Columns[3].HeaderText = "Amount Paid";
                    //receiptlist.Columns[4].HeaderText = "Means";
                    //receiptlist.Columns[5].HeaderText = "Deposit Date (Cheque only)";
                    //receiptlist.Columns[6].HeaderText = "Cheque No";

                    //PdfPTable producttable2 = new PdfPTable(receiptlist.ColumnCount);
                    //producttable2.DefaultCell.Padding = 3;
                    //producttable2.WidthPercentage = 100;
                    //producttable2.HorizontalAlignment = Element.ALIGN_LEFT;
                    //producttable2.DefaultCell.BorderWidth = 1;
                    //couleur = new BaseColor(255, 255, 255);
                    //titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                    //foreach (DataGridViewColumn column in receiptlist.Columns)
                    //{
                    //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    //    cell.BackgroundColor = new iTextSharp.text.BaseColor(5, 144, 137, 255);
                    //    producttable2.AddCell(cell);
                    //}

                    //float[] widths2 = new float[] { 1f, 1f, 1f, 1f, 1f, 1f, 1f, };
                    //producttable2.SetWidths(widths2);

                    //foreach (DataGridViewRow row in receiptlist.Rows)
                    //{
                    //    int counta = 1;
                    //    foreach (DataGridViewCell cell in row.Cells)
                    //    {
                    //        string text = cell.Value.ToString();

                    //        double d;
                    //        if (counta == 4)
                    //        {
                    //            if (double.TryParse(text, out d))
                    //            {
                    //                d = double.Parse(text);
                    //                text = String.Format("{0:f2}", d);
                    //            }
                    //        }

                    //        counta = counta + 1;

                    //        producttable2.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));



                    //    }
                    //}
                    //pdfReport.Add(spacer);
                    //pdfReport.Add(spacer);

                    //pdfReport.Add(producttable2);

                    //pdfReport.Add(spacer);
                    //pdfReport.Add(spacer);

                    title = new Paragraph($"INVOICE NET AMOUNT TOTAL FOR SET PERIOD OF TIME: Rs. {sumINVOICE}.", titleFont);
                    title.Alignment = 0;
                    title.Font = FontFactory.GetFont("Courier", 16);
                    pdfReport.Add(title);
                    title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
                    title.Alignment = 0;
                    title.Font = FontFactory.GetFont("Courier", 16);
                    pdfReport.Add(title);

                    //pdfReport.Add(spacer);


                    //title = new Paragraph($"SUM OF RECEIPTS COLLECTED DURING THE SELECTED PERIOD OF TIME: Rs. {sumReceipt}.", titleFont);
                    //title.Alignment = 0;
                    //title.Font = FontFactory.GetFont("Courier", 16);
                    //pdfReport.Add(title);
                    //string bestbuyer;
                    //using (IDbConnection connection2 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    //{
                    //    bestbuyer = connection.ExecuteScalar($"SELECT TOP 1 company_name1 FROM invoice_record GROUP BY company_name1 ORDER BY SUM(net_amount) DESC").ToString();
                    //}

                    //pdfReport.Add(spacer);


                    //title = new Paragraph($"Client company buying the most: {bestbuyer}.", titleFont);
                    //title.Alignment = 0;
                    //title.Font = FontFactory.GetFont("Courier", 16);
                    //pdfReport.Add(title);

                    pdfReport.Close();

                    System.Diagnostics.Process.Start($"‪C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\SALES REPORT\\R{fromY.Text}{fromM.Text}{fromD.Text}to{toY.Text}{toM.Text}{toD.Text}_{saveno}.pdf");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error generating PDF Report!");
                }

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fromD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fromM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fromY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExecuteGenReport_Click_1(object sender, EventArgs e)
        {

        }
    }
}
