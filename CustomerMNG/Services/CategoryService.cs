using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using CustomerMNG.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerMNG.Services
{
    public class CategoryService : ICategoryService

    {
        private readonly ICategoryRepository _repo;
        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public List<SelectListItem> GetAllCategory()
        {
            var categories = _repo.GetAllCategory();
            List<SelectListItem> listCategoriItems = categories.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();

            return listCategoriItems;
        }
    }
}
