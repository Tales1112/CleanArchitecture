using System.Collections.Generic;

namespace Application.Products
{
    public interface IGetProductsListQuery
    {
        List<ProductModel> Execute();
    }
}