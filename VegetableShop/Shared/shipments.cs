using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    class shipments
    {
        public int id { get; set; }
        public distributors distributors { get; set; }
        public int distributor_id { get; set; }
        public string shipment_code { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
