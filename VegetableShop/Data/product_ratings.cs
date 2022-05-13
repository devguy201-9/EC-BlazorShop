﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
    public class product_ratings
    {
        [Key]
        public int id { get; set; }
        public products products { get; set; }
        public users users { get; set; }
        public string comment { get; set; }
        public int point { get; set; }
        public int status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
