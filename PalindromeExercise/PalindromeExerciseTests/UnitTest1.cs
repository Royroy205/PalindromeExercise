using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mustang", false)]
        [InlineData("vroom", false)]
        [InlineData("hey", false)]
        public void PolindromeTest(string word, bool expected) 
        {
            var wordSmith = new WordSmith();


            var actual = wordSmith.IsPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
