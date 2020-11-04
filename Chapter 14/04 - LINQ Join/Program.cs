using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Comic> comics = Comic.BuildCatalog().ToList();
            Dictionary<int, decimal> prices = Comic.GetPrices();
            List<Purchase> purchases = Purchase.FindPurchases().ToList();

            var comicsWithGregsPrice = from comic in comics
                                       join purchase in purchases
                                       on comic.Issue equals purchase.Issue
                                       select new { comic.Name, comic.Issue, purchase.Price };

            var comicsWithBothPrices = from comic in comicsWithGregsPrice
                                       join price in prices
                                       on comic.Issue equals price.Key
                                       select new { comic.Name, comic.Issue, comic.Price, price.Value };

            decimal gregTotalCost = 0;
            decimal jimmyTotalSpend = 0;
            foreach (var c in comicsWithBothPrices)
            {
                Console.WriteLine("Комикс {0} выпуск №{1} стоит {2:c}", c.Name, c.Issue, c.Price);
                gregTotalCost += c.Price;
                jimmyTotalSpend += c.Value;
            }
            Console.WriteLine("Джимми потратил {0:c} на комиксы общей стоимостью {1:c}", jimmyTotalSpend, gregTotalCost);
            Console.Read();
        }
    }
}
