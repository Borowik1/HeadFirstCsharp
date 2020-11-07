using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Baseball
{
    class Fan
    {
        private ObservableCollection<string> fanSays = new ObservableCollection<string>();
        public ObservableCollection<string> FanSays { get { return fanSays; } }
        public Fan(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            BallEventArgs ballEventArgs = e as BallEventArgs;
            if (ballEventArgs.Distance > 400 && ballEventArgs.Trajectory > 30)
                fanSays.Add("Home run! I'm going for the ball!");
            else
                fanSays.Add("Woo-hoo! Yeah!");
        }
    }
}
