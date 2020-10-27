using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Five_Cards
{
    class CardComparer : IComparer<Cards>
    {
        public int Compare(Cards x, Cards y)
        {
            if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
            else if (x.Suit > y.Suit)
                return 1;
            else if (x.Suit < y.Suit)
                return -1;
            else
                return 0;
        }
    }
}
