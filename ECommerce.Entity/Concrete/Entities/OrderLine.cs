using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class OrderLine:Entity
    {
        public long OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
