using System;
using System.Collections.Generic;

namespace EFCore2.Models
{
    public partial class Grades
    {
        public DateTime DueDate { get; set; }
        public int? Grades1 { get; set; }
        public string LabName { get; set; }
        public int Id { get; set; }
        public int? StudentCourseId { get; set; }

        public virtual StudentCourses StudentCourse { get; set; }
    }
}
