using System;

namespace FillArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = ParseString("How many countries"); // this allows the user to put as many countries as they like. Parsing to turn the int into string
            string[] countries = new string[arrayLength]; //

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = GetUserInput($"Country{i+1}: ");
            }

            ListOutArray(countries);

            // if we want to let the user be in control of which country they access

            int index = ValidateRange("Which country do you want to visit?",0, countries.Length); // we call Validate range here becasue it does 2 methods in one. This simplfies the code
            index--; // index = index - 1 
            Console.WriteLine($"You are visiting {countries[index]}");

        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine(); // can also store in a variable string input = console.readline() and return that 
        }
        public static void ListOutArray(string[] array) // lisitng out the array
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
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
        }
        public static int ValidateRange(string message, int min, int max)
        {
            int number = ParseString(message);
            if (number > min && number <= max)
            {
                return number;
            }

            else
            {
                return ValidateRange(message, min, max); // recurssion is being done here since we are calling parsesting within the same method// 
            }
        }
    }
}
