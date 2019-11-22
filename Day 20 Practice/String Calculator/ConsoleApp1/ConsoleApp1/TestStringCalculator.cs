using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp1
{
    public class TestStringCalculator
    {
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        [InlineData("40000", "40000")]

        public void TestStringCalculatorAdd(string word, string expected)
        {
            double actual = StringCalculator.Add(word);
            Assert.Equal($"{expected}", $"{ actual}");
        }


    }
}
