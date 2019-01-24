using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class ShoppingCardDto:Dto
    {
        public long ProductId { get; set; }
        public virtual ProductDto Products { get; set; }
        public long CustomerId { get; set; }
        public virtual CustomerDto Customers { get; set; }
        public DateTime ReservationTime { get; set; }



    }
}
