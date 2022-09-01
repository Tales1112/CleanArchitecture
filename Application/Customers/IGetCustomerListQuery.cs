using System.Collections.Generic;

namespace Application.Customers
{
    public interface IGetCustomerListQuery
    {
        List<CustomerModel> Execute();
    }
}