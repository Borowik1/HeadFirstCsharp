using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Retired_Jersey_Numbers
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int yearRetired)
        {
            Player = player;
            YearRetired = yearRetired;
        }
    }
}
