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
            return View(new Customer());
        }

        // Model Binding

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            Customer lastCustomer = null;
            if (CustomerContext.Customers.Count > 0)
            {
                lastCustomer = CustomerContext.Customers.Last();
            }

            customer.Id = 1;
            if (lastCustomer != null)
            {
                customer.Id = lastCustomer.Id + 1;
            }

            CustomerContext.Customers.Add(customer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var removedCustomer = CustomerContext.Customers.Find(I => I.Id == id);
            CustomerContext.Customers.Remove(removedCustomer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a => a.Id == id);

            return View(updatedCustomer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {

            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(a => a.Id == customer.Id);

            updatedCustomer.FirstName = customer.FirstName;
            updatedCustomer.LastName = customer.LastName;
            updatedCustomer.Age = customer.Age;

            return RedirectToAction("Index");
        }

    }
}
