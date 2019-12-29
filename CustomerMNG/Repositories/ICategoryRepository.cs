using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;

namespace CustomerMNG.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategory();
    }
}
