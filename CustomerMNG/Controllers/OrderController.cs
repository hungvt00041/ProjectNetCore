using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Services;
using CustomerMNG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerMNG.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        private readonly IProductService _productservice;

        public OrderController(IOrderService service, IProductService productservice)
        {
            _service = service;
            _productservice = productservice;
        }
        public IActionResult Index()
        {
            var listOrders = _service.GetAllOrder();
            return View(listOrders);
        }

        public IActionResult Create()
        {
            OrderViewModel model = new OrderViewModel();
            model.ProductSelections = _productservice.GetAllProduct().Select(x=>new SelectListItem { Text = x.Name, Value = x.Id.ToString()}).ToList();
            return View(model);
        }

        public IActionResult SaveNew(OrderViewModel order)
        {
            _service.Add(order);
            return Redirect("Index");

        }
    }
}