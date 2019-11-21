using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day29IdentityFramework.Models
{
    public class Presidents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PresidentId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]

        public int Terms{ get; set; }
        public DateTime DateTime { get; }
        [Required]
        public DateTime InaugurationDate { get; set; }

        public Presidents()
        {

        }

        public Presidents(int id, string name, int terms, DateTime inaugurationDate)
        {
            PresidentId = id;
            Name = name;
            Terms = terms;
            DateTime = inaugurationDate;
        }
    }
}
