using System;
using System.Collections.Generic;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // we will not be using an abstract class in main

            Elephant troy = new Elephant(true, "balding", 1.75, 2);
            Turkey bill = new Turkey();
           
            Console.WriteLine(bill.IsMammal);
            List<Mammal> mammalList = new List<Mammal> { troy, bill };
            foreach(Mammal mammal in mammalList)
            {
                if(mammal is Turkey)
                {
                    Turkey thisTurkey = bill;
                    thisTurkey.FeatherCount = 1000000;
                }
                else
                {
                    Elephant elephant = troy;
                    elephant.BeAMammal();
                }
            }
        }
    }
}
