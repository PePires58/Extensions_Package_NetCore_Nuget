using Extensions.Package.NetCore.Validations;
using System.Collections.Generic;

namespace Extensions.Package.NetCore
{
    public static class LongExtensions
    {
        public static bool In(this long pInt, List<long> pList)
        {
            return new NumericValidations<long>().In(pInt, pList);
        }
    }
}
