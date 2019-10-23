using System;
using System.Collections.Generic;
namespace StarWarsDictionary
{
    class Program
    {
        // create a dictionary of star wars character
        // keys tring , vlaues bools
        // strings charatcers, bools are true if they are a jedi

        static void Main(string[] args)
        {
            Dictionary<string, bool> starWarsCharacters =
                new Dictionary<string, bool>
                {
                    {"Anakin Skywalker",true},
                    {"Jar Jar Binx",false},
                    {"Frodo,", false},
                    {"R2D2", false },
                    {"Darth Maul", true},
                    {"Captain Picard", false },
                    {"Yoda", true },

                };

            starWarsCharacters.Add("Han Solo", false);
            foreach(KeyValuePair<string,bool> kvp in starWarsCharacters)
            {
                // need to specify values because foreach cannot covert
                PrintCharacters(kvp);

            }

                 
        }
        public static void PrintCharacters(KeyValuePair<string,bool> character)
        {
            if (character.Value == true)
            {
                Console.WriteLine($"{character.Key} has the force");
            }

            else
            {
                Console.WriteLine($"{character.Key} does not have the force");
            }
        }
       

    } 
    

}
