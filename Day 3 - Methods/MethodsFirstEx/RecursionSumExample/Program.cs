using System;

namespace RecursionSumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = CalculateSumRecursively(1, 5);
            Console.WriteLine($"Expected was 15, Actual is: {sum}");
        }

        public static int CalculateSumRecursively(int number1, int number2)
        {
            int sum = number1;
            // make sure the two numbers givien are not equal//

            if (number1 < number2)
            {
                number1++;
                sum = sum + CalculateSumRecursively(number1, number2);
                // can write it sum += CalculateSumRecursively(number1, numebr2)
                
                return sum;
            }
            return sum;
        }
    }
}
