using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Go_Fish__WinStore
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private Game game = new Game();
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.AddCard(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

        public Player(String name, Random random, Game game)
        {
            this.name = name;
            this.random = random;
            this.cards = new Deck();
            this.game =game;
            game.AddProgress(name + " has joined the game." + Environment.NewLine);
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }
        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            // Соперник спрашивает о наличии у меня карты нужного достоинства
            // Используйте метод Deck.PullOutValues() для взятия карт. Добавьте в TextBox
            // строку ″Joe has 3 sixes″, используйте новый статический метод Card.Plural()
            Deck cardsIHave = cards.PullOutValues(value);
            game.AddProgress(Name + " has " + cardsIHave.Count + " " + Card.Plural(value));
            return cardsIHave;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.AddCard(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            game.AddProgress(Name + " asks if anyone have " + value);

            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck cardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    while (cardsGiven.Count > 0)
                        cards.AddCard(cardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0)
            {
                game.AddProgress(Name + " must draw from the stock.");
                cards.AddCard(stock.Deal());
            }

        }
    }
}
