using BasketballRoster.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballRoster.ViewModel
{
    class RosterViewModel
    {
        private string _teamName;
        private IEnumerable<Player> _players;
        private Roster _roster;

        public string TeamName
        {
            get
            {
                return _teamName;
            }
            set
            {
                _teamName = value;
            }
        }
        public ObservableCollection<PlayerViewModel> Starters { get; private set; }
        public ObservableCollection<PlayerViewModel> Bench { get; private set; }

        public RosterViewModel(Roster roster)
        {
            _roster = roster;
            TeamName = _roster.TeamName;
            this.Starters = new ObservableCollection<PlayerViewModel>();
            this.Bench = new ObservableCollection<PlayerViewModel>();
            UpdateRosters();
        }

        private void UpdateRosters()
        {
            var startPlayers = from player in _roster.Players
                       where player.Starter == true
                       select player;

            foreach (Player item in startPlayers)
            {
                Starters.Add(new PlayerViewModel(item.Name, item.Number));
            }

            var benchPlayers = from player in _roster.Players
                               where player.Starter == false
                               select player;

            foreach (Player item in benchPlayers)
            {
                Bench.Add(new PlayerViewModel(item.Name, item.Number));
            }
        }
    }
}
