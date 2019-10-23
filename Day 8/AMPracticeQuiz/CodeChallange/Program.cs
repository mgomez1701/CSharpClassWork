using System;
using System.Collections.Generic;

namespace CodeChallange
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // write a mehtod called a reverse string that takes in a string and returns the reverse of that string
        public static string ReverseString(string element)
        {
            char[] broken = element.ToCharArray();
            List<char> reformed = new List<char>();
            for (int i = element.Length - 1; i >= 0; i--)
            {

                reformed.Add(element[i]);

            }
            return element;
        }

        //write a method called IsdivisiableBy that takes in a list of ints and int number
        //loop through the list parameter if a number from the list is divisible by the number parameter
        // add that that numbere to a new list and return that list

        public static List<int> IsDivisibeBy (List<int> numbers, int number)
        {
            List<int> numbers2 = new List<int>();
            foreach(int item in numbers)
            {
                if(item% number ==0)
                {
                    numbers2.Add(item);
                }
            }

            return numbers2;

        }
    }
            
}
