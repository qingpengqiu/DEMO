using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter FirstName")]
        public string FirstName { get; set; }
        [StringLength(100, ErrorMessage = "Last Name lenth should not greater than 100")]
        public string SecondName { get; set; }

        public int Salary { get; set; }

    }
}