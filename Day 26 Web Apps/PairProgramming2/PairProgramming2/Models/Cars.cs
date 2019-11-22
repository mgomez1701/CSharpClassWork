using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming2.Models
{
    public class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Cars()
        {


        }

        public Cars (string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;

        }
    }
}
