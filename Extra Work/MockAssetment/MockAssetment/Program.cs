using System;

namespace MockAssetment
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(FindBuildingType(51));
            
            
          //   bool test = IsTheSame(3,9);
           //  Console.WriteLine(test); 
        }
        // create static method named isTheSame 
        // returns a bool and takes in two numbers int as parameters
        //if num 1 is = to num 2 return true
        // if num 1 is not equal to num 2 return false//

        public static bool IsTheSame(int num1, int num2)
        {

            if (num1 == num2)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        // create a static method name Subtract() that takes in 2 parameters, all doubles num 1 and num 2
        // return the diffrence of num1 - num2

        public static double Subtract(double num1, double num2)
        {
            double answer = num1 - num2;

            return answer;
        }

        // create a static method FindBuildingType()
        // takes in a number int as a parameter
  
        public static string FindBuildingType(int number)   

        {
            string result = ""; //is also a way we can store the string and then do result = "" and return outside the if statement//

            if (number >= 4 && number <= 10) 

            {
                result = "This is an office building";  // range if the nuymber is between 4 and 10 return "This is an office building"
                // we can use just return becasue the method is already returning a string. we no longer have to specify what to send//
               
            }

            else if (number >= 50)
            {
                result = $"This is a SUPER Skyscraper"; // if the number is over 50 return "This is a SUPER Skyscraper"
                
            }

            else if (number >= 11 && number <= 49)
            {
                result = $"This is a skyscraper!"; // If a number is between 11 and 49, return “This is a skyscraper!”

                
            }
            else if (number <= 3)
            {
                result =  $"This is a house";  // If the number is less than 3, return “This is a house!”
                
            }

            return result;
          
        }
            


    }


}
        
