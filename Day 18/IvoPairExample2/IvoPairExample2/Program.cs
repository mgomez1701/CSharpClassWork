using System;

namespace IvoPairExample2
{
    public class NonRepeatingCharacter
    {
        public static char NonRepeating(string word)
        {
            char repeatedChar = ' ';
            char firstNonRepeatChar =' ';
            int counter = 1;
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] != word[counter] && word[i] != repeatedChar)
                {
                    firstNonRepeatChar = word[i];
                    break;
                }
                else if( word[i]== word[counter])
                {
                    repeatedChar = word[i];
                    counter++;
                }
                
                else
                {
                    counter++;
                }
            }
            return firstNonRepeatChar;
        }
    }
}
