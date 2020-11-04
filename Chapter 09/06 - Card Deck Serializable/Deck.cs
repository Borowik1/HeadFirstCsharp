using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Card_Deck_Serializable
{
    [Serializable]
    class Deck
    {
        private List<Cards> cards;
        public int Count { get { return cards.Count; } }

        public Deck()
        {
            cards = new List<Cards>();
        }

        public void AddCard(Cards card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Cards card)
        {
            cards.Remove(card);
        }

        internal IEnumerable<string> GetCardNames()
        {
            List<string> cardNames = new List<string>();
            foreach (Cards card in cards)
            {
                cardNames.Add(card.Name);
            }
            return cardNames;
        }

        internal void Clear()
        {
            cards.Clear();
        }

        internal void Shuffle()
        {
            List<Cards> shuffledCards = new List<Cards>();
            Random random = new Random();
            int counter = cards.Count;

            for (int i = 0; i < counter; i++)
            {
                Cards randomCard = cards[random.Next(0, cards.Count)];
                shuffledCards.Add(randomCard);
                cards.Remove(randomCard);
            }
            cards = shuffledCards;
        }

        internal Cards Deal(int selectedIndex)
        {
            Cards dealedCard = cards[selectedIndex];
            cards.Remove(dealedCard);
            return dealedCard;
        }
    }
}
