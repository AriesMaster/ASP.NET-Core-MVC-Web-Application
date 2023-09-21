using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data; // Replace with the appropriate namespace for your context
using Microsoft.EntityFrameworkCore;
using Models; // Replace with the appropriate namespace for your models

namespace EcoPower_Logistics.Repository
{
    public class ProductsRepository : IGenericRepository<Product>
    {
        private readonly SuperStoreContext _context;

        public ProductsRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void AddRange(IEnumerable<Product> products)
        {
            _context.Products.AddRange(products);
        }

        public IEnumerable<Product> Find(Expression<Func<Product, bool>> expression)
        {
            return _context.Products.Where(expression);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }

        public void RemoveRange(IEnumerable<Product> products)
        {
            _context.Products.RemoveRange(products);
        }
    }
}
