using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class OrderLineDto:Dto
    {
        public string Name { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public long? ProductId { get; set; }
        public virtual ProductDto Product { get; set; }
        public long OrderId { get; set; }
        public virtual OrderDto Order { get; set; }
    }
}
