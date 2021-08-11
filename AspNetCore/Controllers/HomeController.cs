using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ITest test = new Test();
            ITest test2 = new Test2();

            // ViewBag, ViewData, TempData, Model
            ViewBag.Name = "Ümit";
            ViewData["Name"] = "Yuri Boyka";
            TempData["Name"] = "Bruce Lee";

            Customer customer = new() { FirstName = "Ernesto Che", LastName = "Guevara", Age = 39 };

            // return View(customer);

            return RedirectToAction("Index", "Product", new { @id = 1 });
        }

        public interface ITest
        {

        }

        public class Test : ITest
        {

        }

        public class Test2 : ITest
        {

        }
    }
}
