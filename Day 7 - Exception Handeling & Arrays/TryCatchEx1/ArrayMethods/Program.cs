using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tvArray = { "Game of Thrones", "Walking Dead,", "Barry", "South Park" ,"Futurama", "Samurai Jack" };

            // this is creating a reference to tvArray, any changes to tvArray will also affect tvShowArray
            string[] tvShowArray = tvArray;

            tvShowArray[3] = "Breaking Bad";
            Console.WriteLine(tvArray[3]);

            string[] copyTvArray = new string[tvArray.Length];
            tvArray.CopyTo(copyTvArray, 0); // you do not have to return .CopyTo

            copyTvArray[5] = "Parks and Rec";
            Console.WriteLine($"tvArray [5]:  {tvArray[5]}, copytvArray[5]: {copyTvArray[5]}");


            for (int i = 0; i < tvArray.Length; i++)
            {
                Console.WriteLine($"tvArray [{i}]:  {tvArray[i]}, copytvArray[5]: {copyTvArray[i]}");
            }
        }
    }
}
