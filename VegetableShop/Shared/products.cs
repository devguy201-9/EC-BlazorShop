using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    public class products
    {
        public int id { get; set; }
        public string product_code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string images { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public categories categories { get; set; }
        public int category_id { get; set; }
        public units units { get; set; }
        public int unit_id { get; set; }
        public List<product_ratings> product_ratings { get; set; }
        public List<carts> carts { get; set; }
        public List<order_details> order_details { get; set; }
        public List<shipment_details> shipment_details { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
