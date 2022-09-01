using Application.Interfaces.Infrastructure;
using Domain.Employees;

namespace Application.Interfaces.Persistence
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
