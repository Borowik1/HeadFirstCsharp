using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Jewels_And_Thiefs
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReciveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + safeContents.Sparkle());
        }
    }
}
