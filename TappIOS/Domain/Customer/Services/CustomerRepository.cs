using System;
using TappIOS.Services;

namespace TappIOS.Domain.Customer.Services
{

    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        
    }

    public sealed class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {

    }
}

