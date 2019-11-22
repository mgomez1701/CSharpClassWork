using System;
using System.Collections.Generic;

namespace EFCore2.Models
{
    public partial class Persons
    {
        public Persons()
        {
            Instructors = new HashSet<Instructors>();
            InverseStudent = new HashSet<Persons>();
            Students = new HashSet<Students>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? InstructorId { get; set; }

        public virtual Instructors Instructor { get; set; }
        public virtual Persons Student { get; set; }
        public virtual ICollection<Instructors> Instructors { get; set; }
        public virtual ICollection<Persons> InverseStudent { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
