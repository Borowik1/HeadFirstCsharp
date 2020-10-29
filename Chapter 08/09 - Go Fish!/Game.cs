using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09___Go_Fish_
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;
        public Game(string playerName, IEnumerable<string> opponentsName, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentsName)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            for (int i = 0; i < 4; i++)
                for (int j = 2; j < 15; j++)
                    stock.AddCard(new Card((Suits)i, (Values)j));

            Deal();
            players[0].SortHand();
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        internal string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description; ;
        }

        public bool PlayOneRound(int selctedPlayerCard)
        {
            Values cardToAskFor = players[0].Peek(selctedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                {
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                }
                else
                {
                    players[i].AskForACard(players, i, stock);
                    if (PullOutBook(players[i]))
                    {
                        textBoxOnForm.Text += players[i].Name + " drew a new hand " + Environment.NewLine;
                    }
                    int card = 1;
                    while (card < 6 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    textBoxOnForm.Text += "The stock is out of cards. Game over!" + Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        private bool PullOutBook(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();
            foreach (Values value in booksPulled)
                books.Add(value, player);
            if (player.CardCount == 0)
                return true;
            return false;
        }

        private void Deal()
        {
            stock.Shuffle();

            foreach (Player player in players)
                for (int i = 0; i < 6; i++)
                    player.TakeCard(stock.Deal());

            foreach (Player player in players)
                player.PullOutBooks();
        }

        public string DescribeBooks()
        {
            string describe = "";
            foreach (Values value in books.Keys)
            {
                describe += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
            }
            return describe;
        }

        public string GetWinnerName()
        {
            Dictionary<Player, int> winners = new Dictionary<Player, int>();
            foreach (Player player in players)
            {
                winners.Add(player, 0);
            }

            foreach (Player player in books.Values)
            {
                winners[player]++;
            }
            int maxOfBooks = 0;
            foreach (Player player in winners.Keys)
            {
                if (winners[player] > maxOfBooks)
                    maxOfBooks = winners[player];
            }
            string message = "";
            bool tie = false;
            foreach (Player player in winners.Keys)
            {
                if (winners[player] == maxOfBooks)
                {
                    if (message != "")
                    {
                        message += " and ";
                        tie = true;
                    }
                    message += player.Name;
                }
                message += " whith " + maxOfBooks + " books. ";
            }
            if (tie)
            {
                return "Tie between " + message;
            }
            return message;
        }
    }
}
