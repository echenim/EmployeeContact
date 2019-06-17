using System;
using Xunit;
using Portal.Domain.Helper;

namespace Portal.Test
{
    public class StringUtilTest
    {
        [Fact]
        public void CheckIfFunctionReturnsFirstLetter()
        {
            string result = StringUtils.FirstLetter("Myron William");
            Assert.Equal("M", result);
        }

        [Fact]
        public void CheckIfFunctionReturnsFirstLetterWhenEmptyStringWasPassed()
        {
            string result = StringUtils.FirstLetter(string.Empty);
            Assert.Equal("M", result);
        }

        [Fact]
        public void CheckIfFunctionReturnsCharWhenEmptyStringWasPassed()
        {
            string result = StringUtils.FirstLetter(string.Empty);
            Assert.Equal(string.Empty, result);
        }


    }
}
