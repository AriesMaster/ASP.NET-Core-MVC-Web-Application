using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Models; // Replace 'Models' with the actual namespace for your order model

namespace EcoPower_Logistics.Repository
{
    public interface IOrdersRepository
    {
        Order GetById(int id);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> Find(Expression<Func<Order, bool>> expression);
        void Add(Order order);
        void AddRange(IEnumerable<Order> orders);
        void Remove(Order order);
        void RemoveRange(IEnumerable<Order> orders);
    }
}
