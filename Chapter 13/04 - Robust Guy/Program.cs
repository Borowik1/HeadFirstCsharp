using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Robust_Guy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date of birth:");
            string birthday = Console.ReadLine();

            Console.WriteLine("Enter height in cm:");
            string height = Console.ReadLine();

            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.Read();
        }
    }
}
