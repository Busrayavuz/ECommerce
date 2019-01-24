using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class BrandDto:Dto
    {
        public string BrandName { get; set; }
        public string Explanation { get; set; }
        public long ProductId { get; set; }
        public virtual ProductDto Product { get; set; }
    }
}
