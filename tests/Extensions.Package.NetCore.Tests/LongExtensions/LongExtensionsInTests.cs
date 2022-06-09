using System;
using System.Collections.Generic;
using Xunit;

namespace Extensions.Package.NetCore.Tests.LongExtensions
{
    public class LongExtensionsInTests
    {
        #region Methods
        [Fact]
        public void ShouldReturnTrue()
        {
            List<long> list = new List<long>() { 1, 2, 3 };
            long myNumber = 1;

            Assert.True(myNumber.In(list));
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            List<long> list = new List<long>() { 1, 2, 3 };
            long myNumber = 99;

            Assert.False(myNumber.In(list));
        }

        [Fact]
        public void ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                long myNumber = 0;

                myNumber.In(null);
            });
        }
        #endregion
    }
}
