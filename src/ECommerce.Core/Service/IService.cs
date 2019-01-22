using ECommerce.Core.Dto;
using ECommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Service
{
    public interface IService
    {

    }
    public interface IService<TEntity,TDto>:IService
        where TEntity:class,IEntity
        where TDto:class,IDto
    {
        Task<TDto> GetAsync(long id);
        Task<List<TDto>> GetAllAsync();
        Task CreateAsync(TDto dto);
        Task UpdateAsync(TDto dto);
        Task DeleteAsync(long id);
    }
}
