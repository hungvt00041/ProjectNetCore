using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerMNG.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var listProducts = _service.GetAllProduct();
            return View(listProducts);
        }
    }
}