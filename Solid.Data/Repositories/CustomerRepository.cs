using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public bool AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            return true;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public bool RemoveCustomer(Customer customer)
        {
            return _context.Customers.Remove(customer);
        }

        public bool UpdateCustomer(Customer source, Customer customer)
        {
            return RemoveCustomer(source) && AddCustomer(customer);
        }

        public bool UpdateCustomerStatus(Customer customer, bool status)
        {
            var c = new Customer(customer);
            c.Status = status;
            return UpdateCustomer(customer, c);
        }
    }
}
