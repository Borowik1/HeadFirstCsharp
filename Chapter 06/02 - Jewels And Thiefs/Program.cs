using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Jewels_And_Thiefs
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();

            jewelThief.OpenSafe(safe, owner);
            Console.Read();
        }
    }
}
