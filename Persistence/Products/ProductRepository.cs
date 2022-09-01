using Application.Interfaces.Persistence;
using Domain.Products;
using Persistence.Shared;

namespace Persistence.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
