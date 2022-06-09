using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Extensions.Package.NetCore
{
    public static class EnumExtensions
    {
        public static string GetDefaultValue(this Enum enumObject)
        {
            FieldInfo fieldInfo = enumObject.GetType().GetField(enumObject.ToString());

            return fieldInfo == null ? null :
                (
                    (DefaultValueAttribute)fieldInfo
                        .GetCustomAttribute(typeof(DefaultValueAttribute))
                ).Value.ToString();
        }
        public static string GetDescription(this Enum enumObject) {
            FieldInfo fieldInfo = enumObject.GetType().GetField(enumObject.ToString());
            return fieldInfo == null ? null :
                (
                    (DescriptionAttribute)fieldInfo
                        .GetCustomAttribute(typeof(DescriptionAttribute))
                ).Description.ToString();
        }

        public static bool IsStringOnEnumDefaultValue<T>(this string inputString)
            where T: Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Any(enumObject => enumObject.GetDefaultValue()
                    .Equals(inputString));
        }

        public static bool IsStringOnEnumDescription<T>(this string inputString)
            where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Any(enumObject => enumObject.GetDescription()
                    .Equals(inputString));
        }

    }
}
