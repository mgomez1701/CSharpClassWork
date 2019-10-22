using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Pair_Assigment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("Hello, what is your name ");
            // user input
            string studentName = Console.ReadLine();

            //input
            Console.Write("What is your age? ");
            //user input
            string studentAge = Console.ReadLine();
            byte age = byte.Parse(studentAge);
       

            //input
            Console.Write("What class do you fall in? ");
            //user input 
            string studentClass = Console.ReadLine();

            //input
            Console.Write("What is your GPA? ");
            string studentGPA = Console.ReadLine();
            float gpa = float.Parse(studentGPA);
           
            Console.Write("What school do you attend? ");
            string studentUniversity = Console.ReadLine();

            Console.Write("When is your start date? ");
            string studentStartdate = Console.ReadLine();
            // processing - converting studentStart into firstDay 
            DateTime firstDay = DateTime.Parse(studentStartdate);

            Console.ForegroundColor = ConsoleColor.Magenta;


            // output - Just the month example
            Console.WriteLine($"You will be going to school {firstDay.Month}");


            Console.Write("{0}, you are {1}. You attend {2}. Your GPA is {3}. Your class is {4} and you start {5}", studentName, age, studentUniversity, gpa, studentClass, studentStartdate);
            Console.Read();



        }
    }
}
