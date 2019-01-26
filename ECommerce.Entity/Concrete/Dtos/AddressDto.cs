using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class AddressDto:Dto
    {
        public long DistrictId { get; set; }
        public virtual DistrictDto District { get; set; }
        public long CountryId { get; set; }
        public virtual CountryDto Country { get; set; }
        public long CityId { get; set; }
        public virtual CityDto City { get; set; }
        public string Details { get; set; }
        public long CustomerAddressId { get; set; }
        public virtual CustomerAddressDto CustomersAddress { get; set; }
    }
}
