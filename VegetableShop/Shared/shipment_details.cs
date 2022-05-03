using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    class shipment_details
    {
        public shipments shipments { get; set; }
        public int shipment_id { get; set; }
        public products products { get; set; }
        public int product_id { get; set; }
        public float purchase_price { get; set; }
        public float price { get; set; }
        public int quantity_sold { get; set; }
        public int current_quantity { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
