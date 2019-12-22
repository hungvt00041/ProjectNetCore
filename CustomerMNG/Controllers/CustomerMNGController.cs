using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerMNG.Controllers
{
    public class CustomerMNGController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "HungVT", Age = 31 });
            customers.Add(new Customer { Name = "SonTT", Age = 15 });

            return View(customers);
        }

        public IActionResult Detail(string name, int age)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Age = age;

            return View(customer);
        }
    }
}