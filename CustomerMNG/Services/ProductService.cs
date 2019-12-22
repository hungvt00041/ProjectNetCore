using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using CustomerMNG.Repositories;
using CustomerMNG.ViewModels;

namespace CustomerMNG.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public void AddProduct(Product product)
        {
            _repo.AddProduct(product);
        }

        public List<ProductViewModel> GetAllProduct()
        {
            var products = _repo.GetAllProduct();
            List<ProductViewModel> viewModels = new List<ProductViewModel>();
            foreach( var product in products)
            {
                viewModels.Add(new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    TotalPrice = CaculateTotalPrice(product),
                });
            }
            return viewModels;
        }
        public double CaculateTotalPrice(Product product)
        {
            return product.Quantity * product.Price;
        }
    }
}
