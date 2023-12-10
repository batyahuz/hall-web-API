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
        IEnumerable<Customer> GetAllCustomers(string? text = "");
        IEnumerable<Customer> GetCustomerByPhonenum(string phonenum, string? text = "");
        Customer AddCustomer(Customer customer);
        bool UpdateCustomerByPhonenum(string phonenum, Customer customer);
        bool UpdateCustomerStatusByPhonenum(string phonenum, bool status);
    }
}
