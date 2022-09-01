using Domain;
using Domain.Employees;
using Domain.Products;
using Domain.Sales;

namespace Application.Sales.Commands.Repository
{
    public interface ISaleRepositoryFacade
    {
        void AddSale(Sale sale);
        Customer GetCustomer(int customerId);
        Employee GetEmployee(int employeeId);
        Product GetProduct(int productId);
    }
}