using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    class Animal
    {

        public string Name { get; set; }
        public int age { get; set; }

        public Animal(string name,int age) // constructor 
        {
            this.Name = name;
            this.age = age;
        }

        public virtual void MakeSound() // adding virtual. this means this method can be overridden. the child classes can change it to fit their class. 
        {
            Console.WriteLine("I make a noise");
        }
    }

    class Dog : Animal
    {
        public int SticksFetched { get; set; }

        public Dog(string name, int SF) : base(name,SF) // Dog will be unhappy if there is no contructor using "base" to get the info 
        {
            this.SticksFetched = SF; 
        }

       
        public override void MakeSound()
        {
            base.MakeSound();
            //Console.WriteLine("I say \"woof\"!");
            Console.WriteLine($"{Name} says \"woof\"!"); // using incatination to get the Name of the dog from the parent class

        }
        public void FetchAStick()
        {
            SticksFetched++; // incrementing
        }

    }
    class Cat : Animal
    {
        public int HoursSlept { get; set; }

        
        public Cat(string name, int hoursSlept) : base(name, hoursSlept)
        {
            this.HoursSlept = hoursSlept; // we need o put in this body becaseu HoursSlept is not equaled to anythig anywhere else yet. 
        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine($"{Name} says \"meow'\"!");
        }
        public void AddHoursSlept()
        {
            if (HoursSlept >= 24)
            {
                Console.WriteLine("Is it alive?");
                

            }
            else
            {
                HoursSlept++;
            }
        }
    }

}
