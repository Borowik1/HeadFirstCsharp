using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06___Card_Deck_Serializable
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck();
            for (int i = 0; i < number; i++)
            {
                myDeck.AddCard(new Cards((Suits)random.Next(4), (Values)random.Next(2, 15)));
            }
            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Cards nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "Что было записано в файл");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Deck deckFromFile = (Deck)bf.Deserialize(input);
                DealCards(deckFromFile, "Что было прочитано из файла");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    bf.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Колода #" + i + " записана");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, "Колода #" + i + " прочитана");
                }
            }
        }
    }
}
