using System;

namespace ForLoopDecrement
{
    class Program
    {

        // create a static method called PrintOddNumbers
        // takes in an int number
        // prints all odd numbers from number to 0 

        static void Main(string[] args)
        {
            PrintOddNumbers(7);
        }

        public static void PrintOddNumbers(int number)
        {
            for (int i = number; i> 0; i--) // we are going high to low here. 
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
