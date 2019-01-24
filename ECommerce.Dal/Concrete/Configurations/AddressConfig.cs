using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                 .HasOne(x => x.District)
                 .WithMany()
                 .HasForeignKey(x => x.DistrictId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Country)
                .WithMany()
                .HasForeignKey(x => x.CountryId);

            builder
                .HasOne(x => x.City)
                .WithMany()
                .HasForeignKey(x => x.CityId);

            builder
                .HasMany(x => x.CustomersAddress)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
