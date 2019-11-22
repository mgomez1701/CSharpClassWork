using System;
using System.Collections.Generic;

namespace BoardExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("The Dude", DateTime.Parse("1/1/2477"), "dude");
            Console.WriteLine(newPerson.Name);

            Person newPersonTwo = new Person("Khabib Nurmagomedov", DateTime.Parse("9/20/98"), "Man/Bear");
            Console.WriteLine(newPersonTwo.Name);

            Person newPersonThree = new Person("Princess Zelda", DateTime.Parse("02/21/1987"), "female");
            // instead of doing c.w over and over to print the person we can use a loop and a list that we have to make. 

            List<Person> people = new List<Person> { newPerson, newPersonTwo, newPersonThree };

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Gender}, was born on {person.DOB}"); // a way to call the specfic variable in the class 
            }

            // example of foreach finding strings in a list
            List<string> stringList = new List<string> { "A", "E", "I", "O", "U" };
            foreach(string s in stringList)
            {

            }
        }
    }
}
