using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class ProductImage:Entity
    {
        public string ProductImageName { get; set; }
        public List<Product> Products { get; set; }
    }
}
