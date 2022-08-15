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
    public partial class CNReport : Form
    {
        public CNReport()
        {
            InitializeComponent();
            invoicelist.Visible = false;
        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"select * from creditnote WHERE (dateissued BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;

                double sumINVOICE = 0;
                for (int i = 0; i < invoicelist.Rows.Count; ++i)
                {
                    sumINVOICE += (double)Convert.ToInt32(invoicelist.Rows[i].Cells[3].Value);
                }


                //SqlDataAdapter adapt2 = new SqlDataAdapter(queryreceipt, connection);
                //adapt2.Fill(dt2);

                //receiptlist.DataSource = dt2;

                //double sumReceipt = 0;
                //for (int i = 0; i < receiptlist.Rows.Count; ++i)
                //{
                //    sumReceipt += (double)Convert.ToInt32(receiptlist.Rows[i].Cells[3].Value);
                //}

                try
                {
                    var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                    Random rnd = new Random();
                    int saveno = rnd.Next(1, 51);
                    string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\CREDIT NOTE REPORT\\CNR{fromY.Text}{fromM.Text}{fromD.Text}to{toY.Text}{toM.Text}{toD.Text}_{saveno}.pdf";

                    PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                    pdfReport.Open();

                    var imagepth = @"C:\Users\maste\OneDrive\Desktop\INVOICING SOFTWARE\RESOURCES\BACKGROUNDIMAGE\REPORT.jpg";
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

                    title = new Paragraph($"CREDIT NOTE REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Courier", 16);

                    pdfReport.Add(title);

                    pdfReport.Add(spacer);

                    invoicelist.Columns[0].HeaderText = "Credit Note";
                    invoicelist.Columns[1].HeaderText = "Invoice";
                    invoicelist.Columns[2].HeaderText = "Date Issued";
                    invoicelist.Columns[3].HeaderText = "Amount";
                    //invoicelist.Columns[4].HeaderText = "Remaining Balance";
                    //invoicelist.Columns[5].HeaderText = "Due Date";

                    PdfPTable producttable = new PdfPTable(invoicelist.ColumnCount);
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

                    float[] widths = new float[] { 1f, 1f, 1f, 1f };
                    producttable.SetWidths(widths);
                    string text;
                    foreach (DataGridViewRow row in invoicelist.Rows)
                    {
                        int counta = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            

                            if (cell.Value == null)
                            {
                                text = "";
                            }
                            else
                            {
                                text = cell.Value.ToString();
                            }
                            double d;
                            if (counta == 4)
                            {
                                if (double.TryParse(text, out d))
                                {
                                    d = double.Parse(text);
                                    text = String.Format("{0:f2}", d);
                                }
                            }
                            counta = counta + 1;
                            producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                        }
                    }

                    pdfReport.Add(producttable);
                    title = new Paragraph($"CREDIT NOTE AMOUNT TOTAL FOR SET PERIOD OF TIME: Rs. {sumINVOICE}.", titleFont);
                    title.Alignment = 0;
                    title.Font = FontFactory.GetFont("Courier", 16);
                    pdfReport.Add(title);
                    pdfReport.Close();

                    System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\CREDIT NOTE REPORT\\CNR{fromY.Text}{fromM.Text}{fromD.Text}to{toY.Text}{toM.Text}{toD.Text}_{saveno}.pdf");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error generating PDF Report!");
                }

            }
        }

        private void CNReport_Load(object sender, EventArgs e)
        {

        }
    }
}
