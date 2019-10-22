using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1___Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // input  - two numbers from the user 
            // promt user 
            Console.WriteLine("Give me a number, please");

            // receive input
            string userNumber1 = Console.ReadLine();

            // promt user 
            Console.WriteLine("Give me a 2nd number, please");
            string userNumber2 = Console.ReadLine();

            // process input - adding the two numbers together
            // parse string input into numbers
            int number1 = int.Parse(userNumber1);
            int number2 = int.Parse(userNumber2);
            //add the numbers together
            int sum = number2 + number1;

            //output- displaying the total
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);

        }
    }
}
