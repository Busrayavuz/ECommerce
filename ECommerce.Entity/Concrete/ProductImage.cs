using ECommerce.Core.Entity;

namespace ECommerce.Entities.Concrete
{
    public class ProductImage:Entity
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public string ProductImageName { get; set; }
    }
}
