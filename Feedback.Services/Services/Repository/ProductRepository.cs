﻿using Feedback.DAL.Models;
using Feedback.Services.Services.Interface;
using Feedback2._0.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Feedback.Services.Services.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly Feedback2_0Context _usersDbContext;
        public ProductRepository(Feedback2_0Context context)
        {
            _usersDbContext = context;
        }
        public void AddProduct(Product product)
        {
            _usersDbContext.Products.Add(product);
            _usersDbContext.SaveChanges();
        }

        public bool Any(int? Id)
        {
            if (_usersDbContext.Products.Any(x => x.Id == Id))
            {
                return true;
            }
            return false;
        }

        public void DeleteProductById(int? id)
        {
            Product temp = _usersDbContext.Products.Find(id);
            _usersDbContext.Products.Remove(temp);
            _usersDbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _usersDbContext.Products.Include(x => x.FeedbackRatings).ToList();
        }

     /*   public IEnumerable<Product> GetAllProductById(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _usersDbContext.Products.Where(x => x.UserId == id).ToList();
        }
*/
        public Product GetProductById(int? id)
        {
            return _usersDbContext.Products.FirstOrDefault(p => p.Id == id);

        }

        public void UpdateProduct(Product product)
        {
            _usersDbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _usersDbContext.SaveChanges();
        }
    }
}
