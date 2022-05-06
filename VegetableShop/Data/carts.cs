using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
     public class carts
    {
        [Key]
        public int id { get; set; }
        public products products { get; set; }
        public int product_id { get; set; }
        public users users { get; set; }
        public int user_id { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
