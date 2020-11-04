using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _02___Jimmys_Comics
{
    class ComicQueryManager
    {
        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }
        public ObservableCollection<object> CurrentQueryResults { get; private set; }
        public string Title { get; set; }

        public ComicQueryManager()
        {
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();
        }
        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<ComicQuery>
            {
                new ComicQuery("LINQ упрощает запросы", "Пример запроса",
                    "Продемонстрируем Джимми гибкость LINQ",
                     CreateImageFromAssets("purple_250x250.jpg")),
                new ComicQuery("Дорогие комиксы", "Комиксы дороже $500",
                    "Комиксы, цена которых превышает 500 долларов."
                    + " Эта штука позволит Джимми понять, какие комиксы он хочет больше.",
                    CreateImageFromAssets("captain_amazing_250x250.jpg")),
                new ComicQuery("Универсальный LINQ 1", "Изменим все возвращаемое запросами",
                    "Этот код добавит строку в конец каждой строки в массиве.",
                    CreateImageFromAssets("bluegray_250x250.jpg")),
                new ComicQuery("Универсальный LINQ 2", "Вычисления в коллекциях",
                    "LINQ предоставляет методы расширения коллекциям (и всему прочему"
                    + " что реализует интерфейс IEnumerable<T>).",
                    CreateImageFromAssets("purple_250x250.jpg")),
                new ComicQuery("Универсальный LINQ 3",
                    "Сохраним все результаты в новую последовательность",
                    "Иногда результаты запросов LINQ нужно сохранить отдельно.",
                    CreateImageFromAssets("bluegray_250x250.jpg")),
                new ComicQuery("Группировка комиксов по диапазону цен",
                    "Объединим данные Джимми в группы",
                    "Джимми покупает много дешевых комиксов, несколько более дорогих и"
                    + " немного дорогих и хочет знать, какие варианты ему доступны"
                    + " перед окончательной покупкой.",
                    CreateImageFromAssets("captain_amazing_250x250.jpg")),
                new ComicQuery("Объединим покупки с ценами",
                    "Посмотрим, умеет ли Джимми торговаться",
                    "Этот запрос создает список классов Purchase с приобретениями Джимми"
                    + " и сравнивает их с ценами в списке Грега.",
                    CreateImageFromAssets("captain_amazing_250x250.jpg")),
                new ComicQuery("Все комиксы коллекции",
                    "Получить все комиксы, входящие в коллекцию",
                    "Этот запрос возвращает все комиксы",
                    CreateImageFromAssets("captain_amazing_zoom_250x250.jpg")),
            };

        }

        private static BitmapImage CreateImageFromAssets(string imageFilename)
        {
            try
            {
                Uri uri = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (System.IO.IOException)
            {
                return new BitmapImage();
            }
        }

        public void UpdateQueryResults(ComicQuery query)
        {
            Title = query.Title;
            switch (query.Title)
            {
                case "LINQ упрощает запросы": LinqMakesQueriesEasy(); break;
                case "Дорогие комиксы": ExpensiveComics(); break;
                case "Универсальный LINQ 1": LinqIsVersatile1(); break;
                case "Универсальный LINQ 2": LinqIsVersatile2(); break;
                case "Универсальный LINQ 3": LinqIsVersatile3(); break;
                case "Группировка комиксов по диапазону цен": CombineJimmysValuesIntoGroups(); break;
                case "Объединим покупки с ценами": JoinPurchasesWithPrices(); break;
                case "All comics in the collection": AllComics(); break;
            }
        }

        private void AllComics()
        {
            foreach (Comic comic in BuildCatalog())
            {
                var result = new
                {
                    Image = CreateImageFromAssets("captain_amazing_zoom_250x250.jpg"),
                    Title = comic.Name,
                    Subtitle = "Выпуск #" + comic.Issue,
                    Description = "The Captain versus " + comic.MainVillain,
                    Comic = comic,
                };
                CurrentQueryResults.Add(result);
            }
        }

        private void JoinPurchasesWithPrices()
        {
            List<Comic> comics = BuildCatalog().ToList();
            Dictionary<int, decimal> prices = GetPrices();
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
                CurrentQueryResults.Add(CreateAnonymousListViewItem(String.Format("Комикс {0} выпуск №{1} стоит {2:c}", c.Name, c.Issue, c.Price), "captain_amazing_250x250.jpg"));
                gregTotalCost += c.Price;
                jimmyTotalSpend += c.Value;
            }
            CurrentQueryResults.Add(CreateAnonymousListViewItem(String.Format("Джимми потратил {0:c} на комиксы общей стоимостью {1:c}", jimmyTotalSpend, gregTotalCost), "captain_amazing_250x250.jpg"));

        }

        private void CombineJimmysValuesIntoGroups()
        {
            Dictionary<int, decimal> values = GetPrices();
            var comicsGropByPrice = from item in values
                                    group item.Key by EvaluatePrice(item.Value)
                                    into itemGroup
                                    orderby itemGroup.Key descending
                                    select itemGroup;
            foreach (var group in comicsGropByPrice)
            {
                string text = String.Format("Найдены {0} {1} комикса: выпуски ", group.Count(), group.Key);
                foreach (var issueNumber in group)
                    text += String.Format(issueNumber.ToString() + " ");
                CurrentQueryResults.Add(CreateAnonymousListViewItem(text, "captain_amazing_250x250.jpg"));
            }

        }

        static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100M) return PriceRange.Cheap;
            else if (price < 1000M) return PriceRange.Midrange;
            else return PriceRange.Expensive;
        }

        private void LinqIsVersatile1()
        {
            string[] sandwiches = { "ham and cheese", "salami with mayo",
                                    "turkey and swiss", "chicken cutlet" };
            var sandwichesOnRye =
            from sandwich in sandwiches
            select sandwich + " on rye";
            CurrentQueryResults.Clear();
            foreach (var sandwich in sandwichesOnRye)
                CurrentQueryResults.Add(CreateAnonymousListViewItem(sandwich, "bluegray_250x250.jpg"));
        }
        private void LinqIsVersatile2()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
                listOfNumbers.Add(random.Next(100));
            CurrentQueryResults.Clear();
            CurrentQueryResults.Add(CreateAnonymousListViewItem(
            String.Format("There are {0} numbers", listOfNumbers.Count())));
            CurrentQueryResults.Add(
            CreateAnonymousListViewItem(String.Format("The smallest is {0}", listOfNumbers.Min())));
            CurrentQueryResults.Add(
            CreateAnonymousListViewItem(String.Format("The biggest is {0}", listOfNumbers.Max())));
            CurrentQueryResults.Add(
            CreateAnonymousListViewItem(String.Format("The sum is {0}", listOfNumbers.Sum())));
            CurrentQueryResults.Add(CreateAnonymousListViewItem(
            String.Format("The average is {0:F2}", listOfNumbers.Average())));
        }
        private void LinqIsVersatile3()
        {
            List<int> listOfNumbers = new List<int>();
            for (int i = 1; i <= 10000; i++)
                listOfNumbers.Add(i);
            var under50sorted =
            from number in listOfNumbers
            where number < 50
            orderby number descending
            select number;
            var firstFive = under50sorted.Take(6);
            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
                CurrentQueryResults.Add(CreateAnonymousListViewItem(n.ToString(), "bluegray_250x250.jpg"));
        }

        private object CreateAnonymousListViewItem(string title,
            string imageFilename = "purple_250x250.jpg")
        {
            return new
            {
                Title = title,
                Image = CreateImageFromAssets(imageFilename),
            };
        }

        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic> {
                    new Comic { Name = "Johnny America vs. the Pinko", Issue = 6, Year = 1949, CoverPrice = "10 cents",
                        MainVillain = "The Pinko", Cover = CreateImageFromAssets("Captain Amazing Issue 6 cover.png"),
                        Synopsis = "Captain Amazing must save America from Communists as The Pinko and his"
                        + " communist henchmen threaten to take over Fort Knox and steal all of the nation's gold." },
                    new Comic { Name = "Rock and Roll (limited edition)", Issue = 19, Year = 1957, CoverPrice = "10 cents",
                        MainVillain = "Doctor Vortran", Cover = CreateImageFromAssets("Captain Amazing Issue 19 cover.png"),
                        Synopsis = "Doctor Vortran wreaks havoc with the nation's youth with his radio wave device that"
                        + " uses the latest dance craze to send rock and roll fans into a mind-control trance." },
                    new Comic { Name = "Woman's Work", Issue = 36, Year = 1968, CoverPrice = "12 cents",
                        MainVillain = "Hysterianna", Cover = CreateImageFromAssets("Captain Amazing Issue 36 cover.png"),
                        Synopsis = "The Captain faces his first female foe, Hysterianna, whose incredible telepathic"
                        + " and telekinetic abilities have allowed her to raise an all-girl army that"
                        + " even the Captain has trouble resisting." },
                    new Comic { Name = "Hippie Madness (misprinted)", Issue = 57, Year = 1973, CoverPrice = "20 cents",
                        MainVillain = "The Mayor", Cover = CreateImageFromAssets("Captain Amazing Issue 57 cover.png"),
                        Synopsis = "A zombie apocalypse threatens Objectville when The Mayor rigs the election by"
                        + " introducing his zombification agent into the city's cigarette supply." },
                    new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68, Year = 1984,
                        CoverPrice = "75 cents", MainVillain = "The Swindler",
                        Cover = CreateImageFromAssets("Captain Amazing Issue 68 cover.png"),
                        Synopsis = "A tainted batch of eye makeup turns Dr. Alvin Mudd into the Captain's new nemesis,"
                        + " in The Swindler's first appearance in a Captain Amazing comic." },
                    new Comic { Name = "Black Monday", Issue = 74, Year = 1986, CoverPrice = "75 cents",
                        MainVillain = "The Mayor", Cover = CreateImageFromAssets("Captain Amazing Issue 74 cover.png"),
                        Synopsis = "The Mayor returns to throw Objectville into a financial crisis by directing his"
                        + " zombie creation powers to the floor of the Objectville Stock Exchange." },
                    new Comic { Name = "Tribal Tattoo Madness", Issue = 83, Year = 1996, CoverPrice = "Two bucks",
                        MainVillain = "Mokey Man", Cover = CreateImageFromAssets("Captain Amazing Issue 83 cover.png"),
                        Synopsis = "Monkey Man escapes from his island prison and wreaks havoc with his circus sideshow"
                        + " of tattooed henchmen that and their deadly grunge ray." },
                    new Comic { Name = "The Death of an Object", Issue = 97, Year = 2013, CoverPrice = "Four bucks",
                        MainVillain = "The Swindler", Cover = CreateImageFromAssets("Captain Amazing Issue 97 cover.png"),
                        Synopsis = "The Swindler's clone army attacks Objectville in a ruse to trap and kill the "
                        + " Captain. Can the scientists of Objectville find a way to bring him back?" },
                    };
        }
        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                { 6, 3600M }, { 19, 500M }, { 36, 650M }, { 57, 13525M },
                { 68, 250M }, { 74, 75M }, { 83, 25.75M }, { 97, 35.25M },
            };
        }

        private void LinqMakesQueriesEasy()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 37
                         orderby v
                         select v;

            CurrentQueryResults.Clear();
            foreach (int i in result)
                CurrentQueryResults.Add(
                    new
                    {
                        Title = i.ToString(),
                        Image = CreateImageFromAssets("purple_250x250.jpg"),
                    }
                );
        }

        private void ExpensiveComics()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            var mostExpensive = from comic in comics
                                where values[comic.Issue] > 500
                                orderby values[comic.Issue] descending
                                select comic;
            CurrentQueryResults.Clear();
            foreach (Comic comic in mostExpensive)
                CurrentQueryResults.Add(
                new
                {
                    Title = String.Format("{0} is worth {1:c}",
                comic.Name, values[comic.Issue]),
                    Image = CreateImageFromAssets("captain_amazing_250x250.jpg"),
                }
                );
        }


    }
}

