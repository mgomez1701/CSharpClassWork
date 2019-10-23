using System;
using System.Collections.Generic;

namespace CodeChallange2Question1
{
    class Program
    {
        //wriete a method called findMin()
        // takes in a list of integers
        //returns the lowest number

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            bool addNumbers = true;
            while (addNumbers)
            {
                FindMin(intList);
            }

            foreach


        }

        public static int FindMin(List<int> numbers)
        {
            int smallest = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;

            // wriet a met

            public static string ReverseString(string element)
            {
                char[] broken = element.ToCharArray();
                List<char> reformed = new List<char>();
                for (int i = element.Length - 1; i >= 0; i--)
                {


                    return reformed.Add.element[i]));
        }
    }

                
