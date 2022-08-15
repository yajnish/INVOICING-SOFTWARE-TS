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

    public partial class Dashboard : Form
    {
        public string datetoday = DateTime.Now.ToString("yyyy/MM/dd");
        public Dashboard()
        {
            InitializeComponent();

            
                numINV.Text = DateTime.Now.ToString("ddd dd MMMM yyyy");
                //numRec.Text = connection.ExecuteScalar($"SELECT COUNT(*) FROM receipt").ToString();
            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }
        
        private void addProduct_Click(object sender, EventArgs e)
        {
            Add_Product addprod = new Add_Product();
            addprod.Show();
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            RemoveProducts remProd = new RemoveProducts();
            remProd.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClient addcl = new AddClient();
            addcl.Show();
        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            RemoveClient remClient = new RemoveClient();
            remClient.Show();
        }

        private void genInvoice_Click(object sender, EventArgs e)
        {
            GenerateInvoice geninv = new GenerateInvoice();
            geninv.Show();
        }

        private void genReceipt_Click(object sender, EventArgs e)
        {
            Receipt receiptshow = new Receipt();
            receiptshow.Show();
        }

        private void invReport_Click(object sender, EventArgs e)
        {
            Reports reportstabshow =new Reports();
            reportstabshow.Show();
        }

        private void CNnote_Click(object sender, EventArgs e)
        {
            CreditNote cn = new CreditNote();
            cn.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Do you want to close the program? Any unsaved work will be lost.", "Close Program?", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void numINV_TextChanged(object sender, EventArgs e)
        {

        }

        private void delivery_Click(object sender, EventArgs e)
        {
            delivery deliveryform = new delivery();
            deliveryform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void balance_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string queryString = $"SELECT saleID, products_sold, netamount, paymentmethod FROM sales WHERE date = '{datetoday}'";
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);
                grid.DataSource = dt;

                var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\DAILY SALES\\Sales{saveno}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\maste\OneDrive\Desktop\TOOLS SPECIALIST OP\RESOURCES\report.jpg";
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

                Paragraph title = new Paragraph($"Sales Report {DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                grid.Columns[0].HeaderText = "Sale ID";
                grid.Columns[1].HeaderText = "Products";
                grid.Columns[2].HeaderText = "Net Amount";
                grid.Columns[3].HeaderText = "Paid By";

                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                PdfPTable producttable2 = new PdfPTable(grid.ColumnCount);
                producttable2.DefaultCell.Padding = 3;
                producttable2.WidthPercentage = 100;
                producttable2.HorizontalAlignment = Element.ALIGN_LEFT;
                producttable2.DefaultCell.BorderWidth = 1;
                couleur = new BaseColor(255, 255, 255);
                titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable2.AddCell(cell);
                }

                float[] widths2 = new float[] { 1f, 4f, 2f, 1f };
                producttable2.SetWidths(widths2);

                foreach (DataGridViewRow row in grid.Rows)
                {
                    int counta = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string text;
                        if ((cell.Value == null))
                        {
                            text = "";
                        }
                        else
                        {
                            text = cell.Value.ToString();
                        }
                        

                        double d;
                       
                            if ((double.TryParse(text, out d))&&(counta !=1))
                            {
                                d = double.Parse(text);
                                text = String.Format("{0:f2}", d);
                            }
                        

                        counta = counta + 1;

                        producttable2.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));



                    }
                }
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);

                pdfReport.Add(producttable2);

                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\maste\\OneDrive\\Desktop\\TOOLS SPECIALIST OP\\DAILY SALES\\Sales{saveno}.pdf");



            }


        }
        }
}
