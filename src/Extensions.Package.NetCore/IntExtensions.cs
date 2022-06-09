using Extensions.Package.NetCore.Validations;
using System.Collections.Generic;

namespace Extensions.Package.NetCore
{
    public static class IntExtensions
    {
        public static bool In(this int pInt, List<int> pList)
        {
            return new NumericValidations<int>().In(pInt, pList);
        }
    }
}
