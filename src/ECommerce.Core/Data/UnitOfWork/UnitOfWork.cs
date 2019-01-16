using ECommerce.Core.Data.Repository;
using ECommerce.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _dbContext;
        private readonly IDictionary<Type, object> _repositories = new Dictionary<Type, object>();
        public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
              await Rollback();
              throw new Exception(ex.Message, ex);
            }
        }

        public IRepository<T> GetRepository<T>() where T : class, IEntity, new()
        {         
            return new Repository<T>(_dbContext);
        }

        private async Task Rollback()
        {
            await _dbContext
               .ChangeTracker
               .Entries()
               .AsQueryable()
               .ForEachAsync(x => x.Reload());
            //await  _dbContext.Database.CurrentTransaction.Rollback();
        }
    }
}
