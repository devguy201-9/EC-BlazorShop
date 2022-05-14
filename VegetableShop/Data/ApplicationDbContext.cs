using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VegetableShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<categories> Categories { get; set; }
        public DbSet<products> Products { get; set; }
        public DbSet<units> Units { get; set; }
        public DbSet<carts> Carts { get; set; }
        public DbSet<distributors> Distributors { get; set; }
        public DbSet<order_details> Order_Details { get; set; }
        public DbSet<orders> Orders { get; set; }
        public DbSet<product_ratings> product_Ratings { get; set; }
        public DbSet<roles> Roles { get; set; }
        public DbSet<shipment_details> Shipment_Details { get; set; }
        public DbSet<shipments> Shipments { get; set; }
        public DbSet<users> Users { get; set; }
    }
}
