using System;

namespace ConsoleApp1
{
    class StringCalculator
    {
       

        public static double Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return 0;
            }
           
            {
                double sum = 0;
                foreach (char x in numbers)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += double.Parse(numbers[i].ToString());
                    }
                    return sum;
                }
                return sum;
            }
            
        }
    }
}
