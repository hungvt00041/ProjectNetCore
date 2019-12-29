using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Data;
using CustomerMNG.Models;

namespace CustomerMNG.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public static List<Category> Categories = new List<Category>();

        public List<Category> GetAllCategory()
        {

            return _context.Category.ToList();

        }

    }
}
