using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Structures
{
    class Canine
    {
        public string Name;
        public string Breed;

        public Canine(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("My name is {0} and I'm {1}", Name, Breed);
        }

    }
}
