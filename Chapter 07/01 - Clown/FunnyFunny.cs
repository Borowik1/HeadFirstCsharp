using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Clown
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Првет! У меня есть " + funnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
