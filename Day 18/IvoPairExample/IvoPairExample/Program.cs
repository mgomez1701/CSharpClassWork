using System;

namespace IvoPairExample
{
    public class Palindrome
    {
        public static bool IsPalidrome(string word)
        {
            string reverseWord = "";
            for (int i = word.Length -1; i >= 0; i--)
            {
                reverseWord += word[i];
            }
            if (word == reverseWord)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool AreAnagrams(string word1, string word2)
        {
            foreach (char letter in word1)
            {
                foreach (char letter2 in word2)
                {
                    if(word1.Length == word2.Length) 
                    {
                        for (int i = 0; i < word1.Length; i++)
                        {
                            if (word1.Contains(word2[i]))
                            {

                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
               


            }
            return true;
        }
    }
}
