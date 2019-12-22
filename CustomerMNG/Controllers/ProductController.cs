using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Services;
using CustomerMNG.ViewModels;
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

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult SaveNew(ProductViewModel product)
        {
            _service.AddProduct(product);
            return Redirect("Index");
        }

        public IActionResult View(Guid id)
        {
           var product = _service.GetProduct(id);
            return View(product);
        }

        public IActionResult Edit(Guid id)
        {
            var product = _service.GetProduct(id);
            return View(product);
        }

        public IActionResult Save(ProductViewModel product)
        {
            _service.SaveProduct(product);
            return Redirect("Index");
        }
    }
}