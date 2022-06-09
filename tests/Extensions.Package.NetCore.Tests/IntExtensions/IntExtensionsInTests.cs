using System;
using System.Collections.Generic;
using Xunit;

namespace Extensions.Package.NetCore.Tests.IntExtensions
{
    public class IntExtensionsInTests
    {
        #region Methods
        [Fact]
        public void ShouldReturnTrue()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            int myNumber = 1;

            Assert.True(myNumber.In(list));
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            int myNumber = 99;

            Assert.False(myNumber.In(list));
        }

        [Fact]
        public void ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                int myNumber = 0;

                myNumber.In(null);
            });
        }
        #endregion
    }
}
