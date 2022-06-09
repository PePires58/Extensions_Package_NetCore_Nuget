using Extensions.Package.NetCore.Tests.EnumExtensions.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions.Package.NetCore.Tests.EnumExtensions
{
    public class EnumExtensionsGetDefaultValueTests
    {
        #region Methods
        [Fact]
        public void ShouldReturnNull() {
            EnumModel enumModel = EnumModel.WithNoAttributes;

            Assert.Null(enumModel.GetDefaultValue());
        }

        [Fact]
        public void ShouldReturnAString() {
            EnumModel enumModel = EnumModel.IntExtensions;
            string defaultValue = enumModel.GetDefaultValue();

            Assert.NotNull(defaultValue);
            Assert.Equal("I", defaultValue);
        }
        #endregion
    }
}
