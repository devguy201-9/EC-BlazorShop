using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
{
    class product_ratings
    {
        public products products { get; set; }
        public int product_id { get; set; }
        public users users { get; set; }
        public int user_id { get; set; }
        public string comment { get; set; }
        public int point { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
