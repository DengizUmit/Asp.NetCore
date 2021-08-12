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
            new Customer { Id = 1, FirstName = "Umit", LastName = "Dengiz", Age = 23 },
            new Customer { Id = 2, FirstName = "Cumali", LastName = "Hezex'i", Age = 18 }
        };
    }
}
