﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop.Data
{
    public class roles
    {
        [Key]
        public int id { get; set; }
        public string role_name { get; set; }
        public int status { get; set; }
        public List<users> users { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}