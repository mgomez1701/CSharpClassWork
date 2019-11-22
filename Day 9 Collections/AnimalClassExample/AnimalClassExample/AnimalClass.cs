using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClassExample
{
    class AnimalClass
    {
        #region field
        private string name;
        private string type;
        private string sound;
        private bool fur;

        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public  string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public bool Fur 
        {
            get { return fur; }
            set { fur = value; }
        }

        #endregion
        #region Constructs
        public AnimalClass()
        {

        }
        public AnimalClass(string _name, string _type, string _sound, bool _fur)
        {
            name = _name;
            type = _type;
            sound = _sound;
            fur = _fur;
        }


        #endregion
        public static List<string> GetAnimalTypes(List<AnimalClass> animals) // this was copied form the main method // // we can change this to private becasue its bot bein used anywhere else.
        {
            List<string> animalTypes = new List<string>(); // empty list at this point. just created

            foreach (AnimalClass animal in animals) // going through each animal in the animal list. 1st is whiskers the cat
            {
                if (!animalTypes.Contains(animal.Type)) // checking to see if list does not contains cat
                {
                    animalTypes.Add(animal.Type);
                }

            }
            return animalTypes;


        }

        public static void PrintAnimalTypes (List<AnimalClass>animalList)
        {
            List<string> animalTypes = AnimalClass.GetAnimalTypes(animalList);
            for (int i = 0; i < animalTypes.Count; i++)
            {
                Console.WriteLine($"{animalTypes[i]}, ");
            }
        }

        public static void PrintAnimalByType(List<AnimalClass> animalList, string selection)
        {
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
        }

    }
}
