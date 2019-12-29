using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustomerMNG.Models;
using CustomerMNG.Repositories;
using CustomerMNG.ViewModels;

namespace CustomerMNG.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public void AddProduct(ProductViewModel product)
        {
            //Product productModel = new Product { Id = product.Id, Name = product.Name, Quantity = product.Quantity, Price = product.Price, CategoryId = product.CategoryId };
            //_repo.AddProduct(productModel);
            _repo.AddProduct(_mapper.Map<Product>(product));
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
                    CategoryId = product.CategoryId,
                    Category = product.Category,
                    TotalPrice = CaculateTotalPrice(product),
                }); ;
            }
            return viewModels;
        }
        public double CaculateTotalPrice(Product product)
        {
            return product.Quantity * product.Price;
        }

        public ProductViewModel GetProduct(Guid id)
        {
            var product = _repo.GetProduct(id);
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                Category = product.Category,
                CategoryId = product.CategoryId,
                TotalPrice = CaculateTotalPrice(product),
            };
        }

        public void SaveProduct(ProductViewModel product) {
            Product productModel = new Product { Id = product.Id, Name = product.Name, Quantity = product.Quantity, Price = product.Price, CategoryId = product.CategoryId };
            _repo.SaveProduct(productModel);
        }
    }
}
