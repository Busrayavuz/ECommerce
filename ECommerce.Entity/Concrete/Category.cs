﻿using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete
{
    public class Category:Entity
    {
        public string CategoryName { get; set; }
        public long? ParentCategoryId { get; set; }
        public string Description { get; set; }

        public virtual List<ProductImage> ProductImage { get; set; }
    }
}
