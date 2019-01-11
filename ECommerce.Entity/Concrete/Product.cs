using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public long BrandId { get; set; }
        public string Explanation { get; set; }
        public long MarkaId { get; set; }
        public long CategoryId { get; set; }


        public Category Category { get; set; }
        public Brand Brands { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}
