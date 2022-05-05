using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
    public class shipments
    {
        [Key]
        public int id { get; set; }
        public distributors distributors { get; set; }
        public int distributor_id { get; set; }
        public string shipment_code { get; set; }
        public List<shipment_details> shipment_details { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
