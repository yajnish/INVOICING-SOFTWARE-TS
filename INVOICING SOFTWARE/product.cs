using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVOICING_SOFTWARE
{
    public class Product
    {
        public int product_id { get; set; }
        public string sku { get; set; }
        public string brand { get; set; }
        public string product_name { get; set; }
        public decimal unit_price { get; set; }

        public string listofprod
        {
            get
            {
                return $"{product_name}";
            }
        }
    }
}
