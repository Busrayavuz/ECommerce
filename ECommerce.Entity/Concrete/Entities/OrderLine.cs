using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class OrderLine:Entity
    {
        public string Name { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }

        public long? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public long OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
