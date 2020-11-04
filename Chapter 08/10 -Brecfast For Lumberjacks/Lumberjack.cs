using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10__Brecfast_For_Lumberjacks
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(Lumberjack lumberjack)
        {
            this.name = lumberjack.Name;
            meal = new Stack<Flapjack>();
            this.meal = lumberjack.meal;
        }
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack Food, int HowMany)
        {
            for (int i = 1; i <= HowMany; i++)
                meal.Push(Food);
        }
        public void EatFlapjacs()
        {
            Console.WriteLine(Name + "'s eating flapjacks");
            while (meal.Count != 0)
                Console.WriteLine(Name + " eat a " + meal.Pop().ToString().ToLower() + " flapjack");


        }
    }
}
