using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day24LastExample.Models
{
    public class Student
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [Range(typeof(DateTime), "1/1/1900", "11/14/2001", ErrorMessage = "Age not valid")] // checking the date to only allow a certain range for DOB. 
        public DateTime Date { get; set; }

        public double GPA { get; set; }

       
    }
}
