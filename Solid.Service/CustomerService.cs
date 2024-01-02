using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;

namespace Solid.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers(string? text = "")
        {
            return _customerRepository.GetAllCustomers().Where(c => c.Name.Contains(text));
        }

        public Customer? GetCustomerByPhonenum(string phonenum, string? text = "")
        {
            return _customerRepository.GetCustomerByPhonenum(phonenum);
        }

        public Customer? UpdateCustomerByPhonenum(string phonenum, Customer customer)
        {

            var cust = GetCustomerByPhonenum(phonenum);
            return cust == null ? null : _customerRepository.UpdateCustomer(cust, customer);
        }

        public Customer? UpdateCustomerStatusByPhonenum(string phonenum, bool status)
        {
            var source = GetCustomerByPhonenum(phonenum);
            return source == null ? null : _customerRepository.UpdateCustomerStatusById(source, status);
        }
    }
}
