using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
    public class distributors
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public List<shipments> shipments { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
