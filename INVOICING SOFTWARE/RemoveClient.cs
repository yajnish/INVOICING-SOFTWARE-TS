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
    public partial class RemoveClient : Form
    {
        public RemoveClient()
        {
            InitializeComponent();
        }

        private void RemoveClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVOICEDataSet8.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.iNVOICEDataSet8.clients);
            // TODO: This line of code loads data into the 'iNVOICEDataSet1.clients' table. You can move, or remove it, as needed.
            //this.clientsTableAdapter.Fill(this.iNVOICEDataSet1.clients);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Do you want to remove this client?", "Warning", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    if (remCompanyName.Text != "")
                    {
                        try
                        {
                            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                            {
                                connection.Query($"DELETE FROM clients WHERE company_name = '{remCompanyName.Text}';");
                                announce.Text = "Client removed successfully!";
                            }

                        }
                        catch (Exception)
                        {
                            announce.Text = "ERROR! Please restart the application";
                        }

                    }
                    else
                    {
                        announce.Text = "ERROR! Enter correct details please.";
                    }
                }
                catch (Exception)
                {
                    announce.Text = "ERROR! Please restart the application";
                }
            }
                
        }

        private void updateContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (remContactNumber.Text != "")
                {
                    decimal d;
                    if (decimal.TryParse(remContactNumber.Text, out d))
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                        {
                            connection.Query($"UPDATE clients SET contact_number = '{remContactNumber.Text}' WHERE company_name = '{remCompanyName.Text}';");
                            announce.Text = "Client contact updated successfully!";
                        }
                    }
                    else
                    {
                        announce.Text = "ERROR! Enter correct details please.";
                    }

                }
                else
                {
                    announce.Text = "ERROR! Enter correct details please.";
                }
            }
            catch (Exception)
            {
                announce.Text = "ERROR! Please restart the application";
            }
        }

        private void updateAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if ((remStreet.Text != "") && (remCity.Text != ""))
                {

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        connection.Query($"UPDATE clients SET street_name = '{remStreet.Text}', city = '{remCity.Text}' WHERE company_name = '{remCompanyName.Text}';");
                        announce.Text = "Client address updated successfully!";
                    }
                }
                else
                {
                    announce.Text = "ERROR! Enter correct details please.";
                }
            }
            catch (Exception)
            {
                announce.Text = "ERROR! Please restart the application";
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            remCompanyName.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }
    }
}
