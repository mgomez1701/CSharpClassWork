using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExampleOne
{
    interface IAnimal
    {
        // these are just method bodies. 
        // these methods can return things they do not have to be void

        void MakeNoise();
        void Move();
        void Breathe();
        void Eat();

    }
}
