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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace INVOICING_SOFTWARE
{
    public partial class GenReport : Form
    {
        public GenReport()
        {
            InitializeComponent();
            invoicelist.Visible = false;
            receiptlist.Visible = false;
        }
        public string datetoday = DateTime.Now.ToString("yyyy/MM/dd");
        public string datetoday2 = DateTime.Now.ToString("yyyy/MM/dd");
        private void GenReport_Load(object sender, EventArgs e)
        {


            //this.Close();
        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            //string queryString = $"select * from invoice_record WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";

            bool bSuccess = false, bS2 =false;
            DateTime d1;
            datetoday = $"{fromY.Text}/{fromM.Text}/{fromD.Text}";
            datetoday2 = $"{toY.Text}/{toM.Text}/{toD.Text}";
            bSuccess = DateTime.TryParse(datetoday, out d1);
            bS2 = DateTime.TryParse(datetoday2, out d1);
            if (bSuccess == true && bS2 == true)
            {

                DataTable dt = new System.Data.DataTable();
                //DataTable dt2 = new DataTable();
                string queryString = $"select saleID, date, customer, products_sold, netamount, taxamount, discount, paymentmethod from sales WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
                //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
                var table = new DataTable();

                using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {

                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                    adapt.Fill(dt);

                    inventory.DataSource = dt;

                    Excel.Application excel = new Excel.Application();
                    excel.Visible = true;
                    object Missing = Type.Missing;
                    Workbook workbook = excel.Workbooks.Add(Missing);
                    Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                    int StartCol = 1;
                    int StartRow = 1;
                    for (int j = 0; j < inventory.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                        myRange.Value2 = inventory.Columns[j].HeaderText;
                    }
                    StartRow++;
                    for (int i = 0; i < inventory.Rows.Count; i++)
                    {
                        for (int j = 0; j < inventory.Columns.Count; j++)
                        {

                            Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = inventory[j, i].Value == null ? "" : inventory[j, i].Value;
                            myRange.Select();
                        }
                    }



                }

            }
            else
            {
                MessageBox.Show("Invalid Date Entered!");
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
    }
}
