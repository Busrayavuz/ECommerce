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
               .HasMany(x => x.Customers)
               .WithOne(x => x.Order)
               .HasForeignKey(x=>x.OrderId);

            builder
                .HasMany(x => x.OrderLines)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

        }
    }
}
