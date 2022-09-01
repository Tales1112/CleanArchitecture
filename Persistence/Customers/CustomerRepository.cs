using Application.Interfaces.Persistence;
using Domain;
using Persistence.Shared;

namespace Persistence.Customers
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
