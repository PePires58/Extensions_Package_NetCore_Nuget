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

            Attribute customAttribute = fieldInfo
                    .GetCustomAttribute(typeof(DefaultValueAttribute));

            return customAttribute == null ? null :
                ((DefaultValueAttribute)customAttribute).Value.ToString();

        }
        public static string GetDescription(this Enum enumObject)
        {
            FieldInfo fieldInfo = enumObject.GetType().GetField(enumObject.ToString());


            Attribute customAttribute = fieldInfo
                    .GetCustomAttribute(typeof(DescriptionAttribute));

            return customAttribute == null ? null :
                ((DescriptionAttribute)customAttribute).Description.ToString();
        }

        public static bool IsStringOnEnumDefaultValue<T>(this string inputString)
            where T : Enum
            => IsStringOnEnumDefaultValue<T>(inputString, StringComparison.InvariantCultureIgnoreCase);

        public static bool IsStringOnEnumDefaultValue<T>(this string inputString,
            StringComparison stringComparison)
            where T : Enum
            => Enum.GetValues(typeof(T))
                .Cast<T>()
                .Any(enumObject => inputString
                    .Equals(enumObject.GetDefaultValue(), stringComparison));


        public static bool IsStringOnEnumDescription<T>(this string inputString)
            where T : Enum
            => IsStringOnEnumDescription<T>(inputString, StringComparison.InvariantCultureIgnoreCase);


        public static bool IsStringOnEnumDescription<T>(this string inputString,
            StringComparison stringComparison)
            where T : Enum
            => Enum.GetValues(typeof(T))
                    .Cast<T>()
                    .Any(enumObject => inputString
                        .Equals(enumObject.GetDescription(), stringComparison));
    }
}
