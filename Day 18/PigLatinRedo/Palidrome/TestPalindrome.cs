using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Palidrome
{
    public class TestPalindrome
    {
        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("pear", "earpay")]
        [InlineData("strawberry","")]

        public void IsPalidromeTest( string word)
        {
            bool actual = Palidrome.IsPalidrome(word);
            Assert.True(actual);
        }
    }
}
