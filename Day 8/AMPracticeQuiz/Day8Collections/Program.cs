using System;
using System.Collections.Generic;

namespace Day8Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Tim");
            dictionary.Add(2, "Frank");
            dictionary.Add(3, "Jeff");

            // listing out our key value pairs 
            // how to access individual key value pairs in dictionary

            foreach(KeyValuePair<int,string> kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}. {kvp.Value}");
            }

            // to find an individial key in a dictionary

            Console.WriteLine(dictionary[1]);


        }
    }
}
