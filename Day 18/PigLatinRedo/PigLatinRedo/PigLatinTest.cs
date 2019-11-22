using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatinRedo
{
    public class PigLatinTest
    {
        [Theory]
        [InlineData("apple" ,"appleway")]
        [InlineData("pear", "earpay")]
        [InlineData("strawberry", "awberrystray")]
       

        public void TestPigLatinTranslator(string word, string expected)
        {
            string actual = PigLatin.TranslatePigLatin(word);
            Assert.Equal(expected, actual);
        }

    }
}
