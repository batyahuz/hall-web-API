using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface ICustomerService
    {
        public Customer AddCustomer(Customer customer);
        public IEnumerable<Customer> GetAllCustomers(string? text = "");
        public Customer? GetCustomerByPhonenum(string phonenum, string? text = "");
        public Customer? UpdateCustomerByPhonenum(string phonenum, Customer customer);
        public Customer? UpdateCustomerStatusByPhonenum(string phonenum, bool status);
    }
}
