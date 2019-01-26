using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    public class ShoppingCardConfig : IEntityTypeConfiguration<ShoppingCard>
    {
        public void Configure(EntityTypeBuilder<ShoppingCard> builder)
        {
            builder
               .HasOne(x => x.Product)
               .WithOne()
               .HasForeignKey<ShoppingCard>(x => x.ProductId)
               .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(x => x.Customer)
                .WithOne()
                .HasForeignKey<ShoppingCard>(x => x.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
