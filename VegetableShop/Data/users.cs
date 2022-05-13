using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
    public class users
    {
        [Key]
        public int id { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
        public string full_name { get; set; }
        public string address { get; set; }
        public string cmnd { get; set; }
        public string password { get; set; }
        public string avatar { get; set; }
        public string phone_number { get; set; }
        public roles roles { get; set; }
        public List<product_ratings> product_ratings { get; set; }
        public List<carts> carts { get; set; }
        public List<orders> orders { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
