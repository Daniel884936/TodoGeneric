using System.Collections.Generic;
using TodoGeneric.Core.Entities;
using Ardalis.Result;
using System.Threading.Tasks;

namespace TodoGeneric.Core.Interfaces
{
    public interface IBaseService<TEntity, TReository> where TEntity : BaseEntity
    {
        Result<TEntity> GetById(int id);
        Result<IEnumerable<TEntity>> GetAll();
        Task<Result<TEntity>> Add(TEntity entity);
        Task<Result<TEntity>> Update(TEntity entity);
        Task<Result<bool>> Delete(int id);
    }
}
