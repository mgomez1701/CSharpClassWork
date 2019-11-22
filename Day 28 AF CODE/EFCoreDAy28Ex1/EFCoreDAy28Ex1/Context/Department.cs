using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDAy28Ex1.Controllers.Context
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }

        public double Budget { get; set; }

        // since there is a 1 to many relationship we need to add the list to the department

        public virtual ICollection<Employee> Employees { get; set; }

        public Department()
        {

        }

        public Department (int departmentId, string name, string location, string type, double budget)
        {
            DepartmentId = departmentId;
            Name = name;
            Location = location;
            Type = type;
            Budget = budget;
        }


    }
}
