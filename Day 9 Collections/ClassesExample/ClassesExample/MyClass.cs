using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample
{
    public class MyClass
    {
        // fields 

        private string myProperty;

        // properties
        public string MyProperty
        {
            get
            {
                return myProperty;
            }
            set
            {
                myProperty = value;
            }
        }

        // methods 
        public MyClass() // default constructor does not get parameters
        {

        }
        // overloaded constructor
        public MyClass(string _MyProperty)
        {
            myProperty = _MyProperty;
                
        }


    }

 
}
