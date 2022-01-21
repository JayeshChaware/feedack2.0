using Feedback.DAL.Models;
using System.Collections.Generic;

namespace Feedback.Services.Services.Interface
{
    public interface IProduct
    {
        void AddProduct(Product product);
        void DeleteProductById(int? id);
        Product GetProductById(int? id);
        IEnumerable<Product> GetAllProduct();
        //public IEnumerable<Product> GetAllProductById(int? id);
        void UpdateProduct(Product product);
        bool Any(int? Id);

    }
}
