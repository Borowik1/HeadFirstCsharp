using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09___Go_Fish_
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            // Конструктор класса Player инициализирует четыре закрытых поля, а затем
            // добавляет элементу управления TextBox строку ″Joe has just
            // joined the game″, используя имя закрытого поля. Не забудьте поставить
            // знак переноса в конец каждой строки, добавляемой в TextBox.
            this.name = name;

            
        }
        public IEnumerable<Values> PullOutBooks() { } // код на следующей странице
        public Values GetRandomValue()
        {
            // Этот метод получает случайное значение, но из числа карт колоды!
        }
        public Deck DoYouHaveAny(Values value)
        {
            // Соперник спрашивает о наличии у меня карты нужного достоинства
            // Используйте метод Deck.PullOutValues() для взятия карт. Добавьте в TextBox
            // строку ″Joe has 3 sixes″, используйте новый статический метод Card.Plural()
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Это перегруженная версия AskForACard() — выберите случайную карту с помощью
            // метода GetRandomValue() и спросите о ней методом AskForACard()
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            // Спросите карту у соперников. Добавьте в TextBox текст: ″Joe asks if anyone has
            // a Queen″. В качестве параметра вам будет передана коллекция игроков
            // спросите (с помощью метода DoYouHaveAny()), есть ли у них карты
            // указанного достоинства. Переданные им карты добавьте в свой набор.
            // Следите за тем, сколько карт было добавлено. Если ни одной, вам нужно
            // взять карту из запаса (передается как параметр), в текстовое
            // поле нужно добавить строку TextBox: ″Joe had to draw from the stock″
        }
        // Перечень свойств и коротких методов, которые уже были написаны
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.AddCard(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
