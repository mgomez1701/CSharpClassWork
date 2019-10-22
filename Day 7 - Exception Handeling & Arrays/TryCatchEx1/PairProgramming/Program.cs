using System;

namespace PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Blue", "Red", "Green" };
            Console.WriteLine(colors[2]);

            Console.WriteLine(colors.Length);
            colors[2] = "White"; // accessng the index of the array h

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            for(int i = colors.Length-1; i >= 0; i--)
            {
                Console.WriteLine(colors[i]);
            }

            string[] names = { "Olga", "Brock", "Sebastian" };
            Array.Sort(names);

            string[] sortedNames = new string[names.Length];
            names.CopyTo(sortedNames, 0);
            foreach(string item in sortedNames)
            {
                
                //Array.Sort(item.ToCharArray());
                                                                // not complete yet
            }

            for(int x = 0; x < names.Length; x++)
            {
                Console.WriteLine($"names[{x}] {names[x]}", $"{sortedNames[x]}", $"{sortedNames[x]}");
            }
            

        }
    }
}
