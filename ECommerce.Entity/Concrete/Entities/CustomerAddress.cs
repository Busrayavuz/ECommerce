using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Entities
{
    public class CustomerAddress:Entity
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
