using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class Customer:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Passwordd { get; set; }
        public bool IsWomen { get; set; }
        public long AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
