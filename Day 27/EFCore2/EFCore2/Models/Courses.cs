using System;
using System.Collections.Generic;

namespace EFCore2.Models
{
    public partial class Courses
    {
        public Courses()
        {
            InverseInstructor = new HashSet<Courses>();
            StudentCourses = new HashSet<StudentCourses>();
        }

        public int Id { get; set; }
        public string Language { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? InstructorId { get; set; }

        public virtual Courses Instructor { get; set; }
        public virtual ICollection<Courses> InverseInstructor { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
