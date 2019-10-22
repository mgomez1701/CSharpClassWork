using System;

namespace DeclaringArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOne = new int[7]; // type[ ] arrayName = new type[length];
            arrayOne[0] = 55; // filling the first spot (0) with 55

            Console.WriteLine($"array[0]: {arrayOne[0]}");
            Console.WriteLine($"array[6]: {arrayOne[6]}");

            // Console.WriteLine($"array[1]: {arrayOne[7]}");
            //^ Results is an IndexOutOfRangeException

            Console.WriteLine(arrayOne); // this will not print out the elements of the array

            foreach(int number in arrayOne) // this will print out all elements of the array we have created
            {
                Console.WriteLine(number);
            }
        }

    }
}
