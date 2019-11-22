using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IvoPairExample
{
    public class PalidromeTest
    {
        public class TestPalindrome
        {
            [Theory]
            [InlineData("anna")]
            [InlineData("civic")]
            [InlineData("madam")]

            



            public void IsPalidromeTest(string word)
            {
                bool actual = Palindrome.IsPalidrome(word);
                Assert.True(actual);
            }

            [Theory]
            [InlineData("listen", "silent")]
            [InlineData("inch", "chin")]
            [InlineData("cat", "act")]


            public void AreAnagramsTest(string word1, string word2)
            {
                bool actual = Palindrome.AreAnagrams(word1, word2);
                Assert.True(actual);
            }
        }
    }
}
