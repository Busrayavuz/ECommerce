using ECommerce.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    class CustomerAddressDto:Dto
    {
        public long CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public long AddressId { get; set; }
        public virtual AddressDto Address { get; set; }
    }
}
