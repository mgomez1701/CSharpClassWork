using System;

namespace LoopsExample1
{
    class Program
    {

        //create a static method called SayHello
        // method should take in a int number and write out "Hello while true " number times

        static void Main(string[] args)
        {
            SayHello(10); // no need to set becasue the method returns void
        }

        public static void SayHello(int number) // void becasue we are writing out hello while true// 
        {
            while (true)
            {
                Console.WriteLine($"Hello while true");
                number--; // number from the parameter decreases by one
                if (number == 7) // checking that number equals 0
                {
                    break; // exits out of the 
                }

            }

        }

    }
}
