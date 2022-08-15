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
    public partial class ChequeDepo : Form
    {
        public ChequeDepo()
        {
            InitializeComponent();
			chequedepol.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
			int monno = Convert.ToInt32(fromM.Text);
			int startdate = 1;
			int enddate = 30;

			switch (monno)
			{
				case 1:
					
					enddate = 31;

					break;
				case 2:
					
					int year = int.Parse(fromY.Text);
					
					if (DateTime.IsLeapYear(year))
					{
						enddate = 29;
					}
					else
					{
						enddate = 28;
					}
					break;
				case 3:
					
					enddate = 31;
					break;
				case 4:
					
					enddate = 30;
					break;
				case 5:
					
					enddate = 31;
					break;
				case 6:
					
					enddate = 30;
					break;
				case 7:
					
					enddate = 31;
					break;
				case 8:
					
					enddate = 31;
					break;
				case 9:
					
					enddate = 30;
					break;
				case 10:
					
					enddate = 31;
					break;
				case 11:
					
					enddate = 30;
					break;
				case 12:
                    enddate = 31;
					break;
				default:
					MessageBox.Show("Invalid Month");
					break;

			}

			DataTable dt = new DataTable();
			string queryString = $"SELECT * FROM receipt   WHERE (depoDate BETWEEN '{fromY.Text}-{fromM.Text}-{startdate}'AND '{fromY.Text}-{fromM.Text}-{enddate}')";
            try
            {
				using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {

					SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
					adapt.Fill(dt);

					chequedepol.DataSource = dt;

					

					var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
					Random rnd = new Random();
					int saveno = rnd.Next(1, 51);
					string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\CHEQUE DEPOSIT\\C{fromY.Text}{fromM.Text}_{saveno}.pdf";

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
					Font titleFont = FontFactory.GetFont("Courier");

					var spacer = new Paragraph("")
					{
						SpacingBefore = 10f,
						SpacingAfter = 10f,
					};
					pdfReport.Add(spacer);
					pdfReport.Add(spacer);
					pdfReport.Add(spacer);

					Paragraph title = new Paragraph($"Information about cheques to be deposited in the selected month:", titleFont);
					title.Alignment = 0;
					title.Font = FontFactory.GetFont("Helvetica Bold", 19);
					pdfReport.Add(title);

					chequedepol.Columns[0].HeaderText = "Receipt";
					chequedepol.Columns[1].HeaderText = "Invoice";
					chequedepol.Columns[2].HeaderText = "Date Paid";
					chequedepol.Columns[3].HeaderText = "Amount Paid";
					chequedepol.Columns[4].HeaderText = "Means";
					chequedepol.Columns[5].HeaderText = "Deposit Date (Cheque only)";
					chequedepol.Columns[6].HeaderText = "Cheque No";

					BaseColor couleur = new BaseColor(255, 255, 255);
					Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

					PdfPTable producttable2 = new PdfPTable(chequedepol.ColumnCount);
					producttable2.DefaultCell.Padding = 3;
					producttable2.WidthPercentage = 100;
					producttable2.HorizontalAlignment = Element.ALIGN_LEFT;
					producttable2.DefaultCell.BorderWidth = 1;
					couleur = new BaseColor(255, 255, 255);
					titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
					foreach (DataGridViewColumn column in chequedepol.Columns)
					{
						PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
						cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
						producttable2.AddCell(cell);
					}

					float[] widths2 = new float[] { 1f, 1f, 1f, 1f, 1f, 1f, 1f, };
					producttable2.SetWidths(widths2);

					foreach (DataGridViewRow row in chequedepol.Rows)
					{
						int counta = 1;
						foreach (DataGridViewCell cell in row.Cells)
						{
							string text = cell.Value.ToString();

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

							producttable2.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));



						}
					}
					pdfReport.Add(spacer);
					pdfReport.Add(spacer);

					pdfReport.Add(producttable2);

					pdfReport.Close();

					System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\INVOICING SOFTWARE\\REPORTS\\CHEQUE DEPOSIT\\C{fromY.Text}{fromM.Text}_{saveno}.pdf");

				}
				

			}
            catch (Exception)
            {
				MessageBox.Show("Error generating PDF Report!");
			}

		}

        private void ChequeDepo_Load(object sender, EventArgs e)
        {

        }
    }
}
