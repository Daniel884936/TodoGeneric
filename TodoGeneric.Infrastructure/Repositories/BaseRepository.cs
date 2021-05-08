using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoGeneric.Core.Entities;
using TodoGeneric.Core.Interfaces;
using TodoGeneric.Infrastructure.Data;

namespace TodoGeneric.Infrastructure.Repositories
{
    public abstract class BaseRepository<T>: IBaseRepository<T> where T : BaseEntity 
    {
        private readonly DbSet<T> _entities;
        private readonly TodoGenericContext _context;

        public BaseRepository(TodoGenericContext context)
        {
            _entities = context.Set<T>();
            _context = context;
        }
        public void Add(T entity) => _entities.Add(entity);  
        public void Delete(T entity) =>  _entities.Remove(entity);
        public IEnumerable<T> GetAll() => _entities.AsEnumerable();
        public T GetById(int id) => _entities.FirstOrDefault(x => x.Id == id);
        public void CommitChanges() => _context.SaveChanges();
        public async Task CommitChangesAsync() => await _context.SaveChangesAsync();
        public void Update(T entity) =>_entities.Update(entity);
    }
}
