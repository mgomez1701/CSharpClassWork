using System;

namespace TryCatchEx2
{
    class Program
    {
        // build two methods
        // first method will be static called GetUserInput()
        // takes in a string message
        // method should use the message to prompt the user for an input & return the input


        // write a static method called ParseString 
        // takes in a string message
        // method will call GetUserInput() & parse the string into an int and return int
        // use a try-catch to implement validation. the Try will return the int variable and the catch will use recurssion to call the ParseString method again

        static void Main(string[] args)
        { 
            int number = ParseString($"Give me a number");
            Console.WriteLine(number);
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine(); // can also store in a variable string input = console.readline() and return that 
        }
        public static int ParseString(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }
            catch
            {
                return ParseString(message); // recurssion is being done here since we are calling parsesting within the same method// 
            }

            // try catches are more used for validations // // somewhat easier than if statments if needing to validate//
        }
    }
}
