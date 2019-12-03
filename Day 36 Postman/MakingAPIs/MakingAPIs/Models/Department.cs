using System;
using System.Collections.Generic;

namespace MakingAPIs.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employees>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public double Budget { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
