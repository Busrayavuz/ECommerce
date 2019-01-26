using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                  .HasOne(x => x.Category)
                  .WithMany(x => x.Products)
                  .HasForeignKey(x => x.CategoryId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex((x => new { x.CategoryId, x.UnitInStock }))
               .IsUnique(true);

            builder
                .HasMany(x => x.Brands)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.ProductImage)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.ProductImageId)

                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
