﻿using System;
using System.Threading.Tasks;
using TappIOS.Services;

namespace TappIOS.Domain.Customer.Services
{

    public interface ICustomerRepository : IGenericViewModel<Customer>
    {
        
    }

    public sealed class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {

    }
}

