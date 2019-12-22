using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;

namespace CustomerMNG.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        List<Product> GetAllProduct();

    }
}
