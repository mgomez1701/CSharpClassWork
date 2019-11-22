using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    class Elephant:Mammal
    {
        public double SnoutLength { get; set; }
        public int TuskCount { get; set; }

        // constructor

        public Elephant(bool warmBlooded, string hairDescription, double snoutLength, int tuskCount): base(warmBlooded,hairDescription) // elephant contrctiro must have the
        {
            SnoutLength = snoutLength;
            TuskCount = tuskCount;
        }
          // we have to use override to write over the parent class method in 

        public override void MakeSound()
        {
            Console.WriteLine("rawr");
        }
         public override void Move()
        {
            Console.WriteLine("Trample");
        }
    }
}
