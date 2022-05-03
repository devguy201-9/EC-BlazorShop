using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    public class order_details
    {
        public products products { get; set; }
        public int product_id { get; set; }
        public orders orders { get; set; }
        public int order_id { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
