using System;

namespace CodeChallange
{
    class Program
    {
        //create a static method called CountAllTheNumbers
        // takes in an int number
        // The method should use a loop to sum all the numbers between number and 0
        // return the sum
        static void Main(string[] args)
        {
            CountAllNumbers(10);
        }

        public static int CountAllNumbers(int number)
        {

            int sum = 0; // this is saying we are starting at 0 before the for loop starts//

            for (int i = number; i >= 0; i--)
            {
                if (number >= 0)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                    
                    
                }
            } return sum;
           

        }

    }
}
