using System;

namespace NestedForLoops
{
    // create statsic method called PrintMultiplicationTable
    // take in one int number
    // print table from i which starts at 1 and ends are out number
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiplicationTable(10);
        }

        public static void PrintMultiplicationTable (int number)
        {
            for (int i = 1; i<=number; i++)
            {
                // why we use a nested forloop 
                for (int j = 1; j <= number; j++)
                {
                    Console.Write($"\t {i * j}");
                }
            } Console.WriteLine();
        }
    }
}
