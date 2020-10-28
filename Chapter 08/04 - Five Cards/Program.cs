using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Five_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cards> cards = new List<Cards>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Cards((Suits)random.Next(0, 4), (Values)random.Next(2, 15)));
            }

            Console.WriteLine("Five random cards:");
            Console.WriteLine("");

            foreach (Cards item in cards)
            {
                Console.WriteLine(item.Name);
            }

            CardComparer comparer = new CardComparer();
            cards.Sort(comparer);

            Console.WriteLine("");
            Console.WriteLine("Those same cards, sorted:");
            Console.WriteLine("");

            foreach (Cards item in cards)
            {
                Console.WriteLine(item.Name);
            }

            Console.Read();
        }
    }
}
