using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Methods_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards cardToCheck = new Cards(Suits.Clubs, Values.Three);
            bool doesItMatch = Cards.DoesCardMatch(cardToCheck, Suits.Hearts);
            Console.WriteLine(doesItMatch);
        }
    }
}
