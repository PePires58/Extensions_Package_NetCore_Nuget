using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Extensions.Package.NetCore.Tests.EnumExtensions.Model
{
    internal enum EnumModel
    {
        [DefaultValue(""), Description("")]
        Empty,

        [DefaultValue("I"), Description("int extensions")]
        IntExtensions,

        WithNoAttributes
    }
}
