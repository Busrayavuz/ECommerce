using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class Brand:Entity
    {
        public string BrandName { get; set; }
        public string Explanation { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
