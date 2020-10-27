using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Duck_Collection
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind > y.Kind)
                return 1;
            else if (x.Kind < y.Kind)
                return -1;
            else
                return 0;
        }
    }
}
