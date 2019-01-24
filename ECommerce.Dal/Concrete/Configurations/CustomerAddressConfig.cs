using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    class CustomerAddressConfig : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder
                .HasOne(x => x.Customer)
                .WithOne(x => x.CustomerAddress)
                .HasForeignKey<CustomerAddress>(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Address)
                .WithOne()
                .HasForeignKey<CustomerAddress>(x => x.AddressId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
