using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Baseball
{
    class Bat
    {
        private BatCallback hitBallCallback;

        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallback = new BatCallback(hitBallCallback);
        }

        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallback != null)
                hitBallCallback(e);
        }
    }
}
