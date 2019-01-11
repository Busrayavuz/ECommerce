using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete
{
    public class Category:Entity
    {
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
