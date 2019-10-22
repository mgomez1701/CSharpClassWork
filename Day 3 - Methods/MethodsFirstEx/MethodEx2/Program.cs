using System;

namespace MethodEx2
{
    class Program
    {

        // create static method 
        // will be called ReadIntegers
        // take in string messge as a paramter
        // method will take in user input, convert to an integer and return //

        static void Main(string[] args)
        {
            int age = ReadIntegers("How old are you?");

            int year = ReadIntegers(" What year were you born?");

            Console.WriteLine($"You were born in {year} and you're {age} years old.");
        }

        public static int ReadIntegers(string message)
        {
            Console.WriteLine(message);
            // ask for user input //
            string userNumber = Console.ReadLine();
            // converts user input// 
            int number = int.Parse(userNumber);
            // takes the converted new variable and makes it a new number and ends the code// 
            return number;
        }

    }
}
