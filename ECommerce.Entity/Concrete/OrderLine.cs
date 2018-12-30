using ECommerce.Core.Entity;

namespace ECommerce.Entities.Concrete
{
    public class OrderLine:Entity
    {
        public int OrderId { get; set; }
        public decimal Quantity { get; set; }
    }
}
