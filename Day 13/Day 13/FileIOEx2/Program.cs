using System;
using System.Collections.Generic;
using System.IO;

namespace FileIOEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MovieCharacter> character = new List<MovieCharacter>()
           {
               new MovieCharacter("Columbus",true,"Lead",23),
               new MovieCharacter("Ruby Rose",true,"Lead",17),
               new MovieCharacter("Jack Skellington",true,"Lead",99),
               new MovieCharacter("Joker",false,"Lead",30),
               new MovieCharacter("Doug \"The Thug\"Glatt", true, "Lead", 30),
               new MovieCharacter("John Rambo",true,"Lead",75),
               new MovieCharacter("Lt Dan",true,"Supporting Actor",45),
               new MovieCharacter("SamWise Gamgee",true,"The Real MVP",102),


           };


            StreamWriter writer = new StreamWriter("../../../MovieCharacters.txt");
            foreach (MovieCharacter characters in character)
            {
                writer.WriteLine($"{characters.Name}| {characters.GoodBad}| {characters.Roll}| {characters.Age}");
            }
            writer.Close();
        }
    }
}
