using System;

namespace _01___Clown
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave { get { return "большие ботинки"; } }

        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inch tall.");
        }
    }
}
