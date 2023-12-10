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
            return _customerRepository.GetCustomers().Where(c => c.Name.Contains(text));
        }

        public IEnumerable<Customer> GetCustomerByPhonenum(string phonenum, string? text = "")
        {
            return GetAllCustomers(text).Where(c => c.PhoneNum.Equals(phonenum));
        }

        public bool UpdateCustomerByPhonenum(string phonenum, Customer customer)
        {
            return _customerRepository.UpdateCustomer((Customer)GetCustomerByPhonenum(phonenum), customer);
        }

        public bool UpdateCustomerStatusByPhonenum(string phonenum, bool status)
        {
            return _customerRepository.UpdateCustomerStatus((Customer)GetCustomerByPhonenum(phonenum), status);
        }
    }
}
