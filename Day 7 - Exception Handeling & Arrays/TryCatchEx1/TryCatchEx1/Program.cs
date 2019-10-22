using System;

namespace TryCatchEx1
{
    class Program
    {
        // take in user input
        // check format exeception
        // dividebyzeroexception
        // overflow exception
        // exception class 
        
        static void Main(string[] args)
        {
            try // think of this as if statment
            {
                Console.Write("Please enter a number: ");
                int input1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter another number: ");
                int input2 = int.Parse(Console.ReadLine());

                // dividing these two 

                int result = input1 / input2;
                Console.WriteLine(result);
            }
            catch (FormatException) // giving it a parameter ; we can look at this as else if 
            {
                Console.WriteLine("Bad Input. We need a number.");
            }
            catch (DivideByZeroException) // else if
            {
                Console.WriteLine("Can't divide by 0");
            }
            catch (OverflowException)
            {
                Console.WriteLine("That number is too big.");

            }
             catch // this is like the else statment
            {
                throw new Exception("Something went wrong");
            }


        }
    }
}
