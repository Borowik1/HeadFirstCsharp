﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Covariance
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
        public override string ToString()
        {
            return "A " + Size + " inch " + Kind.ToString();
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
            {
                return 1;
            }
            else if (this.Size < duckToCompare.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}