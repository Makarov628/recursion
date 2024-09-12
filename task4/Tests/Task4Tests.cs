using System;
using NUnit.Framework;
using Task4;

namespace Tests
{
    [TestFixture]
    public class Task4Tests
    {
        [Test]
        public void StringIsPalindrome()
        {
            var str = "TENET";
            Assert.IsTrue(Palindrome.IsPalindrome(str));

            var str2 = "ABBA";
            Assert.IsTrue(Palindrome.IsPalindrome(str2));
        }

        [Test]
        public void StringIsNotPalindrome()
        {
            var str = "SATOR";
            Assert.IsFalse(Palindrome.IsPalindrome(str));

            var str1 = "I've see things what you people wouldn't believe.";
            Assert.IsFalse(Palindrome.IsPalindrome(str1));
        }

    }
}
