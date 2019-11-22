using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _11._14._19FirstWebApp.Models
{
    public class Supers
    {
        [Required] // have to add to the system to use 
        [StringLength(25)]
        public string IRLName { get; set; }

        [Required]
        [StringLength(25, MinimumLength =3)]
        //[RegularExpression("PatternGoesHere")]
        public string SuperName { get; set; }

        public bool GoodOrBad { get; set; }

        //[Range(1,100)] 
        public int PowerLevel { get; set; }

        public string Universe { get; set; }

        public List <Powers> Powers { get; set; }

        public Supers() 
        {
        
        }

        public Supers(string irlName, string superName, bool goodOrBad, string universe, List<Powers> powers)
        {
            IRLName = irlName;
            SuperName = superName;
            GoodOrBad = goodOrBad;
            Universe = universe;
            Powers = powers; 

        }


        public Supers(string irlName, string superName, bool goodOrBad, string universe)
        {
            IRLName = irlName;
            SuperName = superName;
            GoodOrBad = goodOrBad;
            Universe = universe;
       

        }

    }
}
