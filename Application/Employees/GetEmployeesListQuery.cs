using Application.Interfaces.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Application.Employees
{
    public class GetEmployeesListQuery : IGetEmployeesListQuery
    {
        private readonly IEmployeeRepository _repository;

        public GetEmployeesListQuery(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<EmployeeModel> Execute()
        {
            var employees = _repository.GetAll()
                .Select(p => new EmployeeModel
                {
                    Id = p.Id,
                    Name = p.Name
                });

            return employees.ToList();
        }
    }
}
