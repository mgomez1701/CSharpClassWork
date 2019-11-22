using System;
using System.Collections.Generic;

namespace WhiteBoard2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            int counter = 5;
            while(counter > 0)
            {
                int input;
                Console.WriteLine("Enter # Divisible By 5");
                try
                {
                    input = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                if(input %5 == 0)
                {
                    counter--;
                    number.Add(input); // adding input to the list up to a max 5 
                }
            }
        }
    }
}
