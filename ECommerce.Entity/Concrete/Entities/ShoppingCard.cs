using ECommerce.Core.Entity;
using System;

namespace ECommerce.Entities.Concrete.Entities
{
    public class ShoppingCard:Entity
    {
        public long ProductId { get; set; }
        public virtual Product Product{ get; set; }
        public long CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime ReservationTime { get; set; }

    }
}
