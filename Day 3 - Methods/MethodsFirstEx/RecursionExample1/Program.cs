using System;

namespace RecursionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true; 
            while (keepGoing)
            {
                // do the things 


                // do you want to continue?
                keepGoing = GetContinue();
            }
            Console.WriteLine($"Okay, bye!");

            public static bool GetContinue()
            {
                // input from iser on whether they want to conintue (y/n)
                Console.WriteLine($"Would you like to continue? y/n");
                // processing - if y, retun true, if n, return false,
                // if neither, call GetContinue() 
                string userinput = Console.ReadLine();

                switch (userinput.ToLower())
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        return GetContinue(); 
                }
                  

            }
        }
    }
}
