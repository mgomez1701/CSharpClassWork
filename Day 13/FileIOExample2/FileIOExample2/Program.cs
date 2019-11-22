using System;
using System.Collections.Generic;
using System.IO;

namespace FileIOExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MovieCharacters> character = new List<MovieCharacters>()
           {
               new MovieCharacters("Columbus",true,"Lead",23),
               new MovieCharacters("Ruby Rose",true,"Lead",17),
               new MovieCharacters("Jack Skellington",true,"Lead",99),
               new MovieCharacters("Joker",false,"Lead",30),
               new MovieCharacters("Doug \"The Thug\"Glatt", true, "Lead", 30),
               new MovieCharacters("John Rambo",true,"Lead",75),
               new MovieCharacters("Lt Dan",true,"Supporting Actor",45),
               new MovieCharacters("SamWise Gamgee",true,"The Real MVP",102),


           };


            StreamWriter writer = new StreamWriter("../../../MovieCharacters.txt");
            foreach (MovieCharacters characters in character)
            {
                writer.WriteLine($"{characters.Name}| {characters.GoodBad}| {characters.Roll}| {characters.Age}");
            }
            writer.Close();

            /// print to console below 
            /// 
            //List<MovieCharacters> characters = new List<MovieCharacters>();
            //StreamReader reader = new StreamReader("../../../MovieCharacters.txt");
            //string line = reader.ReadLine();
            
            //while(line != null)
            //{
            //    string[] word = line.Split('|');
            //    characters.Add(new MovieCharacters((word[0]), bool.Parse(word[1]), word[2], int.Parse(word[3])));
            //    line = reader.ReadLine();

            //    foreach(MovieCharacters character in characters)
            //    {
            //        Console.WriteLine(character.Name);
            //    }
            //}



        }
    }
}
