using ECommerce.Core.Entity;
using ECommerce.Entities.Concrete.Dtos;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class Product:Entity
    {
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public short UnitInStock { get; set; }     
        public string Explanation { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ProductImage> ProductImage { get; set; }
        public virtual List<Brand> Brands { get; set; }
    }
}
