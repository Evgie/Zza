﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zza.Data;

namespace ZzaDashboard.Services
{
    public interface ICustomersRepository
    {
        Task<List<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerAsync(Guid id);
        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Customer> UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(Guid customerId);
        //void GetCustomerAsync(double v1, object p1, object p2, int v2, object c479618);
    }
}
