using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using CustomerMNG.ViewModels;

namespace CustomerMNG.Services
{
    public interface IProductService
    {
         void AddProduct(ProductViewModel product);

         List<ProductViewModel> GetAllProduct();

         double CaculateTotalPrice(Product product);
        ProductViewModel GetProduct(Guid id);

        void SaveProduct(ProductViewModel product);
    }
}
