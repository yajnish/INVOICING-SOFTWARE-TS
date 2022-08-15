using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace INVOICING_SOFTWARE
{
    public class dataaccess
    {
        public List<Product> GetProducts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("INVOICEDB")))
            {
                return connection.Query<Product>($"SELECT  product_name FROM product").ToList();
            }
        }
    }
}
