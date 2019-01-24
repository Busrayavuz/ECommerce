using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class ProductImageDto:Dto
    {
        public string ProductImageName { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
