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
using Microsoft;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace INVOICING_SOFTWARE
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void general_Click(object sender, EventArgs e)
        {
            GenReport generalreport = new GenReport();
            generalreport.Show();

        }

        private void button1_Click(object sender, EventArgs e) //INVENTORY
        {
            DataTable dt = new System.Data.DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"SELECT sku, product_name, sellingprice, stock FROM product";
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

        private void chekdepo_Click(object sender, EventArgs e)
        {
            ChequeDepo chek = new ChequeDepo();
            chek.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientSaleReport clientsale = new ClientSaleReport();
            clientsale.Show();
        }

        private void CNReport_Click(object sender, EventArgs e)
        {
            CNReport creditn = new CNReport();
            creditn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statement stat = new Statement();
            stat.Show();


        }

        private void inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
