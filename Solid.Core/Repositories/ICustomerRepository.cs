using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        bool UpdateCustomer(Customer source, Customer customer);
        bool AddCustomer(Customer customer);
        bool RemoveCustomer(Customer customer);
        bool UpdateCustomerStatus(Customer customer, bool status);
    }
}
