using System;

namespace IsVowelMock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsVowel(char c)
        {
            // create the vowels we need to check//
            string vowels = "aeiou";
            
            foreach (char v in vowels)
            {
                if(v==c)
                {
                    return true;
                }
            }
            return false;
        }
    }
        public static int CountVowels (string word)
        {
            int counter = 0;

            foreach (char c in word)
            {
                

            }


        }
}
