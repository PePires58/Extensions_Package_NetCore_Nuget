using Extensions.Package.NetCore.Tests.EnumExtensions.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions.Package.NetCore.Tests.EnumExtensions
{
    public class EnumExtensionsIsStringOnEnumDefaultValue
    {
        #region Methods
        [Fact]
        public void ShouldReturnFalse()
        {
            string myString = "abc";

            Assert.False(myString.IsStringOnEnumDefaultValue<EnumModel>());
        }

        [Fact]
        public void ShouldReturnFalseWithStringComparison()
        {
            string myString = "i";

            Assert.False(myString.IsStringOnEnumDefaultValue<EnumModel>(StringComparison.InvariantCulture));
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            string myString = "i";

            Assert.True(myString.IsStringOnEnumDefaultValue<EnumModel>());
        }

        [Fact]
        public void ShouldReturnTrueWithStringComparison()
        {
            string myString = "i";

            Assert.True(myString.IsStringOnEnumDefaultValue<EnumModel>(StringComparison.InvariantCultureIgnoreCase));
        }
        #endregion
    }
}
