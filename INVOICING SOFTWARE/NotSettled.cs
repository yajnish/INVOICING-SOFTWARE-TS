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
    public partial class NotSettled : Form
    {
        public NotSettled()
        {
            InitializeComponent();
            notsettledlist.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {
                SqlDataAdapter adapt = new SqlDataAdapter($"SELECT * FROM invoice_record WHERE duedate < '{fromY.Text}-{fromM.Text}-{fromD.Text}' AND balance_remaining != 0", connection);
                adapt.Fill(dt);

                notsettledlist.DataSource = dt;

                //try
                //{
                    var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                    Random rnd = new Random();
                    int saveno = rnd.Next(1, 51);
                    string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\NOT SETTLED\\NS{fromY.Text}{fromM.Text}{fromD.Text}_{saveno}.pdf";

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

                    Paragraph title = new Paragraph($"As of {fromD.Text}/{fromM.Text}/{fromY.Text}, the following invoices have not been fully settled yet.", titleFont);
                    title.Alignment = 0;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                    pdfReport.Add(title);

                    pdfReport.Add(spacer);

                    notsettledlist.Columns[0].HeaderText = "Invoice";
                    notsettledlist.Columns[1].HeaderText = "Date Issued";
                    notsettledlist.Columns[2].HeaderText = "Name of Company";
                    notsettledlist.Columns[3].HeaderText = "Net Amount";
                    notsettledlist.Columns[4].HeaderText = "Tax";
                    notsettledlist.Columns[5].HeaderText = "Remaining Balance";
                    notsettledlist.Columns[6].HeaderText = "Due Date";

                    PdfPTable producttable = new PdfPTable(notsettledlist.ColumnCount);
                    producttable.DefaultCell.Padding = 3;
                    producttable.WidthPercentage = 100;
                    producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                    producttable.DefaultCell.BorderWidth = 1;
                    BaseColor couleur = new BaseColor(255, 255, 255);
                    Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                    foreach (DataGridViewColumn column in notsettledlist.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                        producttable.AddCell(cell);
                    }

                    float[] widths = new float[] { 0.80f, 0.82f, 2.0f, 0.80f, 0.8f, 0.80f, 0.82f };
                    producttable.SetWidths(widths);
                    int limitY = int.Parse(fromY.Text);
                    int limitM = int.Parse(fromM.Text);
                    int limitD = int.Parse(fromD.Text);
                    DateTime limit = new DateTime(limitY, limitM, limitD);
                    DateTime limitAll = (DateTime)connection.ExecuteScalar($"SELECT TOP 1 duedate FROM invoice_record   WHERE duedate IS NOT NULL ORDER BY duedate ASC");
                    if (limitAll < limit)
                    {
                        foreach (DataGridViewRow row in notsettledlist.Rows)
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
                                counta = counta + 1;
                                producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                            
                            }
                        }
                        pdfReport.Add(producttable);
                    }
                    else
                    {
                        pdfReport.Add(spacer);
                        pdfReport.Add(spacer);
                        pdfReport.Add(spacer);
                        title = new Paragraph($"ERROR!", titleFont);
                        pdfReport.Add(title);
                        MessageBox.Show("Date incorrect!");
                    }
                    

                    

                    pdfReport.Close();

                    System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\NOT SETTLED\\NS{fromY.Text}{fromM.Text}{fromD.Text}_{saveno}.pdf");


                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("ERROR!");
                //}
            }
        }

        private void NotSettled_Load(object sender, EventArgs e)
        {

        }
    }
}
