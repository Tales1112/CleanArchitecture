using System.Collections.Generic;

namespace Application.Employees
{
    public interface IGetEmployeesListQuery
    {
        List<EmployeeModel> Execute();
    }
}