using System;
using System.Collections.Generic;
using Xunit;

namespace Extensions.Package.NetCore.Tests.StringExtensions
{
    public class StringExtensionsInTests
    {
        #region Methods
        [Fact]
        public void ShouldReturnTrue()
        {
            List<string> list = new List<string>() { "1", "2", "3"};
            string myString = "1";

            Assert.True(myString.In(list));
        }

        [Fact]
        public void ShouldReturnTrueWithStringComparison()
        {
            List<string> list = new List<string>() { "abc", "cba", "ZyX" };
            string myString = "ZyX";

            Assert.True(myString.In(list, StringComparison.CurrentCulture));
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            List<string> list = new List<string>() { "1", "2", "3" };
            string myString = "99";

            Assert.False(myString.In(list));
        }

        [Fact]
        public void ShouldReturnFalseWithStringComparison() {

            List<string> list = new List<string>() { "abc", "cba", "ZyX" };
            string myString = "zyx";

            Assert.True(myString.In(list, StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                string myString = string.Empty;

                myString.In(null);
            });
        }
        #endregion
    }
}
