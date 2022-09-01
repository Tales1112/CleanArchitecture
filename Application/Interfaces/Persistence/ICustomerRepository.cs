using Application.Interfaces.Infrastructure;
using Domain;

namespace Application.Interfaces.Persistence
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
}
