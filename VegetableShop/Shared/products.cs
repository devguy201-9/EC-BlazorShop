using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    class products
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
        public int status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; }
    }
}
