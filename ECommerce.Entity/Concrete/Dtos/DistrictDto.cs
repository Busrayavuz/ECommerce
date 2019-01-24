using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class DistrictDto:Dto
    {
        public string DistrictName { get; set; }
        public int CountryId { get; set; }
        public virtual CountryDto Country { get; set; }
        public int CityId { get; set; }
        public virtual CityDto City { get; set; }
    }
}
