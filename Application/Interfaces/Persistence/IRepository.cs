using System.Linq;

namespace Application.Interfaces.Infrastructure
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Remove(T entity);
    }
}
