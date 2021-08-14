using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class CustomerCreateModel
    {
        [Required(ErrorMessage = "error Id")]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name cannot be empty")]
        [MaxLength(40, ErrorMessage = "First Name error max length")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name cannot be empty")]
        [MinLength(3, ErrorMessage = "Last Name error min length")]
        public string LastName { get; set; }
        [Range(18, 50, ErrorMessage = "Age error range")]
        public int Age { get; set; }
    }
}
