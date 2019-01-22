using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.DBContext
{
    public class ECommerceDataContext:DbContext
    {
        public ECommerceDataContext(DbContextOptions<ECommerceDataContext> options) : base(options)
        {
        }
        public DbSet<Product> Product{ get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ShoppingCard> ShoppingCard { get; set; }
        public DbSet<Brand> Brand { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
