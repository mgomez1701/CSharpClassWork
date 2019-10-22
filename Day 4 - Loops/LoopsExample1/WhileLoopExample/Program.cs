using System;

namespace WhileLoopExample
{
    class Program
    {
        // create a static method called PrintName
        // takes in a string userName & an int number
        // print "Hello {userName} number of times using a while loop

            // this example shows a boolen expression and using math it breaks out of the while loop// 

        static void Main(string[] args)
        {
            PrintName("Grant Chirpus", 4); // calling the method and using the parameters
        }

        public static void PrintName (string userName, int number) // order matters on the assesments based off they are asked on the question asked// 
        {
            while (number!= 0)
            {
                Console.WriteLine($"Hello, {userName}");
                number--; // this gets us our the while loop and stops infinite WriteLines

            }
        }

    }

}
