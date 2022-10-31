using Support_Tool.Classes;
using System;
using Xunit;

namespace SupportTool.UnitTests
{
    public class UtilTests
    {
    
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(150)]
        [InlineData(175)]
        [InlineData(200)]
        public void RandomString_ReturnsStringOfExpectedLength(int charCount)
        {
            Assert.Equal(charCount, Utils.RandomString(charCount).Length);
        }

        [Fact]
        public void RandomString_ZeroLength_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Utils.RandomString(0));
        }

        [Theory]
        [InlineData(".exe")]
        [InlineData("suffix")]
        [InlineData("words")]
        public void RandomStringWithSuffix_ReturnsStringWithSuffix(string suffix)
        {
            var result = Utils.RandomStringWithSuffix(10, suffix);
            Assert.EndsWith(suffix, result);
        }

        [Fact]
        public void RandomStringWithSuffix_ZeroLength_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Utils.RandomStringWithSuffix(0, "suffix"));
        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void RandomStringWithSuffix_InvalidSuffix_ThrowsException(string suffix)
        {
            Assert.Throws<ArgumentNullException>(() => Utils.RandomStringWithSuffix(10, suffix));
        }

    }
}
