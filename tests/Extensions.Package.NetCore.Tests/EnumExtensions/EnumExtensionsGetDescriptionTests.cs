using Extensions.Package.NetCore.Tests.EnumExtensions.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions.Package.NetCore.Tests.EnumExtensions
{
    public class EnumExtensionsGetDescriptionTests
    {
        #region Methods
        [Fact]
        public void ShouldReturnNull()
        {
            EnumModel enumModel = EnumModel.WithNoAttributes;

            Assert.Null(enumModel.GetDescription());
        }

        [Fact]
        public void ShouldReturnAString()
        {
            EnumModel enumModel = EnumModel.IntExtensions;
            string defaultValue = enumModel.GetDescription();

            Assert.NotNull(defaultValue);
            Assert.Equal("int extensions", defaultValue);
        }
        #endregion
    }
}
