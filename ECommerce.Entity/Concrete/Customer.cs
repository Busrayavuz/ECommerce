﻿using ECommerce.Core.Entity;
using System.Linq;

namespace ECommerce.Entities.Concrete
{
    public class Customer:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Passwordd { get; set; }
        public bool IsWomen { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }
        public IQueryable<Order> Orders { get; set; }


    }
}
