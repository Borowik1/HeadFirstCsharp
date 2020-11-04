using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___LINQ_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] linqtest = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            IEnumerable<int> result2 = from i in linqtest where i < 3 select i;
            int[] values1 = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result1 = from v in values1
                          where v < 37
                          orderby v
                          select v;
            foreach (var item in result1)
            {
                //Console.WriteLine(item);
            }


            IEnumerable<Comic> comics = Comic.BuildCatalog();
            Dictionary<int, decimal> values = Comic.GetPrices();

            var mostExpensive = from comic in comics
                                where values[comic.Issue] > 500
                                orderby values[comic.Issue] descending
                                select comic;
            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine("{0} стоит {1:c}", comic.Name, values[comic.Issue]);
            }

            Console.Read();


            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
                listOfNumbers.Add(random.Next(100));
            Console.WriteLine("Есть {0} чисел", listOfNumbers.Count());
            Console.WriteLine("Самое маленькое {0}", listOfNumbers.Min());
            Console.WriteLine("Самое большое {0}", listOfNumbers.Max());
            Console.WriteLine("Их сумма равна {0}", listOfNumbers.Sum());
            Console.WriteLine("Среднее арифметическое {0:F2}", listOfNumbers.Average());
        }
    }
}
