using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .Ignore(x=>x.IsDeleted)
                .Ignore(x=>x.LastModifierDate)
                .Ignore(x=>x.LastModifierUserId)
                .HasMany(x => x.Cities)
                .WithOne(x => x.Country)
                .HasForeignKey(x=>x.CountryId);
        }
    }
}
