using System.Collections.Generic;
using TodoGeneric.Core.Entities;

namespace TodoGeneric.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);






    }
}
