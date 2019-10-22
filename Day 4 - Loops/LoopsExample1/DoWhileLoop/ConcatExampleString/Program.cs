using System;

namespace ConcatExampleString
{
    class Program
    {
        static void Main(string[] args)
        {     
            string together = string.Concat("This is the first part, ", "this is the second part");
            Console.WriteLine(together);

            bool isEqual = together.Equals("This is not a string");
            Console.WriteLine($"{together} equals 'this is not a string' : {isEqual}");

            int isSame = string.Compare("Cat", "Dog");
            Console.WriteLine($"Cat == Dog: " + isSame);

            isSame = string.Compare("Dog", "Cat");
            Console.WriteLine($"Dog == Cat: " + isSame);

            int index = together.IndexOf("is");
            Console.WriteLine($"Expected 2 , Actual {index}");

            index = together.LastIndexOf("is");
            Console.WriteLine($"Expected 29 , Actual {index}");

            bool endsWith = together.EndsWith('!'); // does together end in ! anywhere//
            Console.WriteLine($"Expected: False , Actual {endsWith}");

            string newTogether = together.ToLower().Replace("This", ""); // replacing this with blank space in together string// 
            Console.WriteLine(newTogether);

            string[] togetherArray = together.Split();
            foreach(string potato in togetherArray) // declaring the variable word in the foreach loop) 
            {
                Console.WriteLine(potato); // printing each one on their own line//
            }

            index = together.LastIndexOf("this");
            //returning a string so we have to store it// 
            string togetherPartTwo = together.Substring(index); // this is the substing method no matter what it will return a string//
            Console.WriteLine(togetherPartTwo);

            string shortertTogetherPartTwo = together.Substring(index, 5);
            Console.WriteLine(shortertTogetherPartTwo);

            string beginningTogether = together.Substring(0, index);
            Console.WriteLine(beginningTogether);

            string vowels = "aeiou";
            string word = "word"; // we do not have to set a string to char array becasue it already is a char array//
            if (vowels.Contains(word[0])); // syaing if vowels contains "aeiou". starting at 0 first letter of word

        }





    }
}
