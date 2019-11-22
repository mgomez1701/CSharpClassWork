using System;
using System.Collections.Generic;

namespace EFCore2.Models
{
    public partial class Instructors
    {
        public Instructors()
        {
            Persons = new HashSet<Persons>();
        }

        public int? PersonId { get; set; }
        public DateTime HireDate { get; set; }
        public int Pay { get; set; }
        public int Id { get; set; }

        public virtual Persons Person { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
    }
}
