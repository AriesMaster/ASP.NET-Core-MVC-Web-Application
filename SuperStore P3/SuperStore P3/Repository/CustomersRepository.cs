using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data; // Replace with the appropriate namespace for your context
using Microsoft.EntityFrameworkCore;
using Models; // Replace with the appropriate namespace for your models

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly SuperStoreContext _context;

        public CustomersRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void AddRange(IEnumerable<Customer> customers)
        {
            _context.Customers.AddRange(customers);
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression)
        {
            return _context.Customers.Where(expression);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Remove(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public void RemoveRange(IEnumerable<Customer> customers)
        {
            _context.Customers.RemoveRange(customers);
        }
    }
}
