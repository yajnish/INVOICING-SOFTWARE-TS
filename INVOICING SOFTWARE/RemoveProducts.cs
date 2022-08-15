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

namespace INVOICING_SOFTWARE
{
    public partial class RemoveProducts : Form
    {
        List <Product> prod = new List <Product>();
        
        public RemoveProducts()
        {
            InitializeComponent();


        }
        
        private void prodList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVOICEDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iNVOICEDataSet.product);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            prodnamedel.Text = dataGridView2.SelectedCells[0].Value.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateRec_Click(object sender, EventArgs e)
        {
            if ((prodnamedel.Text != "") && (prodpricedel.Text != ""))
            {
                decimal d;
                if (decimal.TryParse(prodpricedel.Text, out d))
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        connection.Query($"UPDATE product SET unit_price = '{prodpricedel.Text}' WHERE product_name = '{prodnamedel.Text}';");
                        announceDel.Text = "Product price updated successfully!";
                    }
                }
                else
                {
                    announceDel.Text = "ERROR! Enter correct details please.";
                }

            }
            else
            {
                announceDel.Text = "ERROR! Enter correct details please.";
            }
        }

        private void deleteRec_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Do you want to remove this product?", "Warning", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    if (prodnamedel.Text != "")
                    {
                        try
                        {
                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                connection.Query($"DELETE FROM product WHERE product_name = '{prodnamedel.Text}';");
                                announceDel.Text = "Product removed successfully!";
                                InitializeComponent();
                            }

                        }
                        catch (Exception)
                        {
                            announceDel.Text = "ERROR!";
                        }


                    }
                    else
                    {
                        announceDel.Text = "ERROR! Enter correct details please.";
                    }
                }
                catch (Exception)
                {
                    announceDel.Text = "ERROR! Please restart the application";
                }
            }
                
            
        }
    }
}
