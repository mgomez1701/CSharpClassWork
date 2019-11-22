using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // showing how to add to a list //

            TheMostAwesomeList awesomeList = new TheMostAwesomeList();
            awesomeList.Add("Bob Ross");
            Console.WriteLine(awesomeList.Count);
            awesomeList.Add("Mr.Rodgers");
            Console.WriteLine(awesomeList.Count);
            awesomeList.Add("Steve Irwin");
            Console.WriteLine(awesomeList.Count);
            awesomeList.Add("Pulisic");
            Console.WriteLine(awesomeList.Count);
            awesomeList.Add("Tammy Abraham");
            Console.WriteLine(awesomeList.Count);
            awesomeList.Add("Frank Lampard");
            Console.WriteLine(awesomeList.Count);

            awesomeList.RemoveNode(5);


            int test = MinCoins(478);
            Console.WriteLine($" {test} is answer");

            for (int i = 0; i
                < awesomeList.Count; i++) // how to access a node based off an index that we will create
            {
                Console.WriteLine(awesomeList.GetNode(i).Data); // we need to creat a method to access a node based off an index
            }



            // create a for loop that loops through the linked list that returns the node// 

        }

        public static int MinCoins(int input)
        {
            int[] coins = { 100, 50, 25, 10, 5, 1 };
            int count = 0;
            int index = 0;
            while (input > 0)
            {
                
                if (input >= coins[index])
                {
                    input -= coins[index];
                    count++;
                }
                else
                {
                    index++;

                }
              

            }
            return count;
        }
    }
}
