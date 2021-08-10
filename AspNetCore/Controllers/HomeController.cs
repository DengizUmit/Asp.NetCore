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
            // ViewBag, ViewData, TempData, Model

            ViewBag.Name = "Ümit";
            ViewData["Name"] = "Yuri Boyka";
            TempData["Name"] = "Bruce Lee";

            Customer customer = new() { FirstName = "Ernesto Che", LastName = "Guevara", Age = 39 };

            return View(customer);
        }
    }
}
