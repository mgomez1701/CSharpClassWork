using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaceExample3
{
    interface IShape
    {
        double CalculateTheOutside();
        double CalculateArea(); // we are assuming there are already properties. so we are not putting parameters
        double CalculateVolume(); // intefaces are non-static

       


        
        
    }
}
