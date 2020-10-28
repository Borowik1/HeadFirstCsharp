using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Go_Fish_
{
    class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
        }

        public Deck(Card[] cards)
        {
            foreach (Card card in cards)
            {
                this.cards.Add(card);
            }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            cards.Remove(card);
        }

        internal IEnumerable<string> GetCardNames()
        {
            List<string> cardNames = new List<string>();
            foreach (Card card in cards)
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
            List<Card> shuffledCards = new List<Card>();
            Random random = new Random();
            int counter = cards.Count;

            for (int i = 0; i < counter; i++)
            {
                Card randomCard = cards[random.Next(0, cards.Count)];
                shuffledCards.Add(randomCard);
                cards.Remove(randomCard);
            }
            cards = shuffledCards;
        }

        public Card Deal(int selectedIndex)
        {
            Card dealedCard = cards[selectedIndex];
            cards.Remove(dealedCard);
            return dealedCard;
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.AddCard(Deal(i));
            return deckToReturn;
        }
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
