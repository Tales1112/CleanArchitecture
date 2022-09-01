using Application.Interfaces.Persistence;
using System.Linq;

namespace Application.Sales.Queries
{
    public class GetSaleDetailQuery : IGetSaleDetailQuery
    {
        private readonly ISaleRepository _repository;

        public GetSaleDetailQuery(ISaleRepository repository)
        {
            _repository = repository;
        }
        public SaleDetailModel Execute(int saleId)
        {
            var sale = _repository.GetAll()
               .Where(p => p.Id == saleId)
               .Select(p => new SaleDetailModel()
               {
                   Id = p.Id,
                   Date = p.Date,
                   CustomerName = p.Customer.Name,
                   EmployeeName = p.Employee.Name,
                   ProductName = p.Product.Name,
                   UnitPrice = p.UnitPrice,
                   Quantity = p.Quantity,
                   TotalPrice = p.TotalPrice
               })
               .Single();

            return sale;
        }
    }
}
