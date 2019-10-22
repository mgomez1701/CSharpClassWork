using System;

namespace MethodOverLoading
{
    class Program
    {
        // create two methods 
        // first will take in sring and print hello string back to console
        // second will add another string langauge to the string name. This is overloading the method
  
        static void Main(string[] args)
        {
            GreetUser("Grant Chirpus");
            GreetUser("Latin", "Gomez");

        }

        public static void GreetUser(string name)
            // always ask yourself what is the return type//
        {
            Console.WriteLine($"Hello, {name}");

        }

        // overloading the method

        public static void GreetUser(string language, string name)
        {
            switch (language)
            {
                case "French":
                    Console.WriteLine($"Bonjour, {name}!");
                    break;
                case "German":
                    Console.WriteLine($"Guten Tag, {name}!");
                    break;
                case "Spanish":
                    Console.WriteLine($"Hola, {name}!");
                    break;
                case "Latin":
                    Console.WriteLine($"Salve, {name}!");
                    break;

            }
        }
    }
}
