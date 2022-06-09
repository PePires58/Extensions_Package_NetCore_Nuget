using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions.Package.NetCore.Validations
{
    internal class NumericValidations<T>
    {
        internal bool In(T pInt, List<T> pList)
        {
            if (pList == null)
                throw new ArgumentNullException(nameof(pList));

            return pList.Any(item => item.Equals(pInt));
        }
    }
}
