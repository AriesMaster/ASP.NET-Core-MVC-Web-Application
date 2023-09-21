using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomersRepository
    {
        Customer GetById(int id);
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression);
        void Add(Customer customer);
        void AddRange(IEnumerable<Customer> customers);
        void Remove(Customer customer);
        void RemoveRange(IEnumerable<Customer> customers);
    }
}
