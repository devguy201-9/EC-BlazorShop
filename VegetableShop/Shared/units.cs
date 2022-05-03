using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    public class units
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<products> products { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; }
    }
}
