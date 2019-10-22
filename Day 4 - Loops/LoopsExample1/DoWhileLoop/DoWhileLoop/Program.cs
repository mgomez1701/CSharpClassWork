using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("Bart", 9);
        }

        public static void PrintName(string userName, int number)
        {
            do
            {
                Console.WriteLine($"Hello, {userName}!");
                number--;
            }

            while (number < 0);
            
        }

    }
}
