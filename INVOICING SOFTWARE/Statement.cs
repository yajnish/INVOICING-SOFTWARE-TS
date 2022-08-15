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
using System.Globalization;

namespace INVOICING_SOFTWARE
{
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVOICEDataSet10.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.iNVOICEDataSet10.clients);

        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string queryString = $"SELECT * FROM statement WHERE Company = '{CompName.Text}' ORDER BY Date ASC";
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;
                int y = (int)(double.Parse(fromY.Text));
                int m = (int)(double.Parse(fromM.Text));
                int d = (int)(double.Parse(fromD.Text));

                DateTime startdate = new DateTime(y, m, d);

                y = (int)(double.Parse(toY.Text));
                m = (int)(double.Parse(toM.Text));
                d = (int)(double.Parse(toD.Text));

                DateTime enddate = new DateTime(y, m, d);
                DateTime today = DateTime.Today;
                double balance = 0;

                //try
                //{
                    var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                    Random rnd = new Random();
                    int saveno = rnd.Next(1, 51);
                    string path = $"C:\\Users\\maste\\Desktop\\FINANCE SOFTWARE\\REPORTS\\STATEMENT OF ACCOUNT\\Statement{fromY.Text}{fromM.Text}{fromD.Text}to{toY.Text}{toM.Text}{toD.Text}_{saveno}.pdf";

                    PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                    pdfReport.Open();
            //C: \Users\maste\OneDrive\Desktop\INVOICING SOFTWARE\REPORTS\STATEMENT_OF_ACCOUNT

                 var imagepth = @"C:\Users\maste\Desktop\FINANCE SOFTWARE\RESOURCE\REPORT.jpg";
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

                    var spacer2 = new Paragraph("")
                    {
                        SpacingBefore = 5f,
                        SpacingAfter = 5f,
                    };
                    pdfReport.Add(spacer);
                    pdfReport.Add(spacer);
                    pdfReport.Add(spacer);


                    Font titleFont = FontFactory.GetFont("Helvetica Bold");

                    Paragraph title = new Paragraph($"{today.ToString("dd/MM/yyyy")}", titleFont);
                    title.Alignment = 2;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                    pdfReport.Add(title);

                    pdfReport.Add(spacer2);

                    title = new Paragraph($"STATEMENT OF ACCOUNT AS FROM {startdate.ToString("dd/MM/yyyy")}", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Courier", 16);

                    pdfReport.Add(title);

                    

                    string invbrn = connection.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{CompName.Text}'").ToString();
                    string invVat = connection.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{CompName.Text}'").ToString();
                    string invStreet = connection.ExecuteScalar($"SELECT street_name FROM clients WHERE company_name = '{CompName.Text}'").ToString();
                    string invCity = connection.ExecuteScalar($"SELECT city FROM clients WHERE company_name = '{CompName.Text}'").ToString();
                    string invNum = connection.ExecuteScalar($"SELECT contact_number FROM clients WHERE company_name = '{CompName.Text}'").ToString();

                    title = new Paragraph($"{CompName.Text}", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 20);
                    pdfReport.Add(title);

                    title = new Paragraph($"VAT No: {invVat}  BRN: {invbrn}", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 15);
                    pdfReport.Add(title);

                    title = new Paragraph($"{invStreet}, {invCity}", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 15);
                    pdfReport.Add(title);

                    title = new Paragraph($"Tel: {invNum}", titleFont);
                    title.Alignment = 1;
                    title.Font = FontFactory.GetFont("Helvetica Bold", 15);
                    pdfReport.Add(title);

                    pdfReport.Add(spacer);

                    PdfPTable producttable = new PdfPTable(5);
                    producttable.DefaultCell.Padding = 3;
                    producttable.WidthPercentage = 100;
                    producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                    producttable.DefaultCell.BorderWidth = 1;
                    BaseColor couleur = new BaseColor(255, 255, 255);
                    Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                    PdfPCell cell = new PdfPCell(new Phrase("Date", titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);

                    cell = new PdfPCell(new Phrase("Reference", titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);

                    cell = new PdfPCell(new Phrase("Dr", titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);

                    cell = new PdfPCell(new Phrase("Cr", titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);

                    
                    cell = new PdfPCell(new Phrase("Balance MUR", titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);

                    float[] widths = new float[] { 0.80f, 1.5f, 0.80f, 0.80f, 0.80f };
                    producttable.SetWidths(widths);
                    string text;
                    int counta = 1;
                    double openbal=0;
                    
                    foreach (DataGridViewRow row in invoicelist.Rows)
                    {
                        int countrow = 1;
                        foreach (DataGridViewCell cell1 in row.Cells)
                        {
                            if (cell1.Value == null)
                            {
                                text = "";
                            }
                            else
                            {
                                text = cell1.Value.ToString();
                            }
                            
                            if ((countrow == 1) && (counta == 2))
                            {
                            
                                DateTime datecheck = Convert.ToDateTime(text);

                                //if (startdate <= datecheck)
                                //{
                                
                                    producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase("Opening Balance", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase("0", FontFactory.GetFont("Courier", 10))));
                                //}
                                //else
                                //{
                                //    using (IDbConnection connection1 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                                //    {
                                //        openbal= double.Parse(connection.ExecuteScalar($"SELECT SUM(Value) FROM statement WHERE (Company = '{CompName.Text}') AND (Date < '{fromY.Text}-{fromM.Text}-{fromD.Text}')").ToString());
                                //    }
                                //    text = String.Format("{0:f2}", openbal);
                                //    producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                                //    producttable.AddCell(new PdfPCell(new Phrase("Opening Balance", FontFactory.GetFont("Courier", 10))));
                                //    producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                                //    producttable.AddCell(new PdfPCell(new Phrase("", FontFactory.GetFont("Courier", 10))));
                                //    producttable.AddCell(new PdfPCell(new Phrase($"{openbal}", FontFactory.GetFont("Courier", 10))));
                                //}
                                balance = balance + openbal;

                                //if (double.TryParse(text, out dou))
                                //{
                                //    dou = double.Parse(text);
                                //    text = String.Format("{0:f2}", dou);
                                //}
                            }
                            countrow = countrow +1;
                            //producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                        }
                        counta = counta + 1;
                    }
                    string typeTxt = "";
                    bool dr = false;
                    bool cr = false;
                    int rowcount = 0;
                    foreach (DataGridViewRow row in invoicelist.Rows)
                    {
                        counta = 1;
                        foreach (DataGridViewCell cell1 in row.Cells)
                        {
                            if ((counta == 1) && (rowcount != 0))
                            {
                                if (cell1.Value == null)
                                {
                                    text = "";
                                goto Here;
                                }
                                else
                                {
                                    text = cell1.Value.ToString();
                                }
                            
                            int dateY = (int)double.Parse(text.Substring(6, 4));
                            int dateM = (int)double.Parse(text.Substring(3, 2));
                            int dateD = (int)double.Parse(text.Substring(0, 2));
                            
                            DateTime datecheck = new DateTime(dateY, dateM, dateD);

                            if ((datecheck >= startdate) && (datecheck <= enddate))
                            {
                                producttable.AddCell(new PdfPCell(new Phrase($"{text}", FontFactory.GetFont("Courier", 10))));
                                }
                                else
                                {
                                    goto Here;
                                }
                            }
                            else if ((counta == 3) && (rowcount != 0))
                            {
                                if (cell1.Value == null)
                                {
                                    text = "";
                                }
                                else
                                {
                                    text = cell1.Value.ToString();
                                }
                                if (text == "DEPOSIT")
                                {
                                    dr = true;
                                    cr = false;
                                    typeTxt = "Deposit";
                                }
                                if (text == "WITHDRAW")
                                {
                                    dr = false;
                                    cr = true;
                                    typeTxt = "Withdrawal";
                                }
                            if (text == "CHEQUE WITHDRAW")
                            {
                                dr = false;
                                cr = true;
                                typeTxt = "Cheque Claim";
                            }
                            if (text.Substring(0,7) == "Payment")
                                {
                                    dr = false;
                                    cr = true;
                                    typeTxt = text;
                                }
                            }
                            else if ((counta == 4) && (rowcount != 0))
                            {
                                if (cell1.Value == null)
                                {
                                    text = "";
                                }
                                else
                                {
                                    text = cell1.Value.ToString();
                                }
                                producttable.AddCell(new PdfPCell(new Phrase($"{typeTxt} Ref {text}", FontFactory.GetFont("Courier", 10))));

                            }
                            else if ((counta == 5) && (rowcount != 0))
                            {
                                if (cell1.Value == null)
                                {
                                    text = "0";
                                }
                                else
                                {
                                    text = cell1.Value.ToString();
                                }
                                
                                double bal = Convert.ToDouble(text);
                                balance = balance + bal;


                                if (dr == true)
                                {
                                    double value = Math.Abs(double.Parse(text));
                                    producttable.AddCell(new PdfPCell(new Phrase($"{value}", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase($"", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase($"{balance}", FontFactory.GetFont("Courier", 10))));
                                }
                                else if (cr== true)
                                {
                                    double value = Math.Abs(double.Parse(text));
                                    producttable.AddCell(new PdfPCell(new Phrase($"", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase($"{value}", FontFactory.GetFont("Courier", 10))));
                                    producttable.AddCell(new PdfPCell(new Phrase($"{balance}", FontFactory.GetFont("Courier", 10))));
                                }
                            }

                            counta = counta + 1;


                        }
                    Here:
                        counta = 1;
                        rowcount = rowcount + 1;
                    }
                    pdfReport.Add(producttable);


                    pdfReport.Close();

                    System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\STATEMENT_OF_ACCOUNT\\Statement{fromY.Text}{fromM.Text}{fromD.Text}to{toY.Text}{toM.Text}{toD.Text}_{saveno}.pdf");



                //}
                //catch (Exception)
                //{

                //}


                //for (int i = 0; i < invoicelist.Rows.Count; ++i)
                //    {

                //        balance += (double)Convert.ToInt32(invoicelist.Rows[i].Cells[4].Value);
                //    }

            }


        }

        private void CompList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompName.Text = CompList.SelectedCells[0].Value.ToString();


        }
    }
}
