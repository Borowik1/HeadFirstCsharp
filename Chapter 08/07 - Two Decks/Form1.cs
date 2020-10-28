using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07___Two_Decks
{
    public partial class Form1 : Form
    {
        Deck deck1 = new Deck();
        Deck deck2 = new Deck();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);

            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void ResetDeck(int deckToReset)
        {
            if (deckToReset == 1)
            {
                deck1.Clear();
                int counter = random.Next(0, 11);
                for (int i = 0; i < counter; i++)
                {
                    deck1.AddCard(new Cards((Suits)random.Next(0, 4), (Values)random.Next(1, 14)));
                }
            }
            else if (deckToReset == 2)
            {
                deck2.Clear();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 1; j < 14; j++)
                    {
                        deck2.AddCard(new Cards((Suits)i, (Values)j));
                    }
                }
            }
        }

        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                deck1ListBox.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    deck1ListBox.Items.Add(cardName);
                }
            }
            else if (deckNumber == 2)
            {
                deck2ListBox.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    deck2ListBox.Items.Add(cardName);
                }
            }
        }

        private void resetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void resetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (deck1ListBox.SelectedIndex > 0)
            {
                deck2.AddCard(deck1.Deal(deck1ListBox.SelectedIndex));
                RedrawDeck(1);
                RedrawDeck(2);
            }
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (deck2ListBox.SelectedIndex > 0)
            {
                deck1.AddCard(deck2.Deal(deck2ListBox.SelectedIndex));
                RedrawDeck(1);
                RedrawDeck(2);
            }

        }
    }
}
