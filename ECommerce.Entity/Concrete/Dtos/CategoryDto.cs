using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class CategoryDto:Dto
    {
        public string CategoryName { get; set; }
        public long? ParentCategoryId { get; set; }
        public string Description { get; set; }

        public virtual List<ProductImageDto> ProductImage { get; set; }
        public virtual List<ProductDto> Products { get; set; }
    }
}
