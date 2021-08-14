using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    // DataAnnotation
    public class Customer
    {
        //[Required(ErrorMessage = "error Id")]
        public int Id { get; set; }
        //[Required(ErrorMessage = "cannot be empty")]
        //[MaxLength(40, ErrorMessage = "error max length")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "cannot be empty")]
        //[MinLength(3, ErrorMessage = "error min length")]
        public string LastName { get; set; }
        //[Range(18, 50, ErrorMessage = "error range")]
        public int Age { get; set; }
    }
}
