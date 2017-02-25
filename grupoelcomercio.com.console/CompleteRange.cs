using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grupoelcomercio.com.console
{
    public static class CompleteRange
    {
        public static IEnumerable<int> build(this int[] arr)
        {
            for (int i = 1; i <= arr.Max(); i++) yield return i;
        }
    }
}
