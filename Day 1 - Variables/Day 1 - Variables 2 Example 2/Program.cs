using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1___Variables_2_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            // prompt 
            Console.Write("Enter your name: ");
            // get user input
            string name = Console.ReadLine();

            // prompt
            Console.Write("Enter yout city: ");
            // get user input
            string city = Console.ReadLine();

            // promt
            Console.Write("Enter your age ");
            // get user input

            string ageString = Console.ReadLine();
            // prompt
            Console.Write("Enter your pin ");
            // Get user info
            string pinString = Console.ReadLine();


            // process - convert age and pin
            byte age = byte.Parse(ageString);
            int birthYear = DateTime.Now.Year - age;


            // output
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("City: " + city); // not using placeholders in these examples here and below //
            Console.WriteLine("Age: " + age + " Birth Year is: " + birthYear);
            Console.WriteLine("PIN: " + pinString);
            Console.ReadLine();




        }
    }
}
