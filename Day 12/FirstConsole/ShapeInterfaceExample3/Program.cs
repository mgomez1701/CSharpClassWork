using System;
using System.Collections.Generic;

namespace ShapeInterfaceExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            // creat a list of Ishapes called shapes

            List<IShape> shapes = new List<IShape>
            {
                new Rhombus(5,17),
                new Rhombus(20,6),
                new Triangle(7.264, 8.45,12.6),
                new Triangle(11,8.77,4.8),
            };
            
            //
            foreach(IShape shape in shapes)
            {
                Console.WriteLine($"Shape 1: ");
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculateVolume());
               Console.WriteLine(shape.CalculateTheOutside());
               
                   
            }
        }
    }
}
