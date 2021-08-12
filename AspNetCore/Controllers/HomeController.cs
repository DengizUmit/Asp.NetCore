using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    // [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;

            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithForm()
        {
            var firstName = HttpContext.Request.Form["firstName"].ToString();
            var lastName = HttpContext.Request.Form["lastName"].ToString();
            var age = int.Parse(HttpContext.Request.Form["age"].ToString());

            var lastCustomer = CustomerContext.Customers.Last();

            var id = lastCustomer.Id + 1;

            CustomerContext.Customers.Add( new Customer
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            });

            return RedirectToAction("Index");
        }

    }
}
