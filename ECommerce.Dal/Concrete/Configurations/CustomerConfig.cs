using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.Concrete.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                 .HasOne(x => x.CustomerAddress)
                 .WithOne(x => x.Customer)
                 .HasForeignKey<CustomerAddress>(x=>x.CustomerId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
