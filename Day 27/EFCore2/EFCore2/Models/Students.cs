using System;
using System.Collections.Generic;

namespace EFCore2.Models
{
    public partial class Students
    {
        public Students()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }

        public double? Gpa { get; set; }
        public int Tuition { get; set; }
        public DateTime? GradDate { get; set; }
        public int Id { get; set; }
        public int? PersonId { get; set; }

        public virtual Persons Person { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
