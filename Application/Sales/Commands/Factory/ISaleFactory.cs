using Domain;
using Domain.Employees;
using Domain.Products;
using Domain.Sales;
using System;

namespace Application.Sales.Commands.Factory
{
    public interface ISaleFactory
    {
        Sale Create(DateTime date, Customer customer, Employee employee, Product product, int quantity);
    }
}