using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Duck_Collection
{
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy { get; set; }
        public int Compare(Duck x, Duck y)
        {

            if (SortBy == SortCriteria.KindThenSize)
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                    if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                    return 0;
            }
            else
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else

                if (x.Kind > y.Kind)
                    return 1;
                else
                    if (x.Kind < y.Kind)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
