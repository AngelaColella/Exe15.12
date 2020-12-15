
using Exe.Help;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exe.Core.EF
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            string conn = Config.connectionString;
            optionBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.ApplyConfiguration<Product>(new ProductConfiguration());
        }
    }
}
