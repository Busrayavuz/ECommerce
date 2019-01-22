using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Concrete.Dtos
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AddressDto Address { get; set; }
    }
}
