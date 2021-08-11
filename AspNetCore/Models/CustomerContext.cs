using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
            new Customer { FirstName = "Umit", LastName = "Dengiz", Age = 23 },
            new Customer { FirstName = "Cumali", LastName = "Hezex'i", Age = 18 }
        };
    }
}
