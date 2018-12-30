using ECommerce.Core.Entity;
using System.Linq;

namespace ECommerce.Entities.Concrete
{
    public class Brand:Entity
    {
        public string BrandName { get; set; }
        public string Explanation { get; set; }

        public IQueryable<Product> Products { get; set; }
    }
}
