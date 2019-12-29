using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerMNG.Services
{
    public interface ICategoryService
    {
        List<SelectListItem> GetAllCategory();
    }
}
