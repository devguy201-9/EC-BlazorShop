using VegetableShop.Shared;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<categories> Categories { get; set; }
        public DbSet<products> Products { get; set; }
        public DbSet<units> Units { get; set; }

    }
}
