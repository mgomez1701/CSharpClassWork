using System;

namespace BuildingACalculatorWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my calculator!");
            Console.WriteLine("Please input your first number then select an option ");
            // TODO: write method for retriving user number
            decimal number1 = GetUserNumber();
            decimal number2;
            bool keepGoing = true;
            while (keepGoing)
            {
                
                PrintMenu(); // not storing anything here //

                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                    case "Addition":
                        // TODO: addition method
                        number2 = GetUserNumber();
                        number1 = AddNumbers(number1,number2);
                        Console.WriteLine($"Result: {number1}");
                        break;

                    case "2":
                    case "Subtraction":
                        // TO DO sub method
                        number2 = GetUserNumber();
                        number1 = SubtractNumbers(number1, number2);
                        Console.WriteLine($"Result: {number1}");
                        break;

                    case "3":
                    case "Multiply":
                        // TO DO multiply method
                        number2 = GetUserNumber();
                        number1 = MultiplyNumbers(number1, number2);
                        Console.WriteLine($"Result: {number1}");
                        break;
                    case "4":
                    case "Divide":
                        // TO DO division  method
                        number2 = GetUserNumber();
                        number1 = DivideNumbers(number1, number2);
                        Console.WriteLine($"Result: {number1}");
                        break;
                    case "5":
                    case "Percentage":
                        // TO DO write percentage method  
                        number1 = PercentageNumbers(number1);
                        Console.WriteLine($"Result: {number1}");

                        break;
                    case "6":
                    case "Clear":
                        // TO DO write clear 
                        number1 = GetUserNumber();
                        break;
                    case "7":
                    case "Exit":
                        // TO DO exit method
                        keepGoing = false;
                        break;
                }


            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Percent");
            Console.WriteLine("6. Clear");
            Console.WriteLine("7. Exit");

        }

        //TODO write GetUserNumber method//

        public static decimal GetUserNumber()
        {
            // input comes in as a sring
            string input = Console.ReadLine();
            decimal number = decimal.Parse(input);
            return number;
            // return decimal.Parse(console.readline()); way condesne way
        }

        public static decimal AddNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 + number2;
            return sum;
        }
        public static decimal SubtractNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 - number2;
            return sum;
        }   
        public static decimal MultiplyNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 * number2;
            return sum;
        }

        public static decimal DivideNumbers(decimal number1, decimal number2)
        {
            decimal sum = number1 / number2;
            return sum;

        }
        public static decimal PercentageNumbers (decimal number1)
        {
            decimal sum = number1 / 100;
            return sum;
        }
    }




}
