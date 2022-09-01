using Application.Interfaces.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace Application.Customers
{
    public class GetCustomerListQuery : IGetCustomerListQuery
    {
        private readonly ICustomerRepository _repository;

        public GetCustomerListQuery(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public List<CustomerModel> Execute()
        {
            var customers = _repository.GetAll()
                .Select(p => new CustomerModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                });

            return customers.ToList();
        }
    }
}
