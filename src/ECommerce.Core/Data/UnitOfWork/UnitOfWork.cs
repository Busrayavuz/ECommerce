using ECommerce.Core.Data.Context;
using ECommerce.Core.Data.Repository;
using ECommerce.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Core.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _dbContext;
        public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Rollback();
                throw ex;
            }
        }

        public IRepository<T> GetRepository<T>() where T : class, IEntity, new()
        {
            return new Repository<T>(_dbContext);
        }

        private void Rollback()
        {
            _dbContext.Database.CurrentTransaction.Rollback();
        }
    }
}
