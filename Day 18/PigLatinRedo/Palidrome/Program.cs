using System;

namespace Palidrome
{
    class Palidrome
    {
      public static bool IsPalidrome(string word)
        {
            string reverseWord = "";
            for (int i  = word.Length; i>0; i--)
            {
                reverseWord += word[i];
            }
            if(word == reverseWord)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
    }
}
