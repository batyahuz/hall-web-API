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
        public Customer AddCustomer(Customer customer);
        public IEnumerable<Customer> GetAllCustomers();
        public Customer? GetCustomerByPhonenum(string phonenum);
        public Customer? GetCustomerById(int id);
        public Customer RemoveCustomer(int id);
        public Customer UpdateCustomer(Customer source, Customer customer);
        public Customer UpdateCustomerStatusById(Customer customer, bool status);
    }
}
