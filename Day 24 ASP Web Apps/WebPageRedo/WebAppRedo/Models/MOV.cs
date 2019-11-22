using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRedo.Models
{
    public class MOV
    {
        public string Type { get; set; }
        public string Description { get; set; }


        public MOV (string type, string description)
        {
            Type = type;
            Description = description; 
        }
    }
}
