using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaceExample3
{
    class Rhombus:IShape
    {
       public double Line { get; set; }
       public double Height { get; set; }
         // these are what goes into a Rhombus
        

        public Rhombus(double line, double height)
        {
            Line = line;
            Height = height;
        }

        public Rhombus() // these are the default values if there is nothing given for the Rhombus.
        {
            Line = 1;           
        }

        public double CalculateTheOutside()
        {
            return 4 * Line;
        }
        public double CalculateArea()
        {
            return Line*Height ;
        }
        public double CalculateVolume()
        {
            return 0;
        }

    }
}
