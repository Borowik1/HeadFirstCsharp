using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___LINQ_Grop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, decimal> values = Comic.GetPrices();

            var comicsGropByPrice = from item in values
                                    group item.Key by EvaluatePrice(item.Value)
                                    into itemGroup
                                    orderby itemGroup.Key descending
                                    select itemGroup;
            foreach (var group in comicsGropByPrice)
            {
                Console.Write("Найдены {0} {1} комикса: выпуски ", group.Count(), group.Key);
                foreach (var issueNumber in group)
                    Console.Write(issueNumber.ToString() + " ");
                Console.WriteLine();
            }
            Console.Read();
        }

        static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100M) return PriceRange.Cheap;
            else if (price < 1000M) return PriceRange.Midrange;
            else return PriceRange.Expensive;
        }
    }
}
