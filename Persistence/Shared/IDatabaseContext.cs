using Domain;
using Domain.Employees;
using Domain.Products;
using Domain.Sales;
using System.Data.Entity;
using Domain.Common;

namespace Persistence.Shared
{
    public interface IDatabaseContext
    {
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Employee> Employees { get; set; }
        IDbSet<Product>  Products { get; set; }
        IDbSet<Sale> Sales { get; set; }

        IDbSet<T> Set<T>() where T : class, IEntity;

        void Save();
    }
}
