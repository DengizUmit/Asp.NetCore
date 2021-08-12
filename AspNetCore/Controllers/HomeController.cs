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

            Customer lastCustomer = null;
            if (CustomerContext.Customers.Count > 0)
            {
                lastCustomer = CustomerContext.Customers.Last();
            }

            int id = 1;
            if (lastCustomer != null)
            {
                id = lastCustomer.Id + 1;
            }

            CustomerContext.Customers.Add( new Customer
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            });

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var id = int.Parse(RouteData.Values["id"].ToString());

            var removedCustomer = CustomerContext.Customers.Find(I => I.Id == id);
            CustomerContext.Customers.Remove(removedCustomer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update()
        {
            var id = int.Parse(RouteData.Values["id"].ToString());

            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a => a.Id == id);

            return View(updatedCustomer);
        }

        [HttpPost]
        public IActionResult UpdateCustomer()
        {
            var id = int.Parse(HttpContext.Request.Form["id"].ToString());

            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a => a.Id == id);

            updatedCustomer.FirstName = HttpContext.Request.Form["firstName"].ToString();
            updatedCustomer.LastName = HttpContext.Request.Form["lastName"].ToString();
            updatedCustomer.Age = int.Parse(HttpContext.Request.Form["age"].ToString());

            return RedirectToAction("Index");
        }

    }
}
