using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
               .HasOne(x => x.Customers)
               .WithMany()
               .HasForeignKey(x=>x.CustomerId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.OrderLines)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
