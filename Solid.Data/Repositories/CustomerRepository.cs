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

        public Customer AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }

        public Customer? GetCustomerByPhonenum(string phonenum)
        {
            return _context.Customers.Where(c => c.PhoneNum == phonenum)?.First();
        }

        public Customer? GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer RemoveCustomer(int id)
        {
            var customer = GetCustomerById(id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer UpdateCustomer(Customer source, Customer customer)
        {
            _context.Customers.Remove(source);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer UpdateCustomerStatusById(Customer customer, bool status)
        {
            var c = new Customer(customer);
            c.Status = status;
            return UpdateCustomer(customer, c);
        }
    }
}
