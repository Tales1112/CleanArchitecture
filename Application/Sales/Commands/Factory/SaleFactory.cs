using Domain;
using Domain.Employees;
using Domain.Products;
using Domain.Sales;
using System;

namespace Application.Sales.Commands.Factory
{
    public class SaleFactory : ISaleFactory
    {
        public Sale Create(DateTime date, Customer customer, Employee employee, Product product, int quantity)
        {
            var sale = new Sale();

            sale.Date = date;

            sale.Customer = customer;

            sale.Employee = employee;

            sale.Product = product;

            sale.UnitPrice = sale.Product.Price;

            sale.Quantity = quantity;

            // Note: Total price is calculated in domain logic

            return sale;
        }
    }
}
