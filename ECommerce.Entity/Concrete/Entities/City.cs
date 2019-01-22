using ECommerce.Core.Entity;

namespace ECommerce.Entities.Concrete.Entities
{
    public class City:Entity
    {
        public string CityName { get; set; }
        public long CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
