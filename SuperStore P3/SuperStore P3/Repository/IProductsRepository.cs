using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Models; // Replace 'Models' with the actual namespace for your product model

namespace EcoPower_Logistics.Repository
{
    public interface IProductsRepository
    {
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> Find(Expression<Func<Product, bool>> expression);
        void Add(Product product);
        void AddRange(IEnumerable<Product> products);
        void Remove(Product product);
        void RemoveRange(IEnumerable<Product> products);
    }
}
