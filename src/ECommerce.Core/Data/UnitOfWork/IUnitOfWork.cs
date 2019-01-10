using ECommerce.Core.Data.Repository;
using ECommerce.Core.Entity;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class, IEntity, new();
        Task<int> SaveChangesAsync();

        //void Rollback();
    }
}
