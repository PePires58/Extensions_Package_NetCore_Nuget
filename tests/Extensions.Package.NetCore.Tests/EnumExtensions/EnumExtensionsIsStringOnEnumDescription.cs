using Extensions.Package.NetCore.Tests.EnumExtensions.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions.Package.NetCore.Tests.EnumExtensions
{
    public class EnumExtensionsIsStringOnEnumDescripton
    {
        #region Methods
        [Fact]
        public void ShouldReturnFalse()
        {
            string myString = "abc";

            Assert.False(myString.IsStringOnEnumDescription<EnumModel>());
        }

        [Fact]
        public void ShouldReturnFalseWithStringComparison()
        {
            string myString = "INT Extensions";

            Assert.False(myString.IsStringOnEnumDescription<EnumModel>(StringComparison.InvariantCulture));
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            string myString = "INT extensions";

            Assert.True(myString.IsStringOnEnumDescription<EnumModel>());
        }

        [Fact]
        public void ShouldReturnTrueWithStringComparison()
        {
            string myString = "INT extensions";

            Assert.True(myString.IsStringOnEnumDescription<EnumModel>(StringComparison.InvariantCultureIgnoreCase));
        }
        #endregion
    }
}
