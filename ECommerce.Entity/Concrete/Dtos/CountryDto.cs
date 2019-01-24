using ECommerce.Core.Dto;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class CountryDto:Dto
    {
        public string CountryName { get; set; }
        public virtual List<CityDto> Cities { get; set; }
    }
}
