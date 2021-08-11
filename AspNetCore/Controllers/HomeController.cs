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
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;

            return View(customers);
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
