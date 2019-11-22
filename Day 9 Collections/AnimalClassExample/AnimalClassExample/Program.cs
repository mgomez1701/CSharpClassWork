using System;
using System.Collections.Generic;

namespace AnimalClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is useful for the homewor
            // create list of animals 

            List<AnimalClass> animalList = new List<AnimalClass>
            {
                new AnimalClass("Whiskers", "Cat", "Meow", true),
                new AnimalClass("Scorsese", "Dog", "Woof", true),
                new AnimalClass("William Snakespeare", "Snake", "hiss", false),
                new AnimalClass("Nemo", "Fish", "Dad", false),
                new AnimalClass("Ron", "Rhino", "bellow", false),
                new AnimalClass("Fluffy", "Bear", "rawr", true),
                new AnimalClass("Nermal", "Cat", "meow", true),
                new AnimalClass("Fido", "Dog", "Woof", true),
            };

            List<string> something = AnimalClass.GetAnimalTypes(animalList);

            foreach(string s in something)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("What kind of animal do you want to see");
            AnimalClass.PrintAnimalTypes(animalList); // we need AnimalClass.PrintAnimalTypes becasue main needs to know what program to talk to. //displays the list 
            string selection = Console.ReadLine();
            AnimalClass.PrintAnimalByType(animalList, selection);

            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList[i].Fur) //changing wgaht it says based off true and false
                {


                    if (selection == animalList[i].Type) // this is telling us exactly where to look
                    {
                        Console.WriteLine($"{animalList[i].Name} is a {animalList[i].Type} that has fur and says {animalList[i].Sound}");
                    }
                    else
                    {
                        Console.WriteLine($"{animalList[i].Name} is a {animalList[i].Type} that does not have fur and says {animalList[i].Sound}");
                    }
                }
            }

            Console.WriteLine("What kind of animal would you like to see?");
            foreach (string types in AnimalClass.GetAnimalTypes(animalList)) //calling the strings in the Animal Class from the list we just created
            {
                // lets write out the options we have
                Console.WriteLine($"{types}, ");
            }

            // if we wanted to use a for loop 
            // you want to create a list firse
            List<string> animalTypes = AnimalClass.GetAnimalTypes(animalList);
            for (int i = 0; i < animalTypes.Count; i++)
            {
                Console.WriteLine($"{animalTypes[i]}, ");
            }


            / now we take in input from the user to choose which animals they would like to be shown
            /

            Console.WriteLine("What kind of animal would you like to see?");
            List<string> animalTypes = new List<string>(); // empty list at this point. just created
            foreach (AnimalClass animal in animalList) // going through each animal in the animal list. 1st is whiskers the cat
            {
                if (!animalTypes.Contains(animal.Type)) ; // checking to see if list does not contains cat
                {
                    animalTypes.Add(animal.Type);
                }

            }

        }
    }
}
