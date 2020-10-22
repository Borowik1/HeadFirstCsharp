using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Clown
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave { get { return "У меня есть " + numberOfScaryThings + " пауков"; }  }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Ага! Ты не можешь забрать " + base.funnyThingIHave);
        }
    }
}
