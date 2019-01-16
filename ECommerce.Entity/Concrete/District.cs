using ECommerce.Core.Entity;

namespace ECommerce.Entities.Concrete
{
    public class District:Entity
    {
        public string DistrictName { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int CityId { get; set; }
        public  virtual City City { get; set; }
    }
}
