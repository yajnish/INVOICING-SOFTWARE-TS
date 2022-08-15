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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void add_Client_Click(object sender, EventArgs e)
        {
            try
            {
                if ((brn.Text != "") && (companyName.Text != "") && (city.Text != "") && (contactnum.Text != ""))
                {

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
                    {
                        connection.Query($"INSERT INTO clients VALUES ('{ brn.Text }', '{ companyName.Text }', '{ vat.Text }', '{ street.Text }', '{ city.Text }', '{ contactnum.Text }')");
                        connection.Query($"INSERT INTO statement(Company, Type, Reference, Value) VALUES ('{companyName.Text}', 'Opening Balance', '', '0')");
                        announce.Text = "Client added successfully!";
                    }
                }
                else
                {
                    announce.Text = "ERROR! Enter correct details please.";
                }
            }
            catch (Exception)
            {
                announce.Text = "ERROR! Enter correct details please.";
            }
            
        }
    }
}
