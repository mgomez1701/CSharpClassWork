using System;

namespace MethodsEx3
{
    class Program
    {

        // find max that takes in two integers as perameters
        // method should compare the two numbers and return the larger

        static void Main(string[] args)
        {
            int max = FindMax(4, 5);
            // to test 
            Console.WriteLine($"Expected: 5, Result: " + max);
        }

        public static int FindMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            // each varibale in the parameter needs to be stored someway
            return num2;

            
        }
    }
}
