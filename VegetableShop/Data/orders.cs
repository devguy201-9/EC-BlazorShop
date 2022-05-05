using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
    public enum states
    {
        pending,
        processing,
        completed,
        cancelled,
        returned
    }

    public class orders
    {
        [Key]
        public int id { get; set; }
        public users users { get; set; }
        public int user_id { get; set; }
        public string note { get; set; }
        public float total_price { get; set; }
        public states state { get; set; }
        public List<order_details> order_details { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
