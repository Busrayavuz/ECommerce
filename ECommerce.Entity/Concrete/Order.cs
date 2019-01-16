using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete
{
    public class Order:Entity
    {
        public int  OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipName { get; set; }
        public long AddressId { get; set; }
        public virtual Address ShipAddress { get; set; }
        public virtual List<Customer> Customer { get; set; }

    }
}
