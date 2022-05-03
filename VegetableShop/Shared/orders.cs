using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Shared
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
