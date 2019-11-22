using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IvoPairExample2
{
    public class NonRepeatTest
    {
        [Theory]
        [InlineData('a', "llal")]
        [InlineData('a', "all")]
        [InlineData('s', "starwberry")]
        [InlineData('v', "hhooover")]


        public void NonRepeatTesting(char expected, string word)
        {
            char actual = NonRepeatingCharacter.NonRepeating(word);
            Assert.Equal(actual, expected);
            

           
        }

    }
}
