using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Data;
using CustomerMNG.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerMNG.Repositories
{
    public class ProductRepository : IProductRepository
    {   
        public readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public static List<Product> Products = new List<Product>();
        public void AddProduct(Product product)
        {
            try {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch(Exception e) { }
        }

        public List<Product> GetAllProduct()
        {
            //Products.Add(new Product { Name="Car", Price = 9999, Quantity = 3});
            //Products.Add(new Product { Name = "Computer", Price = 1000, Quantity = 5 });
                    try { return _context.Products.Include(x => x.Category).ToList(); }
                    catch(Exception e) {
                return null;
                    }
        }

        public Product GetProduct(Guid id)
        {
            return _context.Products.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
        }

        public void SaveProduct(Product product)
        {
            var item = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            //item.Id = product.Id;
            item.Name = product.Name;
            item.Quantity = product.Quantity;
            item.Price = product.Price;
            item.CategoryId = product.CategoryId;
            _context.SaveChanges();
        }
    }
}
