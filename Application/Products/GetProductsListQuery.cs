using Application.Interfaces.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Application.Products
{
    public class GetProductsListQuery : IGetProductsListQuery
    {
        private readonly IProductRepository _repository;

        public GetProductsListQuery(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<ProductModel> Execute()
        {
            var products = _repository.GetAll()
                .Select(p => new ProductModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    UnitPrice = p.Price
                });

            return products.ToList();
        }
    }
}
