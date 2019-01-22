using ECommerce.Core.Data.Repository;
using ECommerce.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Abstract.Repositories
{
    public interface ICountryCitiesRepository:IRepository<Country>
    {
        Task<IQueryable<Country>> WithCities();
    }
}
