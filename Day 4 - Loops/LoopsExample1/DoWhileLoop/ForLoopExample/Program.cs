using System;

namespace ForLoopExample
{
    class Program
    {
        // Create Method called PrintName
        // take in string userName & int number
        // print Hello Usernmame number of time using a for loop
        static void Main(string[] args)
        {
            PrintName("Keanu Reeves", 47);
        }
        
        public static void PrintName (string userName, int number)
        {
            for (int i = 0; i < number; i++) // exits here. becasue of the incrementation
            {
                Console.WriteLine($"Hello, {userName}!");
            }
        }
    }
}
