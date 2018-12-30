using ECommerce.Core.Entity;
using System;

namespace ECommerce.Entities.Concrete
{
    public class Order:Entity
    {
        public long CustomerId { get; set; }
        public long ProductId { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
