using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoGeneric.Core.Entities;
using TodoGeneric.Core.Interfaces;
using TodoGeneric.Infrastructure.Data;

namespace TodoGeneric.Infrastructure.Repositories
{
    public class Repository<T> where T : BaseEntity , IRepository<T> 
    {
        private readonly DbSet<T> _entities;

        public Repository(TodoGenericContext context)
        {
            _entities = context.Set<T>();
        }
        public void Add(T entity) => _entities.Add(entity);  
        public void Delete(T entity) =>  _entities.Remove(entity);
        public IEnumerable<T> GetAll() => _entities.AsEnumerable();
        public T GetById(int id) => _entities.FirstOrDefault(x => x.Id == id);
        public void Update(T entity) =>_entities.Update(entity);
        
    }
}
