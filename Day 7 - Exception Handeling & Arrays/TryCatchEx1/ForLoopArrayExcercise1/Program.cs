using System;

namespace ForLoopArrayExcercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "dog", "tiger", "wombat", "emu", "cat", "platypus", "kangeroo", "koala bear", "huntsman spider" };

            ListOutArray(animals);
            
            // if we want to list out all the animals/elements we would use a forloop
        }

        public static void ListOutArray(string[]array) // lisitng out the array
        {
           for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
