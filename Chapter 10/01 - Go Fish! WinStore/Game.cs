using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace _01___Go_Fish__WinStore
{
    class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }

        public Game()
        {
            PlayerName = "Ed";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bob", random, this));
            players.Add(new Player("Joe", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        public void ClearProgress()
        {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void AddProgress(string progress)
        {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
        }


        private void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            for (int i = 0; i < 4; i++)
                for (int j = 2; j < 15; j++)
                    stock.AddCard(new Card((Suits)i, (Values)j));
            Hand.Clear();
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

        public void PlayOneRound(int selctedPlayerCard)
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
                        AddProgress(players[i].Name + " drew a new hand ");
                    }
                    int card = 1;
                    while (card < 6 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                OnPropertyChanged("Books");
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    AddProgress("The stock is out of cards. Game over!");
                    AddProgress("The winner is... " + GetWinnerName());
                    ResetGame();
                    return;
                }
            }
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
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
