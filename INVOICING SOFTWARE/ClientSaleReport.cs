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
    public partial class ClientSaleReport : Form
    {
        public ClientSaleReport()
        {
            InitializeComponent();
            inventory.Visible = false;
        }
        public string datetoday = DateTime.Now.ToString("yyyy/MM/dd");
        public string datetoday2 = DateTime.Now.ToString("yyyy/MM/dd");
        private void ClientSaleReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVOICEDataSet16.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iNVOICEDataSet16.product);
            // TODO: This line of code loads data into the 'iNVOICEDataSet9.clients' table. You can move, or remove it, as needed.
            //this.clientsTableAdapter.Fill(this.iNVOICEDataSet9.clients);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            bool bSuccess = false, bS2 = false;
            DateTime d1;
            datetoday = $"{fromY.Text}/{fromM.Text}/{fromD.Text}";
            datetoday2 = $"{toY.Text}/{toM.Text}/{toD.Text}";
            bSuccess = DateTime.TryParse(datetoday, out d1);
            bS2 = DateTime.TryParse(datetoday2, out d1);
            if (bSuccess == true && bS2 == true)
            {

                DataTable dt = new System.Data.DataTable();
                //DataTable dt2 = new DataTable();
                string queryString = $"select date, sku, product_name, quantity, salesid from productsale WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}') AND sku = {invSku.Text} ORDER BY date";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (skusearch.Text != "")
            {
                invSku.Text = skusearch.Text;
                try
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {


                        if ((connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'") == null))
                        {
                            invProdName.Text = "";
                            invBrand.Text = "";
                            invSku.Text = "";
                            //invUnitPrice.Text = "";
                            MessageBox.Show("Product does not exist in Database!");
                        }
                        else
                        {
                            invProdName.Text = connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'").ToString();
                            invBrand.Text = connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'").ToString();
                            //invUnitPrice.Text = connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'").ToString();
                        }


                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            invSku.Text = dataGridView2.SelectedCells[0].Value.ToString();
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                {


                    if ((connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'") == null) || (connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'") == null))
                    {
                        invProdName.Text = "";
                        invBrand.Text = "";
                        invSku.Text = "";
                        //invUnitPrice.Text = "";
                    }
                    else
                    {
                        invProdName.Text = connection.ExecuteScalar($"SELECT product_name FROM product WHERE sku = '{invSku.Text}'").ToString();
                        invBrand.Text = connection.ExecuteScalar($"SELECT brand FROM product WHERE sku = '{invSku.Text}'").ToString();
                        //invUnitPrice.Text = connection.ExecuteScalar($"SELECT costprice FROM product WHERE sku = '{invSku.Text}'").ToString();
                    }


                }
            }
            catch (Exception)
            {

            }
        }
    }
}
