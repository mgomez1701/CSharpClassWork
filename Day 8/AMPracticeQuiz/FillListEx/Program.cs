using System;
using System.Collections.Generic;

namespace FillListEx
{
    class Program
    {

        // take empty list 
        // take input from user to add to the list
        // post the list 

        static void Main(string[] args)
        {
            List<string> sportsPlayers = new List<string>();

            bool addPlayers = true;
            while (addPlayers)
            {
                // create a method to add players to the list
                AddtoList(sportsPlayers);

                // to exit the while loop 
                Console.WriteLine("Add more sports people?");
                string input = Console.ReadLine().ToLower();
                if (input == "no") // makes it easier to check for no
                {
                    addPlayers = false;
                }
            }
            // if user is done we want to list out the list created by user
            for (int i = 0; i < sportsPlayers.Count; i++)
            {              
                Console.WriteLine($"{sportsPlayers[i]}"); // listing the players
            }
        }
        public static void AddtoList (List<string>sportsPeople) // we are doing everything in this method. 
        {
            Console.WriteLine("Give me a sports person!");
            string player = Console.ReadLine();
            sportsPeople.Add(player);
        }
    }
}
