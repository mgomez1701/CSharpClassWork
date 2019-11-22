using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11._14._19FirstWebApp.Models
{
    public class Powers
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }

        public Powers(string name, int level, string description)
        {
            Name = name;
            Level = level;
            Description = description; 

        }
    }

   
}
