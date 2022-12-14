using Application.Interfaces.Infrastructure;
using Domain.Products;

namespace Application.Interfaces.Persistence
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
