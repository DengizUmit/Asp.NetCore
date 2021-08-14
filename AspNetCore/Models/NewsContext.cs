using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class NewsContext
    {
        public static List<News> List = new()
        {
            new News { Title = "News 1" },
            new News { Title = "News 2" }
        };
    }
}
