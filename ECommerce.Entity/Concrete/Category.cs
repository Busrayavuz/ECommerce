using ECommerce.Core.Entity;
using System.Linq;

namespace ECommerce.Entities.Concrete
{
    public class Category:Entity
    {
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }

        public IQueryable<Product> Products { get; set; }
    }
}
