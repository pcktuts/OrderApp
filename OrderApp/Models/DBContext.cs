﻿using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OrderApp.Models
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
       : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
           .HasMany(c => c.Orders)
           .WithOne(e => e.Customer);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(c => c.Product);
        }
    }
}
