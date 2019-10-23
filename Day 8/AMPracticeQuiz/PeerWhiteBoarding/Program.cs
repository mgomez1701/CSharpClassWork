using System;
using System.Collections.Generic;

namespace PeerWhiteBoarding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = fruit = new List <string>()
            { "Apples", "Orange","Mango"};
            Console.WriteLine(fruit[1]);
            Console.WriteLine(fruit.Count);
            Console.WriteLine("Add another fruit to the list, please");

            fruit.Add(Console.ReadLine());

            foreach(string f in fruit)
            {
                Console.WriteLine(f);
            }
        }
    }
}
