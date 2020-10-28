using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Covariance
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Pinguins don't fly"); 
        }

        public override string ToString()
        {
            return "Pinguin's name " + base.Name;
        }
    }
}
