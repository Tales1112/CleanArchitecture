using Application.Interfaces.Infrastructure;
using Domain.Common;
using System.Linq;

namespace Persistence.Shared
{
    public abstract class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly IDatabaseContext _databaseContext;

        public Repository(IDatabaseContext database)
        {
            _databaseContext = database;
        }

        public IQueryable<T> GetAll()
        {
            return _databaseContext.Set<T>();
        }

        public T Get(int id)
        {
            return _databaseContext.Set<T>().Single(p => p.Id == id);   
        }
        public void Add(T entity)
        {
            _databaseContext.Set<T>().Add(entity);
        }
        public void Remove(T entity)
        {
            _databaseContext.Set<T>().Remove(entity);
        }
    }
}
