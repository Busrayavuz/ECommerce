﻿using ECommerce.Core.Entity;
using System;

namespace ECommerce.Entities.Concrete
{
    public class ShoppingCard:Entity
    {
        public long ProductId { get; set; }
        public long CustomerId { get; set; }
        public DateTime ReservationTime { get; set; }

        public virtual Product Products { get; set; }
        public virtual Customer Customers { get; set; }
    }
}
