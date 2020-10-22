using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Clown
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
            Console.Read();

            //ScaryScary fingersTheClown = new ScaryScary("большие ботинки", 14);
            //FunnyFunny someFunnyClown = fingersTheClown;
            //IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            //someOtherScaryClown.Honk();

            IScaryClown someOtherScaryClown = new ScaryScary("большие ботинки", 14);            
            someOtherScaryClown.Honk();


        }
    }
}
