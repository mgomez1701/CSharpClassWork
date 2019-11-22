using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object called classdefault 
            // all of the properties within class have default properties. No properites are set prior
            // creating an object of MyClass using the default constructor
            MyClass classDefault = new MyClass();
            Console.WriteLine(classDefault.MyProperty); // nothing will print here since the string is empty

            classDefault.MyProperty = "C#"; // resetting the value here that will thus allow it to get printed
            Console.WriteLine(classDefault.MyProperty);

            // creating an object of MyClass using the overloaded constructor
            MyClass classOverload = new MyClass("C# October 2019");
        }
    }
}
