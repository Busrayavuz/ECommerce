using ECommerce.Core.Data.Repository;
using ECommerce.Data.Abstract.Repositories;
using ECommerce.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data.Concrete.Repositories
{
    public class CountryCitiesRepository : Repository<Country>,ICountryCitiesRepository
    {
        public CountryCitiesRepository(DbContext context) : base(context)
        {
        }

        public async Task<IQueryable<Country>> WithCities()
            => (await base.AllAsync()).Include(x=>x.Cities);
    }
}
