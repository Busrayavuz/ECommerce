using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class CityDto:Dto
    {
        public string CityName { get; set; }
        public long CountryId { get; set; }
        public virtual CountryDto Country { get; set; }
    }
}
