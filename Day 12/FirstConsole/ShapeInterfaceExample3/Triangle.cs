using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeInterfaceExample3
{
    class Triangle : IShape
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public double Base { get; set; }

        public Triangle (double height, double length, double _base)
        {
            Height = height;
            Length = length;
            Base = _base;

        }

        public double CalculateTheOutside()
        {
            return Base * 3;
        }

        public double CalculateArea()
        {
            return Base * Height / 2;
        }

        public double CalculateVolume()
        {
            return (Base * Height * Length) / 2;
        }
    }
}
