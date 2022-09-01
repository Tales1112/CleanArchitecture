using Application.Interfaces.Persistence;
using Domain.Sales;
using Persistence.Shared;

namespace Persistence.Sales
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(IDatabaseContext database) : base(database)
        {
        }
    }
}
