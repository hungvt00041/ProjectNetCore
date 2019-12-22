using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;

namespace CustomerMNG.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public static List<Product> Products = new List<Product>();
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetAllProduct()
        {
            Products.Add(new Product { Name="Car", Price = 9999, Quantity = 3});
            Products.Add(new Product { Name = "Computer", Price = 1000, Quantity = 5 });
            return Products;
        }
    }
}
