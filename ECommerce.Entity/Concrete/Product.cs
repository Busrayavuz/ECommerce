using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete
{
    public class Product:Entity
    {
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public long BrandId { get; set; }
        public virtual Brand Brands { get; set; }
        public string Explanation { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
     

        public virtual List<ProductImage> ProductImage { get; set; }
    }
}
