﻿using System;

namespace Day_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Days.Wednesday} is day {(int)Days.Wednesday}");
            string fourthDay = Enum.GetName(typeof(Days), 4);
            Console.WriteLine(fourthDay);

        }
    }
}