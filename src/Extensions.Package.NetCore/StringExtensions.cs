using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions.Package.NetCore
{
    public static class StringExtensions
    {
        public static bool In(this string pString, List<string> pList) =>
            In(pString, pList, StringComparison.InvariantCultureIgnoreCase);

        public static bool In(this string pString, List<string> pList, StringComparison pStringComparison)
        {
            if (pList == null)
                throw new ArgumentNullException(nameof(pList));
            return pList.Any(item => item.Equals(pString, pStringComparison));
        }
    }
}
