using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PasswordVerifier
{
    public class TestPasswordVerifier
    {
        // create a method that verifies a password
        // must have 8 charactoer, 1 symbol, 1 number, 1 Cap  letter


        public string validPassword = "Hello!1234";
        public string invalidPassword = "hello";
      [Fact]
        public void testInvalidLength()
        {
            bool actual = PasswordVerifier.VerifyPassword(invalidPassword);
            Assert.False(actual);
        }

        [Fact]
        public void TestValidLength()
        {
            bool actual = PasswordVerifier.VerifyPassword(validPassword);
            Assert.True(actual);
        }

        [Fact]
        public void TestInvalidSymbols()
        {
            bool actual = PasswordVerifier.VerifyPassword(invalidPassword);
            Assert.False(actual);
        }

        [Fact]
        public void TestValidSymbols()
        {
            bool actual = PasswordVerifier.VerifyPassword(validPassword);
            Assert.True(actual);
        }

        [Fact]
        public void TestInvalidNumber()
        {
            bool actual = PasswordVerifier.VerifyPassword("HelloWorld!");
            Assert.False(actual);
        }

        [Fact]
        public void TestValidNumber() 
        {
            bool actual = PasswordVerifier.VerifyPassword(validPassword);
            Assert.True(actual);
        }
    }
}
