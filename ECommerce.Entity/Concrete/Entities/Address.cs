using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Entities
{
    public class Address:Entity
    {
        public long DistrictId{ get; set; }
        public virtual District District { get; set; }
        public long CountryId { get; set; }
        public virtual Country Country { get; set; }
        public long CityId { get; set; }
        public virtual City City { get; set; }
        public string Details { get; set; }
        public long  CustomerAddressId { get; set; }
        public virtual List<CustomerAddress>CustomersAddress { get; set; }
    }
}
