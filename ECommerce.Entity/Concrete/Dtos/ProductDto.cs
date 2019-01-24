using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class ProductDto:Dto
    {
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public string Explanation { get; set; }
        public long CategoryId { get; set; }
        public virtual CategoryDto Category { get; set; }
        public long ProductImageId { get; set; }
        public virtual ProductImageDto ProductImage { get; set; }
        public virtual List<BrandDto> Brands { get; set; }
    }
}
