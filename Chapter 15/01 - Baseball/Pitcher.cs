using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Baseball
{
    class Pitcher
    {
        private ObservableCollection<string> pitcherSays = new ObservableCollection<string>();
        public ObservableCollection<string> PitcherSays { get { return pitcherSays; } }
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Distance < 95 && ballEventArgs.Trajectory < 60)
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CoverFirstBase()
        {
            pitcherSays.Add("I covered first base");
        }

        private void CatchBall()
        {
            pitcherSays.Add("I caught the ball");
        }
    }
}
