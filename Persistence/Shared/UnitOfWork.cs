using Application.Interfaces.Persistence;

namespace Persistence.Shared
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext _database;

        public UnitOfWork(IDatabaseContext database)
        {
            _database = database;
        }
        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
