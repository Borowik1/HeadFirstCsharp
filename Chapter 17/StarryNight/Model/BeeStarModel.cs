using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarryNight.Model
{
    using System.Windows;
    class BeeStarModel
    {
        public static readonly Size StarSize = new Size(150, 100);
        private readonly Dictionary<Bee, Point> _bees = new Dictionary<Bee, Point>();
        private readonly Dictionary<Star, Point> _stars = new Dictionary<Star, Point>();
        private Random _random = new Random();
        private Size _playAreaSize;

        public BeeStarModel()
        {
            _playAreaSize = Size.Empty;
        }
        public void Update()
        {
            MoveOneBee();
            AddOrRemoveAStar();
        }
        private static bool RectsOverlap(Rect r1, Rect r2)
        {
            r1.Intersect(r2);
            if (r1.Width > 0 || r1.Height > 0)
                return true;
            return false;
        }
        public Size PlayAreaSize
        {
            get { return _playAreaSize; }
            set
            {
                _playAreaSize = value;
                CreateBees();
                CreateStars();
            }
        }
        private void CreateBees()
        {
            if (PlayAreaSize == Size.Empty) return;
            if (_bees.Count == 0)
            {
                int beesQnty = _random.Next(5, 15);
                for (int i = 0; i < beesQnty; i++)
                {
                    int s = _random.Next(40, 150);
                    Size beeSize = new Size(s, s);
                    Point point = FindNonOverlappingPoint(beeSize);
                    Bee bee = new Bee(point, beeSize);
                    _bees[bee] = point;
                    OnBeeMoved(bee, point.X, point.Y);
                }
            }
            else
            {
                List<Bee> bees = _bees.Keys.ToList<Bee>();
                foreach (Bee bee in bees)
                {
                    MoveOneBee(bee);
                }
            }
        }
        private void CreateStars()
        {
            if (PlayAreaSize == Size.Empty) return;

            if (_stars.Count == 0)
            {
                int starQnty = _random.Next(5, 10);
                for (int i = 0; i < starQnty; i++)
                {
                    CreateAStar();
                }
            }
            else
            {
                foreach (Star star in _stars.Keys)
                {
                    star.Location = FindNonOverlappingPoint(StarSize);
                    OnStarChanged(star, false);
                }
            }
        }
        private void CreateAStar()
        {
            Point point = FindNonOverlappingPoint(StarSize);
            Star star = new Star(point);
            _stars[star] = point;
            OnStarChanged(star, false);
        }
        private Point FindNonOverlappingPoint(Size size)
        {
            Point point = new Point();
            for (int i = 0; i < 1000; i++)
            {
                point.X = _random.Next((int)PlayAreaSize.Width - 250);
                point.Y = _random.Next((int)PlayAreaSize.Height - 150);
                Rect rect = new Rect(point, size);
                var intersectedBees = from bee in _bees.Keys
                                      where RectsOverlap(rect, new Rect(bee.Location, bee.Size))
                                      select bee;
                var intersectedStars = from star in _stars.Keys
                                       where RectsOverlap(rect, new Rect(star.Location, new Size(StarSize.Height, StarSize.Width)))
                                       select star;
                if (intersectedBees.Count() == 0 && intersectedStars.Count() == 0) return point;
            }
            point.X = 0;
            point.Y = 0;
            return point;
        }
        private void MoveOneBee(Bee bee = null)
        {
            if (_bees.Keys.Count() == 0) return;
            if (bee == null)
            {
                int beeCount = _stars.Count;
                List<Bee> bees = _bees.Keys.ToList();
                bee = bees[_random.Next(bees.Count)];
            }
            bee.Location = FindNonOverlappingPoint(bee.Size);
            _bees[bee] = bee.Location;
            OnBeeMoved(bee, bee.Location.X, bee.Location.Y);
        }
        private void AddOrRemoveAStar()
        {
            if (((_random.Next(2) == 0) || (_stars.Count <= 5)) && (_stars.Count < 20))
                CreateAStar();
            else
            {
                Star starToRemove = _stars.Keys.ToList()[_random.Next(_stars.Count)];
                _stars.Remove(starToRemove);
                OnStarChanged(starToRemove, true);
            }
        }
        public event EventHandler<BeeMovedEventArgs> BeeMoved;
        private void OnBeeMoved(Bee beeThatMoved, double x, double y)
        {
            EventHandler<BeeMovedEventArgs> beeMoved = BeeMoved;
            if (beeMoved != null)
            {
                beeMoved(this, new BeeMovedEventArgs(beeThatMoved, x, y));
            }
        }
        public event EventHandler<StarChangedEventArgs> StarChanged;
        private void OnStarChanged(Star starThatChanged, bool removed)
        {
            EventHandler<StarChangedEventArgs> starChanged = StarChanged;
            if (starChanged != null)
            {
                starChanged(this, new StarChangedEventArgs(starThatChanged, removed));
            }
        }
    }
}
