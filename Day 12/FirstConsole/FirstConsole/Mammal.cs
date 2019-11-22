using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    abstract class Mammal
    {
        // properties
        public bool WarmBlooded { get; set; }
        public string HairDescription { get; set; }

        //constructor
        public Mammal (bool warmBlooded, string hairDescription)
        {
            WarmBlooded = warmBlooded;
            HairDescription = hairDescription;
        }
        public Mammal()
        {

        }

        public abstract void MakeSound(); // semicolon becasue these do not have a body

        public abstract void Move(); // we will have to define these in the child classes before we can call. 

        // normal method. 
        public void BeAMammal()
        {
            MakeSound();
            Move();
        }


    }
}
