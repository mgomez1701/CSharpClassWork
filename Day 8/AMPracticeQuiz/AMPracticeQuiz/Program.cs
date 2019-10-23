using System;

namespace AMPracticeQuiz
{
    class Program
    {

        // we are using a bool to find cat in the array//

        static void Main(string[] args)
        {
            string[] animals = { "Dog", "Cat", "Tiger", "Elephant", "Dolphin" };
            bool found = FindElement(animals, "cat");
            if (!found)
            {
                animals[0] = "cat";

            }

        }
        //Console.WriteLine(animals[1]);

        //for (int i = 0; i <= animals.Length - 1; i++)
        //{
        //    Console.WriteLine(animals[i]); // we need an if statment 

        //    // if (animals[i] == cat)
        //    {
        //        Console.WriteLine([i]);
        //    }

        //}


    

        public static bool FindElement(string[] array, string element)
        {
            // look at the array 
            foreach (string word in array)
            {
                if (word == element)
                {
                    return true; // we found what we are looking for. word/cat is in the animals/array
                }
            }
            return false; // we do not put an else statment becasue it will return false on the firt element before cat
        }


    }

}
  