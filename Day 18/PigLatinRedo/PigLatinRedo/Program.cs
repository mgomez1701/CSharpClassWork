using System;

namespace PigLatinRedo
{
    public class PigLatin
    {
       

        public static string TranslatePigLatin(string word)
        {
            string vowels = "aeiou";
            string returnString = "";

                if (vowels.Contains(word[0].ToString().ToLower()))
                {
                    string temp = string.Concat(word, "way");
                    returnString = string.Concat(returnString, temp);

                }
                else
                {
                int counter = 0;
                    foreach(char letter in word)
                    {
                        if (!vowels.Contains(letter))
                        {
                            counter++;
                        }
                        else
                        {
                             break;
                        }
                    }
                    string sub1 = word.Substring(0, counter);
                    string sub2 = word.Substring(counter);
                    returnString = string.Concat(sub2, sub1);
                returnString = string.Concat(returnString, "ay");

                  
                }
            
            return returnString;
        }
    }
}
