using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        // write a static method that takes in a string
        //COMPARES STRING AGAINST A REGULAR EXPRESSION
        // returns " Yay you did it" IF THE STRING MATCHES THE PATTERN

        static void Main(string[] args)
        {
            //Console.WriteLine(TestingOnTheReg("123-45-6789"));

            //Console.WriteLine(TestingOnTheReg("123456789"));



            //Console.WriteLine(ValidateNames("mikegomez"));


            //Console.WriteLine(ValidateEmails("michael005@yahoo.com"));

            Console.WriteLine(ValidateDate("10/03/1991"));
        }

        public static string TestingOnTheReg (string input)
        {
            if (Regex.IsMatch(input, @"\d{3}-\d{2}-\d{4}"))   // we took this from regex site. they need to be in "" // @ is used to give the string an escape character
            {
                return "Yay you did it!";
            }
            
            return "Oh that didnt work";
        }

        public static string ValidateNames(string input)



        {
            if (Regex.IsMatch(input,@"[A-Z][a-z]{1,30}"))  
            {
                return "That one works";
            }
            return "That does not follow parameters";
        }
        public static string ValidateEmails(string email)
        {
            if (Regex.IsMatch(email,@"\w+([a-zA-z_,0-9]{5,30})+@([a-z]{5,10})+\.([a-zA-Z]{2,3})"))
            {
                return "That one works";
            }
            return "That does not follow parameters";
        }

        public static string ValidateDate(string date)
        {
            if (Regex.IsMatch(date,@"(\d[0-9]{0,2})+\/(\d[0-9]{0,2})+\/(\d[0-9]{0,4})"))
            {
                return "That one works";
            }
            return "That does not follow parameters";

        }
        

    }
}
