using System;
using System.Collections.Generic;

namespace ListExamples1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string>();
            movies.Add("Pulp Fiction");
            movies.Add("Midsommer");
            movies.Add("Braveheart");
            movies.Add("SuperBad");
            movies.Add("Pineapple Express");

            for(int i = 0; i < movies.Count; i++)
            {
                // listing out the movies, counting the movies
                Console.WriteLine($"{i+1}. {movies[i]}");
            }
        }
    }
}
