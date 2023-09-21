using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data; // Replace with the appropriate namespace for your context
using Microsoft.EntityFrameworkCore;
using Models; // Replace with the appropriate namespace for your models

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository : IGenericRepository<Order>
    {
        private readonly SuperStoreContext _context;

        public OrdersRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        public void AddRange(IEnumerable<Order> orders)
        {
            _context.Orders.AddRange(orders);
        }

        public IEnumerable<Order> Find(Expression<Func<Order, bool>> expression)
        {
            return _context.Orders.Where(expression);
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.Find(id);
        }

        public void Remove(Order order)
        {
            _context.Orders.Remove(order);
        }

        public void RemoveRange(IEnumerable<Order> orders)
        {
            _context.Orders.RemoveRange(orders);
        }
    }
}
