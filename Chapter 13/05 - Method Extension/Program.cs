using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Method_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman(185);
            Console.WriteLine(steve.BreakWalls(89.2));
        }
        sealed class OrdinaryHuman
        {
            private int age;
            int weight;

            public OrdinaryHuman(int weight)
            {
                this.weight = weight;
            }
            public void GoToWork() { }
            public void PayBills() { }
        }

        static class SuperSolderSerum
        {
            public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
            {
                return ("Я сломал стену плотностью" + wallDensity + ".");
            }
        }

    }
}
