using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class ProductImage:Entity
    {
        public string ProductImageName { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
        public long CategoryId { get; set; }
        public Category Category  { get; set; }
    }
}
