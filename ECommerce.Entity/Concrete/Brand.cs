using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete
{
    public class Brand:Entity
    {
        public string BrandName { get; set; }
        public string Explanation { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
