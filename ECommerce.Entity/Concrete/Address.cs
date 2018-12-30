using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete
{
    public class Address:Entity
    {
        public long DistrictId{ get; set; }
        public District District { get; set; }
        public long CountryId { get; set; }
        public Country Country { get; set; }
        public long CityId { get; set; }
        public City City { get; set; }
    }
}
