using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    class Turkey : Mammal
    {
        public int FeatherCount { get; set; }
        public bool IsMammal  // these are optional. 
        {
          
            get { return false; }
        }
        public Turkey ()
        {

        }
        public Turkey (bool warmBlooded, string hairDescription, int featherCount, bool isMammal):base(warmBlooded,hairDescription)
        {
            FeatherCount = featherCount;
             
        }
        
       

        public override void MakeSound()
        {
            Console.WriteLine("Gobble Gobble"); // will throw this natrualy throw new NotImplementedException();
        }

        public override void Move()
        {
            Console.WriteLine("Trots");
        }
    }
}
