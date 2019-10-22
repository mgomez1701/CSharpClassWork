using System;

namespace CodeChallangeTwo
{
    class Program
    {
        //for each loop //

        //create static method that takes in string called ComtasParameter
        //return how many times "a" appears in the string
        // BONUS: add a second parameter char letter to search for the lenght of the string
        static void Main(string[] args)
        {
            int aCount = CountLetter("Ali Abawa"); // storing the method as in aCount becasue the method is returning an INT
            Console.WriteLine($"Expected  4, Actual: " + aCount);

            int letterCount = CountLetter("Babbaouie", 'b');
            Console.WriteLine($"Expected  4, Actual: " + letterCount);
        }

        public static int CountLetter(string word)
        {
            int count = 0;
            foreach (char letter in word.ToLower()) //chanhe word to lower//
            {
                if (letter == 'a')
                {
                    // make a count variable to store the number before foreeach//
                    count = count + 1; // adding a 1 for every a it finds//

                    // returns count//

                }
            }
            return count;

        }
        // here were are overloading the method we have right above//
        public static int CountLetter(string word, char findLetter)

        {
            int count = 0;
            foreach (char letter in word.ToLower())
            {
                if (letter == findLetter) // we are looking for findLetter here//
                {
                    count++; // same thing as count = count +1; from first method// 
                }
            }
            return count;
        }
    }
}
