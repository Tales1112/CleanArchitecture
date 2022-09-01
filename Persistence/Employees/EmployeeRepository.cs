using Application.Interfaces.Persistence;
using Domain.Employees;
using Persistence.Shared;

namespace Persistence.Employees
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseContext context) : base(context) { }
    }
}
